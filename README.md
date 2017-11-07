# RedDot-OSS

A gathering of open source tools, plugins, APIs, and code for use with RedDot CMS.

RedDot CMS is a web content management system providing best in class usability and functionality. Any developer who has used it, though, will concede the frustrations at times with the developer tools and capabilities of the product. This project is aimed at collecting tools, templates, techniques, and plugins which RedDot developers are willing to share with each other.

One primary goal of the project is to create a RQL .NET API which wraps the RedDot Query Language (RQL) API that allows for programmatic access to the RedDot CMS back-end.

More information on RedDot CMS can be found on the RedDot website.

#summary Proposed architecture for RQL API.

## Introduction

In building a true .NET API for calling RQL, code generation is priceless. Especially in the essence of speed of development and maintainability. However, the true "holy grail" is a high-level RQL API which masks the nastiness of RQL XML entirely.

<img src="https://github.com/solutionexchange/RedDot-OSS/blob/master/wiki/RQL%20API%20Architecture.png" />

## Details

### RQL Soap Interface

RedDot, via the Microsoft SOAP Toolkit, provides a SOAP interface to the RDCMSASP.RdPageData COM component. It doesn't do much as far as usability of RQL however, other than giving you a WSDL for producing a .NET client for XML in/out.

### RQL Code Generator

.NET provides APIs for producing .NET classes from an XML schema that can be used for XML serialization and deserialization. The only problem is that RQL, of course, doesn't adhere to a set schema. Even if it did, the attributes and elements needed for the various RQL calls are diverse, and a schema that encompasses all of them wouldn't be very helpful. Luckily, .NET also provides classes for inferring a schema from XML.

The problems continue however. The schemas generated use all anonymous complex types, which don't generate great classes. To get around this, the current pre-alpha code generation code  "optimizes" the schema for RQL code generation. Thus, the code can issue a given RQL request to RedDot, retrieve the response, and generate schema and usable classes for calling RQL. Eventually, some calls may require more than one request/response to realize the full schema for a given RQL call.

The code generation also adds some additional methods/properties to the classes, and encapsulates all the classes needed for a given call as inner classes of a single class for that call. This is aided by a set of base and utility classes which ease the code generation.

### RQL Request DB

Conceptual at this point, the RQL Request DB would provide a mass of RQL calls which would feed the code generator. This will probably require a RedDot CMS project which supports these calls. The code generator thus would have a database of all the calls needed to generate the "low level" API.

### Low Level RQL API

The result of all this code generation would be a low-level RQL API which essentially mimics the RQL XML calls in objects. It looks like this:

<pre>
RQL.Login login = new RQL.Login();
Login.LoginRequest request = new Login.LoginRequest();
request.Data = new Login.LoginRequest.iodata();
request.Data.Administration = new Login.LoginRequest.administration();
request.Data.Administration.Action = "login";
request.Data.Administration.Name = "admin";
request.Data.Administration.Password = "sdemo06";
Login.LoginResponse response = login.Execute(request);
string loginGuid = response.Data.Login.Guid;

RQL.ProjectLogin prjLogin = new RQL.ProjectLogin();
ProjectLogin.ProjectLoginRequest r2 = new ProjectLogin.ProjectLoginRequest();
r2.Data = new ProjectLogin.ProjectLoginRequest.iodata();
r2.Data.Loginguid = loginGuid;
r2.Data.Administration = new ProjectLogin.ProjectLoginRequest.administration();
r2.Data.Administration.Action = "validate";
r2.Data.Administration.Guid = loginGuid;
r2.Data.Administration.Project = new ProjectLogin.ProjectLoginRequest.project();
r2.Data.Administration.Project.Guid = "DA0A74E7ED3B46BDA16B006E2678C744";
ProjectLogin.ProjectLoginResponse resp2 = prjLogin.Execute(r2);
string sessionKey = resp2.Data.Server.Key;

RQL.ProjectSettingsLoad psl = new ProjectSettingsLoad();
ProjectSettingsLoad.ProjectSettingsLoadRequest r3 = new ProjectSettingsLoad.ProjectSettingsLoadRequest();
r3.Data = new ProjectSettingsLoad.ProjectSettingsLoadRequest.iodata();
r3.Data.Loginguid = loginGuid;
r3.Data.Sessionkey = sessionKey;
r3.Data.Project = new ProjectSettingsLoad.ProjectSettingsLoadRequest.project();
r3.Data.Project.Settings = new ProjectSettingsLoad.ProjectSettingsLoadRequest.settings();
r3.Data.Project.Settings.Action = "load";
ProjectSettingsLoad.ProjectSettingsLoadResponse resp3 = psl.Execute(r3);

RQL.Logout logout = new Logout();
Logout.LogoutRequest r4 = new Logout.LogoutRequest();
r4.Data = new Logout.LogoutRequest.iodata();
r4.Data.Loginguid = loginGuid;
r4.Data.Administration = new Logout.LogoutRequest.administration();
r4.Data.Administration.Logout = new Logout.LogoutRequest.logout();
r4.Data.Administration.Logout.Guid = loginGuid;
Logout.LogoutResponse resp4 = logout.Execute(r4);
</pre>

Still not very friendly, but much easier and cleaner than constructing RQL XML via strings or DOM.

### High-Level RQL API

The ultimate goal would be to construct a high-level API which truly abstracts the complexity of RQL. The class structure of this API would require some thorough analysis, but the idea could be something like this...

<pre>
RQLContext rql = RQL.StartSession(username, password);
Project project = Project.FromGuid(rql, guid);
rql.LogOut();
</pre>

Much easier! The API could then be fronted by a COM Wrapper for VB6/ASP access, or a web service for access via any SOAP client.

The holy grail of RQL...

Copyright 2007 Nick Wesselman
