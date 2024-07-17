class IS_Wrong
{
    public interface IHouseWorker
    {
        public string Name { get; set; }
        public void GetJobQuote();
        public void PaintWall();
        public void MowGrass();
    }

    public class ProffesionalPainter : IHouseWorker
    {
        public string Name { get; set; }

        public ProffesionalPainter(string name)
        {
            Name = name;
        }
        public void GetJobQuote()
        {
            Console.WriteLine("Cost of the job is...");
        }
        public void MowGrass()
        {
            throw new NotImplementedException();
        }

        public void PaintWall()
        {
            Console.WriteLine("I'm painting the wall...");
        }
    }

    public class ProffesionalMower : IHouseWorker
    {
        public string Name { get; set; }

        public ProffesionalMower(string name)
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

        public void PaintWall()
        {
            throw new NotImplementedException();
        }
    }

    static void MyMain(string[] args)
    {
        new ProffesionalPainter("Mark").PaintWall();
        new ProffesionalMower("Andrew").MowGrass();
    }
}