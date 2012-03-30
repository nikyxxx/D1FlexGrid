using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
		#region - 构造函数 -

        public Form3()
        {
            //the 3nd edit!
            InitializeComponent();
        }
	
		#endregion

		#region - 事件 -

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dd;
            Random rnd = new Random();
            dd = rnd.Next(cint(0.06 * 100), 10);
            this.textBox1.Text = dd.ToString();
        }
	
		#endregion

    }
}
