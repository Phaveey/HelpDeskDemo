namespace HelpDeskDemo.WebApi.Exceptions
{
    public sealed class ProblemNotFoundException : NotFoundException
    {
        public ProblemNotFoundException(int Id) 
            : base($"Problem with this Id {Id} doesn't exist in the database  " )
        {
        }
    }
}
