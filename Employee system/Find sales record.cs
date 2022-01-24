using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_system
{
    
    public partial class Find_sales_record : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();
        public Find_sales_record(IDictionary<string, string> record)
        {
            InitializeComponent();
            this.record = record;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                Receipt a = new Receipt(int.Parse(txtID.Text), record);
                a.ShowDialog();
            }
            //catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
