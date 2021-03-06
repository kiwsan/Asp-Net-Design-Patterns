﻿using System;
using NUnit.Framework;

namespace Agathas.Storefront.Model.Tests.Address_Specs
{
    [TestFixture]
    public class When_creating_a_new_address_with_a_blank_city
    {
        [Test]
        [ExpectedException(typeof(InvalidAddressException))]
        public void Then_an_InvalidAddressException_will_be_thrown()
        {
            var invalidAddress = new Address("99 Old street", String.Empty, string.Empty, "State", "Country", "PostCode");

            Assert.Fail();
        }
    }
}