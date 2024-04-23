using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities
{
    public abstract class Assertion : xl.Resource
    {
        public string AspectModel => Attribute("aspectModel")?.Value;

        public string ImplicitFiltering => Attribute("implicitFiltering")?.Value;

        public string Test => Attribute("test")?.Value;

        public Assertion(gen.Link parent, XElement xElement) : base(parent, xElement)
        {
        }
    }
}
