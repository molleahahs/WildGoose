using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WildGoose.Application.Permission.Internal.V10;
using WildGoose.Application.Permission.Internal.V10.Queries;

namespace WildGoose.Controllers.V10;

[Route("api/v1.0/permissions")]
[ApiController]
#if !DEBUG
[Authorize]
#endif
public class PermissionController : ControllerBase
{
    private readonly PermissionService _permissionService;

    public PermissionController(PermissionService permissionService)
    {
        _permissionService = permissionService;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="query"></param>
    /// <returns></returns>
    [HttpPost("enforce")]
    public async Task<IActionResult> EnforceAsync([FromBody] List<EnforceQuery> query)
    {
        if (query.Count == 0)
        {
            return Content("[]", "application/json");
        }

        var builder = new StringBuilder("[");
        for (var i = 0; i < query.Count; ++i)
        {
            var v = await _permissionService.EnforceAsync(query[i]);
            builder.Append(v ? "true" : "false");
            if (i != query.Count - 1)
            {
                builder.Append(',');
            }
        }

        builder.Append(']');
        return Content(builder.ToString(), "text/plain");
    }
}