using System.Threading.Tasks;
using Diaoge.Web.Controllers;
using Shouldly;
using Xunit;

namespace Diaoge.Web.Tests.Controllers
{
    public class HomeController_Tests: DiaogeWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
