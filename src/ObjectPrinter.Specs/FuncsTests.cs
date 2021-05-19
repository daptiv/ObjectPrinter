using System;
using FluentAssertions;
using NUnit.Framework;
using ObjectPrinter.TypeInspectors;

namespace ObjectPrinter.Specs
{
    [TestFixture]
	public class FuncsTests
	{
		[Test]
		public void IncludeNamespaces()
		{
			Funcs.IncludeNamespaces("System")(null, typeof(DateTime)).Should().Be(true);
			Funcs.IncludeNamespaces("System")(null, typeof(TestAttribute)).Should().Be(false);
		}
		[Test]
		public void ExcludeNamespaces()
		{
			Funcs.ExcludeNamespaces("System")(null, typeof(DateTime)).Should().Be(false);
			Funcs.ExcludeNamespaces("System")(null, typeof(TestAttribute)).Should().Be(true);
		}
        [Test]
        public void IncludeTypes()
        {
            var someObj = new TestAttribute();
            Funcs.IncludeTypes(false, typeof(object))(someObj, someObj.GetType()).Should().BeFalse();
            Funcs.IncludeTypes(true, typeof(object))(someObj, someObj.GetType()).Should().BeTrue();
        }
	}
}