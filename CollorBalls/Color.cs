namespace CollorBalls
{
    public class Color
    {
        private byte red, green, blue, alpha;


        public Color (byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha =alpha;
        }


        public byte GetRed() => red;
        public byte GetGreen() => green;
        public byte GetBlue() => blue;
        public byte GetAlpha() => alpha;

        public void SetRed(byte red)
        {
            this.red = red;
        }
        public void SetGreen(byte green)
        {
            this.green = green;
        }
        public void SetBlue(byte blue)
        {
            this.blue = blue;
        }
        public void SetAlpha(byte alpha)
        {
            this.alpha = alpha;
        }

        public byte Getgrey(byte red, byte green, byte blue)
        {
            return (byte) ((red+green+blue)/3);
        }
    }
}