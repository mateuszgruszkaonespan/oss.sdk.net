﻿using System;
using NUnit.Framework;
using Silanis.ESL.SDK;

namespace SDK.Examples
{
    [TestFixture()]
    public class PackageLanguageConfigurationExampleTest
    {
        [Test()]
        public void VerifyResult()
        {
            PackageLanguageConfigurationExample example = new PackageLanguageConfigurationExample(Props.GetInstance());
            example.Run();

            DocumentPackage retrievedPackage = example.EslClient.GetPackage(example.PackageId);

            Assert.AreEqual(retrievedPackage.Language.Name, "fr");
        }
    }
}

