using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contest
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        List<Student> all = new List<Student>();
        //List x

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] c = { "Business", "Engineering", "Social Science" };
            foreach (string x in c)
            {
                lstCollege.Items.Add(x); // --> Object
            }
        }

        private void lstCollege_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCollege.SelectedIndex != -1)
            {
                lstMajor.Items.Clear();
                switch (lstCollege.SelectedIndex)
                {
                    case 0: //business
                        lstMajor.Items.Add("BA");
                        lstMajor.Items.Add("ACCT");
                        lstMajor.Items.Add("MKT");
                        lstMajor.Items.Add("FIN");
                        lstMajor.Items.Add("ECO");
                        //lstMajor.Items.Insert(0, "XYZ")
                        break;
                    case 1:
                        lstMajor.Items.Add("EE");
                        lstMajor.Items.Add("ME");
                        lstMajor.Items.Add("CS");
                        lstMajor.Items.Add("IT");
                        lstMajor.Items.Add("IE");
                        break;
                    case 2:
                        lstMajor.Items.Add("PSY");
                        lstMajor.Items.Add("POL");
                        lstMajor.Items.Add("SOC");
                        lstMajor.Items.Add("GEO");
                        lstMajor.Items.Add("HIS");
                        break;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();  //move this to make f2 a field of Form1 instance
                                       //otherwise, a brand new f2 is made, which
                                       //won't have teams A and B from previous Form2 instance
            //f2.Tag = txtID.Text;
            f2.Tag = all;
            f2.ShowDialog();
            //the following statement will not be executed until Form2 is "closed"
            all.Clear(); //this is necessary because students already
                         //passed to Form2 should not be passed again
                         //every time this button is clicked
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double g;
            Student s = new Student();
            if (txtID.Text != "" && txtName.Text != "" &&
                txtGPA.Text != "")
            {
                s.ID = txtID.Text;
                s.Name = txtName.Text;
                if (Double.TryParse(txtGPA.Text, out g))
                    s.GPA = g;
                if (lstCollege.SelectedIndex != -1)
                    s.College = (lstCollege.SelectedItem.ToString());
                else
                    s.College = "N/A";
                if (lstMajor.SelectedIndex != -1)
                    s.Major = (lstMajor.SelectedItem.ToString());
                else
                    s.Major = "N/A";
                // Save this student in List<Student>
                all.Add(s);

                MessageBox.Show("Student " + txtID.Text + " is saved successfully!", "Data Saved");
            }
            else
                MessageBox.Show("Must enter ID, Name, and GPA", "Input Error");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            txtGPA.Clear();
            lstCollege.SelectedIndex = -1;
            lstMajor.Items.Clear();
            txtID.Focus();
        }
    }
}
