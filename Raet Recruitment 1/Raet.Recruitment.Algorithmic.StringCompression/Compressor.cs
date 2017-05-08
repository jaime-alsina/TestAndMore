using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Raet.Recruitment.Algorithmic.StringCompression
{
    public class Compressor
    {
        public string Compress(string input)
        {
            string processData = string.Empty;
            if (string.IsNullOrWhiteSpace(input))
            {
                return processData;
            }

            bool stringIsValid = Regex.IsMatch(input, @"^[a-zA-Z0-9\-]");

            var lst = new List<Letter>();

            if (stringIsValid)
            {
               // process the input by creating a letter object
                foreach (var item in input)
                {
                    this.AddCharacter(item.ToString(), ref lst);
                }

                var sb = new StringBuilder();

                // Apply the display logic
                foreach (var item in lst)
                {
                    sb.Append(item.ToString());
                }
                processData = sb.ToString();
            }

            if (processData.Length >= input.Length)
            {
                processData = input;
            }

            return processData;
        }

        // see if previuos is the same as the one added
        private void AddCharacter(string c, ref List<Letter> lst)
        {
            var lastEntry = lst.LastOrDefault();
            if (lastEntry != null && lastEntry.Character == c)
            {
                lastEntry.Count = lastEntry.Count + 1;
            }
            else
            {
                lst.Add(new Letter() { Character = c, Count = 1 });
            }
        }

    }
}
