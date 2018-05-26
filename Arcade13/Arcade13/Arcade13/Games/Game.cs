using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Arcade13.Models;

namespace Arcade13.Games
{
    enum EndPlayerState
    {
        WIN,
        LOSE,
        TIE,
        CONTINUING
    }

    abstract class Game : Activity
    {
        public EndPlayerState EndState { get; private set; }

        private Player[] Players { get; set; }
        private Board GameBoard;
        private int TurnCounter = 0;

        public Game()
        {

        }
        public Game(Player[] players)
        {
            this.Players = players;
        }

        //Not sure
        public abstract EndPlayerState Play();             //Main game method. Consider hyperthreading so it doesn't need to wait for the gui to update 
        public abstract EndPlayerState EndGame();         //Are the endgame conditions met and who won
    }
}