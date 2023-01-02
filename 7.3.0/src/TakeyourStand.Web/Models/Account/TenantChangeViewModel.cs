using Abp.AutoMapper;
using TakeyourStand.Sessions.Dto;

namespace TakeyourStand.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}