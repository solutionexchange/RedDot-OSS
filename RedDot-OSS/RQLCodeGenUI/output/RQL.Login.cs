namespace RQL {
    
    
    public class Login {
        
        public virtual LoginResponse Execute(LoginRequest request) {
            LoginResponse response;
            response = new LoginResponse();
            RQL.RQLExecuteUtil.Execute(request, response);
            return response;
        }
        
        public class LoginRequest : RQLRequestBase {
            
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
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class administration {
                
                private string actionField;
                
                private string nameField;
                
                private string passwordField;
                
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="password")]
                public string Password {
                    get {
                        return this.passwordField;
                    }
                    set {
                        this.passwordField = value;
                    }
                }
            }
        }
        
        public class LoginResponse : RQLResponseBase {
            
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
                
                private login loginField;
                
                private user userField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="LOGIN")]
                public login Login {
                    get {
                        return this.loginField;
                    }
                    set {
                        this.loginField = value;
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
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class login {
                
                private string guidField;
                
                private string serverField;
                
                private string serverguidField;
                
                private string userkeyField;
                
                private string usertokenField;
                
                private string nameField;
                
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="server")]
                public string Server {
                    get {
                        return this.serverField;
                    }
                    set {
                        this.serverField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="serverguid")]
                public string Serverguid {
                    get {
                        return this.serverguidField;
                    }
                    set {
                        this.serverguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="userkey")]
                public string Userkey {
                    get {
                        return this.userkeyField;
                    }
                    set {
                        this.userkeyField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="usertoken")]
                public string Usertoken {
                    get {
                        return this.usertokenField;
                    }
                    set {
                        this.usertokenField = value;
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
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class lastmodules {
                
                private module moduleField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="MODULE")]
                public module Module {
                    get {
                        return this.moduleField;
                    }
                    set {
                        this.moduleField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class module {
                
                private modules modulesField;
                
                private string guidField;
                
                private string idField;
                
                private string nameField;
                
                private string projectField;
                
                private string projectnameField;
                
                private string lastidField;
                
                private string lastguidField;
                
                private string lastField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="MODULES")]
                public modules Modules {
                    get {
                        return this.modulesField;
                    }
                    set {
                        this.modulesField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="id")]
                public string Id {
                    get {
                        return this.idField;
                    }
                    set {
                        this.idField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="project")]
                public string Project {
                    get {
                        return this.projectField;
                    }
                    set {
                        this.projectField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="projectname")]
                public string Projectname {
                    get {
                        return this.projectnameField;
                    }
                    set {
                        this.projectnameField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="lastid")]
                public string Lastid {
                    get {
                        return this.lastidField;
                    }
                    set {
                        this.lastidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="lastguid")]
                public string Lastguid {
                    get {
                        return this.lastguidField;
                    }
                    set {
                        this.lastguidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="last")]
                public string Last {
                    get {
                        return this.lastField;
                    }
                    set {
                        this.lastField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class modules {
                
                private module moduleField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="MODULE")]
                public module Module {
                    get {
                        return this.moduleField;
                    }
                    set {
                        this.moduleField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class user {
                
                private modules modulesField;
                
                private lastmodules lastmodulesField;
                
                private string guidField;
                
                private string nameField;
                
                private string fullnameField;
                
                private string idField;
                
                private string flags1Field;
                
                private string flags2Field;
                
                private string dialoglanguageidField;
                
                private string preferrededitorField;
                
                private string invertdirecteditField;
                
                private string dialogtextdirectionField;
                
                private string languageidField;
                
                private string showstarthelpField;
                
                private string lcidField;
                
                private string navigationtypeField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="MODULES")]
                public modules Modules {
                    get {
                        return this.modulesField;
                    }
                    set {
                        this.modulesField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="LASTMODULES")]
                public lastmodules Lastmodules {
                    get {
                        return this.lastmodulesField;
                    }
                    set {
                        this.lastmodulesField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="fullname")]
                public string Fullname {
                    get {
                        return this.fullnameField;
                    }
                    set {
                        this.fullnameField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="preferrededitor")]
                public string Preferrededitor {
                    get {
                        return this.preferrededitorField;
                    }
                    set {
                        this.preferrededitorField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="invertdirectedit")]
                public string Invertdirectedit {
                    get {
                        return this.invertdirecteditField;
                    }
                    set {
                        this.invertdirecteditField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="dialogtextdirection")]
                public string Dialogtextdirection {
                    get {
                        return this.dialogtextdirectionField;
                    }
                    set {
                        this.dialogtextdirectionField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="languageid")]
                public string Languageid {
                    get {
                        return this.languageidField;
                    }
                    set {
                        this.languageidField = value;
                    }
                }
                
                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="showstarthelp")]
                public string Showstarthelp {
                    get {
                        return this.showstarthelpField;
                    }
                    set {
                        this.showstarthelpField = value;
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
                [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="navigationtype")]
                public string Navigationtype {
                    get {
                        return this.navigationtypeField;
                    }
                    set {
                        this.navigationtypeField = value;
                    }
                }
            }
        }
    }
}
