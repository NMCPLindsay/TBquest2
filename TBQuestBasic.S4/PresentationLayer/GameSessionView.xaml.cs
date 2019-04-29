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
using TBQuestBasic.DataLayer;

namespace TBQuestBasic.PresentationLayer
{
    /// <summary>
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class GameSessionView : Window
    {
        GameSessionViewModel _gameSessionViewModel;

        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {

            _gameSessionViewModel = gameSessionViewModel;

            
            InitializeComponent();
        }

  

        private void AvailableLocationsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _gameSessionViewModel.OnMove();
            
        }

        private void ExitBuildingButton_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.ExitBuilding();
            
        }

        private void BuildingPlus1Button_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.EnterBuilding1();
        }

        private void PLocationMinus1_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveToPreviousPlanetLocation();
            
        }

        private void BuildingPlus2Button_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.EnterBuilding2();
        }

        private void BuildingPlus3Button_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.EnterBuilding3();
        }

        private void BuildingPlus4Button_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.EnterBuilding4();
        }

        private void PLocationPlus1_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveToNextPlanetLocation();
        }

        private void PlanetMinus1Button_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveToPreviousPlanet();
        }

        private void PlanetPlus1Button_Click(object sender, RoutedEventArgs e)
        {
            _gameSessionViewModel.MoveToNextPlanet();
        }

        private void PickUpItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (LocationItemsDataGrid.SelectedItem !=null)
            {
                _gameSessionViewModel.AddObjectToInventory();

            }
        }

        private void DropItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerDataTabControl.SelectedItem != null)
            {
                _gameSessionViewModel.RemoveItemFromInventory();
            }
            
        }

        private void UseItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerDataTabControl.SelectedItem != null)
            {
                _gameSessionViewModel.OnUseGameItem();
            }
            
        }

        private void EquipItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerDataTabControl.SelectedItem != null)
            {
                _gameSessionViewModel.EquipObject();
            }
            
        }
    }
}
