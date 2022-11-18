namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            bool correct;
            do
            {
             Console.Clear();
            correct = true;
            Console.WriteLine("What Data Base you want to use ?");
            Console.WriteLine(" 1.Mongo");
            Console.WriteLine(" 2.SQL");
            Console.WriteLine(" 3.List");

            userinput = Console.ReadLine();


            if (userinput != "sql" && userinput != "mango" && userinput != "list") 
            {
                
                correct = false;
                Console.WriteLine("************Sorry Wrong Input please try again!**********");
                Thread.Sleep(1000);
            }

            } while (!correct); ;

            Console.Clear();



            IDataAccess data = DataAccessFactory.GetDataAccessType(userinput);
            var items = data.LoadData();
            data.SaveData();

            foreach (var item in items)
            
            {
                Console.WriteLine($"Name : {item.Name} Price :{item.Prices}");
            
            
            }

           
        }
    }
}
