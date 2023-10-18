using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Account
{
    public class MicrosoftCallbackModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            var authenticateResult1 = await HttpContext.AuthenticateAsync();
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

            // ������������� ������������ ������� �� ������� �������� ��� ������ ��������.
            return RedirectToPage("/Index");
        }
    }
}
