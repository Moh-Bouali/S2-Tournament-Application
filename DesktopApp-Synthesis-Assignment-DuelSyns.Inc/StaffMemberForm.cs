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
    public partial class StaffMemberForm : Form
    {
        ManagingPerson managingPerson;
        ManagingTournament managingTournament;
  
        public StaffMemberForm(int counter)
        {
            InitializeComponent();
            buttonEditTrnmants.Visible = false;
            buttonDeleteTrnmnt.Visible = false;
            buttonDeletePlayer.Visible = false;
            buttonDeleteStaff.Visible = false;
            buttonViewScheduleTrnmnt.Visible = false;
            managingPerson = new ManagingPerson(new PlayerDAL(), new StaffDAL());
            managingTournament = new ManagingTournament(new TournamentDAL());
            foreach (Person person in managingPerson.publicPersonsList.ToList())
            {
                if(person is Player)
                {
                    listBoxShPlayers.Items.Add(((Player)person).GetInfo());
                }
                else
                {
                    listBoxStaffmembers.Items.Add(((Staff_member)person).GetInfo());
                }
            }
            foreach(Tournament tournament in managingTournament.publicTournamentsList.ToList())
            {
                tournament.RegisteredPlayers = managingPerson.CountOfPlayers(tournament.TournamentId);
                if(DateTime.Now >= tournament.StartingDate && DateTime.Now <= tournament.EndDate && tournament.RegisteredPlayers >= tournament.MinPlayers)
                {
                    listBoxTournaments.Items.Add(tournament.GetInfo() + " | Status : ACTIVE");
                }
                else if(DateTime.Now > tournament.EndDate)
                {
                    listBoxTournaments.Items.Add(tournament.GetInfo() + " | Status : FINISHED");
                }
                else if(DateTime.Now.AddDays(7) > tournament.StartingDate && tournament.RegisteredPlayers < tournament.MinPlayers)
                {
                    if(counter == 1)
                    {
                        MessageBox.Show($"Tournament with ID {tournament.TournamentId} still hasn't reached the minimum required of players and start date is less than 7 days");
                    }
                    listBoxTournaments.Items.Add(tournament.GetInfo() + " | Status : Requires more players !");
                }
                else
                {
                    listBoxTournaments.Items.Add(tournament.GetInfo());
                }
            }
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNamePlyr.Text) && !string.IsNullOrEmpty(textBoxPsswdPlyr.Text) && !string.IsNullOrEmpty(textBoxAgePlyr.Text))
                {
                    string salt = Static.GenerateSalt(70);
                    string hashedPsswd = Static.HashPassword(textBoxPsswdPlyr.Text, salt, 10101, 70);
                    Person player = new Player(Convert.ToInt32(textBoxAgePlyr.Text), textBoxNamePlyr.Text, 0, hashedPsswd, salt);
                    managingPerson.AddingPerson(player);
                    MessageBox.Show("Player added !");
                    listBoxShPlayers.Items.Add(((Player)player).GetInfo());
                }
                else
                {
                    MessageBox.Show("Please fill in all the required fields");
                }
            }
            catch { MessageBox.Show("Pleas fill in the fields correctly"); }

        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNameStaff.Text) && !string.IsNullOrEmpty(textBoxPassStaff.Text))
                {
                    string salt = Static.GenerateSalt(70);
                    string hashedPsswd = Static.HashPassword(textBoxPassStaff.Text, salt, 10101, 70);
                    Person staff = new Staff_member(textBoxNameStaff.Text, 0, hashedPsswd, salt);
                    managingPerson.AddingPerson(staff);
                    MessageBox.Show("Staff added !");
                    listBoxStaffmembers.Items.Add(((Staff_member)staff).GetInfo());
                }
                else
                {
                    MessageBox.Show("Please fill in all of the required fields");
                }
            }
            catch { MessageBox.Show("Please fill in the required fields correctly"); }
        }

        private void buttonCreateTournament_Click(object sender, EventArgs e)
        {
            CreateTournamentForm staffForm = new CreateTournamentForm();
            this.Hide();
            staffForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBoxTournaments.Items.Clear();
            if (textBoxIDTournaments.Text.Length >= 1)
            {
                foreach (Tournament tournament in managingTournament.publicTournamentsList)
                {
                    if (tournament.TournamentId.ToString().StartsWith(textBoxIDTournaments.Text))
                    {
                        listBoxTournaments.Items.Add(tournament.GetInfo());
                    }
                }
            }
            else
            {
                foreach (Tournament tournament in managingTournament.publicTournamentsList.ToList())
                {
                    listBoxTournaments.Items.Add(tournament.GetInfo());
                }
            }
        }

        private void textBoxIdPlayer_TextChanged(object sender, EventArgs e)
        {
            listBoxShPlayers.Items.Clear();
            if (textBoxIdPlayer.Text.Length >= 1)
            {
                foreach (Person player in managingPerson.publicPersonsList)
                {
                    if (player is Player)
                    {
                        if (player.ID.ToString().StartsWith(textBoxIdPlayer.Text))
                        {
                            listBoxShPlayers.Items.Add(((Player)player).GetInfo());
                        }
                    }
                }
            }
            else
            {
                foreach (Person person in managingPerson.publicPersonsList.ToList())
                {
                    if (person is Player)
                    {
                        listBoxShPlayers.Items.Add(((Player)person).GetInfo());
                    }
                }
            }
        }

        private void textBoxIdSrchStaff_TextChanged(object sender, EventArgs e)
        {
            listBoxStaffmembers.Items.Clear();
            if (textBoxIdSrchStaff.Text.Length >= 1)
            {
                foreach (Person staff in managingPerson.publicPersonsList)
                {
                    if (staff is Staff_member)
                    {
                        if (staff.ID.ToString().StartsWith(textBoxIdSrchStaff.Text))
                        {
                            listBoxStaffmembers.Items.Add(((Staff_member)staff).GetInfo());
                        }
                    }
                }
            }
            else
            {
                foreach (Person staff in managingPerson.publicPersonsList.ToList())
                {
                    if (staff is Staff_member)
                    {
                        listBoxStaffmembers.Items.Add(((Staff_member)staff).GetInfo());
                    }
                }
            }
        }

        private void listBoxTournaments_Click(object sender, EventArgs e)
        {
            buttonEditTrnmants.Visible = true;
            buttonDeleteTrnmnt.Visible = true;
            buttonViewScheduleTrnmnt.Visible = true;
        }

        private void listBoxShPlayers_Click(object sender, EventArgs e)
        {
            buttonDeletePlayer.Visible = true;
        }

        private void listBoxStaffmembers_Click(object sender, EventArgs e)
        {
            buttonDeleteStaff.Visible = true;
        }

        private void buttonEditTrnmants_Click(object sender, EventArgs e)
        {
            if (listBoxTournaments.SelectedIndex >= 0)
            {
                this.Close();
                new TournamentEditorForm(managingTournament.GetAllTouanaments()[listBoxTournaments.SelectedIndex]).Show();
            }
        }

        private void buttonDeleteTrnmnt_Click(object sender, EventArgs e)
        {
            if(listBoxTournaments.SelectedIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this tournament?", "Approve", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string? _tournament = listBoxTournaments.SelectedItem.ToString();
                    _tournament = _tournament.Substring(_tournament.IndexOf("Tournament :") + 13, (_tournament.IndexOf(",") - (_tournament.IndexOf("Tournament :") + 13)));
                    int tournamentID = Convert.ToInt32(_tournament);
                    managingTournament.DeleteTournaments(tournamentID);
                    listBoxTournaments.Items.RemoveAt(listBoxTournaments.SelectedIndex);
                    MessageBox.Show("Tournament Deleted !");
                    buttonDeletePlayer.Visible = false;
                    buttonEditTrnmants.Visible = false;
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Close();
            loginForm.Show();
        }

        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            if (listBoxShPlayers.SelectedIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this player?", "Approve", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string? player = listBoxShPlayers.SelectedItem.ToString();
                    player = player.Substring(player.IndexOf("ID :") + 5);
                    int playerID = Convert.ToInt32(player);
                    Person playerToDelete = managingPerson.GetPlayer(playerID);
                    managingPerson.DeletePerson(playerToDelete);
                    listBoxShPlayers.Items.RemoveAt(listBoxShPlayers.SelectedIndex);
                    MessageBox.Show("Player Deleted !");
                }
                buttonDeletePlayer.Visible = false;
            }
        }

        private void buttonDeleteStaff_Click(object sender, EventArgs e)
        {
            if(listBoxStaffmembers.SelectedIndex >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Staff member?", "Approve", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string? staff = listBoxStaffmembers.SelectedItem.ToString();
                    staff = staff.Substring(staff.IndexOf("ID :") + 5);
                    int staffID = Convert.ToInt32(staff);
                    Person staffToDelete = managingPerson.GetStaff(staffID);
                    managingPerson.DeletePerson(staffToDelete);
                    listBoxStaffmembers.Items.RemoveAt(listBoxStaffmembers.SelectedIndex);
                    MessageBox.Show("Staff member Deleted !");
                }
            }
            buttonDeleteStaff.Visible = false;
        }

        private void buttonViewScheduleTrnmnt_Click(object sender, EventArgs e)
        {
            if (listBoxTournaments.SelectedIndex >= 0)
            {
                this.Close();
                new TournamentScheduleForm(managingTournament.GetAllTouanaments()[listBoxTournaments.SelectedIndex]).Show();
            }
        }

        private void listBoxTournaments_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxTournaments.SelectedIndex >= 0)
            {
                this.Close();
                new TournamentInfoForm(managingTournament.GetAllTouanaments()[listBoxTournaments.SelectedIndex]).Show();
            }
        }
    }
}
