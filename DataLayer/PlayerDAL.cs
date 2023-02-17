using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PlayerDAL : IPlayerDAL
    {
        Database database = new Database();
        private int effectedRows;
        public int EffectedRows { get => effectedRows; }

        public List<PersonDTO> SelectAllPlayers()
        {
            List<PersonDTO> listOfPlayer = new List<PersonDTO>();
            MySqlConnection conn = new MySqlConnection(database.Connection);

            MySqlCommand cmd = new MySqlCommand("select * from person where Type = 'player'", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listOfPlayer.Add(new PlayerDTO(Convert.ToInt32(reader["age"]), reader["name"].ToString(), Convert.ToInt32(reader["id"]), reader["password"].ToString(), reader["salt"].ToString()));
                    }
                }
                conn.Close();
                return listOfPlayer;
            }
        public void AddPlayer(PersonDTO person)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmdPlyr = new MySqlCommand("INSERT INTO person VALUES (@name, @id, @password, @Type, @age, @salt, @tournamentID)", conn);
            cmdPlyr.Parameters.AddWithValue("@name", person.Name);
            cmdPlyr.Parameters.AddWithValue("@id", default);
            cmdPlyr.Parameters.AddWithValue("@password", person.Password);
            cmdPlyr.Parameters.AddWithValue("@Type", "player");
            cmdPlyr.Parameters.AddWithValue("@age", person.Age);
            cmdPlyr.Parameters.AddWithValue("@salt", person.Salt);
            cmdPlyr.Parameters.AddWithValue("@tournamentID", 0);
            cmdPlyr.ExecuteNonQuery();
            conn.Close();
        }
        public void DeletePlayer(PersonDTO playerDTO)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `person` WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", playerDTO.ID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public bool Login(int id, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("select * from person", connection);

                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        if (Convert.ToInt32(read["id"]) == id && read["password"].ToString() == password)
                        {
                            return true;
                        }
                    }
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
            return false;
        }
        public string GetSaltOfPlayer(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("select * from person where type = 'player'", connection);

                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        if (Convert.ToInt32(read["id"]) == id)
                        {
                            return read["salt"].ToString();
                        }
                    }
                }
                return null;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }
        }
        public void AddPlayerToTournament(int idPlayer, int idTournament)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmdPlyr = new MySqlCommand("UPDATE `person` SET `tournament id`= @tournamentid WHERE id = @id", conn);
            cmdPlyr.Parameters.AddWithValue("@id", idPlayer);
            cmdPlyr.Parameters.AddWithValue("@tournamentid", idTournament);
            cmdPlyr.ExecuteNonQuery();
            conn.Close();;
        }
        public bool CheckIfPlayerAlreadyRegistered(int id, int playerId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("select * from person WHERE `tournament id` = @id and `id` = @playerId", connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@playerId", playerId);
                    MySqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        if (Convert.ToInt32(read["tournament id"]) == id)
                        {
                            return true;
                        }
                    }
                    return false;
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
        public List<PlayerDTO> GetPlayersPerTournamendId(int tournamendId)
        {
            List<PlayerDTO> listOfPlayers = new List<PlayerDTO>();
            MySqlConnection conn = new MySqlConnection(database.Connection);

            MySqlCommand cmd = new MySqlCommand("select * from person where `tournament id` = @TournamendId", conn);
            cmd.Parameters.AddWithValue("@TournamendId", tournamendId);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listOfPlayers.Add(new PlayerDTO(Convert.ToInt32(reader["age"]), reader["name"].ToString(), Convert.ToInt32(reader["id"]), reader["password"].ToString(), reader["salt"].ToString()));
                }
            }
            conn.Close();
            return listOfPlayers;
        }
        public int GetCountOfParticipatingPlayers(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(`tournament id`) FROM `person` WHERE `tournament id` = @id", connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return -1; }
        }
        public int GetPlayersTournamentId(int idPlayer)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT `tournament id` FROM `person` WHERE `id` = @idPlayer", connection);
                    cmd.Parameters.AddWithValue("@idPlayer", idPlayer);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return -1; }
        }
        public int GetLeaderBoardOfPlayersHome(int idPlayerHome, int idTournament)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT SUM(`home player points`) FROM `matches` WHERE (`home player id` = @idPlayerHome) AND `tournament id` = @idTournament", connection);
                    cmd.Parameters.AddWithValue("@idPlayerHome", idPlayerHome);
                    cmd.Parameters.AddWithValue("@idTournament", idTournament);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 0; }
        }
        public int GetLeaderBoardOfPlayersAway(int idPlayerAway, int idTournament)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(database.Connection))
                {
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT SUM(`away player points`) FROM `matches` WHERE (`away player id` = @idPlayerAway) AND `tournament id` = @idTournament", connection);
                    cmd.Parameters.AddWithValue("@idPlayerAway", idPlayerAway);
                    cmd.Parameters.AddWithValue("@idTournament", idTournament);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return 0; }
        }
    }
}
