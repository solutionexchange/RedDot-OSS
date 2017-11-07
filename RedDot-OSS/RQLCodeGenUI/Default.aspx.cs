/*
 * Created by SharpDevelop.
 * User: Nick
 * Date: 2/21/2007
 * Time: 9:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using RQL;

namespace RQLCodeGenUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public class Default : Page
	{	

		protected System.Web.UI.WebControls.TextBox TxtClassName;
		protected System.Web.UI.WebControls.TextBox TxtRqlRequest;
		protected System.Web.UI.WebControls.TextBox TxtRqlResponse;
		protected System.Web.UI.WebControls.Button BtnSubmit;
		protected System.Web.UI.WebControls.Literal LitRqlError;
		protected System.Web.UI.WebControls.Literal LitRqlInfo;

		private void Page_Load(object sender, EventArgs e)
		{
			if(IsPostBack)
			{
			}
		}

		protected override void OnInit(EventArgs e)
		{
			InitializeComponent();
			base.OnInit(e);
		}

		private void InitializeComponent()
		{
			this.Load	+= new System.EventHandler(Page_Load);
			this.BtnSubmit.Click += new EventHandler(this.BtnSubmit_Click);
		}
		
		protected void BtnSubmit_Click(object sender, System.EventArgs e)
		{
			object rqlError = String.Empty;
			object rqlInfo = String.Empty;
			RDCMSXMLServer rql = new RDCMSXMLServer();
			string rqlResponse = rql.Execute(this.TxtRqlRequest.Text, ref rqlError, ref rqlInfo);
			this.LitRqlError.Text = rqlError.ToString();
			this.LitRqlInfo.Text = rqlInfo.ToString();
			this.TxtRqlResponse.Text = rqlResponse;
			
			if (this.TxtClassName.Text.Trim().Length > 0) {
				RQLCodeGenerator codeGen = new RQLCodeGenerator(this.TxtRqlRequest.Text, this.TxtRqlResponse.Text, "RQL", this.TxtClassName.Text, Server.MapPath("./output/"));
				codeGen.GenerateCode();
			}
		}

	}
}
