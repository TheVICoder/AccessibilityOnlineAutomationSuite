using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;

namespace AOATs;


public class HomePageTests : PageTest
{
    [Fact]
public async Task CheckWelcomeTitleIsVisible()
    {
        await Page.GotoAsync("https://accessibility.online/");

        var TitleIsVisible = await Page.Locator("//h1[text()='Wecome to the technology demo of accessibility online']").IsVisibleAsync();
         Assert.True(TitleIsVisible);
    }
}
