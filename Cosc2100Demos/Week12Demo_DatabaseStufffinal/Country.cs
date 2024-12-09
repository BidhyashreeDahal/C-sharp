using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Week12Demo_DatabaseStufffinal.Properties;


namespace Week12Demo_DatabaseStufffinal
{
    public class Country
    {
        public static List<Country> countries = new List<Country>();
        public String CountryID { get; set; }
        public String CountryName { get; set; }
        public int RegionID { get; set; }
        public Country() { }
        public Country(String countryID, String countryName, int regionID) {
            CountryID = countryID;
            CountryName = countryName;
            RegionID = regionID;

        }
        public static void PopulateCountries()
        {
            try
            {
                SqlConnection conn = new SqlConnection(Settings.Default.dbConn);
                // SqlCommand cmd = new SqlCommand("Select * From Countries" ,conn);
                SqlCommand cmd;
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Select * FROM Countries";
                cmd.CommandType = System.Data.CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                // ------ Assignment 5----------------
                /// For Stored Procedure
                /// cmd.CommandText ="spGetSomeCountries";
                /// cmd.Parameters.AddWithValue("@Letter",letter);
                ///   cmd.CommandType = System.Data.CommandType.Text;

                while (reader.Read())
                {
                    Country c = new Country();
                    c.CountryID = reader["CountryID"].ToString();
                    c.CountryName = reader["CountryName"].ToString();
                    c.RegionID = (int)reader["RegionID"];

                    countries.Add(c);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public bool UpdateCountry()
        {
            

            }

         }
        
    }
}
