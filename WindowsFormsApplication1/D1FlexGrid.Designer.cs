namespace WindowsFormsApplication1
{
    partial class D1FlexGrid
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataFlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.FlexGridSum = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.DataFlexGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexGridSum)).BeginInit();
            this.SuspendLayout();
            // 
            // DataFlexGrid
            // 
            this.DataFlexGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DataFlexGrid.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.DataFlexGrid.Location = new System.Drawing.Point(0, 0);
            this.DataFlexGrid.Name = "DataFlexGrid";
            this.DataFlexGrid.Rows.DefaultSize = 20;
            this.DataFlexGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataFlexGrid.Size = new System.Drawing.Size(300, 261);
            this.DataFlexGrid.TabIndex = 6;
            this.DataFlexGrid.AfterResizeColumn += new C1.Win.C1FlexGrid.RowColEventHandler(this.DataFlexGrid_AfterResizeColumn);
            // 
            // FlexGridSum
            // 
            this.FlexGridSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FlexGridSum.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.FlexGridSum.Location = new System.Drawing.Point(0, 258);
            this.FlexGridSum.Name = "FlexGridSum";
            this.FlexGridSum.Rows.Count = 1;
            this.FlexGridSum.Rows.DefaultSize = 20;
            this.FlexGridSum.Rows.Fixed = 0;
            this.FlexGridSum.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.FlexGridSum.Size = new System.Drawing.Size(300, 40);
            this.FlexGridSum.TabIndex = 7;
            this.FlexGridSum.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.FlexGridSum_AfterScroll);
            // 
            // D1FlexGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataFlexGrid);
            this.Controls.Add(this.FlexGridSum);
            this.Name = "D1FlexGrid";
            this.Size = new System.Drawing.Size(300, 300);
            ((System.ComponentModel.ISupportInitialize)(this.DataFlexGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlexGridSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid DataFlexGrid;
        private C1.Win.C1FlexGrid.C1FlexGrid FlexGridSum;

    }
}
