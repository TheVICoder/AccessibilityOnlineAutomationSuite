using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;

namespace AOATs;


public class HomePageTests : PageTest
{
    [Fact]
public async Task CheckWelcomeTitleIsVisible()
    {
var page = new HomePage(Page);
await page.GotoAsync();


        Assert.True(await page.CheckWelcomeHeadingIsVisible());
    }
}
