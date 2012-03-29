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
    public partial class Form2 : Form
    {
        private List<int> m_sumList;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            m_sumList = new List<int>();
            m_sumList.Add(1);
            m_sumList.Add(3);
            m_sumList.Add(4);
            m_sumList.Add(6);

            listBox1.DataSource = m_sumList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _value = int.Parse(textBox1.Text);
            if (m_sumList.Contains(_value))
            {
                MessageBox.Show(_value.ToString() + " exits!");
                return;
            }
            m_sumList.Add(_value);
            listBox1.DataSource = null;
            listBox1.DataSource = m_sumList;

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int _value = int.Parse(textBox2.Text);
            if (!m_sumList.Contains(_value))
            {
                MessageBox.Show(_value.ToString() + " not exits!");
                return;
            }
            m_sumList.Remove(_value);
            listBox1.DataSource = null;
            listBox1.DataSource = m_sumList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int _value = int.Parse(textBox3.Text);
            if (m_sumList.Contains(_value))
            {
                MessageBox.Show(_value.ToString() + " exits!");

            }
            else
            {
                MessageBox.Show(_value.ToString() + " not exits!");
            }
        }
    }
}
