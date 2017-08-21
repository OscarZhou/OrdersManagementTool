using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class CalculatePriceKitPage : Form
    {
        #region Delegate for moving item to the ItemCreation DataGridView

        public delegate void DlgMoveItem(Item objItem);

        public DlgMoveItem EvtMoveItem;        

        #endregion

        public CalculatePriceKitPage()
        {
            InitializeComponent();
            this.dgvPriceHistory.AutoGenerateColumns = false;
            lbError.Visible = false;
            lbError.ForeColor = System.Drawing.Color.Red;
            ReadBrowsingHistory();
            // Add key down event
            this.KeyDown += CalculatePriceKitPage_KeyDown;
            foreach (Control control in this.Controls)
            {
                control.KeyDown += CalculatePriceKitPage_KeyDown;
            }
        }

        public void ReadBrowsingHistory()
        {
            List<Item> objItems = ExportFile.ReadItemsFromBrowseHistoryFile(@"BrowsingHistory.txt");
            // Implement the select Top 20 order by CreateTime desc using Linq 
            //Distinct is used for removing the repeated records
            var lstTop20 = (from t in objItems orderby t.CreateTime descending select t).Distinct(new ItemNoComparer()).Take(20);
            dgvPriceHistory.DataSource = null;
            dgvPriceHistory.DataSource = lstTop20.ToList();
            dgvPriceHistory.Show();

        }

        #region The validation of inputing text

        private void ShowError(string tips, TextBox tbBox, Label lbError)
        {
            lbError.Text = tips;
            lbError.Visible = true;
            tbBox.Text = "";
            tbBox.BackColor = System.Drawing.Color.LightCoral;
            tbBox.Focus();
        }

        private void HideError(TextBox tbBox, Label lbError)
        {
            lbError.Visible = false;
            tbBox.BackColor = System.Drawing.Color.White;
        }

        #endregion

        private void cboExchangeRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            #region Validation

            if (tbNZPrice.Text.Trim().Length == 0)
            {
                this.ShowError("Please fill the blank", tbNZPrice, lbError);
                return;

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbNZPrice.Text, "[^0-9]"))
            {
                this.ShowError("Please input only number", tbNZPrice, lbError);
                return;
            }
            else
            {
                this.HideError(tbNZPrice, lbError);
                lbResult.Text = tbNZPrice.Text.Trim();
            }

            #endregion


            if (cboExchangeRate.SelectedItem != null && tbNZPrice.Text.Trim().Length != 0)
            {
                double price = Convert.ToDouble(tbNZPrice.Text.Trim());

                lbResult.Text = (price * Convert.ToDouble(cboExchangeRate.SelectedItem)).ToString("0.00");
                cboProfitMargin.SelectedIndex = -1;
            }
        }

        private void cboProfitMargin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            #region Validation

            if (tbNZPrice.Text.Trim().Length == 0)
            {
                this.ShowError("Please fill the blank", tbNZPrice, lbError);
                return;

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbNZPrice.Text, "[^0-9]"))
            {
                this.ShowError("Please input only number", tbNZPrice, lbError);
                return;
            }
            else
            {
                this.HideError(tbNZPrice, lbError);
                lbResult.Text = tbNZPrice.Text.Trim();
            }

            #endregion

            if (cboProfitMargin.SelectedItem != null && cboExchangeRate.SelectedItem != null && tbNZPrice.Text.Trim().Length != 0)
            {
                double price = Convert.ToDouble(tbNZPrice.Text.Trim());
                price = price * Convert.ToDouble(cboExchangeRate.SelectedItem);
                lbResult.Text = Math.Round(price * Convert.ToDouble(cboProfitMargin.SelectedItem)).ToString("0.00");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbResult.Text = tbNZPrice.Text.Trim();
            cboExchangeRate.SelectedIndex = -1;
            cboProfitMargin.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Validation controls
            if (tbItem.Text.Trim().Length == 0)
            {
                this.ShowError("Please fill the blank", tbItem, lbError);
                return;

            }
            else
            {
                this.HideError(tbItem, lbError);
            }


            if (tbNZPrice.Text.Trim().Length == 0)
            {
                this.ShowError("Please fill the blank", tbNZPrice, lbError);
                return;

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tbNZPrice.Text, "[^0-9]"))
            {
                this.ShowError("Please input only number", tbNZPrice, lbError);
                return;
            }
            else
            {
                this.HideError(tbNZPrice, lbError);
            }
            #endregion

            #region Generate BrowseHistory file

            Item objItem = new Item()
            {
                ItemDescription = tbItem.Text.Trim(),
                UnitPrice = Convert.ToDouble(lbResult.Text),
                CreateTime = DateTime.Now.Date
            };
            ExportFile.CreateOrUpdateBrowseHistoryFile(@"BrowsingHistory.txt", objItem);
            #endregion

            #region Read BrowseHistory file
            dgvPriceHistory.DataSource = null;
            dgvPriceHistory.DataSource = ExportFile.ReadItemsFromBrowseHistoryFile(@"BrowsingHistory.txt");
            dgvPriceHistory.Show();
            #endregion

            #region Controls updating
            DataGridViewCheckBoxCell chkSelected =
                (DataGridViewCheckBoxCell)dgvPriceHistory.Rows[0].Cells[0];
            chkSelected.Value = true;

            this.ClearControls();
            #endregion
        }

        private void btnClearPrice_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }

        private void btnImportToOrder_Click(object sender, EventArgs e)
        {
            Item objItem = new Item()
            {
                ItemDescription = dgvPriceHistory.CurrentRow.Cells[2].Value.ToString(),
                UnitPrice = Convert.ToDouble(dgvPriceHistory.CurrentRow.Cells[1].Value),
                CreateTime = Convert.ToDateTime(dgvPriceHistory.CurrentRow.Cells[3].Value)
            };
            this.EvtMoveItem(objItem);
        }

        private void dgvPriceHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only the first column can go to this branch
            // This part takes me a long time
            if (e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell chkSelected =
                    (DataGridViewCheckBoxCell)dgvPriceHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (Convert.ToBoolean(chkSelected.Value) == true)
                {
                    chkSelected.Value = false;
                }
                else
                {
                    chkSelected.Value = true;
                }

            }
        }

        private void CalculatePriceKitPage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ClearControls()
        {
            tbItem.Text = "";
            lbResult.Text = "0";
            tbNZPrice.Text = "";
            cboExchangeRate.SelectedIndex = -1;
            cboProfitMargin.SelectedIndex = -1;
            tbNZPrice.Focus();
        }

        private void CalculatePriceKitPage_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        public void Receiver(string whereFromOpen)
        {
            if (whereFromOpen.Equals("Outer"))
            {
                this.btnImportToOrder.Visible = false;
                
            }
        }

        #region Drag and close window

        private Point mouseOff; //The moving position variables of the mouse
        private bool leftFlag; // Determine if the label is left button


        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);  // Get the values of the variable
                leftFlag = true;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mousetSet = Control.MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y);   // Set the position after moving
                Location = mousetSet;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false; // Set false after releasing mouse
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);  // Get the values of the variable
                leftFlag = true;
            }
        }

        private void lbLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mousetSet = Control.MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y);   // Set the position after moving
                Location = mousetSet;
            }
        }

        private void lbLogo_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false; // Set false after releasing mouse
            }
        }
        #endregion

    }
}
