using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class DatosCliente
    {
        private string _connectionString;

        public DatosCliente(string connectionString)
        {
            _connectionString = "Data Source=JEAN-MARTILLO\\SQLEXPRESS;Initial Catalog=PruebaNexTI;Integrated Security=True;Persist Security Info=False";
          
        }

        public int AddClient(Cliente client)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Cliente (Nombre, Apellido, Cedula, Telefono, Correo, FotoPerfil, Cursos) " +
                                                     "VALUES (@Name, @LastName, @IdentityCard, @Phone, @Email, @ProfilePhoto, @Courses); " +
                                                     "SELECT SCOPE_IDENTITY();", connection);

                command.Parameters.AddWithValue("@Name", client.Nombre);
                command.Parameters.AddWithValue("@LastName", client.Apellido);
                command.Parameters.AddWithValue("@IdentityCard", client.Cedula);
                command.Parameters.AddWithValue("@Phone", client.Telefono);
                command.Parameters.AddWithValue("@Email", client.Correo);
                command.Parameters.AddWithValue("@ProfilePhoto", client.FotoPerfil);
                command.Parameters.AddWithValue("@Courses", client.Cursos);

                connection.Open();
                object result = command.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        public DataTable GetAllClients()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Cliente", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable clientsTable = new DataTable();
                adapter.Fill(clientsTable);

                return clientsTable;
            }
        }

        public Cliente GetClientById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Cliente WHERE ID = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Cliente client = new Cliente
                    {
                        ID = reader.GetInt32(reader.GetOrdinal("ID")),
                        Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                        Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                        Cedula = reader.GetString(reader.GetOrdinal("Cedula")),
                        Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                        Correo = reader.GetString(reader.GetOrdinal("Correo")),
                        FotoPerfil = (byte[])reader["FotoPerfil"],
                        Cursos = reader.GetString(reader.GetOrdinal("Cursos"))                        

                    };

                    return client;
                }
                else
                {
                    return null;
                }
            }
        }

    }
}