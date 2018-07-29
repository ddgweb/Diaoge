using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Diaoge.EntityFrameworkCore;
using Diaoge.Tests.TestDatas;

namespace Diaoge.Tests
{
    public class DiaogeTestBase : AbpIntegratedTestBase<DiaogeTestModule>
    {
        public DiaogeTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<DiaogeDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<DiaogeDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<DiaogeDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<DiaogeDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<DiaogeDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<DiaogeDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<DiaogeDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<DiaogeDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
