using System;
using System.Collections.Generic;
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
        public MainWindow()
        {
            InitializeComponent();  
            ApiProvider api = new ApiProvider();
            Task<Rootobject> rootobject = api.GetJokes();
            jokesDGrid.ItemsSource = rootobject;
            //foreach (var res in rootobject.Result.result)
               // Console.WriteLine(res.value + "\n" + res.created_at + "\n\n");
        }
    }
}
