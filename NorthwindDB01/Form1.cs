using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NorthwindDB01.Context;
using NorthwindDB01.Entities;
using System.Data;

namespace NorthwindDB01
{
    public partial class Form1 : Form
    {
        NorthwindContext context = new NorthwindContext();
        SqlParameter top = new SqlParameter() { ParameterName = "@top", Value = 5, SqlDbType = SqlDbType.Int };
        SqlParameter overallCount
            = new SqlParameter() { ParameterName = "@overallcount", SqlDbType = SqlDbType.Int, Direction = ParameterDirection.Output };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /// - 1 - 
            //var Products = ShowProductsBySqlStatements();
            //GV1.DataSource = Products;


            /// - 2 -
            //DTO_Extract();


            /// - 3 - : DTO from SQL raw
            //DTO_From_SQL();


            /// - 4 - : DTOW from View in DB
            DTO_From_View();

        }

        private void DTO_From_View()
        {
            GV1.DataSource = context.ProductsView.ToList();
        }

        private void DTO_From_SQL()
        {
            var sqlS = @"SELECT        
                        Categories.CategoryName AS Category,
                        Products.ProductName AS Product
                        FROM            
                        Categories INNER JOIN
                        Products ON Categories.CategoryID = Products.CategoryID";
            var results = context.Set<ProductCategory>().FromSqlRaw(sqlS).ToList();
            GV1.DataSource = results;
        }

        private void DTO_Extract()
        {
            // this for preview a non-entity element from DB by using SP , or SQL Raw statements .
            GV1.DataSource =
                context
                .Set<TopCustomer>()
                .FromSqlRaw("EXEC [GetTopIDs] @top , @overallcount", top, overallCount)
                .ToList();
        }

        private List<Product> ShowProductsBySqlStatements()
        {
            // that when the return type of the SP or SQL statement is Entity in my EF Tracker
            return
                //context.Products.FromSqlRaw("EXEC SelectAllProducts").ToList(); // stored procedure without parameters
                //context.Products
                //.FromSqlRaw("Select * from Products Where UnitPrice > @Price", new SqlParameter("@Price" , 100)).ToList(); // Raw SQL statements with Parameters
                context.Products.FromSqlInterpolated($"Select * From Products Where UnitPrice > {100}").ToList();   // SqlInterpolated with Parameters
        }



        private void button1_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }
    }
}