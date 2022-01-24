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
    public partial class Form1 : Form
    {
        IDictionary<string, string> record = new Dictionary<string, string>();

        public String staffID, staff_Username, staffPosition; 

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var classicContext = new project_manangementEntities())
            {
                var emp = (from list in classicContext.staffs
                           select list);    // select * from employees


            

                foreach (var emp2 in emp.ToList())
                {
                    String messageToShow = emp2.StaffID.ToString() + "  ,  " + emp2.StaffPosition.ToString() + "  ,  " + emp2.Staff_Username.ToString() 
                        + "  ,  " + emp2.Staff_password.ToString();


                    MessageBox.Show(messageToShow);
                }
            }
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect  
            
            f2.ShowDialog();
            this.Show();
        }

        public void goMenu()
        {
            //store record
            record["storeID"] = "840900001";
            record["newestSaleRecordId"] = (new project_manangementEntities().salesrecords.Max(p => p.SalesID)).ToString();
            record["storePhone"] = "12345678";
            record["newestProductId"] = (new project_manangementEntities().products.Max(p => p.ProductID)).ToString();
            record["newestStaffId"] = (new project_manangementEntities().staffs.Max(p => p.StaffID)).ToString();
            record["newestTenantId"] = (new project_manangementEntities().tenants.Max(p => p.TenantID)).ToString();

            //Go menu
            Main_menu f2 = new Main_menu(record); //this is the change, code for redirect  
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void att()
        {
            try
            {
                using (var classicContext = new project_manangementEntities())
                {
                    var emp = new dailyworkingrecord()
                    {
                        StaffID = int.Parse(record["ID"]),
                        WorkedHour = 10,
                        Date_of_workout = DateTime.Now.Date
                    };
                    classicContext.dailyworkingrecords.Add(emp);

                    classicContext.SaveChanges();
                }
            }
            catch { }
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool logined = false;
            if (radioButton2.Checked) {

                using (var classicContext = new project_manangementEntities())
                {
                    var emp = (from list in classicContext.staffs
                               select list);    // select * from employees

                    foreach (var emp2 in emp.ToList())
                    {

                        if (emp2.StaffID.ToString() == txtID.Text)// May XXXXXXX
                        {
                            if (emp2.Staff_password == txtPassword.Text)
                            {
                                //login record
                                record["ID"] = emp2.StaffID.ToString();
                                record["Position"] = emp2.StaffPosition;
                                record["Username"] = emp2.Staff_Username;

                                att();

                                logined = true;

                                goMenu();
                            }
                            break;
                        }
                        //String messageToShow = emp2.StaffID.ToString() + "  ,  " + emp2.StaffPosition.ToString() + "  ,  " + emp2.Staff_Username.ToString()  + "  ,  " + emp2.Staff_password.ToString();
                    }
                }
                
            }
            else if(radioButton1.Checked)
            {

                using (var classicContext = new project_manangementEntities())
                {
                    var emp = (from list in classicContext.tenants
                               select list);    // select * from employees

                    foreach (var emp2 in emp.ToList())
                    {

                        if (emp2.TenantID.ToString() == txtID.Text)// May XXXXXXX
                        {
                            if (emp2.Tenant_Password == txtPassword.Text)
                            {
                                //login record
                                record["ID"] = emp2.TenantID.ToString();
                                record["Position"] = "Tenant";
                                record["Username"] = emp2.Tenant_Username;

                                logined = true;

                                goMenu();
                            }
                            break;
                        }
                        //String messageToShow = emp2.StaffID.ToString() + "  ,  " + emp2.StaffPosition.ToString() + "  ,  " + emp2.Staff_Username.ToString()  + "  ,  " + emp2.Staff_password.ToString();
                    }
                }
            }

            if (!logined)
            {
                MessageBox.Show("Wrong user name or password!!\nPlease try again!", "Error");

            }



























        }
    }
}
