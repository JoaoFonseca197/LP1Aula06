namespace CollorBalls
{
    public class Balls
    {
        private Color color;
        private float radius;
        private int timesThrown;

        public Balls (Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            timesThrown = 0;

        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }
    }
}