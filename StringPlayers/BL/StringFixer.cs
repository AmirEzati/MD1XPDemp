using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StringPlayers.BL
{
    public class StringFixer
    {
        public string FixString(string text)
        {
            string output = null;

            #region t1
            output = text;
            #endregion

            #region t2

          //  output = text.TrimStart();

            #endregion

            #region t2

           // output = text.TrimEnd();

            #endregion

            return output;
        }
    }
}