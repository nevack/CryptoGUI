using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoGUI
{
    public partial class TextEdit : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                saveAndExit();
            }
            else if (keyData == Keys.Escape) this.Close();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public string text { get; set; }

        public TextEdit(String content)
        {
            InitializeComponent();
            textField.Text = content;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveAndExit();
        }

        private void saveAndExit()
        {
            text = textField.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
