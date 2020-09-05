using System;
using System.Web;
using System.Data;

namespace PubsClasses
{
    public class AuthorClass
    {
        private DataSet dsAuthors = new DataSet("ds1");
        private String filePath =
            HttpContext.Current.Server.MapPath("~/App_Data/authors.xml");

        public AuthorClass()
        {
            dsAuthors.ReadXml(filePath, XmlReadMode.ReadSchema);
            System.Diagnostics.Trace.WriteLine("AuthorClass is created.", "AUTHORCLASS TRACE");
        }

        public DataSet GetAuthors()
        {
            System.Diagnostics.Trace.WriteLine("GetAuthors called.", "AUTHORCLASS TRACE");
            return dsAuthors;
        }
    }
}