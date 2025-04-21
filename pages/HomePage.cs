using Microsoft.Playwright;

namespace AOATs;

public class HomePage
{
  private readonly IPage _page;

    public HomePage(IPage page)
    {
        _page = page;
    }

    public ILocator WelcomeHeading => _page.Locator("//h1[text()='Welcome to the technology demo of accessibility online']");

  public async Task GotoAsync()
  {
    await _page.GotoAsync("https://accessibility.online/");
  }

  public async Task<bool> CheckWelcomeHeadingIsVisible()
  {
    return await WelcomeHeading.IsVisibleAsync();
  }
}
