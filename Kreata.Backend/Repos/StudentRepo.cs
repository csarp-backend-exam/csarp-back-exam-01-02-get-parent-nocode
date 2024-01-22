using Kreata.Backend.Context;

namespace Kreata.Backend.Repos
{
    public class StudentRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public StudentRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
