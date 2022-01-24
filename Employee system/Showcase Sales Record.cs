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
    public partial class Showcase_Sales_Record : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();
        //private int tid;
        private int intcaseid;
        public void cleartxt()
        {
            textBox6.Clear();
            textBox5.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
        }
        public void teninfo(int tid) 
        {
            {
                using (var classicContext = new project_manangementEntities())
                {
                    var showcases_id = (from list in classicContext.showcase_rentrecord
                                        where list.TenantID == tid
                                        select list);
                    foreach (var emp2 in showcases_id.ToList())//get result from query
                    {
                        cmbShowcase.Items.Add(emp2.ShowcaseID.ToString());
                    }
                    var tenent = (from list in classicContext.tenants
                                  where list.TenantID == tid
                                  select list);
                    foreach (var emp3 in tenent.ToList())//get result from query
                    {
                        label19.Text = emp3.Name.ToString();
                        label17.Text = emp3.Phone.ToString();
                    }
                }
            }
            return;
        }
        public void Showrecord(int tid)
        {
            using (var classicContext = new project_manangementEntities())
            {
                var srecord_p = (from sp in classicContext.salesrecord_product
                                 from s in classicContext.salesrecords
                                 from p in classicContext.products
                                 where sp.SalesID == s.SalesID && sp.ProductID == p.ProductID &&p.TenantID== tid && sp.ShowcaseID==intcaseid
                                 select new{s.SalesDATETIME, p.Name, sp.eachFee, sp.Qty, sp.Discount, s.StaffID});
                foreach (var emp2 in srecord_p.ToList())
                {
                    textBox6.Text += emp2.SalesDATETIME.ToShortDateString();
                    textBox6.AppendText(Environment.NewLine);

                    textBox5.Text += emp2.Name.ToString();
                    textBox5.AppendText(Environment.NewLine);

                    textBox1.Text += emp2.eachFee.ToString();
                    textBox1.AppendText(Environment.NewLine);

                    textBox2.Text += emp2.Qty.ToString();
                    textBox2.AppendText(Environment.NewLine);

                    textBox3.Text += emp2.Discount.ToString();
                    textBox3.AppendText(Environment.NewLine);

                    int total = (emp2.eachFee - emp2.Discount) * emp2.Qty;
                    textBox4.Text += total.ToString();
                    textBox4.AppendText(Environment.NewLine);

                    textBox7.Text += emp2.StaffID.ToString();
                    textBox7.AppendText(Environment.NewLine);
                }
                return;
            }
        }
        public Showcase_Sales_Record(IDictionary<string, string> record)
        {
            InitializeComponent();
            this.record = record;
        }

        private void Showcase_Sales_Record_Load(object sender, EventArgs e)
        {if (record["Position"] == "Tenant")
            {
                textBox9.ReadOnly = true;
                textBox9.Text = record["ID"];
                btngtid.Enabled = false;
                int tid = int.Parse(record["ID"]);
                teninfo(tid);
            }
            else
            {
                label19.Text = "";
                label17.Text = "";
            }
        }

        private void btngtid_Click(object sender, EventArgs e)
        {
            int tid = int.Parse(textBox9.Text);
            teninfo(tid);
        }

        private void cmbShowcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            intcaseid = int.Parse(cmbShowcase.SelectedItem.ToString());
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int tid = int.Parse(textBox9.Text);
            cleartxt();
            Showrecord(tid);
        }
    }
        
}
