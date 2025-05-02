using System.Security;
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

  private ILocator AccountDetailsSubHeading => _page.Locator("//h2[text()='Account Details']");

  private ILocator AboutYouSubHeading => _page.Locator("//h2[text()='About You']");
  

  private ILocator RegisterLink => _page.Locator("//a[text()='Register']");

  private ILocator LoginLink => _page.Locator("//a[text()='Login']");

  private ILocator LogoLink => _page.Locator("//a[text()='AO']");

  private ILocator HomeLink => _page.Locator("//a[text()='Home']");

  private ILocator PrivacyLink => _page.Locator("//a[text()='Privacy']");

  private ILocator UsernameInputField => _page.Locator("//input[@id='username']");
  
  private ILocator EmailInputField => _page.Locator("//input[@id='email']");

  private ILocator PasswordInputField => _page.Locator("//input[@id='password']");

  private ILocator ConfirmPasswordInputField => _page.Locator("//input[@id='confirmPassword']");

  private ILocator NextStep1Button => _page.Locator("//button[@id='submitStep1']");
  public async Task GotoAsync()
  {
    await _page.GotoAsync("https://accessibility.online/account/register");
  }

    public async Task FillUsernameField()
    {
      await UsernameInputField.FillAsync("Smurphy");
    }

    public async Task FillEmailField()
    {
      await EmailInputField.FillAsync("josh.murphy1999@icloud.com");
    }

  public async Task FillPasswordField()
  {
    await PasswordInputField.FillAsync("Testpass4");
  }

  public async Task FillConfirmPasswordField()
  {
    await ConfirmPasswordInputField.FillAsync("Testpass4");
  }

  public async Task ClickFirstNextButton()
  {
    await NextStep1Button.ClickAsync();
  }

  public async Task<bool> CheckCreateAccountHeadingIsVisible()
  {
    return await CreateAccountHeading.IsVisibleAsync();
  }

  public async Task<bool> CheckAccountDetailsSubHeadingIsVisible()
  {
    return await AccountDetailsSubHeading.IsVisibleAsync();
  }

  public async Task<bool> CheckAboutYouSubHeadingIsVisible()
  {
    return await AboutYouSubHeading.IsVisibleAsync();
  }
}
