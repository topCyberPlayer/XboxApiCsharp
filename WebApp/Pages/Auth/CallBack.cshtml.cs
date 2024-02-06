using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Auth
{
    public class CallBackModel : PageModel
    {
        public IActionResult OnGet(string code)
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
                // ����� ����� ������������ ���������� ��� ��� ������ �� ����� ��� ��� ������ ��������
                // ��������, ��������� ������ � �������� ������� ��� ��������� ������
                // ��� ��������� ������ ��������, ��������� � �������� ������ ������������

                // ��� ��� ��� ��������� ��������� ����� ������������

                // ����� ��������� ��������� �����, �������������� ������������ �� ��������, ��������, ��������
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
