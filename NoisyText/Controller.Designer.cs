namespace NoisyText
{
    partial class Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChooseFontButton = new System.Windows.Forms.Button();
            this.ReplayTextBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.BackStyleBox = new System.Windows.Forms.ComboBox();
            this.TextStyleBox = new System.Windows.Forms.ComboBox();
            this.HozScrollBox = new System.Windows.Forms.CheckBox();
            this.FrameRateBox = new System.Windows.Forms.ComboBox();
            this.NoiseSizeBox = new System.Windows.Forms.NumericUpDown();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.SourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseSizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.Controls.Add(this.ChooseFileButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BackStyleBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextStyleBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChooseFontButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ReplayTextBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.HozScrollBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.FrameRateBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.NoiseSizeBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(288, 357);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileButton.Location = new System.Drawing.Point(135, 88);
            this.ChooseFileButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(121, 23);
            this.ChooseFileButton.TabIndex = 9;
            this.ChooseFileButton.Text = "Choose file...";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text Source";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Font";
            // 
            // ChooseFontButton
            // 
            this.ChooseFontButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChooseFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFontButton.Location = new System.Drawing.Point(135, 128);
            this.ChooseFontButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ChooseFontButton.Name = "ChooseFontButton";
            this.ChooseFontButton.Size = new System.Drawing.Size(121, 23);
            this.ChooseFontButton.TabIndex = 4;
            this.ChooseFontButton.Text = "Choose font...";
            this.ChooseFontButton.UseVisualStyleBackColor = true;
            this.ChooseFontButton.Click += new System.EventHandler(this.ChooseFontButton_Click);
            // 
            // ReplayTextBox
            // 
            this.ReplayTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ReplayTextBox.AutoSize = true;
            this.ReplayTextBox.Checked = global::NoisyText.Properties.Settings.Default.ReplayText;
            this.ReplayTextBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReplayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NoisyText.Properties.Settings.Default, "ReplayText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ReplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReplayTextBox.Location = new System.Drawing.Point(135, 326);
            this.ReplayTextBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.ReplayTextBox.Name = "ReplayTextBox";
            this.ReplayTextBox.Size = new System.Drawing.Size(111, 24);
            this.ReplayTextBox.TabIndex = 15;
            this.ReplayTextBox.Text = "Replay Text";
            this.ReplayTextBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Noise Speed";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Noise Size";
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(32, 393);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(243, 40);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // BackStyleBox
            // 
            this.BackStyleBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackStyleBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NoisyText.Properties.Settings.Default, "BackStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.BackStyleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackStyleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackStyleBox.FormattingEnabled = true;
            this.BackStyleBox.Items.AddRange(new object[] {
            "Noise",
            "Black",
            "White"});
            this.BackStyleBox.Location = new System.Drawing.Point(135, 6);
            this.BackStyleBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.BackStyleBox.Name = "BackStyleBox";
            this.BackStyleBox.Size = new System.Drawing.Size(121, 28);
            this.BackStyleBox.TabIndex = 1;
            this.BackStyleBox.Text = global::NoisyText.Properties.Settings.Default.BackStyle;
            // 
            // TextStyleBox
            // 
            this.TextStyleBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextStyleBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NoisyText.Properties.Settings.Default, "TextStyle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextStyleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextStyleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStyleBox.FormattingEnabled = true;
            this.TextStyleBox.Items.AddRange(new object[] {
            "Noise",
            "Black",
            "White"});
            this.TextStyleBox.Location = new System.Drawing.Point(135, 46);
            this.TextStyleBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.TextStyleBox.Name = "TextStyleBox";
            this.TextStyleBox.Size = new System.Drawing.Size(121, 28);
            this.TextStyleBox.TabIndex = 2;
            this.TextStyleBox.Text = global::NoisyText.Properties.Settings.Default.TextStyle;
            // 
            // HozScrollBox
            // 
            this.HozScrollBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HozScrollBox.AutoSize = true;
            this.HozScrollBox.Checked = global::NoisyText.Properties.Settings.Default.HozScrollText;
            this.HozScrollBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HozScrollBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::NoisyText.Properties.Settings.Default, "HozScrollText", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.HozScrollBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HozScrollBox.Location = new System.Drawing.Point(135, 288);
            this.HozScrollBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.HozScrollBox.Name = "HozScrollBox";
            this.HozScrollBox.Size = new System.Drawing.Size(144, 24);
            this.HozScrollBox.TabIndex = 14;
            this.HozScrollBox.Text = "Horizontal Mode";
            this.HozScrollBox.UseVisualStyleBackColor = true;
            // 
            // FrameRateBox
            // 
            this.FrameRateBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FrameRateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::NoisyText.Properties.Settings.Default, "NoiseSpeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FrameRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FrameRateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrameRateBox.FormattingEnabled = true;
            this.FrameRateBox.Items.AddRange(new object[] {
            "15 FPS",
            "30 FPS"});
            this.FrameRateBox.Location = new System.Drawing.Point(135, 246);
            this.FrameRateBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.FrameRateBox.Name = "FrameRateBox";
            this.FrameRateBox.Size = new System.Drawing.Size(121, 28);
            this.FrameRateBox.TabIndex = 6;
            this.FrameRateBox.Text = global::NoisyText.Properties.Settings.Default.NoiseSpeed;
            // 
            // NoiseSizeBox
            // 
            this.NoiseSizeBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoiseSizeBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::NoisyText.Properties.Settings.Default, "NoiseSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NoiseSizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiseSizeBox.Location = new System.Drawing.Point(135, 207);
            this.NoiseSizeBox.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.NoiseSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NoiseSizeBox.Name = "NoiseSizeBox";
            this.NoiseSizeBox.Size = new System.Drawing.Size(47, 26);
            this.NoiseSizeBox.TabIndex = 5;
            this.NoiseSizeBox.Value = global::NoisyText.Properties.Settings.Default.NoiseSize;
            // 
            // FontDialog
            // 
            this.FontDialog.AllowVerticalFonts = false;
            this.FontDialog.Font = global::NoisyText.Properties.Settings.Default.MyFont;
            this.FontDialog.FontMustExist = true;
            this.FontDialog.MaxSize = 500;
            this.FontDialog.MinSize = 24;
            this.FontDialog.ScriptsOnly = true;
            this.FontDialog.ShowEffects = false;
            // 
            // SourceFileDialog
            // 
            this.SourceFileDialog.DefaultExt = "txt";
            this.SourceFileDialog.FileName = global::NoisyText.Properties.Settings.Default.MyFileName;
            this.SourceFileDialog.Filter = "Text files|*.txt";
            this.SourceFileDialog.ReadOnlyChecked = true;
            this.SourceFileDialog.Title = "Select text source...";
            this.SourceFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SourceFileDialog_FileOk);
            // 
            // Controller
            // 
            this.AcceptButton = this.StartButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 444);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Controller";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Noisy Text v0.9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoiseSizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox BackStyleBox;
        public System.Windows.Forms.ComboBox TextStyleBox;
        public System.Windows.Forms.ComboBox FrameRateBox;
        public System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.Button ChooseFontButton;
        public System.Windows.Forms.NumericUpDown NoiseSizeBox;
        private System.Windows.Forms.Button ChooseFileButton;
        public System.Windows.Forms.CheckBox HozScrollBox;
        public System.Windows.Forms.OpenFileDialog SourceFileDialog;
        public System.Windows.Forms.CheckBox ReplayTextBox;

    }
}