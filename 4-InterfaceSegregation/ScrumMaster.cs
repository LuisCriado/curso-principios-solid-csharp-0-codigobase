namespace InterfaceSegregation
{
    public class ScrumMaster : IWorkTeamActiviis
    {
        public ScrumMaster()
        {
        }

        public void Plan() 
        {
             Console.WriteLine("I'm planning user stories");
        }

        public void Comunicate() 
        {
            Console.WriteLine("I'm talking to the team user");
        }

       
    }
}