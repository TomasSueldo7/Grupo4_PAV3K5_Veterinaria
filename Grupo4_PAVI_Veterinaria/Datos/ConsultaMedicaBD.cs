using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_PAVI_Veterinaria.Datos
{
    internal class ConsultaMedicaBD
    {

        public static string UltimaConsultaXNroHC(string nroHc)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT MAX(C.Id_Consulta) FROM Consultas C JOIN Perros P ON P.Nro_HC = C.Nro_HC WHERE C.Nro_HC = @nroHC AND P.Activo = 1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroHC", nroHc);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                int id = resultado + 1;
                return id.ToString();

            }
            catch (Exception)
            {
                return "1";
            }
            finally
            {
                cn.Close();
            }
        }

        internal static DataTable ObtenerListadoMedicamentos(String desde, String hasta)
        {
            string diadesde = (desde[0]).ToString() + (desde[1]).ToString();
            string mesdesde = (desde[3]).ToString() + (desde[4]).ToString();
            string añodesde = (desde[6]).ToString() + (desde[7]).ToString() + (desde[8]).ToString() + (desde[9]).ToString();
            string diahasta = (hasta[0]).ToString() + (hasta[1]).ToString();
            string meshasta = (hasta[3]).ToString() + (hasta[4]).ToString();
            string añohasta = (hasta[6]).ToString() + (hasta[7]).ToString() + (hasta[8]).ToString() + (hasta[9]).ToString();
            string fecha1 = añodesde + "-" + mesdesde + "-" + diadesde;
            string fecha2 = añohasta + "-" + meshasta + "-" + diahasta;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                //string consulta1 = "SELECT Nro_HC, Nombre, Fecha_nacimiento, Id_raza, Id_owner, Peso, Altura FROM Perros";

                string consulta = "select r.Denominacion, m.Medicacion, COUNT(*) as 'Usos' from Consultas c JOIN MedicamentosXConsulta mc ON(c.Nro_HC = mc.Nro_HC AND c.Id_Consulta = mc.Id_consulta) JOIN Medicamentos m ON m.Id_medicamento = mc.Id_medicamento JOIN Perros p ON p.Nro_HC = c.Nro_HC JOIN Razas r ON r.Id_raza = p.Id_raza  where c.Fecha between @fecha1 and @fecha2 GROUP BY r.Denominacion, m.Medicacion ORDER BY COUNT(*) desc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha1", fecha1);
                cmd.Parameters.AddWithValue("@fecha2", fecha2);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        internal static DataTable ObtenerListadoHC(String desde, String hasta)
        {
            string diadesde = (desde[0]).ToString() + (desde[1]).ToString();
            string mesdesde = (desde[3]).ToString() + (desde[4]).ToString();
            string añodesde = (desde[6]).ToString() + (desde[7]).ToString() + (desde[8]).ToString() + (desde[9]).ToString();
            string diahasta = (hasta[0]).ToString() + (hasta[1]).ToString();
            string meshasta = (hasta[3]).ToString() + (hasta[4]).ToString();
            string añohasta = (hasta[6]).ToString() + (hasta[7]).ToString() + (hasta[8]).ToString() + (hasta[9]).ToString();
            string fecha1 = añodesde + "-" + mesdesde + "-" + diadesde;
            string fecha2 = añohasta + "-" + meshasta + "-" + diahasta;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                //string consulta1 = "SELECT Nro_HC, Nombre, Fecha_nacimiento, Id_raza, Id_owner, Peso, Altura FROM Perros";

                string consulta = "select CONVERT(varchar,c.Fecha, 103) as Fecha, s.Descripcion, m.Medicacion, p.Nombre, p.Nro_HC  from Consultas c JOIN MedicamentosXConsulta mc ON(c.Nro_HC = mc.Nro_HC AND c.Id_Consulta = mc.Id_consulta) JOIN Medicamentos m ON m.Id_medicamento = mc.Id_medicamento JOIN SintomasXConsultas sc ON(sc.Id_consulta = c.Id_Consulta AND c.Nro_HC = sc.Nro_HC) JOIN Sintomas s ON s.Id_sintoma = sc.Id_sintoma JOIN Perros p ON p.Nro_HC = c.Nro_HC where c.Fecha between @fecha1 and @fecha2 GROUP BY Fecha, s.Descripcion, m.Medicacion, p.Nombre, p.Nro_HC ORDER BY Fecha desc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha1", fecha1);
                cmd.Parameters.AddWithValue("@fecha2", fecha2);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        internal static DataTable ObtenerListadoConsultasPorRaza(String desde, String hasta)
        {
            string diadesde = (desde[0]).ToString() + (desde[1]).ToString();
            string mesdesde = (desde[3]).ToString() + (desde[4]).ToString();
            string añodesde = (desde[6]).ToString() + (desde[7]).ToString() + (desde[8]).ToString() + (desde[9]).ToString();
            string diahasta = (hasta[0]).ToString() + (hasta[1]).ToString();
            string meshasta = (hasta[3]).ToString() + (hasta[4]).ToString();
            string añohasta = (hasta[6]).ToString() + (hasta[7]).ToString() + (hasta[8]).ToString() + (hasta[9]).ToString();
            string fecha1 = añodesde + "-" + mesdesde + "-" + diadesde;
            string fecha2 = añohasta + "-" + meshasta + "-" + diahasta;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                //string consulta = "select month(c.Fecha) as Fecha, count(c.Id_Consulta) as Cantidad from Consultas c group by month(c.Fecha)";
                string consulta = "Select DATENAME(MONTH,c.Fecha) as Mes, count(c.Id_Consulta) as Cantidad from Consultas c where c.Fecha between @fecha1 and @fecha2 group by DATENAME(MONTH,c.Fecha)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha1", fecha1);
                cmd.Parameters.AddWithValue("@fecha2", fecha2);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool VerificarLegajo(int legajo)
        {
            bool resultado = false;

            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();


                string consulta = "SELECT * FROM Empleados WHERE Legajo = @Legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Legajo", legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                };
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
        public static bool AltaNuevaConsulta(int nroHC, int idConsulta, int legajo, List<int> listaMedicamentos, List<int> listaSintomas)
        {
            if (VerificarLegajo(legajo))
            {
                string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
                SqlTransaction objTransaccion = null;
                SqlConnection cn = new SqlConnection(cadenaConexion);
                try
                {
                    SqlCommand cmd = new SqlCommand();


                    string consulta = "INSERT INTO Consultas VALUES(@nroHC,@idConsulta,@fecha, @legajo)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nroHC", nroHC);
                    cmd.Parameters.AddWithValue("@idConsulta", idConsulta);
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@legajo", legajo);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;


                    cn.Open();
                    objTransaccion = cn.BeginTransaction("AltaConsultaMedica");
                    cmd.Transaction = objTransaccion;
                    cmd.Connection = cn;

                    cmd.ExecuteNonQuery();

                    foreach (var idMedicamento in listaMedicamentos)
                    {
                        string consulta2 = "INSERT INTO MedicamentosXConsulta VALUES(@idMedicamento, @nroHC,@idConsulta)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idMedicamento", idMedicamento);
                        cmd.Parameters.AddWithValue("@nroHC", nroHC);
                        cmd.Parameters.AddWithValue("@idConsulta", idConsulta);

                        cmd.CommandText = consulta2;
                        cmd.ExecuteNonQuery();
                    }

                    foreach (var idSintoma in listaSintomas)
                    {
                        string consulta3 = "INSERT INTO SintomasXConsultas VALUES(@nroHC,@idConsulta,@idSintoma)";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idSintoma", idSintoma);
                        cmd.Parameters.AddWithValue("@nroHC", nroHC);
                        cmd.Parameters.AddWithValue("@idConsulta", idConsulta);

                        cmd.CommandText = consulta3;
                        cmd.ExecuteNonQuery();
                    }

                    objTransaccion.Commit();
                    return true;


                }
                catch (Exception)
                {
                    objTransaccion.Rollback();
                    return false;
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                MessageBox.Show("El legajo ingresado no corresponde con un empleado activo. Por favor verifique el campo.");
                return false;
            }
            
        }
    }
}
