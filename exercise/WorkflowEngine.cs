using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class WorkflowEngine
    {

        public void Run(IWorkflow activity)
        {
            foreach (IActivity I in activity.GetActivity())
                I.Execute();
        }
    }
}
