﻿using Autofac;
using System;
using Xunit;

namespace Sunruse.Influx.Unit
{
    public sealed class AutoFacConfigurerTests
    {
        [Fact]
        public void RegistersWhiteSpaceSplitter()
        {
            var containerBuilder = new ContainerBuilder();

            AutoFacConfigurer.Configure(containerBuilder);

            Assert.True(containerBuilder.Build().IsRegistered<WhiteSpaceSplitter>());
        }

        [Fact]
        public void RegistersActorLookup()
        {
            var containerBuilder = new ContainerBuilder();

            AutoFacConfigurer.Configure(containerBuilder);

            Assert.IsType<ActorLookup>(containerBuilder.Build().Resolve<IActorLookup>());
        }
    }
}
