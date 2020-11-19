using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Nile.Stores.Sql
{
    public class SqlProductDatabase : IProductDatabase
    {

        SqlProductDatabase (string connector)
        {
            _connector = connector;
        }

        private readonly string _connector;

        public Product Add ( Product product )
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("AddProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

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
                var command = new SqlCommand("GetProduct", connection);
                command.CommandType = CommandType.StoredProcedure;
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
                var command = new SqlCommand("GetAllProducts", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    var table = dataSet.Tables.Count > 0 ? dataSet.Tables[0] : null;
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
                var command = new SqlCommand("Remove" +
                    "Product", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            };
        }

        public Product Update ( Product product )
        {
            using (var connection = OpenConnection())
            {
                var command = new SqlCommand("UpdateProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

                var paramName = new SqlParameter("@name", product.Name);
                command.Parameters.Add(paramName);
                var paramDescription = new SqlParameter("@description", product.Description);
                command.Parameters.Add(paramDescription);
                var paramPrice = new SqlParameter("@price", product.Price);
                command.Parameters.Add(paramPrice);
                var paramIsDiscontinued = new SqlParameter("@isdiscontinued", product.IsDiscontinued);
                command.Parameters.Add(paramIsDiscontinued);

                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@isdiscontinued", product.IsDiscontinued);
                command.Parameters.AddWithValue("@description", product.Description);

                command.ExecuteNonQuery();
                return product;
            }
        }

        private SqlConnection OpenConnection ()
        {
            using (var connector = new SqlConnection(_connector))
            {
                connector.Open();
                return connector;
            }
        }
    }
}
