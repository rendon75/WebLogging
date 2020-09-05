using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebLogging
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Create a trace listener for Web forms.
            WebPageTraceListener gbTraceListener = new WebPageTraceListener();

            // Add the event log trace listener to the collection.
            System.Diagnostics.Trace.Listeners.Add(gbTraceListener);
        }
    }
}