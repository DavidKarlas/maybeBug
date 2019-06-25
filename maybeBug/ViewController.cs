using System;

using AppKit;
using Foundation;

namespace maybeBug
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            PrintButton1();
            GC.Collect();
            PrintButton1();
        }

        private void PrintButton1()
        {
            Console.WriteLine(button1 != null);
        }
    }
}
