namespace Services.Workflow
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public string PrintWorkflow()
        {
            string message = "Hello from workflow service";
            Console.WriteLine(message);
            return message;
        }
    }
}