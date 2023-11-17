using Practice.Work10.HouseParts;
using Practice.Work10.TeamParts;

namespace Practice.Work10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new TeamLeader());

            House house = new House();
            team.Building(house);

            house.Draw();
            Console.WriteLine("Строительство дома завершено!");
        }
    }
}