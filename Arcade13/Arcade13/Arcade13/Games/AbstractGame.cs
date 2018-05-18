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
    enum TurnPlayer        //May or may not be needed 
    {
        HUMAN,
        CPU
    }
    abstract class AbstractGame
    {
        public EndPlayerState endstate { get; private set; }

        public string Name { get; private set; }

        public string Rules { get; private set; }

        private BasePlayer[] Players { get; set; }

        private Token[] Tokens { get; set; }

        private Board GameBoard;

        public AbstractGame(BasePlayer[] players, Token[] tokens)
        {
            Players = players;
            Tokens = tokens;
            //Name and Rules are Hardcoded or grabbed from file if so wished here or from another method called in here
            //Board is also defined here but may not need to be passed in
        }

        public abstract EndPlayerState Play();             //Main game method. Consider hyperthreading so it doesn't need to wait for the gui to update 
        public abstract EndPlayerState EndGame();         //Are the endgame conditions met and who won
        public abstract void HumanTurn();           //Turns would be better defined
        public abstract void CPUTurn();            //here because they are game specific
                                                   //and don't really need to be
                                                   //defined in their classes. Otherwise
                                                   //each game's rules would need to be
                                                   //sent to each player object in order to work









    }
}