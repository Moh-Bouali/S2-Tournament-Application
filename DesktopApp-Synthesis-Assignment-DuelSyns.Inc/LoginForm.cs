using DataLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    public partial class LoginForm : Form
    {
        ManagingPerson managingPerson;
        int counter = 0;
        public LoginForm()
        {
            InitializeComponent();
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxID.Text) && !string.IsNullOrWhiteSpace(textBoxPsswd.Text))
            {
                foreach (Person person in managingPerson.publicPersonsList.ToList())
                {
                    counter++;
                    if (person is Staff_member)
                    {
                        string hashedpswd = Static.HashPassword(textBoxPsswd.Text, person.Salt, 10101, 70);
                        if (person.CheckIfCorrect(Convert.ToInt32(textBoxID.Text), hashedpswd))
                        {
                            StaffMemberForm staffMemberForm = new StaffMemberForm(1);
                            this.Hide();
                            staffMemberForm.Show();
                            break;
                        }
                        else if(!person.CheckIfCorrect(Convert.ToInt32(textBoxID.Text), hashedpswd) && counter >= managingPerson.publicPersonsList.Count)
                        {
                            MessageBox.Show("Wrong credentials");
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields");
            }
        }
    }
}
