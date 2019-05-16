using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

// Die Elementvorlage "Benutzersteuerelement" wird unter https://go.microsoft.com/fwlink/?LinkId=234236 dokumentiert.

namespace CustomControls
{
    public sealed partial class Test : UserControl
    {
        public Test()
        {
            InitializeComponent();
            ListView.ItemsSource = new List<MyListItem>()
            {
                new MyListItem("Title 1", "SubTitle1"),
                new MyListItem("Title 2", "SubTitle2")
            };
        }
    }

    public class MyListItem
    {
        public string MyProperty { get; set; }
        public string MyOtherProperty { get; set; }

        public MyListItem(string myProperty, string myOtherProperty)
        {
            MyProperty = myProperty;
            MyOtherProperty = myOtherProperty;
        }
    }
}
