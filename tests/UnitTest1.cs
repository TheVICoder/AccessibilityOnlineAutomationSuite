using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;

namespace AOATs;


public class HomePageTests : PageTest
{
    [Fact]
    public async Task CheckWelcomeTitleIsVisible()
    {
        var _homePage = new HomePage(Page);
        await _homePage.GotoAsync();

        Assert.True(await _homePage.CheckWelcomeHeadingIsVisible());
    }

    [Fact]
    public async Task CheckCreateAccountTitleIsVisible()
    {
        var _homePage = new HomePage(Page);
        var _registrationPage = new RegistrationPage(Page);
        await _homePage.GotoAsync();
        await _homePage.ClickRegisterLink();

        Assert.True(await _registrationPage.CheckCreateAccountHeadingIsVisible());
    }
}
