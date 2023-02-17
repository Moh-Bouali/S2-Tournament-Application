using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StaffDAL : IStaffDAL
    {
        Database database = new Database();

        public List<PersonDTO> SelectAllStaffMembers()
        {
            List<PersonDTO> listOfStaff = new List<PersonDTO>();
            MySqlConnection conn = new MySqlConnection(database.Connection);

            MySqlCommand cmd = new MySqlCommand("select * from person where Type = 'staff'", conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    listOfStaff.Add(new StaffMemberDTO(reader["name"].ToString(), Convert.ToInt32(reader["id"]), reader["password"].ToString(), reader["salt"].ToString()));
                }
            }
            conn.Close();
            return listOfStaff;
        }
        public void AddStaff(PersonDTO person)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmdStaff = new MySqlCommand("INSERT INTO person (name, id, password, Type, salt) VALUES (@name, @id, @password, @Type, @salt)", conn);
            cmdStaff.Parameters.AddWithValue("@name", person.Name);
            cmdStaff.Parameters.AddWithValue("@id", default);
            cmdStaff.Parameters.AddWithValue("@password", person.Password);
            cmdStaff.Parameters.AddWithValue("@Type", "staff");
            cmdStaff.Parameters.AddWithValue("@salt", person.Salt);
            cmdStaff.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteStaff(PersonDTO staffDTO)
        {
            MySqlConnection conn = new MySqlConnection(database.Connection);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `person` WHERE id = @id", conn);

            cmd.Parameters.AddWithValue("@id", staffDTO.ID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
