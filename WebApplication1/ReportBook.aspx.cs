using System;
using System.Linq;
using System.Web.UI.WebControls;
using DataAcess.Models;
using Microsoft.Reporting.WebForms;
using WebApplication1.App_Start;

namespace WebApplication1
{
    public partial class ReportBook : System.Web.UI.Page
    {
        DateTime date;
        DateTime date1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //MessageBox.ShowMessage("This Error",this.Page);
           
       }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == " " || TextBox3.Text == "")
            {
                MessageBox.ShowMessage("This Error", this.Page);
               // Response.Write("<SCRIPT>alert('THis ERRROR')</SCRIPT>");
            }
            date = DateTime.Parse(TextBox2.Text);
            date1 = DateTime.Parse(TextBox3.Text);
            
            //  
            using (DBEntities dc = new DBEntities())
            {
                var books = dc.ProcRport1(date, date1).ToList();
                //  List<Book> books;
                //  books = dc.Books.OrderBy(a => a.BookID).ToList();
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/RepProc.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rdc = new ReportDataSource("DBDataSet", books);
                ReportViewer1.LocalReport.DataSources.Add(rdc);
                ReportViewer1.LocalReport.Refresh();
                ReportViewer1.DataBind();
            }
        }
        public void GetData()
        {
            //if (!IsPostBack)
            //{
                date = DateTime.Parse(TextBox2.Text);
                date1 = DateTime.Parse(TextBox3.Text);
                //   List<Book> books;
                using (DBEntities dc = new DBEntities())
                {
                    var books = dc.ProcRport1(date, date1).ToList();
                    //   books = dc.Books.OrderBy(a => a.BookID).ToList();
                    ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/RepProc.rdlc");
                    ReportViewer1.LocalReport.DataSources.Clear();
                    ReportDataSource rdc = new ReportDataSource("DBDataSet", books);
                    ReportViewer1.LocalReport.DataSources.Add(rdc);
                 ReportViewer1.LocalReport.Refresh();
                // ReportViewer1.DataBind(); }

                //  
            }

           
        }
    }

}