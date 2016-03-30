﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace CheckAsm.amberfish_errorreporting {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ErrorReportingSoap", Namespace="http://amberfish.net/")]
    public partial class ErrorReporting : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback UploadFilePartOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetFilePathOperationCompleted;
        
        private System.Threading.SendOrPostCallback ReportBugOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ErrorReporting() {
            this.Url = global::CheckAsm.Properties.Settings.Default.CheckAsm_net_booring_checkasm_WS_Test;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event UploadFilePartCompletedEventHandler UploadFilePartCompleted;
        
        /// <remarks/>
        public event GetFilePathCompletedEventHandler GetFilePathCompleted;
        
        /// <remarks/>
        public event ReportBugCompletedEventHandler ReportBugCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://amberfish.net/UploadFilePart", RequestNamespace="http://amberfish.net/", ResponseNamespace="http://amberfish.net/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UploadFilePart(string filename, bool append, [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")] byte[] bytes, int length) {
            this.Invoke("UploadFilePart", new object[] {
                        filename,
                        append,
                        bytes,
                        length});
        }
        
        /// <remarks/>
        public void UploadFilePartAsync(string filename, bool append, byte[] bytes, int length) {
            this.UploadFilePartAsync(filename, append, bytes, length, null);
        }
        
        /// <remarks/>
        public void UploadFilePartAsync(string filename, bool append, byte[] bytes, int length, object userState) {
            if ((this.UploadFilePartOperationCompleted == null)) {
                this.UploadFilePartOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadFilePartOperationCompleted);
            }
            this.InvokeAsync("UploadFilePart", new object[] {
                        filename,
                        append,
                        bytes,
                        length}, this.UploadFilePartOperationCompleted, userState);
        }
        
        private void OnUploadFilePartOperationCompleted(object arg) {
            if ((this.UploadFilePartCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadFilePartCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://amberfish.net/GetFilePath", RequestNamespace="http://amberfish.net/", ResponseNamespace="http://amberfish.net/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetFilePath() {
            object[] results = this.Invoke("GetFilePath", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetFilePathAsync() {
            this.GetFilePathAsync(null);
        }
        
        /// <remarks/>
        public void GetFilePathAsync(object userState) {
            if ((this.GetFilePathOperationCompleted == null)) {
                this.GetFilePathOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetFilePathOperationCompleted);
            }
            this.InvokeAsync("GetFilePath", new object[0], this.GetFilePathOperationCompleted, userState);
        }
        
        private void OnGetFilePathOperationCompleted(object arg) {
            if ((this.GetFilePathCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetFilePathCompleted(this, new GetFilePathCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://amberfish.net/ReportBug", RequestNamespace="http://amberfish.net/", ResponseNamespace="http://amberfish.net/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ReportBug(string message, string logId) {
            this.Invoke("ReportBug", new object[] {
                        message,
                        logId});
        }
        
        /// <remarks/>
        public void ReportBugAsync(string message, string logId) {
            this.ReportBugAsync(message, logId, null);
        }
        
        /// <remarks/>
        public void ReportBugAsync(string message, string logId, object userState) {
            if ((this.ReportBugOperationCompleted == null)) {
                this.ReportBugOperationCompleted = new System.Threading.SendOrPostCallback(this.OnReportBugOperationCompleted);
            }
            this.InvokeAsync("ReportBug", new object[] {
                        message,
                        logId}, this.ReportBugOperationCompleted, userState);
        }
        
        private void OnReportBugOperationCompleted(object arg) {
            if ((this.ReportBugCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ReportBugCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void UploadFilePartCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GetFilePathCompletedEventHandler(object sender, GetFilePathCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetFilePathCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetFilePathCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void ReportBugCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591