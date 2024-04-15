using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace UraniumUITest;

public partial class HomePage : ContentView
{
    HomeViewModel vm;

    public HomePage()
    {
        InitializeComponent();

        autoCompNamed.ItemsSource = new List<string>() { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10" };

        // this works
        /*vm = new HomeViewModel();
        BindingContext = vm;
        vm.LoadData();*/

        // this doesn't work
        HandlerChanged += (s, e) =>
        {
            vm = Handler.MauiContext.Services.GetService<HomeViewModel>();
            BindingContext = vm;
            vm.LoadData();
        };
    }
}

public partial class HomeViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string> items = [];

    [ObservableProperty]
    ObservableCollection<string> presetItems = ["Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Test 6", "Test 7", "Test 8", "Test 9", "Test 10"];

    public HomeViewModel()
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