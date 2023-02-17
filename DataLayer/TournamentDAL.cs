using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TournamentDAL : ITournamentDAL
    {
        Database database = new Database();
        ManagingTournamentDTO? managingTournamentDTO;
        public void AddTournament(TournamentDTO tournamentDTO)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmdTrnmt = new MySqlCommand("INSERT INTO tournament VALUES (@name, @id, @startdate, @enddate, @maxplayers, @minplayers, @sporttype, @location)", conn);
            cmdTrnmt.Parameters.AddWithValue("@name", tournamentDTO.TournamentName);
            cmdTrnmt.Parameters.AddWithValue("@id", default);
            cmdTrnmt.Parameters.AddWithValue("@startdate", tournamentDTO.StartingDate);
            cmdTrnmt.Parameters.AddWithValue("@enddate", tournamentDTO.EndDate);
            cmdTrnmt.Parameters.AddWithValue("@maxplayers", tournamentDTO.MaxPlayers);
            cmdTrnmt.Parameters.AddWithValue("@minplayers", tournamentDTO.MinPlayers);
            cmdTrnmt.Parameters.AddWithValue("@sporttype", tournamentDTO.SportType.Name);
            cmdTrnmt.Parameters.AddWithValue("@location", tournamentDTO.Location);
            cmdTrnmt.ExecuteNonQuery();
            conn.Close();
        }
        public List<TournamentDTO> SelectAllTournaments()
        {
            managingTournamentDTO = new ManagingTournamentDTO();
            List<TournamentDTO> tournamentDTOList = new List<TournamentDTO>();
            MySqlConnection conn = new MySqlConnection(database.Connection);

            MySqlCommand cmd = new MySqlCommand("select * from tournament", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    tournamentDTOList.Add(new TournamentDTO(reader["name"].ToString(), Convert.ToInt32(reader["id"]), Convert.ToDateTime(reader["start date"]), Convert.ToDateTime(reader["end date"]), Convert.ToInt32(reader["maximum players"]), Convert.ToInt32(reader["minimum players"]), managingTournamentDTO.sportType(reader.GetString("Type")), reader["location"].ToString()));
                }
            }
            conn.Close();
            return tournamentDTOList;
        }
        public void UpdateTournament(TournamentDTO tournamentDTO)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `tournament` SET `name`=@name,`start date`=@startdate,`end date`=@enddate,`maximum players`= @maxplayers,`minimum players`=@minplayers, `location`= @location WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", tournamentDTO.TournamentId);
            cmd.Parameters.AddWithValue("@name", tournamentDTO.TournamentName);
            cmd.Parameters.AddWithValue("@startdate", tournamentDTO.StartingDate);
            cmd.Parameters.AddWithValue("@enddate", tournamentDTO.EndDate);
            cmd.Parameters.AddWithValue("@maxplayers", tournamentDTO.MaxPlayers);
            cmd.Parameters.AddWithValue("@minplayers", tournamentDTO.MinPlayers);
            cmd.Parameters.AddWithValue("@location", tournamentDTO.Location);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteTournament(int id)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `tournament` WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
