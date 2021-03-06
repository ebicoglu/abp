﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Volo.Abp.SettingManagement
{
    public class AbpSettingManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAssemblyOf<AbpSettingManagementDomainSharedModule>();
        }
    }
}
