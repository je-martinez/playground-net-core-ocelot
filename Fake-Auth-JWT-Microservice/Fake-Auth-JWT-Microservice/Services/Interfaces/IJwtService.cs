using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fake_Auth_JWT_Microservice.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken();
    }
}
