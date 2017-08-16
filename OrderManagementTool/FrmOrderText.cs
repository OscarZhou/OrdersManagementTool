using System;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class FrmOrderText : Form
    {
        public FrmOrderText()
        {
            InitializeComponent();

            // Add key down event
            KeyDown += FrmOrderText_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += FrmOrderText_KeyDown;
        }

        public void Receiver(string content)
        {
            tbOrderContent.Text = content;
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (tbOrderContent.Text != "")
            {
                Clipboard.SetDataObject(tbOrderContent.Text);
                tbOrderContent.Focus();
                MessageBox.Show("Copy to clipboard!");
            }
        }

        private void FrmOrderText_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;

                default:
                    break;
            }
        }
    }
}