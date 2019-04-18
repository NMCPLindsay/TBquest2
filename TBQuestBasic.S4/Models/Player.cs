using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.DataLayer;
using System.Collections.ObjectModel;

namespace TBQuestBasic.Models
{
    public partial class Player : Character
    {
        public enum Alignments
        {
            Good,
            Neutral,
            Evil
        }

    
        private Alignments _align;
        private int _level;
        private double _hitPoints;
        private double _exp;
        private Uri _imgFileName;
        private ObservableCollection<GameObjectQuantity> _inventory;
        private ObservableCollection<GameObjectQuantity> _weapons;
        private ObservableCollection<GameObjectQuantity> _armor;
        private ObservableCollection<GameObjectQuantity> _elixirs;
        private ObservableCollection<GameObjectQuantity> _ships;

        public ObservableCollection<GameObjectQuantity> Ships
        {
            get { return _ships; }
            set { _ships = value; }
        }


        public ObservableCollection<GameObjectQuantity> Elixirs
        {
            get { return _elixirs; }
            set { _elixirs = value; }
        }



        public ObservableCollection<GameObjectQuantity> Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }


        public ObservableCollection<GameObjectQuantity> Weapons
        {
            get { return _weapons; }
            set { _weapons = value; }
        }


        public ObservableCollection<GameObjectQuantity> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }





        public Uri ImgFileName
        {
            get { return _imgFileName; }
            set { _imgFileName = value; }
        }

        

        public double EXP
        {
            get { return _exp; }
            set { _exp = value; }
        }


        public double HitPoints
        {
            get { return _hitPoints; }
            set { _hitPoints = value; }
        }


        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }


        public Alignments Align
        {
            get { return _align; }
            set { _align = value; }
        }


     

        




        public Player()
        {
            _armor = new ObservableCollection<GameObjectQuantity>();
            _elixirs = new ObservableCollection<GameObjectQuantity>();
            _inventory = new ObservableCollection<GameObjectQuantity>();
            _ships = new ObservableCollection<GameObjectQuantity>();
            _weapons = new ObservableCollection<GameObjectQuantity>();
        

        }
     
        public override string GetPlayerBio()
        {
            string Bio = null;
            
            if (Race == Races.Mandalorian)
            {
                 Bio = "The mandalorians were a proud race of bounty hunters. The most famous of which are the late Jango Fett and his son, Boba Fett.";
            }
            else if (Race == Races.Human)
            {
                Bio = "The humans are a poplulace sentiant race primarily from Corellia. They are found all over the galaxy and are a balanced race. Notable humans are Han Solo and Luke Skywalker.";
            }
            else if (Race == Races.Wookie)
            {
                Bio = "Hailing from their homeworld of Kashyyk, Wookies are tall, furry creatures. Known for feirce strength, they were often used as slaves by the Empire. Noteable wookies are Chewbacca and Gungi";
            }
            else
            {
                Bio = "No Biography on this race is available.";
            }

            return Bio;
        }
        

        public override string GetPlayerGreeting(Player player)
        {
            string Greeting = null;

            if (player.Align == Alignments.Good)
            {
                Greeting = $"Hello, I am {player.Name}, Pleasure to meet you.";
            }
            else if (player.Align == Alignments.Neutral)
            {
                Greeting = $"I am {player.Name}";
            }
            else if (player.Align == Alignments.Evil)
            {
                Greeting = $"I am {player.Name}, get out of my way or die.";
            }

            return Greeting;
        }

        public void UpdateInventoryCategories()
        {
            Elixirs.Clear();
            Ships.Clear();
            Weapons.Clear();
            Armor.Clear();

            foreach (var gameItemQuantity in _inventory)
            {
                if (gameItemQuantity.GameObject is Weapons) Weapons.Add(gameItemQuantity);
                if (gameItemQuantity.GameObject is Armor) Armor.Add(gameItemQuantity);
                if (gameItemQuantity.GameObject is Ship) Ships.Add(gameItemQuantity);
                if (gameItemQuantity.GameObject is Elixirs) Elixirs.Add(gameItemQuantity);
            }
        }

        public void AddGameItemQuantityToInventory(GameObjectQuantity selectedGameObjectQuantity)
        {
            GameObjectQuantity gameObjectQuantity = _inventory.FirstOrDefault(i => i.GameObject.Id == selectedGameObjectQuantity.GameObject.Id);

            if (gameObjectQuantity == null)
            {
                GameObjectQuantity newGameObjectQuantity = new GameObjectQuantity();
                newGameObjectQuantity.GameObject = selectedGameObjectQuantity.GameObject;
                newGameObjectQuantity.Quantity = 1;

                _inventory.Add(newGameObjectQuantity);
            }
            else
            {
                gameObjectQuantity.Quantity++;
            }
            UpdateInventoryCategories();
        }

        public void RemoveGameItemQuantityFromInventory(GameObjectQuantity selectedGameObjectQuantity)
        {
            GameObjectQuantity gameObjectQuantity = _inventory.FirstOrDefault(i => i.GameObject.Id == selectedGameObjectQuantity.GameObject.Id);

            if (gameObjectQuantity != null)
            {

                if (selectedGameObjectQuantity.Quantity == 1)
                {
                    _inventory.Remove(gameObjectQuantity);
                }

                else
                {
                    gameObjectQuantity.Quantity--;
                }
            }
            UpdateInventoryCategories();
            
        }

    }
}
