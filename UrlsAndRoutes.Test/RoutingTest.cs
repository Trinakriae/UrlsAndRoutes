using System;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UrlsAndRoutes.Test
{
    [TestClass]
    public class RoutingTest
    {
        public void TestRouteMatch(string url, string controller, string action, object routeProperties = null, string httpMethod = "GET")
        {
            //Arrange
            RouteCollection routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);

            //Act - process the route
            RouteData result = routes.GetRouteData(TestHelper.CreateHttpContext(url, httpMethod));

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(TestHelper.TestIncomingRouteResult(result, controller, action, routeProperties));
        }
    }
}
