using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class FrmBreakfastBeverage : Form
    {
        public FrmBreakfastBeverage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = dataGridView1.SelectedCells[0].Value.ToString();


            // MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
            int index = dataGridView1.SelectedCells[0].ColumnIndex;
            MessageBox.Show(dataGridView1.SelectedCells[0].ColumnIndex.ToString());
            dataGridView2.Rows.Add();


            dataGridView2.Rows[0].Cells[0].Value = data;
            dataGridView2.Rows[0].Cells[1].Value = "500";
        }

        private void FrmBreakfastBeverage_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();


            dataGridView1.Rows[0].Cells[0].Value = "test";
            dataGridView1.Rows[0].Cells[1].Value = "500";
            dataGridView1.Rows[1].Cells[0].Value = "test 1";
            dataGridView1.Rows[1].Cells[1].Value = "1000";
        }
    }
}
