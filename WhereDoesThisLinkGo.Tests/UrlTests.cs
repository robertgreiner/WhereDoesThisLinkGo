using System;
using NUnit.Framework;
using Ninject;
using WhereDoesThisLinkGo.Services;

namespace WhereDoesThisLinkGo.Tests
{
    [TestFixture]
    public class UrlTests
    {
        private IUrlService service;

        [SetUp]
        public void SetUp()
        {
            service = new UrlService();
        }

        [Test]
        public void ShouldExpandShortenedUrl()
        {
            var uri = service.Expand("http://goo.gl/s4i0").AbsoluteUri;
            Assert.AreEqual("http://robertgreiner.com/", uri);
        }

        [Test]
        public void ShouldReturnSameUrlWhenNotShortened()
        {
            var uri = service.Expand("http://robertgreiner.com").AbsoluteUri;
            Assert.AreEqual("http://robertgreiner.com/", uri);
        }

        [Test]
        public void InvalidUrl()
        {
            var uri = service.Expand("http://qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq.com/1234");
            Assert.AreEqual(null, uri);
        }

        [Test]
        public void ShouldProcessShortenedUrlWithoutHttpPrefix()
        {
            var uri = service.Expand("goo.gl/s4i0").AbsoluteUri;
            Assert.AreEqual("http://robertgreiner.com/", uri);
        }
    }
}
