using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using IdentityServer4.Models;

namespace GxG.AuthTest
{
    public class Clients
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "api.client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = { new Secret("my-shared-secret".Sha256())},
                    AllowedScopes = {"core.api"}
                },
                
                new Client()
                {
                    ClientId = "ro.client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets = { new Secret("my-shared-secret".Sha256())},
                    AllowedScopes = {"core.api"}
                },
                
                new Client()
                {
                    ClientId = "mvc",
                    ClientName = "MVC Client",
                    AllowedGrantTypes = GrantTypes.HybridAndClientCredentials,

                    ClientSecrets = { new Secret("my-shared-secret".Sha256())},

                    RedirectUris = { "http://localhost:5002/Home/About" },
                    PostLogoutRedirectUris = { "http://localhost:5002/signout-callback-oidc" },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "core.api"
                    },
                    AllowOfflineAccess = true
                },

                new Client()
                {
                    ClientId = "js",
                    ClientName = "JavaScript Client",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,

                    AccessTokenLifetime = 60,
                    AbsoluteRefreshTokenLifetime = 60,
                    RefreshTokenExpiration = TokenExpiration.Absolute,

                    RedirectUris = {"http://localhost:5001/auth-callback", "http://localhost:5001/silent-refresh.html"},
                    AllowedCorsOrigins = {"http://localhost:5001"},
                    PostLogoutRedirectUris = {"http://localhost:5001/"},
                    
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "core.api"
                    }
                }
            };
        }
    }
}
