using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LinqPracticeWebApp
{
    public partial class LinqPractice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //LINQ to Object
            int[] numbers = { 1, 21, 24, 15, 26, 68, 74, 12 };

            GridView1.DataSource = from number in numbers
                                   where (number % 2) == 0
                                   select number;

            GridView1.DataBind();

            //LINQ to Sql
            StudentDataContext db = new StudentDataContext();

            GridView2.DataSource = from s in db.Students
                                   where s.Gender=="Male"
                                   orderby s.Name
                                   select s;

            GridView2.DataBind();

            //LINQ query using Lambda Expressions

            IEnumerable<Customer> result= Customer.GetAllCustomers().Where(c => c.Gender == "Male");

            GridView3.DataSource = result;

            GridView3.DataBind();


            //LINQ query using SQL 

            IEnumerable<Customer> resultlists = from c in Customer.GetAllCustomers()
                                                where c.Gender == "Female"
                                                select c;

            GridView4.DataSource = resultlists;

            GridView4.DataBind();

        }
    }
}