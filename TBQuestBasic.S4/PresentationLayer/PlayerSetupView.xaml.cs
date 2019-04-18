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


        private Uri SetPlayerImage()
        {
            Uri tempUri = null; 

            if (PlayerRaceComboBox.SelectedItem.Equals("Mandalorian"))
            {
                PlayerImage.Source = new BitmapImage(new Uri(@"..\..\Assets\mandalorian.jpg", UriKind.Relative));
                BioTextBox.Text = "The mandalorians were a proud race of bounty hunters. The most famous of which are the late Jango Fett and his son, Boba Fett.";
                tempUri = new Uri(@"..\..\Assets\mandalorian.jpg", UriKind.Relative);
            }
            else if (PlayerRaceComboBox.SelectedItem.Equals("Human"))
            {
                PlayerImage.Source = new BitmapImage(new Uri(@"../../Assets/human.jpg", UriKind.Relative));
                BioTextBox.Text = "The humans are a poplulace sentiant race primarily from Corellia. They are found all over the galaxy and are a balanced race. Notable humans are Han Solo and Luke Skywalker.";
                tempUri = new Uri(@"..\..\Assets\human.jpg", UriKind.Relative);
            }
            else if (PlayerRaceComboBox.SelectedItem.Equals("Wookie"))
            {
                PlayerImage.Source = new BitmapImage(new Uri(@"../../Assets/wookie.jpg", UriKind.Relative));
                BioTextBox.Text = "Hailing from their homeworld of Kashyyk, Wookies are tall, furry creatures. Known for feirce strength, they were often used as slaves by the Empire. Noteable wookies are Chewbacca and Gungi";
                tempUri = new Uri(@"..\..\Assets\wookie.jpg", UriKind.Relative);
            }

            return tempUri;
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
                _player.ImgFileName = SetPlayerImage();
                _player.Bio = BioTextBox.Text;
                Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorMsgLabel.Visibility = Visibility.Visible;
                ErrorMsgLabel.Content = errorMessage;
            }
        
        }

      

        private void PlayerRaceComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string errorMessage;

            if (IsValidInput(out errorMessage))
            {
                SetPlayerImage();
                ErrorMsgLabel.Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorMsgLabel.Visibility = Visibility.Visible;
                ErrorMsgLabel.Content = errorMessage;
            }
        }
    }
}
