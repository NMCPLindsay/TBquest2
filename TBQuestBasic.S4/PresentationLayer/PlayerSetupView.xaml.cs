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
            List<string> races = Enum.GetNames(typeof(Player.Races)).ToList();
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
                PlayerImage.Source = new BitmapImage(new Uri(@"..\..\Assets\mandolorian.jpg", UriKind.Relative));
                BioTextBox.Text = "The mandalorians were a proud race of bounty hunters. The most famous of which are the late Jango Fett and his son, Boba Fett.";
                tempUri = new Uri(@"..\..\Assets\mandolorian.jpg", UriKind.Relative);
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
                
                Enum.TryParse(PlayerRaceComboBox.SelectionBoxItem.ToString(), out Player.Races race);
                Enum.TryParse(AlignmentComboBox.SelectionBoxItem.ToString(), out Player.Alignments alignment);
                
              
                _player.Race = race;
                _player.Align = alignment;
                _player.EXP = 0;                
                _player.Level = 1;
                _player.Name = PlayerNameTextBox.Text;
                _player.ImgFileName = SetPlayerImage();
                _player.Bio = BioTextBox.Text;
                _player.Charisma = AttributeRoll();
                _player.Constitution = AttributeRoll();
                _player.Dexterity = AttributeRoll();
                _player.Intelligence = AttributeRoll();
                _player.Strength = AttributeRoll();
                _player.Wisdom = AttributeRoll();
                _player.CharismaModifier = AttributeModifier(_player.Charisma);
                _player.ConstitutionModifier = AttributeModifier(_player.Constitution);
                _player.DexterityModifier = AttributeModifier(_player.Dexterity);
                _player.IntelligenceModifier = AttributeModifier(_player.Intelligence);
                _player.StrengthModifier = AttributeModifier(_player.Strength);
                _player.WisdomModifier = AttributeModifier(_player.Wisdom);
                _player.HitPoints = HitPointCalculator(_player.ConstitutionModifier);
                _player.ArmorClass = 10;
                Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorMsgLabel.Visibility = Visibility.Visible;
                ErrorMsgLabel.Content = errorMessage;
            }
        
        }

        private double HitPointCalculator(int constitutionModifier)
        {
            int modifier = constitutionModifier;
            int addRoll=0;
            double rollsMod;
            DiceBag diceBag = new DiceBag();
            List<int> rolls = diceBag.RollQuantity(DiceBag.Dice.D8, 4);
            foreach (int roll in rolls)
            {
                addRoll = addRoll + roll;
            }
            rollsMod = addRoll + modifier;
            return rollsMod;
        }

        private int AttributeModifier(int attributeScore)
        {
            int modifier;
            if (attributeScore <= 1 )
            {
                modifier = -5;
            }
            else if (attributeScore== 2 || attributeScore == 3 )
            {
                modifier = -4;
            }
            else if (attributeScore == 4 || attributeScore == 5)
            {
                modifier = -3;
            }
            else if (attributeScore == 6 || attributeScore == 7)
            {
                modifier = -2;
            }
            else if (attributeScore == 8 || attributeScore == 9)
            {
                modifier = -1;
            }
            else if (attributeScore == 10 || attributeScore == 11)
            {
                modifier = 0;
            }
            else if (attributeScore == 12 || attributeScore == 13)
            {
                modifier = 1;
            }
            else if (attributeScore == 14 || attributeScore == 15)
            {
                modifier = 2;
            }
            else if (attributeScore == 16 || attributeScore ==17)
            {
                modifier = 3;
            }
            else if (attributeScore == 18 || attributeScore == 19)
            {
                modifier = 4;
            }           
            else if (attributeScore == 20 || attributeScore == 21)
            {
                modifier = 5;
            }
            else if (attributeScore == 22 || attributeScore == 23)
            {
                modifier = 6;
            }
            else if (attributeScore == 24 || attributeScore == 25)
            {
                modifier = 7;
            }
            else if (attributeScore == 26 || attributeScore == 27)
            {
                modifier = 8;
            }
            else if (attributeScore == 28 || attributeScore == 29)
            {
                modifier = 9;
            }
            else if (attributeScore >= 30)
            {
                modifier = 10;
            }
            else
            {
                modifier = 0;
            }
            return modifier;
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

        private int AttributeRoll()
        {
            int attribute = 0;
            DiceBag diceBag = new DiceBag();
            List<int> rolls = new List<int>();

            rolls = diceBag.RollQuantity(DiceBag.Dice.D6, 4);
            foreach (int roll in rolls)
            {
                attribute = attribute + roll;
            }

            return attribute;

        }
    }
}
