using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderManagementTool
{
    public partial class CalculatePriceKitPage : Form
    {
        public delegate void DlgMoveItem(Item objItem);

        public DlgMoveItem EvtMoveItem;

        public CalculatePriceKitPage()
        {
            InitializeComponent();
            this.dgvPriceHistory.AutoGenerateColumns = false;
            ShowPriceHistory();
        }

        public void ShowPriceHistory()
        {
            foreach (DataGridViewRow row in dgvPriceHistory.Rows)
            {
                DataGridViewCheckBoxCell chkSelected = (DataGridViewCheckBoxCell) row.Cells[0];
                chkSelected.Value = false;
            }
            dgvPriceHistory.DataSource = new ItemManage().GetItemPriceHistory();
            dgvPriceHistory.Show();

        }

        private void tbNZPrice_Leave(object sender, EventArgs e)
        {
            lbResult.Text = tbNZPrice.Text.Trim();
            
        }

        private void cboExchangeRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboExchangeRate.SelectedItem != null)
            {
                double price = Convert.ToDouble(lbResult.Text.Trim());
                lbResult.Text = (price * Convert.ToDouble(cboExchangeRate.SelectedItem)).ToString();   
            }
        }

        private void cboProfitMargin_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboProfitMargin.SelectedItem != null)
            {
                double price = Convert.ToDouble(lbResult.Text.Trim());
                lbResult.Text = (price * Convert.ToDouble(cboProfitMargin.SelectedItem)).ToString();
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
            dgvPriceHistory.DataSource = null;
            List<Item> objItems = new ItemManage().GetItemPriceHistory();
            objItems.Insert(0, new Item()
            {
                ItemDescription = tbItem.Text.Trim(),
                UnitPrice = Convert.ToDouble(lbResult.Text),
                CreateTime = DateTime.Now.Date
            });

            dgvPriceHistory.DataSource = objItems;
            dgvPriceHistory.Show();

            DataGridViewCheckBoxCell chkSelected =
                (DataGridViewCheckBoxCell)dgvPriceHistory.Rows[0].Cells[0];
            chkSelected.Value = true;
        }

        private void btnClearPrice_Click(object sender, EventArgs e)
        {
            tbItem.Text = "";
            lbResult.Text = "0";
            tbNZPrice.Text = "";
            cboExchangeRate.SelectedIndex = -1;
            cboProfitMargin.SelectedIndex = -1;
            tbNZPrice.Focus();

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
                    //Console.WriteLine(chkSelected.Value.ToString());
                }
                else
                {
                    chkSelected.Value = true;
                    //Console.WriteLine(chkSelected.Value.ToString());
                }

            }
        }

        private void CalculatePriceKitPage_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


    }
}
