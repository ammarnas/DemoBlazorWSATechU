using DemoBlazorWSATechU.Code;

namespace DemoBlazorWSATechU.Pages
{
    public partial class Counter
    {
        public AddClass AddClass { get; set; }

        public Counter()
        {
            AddClass = new AddClass();
        }
        public void Add()
        {
            AddClass.Result = AddClass.FirstNumber + AddClass.SecondNumber;
        }
    }
}
