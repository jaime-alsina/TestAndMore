using System;

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
            throw new NotImplementedException("Waiting to be implemented.");
        }

    }
}