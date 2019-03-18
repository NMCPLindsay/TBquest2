using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TBQuestBasic.Models;


namespace TBQuestBasic.PresentationLayer
{
    /// <summary>
    /// Interaction logic for PlayerSetupView.xaml
    /// </summary>
    public partial class PlayerSetupView : Window
    {
        private Player _player = new Player();

        public PlayerSetupView(Player player)
        {


            _player = player;
            InitializeComponent();

            SetupWindow();
        }

        private void SetupWindow()
        {
            List<string> races = Enum.GetNames(typeof(Character.Races)).ToList();
            List<string> alignments = Enum.GetNames(typeof(Player.Alignments)).ToList();
            PlayerRaceComboBox.ItemsSource = races;
            AlignmentComboBox.ItemsSource = alignments;

            ErrorMsgLabel.Visibility = Visibility.Hidden;
        }

        private bool IsValidInput(out string errorMessage)
        {
            errorMessage = "";
            
            if (PlayerNameTextBox.Text == "")
            {
                errorMessage += "Player name is required.\n";
            }
            else
            {
                _player.Name = PlayerNameTextBox.Text;
                

            }

            return errorMessage == "" ? true : false;
        }
        private void SetPlayerImage()
        {

            

            if (PlayerRaceComboBox.SelectedItem.Equals("Mandalorian"))
            {
                PlayerImage.Source = new BitmapImage(new Uri(@"C:\Users\phili\Desktop\Application Dev\TBQuestBasic\TBQuestBassic\Assets\mandolorain.jpg"));
            }
            else if (PlayerRaceComboBox.SelectedItem.Equals("Human"))
            {
                PlayerImage.Source = new BitmapImage(new Uri(@"C:\Users\phili\Desktop\Application Dev\TBQuestBasic\TBQuestBassic\Assets\human.jpg"));
            }
            else if (PlayerRaceComboBox.SelectedItem.Equals("Wookie"))
            {
                PlayerImage.Source = new BitmapImage(new Uri(@"C:\Users\phili\Desktop\Application Dev\TBQuestBasic\TBQuestBassic\Assets\wookie.jpg"));
            }

        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage;

            if (IsValidInput(out errorMessage))
            {
                Enum.TryParse(PlayerRaceComboBox.SelectionBoxItem.ToString(), out Character.Races race);
                Enum.TryParse(AlignmentComboBox.SelectionBoxItem.ToString(), out Player.Alignments alignment);

              
                _player.Race = race;
                _player.Align = alignment;
                _player.EXP = 0;
                _player.HitPoints = 100;
                _player.Level = 1;
                _player.Name = PlayerNameTextBox.Text;
                Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorMsgLabel.Visibility = Visibility.Visible;
                ErrorMsgLabel.Content = errorMessage;
            }
        
        }

        private void CharacterViewButton_Click(object sender, RoutedEventArgs e)
        {
            SetPlayerImage();
        }
    }
}
