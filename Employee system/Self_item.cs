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
    public partial class Self_item : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();
        int selfid;
        public Self_item(IDictionary<string, string> record)
        {
            InitializeComponent();
            this.record = record;
            selfid= int.Parse(record["ID"]);
        }

        private void Self_item_Load(object sender, EventArgs e)
        {
            
            if(record["Position"] == "Tenant")
            {
                btnSearch.Enabled = false;
                textBox4.ReadOnly = true;
                textBox4.Text = selfid.ToString();
                using (var classicContext = new project_manangementEntities())
                {
                    var tenent = (from list in classicContext.tenants
                                  where list.TenantID == selfid
                                  select list);
                    foreach (var emp3 in tenent.ToList())//get result from query
                    {
                        label19.Text = emp3.Name.ToString();
                        label17.Text = emp3.Phone.ToString();
                    }

                    var produc = (from list in classicContext.products
                                  where list.TenantID == selfid
                                  orderby list.ProductID ascending
                                  select list);
                    textBox6.Clear();
                    textBox5.Clear();
                    textBox1.Clear();
                    textBox7.Clear();
                    foreach (var emp2 in produc.ToList())//get result from query
                    {
                        textBox6.Text += emp2.ProductID.ToString();
                        textBox6.AppendText(Environment.NewLine);

                        textBox5.Text += emp2.Name.ToString();
                        textBox5.AppendText(Environment.NewLine);

                        textBox1.Text += emp2.ProductFee.ToString();
                        textBox1.AppendText(Environment.NewLine);

                        textBox7.Text += emp2.Discount.ToString();
                        textBox7.AppendText(Environment.NewLine);

                        try
                        {
                            var summ = (from list in classicContext.showcase_product
                                        where list.ProductID == emp2.ProductID
                                        orderby list.ProductID ascending
                                        select list.stock).Sum();
                            textBox2.Text += summ.ToString();
                       }
                        catch (Exception ex){ textBox2.Text += 0.ToString(); }
                        textBox2.AppendText(Environment.NewLine);
                    }
                     
                }
            }
            else
            {
                label19.Text = "";
                label17.Text = "";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var classicContext = new project_manangementEntities())
                {
                    int idid = int.Parse(textBox4.Text);
                    var tenent = (from list in classicContext.tenants
                                  where list.TenantID == idid
                                  select list);
                    foreach (var emp3 in tenent.ToList())//get result from query
                    {
                        label19.Text = emp3.Name.ToString();
                        label17.Text = emp3.Phone.ToString();
                    }

                    var produc = (from list in classicContext.products
                                  where list.TenantID == idid
                                  orderby list.ProductID ascending
                                  select list);
                    textBox6.Clear();
                    textBox5.Clear();
                    textBox1.Clear();
                    textBox7.Clear();
                    foreach (var emp2 in produc.ToList())//get result from query
                    {
                        textBox6.Text += emp2.ProductID.ToString();
                        textBox6.AppendText(Environment.NewLine);

                        textBox5.Text += emp2.Name.ToString();
                        textBox5.AppendText(Environment.NewLine);

                        textBox1.Text += emp2.ProductFee.ToString();
                        textBox1.AppendText(Environment.NewLine);

                        textBox7.Text += emp2.Discount.ToString();
                        textBox7.AppendText(Environment.NewLine);

                        try
                        {
                            var summ = (from list in classicContext.showcase_product
                                        where list.ProductID == emp2.ProductID
                                        orderby list.ProductID ascending
                                        select list.stock).Sum();
                            textBox2.Text += summ.ToString();
                        }
                        catch (Exception ex) { textBox2.Text += 0.ToString(); }//if null
                        textBox2.AppendText(Environment.NewLine);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Please enter corrent Tenant ID!");
            }

            }
        }
    }

