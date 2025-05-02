using Microsoft.Playwright;

namespace AOATs;

public class RegistrationPage
{
  private readonly IPage _page;

  public RegistrationPage(IPage page)
  {
    _page = page;
  }

  private ILocator CreateAccountHeading => _page.Locator("//h1[text()='Create your account']");

  private ILocator RegisterLink => _page.Locator("//a[text()='Register']");

  private ILocator LoginLink => _page.Locator("//a[text()='Login']");

  private ILocator LogoLink => _page.Locator("//a[text()='AO']");

  private ILocator HomeLink => _page.Locator("//a[text()='Home']");

  private ILocator PrivacyLink => _page.Locator("//a[text()='Privacy']");

  private ILocator UsernameInputField => _page.Locator("//input[@id='username']");
  
  private ILocator EmailInputField => _page.Locator("//input[@id='email']");

  private ILocator PasswordInputField => _page.Locator("//input[@id='password']");

  private ILocator ConfirmPasswordInputField => _page.Locator("//input[@id='confirmPassword']");

  private ILocator NextStepButton => _page.Locator("//button[@id='submitStep1']");
  public async Task GotoAsync()
  {
    await _page.GotoAsync("https://accessibility.online/account/register");
  }

  public async Task<bool> CheckCreateAccountHeadingIsVisible()
  {
    return await CreateAccountHeading.IsVisibleAsync();
  }
}
