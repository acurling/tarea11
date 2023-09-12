using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Menudinamico1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bingresar_Click(object sender, EventArgs e)
        {
            string dc = ConfigurationManager.ConnectionStrings["UPICONEXION"].ConnectionString;

            using (SqlConnection con = new SqlConnection(dc))
            {
                using (SqlCommand cmd = new SqlCommand("DesEncriptarClave", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@USUARIO", SqlDbType.VarChar).Value = TNOMBRE.Text;
                    cmd.Parameters.Add("@CLAVE", SqlDbType.VarChar).Value = TCLAVE.Text;
                    con.Open();
                    cmd.ExecuteReader();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        Response.Redirect("WebForm1.aspx");
                    }
                    else
                    {
                        Label1.Text = "Usuario no Existe";
                    }



                    con.Close();
                }
            }
        }
    }
}