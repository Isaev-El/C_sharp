namespace Practice12
{
    public class Program
    {
        delegate void GetMessage();
        static void GoodMorning()
        {
            Console.WriteLine("GoodMorning");
        }

        static void GoodEvening() {
            Console.WriteLine("GoodEvening");
        }
        static void Main(string[] args)
        {
            GetMessage del;
            if (DateTime.Now.Hour<12)
            {
                del=GoodMorning;
            }
            else
            {
                del = GoodEvening;
            }

            del.Invoke();
        }
    }
}