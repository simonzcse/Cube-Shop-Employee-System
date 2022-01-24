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
    public partial class Staff_List : Form
    {
        public Staff_List()
        {
            InitializeComponent();

            using (var classicContext = new project_manangementEntities())
            {//Conn. Database 

                var emp = (from list in classicContext.staffs
                           select list);

                foreach (var emp2 in emp.ToList())//get result from query
                {
                    txtBirth.AppendText(((DateTime)emp2.DateOfBirth).ToString("dd/MM/yyyy"));
                    txtBirth.AppendText(Environment.NewLine);

                    if(emp2.isFulltime)  txtFull.AppendText("Yes");
                    else txtFull.AppendText("No");
                    txtFull.AppendText(Environment.NewLine);

                    txtHireDate.AppendText(((DateTime)emp2.HireDate).ToString("dd/MM/yyyy"));
                    txtHireDate.AppendText(Environment.NewLine);

                    txtHKID.AppendText(emp2.Staff_HKIDNumber.ToString());
                    txtHKID.AppendText(Environment.NewLine);

                    txtName.AppendText(emp2.Staff_Name.ToString());
                    txtName.AppendText(Environment.NewLine);

                    txtStaffID.AppendText(emp2.StaffID.ToString());
                    txtStaffID.AppendText(Environment.NewLine);

                    SetTextsize();
                }
            }
        }

        public void SetTextsize()
        {
            Size size = TextRenderer.MeasureText(txtStaffID.Text, txtStaffID.Font);
            txtBirth.Height = size.Height;
            txtStaffID.Height = size.Height;
            txtName.Height = size.Height;
            txtHKID.Height = size.Height;
            txtHireDate.Height = size.Height;
            txtFull.Height = size.Height;
            txtBirth.Height = size.Height;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_List_Load(object sender, EventArgs e)
        {

        }
    }
}
