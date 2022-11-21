using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chuck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApiProvider Api { get; }
        List<Result> Results { get; set; }
        public MainWindow()
        {
            InitializeComponent();  
            DataContext = this;
            Results = new List<Result>();
            Api = new ApiProvider();
        }
        async void LoadJokesDGridAsync() 
        {
            Rootobject? rootobject = await Api.GetJokesAsync(SearchJokeTBox.Text);
            //foreach (var item in rootobject.result)
            //    Results.Add(item);
            JokesDGrid.ItemsSource = rootobject.result;
        }
        private void SearchJokeBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadJokesDGridAsync();
        }
    }
}
