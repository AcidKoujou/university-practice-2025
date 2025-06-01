using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace MyLittleRPG
{
    public partial class TradingScreen : Form
    {
        private Player _currentPlayer;
        public TradingScreen(Player player)
        {
            _currentPlayer = player;

            InitializeComponent();

            //Style to display numeric column values
            DataGridViewCellStyle rightAllignedCellStyle= new DataGridViewCellStyle();
            rightAllignedCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //populate grid for player inventory
            dgvMyItems.RowHeadersVisible = false;
            dgvMyItems.AutoGenerateColumns = false;

            //hidden column with id
            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemID",
                Visible = false
            });

            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 100,
                DataPropertyName ="Description"
            });

            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Qty",
                Width = 30,
                DefaultCellStyle = rightAllignedCellStyle,
                DataPropertyName = "Quantity"
            });

            dgvMyItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Width = 35,
                DefaultCellStyle = rightAllignedCellStyle,
                DataPropertyName = "Price"
            });

            dgvMyItems.Columns.Add(new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Sell 1",
                
                Width = 50,
                DataPropertyName = "ItemID"
            }) ;
            
            //Bind players inventory to grid
            dgvMyItems.DataSource = _currentPlayer.Inventory;

            //When the user clicks on a row 
            dgvMyItems.CellClick += dgvMyItems_CellClick;


            //populate grid for vendor inventory
            dgvVendorItem.RowHeadersVisible = false;
            dgvVendorItem.AutoGenerateColumns = false;

            //hidden column with id
            dgvVendorItem.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemID",
                Visible = false
            });

            dgvVendorItem.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText ="Name",
                Width =100
            });
            dgvVendorItem.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Price",
                Width = 35,
                DefaultCellStyle = rightAllignedCellStyle,
                DataPropertyName = "Price"
            });

            dgvVendorItem.Columns.Add(new DataGridViewButtonColumn
            {
                Text = "Buy 1",
                UseColumnTextForButtonValue = true,
                Width = 50,
                DataPropertyName = "ItemID"
            });
            //Bind vendors inventory to grid
            dgvVendorItem.DataSource = _currentPlayer.CurrentLocation.VendorWorkingHere.Inventory;

            // when user clicks on a row  call function
            dgvVendorItem.CellClick += dgvVendorItem_CellClick;
        }
        private void dgvMyItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                var itemID = dgvMyItems.Rows[e.RowIndex].Cells[0].Value;

                Item itemBeingSold = World.ItemByID(Convert.ToInt32(itemID));

                if (itemBeingSold.Price == World.UNSELLABLE_ITEM_PRICE)
                {
                    MessageBox.Show($"You can't sell the {itemBeingSold.Name}");
                }
                else
                {
                    _currentPlayer.RemoveItemFromInventory(itemBeingSold);
                    _currentPlayer.Gold += itemBeingSold.Price;
                }
            }
        }
        private void dgvVendorItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==3)
            {
                var itemID = dgvVendorItem.Rows[e.RowIndex].Cells[0].Value;
                Item itemBeingBought = World.ItemByID(Convert.ToInt32(itemID));
                if (_currentPlayer.Gold>= itemBeingBought.Price)
                {
                    _currentPlayer.AddItemToInventory(itemBeingBought);
                    _currentPlayer.Gold -= itemBeingBought.Price;
                }
                else
                {
                    MessageBox.Show($"You don't have enought gold to buy the {itemBeingBought.Name}");
                }
            }
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
