namespace Metiator.EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User mark=new User("mark");

            User Emad = new User("Emad");



            mark.SendMessage("Hi");

            Emad.SendMessage("Hi,mark");

        }
    }
}
