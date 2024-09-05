using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace first_web_api.Controllers
{
    public class DepartmentController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @" 
                    select DepartmentId, DepartmentName
                            from dbo.Department";
            Datatable table = new Datatable();
            using(var con= new SqlConnection(ConfigurationManager. ConnectionStrings["EmployeeAppDb"].ConnectionString))
            using (var cmd = new SqlCommand(query, con))
            using (var da= new SqlDataAdapter(cmd))
            {
                cmd.Commandtype = CommandType.Text;
                da.Fill(table);
            }
        }
    }
}
