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
    public partial class Showcase_Inventory : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();
        DateTime currentDate = System.DateTime.Now.Date;
        String strPosition = "";
        int selfid;
        String strstoreid = "";
        String strswid = "";//showcase id
        DateTime Startdate = System.DateTime.Now.Date;
        public Showcase_Inventory(IDictionary<string, string> record)
        {
            InitializeComponent();
            this.record = record;
            strPosition = record["Position"];
            selfid = int.Parse(record["ID"]);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Showcase_Inventory_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            if (strPosition == "Tenant")
            {
                btnfind.Enabled = false;
                textBox4.ReadOnly = true;
                textBox4.Text = selfid.ToString();
                using (var classicContext = new project_manangementEntities())
                {
                    var showcases_id = (from list in classicContext.showcase_rentrecord
                                        where list.TenantID == selfid
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
                    btnSearch.Enabled = true;
                }
            }
            else
            {
                label19.Text = "";
                label17.Text = "";
            }
        }

        private void cmbShowcase_SelectedIndexChanged(object sender, EventArgs e)
        {
            strswid = cmbShowcase.SelectedItem.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox5.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox7.Clear();
            int tid = int.Parse(textBox4.Text);
            int intswid = int.Parse(strswid);
            using (var classicContext = new project_manangementEntities())
            {
                var produ = (from p in classicContext.products
                             from sp in classicContext.showcase_product
                             where p.TenantID == tid && sp.ShowcaseID == intswid&& p.ProductID == sp.ProductID
                             orderby p.ProductID ascending
                             select new{p.ProductID, p.Name, p.ProductFee, sp.stock, sp.product_description});
                foreach (var emp4 in produ.ToList())
                {
                    textBox6.AppendText(currentDate.ToShortDateString());
                    textBox6.AppendText(Environment.NewLine);

                    textBox5.AppendText(emp4.Name.ToString());
                    textBox5.AppendText(Environment.NewLine);

                    textBox1.AppendText(emp4.ProductFee.ToString());
                    textBox1.AppendText(Environment.NewLine);

                    textBox2.AppendText(emp4.stock.ToString());
                    textBox2.AppendText(Environment.NewLine);
                    if (emp4.product_description == null){textBox7.AppendText("");}
                    else {textBox7.AppendText(emp4.product_description);}
                    textBox7.AppendText(Environment.NewLine);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tid = int.Parse(textBox4.Text);
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
                    btnSearch.Enabled = true;
                }
            }
            catch (Exception ex){
                MessageBox.Show("Please sure inputed TenantID ");
            }
          
        }
    }
}
