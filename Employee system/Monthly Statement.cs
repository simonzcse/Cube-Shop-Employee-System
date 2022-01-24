using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Employee_system
{
    public partial class Monthly_Statement : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();
        DateTime currentDate = System.DateTime.Now.Date;
        String strPosition = "";
        int selfid;
        DateTime Startdate = System.DateTime.Now.Date;
        private int intcaseid;
        DateTime now = DateTime.Now;
        public Monthly_Statement(IDictionary<string, string> record)
        {
            InitializeComponent();
            this.record = record;
            strPosition = record["Position"];
            selfid = int.Parse(record["ID"]);
        }
        public void cleartxt()
        {
            textBox11.Clear();
            textBox10.Clear();
            textBox1.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox14.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox16.Clear();
        }
        private double getrent() {
            try
            {
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                String period = startDate.ToShortDateString() + " - ";
                period += endDate.ToShortDateString();
                textBox11.Text = period;
                int tid = int.Parse(textBox13.Text);

                using (var classicContext = new project_manangementEntities())
                {
                    int sumTenant = (from list in classicContext.showcase_rentrecord
                                     where list.TenantID == tid && list.ShowcaseID == intcaseid && (!(list.LeaseTermTo <= startDate) || (list.LeaseStartDate >= startDate))
                                     select list.RentFee).Sum();
                    textBox10.Text = "$" + sumTenant.ToString();
                    return (Double)sumTenant;
                }
            }
            catch {
                MessageBox.Show("No Showcase rent");
                return 0.0; }
          
        }
        private double getsales()
        {
            try
            {
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                int tid = int.Parse(textBox13.Text);
                using (var classicContext = new project_manangementEntities())
                {
                    double dumm = 0;
                    var srecord_p = (from sp in classicContext.salesrecord_product
                                     from s in classicContext.salesrecords
                                     from p in classicContext.products
                                     where sp.SalesID == s.SalesID && sp.ProductID == p.ProductID && p.TenantID == tid && sp.ShowcaseID == intcaseid && s.SalesDATETIME > startDate && s.SalesDATETIME < endDate
                                     select new { s.SalesDATETIME, p.Name, sp.eachFee, sp.Qty, sp.Discount, s.StaffID });

                    foreach (var emp2 in srecord_p.ToList())
                    {
                        textBox1.Text += emp2.SalesDATETIME.ToShortDateString();
                        textBox1.AppendText(Environment.NewLine);

                        textBox6.Text += emp2.Name.ToString();
                        textBox6.AppendText(Environment.NewLine);

                        textBox5.Text += emp2.eachFee.ToString();
                        textBox5.AppendText(Environment.NewLine);

                        textBox4.Text += emp2.Qty.ToString();
                        textBox4.AppendText(Environment.NewLine);

                        textBox3.Text += emp2.Discount.ToString();
                        textBox3.AppendText(Environment.NewLine);

                        int total = (emp2.eachFee - emp2.Discount) * emp2.Qty;

                        textBox2.Text += total.ToString();
                        textBox2.AppendText(Environment.NewLine);

                        dumm += (double)total;
                        textBox14.Text = "$" + dumm.ToString();
                    }
                    return dumm;
                }
            }
            catch { MessageBox.Show("No product sale");
                return 0.0;
            }
            
            
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Monthly_Statement_Load(object sender, EventArgs e)
        {
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            if (strPosition == "Tenant")
            {
                btnFind.Enabled = false;
                textBox13.ReadOnly = true;
                textBox13.Text = selfid.ToString();
                using (var classicContext = new project_manangementEntities())
                {
                    var showcases_id = (from list in classicContext.showcase_rentrecord
                                        where list.TenantID == selfid && (!(list.LeaseTermTo <= startDate) || (list.LeaseStartDate >= startDate))
                                        select list);
                    foreach (var emp2 in showcases_id.ToList())//get result from query
                    {
                        cmbShowcase.Items.Add(emp2.ShowcaseID.ToString());
                    }
                    var tenent = (from list in classicContext.tenants
                                  where list.TenantID == selfid
                                  select list);
                    foreach (var emp3 in tenent.ToList())//get result from query
                    {
                        label19.Text = emp3.Name.ToString();
                        label17.Text = emp3.Phone.ToString();
                    }
                    //btnSearch.Enabled = true;
                }
            }
            else
            {
                label19.Text = "";
                label17.Text = "";
            }
            label8.Text=currentDate.ToLongDateString();
            label16.Text= now.ToString("MMM-yyyy", CultureInfo.InvariantCulture);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try {
                var startDate = new DateTime(now.Year, now.Month, 1);
                var endDate = startDate.AddMonths(1).AddDays(-1);
                int tid = int.Parse(textBox13.Text);
                using (var classicContext = new project_manangementEntities())
                {
                    var showcases_id = (from list in classicContext.showcase_rentrecord
                                        where list.TenantID == tid  && (!(list.LeaseTermTo <= startDate) || (list.LeaseStartDate >= startDate))
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
                    btnFind.Enabled = true;
                }
            }
            catch { MessageBox.Show("Please make sure TID has been inputed"); }
            
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            cleartxt();
            double rentfee= getrent();
            double salereceive = getsales();
            textBox19.Text = "$" + salereceive.ToString();
            textBox20.Text = "$" + rentfee.ToString();
            textBox16.Text = "$"+(salereceive - rentfee).ToString();
        }

        private void cmbShowcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            intcaseid = int.Parse(cmbShowcase.SelectedItem.ToString());
        }
    }
}
