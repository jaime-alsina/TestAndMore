using System;
using System.Linq;

namespace PracticeAlgo.FilePath
{
    public class Path
    {
        public string CurrentPath { get; private set; }

        public Path(string path)
        {
            this.CurrentPath = path;
        }

        public void Cd(string newPath)
        {
            var decompose = newPath.Split('/');
            foreach (var item in decompose)
            {
                switch (item)
                {
                    case "..":
                        var p = CurrentPath.LastIndexOf('/');
                        this.CurrentPath = CurrentPath.Substring(0, p);
                        this.CurrentPath = this.CurrentPath + newPath.Replace("..", string.Empty);
                        break;
                    default:
                        break;
                }
            }
        }

    }
}