﻿// See https://aka.ms/new-console-template for more information
using DependencyInjectionDemo_NETCore;
using Microsoft.Extensions.DependencyInjection;

// 1. 建立依賴注入的容器
var serviceCollection = new ServiceCollection();
// 2. 註冊服務
serviceCollection.AddTransient<App>();
serviceCollection.AddTransient<IService, ChtService>();
// 建立依賴服務提供者
var serviceProvider = serviceCollection.BuildServiceProvider();

// 3. 執行主服務
serviceProvider.GetRequiredService<App>().Run();