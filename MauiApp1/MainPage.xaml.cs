namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        List<string> fruits = new List<string>() { "apple", "banana", "peach" };
        public MainPage()
        {
            InitializeComponent();
            FruityListView.ItemsSource = fruits;
        }
        public void FruityListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (FruityListView.SelectedItem == null)
                return;
            DisplayAlert("Selected", e.SelectedItem.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;

        }
        

     

        
    }
}