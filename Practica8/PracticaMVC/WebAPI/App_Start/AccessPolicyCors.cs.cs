using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Web.Http.Cors;
using CorsPolicy = System.Web.Cors.CorsPolicy;
using ICorsPolicyProvider = System.Web.Http.Cors.ICorsPolicyProvider;

namespace WebAPI.App_Start
{
    public class AccessPolicyCors : Attribute, ICorsPolicyProvider
    {
        public async Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var corsRequestContext = request.GetCorsRequestContext();
            var originRequested = corsRequestContext.Origin;
            if (await IsOriginFromCustomer(originRequested))
            {
                var policy = new CorsPolicy
                {
                    AllowAnyHeader = true,
                    AllowAnyMethod = true

                };
                policy.Origins.Add(originRequested);
                policy.Origins.Add("http://localhost:4200");
                return policy;
            }
            return null;
        }
        private async Task<bool> IsOriginFromCustomer(string originRequested)
        {
            return true;
        }
    }
}
