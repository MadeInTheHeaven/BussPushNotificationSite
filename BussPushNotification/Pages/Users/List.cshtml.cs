using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BussPushNotification.Pages.Users
{
    public class ListModel : AdminPageModel
    {
        public UserManager<IdentityUser> UserManager { get; set; }
        public ListModel(UserManager<IdentityUser> userManager)
        {
            UserManager = userManager;
        }
        public IEnumerable<IdentityUser> Users { get; set; } = Enumerable.Empty<IdentityUser>();
        public void OnGet()
        {
            Users = UserManager.Users;
        }
    }
}
