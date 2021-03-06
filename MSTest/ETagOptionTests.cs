﻿using System;
using BLun.ETagMiddleware;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ETagMiddlewareTest
{
    [TestClass]
    public class ETagOptionTests
    {
        [TestMethod]
        public void Create_And_Check_Value_Ok()
        {
            // arange
            var option = new ETagOption();

            // act
            option.BodyMaxLength = 1;

            // assert
            Assert.IsNotNull(option);
            Assert.AreEqual(1, option.BodyMaxLength);
        }

        [TestMethod]
        public void Create_And_Check_Value2_Ok()
        {
            // arange
            var option = new ETagOption();

            // act
            option.BodyMaxLength = ETagMiddlewareExtensions.DefaultBodyMaxLength;

            // assert
            Assert.IsNotNull(option);
            Assert.AreEqual(ETagMiddlewareExtensions.DefaultBodyMaxLength, option.BodyMaxLength);
        }
    }
}
