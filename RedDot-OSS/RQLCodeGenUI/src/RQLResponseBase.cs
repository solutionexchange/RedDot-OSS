/*
 * Created by SharpDevelop.
 * User: Nick
 * Date: 2/22/2007
 * Time: 3:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace RQL
{
	/// <summary>
	/// Description of RQLResponseBase.
	/// </summary>
	public class RQLResponseBase
	{
			private string rqlError;
			private string rqlInfo;
						
			public string RqlError {
				get {
					return this.rqlError;
				}
				set {
					this.rqlError = value;
				}
			}
			
			public string RqlInfo {
				get {
					return this.rqlInfo;
				}
				set {
					this.rqlInfo = value;
				}
			}
	}
}
