using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Legacy;
using Thought.vCards;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestClass]
    public sealed class vCardCertificateTests : IDisposable
    {
        [TestMethod]
        public void EmptyString_KeyType()
        {
            vCardCertificate cert = new vCardCertificate();

            ClassicAssert.IsEmpty(
                cert.KeyType,
                "The string KeyType property should default to String.Empty.");

            cert.KeyType = null;

            ClassicAssert.IsEmpty(
                cert.KeyType,
                "The string KeyType should be String.Empty when assigned null.");
        }

        public void Dispose()
        {
            //driver.Dispose(); 
        }
    }
}