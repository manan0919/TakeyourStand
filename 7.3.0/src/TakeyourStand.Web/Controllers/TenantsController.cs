﻿using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using TakeyourStand.Authorization;
using TakeyourStand.MultiTenancy;

namespace TakeyourStand.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : TakeyourStandControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _tenantAppService.GetAllAsync(new PagedResultRequestDto { MaxResultCount = int.MaxValue }); //Paging not implemented yet
            return View(output);
        }

        public async Task<ActionResult> EditTenantModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.GetAsync(new EntityDto(tenantId));
            return View("_EditTenantModal", tenantDto);
        }
    }
}