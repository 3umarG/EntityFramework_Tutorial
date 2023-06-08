using Microsoft.EntityFrameworkCore;

namespace WF_From_DB
{
    public partial class Form1 : Form
    {
        private NorthwindContext context = new();
        public Form1()
        {
            InitializeComponent();

            this.FormClosed += (sender, e) => context.Dispose();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            #region Lazy Loading different approachs
            // the first way 
            /*
            context.Products.Load(); // Load : load the data from Table into Local Copy 
            this.gvProducts.DataSource = context.Products.Local.ToBindingList();
            */

            // the second way : Lazy Loading , all information about Categorie is NULL because i don't determine the Categorie in Select statement
            //var result = (from P in context.Products
            //             select P).ToList();

            // I continue using Lazy loading , but I generate an except for this select to join with Categorie Table
            var result = (from P in context.Products.Include(P => P.Category) select P).ToList();

            // or I can choose the CategorieID in the select 
            //var result = (from P in context.Products
            //              select new { P.ProductID, P.ProductName, P.CategoryID }).ToList();

            this.gvProducts.DataSource = result;

            #endregion
        }

    }
}