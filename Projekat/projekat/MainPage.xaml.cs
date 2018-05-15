using Windows.UI.Xaml.Controls;
using projekat.ViewModel;
using Windows.UI.Popups;


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

        public  void OdustaniClick()
        {
            MessageDialog dialog = new MessageDialog("Yes or no?");
            dialog.Commands.Add(new UICommand("Yes", null));
            dialog.Commands.Add(new UICommand("No", null));
            dialog.DefaultCommandIndex = 0;
            dialog.CancelCommandIndex = 1;

           
            
        }

       
    }
}
