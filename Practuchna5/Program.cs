namespace Pracruchna5
{
    public class Counter
    {
        private int max;
        private int min;
        private int count;

        public Counter(int count, int min, int max)
        {
            this.count = count;
            this.min = min;
            this.max = max;
        }

        public Counter()
        {
            this(0, 0, 10);
        }

        public void setMax(int max)
        {
            this.max = max;
        }

        public void setMin(int min)
        {
            this.min = min;
        }

        public void setCount(int count)
        {
            this.count = count;
        }

        public void up()
        {
            count++;
        }

        public void down()
        {
            count--;
        }
    }
}