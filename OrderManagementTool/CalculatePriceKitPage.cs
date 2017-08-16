using System;
using System.Linq;
using System.Windows.Forms;
using Models;
using Utilities;

namespace OrderManagementTool
{
    public partial class CalculatePriceKitPage : Form
    {
        public delegate void DlgMoveItem(Item objItem);

        public DlgMoveItem EvtMoveItem;

        public CalculatePriceKitPage()
        {
            InitializeComponent();
            dgvPriceHistory.AutoGenerateColumns = false;
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
                (from t in objItems orderby t.CreateTime descending select t).Distinct(new ItemNoComparer()).Take(20);
            dgvPriceHistory.DataSource = null;
            dgvPriceHistory.DataSource = lstTop20.ToList();
            dgvPriceHistory.Show();
        }

        private void tbNZPrice_Leave(object sender, EventArgs e)
        {
            lbResult.Text = tbNZPrice.Text.Trim();
        }

        private void cboExchangeRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboExchangeRate.SelectedItem != null && tbNZPrice.Text.Trim() != "")
            {
                var price = Convert.ToDouble(tbNZPrice.Text.Trim());

                lbResult.Text = (price * Convert.ToDouble(cboExchangeRate.SelectedItem)).ToString("0.00");
                cboProfitMargin.SelectedIndex = -1;
            }
        }

        private void cboProfitMargin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboProfitMargin.SelectedItem != null && cboExchangeRate.SelectedItem != null &&
                tbNZPrice.Text.Trim() != "")
            {
                var price = Convert.ToDouble(tbNZPrice.Text.Trim());
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

            dgvPriceHistory.DataSource = null;
            dgvPriceHistory.DataSource = ExportFile.ReadItemsFromBrowseHistoryFile(@"BrowsingHistory.txt");
            dgvPriceHistory.Show();

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
    }
}