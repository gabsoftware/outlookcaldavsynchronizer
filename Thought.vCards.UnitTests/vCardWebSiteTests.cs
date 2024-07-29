using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Legacy;
using Thought.vCards;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestClass]
    public sealed class vCardWebSiteTests : IDisposable
    {
        private const string TestUrl = "http://www.thoughtproject.com";

        #region [ Constructor ]

        [TestMethod]
        public void Constructor()
        {
            // Tests for default values when a web site
            // object is created without parameters.

            vCardWebsite site = new vCardWebsite();

            ClassicAssert.AreEqual(
                site.WebsiteType,
                vCardWebsiteTypes.Default,
                "The site type should be the default.");

            ClassicAssert.IsEmpty(
                site.Url,
                "The Url should be String.Empty because it was not initialized.");
        }

        #endregion

        #region [ Constructor_Url ]

        [TestMethod]
        public void Constructor_Url()
        {
            // Tests for values when a web site is created
            // with a URL.

            vCardWebsite site = new vCardWebsite(TestUrl);

            ClassicAssert.AreEqual(
                TestUrl,
                site.Url,
                "The URL was not assigned properly by the constructor.");

            ClassicAssert.AreEqual(
                vCardWebsiteTypes.Default,
                site.WebsiteType,
                "The site type should be default because it was not specified.");
        }

        #endregion

        #region [ Constructor_NullUrl ]

        [TestMethod]
        public void Constructor_NullUrl()
        {
            vCardWebsite site = new vCardWebsite((string) null);

            ClassicAssert.IsEmpty(
                site.Url,
                "The Url should be String.Empty even when initialized to null.");
        }

        #endregion

        #region [ Constructor_Url_WebSiteType ]

        [TestMethod]
        public void Constructor_Url_WebSiteType()
        {
            vCardWebsite site = new vCardWebsite(
                TestUrl, vCardWebsiteTypes.Personal);

            ClassicAssert.AreEqual(
                TestUrl,
                site.Url,
                "The URL was not assigned properly by the constructor.");

            ClassicAssert.AreEqual(
                vCardWebsiteTypes.Personal,
                site.WebsiteType,
                "The site type should have been set.");
        }

        #endregion

        #region [ ReadWriteProperty_IsPersonalSite ]

        [TestMethod]
        public void ReadWriteProperty_IsPersonalSite()
        {
            vCardWebsite site = new vCardWebsite();

            site.IsPersonalSite = true;
            ClassicAssert.IsTrue(
                site.IsPersonalSite,
                "The IsPersonSite property should be true.");

            site.IsPersonalSite = false;
            ClassicAssert.IsFalse(
                site.IsPersonalSite,
                "The IsPersonSite property should be false.");
        }

        #endregion

        #region [ ReadWriteProperty_IsWorkSite ]

        [TestMethod]
        public void ReadWriteProperty_IsWorkSite()
        {
            vCardWebsite site = new vCardWebsite();

            site.IsWorkSite = true;
            ClassicAssert.IsTrue(
                site.IsWorkSite,
                "The IsWorkSite property should be true.");

            site.IsWorkSite = false;
            ClassicAssert.IsFalse(
                site.IsWorkSite,
                "The IsWorkSite property should be false.");
        }

        #endregion

        #region [ ReadWriteProperty_WebSiteType ]

        [TestMethod]
        public void ReadWriteProperty_WebSiteType()
        {
            vCardWebsite site = new vCardWebsite();

            site.WebsiteType = vCardWebsiteTypes.Personal;

            ClassicAssert.AreEqual(
                vCardWebsiteTypes.Personal,
                site.WebsiteType,
                "The web site type should be set to Personal.");

            ClassicAssert.IsTrue(
                site.IsPersonalSite,
                "The IsPersonalSite property should be true.");

            ClassicAssert.IsFalse(
                site.IsWorkSite,
                "The IsWorkSite property should be false.");

            site.WebsiteType = vCardWebsiteTypes.Work;

            ClassicAssert.AreEqual(
                vCardWebsiteTypes.Work,
                site.WebsiteType,
                "The web site type should be set to Work.");

            ClassicAssert.IsFalse(
                site.IsPersonalSite,
                "The IsPersonalSite property should be false.");

            ClassicAssert.IsTrue(
                site.IsWorkSite,
                "The IsWorkSite property should be true.");

            // Now set both types.

            site.WebsiteType = vCardWebsiteTypes.Personal | vCardWebsiteTypes.Work;

            ClassicAssert.IsTrue(
                site.IsPersonalSite,
                "The IsPersonalSite property should also be true.");

            ClassicAssert.IsTrue(
                site.IsWorkSite,
                "The IsWorkSite property should also be true.");

            ClassicAssert.AreEqual(
                vCardWebsiteTypes.Personal | vCardWebsiteTypes.Work,
                site.WebsiteType,
                "The WebSiteType property is not working for multiple values.");
        }

        #endregion

        #region [ ReadWriteProperty_Url ]

        [TestMethod]
        public void ReadWriteProperty_Url()
        {
            vCardWebsite site = new vCardWebsite();

            site.Url = TestUrl;
            ClassicAssert.AreEqual(
                TestUrl,
                site.Url,
                "The Url property is not working.");
        }

        #endregion

        public void Dispose()
        {
            //driver.Dispose(); 
        }
    }
}