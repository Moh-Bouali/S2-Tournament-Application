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
    public partial class TournamentScheduleForm : Form
    {
        ManagingPerson managingPerson;
        ManagingTournament managingTournament;
        ManagingMatch managingMatch;
        Tournament tournamentToCreateSchedule;
        List<Player> playersToMatchUpList;
        List<Match> matches;
        int registeredPlayers;
        public TournamentScheduleForm(Tournament tournament)
        {
            InitializeComponent();
            labeIdToShow.Text = tournament.TournamentId.ToString();
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            managingTournament = new ManagingTournament(new TournamentDAL());
            managingMatch = new ManagingMatch(new MatchDAL());
            matches = new List<Match>();
            tournamentToCreateSchedule = managingTournament.GetTournament(tournament.TournamentId);
            playersToMatchUpList = managingPerson.GetPlayersPerTournamentId(tournament.TournamentId);
            if (managingMatch.HasSchedule(tournament.TournamentId))
            {
                buttonCreateSchedule.Visible = false;
                managingMatch.QueryMatches(tournament.TournamentId);
                foreach (Match match in managingMatch.publicMatchesList)
                {
                    listBoxTournamentScehdule.Items.Add(match.GetInfo() + $" {match.HomePlayerScore} {match.AwayPlayerScore}");
                }
            }
            else
            {
                listBoxTournamentScehdule.Items.Add("No Schedule available for this tournament");
            }
        }
        private void buttonCreateSchedule_Click(object sender, EventArgs e)
        {
            registeredPlayers = managingPerson.CountOfPlayers(tournamentToCreateSchedule.TournamentId);
            if (/*DateTime.Now.AddDays(7) > tournamentToCreateSchedule.StartingDate && */registeredPlayers >= tournamentToCreateSchedule.MinPlayers)
            {
                managingMatch.CreateSchedulingForMatches(playersToMatchUpList, tournamentToCreateSchedule);
                managingMatch.AddMatchScehduleToDataBase();
                managingMatch.QueryMatches(tournamentToCreateSchedule.TournamentId);
                listBoxTournamentScehdule.Items.Clear();
                foreach (Match match in managingMatch.publicMatchesList)
                {
                    listBoxTournamentScehdule.Items.Add(match.GetInfo());
                }
            }
            else
            {
                MessageBox.Show("Tournament schedule cannot be made yet");
                StaffMemberForm staffMemberForm = new StaffMemberForm(0);
                this.Close();
                staffMemberForm.ShowDialog();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StaffMemberForm staffMemberForm = new StaffMemberForm(0);
            this.Close();
            staffMemberForm.ShowDialog();
        }

        private void buttonSaveGameResult_Click(object sender, EventArgs e)
        {
            matches = managingMatch.publicMatchesList;
            if (listBoxTournamentScehdule.SelectedIndex >= 0)
            {
                Match match = managingMatch.GetAllMatches()[listBoxTournamentScehdule.SelectedIndex];
                if(match.HomePlayerPoints != 0 || match.AwayPlayerPoints != 0)
                {
                    MessageBox.Show("Score already saved !");
                }
                else
                {
                    this.Close();
                    new SaveResultsForm(managingMatch.GetAllMatches()[listBoxTournamentScehdule.SelectedIndex]).Show();
                }
            }
        }
    }
}
