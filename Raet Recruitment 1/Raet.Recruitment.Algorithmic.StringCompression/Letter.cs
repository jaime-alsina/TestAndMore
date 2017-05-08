using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raet.Recruitment.Algorithmic.StringCompression
{
    public class Letter
    {
        public string Character { get; set; }

        public int Count { get; set; }

        /// <summary>
        /// Applies the require logic to return the number of characters
        /// </summary>
        /// <returns>the process string im the correct format</returns>
        public override string ToString()
        {
            var numb = Count.ToString().ToArray().Select(x => { return Character + x.ToString(); }).Aggregate((current, next) => current + next);

            return numb;
        }
    }
}
