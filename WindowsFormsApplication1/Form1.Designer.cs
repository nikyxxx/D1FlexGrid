namespace WindowsFormsApplication1
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.d1TextBox1 = new D1Lib.D1TextBox();
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1FlexGrid2 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txRow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txCol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txValue = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txDelRow = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txDelCol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.d1FlexGrid1 = new WindowsFormsApplication1.D1FlexGrid();
            this.d1FlexGrid2 = new WindowsFormsApplication1.D1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // d1TextBox1
            // 
            this.d1TextBox1.ItemClassID = 0;
            this.d1TextBox1.LabelName = "标题：";
            this.d1TextBox1.Location = new System.Drawing.Point(12, 29);
            this.d1TextBox1.Name = "d1TextBox1";
            this.d1TextBox1.Numberic = false;
            this.d1TextBox1.Size = new System.Drawing.Size(240, 21);
            this.d1TextBox1.TabIndex = 0;
            this.d1TextBox1.Value = null;
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.c1FlexGrid1.Location = new System.Drawing.Point(12, 56);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.DefaultSize = 20;
            this.c1FlexGrid1.Rows.MinSize = 21;
            this.c1FlexGrid1.Size = new System.Drawing.Size(240, 150);
            this.c1FlexGrid1.TabIndex = 5;
            // 
            // c1FlexGrid2
            // 
            this.c1FlexGrid2.ColumnInfo = "10,1,0,0,0,100,Columns:";
            this.c1FlexGrid2.Location = new System.Drawing.Point(12, 214);
            this.c1FlexGrid2.Name = "c1FlexGrid2";
            this.c1FlexGrid2.Rows.Count = 1;
            this.c1FlexGrid2.Rows.DefaultSize = 20;
            this.c1FlexGrid2.Rows.Fixed = 0;
            this.c1FlexGrid2.Rows.MinSize = 21;
            this.c1FlexGrid2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.c1FlexGrid2.Size = new System.Drawing.Size(240, 40);
            this.c1FlexGrid2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "change Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "bind DataTable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "row:";
            // 
            // txRow
            // 
            this.txRow.Location = new System.Drawing.Point(45, 319);
            this.txRow.Name = "txRow";
            this.txRow.Size = new System.Drawing.Size(32, 21);
            this.txRow.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "col:";
            // 
            // txCol
            // 
            this.txCol.Location = new System.Drawing.Point(110, 319);
            this.txCol.Name = "txCol";
            this.txCol.Size = new System.Drawing.Size(34, 21);
            this.txCol.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "value:";
            // 
            // txValue
            // 
            this.txValue.Location = new System.Drawing.Point(192, 319);
            this.txValue.Name = "txValue";
            this.txValue.Size = new System.Drawing.Size(47, 21);
            this.txValue.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "delete a Row";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txDelRow
            // 
            this.txDelRow.Location = new System.Drawing.Point(45, 375);
            this.txDelRow.Name = "txDelRow";
            this.txDelRow.Size = new System.Drawing.Size(32, 21);
            this.txDelRow.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "row:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "delete a Col";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txDelCol
            // 
            this.txDelCol.Location = new System.Drawing.Point(45, 431);
            this.txDelCol.Name = "txDelCol";
            this.txDelCol.Size = new System.Drawing.Size(32, 21);
            this.txDelCol.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "col:";
            // 
            // d1FlexGrid1
            // 
            this.d1FlexGrid1.FooterVisible = true;
            this.d1FlexGrid1.Location = new System.Drawing.Point(313, 27);
            this.d1FlexGrid1.Name = "d1FlexGrid1";
            this.d1FlexGrid1.RowHeight = 20;
            this.d1FlexGrid1.Size = new System.Drawing.Size(336, 256);
            this.d1FlexGrid1.SumCols = null;
            this.d1FlexGrid1.TabIndex = 10;
            // 
            // d1FlexGrid2
            // 
            this.d1FlexGrid2.FooterVisible = false;
            this.d1FlexGrid2.Location = new System.Drawing.Point(313, 289);
            this.d1FlexGrid2.Name = "d1FlexGrid2";
            this.d1FlexGrid2.RowHeight = 21;
            this.d1FlexGrid2.Size = new System.Drawing.Size(300, 153);
            this.d1FlexGrid2.SumCols = null;
            this.d1FlexGrid2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 550);
            this.Controls.Add(this.txDelCol);
            this.Controls.Add(this.txDelRow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.d1FlexGrid1);
            this.Controls.Add(this.d1FlexGrid2);
            this.Controls.Add(this.c1FlexGrid2);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.d1TextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private D1Lib.D1TextBox d1TextBox1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid2;
        private D1FlexGrid d1FlexGrid2;
        private D1FlexGrid d1FlexGrid1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txValue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txDelRow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txDelCol;
        private System.Windows.Forms.Label label5;
    }
}

