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
    public partial class Receipt : Form
    {
        private IDictionary<string, string> record = new Dictionary<string, string>();

        public Receipt(Bill[] bill, int tender, Boolean cash, IDictionary<string, string> getRecord)
        {
            InitializeComponent();

            record = getRecord;


            lblStore.Text = record["storeID"];
            lblPhone.Text = record["storePhone"];
            lblstaff.Text = record["ID"]; ;
            lblDate.Text = DateTime.UtcNow.ToString("MM-dd-yyyy");
            lblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            


            int total = 0, amount = 0;
            
            int newestSaleRecordId = int.Parse(record["newestSaleRecordId"]) + 1;//newestSaleRecordId + 1
            record["newestSaleRecordId"] = newestSaleRecordId.ToString();

            using (var context = new project_manangementEntities())//inserting to salesrecord_order database
            {
                string payment;
                if (cash) payment = "Cash";
                else payment = "Credit";
                var a = new salesrecord()
                {
                    SalesID = newestSaleRecordId,
                    SalesDATETIME = DateTime.Now,
                    StoreID = int.Parse(record["storeID"]),
                    TotalSalesAmount = total,//Is not true(total = 0), will be update after total amount get
                    StaffID = int.Parse(record["ID"]),
                    Paymethod = payment
                };
                context.salesrecords.Add(a);
                context.SaveChanges();
            }

            foreach (Bill goods2 in bill)//Displaying
            {
                if(goods2 != null) { 
                    txtSID.Text += goods2.SID.ToString();
                    txtSID.AppendText(Environment.NewLine);

                    txtName.Text += goods2.Name;
                    txtName.AppendText(Environment.NewLine);

                    txtDescription.Text += goods2.Description;
                    txtDescription.AppendText(Environment.NewLine);

                    txtPrice.Text += '$' + goods2.Price.ToString();
                    txtPrice.AppendText(Environment.NewLine);

                    txtQuantity.Text += goods2.Quantity.ToString();
                    txtQuantity.AppendText(Environment.NewLine);

                    txtDiscount.Text += '$' + goods2.Discount.ToString();
                    txtDiscount.AppendText(Environment.NewLine);

                    amount = goods2.Price * goods2.Quantity - goods2.Discount;
                    total += amount;
                    txtTotalAmount.Text += '$' + amount.ToString();
                    txtTotalAmount.AppendText(Environment.NewLine);

                    using (var context = new project_manangementEntities())//inserting to salesrecord_order database
                    {
                        var b = new salesrecord_product()
                        {
                            SalesID = newestSaleRecordId,
                            ProductID = goods2.PID,
                            ShowcaseID = goods2.SID,
                            eachFee = amount,//??
                            Qty = goods2.Quantity,
                            Discount = goods2.Discount
                        };
                        context.salesrecord_product.Add(b);
                        context.SaveChanges();
                    }
                }
            }

            using (var context = new project_manangementEntities())//inserting TotalSalesAmount to salesrecords database
            {
                var std = from list in context.salesrecords
                          where list.SalesID == newestSaleRecordId
                          select list;

                foreach (var emp2 in std.ToList())
                {
                    emp2.TotalSalesAmount = total;
                }
                context.SaveChanges();
            }

            txtTotal.Text = '$' + total.ToString();
            txtTender.Text = '$' + tender.ToString();
            txtChange.Text = '$' + (tender - total).ToString();
            if (cash) lblMethod.Text = "Cash";
            else lblMethod.Text = "Credit";
        }

        public Receipt(int order, IDictionary<string, string> getRecord) {
            InitializeComponent();
            record = getRecord;
            Bill[] bill = new Bill[99];
            using (var context = new project_manangementEntities())//inserting TotalSalesAmount to salesrecords database
            {
                var std = from list in context.salesrecords
                          where list.SalesID == order
                          select list;

                foreach (var goods2 in std.ToList())
                {
                    lblMethod.Text= goods2.Paymethod;
                    lblDate.Text = goods2.SalesDATETIME.ToString("MM-dd-yyyy");
                    lblTime.Text = goods2.SalesDATETIME.ToString("h:mm:ss tt");
                    // goods2.salesID;
                    lblstaff.Text = goods2.StaffID.ToString();
                    lblStore.Text =  goods2.StoreID.ToString();
                    txtTotal.Text = goods2.TotalSalesAmount.ToString();
                    txtTender.Text = goods2.Tender.ToString();
                    lblStore.Text = goods2.StoreID.ToString();
                    txtChange.Text = (goods2.Tender - goods2.TotalSalesAmount).ToString();
                }
                lblPhone.Text = 12345678.ToString();
            }

            using (var context = new project_manangementEntities())//inserting TotalSalesAmount to salesrecords database
            {
                var std = from list in context.salesrecord_product
                          where list.SalesID == order
                          select list;
                MessageBox.Show(std.ToList().Count().ToString() + " product of this order");

                foreach (var goods2 in std.ToList())
                {
                    
                    txtSID.Text += goods2.ShowcaseID.ToString();
                    txtSID.AppendText(Environment.NewLine);
                    DisplayProductInfo(goods2.ProductID);

                    txtQuantity.Text += goods2.Qty.ToString();
                    txtQuantity.AppendText(Environment.NewLine);

                    txtPrice.Text += goods2.eachFee.ToString();
                    txtPrice.AppendText(Environment.NewLine);

                    txtTotalAmount.Text += (goods2.eachFee * goods2.Qty).ToString();
                    txtTotalAmount.AppendText(Environment.NewLine);

                    txtDiscount.Text += goods2.Discount.ToString();
                    txtDiscount.AppendText(Environment.NewLine);

                }
            }


        }

        private void DisplayProductInfo(int ProductID)
        {
            using (var context = new project_manangementEntities())//inserting TotalSalesAmount to salesrecords database
            {
                var std = from list in context.products
                          where list.ProductID == ProductID
                          select list;

                foreach (var goods2 in std.ToList())
                {

                    txtName.Text += goods2.Name.ToString();
                    txtName.AppendText(Environment.NewLine);

                    if(goods2.Description != null) txtDescription.Text += goods2.Description.ToString();
                    txtDescription.AppendText(Environment.NewLine);

                }
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtTender_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

