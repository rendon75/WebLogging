using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebLogging
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Trace.Write("ASP.NET TRACE", "page_load called.");
            Trace.Write("ASP.NET TRACE", "page_load finished.");
        }
    }
}