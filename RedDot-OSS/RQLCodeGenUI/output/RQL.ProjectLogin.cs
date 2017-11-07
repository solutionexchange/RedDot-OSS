namespace RQL {
    
    
    public class ProjectLogin {
        
        public virtual ProjectLoginResponse Execute(ProjectLoginRequest request) {
            ProjectLoginResponse response;
            response = new ProjectLoginResponse();
            RQL.RQLExecuteUtil.Execute(request, response);
            return response;
        }
        
        public class ProjectLoginRequest : RQLRequestBase {
            
            private iodata data;
            
            public virtual iodata Data {
                get {
                    return this.data;
                }
                set {
                    this.data = value;
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false, ElementName="IODATA")]
            public class iodata {
                
                private administration administrationField;
                
                private string loginguidField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="ADMINISTRATION")]
                public administration Administration {
                    get {
                        return this.administrationField;
                    }
                    set {
                        this.administrationField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="loginguid")]
                public string Loginguid {
                    get {
                        return this.loginguidField;
                    }
                    set {
                        this.loginguidField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class administration {
                
                private project projectField;
                
                private string actionField;
                
                private string guidField;
                
                private string useragentField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="PROJECT")]
                public project Project {
                    get {
                        return this.projectField;
                    }
                    set {
                        this.projectField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="action")]
                public string Action {
                    get {
                        return this.actionField;
                    }
                    set {
                        this.actionField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="guid")]
                public string Guid {
                    get {
                        return this.guidField;
                    }
                    set {
                        this.guidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="useragent")]
                public string Useragent {
                    get {
                        return this.useragentField;
                    }
                    set {
                        this.useragentField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class project {
                
                private string guidField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="guid")]
                public string Guid {
                    get {
                        return this.guidField;
                    }
                    set {
                        this.guidField = value;
                    }
                }
            }
        }
        
        public class ProjectLoginResponse : RQLResponseBase {
            
            private iodata data;
            
            public virtual iodata Data {
                get {
                    return this.data;
                }
                set {
                    this.data = value;
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false, ElementName="IODATA")]
            public class iodata {
                
                private project projectField;
                
                private user userField;
                
                private server serverField;
                
                private license licenseField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="PROJECT")]
                public project Project {
                    get {
                        return this.projectField;
                    }
                    set {
                        this.projectField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="USER")]
                public user User {
                    get {
                        return this.userField;
                    }
                    set {
                        this.userField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="SERVER")]
                public server Server {
                    get {
                        return this.serverField;
                    }
                    set {
                        this.serverField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="LICENSE")]
                public license License {
                    get {
                        return this.licenseField;
                    }
                    set {
                        this.licenseField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class project {
                
                private string guidField;
                
                private string nameField;
                
                private string reddotstartpageguidField;
                
                private string flagsField;
                
                private string versioningField;
                
                private string archiveField;
                
                private string testprojectField;
                
                private string useexterneditorField;
                
                private string externeditorurlField;
                
                private string requestexterneditortextField;
                
                private string setnamesonlyinmainlanguageField;
                
                private string rdeditorpreferredField;
                
                private string templatereleaseField;
                
                private string contentclassversioningField;
                
                private string wordeditorallowedField;
                
                private string liveserverguidField;
                
                private string donotloadtexteditorinformField;
                
                private string navigationmanagerField;
                
                private string mainlanguagevariantidField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="guid")]
                public string Guid {
                    get {
                        return this.guidField;
                    }
                    set {
                        this.guidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="name")]
                public string Name {
                    get {
                        return this.nameField;
                    }
                    set {
                        this.nameField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="reddotstartpageguid")]
                public string Reddotstartpageguid {
                    get {
                        return this.reddotstartpageguidField;
                    }
                    set {
                        this.reddotstartpageguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="flags")]
                public string Flags {
                    get {
                        return this.flagsField;
                    }
                    set {
                        this.flagsField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="versioning")]
                public string Versioning {
                    get {
                        return this.versioningField;
                    }
                    set {
                        this.versioningField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="archive")]
                public string Archive {
                    get {
                        return this.archiveField;
                    }
                    set {
                        this.archiveField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="testproject")]
                public string Testproject {
                    get {
                        return this.testprojectField;
                    }
                    set {
                        this.testprojectField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="useexterneditor")]
                public string Useexterneditor {
                    get {
                        return this.useexterneditorField;
                    }
                    set {
                        this.useexterneditorField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="externeditorurl")]
                public string Externeditorurl {
                    get {
                        return this.externeditorurlField;
                    }
                    set {
                        this.externeditorurlField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="requestexterneditortext")]
                public string Requestexterneditortext {
                    get {
                        return this.requestexterneditortextField;
                    }
                    set {
                        this.requestexterneditortextField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="setnamesonlyinmainlanguage")]
                public string Setnamesonlyinmainlanguage {
                    get {
                        return this.setnamesonlyinmainlanguageField;
                    }
                    set {
                        this.setnamesonlyinmainlanguageField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="rdeditorpreferred")]
                public string Rdeditorpreferred {
                    get {
                        return this.rdeditorpreferredField;
                    }
                    set {
                        this.rdeditorpreferredField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="templaterelease")]
                public string Templaterelease {
                    get {
                        return this.templatereleaseField;
                    }
                    set {
                        this.templatereleaseField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="contentclassversioning")]
                public string Contentclassversioning {
                    get {
                        return this.contentclassversioningField;
                    }
                    set {
                        this.contentclassversioningField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="wordeditorallowed")]
                public string Wordeditorallowed {
                    get {
                        return this.wordeditorallowedField;
                    }
                    set {
                        this.wordeditorallowedField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="liveserverguid")]
                public string Liveserverguid {
                    get {
                        return this.liveserverguidField;
                    }
                    set {
                        this.liveserverguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="donotloadtexteditorinform")]
                public string Donotloadtexteditorinform {
                    get {
                        return this.donotloadtexteditorinformField;
                    }
                    set {
                        this.donotloadtexteditorinformField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="navigationmanager")]
                public string Navigationmanager {
                    get {
                        return this.navigationmanagerField;
                    }
                    set {
                        this.navigationmanagerField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="mainlanguagevariantid")]
                public string Mainlanguagevariantid {
                    get {
                        return this.mainlanguagevariantidField;
                    }
                    set {
                        this.mainlanguagevariantidField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class license {
                
                private string userguidField;
                
                private string projectguidField;
                
                private string teField;
                
                private string lmField;
                
                private string levelField;
                
                private string idField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="userguid")]
                public string Userguid {
                    get {
                        return this.userguidField;
                    }
                    set {
                        this.userguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="projectguid")]
                public string Projectguid {
                    get {
                        return this.projectguidField;
                    }
                    set {
                        this.projectguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="te")]
                public string Te {
                    get {
                        return this.teField;
                    }
                    set {
                        this.teField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="lm")]
                public string Lm {
                    get {
                        return this.lmField;
                    }
                    set {
                        this.lmField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="level")]
                public string Level {
                    get {
                        return this.levelField;
                    }
                    set {
                        this.levelField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="id")]
                public string Id {
                    get {
                        return this.idField;
                    }
                    set {
                        this.idField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class server {
                
                private string guidField;
                
                private string nameField;
                
                private string keyField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="guid")]
                public string Guid {
                    get {
                        return this.guidField;
                    }
                    set {
                        this.guidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="name")]
                public string Name {
                    get {
                        return this.nameField;
                    }
                    set {
                        this.nameField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="key")]
                public string Key {
                    get {
                        return this.keyField;
                    }
                    set {
                        this.keyField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class user {
                
                private string guidField;
                
                private string useridField;
                
                private string maxlevelField;
                
                private string isservermanagerField;
                
                private string dialoglanguageidField;
                
                private string projectguidField;
                
                private string levelField;
                
                private string teField;
                
                private string lmField;
                
                private string mainlanguagevariantidField;
                
                private string languagevariantidField;
                
                private string countryField;
                
                private string languageField;
                
                private string languagekeyField;
                
                private string lcidField;
                
                private string dialoglcidField;
                
                private string languagevariantlcidField;
                
                private string mainlanguagevariantguidField;
                
                private string languagevariantguidField;
                
                private string rights1Field;
                
                private string rights2Field;
                
                private string rights3Field;
                
                private string rights4Field;
                
                private string flags1Field;
                
                private string flags2Field;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="guid")]
                public string Guid {
                    get {
                        return this.guidField;
                    }
                    set {
                        this.guidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="userid")]
                public string Userid {
                    get {
                        return this.useridField;
                    }
                    set {
                        this.useridField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="maxlevel")]
                public string Maxlevel {
                    get {
                        return this.maxlevelField;
                    }
                    set {
                        this.maxlevelField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="isservermanager")]
                public string Isservermanager {
                    get {
                        return this.isservermanagerField;
                    }
                    set {
                        this.isservermanagerField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="dialoglanguageid")]
                public string Dialoglanguageid {
                    get {
                        return this.dialoglanguageidField;
                    }
                    set {
                        this.dialoglanguageidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="projectguid")]
                public string Projectguid {
                    get {
                        return this.projectguidField;
                    }
                    set {
                        this.projectguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="level")]
                public string Level {
                    get {
                        return this.levelField;
                    }
                    set {
                        this.levelField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="te")]
                public string Te {
                    get {
                        return this.teField;
                    }
                    set {
                        this.teField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="lm")]
                public string Lm {
                    get {
                        return this.lmField;
                    }
                    set {
                        this.lmField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="mainlanguagevariantid")]
                public string Mainlanguagevariantid {
                    get {
                        return this.mainlanguagevariantidField;
                    }
                    set {
                        this.mainlanguagevariantidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="languagevariantid")]
                public string Languagevariantid {
                    get {
                        return this.languagevariantidField;
                    }
                    set {
                        this.languagevariantidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="country")]
                public string Country {
                    get {
                        return this.countryField;
                    }
                    set {
                        this.countryField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="language")]
                public string Language {
                    get {
                        return this.languageField;
                    }
                    set {
                        this.languageField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="languagekey")]
                public string Languagekey {
                    get {
                        return this.languagekeyField;
                    }
                    set {
                        this.languagekeyField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="lcid")]
                public string Lcid {
                    get {
                        return this.lcidField;
                    }
                    set {
                        this.lcidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="dialoglcid")]
                public string Dialoglcid {
                    get {
                        return this.dialoglcidField;
                    }
                    set {
                        this.dialoglcidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="languagevariantlcid")]
                public string Languagevariantlcid {
                    get {
                        return this.languagevariantlcidField;
                    }
                    set {
                        this.languagevariantlcidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="mainlanguagevariantguid")]
                public string Mainlanguagevariantguid {
                    get {
                        return this.mainlanguagevariantguidField;
                    }
                    set {
                        this.mainlanguagevariantguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="languagevariantguid")]
                public string Languagevariantguid {
                    get {
                        return this.languagevariantguidField;
                    }
                    set {
                        this.languagevariantguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="rights1")]
                public string Rights1 {
                    get {
                        return this.rights1Field;
                    }
                    set {
                        this.rights1Field = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="rights2")]
                public string Rights2 {
                    get {
                        return this.rights2Field;
                    }
                    set {
                        this.rights2Field = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="rights3")]
                public string Rights3 {
                    get {
                        return this.rights3Field;
                    }
                    set {
                        this.rights3Field = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="rights4")]
                public string Rights4 {
                    get {
                        return this.rights4Field;
                    }
                    set {
                        this.rights4Field = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="flags1")]
                public string Flags1 {
                    get {
                        return this.flags1Field;
                    }
                    set {
                        this.flags1Field = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="flags2")]
                public string Flags2 {
                    get {
                        return this.flags2Field;
                    }
                    set {
                        this.flags2Field = value;
                    }
                }
            }
        }
    }
}
