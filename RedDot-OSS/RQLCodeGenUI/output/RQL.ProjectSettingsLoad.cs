namespace RQL {
    
    
    public class ProjectSettingsLoad {
        
        public virtual ProjectSettingsLoadResponse Execute(ProjectSettingsLoadRequest request) {
            ProjectSettingsLoadResponse response;
            response = new ProjectSettingsLoadResponse();
            RQL.RQLExecuteUtil.Execute(request, response);
            return response;
        }
        
        public class ProjectSettingsLoadRequest : RQLRequestBase {
            
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
                
                private string sessionkeyField;
                
                private string loginguidField;
                
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="sessionkey")]
                public string Sessionkey {
                    get {
                        return this.sessionkeyField;
                    }
                    set {
                        this.sessionkeyField = value;
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
            public class project {
                
                private settings settingsField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="SETTINGS")]
                public settings Settings {
                    get {
                        return this.settingsField;
                    }
                    set {
                        this.settingsField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class settings {
                
                private string actionField;
                
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
            }
        }
        
        public class ProjectSettingsLoadResponse : RQLResponseBase {
            
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
                
                private settings settingsField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="SETTINGS")]
                public settings Settings {
                    get {
                        return this.settingsField;
                    }
                    set {
                        this.settingsField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class settings {
                
                private string actionField;
                
                private string languagevariantidField;
                
                private string dialoglanguageidField;
                
                private string externeditorurlField;
                
                private string excludeweekdaysField;
                
                private string requestexterneditortextField;
                
                private string activetemplateextensionsField;
                
                private string activetemplatecachingField;
                
                private string borderstyleField;
                
                private string borderwidthField;
                
                private string bordercolorField;
                
                private string contentclassversioningField;
                
                private string liveserverguidField;
                
                private string donotremoveptagField;
                
                private string onclosedotempsaveField;
                
                private string activatealllvontranslationField;
                
                private string activatealllvondeleteField;
                
                private string parser410compactibleField;
                
                private string useexterneditorField;
                
                private string donotreplacetopField;
                
                private string setnamesonlyinmainlanguageField;
                
                private string rdeditorpreferredField;
                
                private string templatereleaseField;
                
                private string enabledirecteditField;
                
                private string hidedisabledreddotsField;
                
                private string wordeditorallowedField;
                
                private string donotloadtexteditorinformField;
                
                private string showpagerangeField;
                
                private string navigationmanagerField;
                
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="excludeweekdays")]
                public string Excludeweekdays {
                    get {
                        return this.excludeweekdaysField;
                    }
                    set {
                        this.excludeweekdaysField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="activetemplateextensions")]
                public string Activetemplateextensions {
                    get {
                        return this.activetemplateextensionsField;
                    }
                    set {
                        this.activetemplateextensionsField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="activetemplatecaching")]
                public string Activetemplatecaching {
                    get {
                        return this.activetemplatecachingField;
                    }
                    set {
                        this.activetemplatecachingField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="borderstyle")]
                public string Borderstyle {
                    get {
                        return this.borderstyleField;
                    }
                    set {
                        this.borderstyleField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="borderwidth")]
                public string Borderwidth {
                    get {
                        return this.borderwidthField;
                    }
                    set {
                        this.borderwidthField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="bordercolor")]
                public string Bordercolor {
                    get {
                        return this.bordercolorField;
                    }
                    set {
                        this.bordercolorField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="donotremoveptag")]
                public string Donotremoveptag {
                    get {
                        return this.donotremoveptagField;
                    }
                    set {
                        this.donotremoveptagField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="onclosedotempsave")]
                public string Onclosedotempsave {
                    get {
                        return this.onclosedotempsaveField;
                    }
                    set {
                        this.onclosedotempsaveField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="activatealllvontranslation")]
                public string Activatealllvontranslation {
                    get {
                        return this.activatealllvontranslationField;
                    }
                    set {
                        this.activatealllvontranslationField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="activatealllvondelete")]
                public string Activatealllvondelete {
                    get {
                        return this.activatealllvondeleteField;
                    }
                    set {
                        this.activatealllvondeleteField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="parser410compactible")]
                public string Parser410compactible {
                    get {
                        return this.parser410compactibleField;
                    }
                    set {
                        this.parser410compactibleField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="donotreplacetop")]
                public string Donotreplacetop {
                    get {
                        return this.donotreplacetopField;
                    }
                    set {
                        this.donotreplacetopField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="enabledirectedit")]
                public string Enabledirectedit {
                    get {
                        return this.enabledirecteditField;
                    }
                    set {
                        this.enabledirecteditField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="hidedisabledreddots")]
                public string Hidedisabledreddots {
                    get {
                        return this.hidedisabledreddotsField;
                    }
                    set {
                        this.hidedisabledreddotsField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="showpagerange")]
                public string Showpagerange {
                    get {
                        return this.showpagerangeField;
                    }
                    set {
                        this.showpagerangeField = value;
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
            }
        }
    }
}
