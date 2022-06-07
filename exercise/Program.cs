using System;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new Uploader());
            workflow.AddActivity(new Informer());
            workflow.AddActivity(new SendEmail());
            workflow.AddActivity(new VideoStatus());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
            
        }
    }
}
