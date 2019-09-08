# REST-WCF-Service-for-Web-Apps-in-ASP.NET-Hands-On
Implement WCF Service in C#<br />
<ul>
    <li>Create Service folder</li>
    <li>Add new item -> Select WCF Service (Ajax-enabled)</li>
    <li>System.Runtime.Serialization</li>
    <li>System.ServiceModel</li>
    <li>System.ServiceModel.Web</li>
    <li>were added to the References</li>
    <li>Markup of service file will not be updated if you change the namespace of your service</li>
    <li>content of Web.config also changed once the service was added</li>
    <li>Right click service -> View in Browser -> append operation name to service</li>
</ul>
<ul>
    <li>To get Json response</li>
    <li>modify web.config to use webHttp tag in system.serviceModel>behaviors>endpointBehaviors>behavior></li>
    <li>add WebGet(ResponseFormat = WebMessageFormat.Json) attribute to OperationContract in service file</li>
</ul>
Implement service calls with jQuery<br />
Implement CRUD: Create, Read, Update, Delete<br />
Implement additional methods: Filtering, sorting... <br />
