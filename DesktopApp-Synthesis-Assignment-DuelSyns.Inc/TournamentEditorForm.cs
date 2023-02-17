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
    public partial class TournamentEditorForm : Form
    {
        ManagingTournament managingTournament;
        Tournament tournamentToSend;
        public TournamentEditorForm(Tournament tournament)
        {
            InitializeComponent();
            managingTournament = new ManagingTournament(new TournamentDAL());
            monthCalendarStart.Visible = false;
            monthCalendarEnd.Visible = false;
            tournamentToSend = tournament;
            monthCalendarStart.SetDate(tournament.StartingDate);
            monthCalendarEnd.SetDate(tournament.EndDate);
            textBoxStartDate.Text = tournament.StartingDate.ToString("dd/MM/yyyy");
            textBoxEndDate.Text = tournament.EndDate.ToString("dd/MM/yyyy");
            labelIDShow.Text = tournament.TournamentId.ToString();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int counter = 0;
                if (!string.IsNullOrEmpty(textBoxName.Text) || !string.IsNullOrEmpty(textBoxMaxPlayers.Text) || !string.IsNullOrEmpty(textBoxMinPlayers.Text) || monthCalendarStart.SelectionStart != tournamentToSend.StartingDate || monthCalendarEnd.SelectionEnd != tournamentToSend.EndDate || !string.IsNullOrEmpty(textBoxLocation.Text))
                {
                    if (textBoxName.Text != "")
                    {
                        tournamentToSend.TournamentName = textBoxName.Text;
                    }
                    if (textBoxMaxPlayers.Text != "")
                    {
                        tournamentToSend.MaxPlayers = Convert.ToInt32(textBoxMaxPlayers.Text);
                    }
                    if (textBoxMinPlayers.Text != "")
                    {
                        tournamentToSend.MinPlayers = Convert.ToInt32(textBoxMinPlayers.Text);
                    }
                    if (monthCalendarStart.SelectionStart != tournamentToSend.StartingDate)
                    {
                        tournamentToSend.StartingDate = monthCalendarStart.SelectionStart;
                    }
                    if (monthCalendarEnd.SelectionEnd != tournamentToSend.EndDate)
                    {
                        tournamentToSend.EndDate = monthCalendarEnd.SelectionEnd;
                    }
                    if(textBoxLocation.Text != "")
                    {
                        tournamentToSend.Location = textBoxLocation.Text;   
                    }
                    int RulesOfTournament = managingTournament.RulesOfTournament(tournamentToSend.MaxPlayers, tournamentToSend.MinPlayers, tournamentToSend.StartingDate, tournamentToSend.EndDate);
                    if (RulesOfTournament == 1)
                    {
                        MessageBox.Show("Minimum players must be atleast 8");
                        counter++;
                    }
                    if (RulesOfTournament == 2)
                    {
                        MessageBox.Show("Maximum players cannot be less than minimum players");
                        counter++;
                    }
                    if (RulesOfTournament == 3)
                    {
                        MessageBox.Show("Start date and end date cannot be the same");
                        counter++;
                    }
                    if (RulesOfTournament == 4)
                    {
                        MessageBox.Show("End date cannot be earlier than start date");
                        counter++;
                    }
                    if (RulesOfTournament == 5)
                    {
                        MessageBox.Show("Start date has already passed");
                        counter++;
                    }
                    if(RulesOfTournament == 6)
                    {
                        MessageBox.Show("Maximum allowed players is 10");
                        counter++;
                    }
                    if(RulesOfTournament == 7)
                    {
                        MessageBox.Show("Star date has to be more than a week from today");
                        counter++;
                    }
                    if(counter == 0)
                    {
                        managingTournament.UpdateTournament(tournamentToSend);
                        MessageBox.Show("Tournament updated !");
                        StaffMemberForm staffMemberForm = new StaffMemberForm(0);
                        this.Close();
                        staffMemberForm.Show();
                    }
                }
            }
            catch { MessageBox.Show("Please fill in the fields correctly"); }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StaffMemberForm staffMemberForm = new StaffMemberForm(0);
            this.Close();
            staffMemberForm.ShowDialog();
        }

        private void textBoxStartDate_Click(object sender, EventArgs e)
        {
            monthCalendarStart.Visible = true;
        }

        private void textBoxEndDate_Click(object sender, EventArgs e)
        {
            monthCalendarEnd.Visible = true;
        }

        private void monthCalendarStart_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxStartDate.Text = monthCalendarStart.SelectionStart.ToString("dd/MM/yyyy");
        }

        private void monthCalendarEnd_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxEndDate.Text = monthCalendarEnd.SelectionEnd.ToString("dd/MM/yyyy");
        }
    }
}
