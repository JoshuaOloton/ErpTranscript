using ErpTranscript.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ErpTranscript.Security
{
    public class AccessPageHandler : AuthorizationHandler<ManagePermissionsRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ManagePermissionsRequirement requirement)
        {
            var authFilterContext = context.Resource as AuthorizationFilterContext;
            if (authFilterContext == null)
            {
                return Task.CompletedTask;
            }
            var userId = authFilterContext.HttpContext.Request.Cookies.Where(c => c.Key == "userId").FirstOrDefault().Value;

            using (var erpContext = new ErpDbContext())
            {
                var previledge = (from record in erpContext.UserPreviledges
                                  where record.Activityid == 10
                                  && record.Userid == Convert.ToInt32(userId)
                                  select record);
                if (previledge != null && previledge.Any())
                {
                    context.Succeed(requirement);
                }
            }

            return Task.CompletedTask;
        }
    }
}
