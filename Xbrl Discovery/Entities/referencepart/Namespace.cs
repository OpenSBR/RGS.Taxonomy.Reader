namespace Xbrl.Discovery.Entities.referencepart
{
    public class Namespace
    {
        /*<schema
         xmlns:link="http://www.xbrl.org/2003/linkbase" 
         xmlns:referencepart="http://www.xbrl.org/2003/ref" 
         xmlns="http://www.w3.org/2001/XMLSchema" targetNamespace="http://www.xbrl.org/2003/ref" elementFormDefault="qualified">
       <import namespace="http://www.xbrl.org/2003/linkbase" schemaLocation="xbrl-linkbase.xsd"/>
       <element name = "name" type="string" substitutionGroup="link:part"/>
       <element name = "number" type="string" substitutionGroup="link:part"/>
       <element name = "paragraph" type="string" substitutionGroup="link:part"/>
       <element name = "subparagraph" type="string" substitutionGroup="link:part"/>
       <element name = "clause" type="string" substitutionGroup="link:part"/>
       <element name = "pages" type="string" substitutionGroup="link:part"/>
       </schema>*/
        public const string Name = @"http://www.xbrl.org/2006/ref";
        public const string Prefix = "referencepart";
    }
}
