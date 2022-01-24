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
    public partial class Cal_Salary : Form
    {
        public Cal_Salary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { int hours = 0;
            try
            {
                using (var classicContext = new project_manangementEntities())
                {
                    
                    int sid = int.Parse(textBox1.Text);
                    var std = from list in classicContext.staffs
                              where list.StaffID == sid
                              select list;
                    var dwr = from list in classicContext.dailyworkingrecords
                              where list.StaffID == sid
                              select list;
                    foreach (var emp2 in std.ToList())
                    {
                        Boolean isft = emp2.isFulltime;
                        if (isft) { int salary = emp2.HourSalary * 21 * 10;
                            MessageBox.Show("Salary = " + salary);
                        }
                        else
                        {
                            foreach (var emp3 in dwr.ToList())
                            {
                                String x=emp3.WorkedHour.ToString();
                                hours += int.Parse(x);
                            }
                             hours*=emp2.HourSalary;
                            MessageBox.Show("Salary = " + hours);
                            break;
                        }
                        
                        
                    }
                    try
                    {
                        //classicContext.SaveChanges();
                        //MessageBox.Show(sid + "/r Salary = ");
                    }
                    catch (Exception exp) { MessageBox.Show(sid + " Cant \n\r" + exp); }








                }
            }
            catch (Exception ex) { MessageBox.Show("Error : \n\r" + ex); }
        }
    }
}
