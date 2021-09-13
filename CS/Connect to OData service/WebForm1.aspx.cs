using DevExpress.Data.ODataLinq;
using ODataDemo;
using System;
using System.Net;

namespace Connect_to_OData_service {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            Uri uri = new Uri("http://services.odata.org/V4/OData/OData.svc/");
            var container = new DemoService(uri);
            var source = new ODataServerModeSource {
                KeyExpression = "ID",
                Query = container.Products
            };
            BootstrapGridView1.DataSource = source;
            BootstrapGridView1.DataBind();
        }
    }
}