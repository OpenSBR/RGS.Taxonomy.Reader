namespace Xbrl.Discovery.rgs
{
    public class Namespace
	{
		/*<xs:schema xmlns:xs="http://www.w3.org/2001/XMLSchema" xmlns:rgs="http://www.nltaxonomie.nl/rgs/2015/xbrl/rgs-syntax-extension" xmlns:gen="http://xbrl.org/2008/generic" xmlns:xl="http://www.xbrl.org/2003/XLink" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:link="http://www.xbrl.org/2003/linkbase" targetNamespace="http://www.nltaxonomie.nl/rgs/2015/xbrl/rgs-syntax-extension" elementFormDefault="qualified" attributeFormDefault="unqualified" version="20151002">
			<xs:import namespace="http://www.xbrl.org/2003/XLink" schemaLocation="http://www.xbrl.org/2003/xl-2003-12-31.xsd"/>
			<xs:import namespace="http://www.xbrl.org/2003/linkbase" schemaLocation="http://www.xbrl.org/2003/xbrl-linkbase-2003-12-31.xsd"/>
			<xs:import namespace="http://xbrl.org/2008/generic" schemaLocation="http://www.xbrl.org/2008/generic-link.xsd"/>
			<xs:element name = "one2manyArc" substitutionGroup="gen:arc" id="rgs_one2manyarc">
				<xs:annotation>
					<xs:documentation>Arc element that supports processing one DTS-A(RGS) concept being mapped to many DTS-B(NT/BT) concepts.</xs:documentation>
				</xs:annotation>
				<xs:complexType>
					<xs:complexContent>
						<xs:extension base="gen:genericArcType" />
					</xs:complexContent>
				</xs:complexType>
			</xs:element>
			<xs:element name = "many2oneArc" substitutionGroup="gen:arc" id="rgs_many2onearc">
				<xs:annotation>
					<xs:documentation>Arc element that supports processing many DTS-A(RGS) concepts being mapped to one DTS-B(NT/BT) concept supporting a 'balanceOverturn' attribute to indicate if both debit and credit concepts are targeted.</xs:documentation>
				</xs:annotation>
				<xs:complexType>
					<xs:complexContent>
						<xs:extension base="gen:genericArcType" />
					</xs:complexContent>
				</xs:complexType>
			</xs:element>
			<xs:element name = "one2oneArc" substitutionGroup="gen:arc" id="rgs_one2onearc">
				<xs:annotation>
					<xs:documentation>Arc element that supports processing one DTS-A(RGS) concept being mapped to one DTS-B(NT/BT) concept</xs:documentation>
				</xs:annotation>
				<xs:complexType>
					<xs:complexContent>
						<xs:extension base="gen:genericArcType" />
					</xs:complexContent>
				</xs:complexType>
			</xs:element>
			<xs:element name = "datapoint" substitutionGroup="xl:resource">
				<xs:annotation>
					<xs:documentation>Resource element that can contain a datapoint mapped in one of the arcs, including all of its required aspects, starting with the entrypoint to the DTS it's in.</xs:documentation>
				</xs:annotation>
				<xs:complexType mixed = "true" >
					< xs:complexContent>
						<xs:extension base="xl:resourceType">
							<xs:sequence>
								<xs:element name = "entrypoint" type="rgs:entrypointType" minOccurs="1" maxOccurs="1">
									<xs:annotation>
										<xs:documentation>Entrypoint element defining the datapoint.</xs:documentation>
									</xs:annotation>
								</xs:element>
							</xs:sequence>
						</xs:extension>
					</xs:complexContent>
				</xs:complexType>
			</xs:element>
			<xs:complexType name = "entrypointType" >
				< xs:annotation>
					<xs:documentation>Type of the entrypoint element within a datapoint.Identifies the entrypoint and any required aspects to define the datapoint.</xs:documentation>
				</xs:annotation>
				<xs:sequence>
					<xs:element name = "primary" minOccurs= "1" maxOccurs= "1" >
						< xs:annotation>
							<xs:documentation>Primary element using QName, path(for nesting), decimals(for datapoints in millions etc.), language, balance(for restricting to positive/negative amounts). Contains any required aspect.</xs:documentation>
						</xs:annotation>
						<xs:complexType>
							<xs:sequence>
								<xs:element name = "explicitDimension" minOccurs= "0" maxOccurs= "unbounded" >
								 < xs:annotation>
										<xs:documentation>Explicit dimension element using QName and optionally a member, in either segment or scenario container.</xs:documentation>
									</xs:annotation>
									<xs:complexType>
										<xs:attribute ref="rgs:qname" use="required"/>
										<xs:attribute name = "member" type="xs:QName" use="optional">
											<xs:annotation>
												<xs:documentation>Optional member attribuut: only when there is only one allowed its listed.Sets of allowed members must be discovered.</xs:documentation>
											</xs:annotation>
										</xs:attribute>
										<xs:attribute ref="rgs:container" use="required"/>
									</xs:complexType>
								</xs:element>
								<xs:element name = "typedDimension" minOccurs="0" maxOccurs="unbounded">
									<xs:annotation>
										<xs:documentation>Typed dimension element using QName, in either segment or scenario container.</xs:documentation>
									</xs:annotation>
									<xs:complexType>
										<xs:annotation>
											<xs:documentation>No typed element: must be discovered</xs:documentation>
										</xs:annotation>
										<xs:attribute ref="rgs:qname" use="required"/>
										<xs:attribute ref="rgs:container" use="required"/>
									</xs:complexType>
								</xs:element>
							</xs:sequence>
							<xs:attribute ref="rgs:qname" use="required"/>
						</xs:complexType>
					</xs:element>
				</xs:sequence>
				<xs:attribute name = "URI" use="required">
					<xs:simpleType>
						<xs:restriction base="xs:anyURI">
							<xs:minLength value = "1" />
						</ xs:restriction>
					</xs:simpleType>
				</xs:attribute>
			</xs:complexType>
			<xs:attribute name = "container" type="rgs:containerType"/>
			<xs:attribute name = "qname" type="xs:QName"/>
			<xs:attribute name = "transposeId" type="xs:QName"/>
			<xs:simpleType name = "containerType" >
				< xs:restriction base="xs:string">
					<xs:enumeration value = "segment" />
					< xs:enumeration value = "scenario" />
				 </ xs:restriction>
			</xs:simpleType>
		</xs:schema>*/
        public const string Name = @"http://www.nltaxonomie.nl/rgs/2015/xbrl/rgs-syntax-extension";
        public const string Prefix = "rgs";
    }
}
