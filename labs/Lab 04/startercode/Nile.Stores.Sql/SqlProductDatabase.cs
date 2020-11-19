/*
 * ITSE 1430
 * Matthew Traywick
 * Lab 04
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : IProductDatabase
    {

        public SqlProductDatabase (string connector)
        {
            _connector = connector;
        }

        private readonly string _connector;

        public Product Add ( Product product )
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("AddProduct", connection) {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@isdiscontinued", product.IsDiscontinued);
                command.Parameters.AddWithValue("@description", product.Description);
                
                var dbId = command.ExecuteScalar();
                var id = Convert.ToInt32(dbId);

                product.Id = id;
                return product;
            };
        }

        public Product Get ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("GetProduct", connection) {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@id", id);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dbId = reader.GetInt32(0);
                        if (id == dbId)
                            return new Product() {
                                Id = id,
                                Name = reader.GetString(1),
                                Description = reader.GetString(2),
                                Price = reader.GetInt32(3),
                                IsDiscontinued = reader.GetBoolean(4)
                            };
                    }

                    throw new ArgumentException(nameof(id), "Not found!");
                }
            }
        }

        public IEnumerable<Product> GetAll ()
        {
            var dataSet = new DataSet();

            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("GetAllProducts", connection) {
                    CommandType = CommandType.StoredProcedure
                };

                using (var reader = command.ExecuteReader())
                {
                    var table = new DataTable();
                    table.Load(reader);

                    foreach (var row in table.Rows.OfType<DataRow>())
                        yield return new Product() {
                            Id = row.Field<int>("id"),
                            Name = row.Field<string>("name"),
                            Description = row.Field<string>("description"),
                            IsDiscontinued = row.Field<bool>("isdiscontinued"),
                            Price = row.Field<decimal>("price"),
                        };
                }
            }
        }

        public void Remove ( int id )
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("RemoveProduct", connection) {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            };
        }

        public Product Update ( Product product )
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("UpdateProduct", connection) {
                    CommandType = CommandType.StoredProcedure
                };

                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@description", product.Description);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@isDiscontinued", product.IsDiscontinued);

                command.ExecuteNonQuery();
                return product;
            }
        }

        private SqlConnection OpenConnection ()
        {
            var connector = new SqlConnection(_connector);
            connector.Open();
            return connector;
        }
    }
}
