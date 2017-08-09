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
                output = output.Replace("  ", " ");
            }
            ;
            #endregion
            #endregion

            // #region Team B from Iran
            #region t5
            output = output.Replace(".", "");
            #endregion

            #region t6
            output = output.Replace("&", "");
            #endregion

            // //#region t6
            // //List<string> IllegalCharacters = new List<string> {"%","^","*","#","$","&" };

            // //foreach(var illegalchar in IllegalCharacters)
            // //{
            // //    output = output.Replace(illegalchar, "");
            // //}
            // //#endregion

            // #region t7
            // List<string> IllegalCharacters2 = new List<string> { "%", "^", "*", "#", "$", "&" };
            // IllegalCharacters2.ForEach(c =>{
            //     if (!c.Contains("&"))
            //     {
            //         output = output.Replace(c, "");
            //     }
            // });
            // //foreach (var illegalchar2 in IllegalCharacters2)
            // //{
            // //    if (illegalchar2!="&")
            // //    output = output.Replace(illegalchar2, "");
            // //}


            // #endregion
            //#endregion
            return output;
        }
    }
}