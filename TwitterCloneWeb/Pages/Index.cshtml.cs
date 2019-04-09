using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TwitterClone;
using TwitterClonePersistence;

namespace TwitterCloneWeb.Pages
{
    public class IndexModel : PageModel
    {

        TwitterCloneDiskPersistence persistence = new TwitterCloneDiskPersistence();
        public ICollection<User> Users = null;

        public void OnGet()
        {
            Users = persistence.GetUsers();
        }
    }
}
