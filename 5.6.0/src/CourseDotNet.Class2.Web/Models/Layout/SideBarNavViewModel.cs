using Abp.Application.Navigation;

namespace CourseDotNet.Class2.Web.Models.Layout
{
    public class SideBarNavViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}