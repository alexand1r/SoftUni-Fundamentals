using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToUppercase
{
    class ToUppercase
    {
        static void Main(string[] args)
        {
            string matchCodeTag = @"<upcase>(.*?)<\/upcase>";
            string textToReplace = Console.ReadLine();
            
            var result = Regex.Replace(textToReplace, matchCodeTag,
                    m =>
                    {
                        var codeString = m.Groups[1].Value;
                        return codeString.ToUpper();
                    });

            Console.WriteLine(result);
        }
    }
}
//string text = Console.ReadLine();
//string resultText = "";
//List<string> tags = new List<string>();
//tags.Add("<upcase>");
//            tags.Add("</upcase>");
//            int i = 0;
//int tagIndexStart = -1;
//int tagIndexEnd = -1;

//            while (i<text.Length)
//            {
//                tagIndexStart = text.IndexOf(tags[0], i);
//                tagIndexEnd = text.IndexOf(tags[1], i);
//                if (tagIndexStart == -1) break;
//                // add regular text
//                resultText += text.Substring(i, tagIndexStart - i);
//                // add uppercase text
//                resultText += text.Substring(tagIndexStart + tags[0].Length,
//                                             tagIndexEnd - tagIndexStart - tags[0].Length)
//                                            .ToUpper();
//i = tagIndexEnd + tags[1].Length;
//            }
//            // add remaining text
//            if (tagIndexStart == -1 && i<text.Length)
//                resultText += text.Substring(i, text.Length - i);
//            Console.WriteLine(resultText);