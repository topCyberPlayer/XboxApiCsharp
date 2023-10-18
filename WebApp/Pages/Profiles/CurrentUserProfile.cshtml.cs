using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Profiles
{
    
    public class CurrentUserProfileModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        public CurrentUserProfileModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public async Task OnGet()
        {
            //�������� ������ ��������� ������ ������� �� ��:ProfileUser

            var asdfdf = await _signInManager.GetExternalAuthenticationSchemesAsync();
            var b = await _signInManager.ExternalLoginSignInAsync("Microsoft", "0f29ee4d4b9131de", true);

            //var authenticateResult = await HttpContext.AuthenticateAsync("Microsoft");
            //var identity = HttpContext.User.Identity;
            //var identities = HttpContext.User.Identities;
            //;

            //if (authenticateResult.Succeeded)
            //{
            //    // �������� `authorization_code` �� authenticateResult.Properties
            //    IDictionary<string, string?> items = authenticateResult.Properties.Items;

            //    // ������ �� ������ ������������ `authorizationCode` ��� ������� ������ OAuth2.
            //    // �������������� ������ ��������� ������ �����.

            //    var accessToken = authenticateResult.Properties.GetTokenValue("access_token");
            //    var refreshToken = authenticateResult.Properties.GetTokenValue("refresh_token");

            //    // �������� ���������� � ������������
            //    var user = authenticateResult.Principal;
            //}
            //else
            //{
            //    // ��������� ��������� ��������������
            //}

        }
    }
}
