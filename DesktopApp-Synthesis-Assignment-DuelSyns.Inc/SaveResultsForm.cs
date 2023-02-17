using DataLayer;
using DTO;
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
    public partial class SaveResultsForm : Form
    {
        ManagingPerson managingPerson;
        ManagingTournament managingTournament;
        ManagingMatch managingMatch;
        Match matchToSend;
        Tournament tournament;
        string sportType;
        public SaveResultsForm(Match match)
        {
            InitializeComponent();
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            managingTournament = new ManagingTournament(new TournamentDAL());
            managingMatch = new ManagingMatch(new MatchDAL());
            matchToSend = match;
            tournament = managingTournament.GetTournament(matchToSend.TournamentId);
            string player1 = managingPerson.GetName(match.HomePlayerId);
            string player2 = managingPerson.GetName(match.AwayPlayerId);
            labelScoreOf1.Text = player1;
            labelScoreOf2.Text = player2;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
                if (tournament.SportTypeDTO is BadmintonDTO || tournament.SportTypeDTO is TennisDTO || tournament.SportTypeDTO is ChessDTO)
                {
                    //SportTypeDTO badminton = new BadmintonDTO(sportType);
                    if (tournament.SportTypeDTO.ScoringRules(Convert.ToInt32(textBoxScorePlyr1.Text), Convert.ToInt32(textBoxScorePlyr2.Text)))
                    {
                        if (Convert.ToInt32(textBoxScorePlyr1.Text) > Convert.ToInt32(textBoxScorePlyr2.Text))
                        {
                            matchToSend.HomePlayerPoints = 1;
                            managingMatch.AddMatchResult(matchToSend.MatchId, Convert.ToInt32(textBoxScorePlyr1.Text), Convert.ToInt32(textBoxScorePlyr2.Text), matchToSend.HomePlayerPoints, matchToSend.AwayPlayerPoints);
                            MessageBox.Show("Match score saved !");
                        }
                        else if (Convert.ToInt32(textBoxScorePlyr1.Text) < Convert.ToInt32(textBoxScorePlyr2.Text))
                        {
                            matchToSend.AwayPlayerPoints = 1;
                            managingMatch.AddMatchResult(matchToSend.MatchId, Convert.ToInt32(textBoxScorePlyr1.Text), Convert.ToInt32(textBoxScorePlyr2.Text), matchToSend.HomePlayerPoints, matchToSend.AwayPlayerPoints);
                            MessageBox.Show("Match score saved !");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Wrong scoring ! please follow the appropriate scoring rules for this sport");
                    }
                }
            else
            {
                MessageBox.Show("SportType does not exist");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            new TournamentScheduleForm(tournament).ShowDialog();
            this.Close();
        }
    }
}
