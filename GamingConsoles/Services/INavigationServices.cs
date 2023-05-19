using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingConsoles.Services
{
    public interface INavigationServices
    {
        Task NavigateToAsync(string route, IDictionary<string, object> parameters);
    }
}
