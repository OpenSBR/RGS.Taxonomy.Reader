using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using RGS.Mapping.Model;
using Xbrl.Discovery.Entities.referencepart;

namespace Xbrl.Discovery.Entities.ea
{
    public class ExistenceAssertion : Assertion
    {
        public static new RGS.Mapping.Model.QName QName => Namespaces.ea + "existenceAssertion";

        public ExistenceAssertion(gen.Link parent, XElement xElement) : base(parent, xElement)
        {
        }
    }
}
