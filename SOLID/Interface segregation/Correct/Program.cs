class IS_Correct
{
    public interface IHouseWorker
    {
        public string Name { get; set; }
        public void GetJobQuote();
    }
    public interface IProffesionalPainter
    {
        public void PaintWall();
    }

    public interface IProffesionalMower
    {
        public void MowGrass();
    }

    public class Painter : IHouseWorker, IProffesionalPainter
    {
        public string Name { get; set; }
        public Painter(string name)
        {
            Name = name;
        }
        public void GetJobQuote()
        {
            Console.WriteLine("Cost of the job is...");
        }
        public void PaintWall()
        {
            Console.WriteLine("I'm painting the wall...");
        }
    }

    public class Mower : IHouseWorker, IProffesionalMower
    {
        public string Name { get; set; }
        public Mower(string name)
        {
            Name = name;
        }
        public void GetJobQuote()
        {
            Console.WriteLine("Cost of the job is...");
        }
        public void MowGrass()
        {
            Console.WriteLine("I'm mowing the grass...");
        }
    }

    static void MyMain(string[] args)
    {
        new Painter("Mark").PaintWall();
        new Mower("Andrew").MowGrass();        
    }
}