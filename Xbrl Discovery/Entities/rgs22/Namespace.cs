namespace Xbrl.Discovery.rgs22
{
    public class Namespace
	{
		/*<?xml version="1.0" encoding="utf-8"?>
		<xs:schema
		 xmlns:xs="http://www.w3.org/2001/XMLSchema"
		 xmlns:rgs="http://www.nltaxonomie.nl/rgs/2022/xbrl/rgs-syntax-extension"
		 xmlns:gen="http://xbrl.org/2008/generic"
		 xmlns:xl="http://www.xbrl.org/2003/XLink"
		 xmlns:xlink="http://www.w3.org/1999/xlink"
		 xmlns:link="http://www.xbrl.org/2003/linkbase"
		 targetNamespace="http://www.nltaxonomie.nl/rgs/2022/xbrl/rgs-syntax-extension"
		 elementFormDefault="qualified"
		 attributeFormDefault="unqualified"
		 version="20220610">
			<xs:import namespace="http://www.xbrl.org/2003/XLink" schemaLocation="http://www.xbrl.org/2003/xl-2003-12-31.xsd"/>
			<xs:import namespace="http://www.xbrl.org/2003/linkbase" schemaLocation="http://www.xbrl.org/2003/xbrl-linkbase-2003-12-31.xsd"/>
			<xs:import namespace="http://xbrl.org/2008/generic" schemaLocation="http://www.xbrl.org/2008/generic-link.xsd"/>
			<xs:element name="Filters" type="xs:NMTOKENS" substitutionGroup="link:part" id="ref_Filters">
			  <xs:annotation>
				<xs:documentation xml:lang="en">A list of filters for RGS codes, defined in a reference resource</xs:documentation>
			  </xs:annotation>
			</xs:element>
			<xs:element name="datapoint" substitutionGroup="xl:resource">
				<xs:annotation>
					<xs:documentation>Resource element that can contain a datapoint mapped in one of the arcs, including all of its required aspects, starting with the primary element.</xs:documentation>
				</xs:annotation>
				<xs:complexType mixed="true">
					<xs:complexContent>
						<xs:extension base="xl:resourceType">
							<xs:sequence>
								<xs:element name="primary" type="rgs:primaryType" minOccurs="1" maxOccurs="1">
									<xs:annotation>
										<xs:documentation>Primary element using QName, path (for nesting), decimals (for datapoints in millions etc.), language, balance (for restricting to positive/negative amounts). Contains any required aspect.</xs:documentation>
									</xs:annotation>
								</xs:element>
							</xs:sequence>
						</xs:extension>
					</xs:complexContent>
				</xs:complexType>
			</xs:element>
			<xs:complexType name="primaryType">
				<xs:annotation>
					<xs:documentation>Primary element using QName, path (for nesting), decimals (for datapoints in millions etc.), language, balance (for restricting to positive/negative amounts). Contains any required aspect.</xs:documentation>
				</xs:annotation>
				<xs:sequence>
					<xs:element name="explicitDimension" minOccurs="0" maxOccurs="unbounded">
						<xs:annotation>
							<xs:documentation>Explicit dimension element using QName and optionally a member.</xs:documentation>
						</xs:annotation>
						<xs:complexType>
							<xs:attribute ref="rgs:qname" use="required"/>
							<xs:attribute name="member" type="xs:QName" use="optional">
								<xs:annotation>
									<xs:documentation>Optional member attribuut: only when there is only one allowed its listed. Sets of allowed members must be discovered.</xs:documentation>
								</xs:annotation>
							</xs:attribute>
						</xs:complexType>
					</xs:element>
					<xs:element name="typedDimension" minOccurs="0" maxOccurs="unbounded">
						<xs:annotation>
							<xs:documentation>Typed dimension element using QName.</xs:documentation>
						</xs:annotation>
						<xs:complexType>
							<xs:annotation>
								<xs:documentation>No typed element: must be discovered</xs:documentation>
							</xs:annotation>
							<xs:attribute ref="rgs:qname" use="required"/>
						</xs:complexType>
					</xs:element>
					<xs:element name="source" minOccurs="0" type="xs:string" />
				</xs:sequence>
				<xs:attribute ref="rgs:qname" use="required"/>
			</xs:complexType>
			<xs:attribute name="qname" type="xs:QName"/>
			<xs:attribute name="transposeId" type="xs:QName"/>
		</xs:schema>*/
		public const string Name = @"http://www.nltaxonomie.nl/rgs/2022/xbrl/rgs-syntax-extension";
        public const string Prefix = "rgs22";
    }
}
