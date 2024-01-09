using LearnProject.Entity.Concrete;
using System.Web.Mvc;

namespace LearnProject.MvcWebUI.Models
{
    public class LoginViewModel
    {
        public string? Id { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
