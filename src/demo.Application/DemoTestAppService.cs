using System;
using System.Threading.Tasks;
using demo.Permissions;
using Microsoft.AspNetCore.Authorization;

namespace demo
{
    public class DemoTestAppService :demoAppService, IDemoTestAppService
    {
        [Authorize(demoPermissions.DemoValidPermission)]
        public Task<string> GetInfoWithAuthorizeAsync()
        {
            return Task.FromResult("Hello World");
        }


        public async Task<string> GetInfoAsync()
        {
            await this.CheckPolicyAsync(demoPermissions.DemoValidPermission);
            return "Hello World";
        }
    }
}