using Entity01;

internal class Program
{
    private static void Main(string[] args)
    {
        // using ====> for Close/Dispose all resources you use after finishing all your work
        using (EnterpriseContext context = new EnterpriseContext())
        {

            // for create the Database if it is not created , if 
            // to ensure that the database is created
            context.Database.EnsureCreated();

            #region Create DB and Insert some Dummy Rows
            /*
           
            // my local objects
            var D1 = new Department { Name = "Engineering" };
            var D2 = new Department { Name = "IT" };

            // adding them locally to my DbSet
            context.Departments.Add(D1);
            context.Departments.Add(D2);

            // for this line there is no data updated or inserted to the database in SQL , all these rows are locally
            // to make all my changes go for DB from My Memory to DB
            context.SaveChanges();
            */
            #endregion

            #region Select , Update , and Insert
            /*
             Console.WriteLine($"Length of Depts before Filtering : {context.Departments.Count()}"); // the total from DB Table
             Console.WriteLine($"Length of Depts Local before Filtering : {context.Departments.Local.Count()}"); // Zero : the local copy of the Data start always by 0 , when query or get any data start increase

             var Result = context.Departments.Where(D => D.Name == "Human Resourcing -HR- ");
             var newDept = Result.FirstOrDefault();

             Console.WriteLine($"Length of Depts after Filtering : {context.Departments.Count()}"); // the total from DB Table doesn't change from the top
             Console.WriteLine($"Length of Depts Local after Filtering : {context.Departments.Local.Count()}");  // 1 : the result of the query from the DB One Matching Dept , the last query result
             // Local : the last successed query result stored on the Local

             if (newDept != null)
                 newDept.Name = "Management";
             else
             {
                 var Dept3 = new Department() { Name = "Accounting"};
                 context.Departments.Add(Dept3);
             }

             context.SaveChanges();
             Console.WriteLine($"Length of Depts after Save changes Filtering : {context.Departments.Count()}");  // the Total number of all rows in the remote DB
             Console.WriteLine($"Length of Depts Local after Save changes Filtering : {context.Departments.Local.Count()}");  // still 1 : because the last query still store its result in the Local DataSet

             // Local : the DataSet fulled by the result of last successed query from DB.
             // Departments : the Actual Table in the Database , for that I do all my jobs on it then told SaveChanges() 
            */
            #endregion

            #region Delete 
            Console.WriteLine($"Table before delete : {context.Departments.Count()}");
            Console.WriteLine($"Local Table before delete : {context.Departments.Local.Count()}"); // 0

            context.Departments.Remove(context.Departments.OrderBy(dept => dept.DepartmentID).Last());

            Console.WriteLine($"Table After delete Locally : {context.Departments.Count()}"); // still not changed
            Console.WriteLine($"Local Table After delete Locally : {context.Departments.Local.Count()}"); // 0 because it deleted

            context.SaveChanges();

            Console.WriteLine($"Table After delete Changes Saved : {context.Departments.Count()}"); // -1 
            Console.WriteLine($"Local Table after delete changes Saved : {context.Departments.Local.Count()}"); // still zero

            #endregion
        }
    }
}