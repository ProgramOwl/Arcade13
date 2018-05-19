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
    //Use to bind to the view
    //These are the elements of the board that are bound to the view
    //The game reads these through the board which holds these and the tokens
    class Cell
    {
        bool Occupied;
        public Token token;

        public Cell()
        {
            token = null;
            bool Occupied = false;
        }

        public Player OccupyingPlayer()
        {
            return token.Owner;
        }

    }
}