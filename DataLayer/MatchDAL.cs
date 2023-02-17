using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class MatchDAL : IMatchDAL
    {
        Database database = new Database();
        int effectedRows;
        public void AddMatch(List<MatchDTO> matches)
        {
            foreach(MatchDTO match in matches)
            {
                MySqlConnection conn = new MySqlConnection(database.Connection);
                conn.Open();
                MySqlCommand cmdTrnmt = new MySqlCommand("INSERT INTO `matches`(`match id`, `tournament id`, `home player id`, `away player id`, `home player score`, `away player score`, `home player points`, `away player points`) VALUES (@matchId,@tournamentId,@homePlyrId,@awayPlyrId,@homePlyrScore,@awayPlyrScore,@homePlyrPoints,@awayPlyrPoints)", conn);
                cmdTrnmt.Parameters.AddWithValue("@matchId", default);
                cmdTrnmt.Parameters.AddWithValue("@tournamentId", match.TournamentId);
                cmdTrnmt.Parameters.AddWithValue("@homePlyrId", match.HomePlayerId);
                cmdTrnmt.Parameters.AddWithValue("@awayPlyrId", match.AwayPlayerId);
                cmdTrnmt.Parameters.AddWithValue("@homePlyrScore", match.HomePlayerScore);
                cmdTrnmt.Parameters.AddWithValue("@awayPlyrScore", match.AwayPlayerScore);
                cmdTrnmt.Parameters.AddWithValue("@homePlyrPoints", match.HomePlayerPoints);
                cmdTrnmt.Parameters.AddWithValue("@awayPlyrPoints", match.AwayPlayerPoints);
                cmdTrnmt.ExecuteNonQuery();
                conn.Close();
            }
        }
        public List<MatchDTO> QueryMatch(int id)
        {
            List<MatchDTO> matchesDTOList = new List<MatchDTO>();
            MySqlConnection conn = new MySqlConnection(database.Connection);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `matches` WHERE `tournament id` = @id", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    matchesDTOList.Add(new MatchDTO(Convert.ToInt32(reader["match id"]), Convert.ToInt32(reader["tournament id"]), Convert.ToInt32(reader["home player id"]), Convert.ToInt32(reader["away player id"]), Convert.ToInt32(reader["home player score"]), Convert.ToInt32(reader["away player score"]), Convert.ToInt32(reader["home player points"]), Convert.ToInt32(reader["away player points"])));
                }
            }
            conn.Close();
            return matchesDTOList;
        }
        public bool CheckIfTournamentHasSchedule(int idTournament)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("select `tournament id` from `matches` WHERE `tournament id` = @idTournament", connection);
                    cmd.Parameters.AddWithValue("@idTournament", idTournament);
                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        if (Convert.ToInt32(read["tournament id"]) == idTournament)
                        {
                            return true;
                        }
                    }
                    return false;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public void AddMatchResult(int matchId, int homePlayerScore, int awayPlayerScore, int homePlayerPoints, int awayPlayerPoints)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `matches` SET `home player score`= @homePlayerScore,`away player score`= @awayPlayerScore,`home player points`= @homePlayerPoints,`away player points`= @awayPlayerPoints WHERE `match id` = @matchId", conn);
            cmd.Parameters.AddWithValue("@matchId", matchId);
            cmd.Parameters.AddWithValue("@homePlayerScore", homePlayerScore);
            cmd.Parameters.AddWithValue("@awayPlayerScore", awayPlayerScore);
            cmd.Parameters.AddWithValue("@homePlayerPoints", homePlayerPoints);
            cmd.Parameters.AddWithValue("@awayPlayerPoints", awayPlayerPoints);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<MatchDTO> SelectAllMatches()
        {
            List<MatchDTO> matchDTOList = new List<MatchDTO>();
            MySqlConnection conn = new MySqlConnection(database.Connection);

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `matches`", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    matchDTOList.Add(new MatchDTO(Convert.ToInt32(reader["match id"]), Convert.ToInt32(reader["tournament id"]), Convert.ToInt32(reader["home player id"]), Convert.ToInt32(reader["away player id"]), Convert.ToInt32(reader["home player score"]), Convert.ToInt32(reader["away player score"]), Convert.ToInt32(reader["home player points"]), Convert.ToInt32(reader["away player points"])));
                }
            }
            conn.Close();
            return matchDTOList;
        }
    }
}
