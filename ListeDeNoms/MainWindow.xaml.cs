using System.Windows;

namespace ListeDeNoms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void OnEdtNomKeyDown(object sender, EventArgs e)
        {
            // Comment on ajoute un évènement en xaml?
        }

        void OnBtnAddNameClick(object sender, EventArgs e)
        {
            AddName(edtName.Text);
        }

        // Avoir un message box qui montre le nom
        void AddName(string name)
        {
            MessageBox.Show(name);

        }
    }
}