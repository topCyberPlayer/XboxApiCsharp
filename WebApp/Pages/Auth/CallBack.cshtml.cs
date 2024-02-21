using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using WebApp.Services;

namespace WebApp.Pages.Auth
{
    public class CallBackModel : PageModel
    {
        private readonly AuthenticationService _authServ;

        public CallBackModel(AuthenticationService authServ)
        {
            _authServ = authServ;
        }

        //private AuthenticationServiceDb _authServiceDb;

        //public CallBackModel(AuthenticationServiceDb authServiceDb)
        //{
        //    _authServiceDb = authServiceDb;
        //}

        public async Task OnGet(string code)
        {
            var error = HttpContext.Request.Query["error"];
            var errorDescription = HttpContext.Request.Query["error_description"];

            // ���������, ��� �� ������� ���
            if (code == null)
            {
                // ��������� ������ - ��� �� ��� �������
                //return RedirectToAction("ExternalLoginFailure");
            }

            try
            {
                // ����� ����� ������������ ���������� ��� ��� ������ �� ����� ��� ��� ������ ��������
                // ��������, ��������� ������ � �������� ������� ��� ��������� ������
                // ��� ��������� ������ ��������, ��������� � �������� ������ ������������

                // ��� ��� ��� ��������� ��������� ����� ������������
                if (User.Identity.IsAuthenticated)
                {
                    string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    await _authServ.ZeroStart(userId, code);
                    //_authServiceDb.SaveToDb(userId, new Models.TokenXstsModelXbl());
                }
                
                // ����� ��������� ��������� �����, �������������� ������������ �� ��������, ��������, ��������
                //return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                // ��������� ������
                // �����������, �������� �����������, ��������������� �� �������� ������ � �.�.
                //return RedirectToAction("Error", "Home");
            }
        }
    }
}
