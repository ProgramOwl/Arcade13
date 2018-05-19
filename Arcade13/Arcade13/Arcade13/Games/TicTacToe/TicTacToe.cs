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

//NOAH look at this in more detail later ~Noah

namespace Arcade13.Games.TicTacToe
{
    class TicTacToe : Game
    {
        public TicTacToe(Player[] players) : base(players) { }

        public override EndPlayerState EndGame()
        {
            throw new NotImplementedException();
        }

        public override EndPlayerState Play()
        {
            EndPlayerState state = EndPlayerState.CONTINUING;

            while (EndGame() == EndPlayerState.CONTINUING)
            {
                //HumanTurn();
                state = EndGame();
                if (EndGame() != EndPlayerState.CONTINUING)
                {
                    break;
                }
                //CPUTurn();
                state = EndGame();
            }
            return state;
        }
    }
}