using System.Windows;
using System.Windows.Controls;

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
            InitGame();
        }

        private void InitGame()
        {
            tbHint.Text= "?";
            NumberOfAttempts = 0;
            NumberToFind = Random.Next(1, 20);
        }

        private void PrepareButtons()
        {
            for (int i = 1; i <= 20; i++)
            {
                GridButtons.ColumnDefinitions.Add(new ColumnDefinition());
                var button = new Button()
                {
                    Content = i.ToString(),
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                };
                button.Click += OnBtnNumberClick;
                Grid.SetColumn(button, i-1);
                GridButtons.Children.Add(button);
            }
        }

        void OnBtnNumberClick(object sender, RoutedEventArgs e)
        {
            ((Button)sender).IsEnabled = false;
            if (int.TryParse(((Button)sender).Content.ToString(), out int selectedNumber))
            {
                NumberOfAttempts++;
                if (selectedNumber > NumberToFind)
                {
                    tbHint.Text = "↓";
                }
                else if (selectedNumber < NumberToFind)
                {
                    tbHint.Text = "↑";
                }
                else
                {
                    MessageBox.Show($"Le nombre était {NumberToFind} \nVous avez trouvé en {NumberOfAttempts} essai{(NumberOfAttempts > 1 ? "s" : "")}");
                    StartANewGame();
                }
            }
        }

        void OnMenuNewGameClick(object sender, RoutedEventArgs e)
        {
            StartANewGame();
        }

        private void StartANewGame()
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous démarrer une nouvelle partie?", "Nouvelle partie?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                InitGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}