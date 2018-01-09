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
               /* new Client
                {
                    ClientId = "service.client",
                    ClientSecrets = { new Secret("my-shared-secret".Sha256()) },

                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes = { "core.api" }
                },*/

                /*new Client
                {
                    ClientId = "GxG.webclient",
                    ClientName = "Web Client",
                    ClientUri = "http://localhost:5000",

                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,

                    RedirectUris = { "http://localhost:5001" },
                    PostLogoutRedirectUris = { "http://localhost:5001" },
                    AllowedCorsOrigins = { "http://localhost:5001" },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Email,
                        "core.api"
                    }
                },*/

                /*new Client
                {
                    ClientId = "GxG.ui",
                    ClientName = "UI Client",
                    ClientUri = "http://localhost:5000",

                    AllowedGrantTypes = GrantTypes.Hybrid,
                    AllowOfflineAccess = true,
                    ClientSecrets = { new Secret("my-shared-secret".Sha256()) },

                    RedirectUris = { "http://localhost:5001" },
                    PostLogoutRedirectUris = { "http://localhost:5001" },
                    AllowedCorsOrigins = { "http://localhost:5001" },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Email,
                        "core.api"
                    }


                },*/

                new Client
                {
                    ClientId = "ro.client",
                    
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    
                    ClientSecrets = { new Secret("my-shared-secret".Sha256()) },
                    AllowedScopes = { "core.api" }
                }
            };
        }
    }
}
