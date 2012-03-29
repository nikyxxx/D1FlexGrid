using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
         

            c1FlexGrid1.DataSource= buildDataTable();
            this.c1FlexGrid2.Cols.Count = this.c1FlexGrid1.Cols.Count;
            for (int i = 0; i < this.c1FlexGrid1.Cols.Count; i++)
            {
                this.c1FlexGrid2.Cols[i].Width = this.c1FlexGrid1.Cols[i].Width;
            }

            
            
            Console.WriteLine("c1FlexGrid2.Height:{0};", c1FlexGrid2.Height);
            Console.WriteLine(" c1FlexGrid2.Rows.MinSize:{0};", c1FlexGrid2.Rows.MinSize);
            Console.WriteLine(" c1FlexGrid2.ScrollableRectangle.Height:{0};", c1FlexGrid2.ScrollableRectangle.Height);

            Console.WriteLine(" c1FlexGrid1.ScrollableRectangle.Height:{0};", c1FlexGrid1.ScrollableRectangle.Height);
        }

        private DataTable buildDataTable()
        {
            DataTable dt = new DataTable();
            DataRow dr ;
            DataColumn dc = new DataColumn();
            for (int i=0; i < 10; i++)
            {
                dc = new DataColumn();
                dc.ColumnName = "Column" + i.ToString();
                dc.DataType = System.Type.GetType("System.String");
                dt.Columns.Add(dc);
            }

            for (int i = 0; i < 100; i++)
            {
                dr = dt.NewRow();
                dr[0] = "aaaa" + i.ToString();
                dt.Rows.Add(dr);
            }
            
            return dt;
        }

      

        private void c1FlexGrid1_KeyUpEdit(object sender, KeyEditEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                //MessageBox.Show(e.KeyCode.ToString());
                c1FlexGrid1.FinishEditing();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _row = int.Parse(txRow.Text);
            int _col = int.Parse(txCol.Text);
            string _value = txValue.Text;

            d1FlexGrid1[_row, _col] = _value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1FlexGrid1.DataSource(buildDataTable());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int _row = int.Parse(txDelRow.Text);
            d1FlexGrid1.Rows.Remove(_row);
            
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int _col = int.Parse(txDelCol.Text);
            d1FlexGrid1.Cols.Remove(_col);
        }

        
    }
}
