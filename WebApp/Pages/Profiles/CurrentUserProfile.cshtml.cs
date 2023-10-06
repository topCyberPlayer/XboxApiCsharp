using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Profiles
{
    public class CurrentUserProfileModel : PageModel
    {
        public async Task OnGet()
        {
            var asd = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "http://schemas.microsoft.com/identity/claims/identityprovider")?.Value;

            //signInManager.

            var props = new AuthenticationProperties();
            //props.StoreTokens(info.AuthenticationTokens);
            //props.IsPersistent = false;

            var authenticateResult = await HttpContext.AuthenticateAsync("Microsoft");

            if (authenticateResult.Succeeded)
            {
                // �������� `authorization_code` �� authenticateResult.Properties
                IDictionary<string, string?> items = authenticateResult.Properties.Items;

                // ������ �� ������ ������������ `authorizationCode` ��� ������� ������ OAuth2.
                // �������������� ������ ��������� ������ �����.

                var accessToken = authenticateResult.Properties.GetTokenValue("access_token");
                var refreshToken = authenticateResult.Properties.GetTokenValue("refresh_token");

                // �������� ���������� � ������������
                var user = authenticateResult.Principal;
            }
            else
            {
                // ��������� ��������� ��������������
            }
            
        }
    }
}
