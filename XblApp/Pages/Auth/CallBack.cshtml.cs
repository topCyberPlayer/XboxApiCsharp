using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using XblApp.Application.UseCases;

namespace XblApp.Pages.Auth
{
    public class CallBackModel : PageModel
    {
        private readonly AuthenticationUseCase _authServ;

        public CallBackModel(AuthenticationUseCase authServ)
        {
            _authServ = authServ;
        }

        public async Task<IActionResult> OnGet(string code)
        {
            var error = HttpContext.Request.Query["error"];
            var errorDescription = HttpContext.Request.Query["error_description"];

            // ���������, ��� �� ������� ���
            if (code == null)
            {
                // ��������� ������ - ��� �� ��� �������
                return RedirectToAction("ExternalLoginFailure");
            }

            try
            {
                if (User.Identity.IsAuthenticated)
                {
                    await _authServ.RequestTokens(code);
                }
                
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                // ��������� ������
                // �����������, �������� �����������, ��������������� �� �������� ������ � �.�.
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
