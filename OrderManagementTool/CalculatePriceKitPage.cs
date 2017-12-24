using Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Utilities;

namespace OrderManagementTool
{
    public partial class CalculatePriceKitPage : Form
    {
        private bool zh;
        public CalculatePriceKitPage()
        {
            InitializeComponent();
            CultureInfo ci = Thread.CurrentThread.CurrentUICulture;
            zh = ci.Name.Equals("zh-CHS") ? true : false;
            dgvPriceHistory.AutoGenerateColumns = false;
            lbError.Visible = false;
            lbError.ForeColor = Color.Red;
            ReadBrowsingHistory();
            // Add key down event
            KeyDown += CalculatePriceKitPage_KeyDown;
            foreach (Control control in Controls)
                control.KeyDown += CalculatePriceKitPage_KeyDown;
        }

        public void ReadBrowsingHistory()
        {
            var objItems = ExportFile.ReadItemsFromBrowseHistoryFile(@"BrowsingHistory.txt");
            // Implement the select Top 20 order by CreateTime desc using Linq 
            //Distinct is used for removing the repeated records
            var lstTop20 =
                (from t in objItems orderby t.CreateTime descending select t).Distinct(new ItemNoComparer()).Take(100);
            dgvPriceHistory.DataSource = null;
            dgvPriceHistory.DataSource = lstTop20.ToList();
            dgvPriceHistory.Show();
        }

        private void cboExchangeRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            #region Validation

            if (tbNZPrice.Text.Trim().Length == 0)
            {
                ShowError(zh?"请输入纽币价格":"Please fill NZ price", tbNZPrice, lbError);
                return;
            }
            if (Regex.IsMatch(tbNZPrice.Text, "[^0-9]")) //区分不是字母，而是数字
            {
                // 可能是字母或者是小数
                if (!Regex.IsMatch(tbNZPrice.Text, @"^(-?\d+)(\.\d+)?$"))
                {
                    //不是小数
                    ShowError(zh?"只允许输入数字":"Please input only number", tbNZPrice, lbError);
                    return;
                }
                HideError(tbNZPrice, lbError);
                lbResult.Text = tbNZPrice.Text.Trim();
            }
            else
            {
                HideError(tbNZPrice, lbError);
                lbResult.Text = tbNZPrice.Text.Trim();
            }

            #endregion

            if (cboExchangeRate.SelectedItem != null && tbNZPrice.Text.Trim().Length != 0)
            {
                var price = Convert.ToDouble(tbNZPrice.Text.Trim());

                lbResult.Text = (price * Convert.ToDouble(cboExchangeRate.SelectedItem)).ToString("0.00");
                cboProfitMargin.SelectedIndex = -1;
            }
        }

        private void cboProfitMargin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            #region Validation

            if (tbNZPrice.Text.Trim().Length == 0)
            {
                ShowError(zh?"请输入纽币价格":"Please fill NZ price", tbNZPrice, lbError);
                return;
            }
            if (Regex.IsMatch(tbNZPrice.Text, "[^0-9]")) //区分不是字母，而是数字
                if (!Regex.IsMatch(tbNZPrice.Text, @"^(-?\d+)(\.\d+)?$"))
                {
                    //不是小数
                    ShowError(zh?"只允许输入数字":"Please input only number", tbNZPrice, lbError);
                    return;
                }
                else
                {
                    HideError(tbNZPrice, lbError);
                    lbResult.Text = tbNZPrice.Text.Trim();
                }
            else
                HideError(tbNZPrice, lbError);

            #endregion

            if (cboProfitMargin.SelectedItem != null && cboExchangeRate.SelectedItem != null &&
                tbNZPrice.Text.Trim().Length != 0)
            {
                var price = Convert.ToDouble(tbNZPrice.Text.Trim());
                price = price * Convert.ToDouble(cboExchangeRate.SelectedItem);
                lbResult.Text = Math.Round(price * Convert.ToDouble(cboProfitMargin.SelectedItem)).ToString("0.00");
            }
            else if (cboProfitMargin.SelectedItem != null && tbNZPrice.Text.Trim().Length != 0)
            {
                var price = Convert.ToDouble(tbNZPrice.Text.Trim());
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
                ShowError(zh?"请输入产品":"Please fill the item", tbItem, lbError);
                return;
            }
            HideError(tbItem, lbError);


