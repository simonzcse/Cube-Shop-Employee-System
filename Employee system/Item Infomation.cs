using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Employee_system
{
    public partial class Item_Infomation : Form
    {
        IDictionary<string, string> record = new Dictionary<string, string>();

        public Item_Infomation(IDictionary<string, string> record)
        {
            this.record = record;
            InitializeComponent();
        }

        public Item_Infomation(int newestProductId)
        {
            InitializeComponent();

            txtproductID.Text = newestProductId.ToString();
            btnsearch.PerformClick();
            btnsearch_Click(this, EventArgs.Empty);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            int Id = int.Parse(txtproductID.Text);//Product ID
            using (var classicContext = new project_manangementEntities())
            {//Conn. Database 

                Boolean found = false;
                
                    var emp = (from list in classicContext.products//store query
                               where list.ProductID == Id
                               select list);    // select 

                int countitem = 0;

                var countofeachcase = (from list in classicContext.showcase_product//store query
                            where list.ProductID == Id
                            select list);    // select 

                var countofeachcase5 = (from list in classicContext.showcase_product//store query
                                       where list.ProductID == Id
                                       select list).Distinct();    // select 

                foreach (var emp2 in emp.ToList())//get result from query
                {
                    lblname.Text = emp2.Name.ToString();
                    lblname.Show();
                    txtresult.AppendText("ProductID :" + emp2.ProductID.ToString());
                    txtresult.AppendText(Environment.NewLine);
                    txtresult.AppendText("ProductFee :" + emp2.ProductFee.ToString());
                    txtresult.AppendText(Environment.NewLine);
                    found = true;
                }

                foreach (var countofeachcase2 in countofeachcase.ToList())//get result from query
                    {
                    countitem += int.Parse(countofeachcase2.stock.ToString());
                    }
                foreach (var countofeachcase6 in countofeachcase5.ToList())//get result from query
                {
                    txtresult.Text += ("ShowcaseID :" + countofeachcase6.ShowcaseID.ToString());
                    txtresult.AppendText(Environment.NewLine);
                }
                foreach (var emp2 in emp.ToList())//get result from query
                {
                    txtresult.Text += "\nCount : " + countitem.ToString();
                }


                
                
                if(found)    pictureBox1.Image = Image.FromFile(@"..\" + txtproductID.Text + ".jpg");
                
               

                //MessageBox.Show("SQL ERROR :\n" , "ERROR");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            this.Close();
        }

        private void Item_Infomation_Load(object sender, EventArgs e)
        {

        }

        private void btnInstoring_Click(object sender, EventArgs e)
        {
            Restoring restoring = new Restoring(txtproductID.Text);
            restoring.ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Saling Saling = new Saling(record, txtproductID.Text);
            Saling.ShowDialog();
        }
    }
}
