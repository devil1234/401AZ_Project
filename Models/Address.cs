using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;

namespace _401AZ_PROJECT.Models
{
    /// <summary>
    /// Class Address.
    /// Implements the <see cref="_401AZ_PROJECT.Models.Person" />
    /// </summary>
    /// <seealso cref="_401AZ_PROJECT.Models.Person" />
    public class Address : Person
    {
        private readonly DataManager _c = new DataManager();

        /// <summary>
        /// Gets the addresses by city.
        /// </summary>
        /// <param name="address_city_par">The address city parameter</param>
        /// <returns>List&lt;Address&gt;.</returns>
        public List<Address> GetAddressesByCity(string address_city_par)
        {
            var adr = new List<Address>();
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_select_address_by_adddress_city", connection))
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

        /// INSERT TO DATABASE AND END RETURN THE LAST ID INSERTED
        /// <summary>
        /// Inserts the address details.
        /// </summary>
        /// <param name="address_street_par">The address street parameter</param>
        /// <param name="address_city_par">The address city parameter</param>
        /// <param name="address_region_par">The address region parameter</param>
        /// <param name="address_postcode_par">The address postcode parameter</param>
        /// <returns>addressId</returns>
        public void InsertAddressDetails(string address_street_par, string address_city_par, string address_region_par, string address_postcode_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_insert_address", connection))
                {
                    cmd.Parameters.AddWithValue("address_street_par", address_street_par);
                    cmd.Parameters.AddWithValue("address_city_par", address_city_par);
                    cmd.Parameters.AddWithValue("address_region_par", address_region_par);
                    cmd.Parameters.AddWithValue("address_postcode_par", address_postcode_par);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Updates the address details.
        /// </summary>
        /// <param name="address_id_par">The address identifier parameter</param>
        /// <param name="address_street_par">The address street parameter</param>
        /// <param name="address_city_par">The address city parameter</param>
        /// <param name="address_region_par">The address region parameter</param>
        /// <param name="address_postcode_par">The address postcode parameter</param>
        public void UpdateAddressDetails(int address_id_par, string address_street_par, string address_city_par, string address_region_par, string address_postcode_par)
        {
            using (var connection = new MySqlConnection(_c.ConnectionDetails))
            {
                connection.Open();
                using (var cmd = new MySqlCommand("sp_update_address", connection))
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
