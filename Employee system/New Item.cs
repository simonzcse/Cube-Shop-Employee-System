using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Employee_system
{
    public partial class New_Item : Form
    {
        String path;

        private IDictionary<string, string> record = new Dictionary<string, string>();
        public New_Item(IDictionary<string, string> record)
        {
            this.record = record;
            InitializeComponent();
        }

        private void txtConfirm_Click(object sender, EventArgs e)
        {
            int newestProductId = int.Parse(record["newestProductId"]) + 1;// newestProductId + 1
            record["newestProductId"] = newestProductId.ToString();

            using (var context = new project_manangementEntities())
            {
                int discount;

                if (boxDiscount.Checked) discount = int.Parse(txtDiscount.Text);
                else discount = 0;

                

                var std = new product()
                {
                    ProductID = newestProductId,
                    Name = txtName.Text,
                    TenantID = int.Parse(txtTID.Text),
                    ProductFee = int.Parse(txtFee.Text),
                    Discount = discount,
                    PrivateLabelItems = boxPrivate.Checked,
                    Description = txtDescription.Text
                };

                context.products.Add(std);
                context.SaveChanges();

                MessageBox.Show("Moved to :\n" + (@"..\" + newestProductId + ".jpg").ToString());
                System.IO.File.Copy(path, @"..\" + newestProductId + ".jpg",true);


            }

            using (var context = new project_manangementEntities())
            {
                var std = new showcase_product()
                {
                    ShowcaseID = int.Parse(txtSID.Text),
                    stock = int.Parse(txtQty.Text),
                    ProductID = newestProductId
                };
                
                context.showcase_product.Add(std);
                context.SaveChanges();

                
            }

            MessageBox.Show("The productId is " + newestProductId, "Success!");
            Item_Infomation item1 = new Item_Infomation(newestProductId);
            item1.ShowDialog();
        }

        private void boxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if(txtDiscount.Enabled == false) txtDiscount.Enabled = true;
            else txtDiscount.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                MessageBox.Show(open.FileName.ToString());
                path = open.FileName.ToString();
            }
            //            pictureBox1.Image = Image.FromFile("C:\\\\Users\\loyee\\OneDrive\\桌面\\Employee system\\Employee system\\bin\\Food.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
