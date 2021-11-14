﻿using System.Xml.Linq;

namespace Xbrl.Discovery.Entities.xbrldt
{
    public class DimensionDomainArc : link.DefinitionArc<DimensionLoc, ItemLoc>
    {
        public string ContextElement => Attribute(Namespaces.xbrldt + "contextElement")?.Value;
        public string TypedDomainRef => Attribute(Namespaces.xbrldt + "typedDomainRef")?.Value;
        public bool Closed => Attribute(Namespaces.xbrldt + "closed") == default ? false : Attribute(Namespaces.xbrldt + "closed").Value == "true";
        public bool Usable => Attribute(Namespaces.xbrldt + "usable") == default ? true : Attribute(Namespaces.xbrldt + "usable").Value == "true";
        public string TargetRole => Attribute(Namespaces.xbrldt + "targetRole")?.Value;

        public DimensionDomainArc(link.DefinitionLink parent, XElement xElement) : base(parent, xElement)
        { }
    }
}
