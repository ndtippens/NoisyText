using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace NoisyText {
    public partial class VideoOut : Form {
        private bool update = false;
        // keep pointer to Controller object
        private Controller Ctrl;

        // array of bitmaps makes up our movie
        private Bitmap[] NoiseLoop;
        private int FrameNum = 0;
        private Brush TextBrush;
        private Rectangle MyTextRect = new Rectangle(50, 50, 700, 500);

        // parameters that are read from Controller object
        private int Delta = 3;
        private int MovieLength = 10;
        private int NoiseSize = 2;
        private Font MyFont;
        private StreamReader FileIn;
        private Queue<String> MyTextBuf = new Queue<String>();
        private String CurrentLine;

        private bool HozScroll;
        private bool ReplayText;
        private bool AutoScrollText = true;
        private bool NoisyBack = true;
        private bool NoisyFore = false;

        // If not noisy, what color?
        private Color BackFill = Color.Black;
        private Color ForeFill = Color.White;



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ctrl">The Controller window for this video stream.</param>
        public VideoOut(Controller c) {
            Ctrl = c;

            InitializeComponent();

            // video optimization flags
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }


        private void VideoOut_Shown(object sender, EventArgs e) {
            Timer.Start();
        }


        /// <summary>
        /// Read video preferences from Controller.
        /// </summary>
        public void ReadPreferences() {
            NoiseSize = (int)Ctrl.NoiseSizeBox.Value;
            MyFont = Ctrl.FontDialog.Font;

            HozScroll = Ctrl.HozScrollBox.Checked;
            ReplayText = Ctrl.ReplayTextBox.Checked;

            NoisyBack = Ctrl.BackStyleBox.Text == "Noise";
            NoisyFore = Ctrl.TextStyleBox.Text == "Noise";
            if (!NoisyBack)
                BackFill = Color.FromName(Ctrl.BackStyleBox.Text);
            if (!NoisyFore)
                ForeFill = Color.FromName(Ctrl.TextStyleBox.Text);

            if (Ctrl.FrameRateBox.SelectedText == "15 FPS")
                MovieLength = 15;
            else
                MovieLength = 30;

            Timer.Interval = 500 / MovieLength;

            try {
                FileIn = new StreamReader(Ctrl.SourceFileDialog.OpenFile());
            }
            catch (Exception ex) {
                // Let the user know what went wrong.
                MessageBox.Show("The file could not be read:\n" + ex.Message);
            }

            if (NoisyFore || NoisyBack)
                GenerateNoise();
            FrameNum = 0;
        }


        /// <summary>
        /// Method to repaint this screen.
        /// </summary>
        public void repaint(object sender, PaintEventArgs e) {

            if (MyTextBuf.Count == 0) {
                ReadStream();
                UpdateMyText(e);
            }

            if (NoisyBack)
                e.Graphics.DrawImage(NoiseLoop[FrameNum], this.DisplayRectangle);
            else
                e.Graphics.FillRectangle(new SolidBrush(BackFill), 0, 0, Width, Height);

            if (NoisyFore)
                TextBrush = new TextureBrush(NoiseLoop[FrameNum]);
            else
                TextBrush = new SolidBrush(ForeFill);

            if (HozScroll) {
                if( AutoScrollText )
                    MyTextRect.X -= Delta;
                if (MyTextRect.X < 150 - MyTextRect.Width)
                    UpdateMyText(e);
                e.Graphics.DrawString(CurrentLine, MyFont, TextBrush, MyTextRect.Location);
            }
            else {
                if (AutoScrollText)
                    MyTextRect.Y -= Delta;
                if (MyTextRect.Y < (-50 - MyTextRect.Height))
                    UpdateMyText(e);
                e.Graphics.DrawString(CurrentLine, MyFont, TextBrush, MyTextRect);
            }
        }

        private void UpdateMyText(PaintEventArgs e) {
            try {
                CurrentLine = MyTextBuf.Dequeue();
            }
            catch (Exception) {
                Close();
            }

            if (HozScroll) {
                MyTextRect.X = Width;
                MyTextRect.Y = (int)((Height / 2) - MyFont.Size);
                MyTextRect.Size = Size.Ceiling(e.Graphics.MeasureString(CurrentLine, MyFont));
            }
            else {
                MyTextRect.X = (int)MyFont.Size;
                MyTextRect.Y = Height;
                MyTextRect.Width = Width - 2 * (int)MyFont.Size;
                MyTextRect.Height = Size.Ceiling(e.Graphics.MeasureString(CurrentLine, MyFont, MyTextRect.Width)).Height;
            }
        }

        ///<summary>
        /// Read in 100 lines of text from the user-specified text file.
        /// Loops after reaching the end of the file.
        ///</summary>
        private void ReadStream() {
            int n = 100;
            String s = "";

            // Enqueue 100 lines to be displayed.
            while ((CurrentLine = FileIn.ReadLine()) != null && --n != -1) {
                s = "";
                CurrentLine = CurrentLine.Trim();
                if (CurrentLine.Length == 0) {
                    if (HozScroll)
                        s += "   \\";
                }
                else
                    s += CurrentLine;
                MyTextBuf.Enqueue(s);
            }
            if (FileIn.EndOfStream) {
                if (HozScroll)
                    MyTextBuf.Enqueue("      \\\\ END OF TEXT \\\\       ");
                else
                    MyTextBuf.Enqueue("END OF TEXT");

                if (!ReplayText)
                    return;

                try {
                    FileIn = new StreamReader(Ctrl.SourceFileDialog.OpenFile());
                }
                catch (Exception ex) {
                    // Let the user know what went wrong.
                    MessageBox.Show("The file could not be read:\n" + ex.Message);
                }
            }
        }


        /// <summary>
        /// Generates a movie of random noise.
        /// Method:
        /// 1) Copy random bytes into a bitmap image.
        /// 2) Scale image up by a factor of NoiseSize, so that 1x1 noise becomes NxN noise.
        /// </summary>
        private void GenerateNoise() {
            // determine width and height of noise image to be generated
            int nwidth, nheight;
            if (NoisyFore) {
                nwidth = DisplayRectangle.Width / NoiseSize;
                nheight = DisplayRectangle.Height / NoiseSize;
            }
            else {
                nwidth = Width / NoiseSize + 1;
                nheight = Height / NoiseSize + 1;
            }

            Graphics gr;
            NoiseLoop = new Bitmap[MovieLength];
            Bitmap[] loop = new Bitmap[MovieLength];
            Rectangle FrameRect = new Rectangle(0, 0, nwidth, nheight);
            System.Drawing.Imaging.BitmapData bitdata;

            for (FrameNum = 0; FrameNum < MovieLength; FrameNum++) {
                // Each frame needs to have a different random seed, so we make the seed
                // a function of FrameNum.
                Random r = new Random(FrameNum * Width * Height);
                loop[FrameNum] = new Bitmap(nwidth, nheight, System.Drawing.Imaging.PixelFormat.Format1bppIndexed);

                // 50% noise
                bitdata = loop[FrameNum].LockBits(FrameRect, System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format1bppIndexed);
                IntPtr ptr = bitdata.Scan0;
                int bytes = Math.Abs(bitdata.Stride) * bitdata.Height;
                byte[] RawValues = new byte[bytes];
                r.NextBytes(RawValues);
                System.Runtime.InteropServices.Marshal.Copy(RawValues, 0, ptr, bytes);
                loop[FrameNum].UnlockBits(bitdata);

                NoiseLoop[FrameNum] = new Bitmap(DisplayRectangle.Width, DisplayRectangle.Height);
                gr = Graphics.FromImage(NoiseLoop[FrameNum]);
                // We don't want any smoothing when scaling up the noise.
                gr.InterpolationMode = InterpolationMode.NearestNeighbor;
                gr.DrawImage(loop[FrameNum], new Rectangle(0, 0, DisplayRectangle.Width, DisplayRectangle.Height));
            }
        }


        /// <summary>
        /// Esc   :  Cancel
        /// Space :  Cancel
        /// Enter :  Cancel
        /// Up    :  Increase text scroll speed
        /// Down  :  Decrease text scroll speed
        /// </summary>
        private void NoisyText_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {

                case Keys.Escape:
                    Close();
                    break;

                case Keys.Down:
                    if (Delta > 0)
                        --Delta;
                    break;

                case Keys.Up:
                    if (Delta < 60)
                        ++Delta;
                    break;


                case Keys.Space:
                case Keys.Enter:
                    AutoScrollText = !AutoScrollText;
                    break;

                default:
                    break;
            }
        }


        /// <summary>
        /// Update FrameNumber and force redraw at every timer tick.
        /// </summary>
        private void Timer_Tick(object sender, EventArgs e) {
            if (update)
                FrameNum++;
            else
                update = true;
            if (FrameNum == MovieLength)
                FrameNum = 0;

            // force redraw
            Invalidate();
        }


        /// <summary>
        /// Stop movie loop when the dialog closes.
        /// </summary>
        private void VideoOut_FormClosing(object sender, FormClosingEventArgs e) {
            Timer.Stop();
            FileIn.Dispose();
            MyTextBuf.Clear();
        }


    }
}
