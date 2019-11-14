using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MvcBasic.Helpers
{
    public class GlobalHelpers
    {
        public string StringToUnicode(string stringText)
        {
            char[] chars = stringText.ToCharArray();

            //string Poem = @"春花秋月何時了";
            string Poem = stringText;
            byte[] fileContent = new byte[Poem.Length * 2];
            int index = 0;
            for (int i = 0; i < Poem.Length; i++)
            {
                byte[] word = Encoding.Default.GetBytes(Poem.Substring(i, 1));
                fileContent[index] = word[0];
                fileContent[++index] = word[1];
                ++index;
            }

            StringBuilder sb = new StringBuilder();
            for(int i=0; i < fileContent.Length; i++)
            {
                sb.Append(@"\u" + fileContent[i].ToString("X2"));
            }

            return sb.ToString();
        }

        //SO-8859-1 is the default character in HTML 4.01.
        // Convert String to ISO 8859-1 character
        public string StringToIso8859_1(string stringText)
        {
            StringBuilder sb = new StringBuilder();

            char[] chars = stringText.ToCharArray();
            for(int i=0;i < stringText.Length; i++)
            {
                sb.Append(@"&#");
                sb.Append((int)chars[i]);
                sb.Append(";");
            }

            return sb.ToString();
        }
    }
}