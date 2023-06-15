using NorthwindReversedPowerTools.Context;

internal class Program
{
    private static async Task Main(string[] args)
    {
        OutputParameter<int?> outputParameter = new();

        using (NorthwindContext context = new NorthwindContext())
        {
            var Procedures = new NorthwindContextProcedures(context);

            var topIDs =  await Procedures.GetTopIDsAsync(10, outputParameter);


            // the code after await line will be suspended until the await returns its value ...
            Console.WriteLine("Do Some Work Independently until the Async Function finish its work .......");

           
            foreach (var id in topIDs)
            {
                await Console.Out.WriteLineAsync(id.ToString());
            }
            await Console.Out.WriteLineAsync("\n");
            await Console.Out.WriteLineAsync(outputParameter!.Value.ToString());

        }
    }
}