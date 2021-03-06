using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Soloco.RealTimeWeb.Common;
using Soloco.RealTimeWeb.Common.Security;

namespace Soloco.RealTimeWeb.Membership.Clients.Domain
{
    public static class Clients
    {
        public static IEnumerable<Client> Get(IConfiguration configuration)
        {
            return new List<Client>
            {
                new Client
                {
                    Id = Guid.NewGuid(),
                    Key = "realTimeWebClient",
                    Name = "React front-end Application",
                    ApplicationType = ApplicationTypes.JavaScript,
                    Active = true,
                    AllowedOrigin = configuration.WebHostName(),
                    RedirectUri = configuration.WebHostName() + "account/authorized"
                },
                new Client
                {
                    Id = Guid.NewGuid(),
                    Key = "automatedTests",
                    Secret = Hasher.ComputeSHA256("*automatedTests@localhost"),
                    Name = "Automated tests",
                    ApplicationType = ApplicationTypes.NativeConfidential,
                    Active = true,
                    AllowedOrigin = "*",
                    RedirectUri = "*"
                }
            };
        }
    }
}