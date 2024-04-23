using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.va
{
    public class ValueAssertion : Assertion
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.va + "valueAssertion";

        public ValueAssertion(gen.Link parent, XElement xElement) : base(parent, xElement)
        {
        }
    }
}
