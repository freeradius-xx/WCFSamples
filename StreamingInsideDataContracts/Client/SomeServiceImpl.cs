﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://my.namespace.com/service", ConfigurationName="ISomeService")]
public interface ISomeService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://my.namespace.com/service/ISomeService/SendRequest", ReplyAction="http://my.namespace.com/service/ISomeService/SendRequestResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    void SendRequest(RequestClass request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://my.namespace.com/service/ISomeService/GetResponse", ReplyAction="http://my.namespace.com/service/ISomeService/GetResponseResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    ResponseClass GetResponse(int dataSize);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://my.namespace.com/data")]
public partial class RequestClass
{
    
    private string tokenField;
    
    private Content contentField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string token
    {
        get
        {
            return this.tokenField;
        }
        set
        {
            this.tokenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public Content content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://my.namespace.com/data")]
public partial class Content
{
    
    private string nameField;
    
    private string extensionField;
    
    private byte[] dataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string extension
    {
        get
        {
            return this.extensionField;
        }
        set
        {
            this.extensionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary", Order=2)]
    public byte[] data
    {
        get
        {
            return this.dataField;
        }
        set
        {
            this.dataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://my.namespace.com/data")]
public partial class ResponseClass
{
    
    private string tokenField;
    
    private Content contentField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string token
    {
        get
        {
            return this.tokenField;
        }
        set
        {
            this.tokenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public Content content
    {
        get
        {
            return this.contentField;
        }
        set
        {
            this.contentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISomeServiceChannel : ISomeService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SomeServiceClient : System.ServiceModel.ClientBase<ISomeService>, ISomeService
{
    
    public SomeServiceClient()
    {
    }
    
    public SomeServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SomeServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SomeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SomeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public void SendRequest(RequestClass request)
    {
        base.Channel.SendRequest(request);
    }
    
    public ResponseClass GetResponse(int dataSize)
    {
        return base.Channel.GetResponse(dataSize);
    }
}