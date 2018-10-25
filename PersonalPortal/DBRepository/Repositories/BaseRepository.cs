using DBRepository.Interfaces;

namespace DBRepository.Repositories
{
    public class BaseRepository
    {
        public string ConnectionString { get; }
        public IRepositoryContextFactory ContextFactory { get; }
        public BaseRepository(string connectionString, IRepositoryContextFactory contextFactory)
        {
            ConnectionString = connectionString;
            ContextFactory = contextFactory;
        }
    }
}
