﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.239
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace Echo
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://www.without-brains.net/echo_service", ConfigurationName:="Echo.EchoPortType")>  _
    Public Interface EchoPortType
        
        'CODEGEN: Generating message contract since the operation Echo is neither RPC nor document wrapped.
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.without-brains.net/echo_service#Echo", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Echo(ByVal request As Echo.EchoRequest) As Echo.EchoResponse
        
        'CODEGEN: Generating message contract since the operation ReverseEcho is neither RPC nor document wrapped.
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.without-brains.net/echo_service#ReverseEcho", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function ReverseEcho(ByVal request As Echo.ReverseEchoRequest) As Echo.ReverseEchoResponse
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.without-brains.net/echo")>  _
    Partial Public Class EchoMessageType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private messageField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Message() As String
            Get
                Return Me.messageField
            End Get
            Set
                Me.messageField = value
                Me.RaisePropertyChanged("Message")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class EchoRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="EchoRequest", [Namespace]:="http://www.without-brains.net/echo", Order:=0)>  _
        Public EchoRequest1 As Echo.EchoMessageType
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal EchoRequest1 As Echo.EchoMessageType)
            MyBase.New
            Me.EchoRequest1 = EchoRequest1
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class EchoResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="EchoResponse", [Namespace]:="http://www.without-brains.net/echo", Order:=0)>  _
        Public EchoResponse1 As Echo.EchoMessageType
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal EchoResponse1 As Echo.EchoMessageType)
            MyBase.New
            Me.EchoResponse1 = EchoResponse1
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ReverseEchoRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ReverseEchoRequest", [Namespace]:="http://www.without-brains.net/echo", Order:=0)>  _
        Public ReverseEchoRequest1 As Echo.EchoMessageType
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ReverseEchoRequest1 As Echo.EchoMessageType)
            MyBase.New
            Me.ReverseEchoRequest1 = ReverseEchoRequest1
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class ReverseEchoResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="ReverseEchoResponse", [Namespace]:="http://www.without-brains.net/echo", Order:=0)>  _
        Public ReverseEchoResponse1 As Echo.EchoMessageType
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal ReverseEchoResponse1 As Echo.EchoMessageType)
            MyBase.New
            Me.ReverseEchoResponse1 = ReverseEchoResponse1
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface EchoPortTypeChannel
        Inherits Echo.EchoPortType, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class EchoPortTypeClient
        Inherits System.ServiceModel.ClientBase(Of Echo.EchoPortType)
        Implements Echo.EchoPortType
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Echo_EchoPortType_Echo(ByVal request As Echo.EchoRequest) As Echo.EchoResponse Implements Echo.EchoPortType.Echo
            Return MyBase.Channel.Echo(request)
        End Function
        
        Public Function Echo(ByVal EchoRequest1 As Echo.EchoMessageType) As Echo.EchoMessageType
            Dim inValue As Echo.EchoRequest = New Echo.EchoRequest()
            inValue.EchoRequest1 = EchoRequest1
            Dim retVal As Echo.EchoResponse = CType(Me,Echo.EchoPortType).Echo(inValue)
            Return retVal.EchoResponse1
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function Echo_EchoPortType_ReverseEcho(ByVal request As Echo.ReverseEchoRequest) As Echo.ReverseEchoResponse Implements Echo.EchoPortType.ReverseEcho
            Return MyBase.Channel.ReverseEcho(request)
        End Function
        
        Public Function ReverseEcho(ByVal ReverseEchoRequest1 As Echo.EchoMessageType) As Echo.EchoMessageType
            Dim inValue As Echo.ReverseEchoRequest = New Echo.ReverseEchoRequest()
            inValue.ReverseEchoRequest1 = ReverseEchoRequest1
            Dim retVal As Echo.ReverseEchoResponse = CType(Me,Echo.EchoPortType).ReverseEcho(inValue)
            Return retVal.ReverseEchoResponse1
        End Function
    End Class
End Namespace
