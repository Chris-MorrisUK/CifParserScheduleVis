﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleVis.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prefix tt: <http://purl.org/rail/tt/> \r\nCONSTRUCT  \r\n{\r\n  ?serviceName a tt:Sched" +
            "uledService .\r\n  ?serviceName rdfs:label ?lab\r\n}\r\nWHERE\r\n{ \r\n   ?serviceName a t" +
            "t:ScheduledService .\r\n   OPTIONAL{?serviceName rdfs:label ?lab}\r\n}\r\n")]
        public string selectServices {
            get {
                return ((string)(this["selectServices"]));
            }
            set {
                this["selectServices"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.w3.org/1999/02/22-rdf-syntax-ns#type")]
        public string RDFType {
            get {
                return ((string)(this["RDFType"]));
            }
            set {
                this["RDFType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(" http://purl.org/rail/tt/ScheduledService")]
        public string ScheduledService {
            get {
                return ((string)(this["ScheduledService"]));
            }
            set {
                this["ScheduledService"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.w3.org/2000/01/rdf-schema#label")]
        public string Label {
            get {
                return ((string)(this["Label"]));
            }
            set {
                this["Label"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"CONSTRUCT 
{
   <http://purl.org/rail/resource/TTService978>  tt:serviceNode  ?serviceNode . 
  ?serviceNode rdfs:label ?lab
  
}
WHERE 
{ <http://purl.org/rail/resource/TTService978> tt:serviceNode ?serviceNode .
 	OPTIONAL{?serviceNode rdfs:label ?lab}
}")]
        public string GetServiceNodes {
            get {
                return ((string)(this["GetServiceNodes"]));
            }
            set {
                this["GetServiceNodes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://purl.org/rail/resource/")]
        public string StationGraphBase {
            get {
                return ((string)(this["StationGraphBase"]));
            }
            set {
                this["StationGraphBase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.w3.org/ns/prov#")]
        public string ProvNS {
            get {
                return ((string)(this["ProvNS"]));
            }
            set {
                this["ProvNS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prov:Activity")]
        public string ProvActivity {
            get {
                return ((string)(this["ProvActivity"]));
            }
            set {
                this["ProvActivity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prov:startedAtTime")]
        public string ProvStartedAtTime {
            get {
                return ((string)(this["ProvStartedAtTime"]));
            }
            set {
                this["ProvStartedAtTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prov:wasAttributedTo")]
        public string ProvWasAttributedTo {
            get {
                return ((string)(this["ProvWasAttributedTo"]));
            }
            set {
                this["ProvWasAttributedTo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FILE-SPEC=05 1.00")]
        public string FileSpecString {
            get {
                return ((string)(this["FileSpecString"]));
            }
            set {
                this["FileSpecString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://purl.org/rail/resource/")]
        public string ResourceBaseURI {
            get {
                return ((string)(this["ResourceBaseURI"]));
            }
            set {
                this["ResourceBaseURI"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SourceFiles")]
        public string ImportedFilesSubDir {
            get {
                return ((string)(this["ImportedFilesSubDir"]));
            }
            set {
                this["ImportedFilesSubDir"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prov:Used")]
        public string provUsed {
            get {
                return ((string)(this["provUsed"]));
            }
            set {
                this["provUsed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prov:generatedAtTime")]
        public string provGeneratedTime {
            get {
                return ((string)(this["provGeneratedTime"]));
            }
            set {
                this["provGeneratedTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://purl.org/ub/upper/")]
        public string racoonUpper {
            get {
                return ((string)(this["racoonUpper"]));
            }
            set {
                this["racoonUpper"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://purl.org/rail/is/")]
        public string racoonIS {
            get {
                return ((string)(this["racoonIS"]));
            }
            set {
                this["racoonIS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.w3.org/2000/01/rdf-schema#")]
        public string RDFS {
            get {
                return ((string)(this["RDFS"]));
            }
            set {
                this["RDFS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("u:Location")]
        public string Location {
            get {
                return ((string)(this["Location"]));
            }
            set {
                this["Location"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("is:TiplocLocation")]
        public string TiplocLocation {
            get {
                return ((string)(this["TiplocLocation"]));
            }
            set {
                this["TiplocLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en-GB")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("is:tiplocCode")]
        public string tiplocCode {
            get {
                return ((string)(this["tiplocCode"]));
            }
            set {
                this["tiplocCode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.w3.org/2003/01/geo/wgs84_pos#")]
        public string Geo {
            get {
                return ((string)(this["Geo"]));
            }
            set {
                this["Geo"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("u:id")]
        public string ID {
            get {
                return ((string)(this["ID"]));
            }
            set {
                this["ID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("wgspos:lat")]
        public string Lat {
            get {
                return ((string)(this["Lat"]));
            }
            set {
                this["Lat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("wgspos:long")]
        public string Long {
            get {
                return ((string)(this["Long"]));
            }
            set {
                this["Long"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://data.ordnancesurvey.co.uk/ontology/spatialrelations/")]
        public string SpatailRelations {
            get {
                return ((string)(this["SpatailRelations"]));
            }
            set {
                this["SpatailRelations"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("spatialrelations:easting")]
        public string Eastings {
            get {
                return ((string)(this["Eastings"]));
            }
            set {
                this["Eastings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("spatialrelations:northing")]
        public string Northings {
            get {
                return ((string)(this["Northings"]));
            }
            set {
                this["Northings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.w3.org/ns/prov#wasGeneratedBy")]
        public string provWasGeneratedBy {
            get {
                return ((string)(this["provWasGeneratedBy"]));
            }
            set {
                this["provWasGeneratedBy"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("prov:invalidatedAtTime")]
        public string provInvalidAtTime {
            get {
                return ((string)(this["provInvalidAtTime"]));
            }
            set {
                this["provInvalidAtTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:nodeOrder")]
        public string NodeOrder {
            get {
                return ((string)(this["NodeOrder"]));
            }
            set {
                this["NodeOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:platform")]
        public string Platform {
            get {
                return ((string)(this["Platform"]));
            }
            set {
                this["Platform"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:pubArrival")]
        public string PublicArrival {
            get {
                return ((string)(this["PublicArrival"]));
            }
            set {
                this["PublicArrival"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:pubDeparture")]
        public string PublicDeparture {
            get {
                return ((string)(this["PublicDeparture"]));
            }
            set {
                this["PublicDeparture"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:ttArrival")]
        public string ttArrival {
            get {
                return ((string)(this["ttArrival"]));
            }
            set {
                this["ttArrival"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:ttDeparture")]
        public string ttDeparture {
            get {
                return ((string)(this["ttDeparture"]));
            }
            set {
                this["ttDeparture"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:ttOrder")]
        public string ttOrder {
            get {
                return ((string)(this["ttOrder"]));
            }
            set {
                this["ttOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:PassingTime")]
        public string PassingTime {
            get {
                return ((string)(this["PassingTime"]));
            }
            set {
                this["PassingTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:Line")]
        public string Line {
            get {
                return ((string)(this["Line"]));
            }
            set {
                this["Line"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:Path")]
        public string Path {
            get {
                return ((string)(this["Path"]));
            }
            set {
                this["Path"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:PerformanceAllowance")]
        public string Performance {
            get {
                return ((string)(this["Performance"]));
            }
            set {
                this["Performance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:EngineeringAllowance")]
        public string Engineering {
            get {
                return ((string)(this["Engineering"]));
            }
            set {
                this["Engineering"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:PathingAllowance")]
        public string Pathing {
            get {
                return ((string)(this["Pathing"]));
            }
            set {
                this["Pathing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://purl.org/rail/tt/")]
        public string TimeTableNameSpace {
            get {
                return ((string)(this["TimeTableNameSpace"]));
            }
            set {
                this["TimeTableNameSpace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("u:location")]
        public string locationPredicate {
            get {
                return ((string)(this["locationPredicate"]));
            }
            set {
                this["locationPredicate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("tt:serviceNode")]
        public string serviceNodePredicate {
            get {
                return ((string)(this["serviceNodePredicate"]));
            }
            set {
                this["serviceNodePredicate"] = value;
            }
        }
    }
}
