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
    public partial class TournamentInfoForm : Form
    {
        ManagingPerson managingPerson;
        public TournamentInfoForm(Tournament tournament)
        {
            InitializeComponent();
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            labelIdShow.Text = tournament.TournamentId.ToString();
            labelNameShow.Text = tournament.TournamentName;
            labelTypeShow.Text = tournament.SportTypeDTO.Name;
            labelMaxShow.Text = tournament.MaxPlayers.ToString();
            labelMinShow.Text = tournament.MinPlayers.ToString();
            tournament.RegisteredPlayers = managingPerson.CountOfPlayers(tournament.TournamentId);
            labelSignedUpShow.Text = tournament.RegisteredPlayers.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            StaffMemberForm staffMemberForm = new StaffMemberForm(0);
            this.Close();
            staffMemberForm.ShowDialog();
        }
    }
}
