using System;
using Xunit;
using Xunit.Sdk;
using AutoFixture.Xunit2;

namespace Bit.Core.Test.AutoFixture.Attributes
{
    internal class InlineCustomAutoDataAttribute : CompositeDataAttribute
    {
        public InlineCustomAutoDataAttribute(Type[] iCustomizationTypes, params object[] values) : base(new DataAttribute[] {
            new InlineDataAttribute(values),
            new CustomAutoDataAttribute(iCustomizationTypes)
        })
        { }
    }
}
