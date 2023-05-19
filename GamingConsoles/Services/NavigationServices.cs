using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsoles.Services
{
    public class NavigationServices : INavigationServices
    {
        public Task NavigateToAsync(string route, IDictionary<string, object> parameters)
        {
            if (parameters != null)
            {
                return Shell.Current.GoToAsync(route, parameters);
            }
            else
            {
                return Shell.Current.GoToAsync(route);
            }
        }
    }
}
