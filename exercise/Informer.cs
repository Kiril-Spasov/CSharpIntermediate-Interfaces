using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Informer : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is ready for encoding.");
        }
    }
}
