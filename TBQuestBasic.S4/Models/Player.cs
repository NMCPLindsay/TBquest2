﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.DataLayer;
using System.Collections.ObjectModel;
using TBQuestBasic.Models.GameObjects;
using System.Windows.Data;


namespace TBQuestBasic.Models
{
    public partial class Player : Character
    {

        #region ENUMS
        public enum Alignments
        {
            Good,
            Neutral,
            Evil
        }

        public enum Races
        {
            Mandalorian,
            Wookie,
            Human
        }
        #endregion

        #region FIELDS
        private Alignments _align;
        private int _level;
        private double _hitPoints;
        private double _exp;
        private Uri _imgFileName;
        private ObservableCollection<GameObjectQuantity> _inventory;
        private ObservableCollection<GameObjectQuantity> _weapons;
        private ObservableCollection<GameObjectQuantity> _armor;
        private ObservableCollection<GameObjectQuantity> _elixirs;
        private ObservableCollection<GameObjectQuantity> _shipKeys;
        private Races _race;
        private string _bio;
        private int _str;
        private int _dex;
        private int _int;
        private int _cha;
        private int _wis;
        private int _con;
        private int _armorClass;
        private int _strMod;
        private int _dexMod;
        private int _intMod;
        private int _chaMod;
        private int _wisMod;
        private int _conMod;
        private Armor _currentHelm;
        private Armor _currentChest;
        private Armor _currentLegs;
        private Armor _currentHands;
        private Armor _currentFeet;
        private Weapons _currentWeapon;

        #endregion

        #region PROPERTIES

        public Weapons CurrentWeapon
        {
            get { return _currentWeapon; }
            set { _currentWeapon = value; OnPropertyChanged(nameof(CurrentWeapon)); }
        }

        public Armor CurrentFeet
        {
            get { return _currentFeet; }
            set { _currentFeet = value; OnPropertyChanged(nameof(CurrentFeet)); }
        }

        public Armor CurrentHands
        {
            get { return _currentHands; }
            set { _currentHands = value; OnPropertyChanged(nameof(CurrentHands)); }
        }

        public Armor CurrentLegs
        {
            get { return _currentLegs; }
            set { _currentLegs = value; OnPropertyChanged(nameof(CurrentLegs)); }
        }


        public Armor CurrentChest
        {
            get { return _currentChest; }
            set { _currentChest = value; OnPropertyChanged(nameof(CurrentChest)); }
        }


        public Armor CurrentHelm
        {
            get { return _currentHelm; }
            set
            {
                _currentHelm = value;
                OnPropertyChanged(nameof(CurrentHelm));
            }
        }


        public int ConstitutionModifier
        {
            get { return _conMod; }
            set
            {
                _conMod = value;
                OnPropertyChanged(nameof(ConstitutionModifier));
            }
        }


        public int WisdomModifier
        {
            get { return _wisMod; }
            set { _wisMod = value; OnPropertyChanged(nameof(WisdomModifier)); }
        }


        public int CharismaModifier
        {
            get { return _chaMod; }
            set { _chaMod = value; OnPropertyChanged(nameof(CharismaModifier)); }
        }


        public int IntelligenceModifier
        {
            get { return _intMod; }
            set { _intMod = value; OnPropertyChanged(nameof(IntelligenceModifier)); }
        }


        public int DexterityModifier
        {
            get { return _dexMod; }
            set { _dexMod = value; OnPropertyChanged(nameof(DexterityModifier)); }
        }


        public int StrengthModifier
        {
            get { return _strMod; }
            set { _strMod = value; OnPropertyChanged(nameof(StrengthModifier)); }
        }

        public int ArmorClass
        {
            get { return _armorClass; }
            set { _armorClass = value; OnPropertyChanged(nameof(ArmorClass)); }
        }

        public int Constitution
        {
            get { return _con; }
            set { _con = value; OnPropertyChanged(nameof(Constitution)); }
        }


        public int Wisdom
        {
            get { return _wis; }
            set { _wis = value; OnPropertyChanged(nameof(Wisdom)); }
        }


        public int Charisma
        {
            get { return _cha; }
            set { _cha = value; OnPropertyChanged(nameof(Charisma)); }
        }


        public int Intelligence
        {
            get { return _int; }
            set { _int = value; OnPropertyChanged(nameof(Intelligence)); }
        }


        public int Dexterity
        {
            get { return _dex; }
            set { _dex = value; OnPropertyChanged(nameof(Dexterity)); }
        }


        public int Strength
        {
            get { return _str; }
            set { _str = value; OnPropertyChanged(nameof(Strength)); }
        }

        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        public Races Race
        {
            get { return _race; }
            set { _race = value; }
        }


        public ObservableCollection<GameObjectQuantity> ShipKeys
        {
            get { return _shipKeys; }
            set { _shipKeys = value; }
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
            set
            {

                _exp = value;
                OnPropertyChanged(nameof(EXP));
            }
        }


        public double HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged(nameof(HitPoints));
            }
        }


        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }


        public Alignments Align
        {
            get { return _align; }
            set { _align = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Player()
        {
            _armor = new ObservableCollection<GameObjectQuantity>();
            _elixirs = new ObservableCollection<GameObjectQuantity>();
            _inventory = new ObservableCollection<GameObjectQuantity>();
            _shipKeys = new ObservableCollection<GameObjectQuantity>();
            _weapons = new ObservableCollection<GameObjectQuantity>();
             
        }
        #endregion

        #region METHODS        

        public void UpdateInventoryCategories()
        {
            Elixirs.Clear();
            ShipKeys.Clear();
            Weapons.Clear();
            Armor.Clear();

            foreach (var gameItemQuantity in _inventory)
            {
                if (gameItemQuantity.GameObject is Weapons) Weapons.Add(gameItemQuantity);
                if (gameItemQuantity.GameObject is Armor) Armor.Add(gameItemQuantity);
                if (gameItemQuantity.GameObject is ShipKeys) ShipKeys.Add(gameItemQuantity);
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
        #endregion

    }
}
