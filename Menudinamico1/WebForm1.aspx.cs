using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

namespace Menudinamico1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
      string str = "Data Source=DESKTOP-R60ATPU;Initial Catalog=Menudinamico2;Integrated Security=True";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BuscarUsuarios();
            }
            CargarMenu();
        }

        private HtmlGenericControl UList(string id, string cssClass)
        {
            HtmlGenericControl ul = new HtmlGenericControl("ul");
            ul.ID = id;
            ul.Attributes.Add("class", cssClass);
            return ul;
        }

        private HtmlGenericControl LIList(string innerHtml, string rel, string url)
        {
            HtmlGenericControl li = new HtmlGenericControl("li");
            li.Attributes.Add("rel", rel);
            li.InnerHtml = "<a href=" + string.Format("http://{0}", url) + ">" + innerHtml + "</a>";
            return li;

        }

        private void BuscarUsuarios()
        {
            SqlConnection con = new SqlConnection(str);
            string com = "Select * from Usuario";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DropDownList1.DataSource = dt;
            DropDownList1.DataBind();
            DropDownList1.DataTextField = "Nombre";
            DropDownList1.DataValueField = "UsuarioID";
            DropDownList1.DataBind();
        }
        
        private void CargarMenu()
        {
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select  pm.MenuID,m.MenuNombre,m.MenuURL from PerfilMenu as pm " +
                 " inner join UsuarioPerfil as up ON pm.PerfilD = up.UsuarioID  " +
                   " inner join Menu as m ON pm.MenuID = m.MenuID  " +
                     " where UsuarioPerfil = " + DropDownList1.SelectedValue + "", con);

            DataTable dttc = new DataTable();
            da.Fill(dttc);
            HtmlGenericControl main = UList("Menuid", "menu");
            foreach (DataRow row in dttc.Rows)
            {
                da = new SqlDataAdapter("select MenuCategoriaID,MenuCategoryNombre,MenuCategoryURL from MenuCategoria where MenuID=" + row["MenuID"].ToString(), con);
                DataTable dtDist = new DataTable();
                da.Fill(dtDist);

                if (dtDist.Rows.Count > 0)
                {
                    HtmlGenericControl sub_menu = LIList(row["MenuNombre"].ToString(), row["MenuID"].ToString(), row["MenuURL"].ToString());
                    HtmlGenericControl ul = new HtmlGenericControl("ul");

                    foreach (DataRow r in dtDist.Rows)
                    {
                        ul.Controls.Add(LIList(r["MenuCategoryNombre"].ToString(), r["MenuCategoriaID"].ToString(), r["MenuCategoryURL"].ToString()));
                    }
                    sub_menu.Controls.Add(ul);
                    main.Controls.Add(sub_menu);

                }
                else
                {
                    main.Controls.Add(LIList(row["MenuNombre"].ToString(), row["MenuID"].ToString(), row["MenuURL"].ToString()));

                }

            }
            Panel1.Controls.Add(main);
            da.Fill(dttc);

        }

    }
}
