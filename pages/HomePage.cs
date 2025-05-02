using Microsoft.Playwright;

namespace AOATs;

public class HomePage
{
  private readonly IPage _page;

  public HomePage(IPage page)
  {
    _page = page;
  }

  private ILocator WelcomeHeading => _page.Locator("//h1[contains(text(),\"  We're on a mission. Take Accessibility Mainstream.\")]");

  private ILocator RegisterLink => _page.Locator("//a[text()='Register']");

  private ILocator LoginLink => _page.Locator("//a[text()='Login']");

  private ILocator LogoLink => _page.Locator("//a[text()='AO']");

  private ILocator HomeLink => _page.Locator("//a[text()='Home']");

  private ILocator PrivacyLink => _page.Locator("//a[text()='Privacy']");

  private ILocator LoginButton => _page.Locator("//div[1]/div[3]/a[contains(text(), 'Login')]");

  private ILocator JoinUsTodayButton => _page.Locator("//div[2]/div[1]/a[contains(text(), 'Join us today')]");

  private ILocator MemorialLink => _page.Locator("//footer/div/a[@href='/Home/Memorial']");

  public async Task GotoAsync()
  {
    await _page.GotoAsync("http://factory.accessibility.online/");
  }

  public async Task ClickRegisterLink()
  {
    await RegisterLink.ClickAsync();
  }

  public async Task<bool> CheckWelcomeHeadingIsVisible()
  {
    return await WelcomeHeading.IsVisibleAsync();
  }
}
