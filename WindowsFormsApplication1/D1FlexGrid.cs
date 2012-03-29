using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace WindowsFormsApplication1
{
    public partial class D1FlexGrid : UserControl
    {
        #region "FooterVisible"
        private bool _footerVisible=true;
        //[DefaultValue(true)]
        public bool FooterVisible 
        { 
            get { return _footerVisible; } 
            set 
            {
                if (_footerVisible != value)
                {
                    FooterChanged(value);
                }
                _footerVisible = value; 
            } 
        }
        void FooterChanged(bool _visible)
        {
            if (_visible)
            {
                FlexGridSum.Visible = true;
                DataFlexGrid.Dock = DockStyle.None;
                DataFlexGrid.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                FlexGridSum.Visible = false;
                DataFlexGrid.Dock = DockStyle.Fill;
                DataFlexGrid.ScrollBars = ScrollBars.Both;
            }

        }
        #endregion

        #region "RowHeight"
        private int rowHeight = 20;
        public int RowHeight
        {
            get { return rowHeight;}
            set { if (rowHeight != value) RowHeightChanged(value); rowHeight = value; }
        }

        void RowHeightChanged(int _height)
        {
            DataFlexGrid.Rows.MinSize = _height;
            DataFlexGrid.Rows.MaxSize = _height;
            FlexGridSum.Rows.MinSize = _height;
            FlexGridSum.Rows.MaxSize = _height;
            FlexGridSum.Height = _height + FlexGridSum.ScrollableRectangle.Height;

            FlexGridSum.Top = this.Height - FlexGridSum.Height;
            DataFlexGrid.Height = this.Height - FlexGridSum.Height;
            DataFlexGrid.Top = 0;
        }
        #endregion

        #region "SumCols"
        private List<int> sumCols;

        public List<int> SumCols
        {
            get { return sumCols; }
            set {
                SumColsChanged(value);
                sumCols=value;
            } 
        }

        void SumColsChanged(List<int> _sumcols)
        {
            //Console.WriteLine(" _sumcols.Keys.ToString():{0};", _sumcols.);
        }
        #endregion

        //public Row this[int _row] { get { return DataFlexGrid.Rows[_row]; } set { ;} }

        public RowCollection Rows { get { return DataFlexGrid.Rows; } set { ;} }

        public ColumnCollection Cols { get { return DataFlexGrid.Cols; } set { ;} }

        public object this[int row, int col] { get { return DataFlexGrid[row,col]; } set { DataFlexGrid[row,col] = value; } }

        public object this[int row, string colName] { get { return DataFlexGrid[row,colName]; } set { DataFlexGrid[row,colName] = value; } }
        
        public D1FlexGrid()
        {
            InitializeComponent();

            DataFlexGrid.AllowSorting=AllowSortingEnum.None;
        }

        public void DataSource(DataTable _dt)
        {
            this.DataFlexGrid.DataSource = _dt;

            //for (int i = 0; i < this.c1FlexGrid1.Cols.Count; i++)
            //{
            //    c1FlexGrid1.Cols[i].Width = 40;
            //    c1FlexGrid1.Cols[i].Visible = true;
            //}

            this.FlexGridSum.Cols.Count = this.DataFlexGrid.Cols.Count;
           

        }

        private void DataFlexGrid_AfterResizeColumn(object sender, RowColEventArgs e)
        {
            FlexGridSum.Cols[e.Col].Width = DataFlexGrid.Cols[e.Col].Width;
        }

        private void FlexGridSum_AfterScroll(object sender, RangeEventArgs e)
        {
            DataFlexGrid.ScrollPosition = FlexGridSum.ScrollPosition;
        }
    }
}
