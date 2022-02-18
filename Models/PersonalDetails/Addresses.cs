using _401AZ_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data;
using _401AZ_PROJECT.Classes_Methods.Students.Students;

namespace _401AZ_PROJECT.Classes_Methods.Addresses
{
    public class Address : Person
    {

        readonly DataManager c = new DataManager();

        public List<Address> GetAddressesByCity(string address_city_par)
        {
            List<Address> adr = new List<Address>();
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_select_address_by_adddress_city", connection))
                {
                    cmd.Parameters.AddWithValue("address_city_par", address_city_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            adr.Add(new Address
                            {
                                AddressId = reader.GetInt32(0),
                                AddressStreet = reader.GetString(1),
                                AddressCity = reader.GetString(2),
                                AddressRegion = reader.GetString(3),
                                AddressPostcode = reader.GetString(4)
                            });
                        }
                    }
                }
                connection.Close();
                return adr;
            }
        }

        // INSERT TO DATABASE AND END RETURN THE LAST ID INSERTED
        public int InsertAddressDetails(string address_street_par, string address_city_par, string address_region_par, string address_postcode_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_insert_address", connection))
                {
                    cmd.Parameters.AddWithValue("address_street_par", address_street_par);
                    cmd.Parameters.AddWithValue("address_city_par", address_city_par);
                    cmd.Parameters.AddWithValue("address_region_par", address_region_par);
                    cmd.Parameters.AddWithValue("address_postcode_par", address_postcode_par);
                    cmd.Parameters.Add("@address_id_par", MySqlDbType.Int32, 11);
                    cmd.Parameters["@address_id_par"].Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteScalar();
                    int address_id = Convert.ToInt32(cmd.Parameters["@address_id_par"].Value.ToString());
                    return address_id;
                }
            }
        }

        public void UpdateAddressDetails(int address_id_par, string address_street_par, string address_city_par, string address_region_par, string address_postcode_par)
        {
            using (var connection = new MySqlConnection(c.connection_details))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand("sp_update_address", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("address_id_par", address_id_par);
                    cmd.Parameters.AddWithValue("address_street_par", address_street_par);
                    cmd.Parameters.AddWithValue("address_city_par", address_city_par);
                    cmd.Parameters.AddWithValue("address_region_par", address_region_par);
                    cmd.Parameters.AddWithValue("address_postcode_par", address_postcode_par);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}
