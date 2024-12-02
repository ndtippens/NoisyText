using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoisyText
{
    public partial class Controller : Form
    {
        // Allocate a VideoOutput object
        private static VideoOut VidOut;



        public Controller()
        {
            InitializeComponent();
            VidOut = new VideoOut( this );
        }

        private void Controller_FormClosing(object sender, FormClosingEventArgs e)
        {
            NoisyText.Properties.Settings.Default.Save();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            VidOut.ReadPreferences();
            VidOut.ShowDialog();
        }


        private void ChooseFontButton_Click(object sender, EventArgs e)
        {
            FontDialog.ShowDialog();
        }


        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            SourceFileDialog.ShowDialog();
        }

        private void SourceFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            NoisyText.Properties.Settings.Default.MyFileName = SourceFileDialog.FileName;
        }

    }
}
