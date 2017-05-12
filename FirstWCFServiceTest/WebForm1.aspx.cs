using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FirstWCFServiceTest.HelloWorldReference;

namespace FirstWCFServiceTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private HelloWorldReference.HelloworldServiceClient client = new HelloWorldReference.HelloworldServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = client.GetEmployee(22);
            }
            catch (FaultException<HelloFault> exception)
            {
                Response.Write(exception.Detail.ErrorDescription);
            }
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            //var result = client.GetEmployee(2);
            try
            {
                var res = client.Divide(22, 0);
            }
            catch (FaultException<HelloFault> exception)
            {
                Response.Write(exception.Detail.ErrorDescription);
            }
        }
    }
}