            if (tbNZPrice.Text.Trim().Length == 0)
            {
                ShowError(zh?"请输入纽币价格":"Please fill the blank", tbNZPrice, lbError);
                return;
            }
            if (Regex.IsMatch(tbNZPrice.Text, "[^0-9]")) //区分不是字母，而是数字
                if (!Regex.IsMatch(tbNZPrice.Text, @"^(-?\d+)(\.\d+)?$"))
                {
                    //不是小数
                    ShowError(zh?"只允许输入数字":"Please input only number", tbNZPrice, lbError);
                    return;
                }
                else
                {
                    HideError(tbNZPrice, lbError);
                }
            else
                HideError(tbNZPrice, lbError);

            #endregion

            #region Generate BrowseHistory file

            var objItem = new Item
            {
                ItemDescription = tbItem.Text.Trim(),
                UnitPrice = Convert.ToDouble(lbResult.Text),
                CreateTime = DateTime.Now.Date
            };
            ExportFile.CreateOrUpdateBrowseHistoryFile(@"BrowsingHistory.txt", objItem);

            #endregion

            #region Read BrowseHistory file

            ReadBrowsingHistory();

            #endregion

            #region Controls updating

            var chkSelected =
                (DataGridViewCheckBoxCell) dgvPriceHistory.Rows[0].Cells[0];
            chkSelected.Value = true;

            ClearControls();

            #endregion
        }

        private void btnClearPrice_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnImportToOrder_Click(object sender, EventArgs e)
        {
            var objItem = new Item
            {
                ItemDescription = dgvPriceHistory.CurrentRow.Cells[2].Value.ToString(),
                UnitPrice = Convert.ToDouble(dgvPriceHistory.CurrentRow.Cells[1].Value),
                CreateTime = Convert.ToDateTime(dgvPriceHistory.CurrentRow.Cells[3].Value)
            };
            EvtMoveItem(objItem);
        }

        private void dgvPriceHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only the first column can go to this branch
            // This part takes me a long time
            if (e.ColumnIndex == 0)
            {
                var chkSelected =
                    (DataGridViewCheckBoxCell) dgvPriceHistory.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (Convert.ToBoolean(chkSelected.Value))
                    chkSelected.Value = false;
                else
                    chkSelected.Value = true;
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
                    Close();
                    break;

                default:
                    break;
            }
        }

        public void Receiver(string whereFromOpen)
        {
            if (whereFromOpen.Equals("Outer"))
                btnImportToOrder.Visible = false;
        }

        #region Delegate for moving item to the ItemCreation DataGridView

        public delegate void DlgMoveItem(Item objItem);

        public DlgMoveItem EvtMoveItem;

        #endregion

        #region The validation of inputing text

        private void ShowError(string tips, TextBox tbBox, Label lbError)
        {
            lbError.Text = tips;
            lbError.Visible = true;
            tbBox.Text = "";
            tbBox.BackColor = Color.LightCoral;
            tbBox.Focus();
        }

        private void HideError(TextBox tbBox, Label lbError)
        {
            lbError.Visible = false;
            tbBox.BackColor = Color.White;
        }

        #endregion

        #region Drag and close window

        private Point mouseOff; //The moving position variables of the mouse
        private bool leftFlag; // Determine if the label is left button


        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); // Get the values of the variable
                leftFlag = true;
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                var mousetSet = MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y); // Set the position after moving
                Location = mousetSet;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
                leftFlag = false; // Set false after releasing mouse
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); // Get the values of the variable
                leftFlag = true;
            }
        }

        private void lbLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                var mousetSet = MousePosition;
                mousetSet.Offset(mouseOff.X, mouseOff.Y); // Set the position after moving
                Location = mousetSet;
            }
        }

        private void lbLogo_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
                leftFlag = false; // Set false after releasing mouse
        }

        #endregion
    }
}