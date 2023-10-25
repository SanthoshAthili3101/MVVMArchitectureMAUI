using MVVMArchitecture.Views;

namespace MVVMArchitecture
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("TestingLabelView", typeof(TestingLabelView));
            Routing.RegisterRoute("TestingButtonView", typeof(TestingButtonView));
        }
    }
}