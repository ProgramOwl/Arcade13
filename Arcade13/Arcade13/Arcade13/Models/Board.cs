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

namespace Arcade13.Models
{
    public abstract class Board
    {
        public Token[,] PlayerTokens;
        private int BOARD_SIZE;

        public Board()
        {
            PlayerTokens = new Token[BOARD_SIZE, BOARD_SIZE];
        }
        public abstract void ClearBoard();
    }
}