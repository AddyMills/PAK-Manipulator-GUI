using GH_Toolkit_Core.PAK;
using static GH_Toolkit_Core.PAK.PAK;

namespace PAK_Manipulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (RadioButton rb in groupBox1.Controls.OfType<RadioButton>())
            {
                rb.CheckedChanged += ChangeConsole;
            }
        }

        // Install a new output TextWriter for the Console window.
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(textLog);
            Console.SetOut(writer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pakFilesFolder.Text = folderBrowserDialog1.SelectedPath;
                SetPakOutput();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pakFolderToCompile.Text = folderBrowserDialog1.SelectedPath;
                SetPakOutput();
            }
        }
        private void ChangeConsole(object sender, EventArgs e)
        {
            // Call SetPakOutput whenever any radio button's checked state changes
            SetPakOutput();
        }
        private void SetPakOutput()
        {
            if (pakFolderToCompile.Text == "")
            {
                pakFileSave.Text = "";
                return;
            }
            string extension;
            if (radioButton1.Checked)
            {
                extension = ".pak.xen";
            }
            else if (radioButton2.Checked)
            {
                extension = ".pak.ps3";
            }
            else if (radioButton3.Checked)
            {
                extension = ".pak.ps2";
            }
            else
            {
                extension = ".pak";
            }
            pakFileSave.Text = $"{pakFolderToCompile.Text}{extension}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pakFilesFolder.Text == "")
            {
                MessageBox.Show("Please select a folder containing PAK files to unpack.");
                return;
            }
            else
            {

                List<string> files = GetFilesFromFolder(pakFilesFolder.Text);
                foreach (string file in files)
                {
                    try
                    {
                        ProcessPAKFromFile(file, convQ.Checked);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Extraction failed: {ex.Message}");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pakFolderToCompile.Text == "")
            {
                MessageBox.Show("Please select a folder containing files to compile.");
                return;
            }
            string game = gameSelect.Text;
            if (!game.StartsWith("GH"))
            {
                MessageBox.Show("Please select a game.");
                return;
            }
            string console = SetConsole();
            string? assetContext = assetContextText.Text == "" ? null : assetContextText.Text;
            PakCompiler pakCompiler = new PAK.PakCompiler(game, console, assetContext, false, splitPab.Checked);
            var (pak, pab, other) = pakCompiler.CompilePAK(pakFolderToCompile.Text);
            string pakPath = pakFileSave.Text;
            string pabPath = pakPath.Replace(".pak", ".pab");
            try
            {
                if (pab != null)
                {
                    using (FileStream pakFile = new FileStream(pakPath, FileMode.Create, FileAccess.Write))
                    using (FileStream pabFile = new FileStream(pabPath, FileMode.Create, FileAccess.Write))
                    {
                        pakFile.Write(pak);
                        pabFile.Write(pab);
                    }
                }
                else
                {
                    using (FileStream pakFile = new FileStream(pakPath, FileMode.Create, FileAccess.Write))
                    {
                        pakFile.Write(pak);
                        pakFile.Write(pab);
                    }
                }
                Console.WriteLine("PAK compiled successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Compile failed: {ex.Message}");
            }
        }

        private string SetConsole()
        {
            if (radioButton3.Checked)
            {
                return "PS2";
            }
            else
            {
                return "360";
            }
        }

        private void assetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Enable the asset context textbox if the checkbox is checked
            assetContextText.Enabled = assetCheckBox.Checked;
            if (!assetCheckBox.Checked)
            {
                // Clear the contents of the textbox if the checkbox is unchecked
                assetContextText.Clear();
            }
        }
    }
}
