using System;

namespace CollorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            Color red = new Color (255, 0, 0, 255);
            Color purple = new Color (255, 0, 255, 255);

            Balls bigRed = new Balls (red , 5);
            Balls littlePurple = new Balls (purple, 3);

            Console.WriteLine("Purple = R={0}, G={1}, B={2}, A={3}",
            purple.GetRed(), purple.GetGreen(),
            purple.GetBlue(), purple.GetAlpha()    
            );

            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine(bigRed.GetTimesThrown());

            littlePurple.Pop();
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());   
        }

    }
}
