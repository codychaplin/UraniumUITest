using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace UraniumUITest;

public partial class TestPage : ContentPage
{
	public TestPage(TestViewModel vm)
	{
		InitializeComponent();

        // this works
        BindingContext = vm;
        vm.LoadData();
	}
}

public partial class TestViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string> items = [];

    public TestViewModel()
    {

    }

    public void LoadData()
    {
        var list = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5",
            "Test 6",
            "Test 7",
            "Test 8",
            "Test 9",
            "Test 10",
        };

        foreach (var item in list)
        {
            Items.Add(item);
        }
    }
}