using System.Windows;

namespace ChiffreSecret
{
    public partial class MainWindow : Window
    {
        int NumberOfAttempts;
        int NumberToFind;
        Random Random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            PrepareButtons();
            // Va voir le menu!
        }

        private void PrepareButtons()
        {
            // Ici tu vas préparer tes boutons.
        }
    }
}