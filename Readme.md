<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128549003/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T585747)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to bind the Bootstrap GridView to a Web Service


<p>This example demonstrates how to bind a <a href="https://documentation.devexpress.com/AspNetBootstrap/117691/Grid-View">BootstrapGridView</a> to the <a href="https://en.wikipedia.org/wiki/Web_data_services">Web Service</a>. The "Connect to OData service" project represents a web application and the BootstrapGridView control. The BootstrapGridView is bound to a data source with the <a href="https://documentation.devexpress.com/CoreLibraries/DevExpress.Data.ODataLinq.ODataServerModeSource.class">ODataServerModeSource</a> in the Page_Load event handler. Since the ODataServerModeSource component is inaccessible at design time, it can only be used at runtime. To connect our web application to the Web Service, it is necessary to create the "Reference.cs" class. You can use the <a href="https://marketplace.visualstudio.com/items?itemName=laylaliu.ODataConnectedService">OData Connected Service</a> wizard to create and fill this class automatically.<br>In this solution, the<a href="http://www.odata.org/"> OData</a> web service is represented by the public <a href="http://services.odata.org/V4/OData/OData.svc/">OData URL</a>.<br>Also, the<a href="http://www.odata.org/"> OData</a> service can be generated locally using the "<a href="https://documentation.devexpress.com/CoreLibraries/14812/DevExpress-ORM-Tool/Design-Time-Features/OData-Service-Wizard">DevExpress v17.2 ORM OData Service</a>" wizard for creating an XPO OData Service that can also include a visual data model.</p>

<br/>

<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/Connect%20to%20OData%20service/WebForm1.aspx)
* [WebForm1.aspx.cs](./CS/Connect%20to%20OData%20service/WebForm1.aspx.cs)
<!-- default file list end -->
