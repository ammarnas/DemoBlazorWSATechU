using DemoBlazorWSATechU.Code;

namespace DemoBlazorWSATechU.Pages
{
    public partial class Counter
    {
        public AddClass AddClass { get; set; }
        public Char Operator { get; set; }

        public Counter()
        {
            AddClass = new AddClass();
            Operator = '+';
        }
        public void Process(char operation)
        {
            switch (operation)
            {
                case '+':
                    AddClass.Result = AddClass.FirstNumber + AddClass.SecondNumber;
                    break;
                case '-':
                    AddClass.Result = AddClass.FirstNumber - AddClass.SecondNumber;
                    break;
                case '*':
                    AddClass.Result = AddClass.FirstNumber * AddClass.SecondNumber;
                    break;
                case '/':
                    AddClass.Result = AddClass.FirstNumber / AddClass.SecondNumber;
                    break;
                default:
                    break;
            }
        }
    }
}
