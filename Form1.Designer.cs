namespace PAK_Manipulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            extractButton = new Button();
            convQ = new CheckBox();
            button1 = new Button();
            pakFilesFolder = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            assetContextText = new TextBox();
            assetCheckBox = new CheckBox();
            gameSelect = new ComboBox();
            splitPab = new CheckBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button6 = new Button();
            pakFileSave = new TextBox();
            label5 = new Label();
            button3 = new Button();
            pakFolderToCompile = new TextBox();
            label4 = new Label();
            openPakFile = new OpenFileDialog();
            label3 = new Label();
            textLog = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            savePakFile = new SaveFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(558, 277);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(extractButton);
            tabPage1.Controls.Add(convQ);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pakFilesFolder);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(550, 244);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PAK Extract";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // extractButton
            // 
            extractButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            extractButton.Location = new Point(457, 204);
            extractButton.Margin = new Padding(3, 4, 3, 4);
            extractButton.Name = "extractButton";
            extractButton.Size = new Size(86, 31);
            extractButton.TabIndex = 16;
            extractButton.Text = "Extract";
            extractButton.UseVisualStyleBackColor = true;
            extractButton.Click += button5_Click;
            // 
            // convQ
            // 
            convQ.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            convQ.AutoSize = true;
            convQ.Checked = true;
            convQ.CheckState = CheckState.Checked;
            convQ.Location = new Point(3, 209);
            convQ.Margin = new Padding(3, 4, 3, 4);
            convQ.Name = "convQ";
            convQ.Size = new Size(185, 24);
            convQ.TabIndex = 15;
            convQ.Text = "Convert .qb files to text";
            convQ.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(457, 28);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 11;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pakFilesFolder
            // 
            pakFilesFolder.AllowDrop = true;
            pakFilesFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pakFilesFolder.Location = new Point(3, 28);
            pakFilesFolder.Margin = new Padding(3, 4, 3, 4);
            pakFilesFolder.Name = "pakFilesFolder";
            pakFilesFolder.Size = new Size(446, 27);
            pakFilesFolder.TabIndex = 10;
            pakFilesFolder.DragDrop += textBox_DragDrop;
            pakFilesFolder.DragEnter += textBox_DragEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 9;
            label1.Text = "Folder Containing PAK Files";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(assetContextText);
            tabPage2.Controls.Add(assetCheckBox);
            tabPage2.Controls.Add(gameSelect);
            tabPage2.Controls.Add(splitPab);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(pakFileSave);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(pakFolderToCompile);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(550, 244);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "PAK Compile";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // assetContextText
            // 
            assetContextText.Enabled = false;
            assetContextText.Location = new Point(3, 149);
            assetContextText.Margin = new Padding(3, 4, 3, 4);
            assetContextText.Name = "assetContextText";
            assetContextText.Size = new Size(199, 27);
            assetContextText.TabIndex = 26;
            // 
            // assetCheckBox
            // 
            assetCheckBox.AutoSize = true;
            assetCheckBox.Location = new Point(3, 125);
            assetCheckBox.Margin = new Padding(3, 4, 3, 4);
            assetCheckBox.Name = "assetCheckBox";
            assetCheckBox.Size = new Size(121, 24);
            assetCheckBox.TabIndex = 25;
            assetCheckBox.Text = "Asset Context";
            assetCheckBox.UseVisualStyleBackColor = true;
            assetCheckBox.CheckedChanged += assetCheckBox_CheckedChanged;
            // 
            // gameSelect
            // 
            gameSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            gameSelect.FormattingEnabled = true;
            gameSelect.Items.AddRange(new object[] { "GH3", "GHWT" });
            gameSelect.Location = new Point(301, 204);
            gameSelect.Margin = new Padding(3, 4, 3, 4);
            gameSelect.Name = "gameSelect";
            gameSelect.Size = new Size(149, 28);
            gameSelect.TabIndex = 24;
            gameSelect.Text = "Select Game";
            // 
            // splitPab
            // 
            splitPab.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            splitPab.AutoSize = true;
            splitPab.Location = new Point(210, 208);
            splitPab.Margin = new Padding(3, 4, 3, 4);
            splitPab.Name = "splitPab";
            splitPab.Size = new Size(91, 24);
            splitPab.TabIndex = 23;
            splitPab.Text = "Split PAB";
            splitPab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(3, 188);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(200, 47);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Console";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Enabled = false;
            radioButton3.Location = new Point(143, 19);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(54, 24);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "PS2";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(86, 19);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 24);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "PS3";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(7, 19);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(77, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "360/PC";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.Location = new Point(457, 204);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 21;
            button6.Text = "Compile";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // pakFileSave
            // 
            pakFileSave.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pakFileSave.Location = new Point(3, 87);
            pakFileSave.Margin = new Padding(3, 4, 3, 4);
            pakFileSave.Name = "pakFileSave";
            pakFileSave.ReadOnly = true;
            pakFileSave.Size = new Size(446, 27);
            pakFileSave.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 63);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 18;
            label5.Text = "Save Location";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(457, 28);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 17;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pakFolderToCompile
            // 
            pakFolderToCompile.AllowDrop = true;
            pakFolderToCompile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pakFolderToCompile.Location = new Point(3, 28);
            pakFolderToCompile.Margin = new Padding(3, 4, 3, 4);
            pakFolderToCompile.Name = "pakFolderToCompile";
            pakFolderToCompile.Size = new Size(446, 27);
            pakFolderToCompile.TabIndex = 16;
            pakFolderToCompile.TextChanged += pakFolderToCompile_TextChanged;
            pakFolderToCompile.DragDrop += textBox_DragDrop;
            pakFolderToCompile.DragEnter += textBox_DragEnter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 15;
            label4.Text = "Extract Folder";
            // 
            // openPakFile
            // 
            openPakFile.CheckFileExists = false;
            openPakFile.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 303);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 1;
            label3.Text = "Log";
            // 
            // textLog
            // 
            textLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textLog.Location = new Point(14, 327);
            textLog.Margin = new Padding(3, 4, 3, 4);
            textLog.Multiline = true;
            textLog.Name = "textLog";
            textLog.ReadOnly = true;
            textLog.Size = new Size(557, 348);
            textLog.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 692);
            Controls.Add(textLog);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "PAK Manipulator";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private OpenFileDialog openPakFile;
        private Button button1;
        private TextBox pakFilesFolder;
        private Label label1;
        private Label label3;
        private TextBox textLog;
        private CheckBox convQ;
        private TextBox pakFileSave;
        private Label label5;
        private Button button3;
        private TextBox pakFolderToCompile;
        private Label label4;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button extractButton;
        private Button button6;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private SaveFileDialog savePakFile;
        private CheckBox splitPab;
        private ComboBox gameSelect;
        private TextBox assetContextText;
        private CheckBox assetCheckBox;
    }
}
