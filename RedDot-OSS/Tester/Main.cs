/*
 * Created by SharpDevelop.
 * User: Nick
 * Date: 2/22/2007
 * Time: 1:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using RQL;

namespace Tester
{
	class MainClass
	{
		public static void Main(string[] args)
		{
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
			
			Console.ReadLine();
		}
	}
}
