namespace D1FlexGridTest
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
            this.d1FlexGrid1 = new WindowsFormsApplication1.D1FlexGrid();
            this.SuspendLayout();
            // 
            // d1FlexGrid1
            // 
            this.d1FlexGrid1.FooterVisible = true;
            this.d1FlexGrid1.Location = new System.Drawing.Point(63, 25);
            this.d1FlexGrid1.Name = "d1FlexGrid1";
            this.d1FlexGrid1.RowHeight = 20;
            this.d1FlexGrid1.Size = new System.Drawing.Size(300, 300);
            this.d1FlexGrid1.SumCols = null;
            this.d1FlexGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 384);
            this.Controls.Add(this.d1FlexGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsApplication1.D1FlexGrid d1FlexGrid1;

    }
}

