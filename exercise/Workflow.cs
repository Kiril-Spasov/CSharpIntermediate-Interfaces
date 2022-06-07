using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _workflow;
        public Workflow()
        {
            _workflow = new List<IActivity>();
        }
        public void AddActivity(IActivity activity)
        {
             _workflow.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            _workflow.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivity()
        {
            return _workflow;
        }
    }
}
