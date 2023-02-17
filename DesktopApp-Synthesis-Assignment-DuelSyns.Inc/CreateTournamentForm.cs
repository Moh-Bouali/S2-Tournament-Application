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
    public partial class CreateTournamentForm : Form
    {
        ManagingTournament managingTournament;
        public CreateTournamentForm()
        {
            InitializeComponent();
            managingTournament = new ManagingTournament(new TournamentDAL());
            comboBoxSportType.Items.Add(SportTypes.TENNIS);
            comboBoxSportType.Items.Add(SportTypes.BADMINTON);
            comboBoxSportType.Items.Add(SportTypes.CHESS);
        }

        private void buttonCreateTournament_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxTournamentName.Text) && !string.IsNullOrWhiteSpace(numericUpDownMaxPlayers.ToString()) && !string.IsNullOrWhiteSpace(numericUpDownMinPlayers.ToString()) && !string.IsNullOrWhiteSpace(monthCalendarStart.ToString()) && !string.IsNullOrWhiteSpace(monthCalendarEnd.ToString()) && comboBoxSportType.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(textBoxLocation.Text))
                {
                    int RulesMethodResult = managingTournament.RulesOfTournament((int)numericUpDownMaxPlayers.Value, (int)numericUpDownMinPlayers.Value, Convert.ToDateTime(monthCalendarStart.SelectionStart), Convert.ToDateTime(monthCalendarEnd.SelectionEnd));
                    if (RulesMethodResult == 0)
                    {
                        if (comboBoxSportType.SelectedIndex == 0)
                        {
                            Tournament tournament = new Tournament(textBoxTournamentName.Text, 0, Convert.ToDateTime(monthCalendarStart.SelectionStart), Convert.ToDateTime(monthCalendarEnd.SelectionEnd), (int)numericUpDownMaxPlayers.Value, (int)numericUpDownMinPlayers.Value, managingTournament.SportType(comboBoxSportType.SelectedItem.ToString()), textBoxLocation.Text);
                            managingTournament.AddTournament(tournament);
                            MessageBox.Show("Tournament Created ! ");
                            StaffMemberForm staffMemberForm = new StaffMemberForm(0);
                            this.Close();
                            staffMemberForm.ShowDialog();
                        }
                        else if (comboBoxSportType.SelectedIndex == 1)
                        {
                            Tournament tournament = new Tournament(textBoxTournamentName.Text, 0, Convert.ToDateTime(monthCalendarStart.SelectionStart), Convert.ToDateTime(monthCalendarEnd.SelectionEnd), (int)numericUpDownMaxPlayers.Value, (int)numericUpDownMinPlayers.Value, managingTournament.SportType(comboBoxSportType.SelectedItem.ToString()), textBoxLocation.Text);
                            managingTournament.AddTournament(tournament);
                            MessageBox.Show("Tournament Created ! ");
                            StaffMemberForm staffMemberForm = new StaffMemberForm(0);
                            this.Close();
                            staffMemberForm.ShowDialog();
                        }
                        else if (comboBoxSportType.SelectedIndex == 2)
                        {
                            Tournament tournament = new Tournament(textBoxTournamentName.Text, 0, Convert.ToDateTime(monthCalendarStart.SelectionStart), Convert.ToDateTime(monthCalendarEnd.SelectionEnd), (int)numericUpDownMaxPlayers.Value, (int)numericUpDownMinPlayers.Value, managingTournament.SportType(comboBoxSportType.SelectedItem.ToString()), textBoxLocation.Text);
                            managingTournament.AddTournament(tournament);
                            MessageBox.Show("Tournament Created ! ");
                            StaffMemberForm staffMemberForm = new StaffMemberForm(0);
                            this.Close();
                            staffMemberForm.ShowDialog();
                        }
                    }
                    else if(RulesMethodResult == 1)
                    {
                        MessageBox.Show("Minimum number of players has to be alteast 8");
                    }
                    else if(RulesMethodResult == 2)
                    {
                        MessageBox.Show("Minimum number of players cannot be bigger than the maximum");
                    }
                    else if (RulesMethodResult == 3)
                    {
                        MessageBox.Show("Start date and end date cannot be the same");
                    }
                    else if (RulesMethodResult == 4)
                    {
                        MessageBox.Show("Please make sure that the end date is not before the start date");
                    }
                    else if(RulesMethodResult == 5)
                    {
                        MessageBox.Show("Start date already passed");
                    }
                    else if (RulesMethodResult == 6)
                    {
                        MessageBox.Show("Maximum players has to be 8");
                    }
                    else if(RulesMethodResult == 7)
                    {
                        MessageBox.Show("Start date has to be atleast a week from today");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields");
                }
        }
            catch { MessageBox.Show("Please fill in all the required fields correctly"); }
}

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StaffMemberForm form = new StaffMemberForm(0);
            this.Close();
            form.ShowDialog();
        }
    }
}