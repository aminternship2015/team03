using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using DAL;
using Services;
using System.Web.Mvc;
using Autofac.Builder;
using Autofac.Integration.Mvc;

namespace Twitter.App_Start
{
    public static class DependencyConfig
    {
        private static IContainer Container { get; set; }

        public static void Config()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterType<UsersDal>().As<IUsersDal>();
            //builder.RegisterType<TweetsDal>().As<ITweetsDal>();
            //builder.RegisterType<FollowersDal>().As<IFollowersDal>();
            //builder.RegisterType<UsersService>().As<IUsersService>();
            //builder.RegisterType<FollowersService>().As<IFollowersService>();
            //builder.RegisterType<TweetsService>().As<ITweetsService>();
            Container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
        }
    }
}