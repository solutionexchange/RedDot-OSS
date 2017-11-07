namespace RQL {
    
    
    public class Logout {
        
        public virtual LogoutResponse Execute(LogoutRequest request) {
            LogoutResponse response;
            response = new LogoutResponse();
            RQL.RQLExecuteUtil.Execute(request, response);
            return response;
        }
        
        public class LogoutRequest : RQLRequestBase {
            
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
                
                private logout logoutField;
                
                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, ElementName="LOGOUT")]
                public logout Logout {
                    get {
                        return this.logoutField;
                    }
                    set {
                        this.logoutField = value;
                    }
                }
            }
            
            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.42")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            public class logout {
                
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
        
        public class LogoutResponse : RQLResponseBase {
            
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
            }
        }
    }
}
