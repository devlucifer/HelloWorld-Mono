
using System;
using System.Web;
using System.Web.UI;

using CoreWeb;

namespace HelloWorld
{
	/// <summary>
	/// 
	/// </summary>
	public partial class Default : PageBase
	{
		

		/// <summary>
		/// 
		/// </summary>
		public virtual void button1Clicked (object sender, EventArgs args)
		{
			button1.Text = "You clicked me";
		}
	}
}
