﻿using Microsoft.Extensions.DependencyInjection;
using Tel.Egram.Components.Messenger;
using Tel.Egram.Components.Messenger.Catalog;
using Tel.Egram.Components.Messenger.Explorer;
using Tel.Egram.Components.Messenger.Explorer.Triggers;

namespace Tel.Egram.Registry
{
    public static class MessengerRegistry
    {
        public static void AddMessenger(this IServiceCollection services)
        {
            services.AddTransient<IAvatarManager, AvatarManager>();
            services.AddTransient<IMessageModelFactory, MessageModelFactory>();
            services.AddScoped<IExplorerTrigger, ExplorerTrigger>();
            services.AddTransient<IExplorerProvider, ExplorerProvider>();
            services.AddTransient<ExplorerModel>();
            
            services.AddScoped<ICatalogProvider, CatalogProvider>();
            services.AddTransient<CatalogModel>();
        }
    }
}