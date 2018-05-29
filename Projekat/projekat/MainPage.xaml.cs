using Windows.UI.Xaml.Controls;
using projekat.ViewModel;
using Windows.UI.Popups;
using projekat.RegistracijaDetalji;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace projekat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
         public PrijavaViewModel Osoba { get; set; }

    

        private void loginbtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(FormaRegistracije));
        }

       
    }
}
