namespace DemoBlazorWSATechU.Pages
{
    public partial class Counter
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Result { get; set; }

        public Counter()
        {
            FirstNumber = SecondNumber = Result = 0;
        }
        public void Add()
        {
            Result = FirstNumber + SecondNumber;
        }
    }
}
