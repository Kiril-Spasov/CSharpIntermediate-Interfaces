using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Uploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video has been uploaded to the cloud storage.");
        }
    }
}
