using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexApp.Models
{
    public class MyRegex
    {
        
        public static string? FindRegexInText(string Text, string Pattern)
        {
            string res = "";
            Regex r = new Regex(Pattern);
            MatchCollection m = r.Matches(Text);
            foreach (Match x in m)
            {
                res += (x.Value + "\n");
            }
            return res;
        }
    }
}
