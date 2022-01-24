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
    public partial class PTStaff_work : Form
    {
        public PTStaff_work()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")  //OR if !(string.IsNullOrEmpty(tb.Text))
            {
                using (var classicContext = new project_manangementEntities())
                {
                    int intStaffID = int.Parse(textBox1.Text);

                    var b = from list in classicContext.staffs
                              where list.StaffID == intStaffID
                              select list;

                    txtName.Text = b.ToList()[0].Staff_Name;

                    var emp = from list in classicContext.dailyworkingrecords
                              where list.StaffID == intStaffID
                              select list;

                    foreach (var a in emp.ToList())
                    {
                        textBox2.AppendText(((DateTime)a.Date_of_workout).ToString("dd/MM/yyyy"));
                        textBox2.AppendText(Environment.NewLine);

                        textBox3.AppendText(a.WorkedHour.ToString());
                        textBox3.AppendText(Environment.NewLine);

                       
                    }
                }
            }
            else MessageBox.Show("Wrong Staff ID !!\nPlease input again!\n", "Error");
        }

        public void SetTextsize()
        {
            Size size = TextRenderer.MeasureText(textBox2.Text, textBox2.Font);
            textBox2.Height = size.Height;
            textBox3.Height = size.Height;
        }
    }
}

