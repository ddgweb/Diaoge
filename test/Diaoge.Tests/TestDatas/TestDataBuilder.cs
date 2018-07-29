using Diaoge.EntityFrameworkCore;

namespace Diaoge.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly DiaogeDbContext _context;

        public TestDataBuilder(DiaogeDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}