//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码由 wsdl 自动生成, Version=4.8.3928.0。
// 
namespace nsname {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Ewin.Services.Realization.Wcf_THREE_CODE_COMPARISON_Ic_THREE_CODE_COMPARISONServi" +
        "ce", Namespace="http://tempuri.org/")]
    public partial class Wcf_THREE_CODE_COMPARISON : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ThreeCodeComparisonTestOperationCompleted;
        
        /// <remarks/>
        public Wcf_THREE_CODE_COMPARISON() {
            this.Url = "http://10.16.2.204:5050/Ewin/CommonLib/Interface/Ic_THREE_CODE_COMPARISONService/" +
                "";
        }
        
        /// <remarks/>
        public event ThreeCodeComparisonTestCompletedEventHandler ThreeCodeComparisonTestCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Ic_THREE_CODE_COMPARISONService/ThreeCodeComparisonTest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string ThreeCodeComparisonTest([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string sPostData) {
            object[] results = this.Invoke("ThreeCodeComparisonTest", new object[] {
                        sPostData});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginThreeCodeComparisonTest(string sPostData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("ThreeCodeComparisonTest", new object[] {
                        sPostData}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndThreeCodeComparisonTest(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void ThreeCodeComparisonTestAsync(string sPostData) {
            this.ThreeCodeComparisonTestAsync(sPostData, null);
        }
        
        /// <remarks/>
        public void ThreeCodeComparisonTestAsync(string sPostData, object userState) {
            if ((this.ThreeCodeComparisonTestOperationCompleted == null)) {
                this.ThreeCodeComparisonTestOperationCompleted = new System.Threading.SendOrPostCallback(this.OnThreeCodeComparisonTestOperationCompleted);
            }
            this.InvokeAsync("ThreeCodeComparisonTest", new object[] {
                        sPostData}, this.ThreeCodeComparisonTestOperationCompleted, userState);
        }
        
        private void OnThreeCodeComparisonTestOperationCompleted(object arg) {
            if ((this.ThreeCodeComparisonTestCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ThreeCodeComparisonTestCompleted(this, new ThreeCodeComparisonTestCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    public delegate void ThreeCodeComparisonTestCompletedEventHandler(object sender, ThreeCodeComparisonTestCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.8.3928.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ThreeCodeComparisonTestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ThreeCodeComparisonTestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
