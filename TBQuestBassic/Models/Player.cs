﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestBasic.DataLayer;

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

        private string _bio;
        private Alignments _align;
        private int _level;
        private double _hitPoints;
        private double _exp;
        private string _imgFileName;

        public string ImgFileName
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


        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        




        public Player()
        {
            


        }
        public Player(Player player)
        {
            player.Bio = GetPlayerBio(player);
            player.ImgFileName = GetImageFileName(player);

        }
        public override string GetPlayerBio(Player player)
        {
            string Bio = null;
            
            if (player.Race == Races.Mandalorian)
            {
                 Bio = "The mandalorians were a proud race of bounty hunters. The most famous of which are the late Jango Fett and his son, Boba Fett.";
            }
            else if (player.Race == Races.Human)
            {
                Bio = "The humans are a poplulace sentiant race primarily from Corellia. They are found all over the galaxy and are a balanced race. Notable humans are Han Solo and Luke Skywalker.";
            }
            else if (player.Race == Races.Wookie)
            {
                Bio = "Hailing from their homeworld of Kashyyk, Wookies are tall, furry creatures. Known for feirce strength, they were often used as slaves by the Empire. Noteable wookies are Chewbacca and Gungi";
            }
            else
            {
                Bio = "No Biography on this race is available.";
            }

            return Bio;
        }
        public string GetImageFileName(Player player)
        {
            
            string fileName = null;
            if (player.Race == Character.Races.Mandalorian)
            {
                fileName = @"C:\Users\phili\Desktop\Application Dev\TBQuestBasic\TBQuestBassic\TBQuestBassic\Assets\mandolorain.jpg";
            }
            else if (player.Race == Character.Races.Human)
            {
                fileName = @"C:\Users\phili\Desktop\Application Dev\TBQuestBasic\TBQuestBassic\TBQuestBassic\Assets\human.jpg";
            }
            else if (player.Race == Character.Races.Wookie)
            {
                fileName = @"C:\Users\phili\Desktop\Application Dev\TBQuestBasic\TBQuestBassic\TBQuestBassic\Assets\wookie.jpg";
            }

            return fileName;
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
    }
}
