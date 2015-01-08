using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.RequestType == "POST")
            {
                //Response.ContentType = "text/xml";  

                string pltFileName = Request.QueryString["PltFileName"];//PLT文件名  
                string dwgFileName = Request.QueryString["DwgFileName"];//dwg文件名列表 :111.dwg,222.dwg,333.dwg.....  
            }
        }
    }
}