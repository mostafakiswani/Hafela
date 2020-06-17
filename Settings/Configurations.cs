using System;
using Microsoft.Extensions.Configuration;

namespace Settings
{
    public static class Configurations
    {
        public static IConfiguration Configuration { get; set; }

        public static string ConnectionString { get { return Configuration.GetSection("ConnectionString").Value; } }
        public static string RegionKey { get { return Configuration.GetSection("RegionKey").Value; } }
        public static string FirebaseApiKey { get { return Configuration.GetSection("FirebaseApiKey").Value; } }
        public static string FirebaseUser { get { return Configuration.GetSection("FirebaseUser").Value; } }
        public static string AppName { get { return Configuration.GetSection("AppName").Value; } }
        public static string JwtKey { get { return Configuration.GetSection("JwtKey").Value; } }


        public static void Init(IConfiguration config)
        {
            Configuration = config;
        }
    }
}
