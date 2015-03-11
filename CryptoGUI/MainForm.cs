using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoGUI
{
    public partial class MainForm : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.D1))
            {
                radioEncrypt.Checked = true;
            }
            else if (keyData == (Keys.Alt | Keys.D2))
            {
                radioDecrypt.Checked = true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonShowFile_Click(object sender, EventArgs e)
        {
            buttonShowFile.Visible = false;
            buttonOpen.Visible = true;
            buttonSave.Visible = true;
        }

        private void openFile(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textSource.Text = File.ReadAllText(dialog.FileName);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error, while reading the file", "File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveFile(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(textResult.Text, dialog.FileName);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error, while reading the file", "File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void exitApplication(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void generateKey(object sender, EventArgs e)
        {
            Random random = new Random();
            textKey.Text = random.Next(1000000, 9999999).ToString();
        }

        private void swapTexts(object sender, EventArgs e)
        {
            string temp = textSource.Text;
            textSource.Text = textResult.Text;
            textResult.Text = temp;
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.Show();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (textKey.Text == "" || textSource.Text == "")
            {
                MessageBox.Show("Text or key fields are empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cryptProcess();
            }
        }

        private void keyNumbers(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Back && !Char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            } 
            else if (e.KeyChar == (char) Keys.Enter)
            {
                cryptProcess();
                e.Handled = true;
            }
        }

        private void cryptProcess()
        {
            if (textKey.Text != "")
            {
                int key = int.Parse(textKey.Text);
                int token = 0;
                char[] letters = textSource.Text.ToCharArray();

                while (key != 0)
                {
                    if ((key % 10) % 2 == 0) token += key % 10;
                    else token -= key % 10;
                    key /= 10;
                }

                if (radioEncrypt.Checked)
                {
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (char.IsControl(letters[i]))
                        {
                            if (((int)letters[i] + token) > 255)
                            {
                                letters[i] = (char)((int)letters[i] + token - 256);
                            }
                            else if (((int)letters[i] + token) < 0)
                            {
                                letters[i] = (char)((int)letters[i] + token + 256);
                            }
                            else letters[i] += (char)token;
                        }
                    }
                }

                if (radioDecrypt.Checked)
                {
                    for (int i = 0; i < letters.Length; i++)
                    {
                        if (char.IsControl(letters[i]))
                        {
                            if (((int)letters[i] - token) < 0)
                            {
                                letters[i] = (char)((int)letters[i] + token + 256);
                            }
                            else if (((int)letters[i] - token) > 255)
                            {
                                letters[i] = (char)((int)letters[i] + token - 256);
                            }
                            else letters[i] -= (char)token;
                        }
                    }
                }

                textResult.Text = new string(letters);
            }
            else MessageBox.Show("Key field is empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textSource_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelSymbolsCount.Text = textSource.Text.Length.ToString();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            buttonOpen.Visible = buttonSave.Visible = false;
            buttonShowFile.Visible = true;
        }

        private void textContextMenuClear_Click(object sender, EventArgs e)
        {
            textSource.Text = "";
        }

        private void textSourceContextMenuNewWindow_Click(object sender, EventArgs e)
        {
            using (TextEdit textEdit = new TextEdit(textSource.Text))
            {
                if (textEdit.ShowDialog() == DialogResult.OK)
                {
                    this.textSource.Text = textEdit.text;
                }
            }
        }
    }
}
