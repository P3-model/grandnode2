﻿using Grand.Business.Core.Interfaces.Common.Security;
using Grand.Domain.Permissions;
using Grand.Web.Common.Components;
using Microsoft.AspNetCore.Mvc;

namespace Grand.Web.Admin.Components;

public class OrderTimeChartViewComponent : BaseAdminViewComponent
{
    private readonly IPermissionService _permissionService;

    public OrderTimeChartViewComponent(IPermissionService permissionService)
    {
        _permissionService = permissionService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        if (!await _permissionService.Authorize(StandardPermission.ManageOrders))
            return Content("");

        return View();
    }
}