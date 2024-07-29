using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Legacy;
using Thought.vCards;
using Assert = NUnit.Framework.Assert;

namespace Tests
{
    [TestClass]
    public sealed class vCardDeliveryAddressTests : IDisposable
    {
        #region [ Constructor ]

        [TestMethod]
        public void Constructor()
        {
            // Tests the default values of the address constructor.

            vCardDeliveryAddress address = new vCardDeliveryAddress();

            ClassicAssert.IsEmpty(
                address.City,
                "The City property should default to String.Empty.");

            ClassicAssert.IsEmpty(
                address.Country,
                "The Country property should default to String.Empty.");

            ClassicAssert.IsEmpty(
                address.PostalCode,
                "The PostalCode property should default to String.Empty.");

            ClassicAssert.IsEmpty(
                address.Region,
                "The Region property should default to String.Empty.");

            ClassicAssert.IsEmpty(
                address.Street,
                "The Street property should default to String.Empty.");
        }

        #endregion

        #region [ EmptyString_City ]

        [TestMethod]
        public void EmptyString_City()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            ClassicAssert.IsEmpty(
                address.City,
                "The City property should default to String.Empty.");

            address.City = null;

            ClassicAssert.IsEmpty(
                address.City,
                "The City property should return String.Empty instead of null.");
        }

        #endregion

        #region [ EmptyString_Country ]

        [TestMethod]
        public void EmptyString_Country()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            ClassicAssert.IsEmpty(
                address.Country,
                "The Country property should default to String.Empty.");

            address.Country = null;

            ClassicAssert.IsEmpty(
                address.Country,
                "The Country property should return String.Empty instead of null.");
        }

        #endregion

        #region [ EmptyString_PostalCode ]

        [TestMethod]
        public void EmptyString_PostalCode()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            ClassicAssert.IsEmpty(
                address.PostalCode,
                "The PostalCode property should default to String.Empty.");

            address.PostalCode = null;

            ClassicAssert.IsEmpty(
                address.PostalCode,
                "The PostalCode property should return String.Empty instead of null.");
        }

        #endregion

        #region [ EmptyString_Region ]

        [TestMethod]
        public void EmptyString_Region()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            ClassicAssert.IsEmpty(
                address.Region,
                "The Region property should default to String.Empty.");

            address.Region = null;

            ClassicAssert.IsEmpty(
                address.Region,
                "The Region property should return String.Empty instead of null.");
        }

        #endregion

        #region [ EmptyString_Street ]

        [TestMethod]
        public void EmptyString_Street()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            ClassicAssert.IsEmpty(
                address.Street,
                "The Street property should default to String.Empty.");

            address.Street = null;

            ClassicAssert.IsEmpty(
                address.Street,
                "The Street property should return String.Empty instead of null.");
        }

        #endregion

        #region [ ReadWriteProperty_AddressType ]

        [TestMethod]
        public void ReadWriteProperty_AddressType()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.AddressType.Add(vCardDeliveryAddressTypes.Domestic);

            ClassicAssert.IsTrue(address.AddressType.Contains(vCardDeliveryAddressTypes.Domestic), "The AddressType property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_City ]

        [TestMethod]
        public void ReadWriteProperty_City()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.City = "Warroad";
            ClassicAssert.AreEqual(
                "Warroad",
                address.City,
                "The City property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Country ]

        [TestMethod]
        public void ReadWriteProperty_Country()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.Country = "Jordan";
            ClassicAssert.AreEqual(
                "Jordan",
                address.Country,
                "The Country property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_PostalCode ]

        [TestMethod]
        public void ReadWriteProperty_PostalCode()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.PostalCode = "55109";
            ClassicAssert.AreEqual(
                "55109",
                address.PostalCode,
                "The PostalCode property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Region ]

        [TestMethod]
        public void ReadWriteProperty_Region()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.Region = "North Pole";
            ClassicAssert.AreEqual(
                "North Pole",
                address.Region,
                "The Region property is not working.");
        }

        #endregion

        #region [ ReadWriteProperty_Street ]

        [TestMethod]
        public void ReadWriteProperty_Street()
        {
            vCardDeliveryAddress address = new vCardDeliveryAddress();

            address.Street = "1490 Lark Avenue";
            ClassicAssert.AreEqual(
                "1490 Lark Avenue",
                address.Street,
                "The Street property is not working.");
        }

        #endregion

        public void Dispose()
        {
            //driver.Dispose(); 
        }
    }
}