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
    

    public partial class Saling : Form
    {
        int count = 0;

        int Total = 0;

        String strstoreid = "";

        public Bill[] bill = new Bill[99];
        IDictionary<string, string> ProductInfo = new Dictionary<string, string>();

        public void Bill_InsertProductInfo(int neededPID)
        {
            using (var classicContext = new project_manangementEntities())
            {
                var goods = (from list in classicContext.products
                             where list.ProductID == neededPID
                             select list);    // select * from employees

                foreach (var goods2 in goods.ToList())
                {
                    bill[count].PID = goods2.ProductID;
                    bill[count].Discount = goods2.Discount;
                    bill[count].Price = goods2.ProductFee;
                    bill[count].Name = goods2.Name;
                    bill[count].Description = goods2.Description;
                }
            }
        }

        public void DisplayBill()
        {
            int quentity = bill[count].Quantity,
                Price = bill[count].Price,
                discount = bill[count].Discount;

            txtName.Text += bill[count].Name;
            txtName.AppendText(Environment.NewLine);

            txtID.Text += bill[count].PID.ToString();
            txtID.AppendText(Environment.NewLine);

            txtPrice.Text += "$" + Price.ToString();
            txtPrice.AppendText(Environment.NewLine);

            txtBillQuantity.Text += quentity.ToString();
            txtBillQuantity.AppendText(Environment.NewLine);

            txtDiscount.Text += '$' + discount.ToString();
            txtDiscount.AppendText(Environment.NewLine);

            txtAmount.Text += "$" + (Price * quentity - discount).ToString();
            txtAmount.AppendText(Environment.NewLine);
        }
        
        public void UpdateTotal()
        {
            Total += bill[count].Price * bill[count].Quantity;
            txtTotal.Text = "$" + Total.ToString();
        }

        IDictionary<string, string> record = new Dictionary<string, string>();

        public Saling(IDictionary<string, string> record)
        {
            this.record = record;
            InitializeComponent();


        }

        public Saling(IDictionary<string, string> record,String PID)
        {
            this.record = record;
            InitializeComponent();

            //txtPID.Text = PID;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool idfound = false;

            int neededPID = int.Parse(cmbPID.SelectedItem.ToString());
            int neededSID = int.Parse(cmbSID.SelectedItem.ToString());
            int needeQuentity = int.Parse(txtQuantity.Text); ;

            using (var classicContext = new project_manangementEntities())
            {
                var goods = (from list in classicContext.showcase_product
                           select list);    // select * from employees

                foreach (var goods2 in goods.ToList())
                {
                    if (goods2.ShowcaseID == neededSID)//looking for neededPID
                    {
                        
                        if (goods2.ProductID == neededPID)
                        {
                            idfound = true;
                            if (goods2.stock >= needeQuentity)//checking enough
                            {
                                bill[count] = new Bill();
                                //inputing details to the bill
                                bill[count].SID = goods2.ShowcaseID;//writing ShowcaseID --> bill
                                bill[count].Quantity = needeQuentity;//writing quentity --> bill
                                Bill_InsertProductInfo(neededPID);//writing id , discount, price, name --> bill  
                                DisplayBill();

                                UpdateTotal();
                                count++;
                                txtCount.Text = count.ToString();
                                break;
                            }

                            else
                            {
                                MessageBox.Show(neededPID + " Only " + goods2.stock + " left!", "Error");
                            }


                        }
                    }

                }

                if (!idfound)
                {
                    MessageBox.Show("Product Id not found" , "Error");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ChangingQty()
        {
            int times = 0,SID,PID;

            while (times < count) using (var classicContext = new project_manangementEntities())
            {
                    SID = bill[times].SID;
                    PID = bill[times].PID;

                    var goods = (from list in classicContext.showcase_product
                                 where SID == list.ShowcaseID && PID == list.ProductID
                                 select list);

                    if (goods.FirstOrDefault() != null) {
                        goods.ToList()[0].stock -= bill[times].Quantity;
                        MessageBox.Show("Success!");
                    }

                    classicContext.SaveChanges();
                    times++;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int tender = int.Parse(txtTender.Text);
            Boolean cash = false;
            if (rdoCash.Checked) cash = true;
            if (tender >= Total)
            {
                ChangingQty();
                
                Receipt f2 = new Receipt(bill, tender, cash, record);
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No enough money!!!!");
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bill = null;
            bill = new Bill[99];

            txtName.Text = "";
            txtID.Text = "";
            txtPrice.Text = "";
            txtBillQuantity.Text = "";
            txtDiscount.Text = "";
            txtAmount.Text = "";

            count = 0;
            Total = 0;
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbShowcase_SelectedIndexChanged(object sender, EventArgs e)
        {

            strstoreid = cmbStore.SelectedItem.ToString();
            int intstoreid = int.Parse(strstoreid);
            cmbSID.Items.Clear();
            cmbPID.Items.Clear();
            using (var classicContext = new project_manangementEntities())
            {
                var showcases_id = (from list in classicContext.showcases
                                    where list.StoreID == intstoreid
                                    select list);
                foreach (var emp2 in showcases_id.ToList())//get result from query
                {
                    cmbSID.Items.Add(emp2.ShowcaseID.ToString());
                }
            }
        }

        private void cmbSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String strchowcaseid = cmbSID.SelectedItem.ToString();
            int intchowcaseid = int.Parse(strchowcaseid);
            cmbPID.Items.Clear();
            using (var classicContext = new project_manangementEntities())
            {
                var showcases_id = (from list in classicContext.showcase_product
                                    where list.ShowcaseID == intchowcaseid
                                    select list);
                foreach (var emp2 in showcases_id.ToList())//get result from query
                {
                    cmbPID.Items.Add(emp2.ProductID.ToString());
                }
            }
        }

        private void cmbPID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

