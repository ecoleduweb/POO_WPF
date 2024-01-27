using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ListeDeNoms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int MaxNumberOfNames = 10;
        int CurrentTopMargin = 0;
        int CurrentNumberOfNames = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        void OnEdtNomKeyDown(object sender, EventArgs e)
        {
            // Le faire avec l'étudiant
            if ((e as KeyEventArgs).Key == Key.Enter)
            {
                string name = (sender as TextBox).Text;
                AddName(name);
            }
        }

        void OnBtnAddNameClick(object sender, EventArgs e)
        {
            AddName(edtName.Text);
        }

        // Avoir un message box qui montre le nom
        void AddName(string name)
        {
            if (CurrentNumberOfNames >= MaxNumberOfNames)
            {
                MessageBox.Show("Trop de noms");
            }
            else
            {
                var tbNom = new TextBlock();
                tbNom.Margin = new Thickness(100, CurrentTopMargin, 0, 0);
                tbNom.TextWrapping = TextWrapping.Wrap;
                tbNom.FontSize = 12;
                tbNom.VerticalAlignment = VerticalAlignment.Top;
                tbNom.HorizontalAlignment = HorizontalAlignment.Left;
                tbNom.Text = name;
                gridNoms.Children.Add(tbNom);

                CurrentTopMargin+=12;
                CurrentNumberOfNames++;
            }
        }
    }

}