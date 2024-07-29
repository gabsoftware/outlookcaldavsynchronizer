using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Legacy;
using Thought.vCards;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestClass]
    public sealed class vCardSourceTests : IDisposable
    {
        #region [ Constructor ]

        [TestMethod]
        public void Constructor()
        {
            // Tests the default values of the vCardSource
            // class when the parameterless constructor is used.

            vCardSource source = new vCardSource();

            ClassicAssert.IsEmpty(
                source.Context,
                "The Context property should default to empty.");

            ClassicAssert.IsNull(
                source.Uri,
                "The Uri property should default to null.");
        }

        #endregion

        #region [ ReadWriteProperty_Context ]

        [TestMethod]
        public void ReadWriteProperty_Context()
        {
            vCardSource source = new vCardSource();

            source.Context = "LDAP";
            ClassicAssert.AreEqual(
                "LDAP",
                source.Context,
                "The Context property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Uri ]

        [TestMethod]
        public void ReadWriteProperty_Uri()
        {
            Uri testUri = new Uri("isdn:123456789");
            vCardSource source = new vCardSource();

            source.Uri = testUri;
            ClassicAssert.AreEqual(
                testUri,
                source.Uri);
        }

        #endregion

        public void Dispose()
        {
            // driver.Dispose();
        }
    }
}