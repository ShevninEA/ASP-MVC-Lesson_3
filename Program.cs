namespace ASP_MVC_Lesson_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Freelancer freelancer = new Freelancer();
            freelancer.Print();

            FixWorker fixWorker = new FixWorker();
            fixWorker.Print();

            Console.ReadKey(true);

        }
    }
}