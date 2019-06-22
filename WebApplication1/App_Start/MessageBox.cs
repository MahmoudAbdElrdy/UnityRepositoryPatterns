using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebApplication1.App_Start
{
    public static class MessageBox
    {public static void ShowMessage(string Msg,Page page)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "MessageBox", "alert(" + Msg.Replace(" ", "/") + ");", true);
        }
    }
}