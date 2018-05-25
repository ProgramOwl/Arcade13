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
    //the grid starts from the top left like a monitor's coordinate system
    
    class TTTBoard : Board
    {
        Cell[,] grid;
        public TTTBoard(Token[] t)
        {
            grid = new Cell[3, 3];
        }

        //Flush out
        public override void ClearBoard()
        {
            throw new NotImplementedException();
        }

        public void setCellOwner(Player p, int x, int y)
        {
            grid[x, y].token = getOwned(p);
        }

        private Token getOwned(Player p)
        {
            foreach(Token t in PlayerTokens)
            {
                if (t.Owner.Equals(p))
                {
                    return t;
                }
            }
            return null;
        }
    }
}