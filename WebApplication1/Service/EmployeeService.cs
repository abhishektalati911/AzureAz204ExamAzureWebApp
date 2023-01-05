


using AzureAz204ExamAzureWebApp.Model;
using System.Data.SqlClient;

namespace AzureAz204ExamAzureWebApp.Service
{
    public class EmployeeService
    {
        public static string db_source = "azureaz204server.database.windows.net";
        public static string db_user = "az204login";
        public static string db_password = "Paratha@2019";
        public static string db_database = "Test";


        private SqlConnection GetConnection()
        {
            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_source;
            _builder.InitialCatalog = db_source;

            return new SqlConnection(_builder.ConnectionString);

        }

        public IEnumerable<Employee> GetEmployee()
        {
            List<Employee> employees = new List<Employee>();
            string str = "select * from test";

            SqlConnection con = GetConnection();
            con.Open();

            SqlCommand cmd = new SqlCommand(str, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Employee employee = new Employee()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Phone = reader.GetString(2)

                    };
                }
            }
            con.Close();

            return employees;

        }
    }
}