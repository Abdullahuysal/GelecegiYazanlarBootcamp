using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionLifetime.Services
{
    public interface IScopedService
    {
        Guid GetID();
    }
}
