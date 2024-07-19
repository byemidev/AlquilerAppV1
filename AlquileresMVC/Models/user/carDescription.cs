using System.Data.SqlClient;
using System.Drawing;

namespace AlquileresMVC.Models.user
{
    public class carDescription
    {


        public string? titulo { get; set; }
        public string? descripcion { get; set; }
        public string? puertas { get; set; }
        public string? anio{ get; set; }
        public string? URLImagen { get; set; }


        public string SelectAll = $"select v.Provincia,     from [alquilerdb].[dbo].[Vehiculo];";
        public List<carDescription> GetAllDescriptions(SqlConnection conexion)
        {
            List<carDescription> descriptions_aux = new List<carDescription>(); 

            conexion.Open();
            using (SqlCommand cmd = conexion.CreateCommand())
            {
                cmd.CommandText = SelectAll;
                SqlDataReader reader =  cmd.ExecuteReader();

                while (reader.Read()) {
                    descriptions_aux.Add(new carDescription { 
                        
                        titulo = reader[0].ToString()   
                        
                        });
                }
            }
            return descriptions_aux;
            //TODO: getdata from vehicles
        }
    }
}
