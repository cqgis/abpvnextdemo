## ReadMe

 This Project is Show the problem about abp vnext 

 https://github.com/abpframework/abp/issues/2262[!https://github.com/abpframework/abp/issues/2262]


 It just add custom app service 

 ``` c#
     public interface IDemoTestAppService : IApplicationService
    {
        /// <summary>
        /// method use [Authorize]
        /// </summary>
        /// <returns></returns>
        Task<string> GetInfoWithAuthorizeAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<string> GetInfoAsync();
    }

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

 ```

 ### Steps

 1. Run `demo.DbMigrator` 

 2. Run `deom.web`

   
 + `https://localhost:44315/api/app/demoTest/infoWithAuthorize`  will redirect to login page, if after login ,will redirect to error page


 + `https://localhost:44315/api/app/demoTest/info`  get right json data.


