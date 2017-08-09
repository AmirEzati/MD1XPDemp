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
            #region Team A from England

            
            #region t1
            //Written in 2014
            output = text;
            #endregion

            #region t2
            //Written in 2015
             output = text.TrimStart();

            #endregion

            #region t3

             output = output.TrimEnd();

            #endregion

            #region t4
            while (output.Contains("  "))
            {
                output = output.Replace("  "," ");
            }
           ;
            #endregion
            #endregion

            #region Team B from Iran
            #region t5
            output = output.Replace(".", "");
            #endregion
            #endregion
            return output;
        }
    }
}