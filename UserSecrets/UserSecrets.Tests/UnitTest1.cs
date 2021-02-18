using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UserSecrets.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IConfigurationBuilder config = new ConfigurationBuilder()
                .AddUserSecrets<UnitTest1>();

            IConfigurationRoot? Configuration = config.Build();
        }
    }
}
