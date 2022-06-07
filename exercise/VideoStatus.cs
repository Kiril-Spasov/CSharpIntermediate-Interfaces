using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class VideoStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("New status: Processing");
        }
    }
}
