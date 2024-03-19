using MySql.Data.MySqlClient;
// using api.data;
namespace api.Models
{
    public class Furniture
    {
        public string Name { get; set; }
        public string Owner { get; set; }

        public static List<Furniture> GetAllFurniture()
        {
            List<Furniture> mytitleTownFs = new List<Furniture>(); 
            Database database = new Database(); 
            using var con = database.GetPublicConnection();
            con.Open(); 

            string stm = "Select * from titleTownFs";
            MySqlCommand cmd = new MySqlCommand(stm, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();



            while (rdr.Read())
            {
                Console.WriteLine(new Furniture() { Name = rdr.GetString(1), Owner = rdr.GetString(2) });
            }
            con.Close();
            return mytitleTownFs; 
        }


    }
}