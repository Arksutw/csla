﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("a596fa9c-0232-4875-9f10-e1c659ac36b7")> 

'Original file name:
'Generation date: 9/10/2008 3:25:57 PM
'''<summary>
'''There are no comments for CompanyEntities in the schema.
'''</summary>
Partial Public Class CompanyEntities
    Inherits Global.System.Data.Objects.ObjectContext
    '''<summary>
    '''Initializes a new CompanyEntities object using the connection string found in the 'CompanyEntities' section of the application configuration file.
    '''</summary>
    Public Sub New()
        MyBase.New("name=CompanyEntities", "CompanyEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new CompanyEntities object.
    '''</summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "CompanyEntities")
        Me.OnContextCreated
    End Sub
    '''<summary>
    '''Initialize a new CompanyEntities object.
    '''</summary>
    Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
        MyBase.New(connection, "CompanyEntities")
        Me.OnContextCreated
    End Sub
    Partial Private Sub OnContextCreated()
        End Sub
    '''<summary>
    '''There are no comments for Companies in the schema.
    '''</summary>
    Public ReadOnly Property Companies() As Global.System.Data.Objects.ObjectQuery(Of Companies)
        Get
            If (Me._Companies Is Nothing) Then
                Me._Companies = MyBase.CreateQuery(Of Companies)("[Companies]")
            End If
            Return Me._Companies
        End Get
    End Property
    Private _Companies As Global.System.Data.Objects.ObjectQuery(Of Companies)
    '''<summary>
    '''There are no comments for Users in the schema.
    '''</summary>
    Public ReadOnly Property Users() As Global.System.Data.Objects.ObjectQuery(Of Users)
        Get
            If (Me._Users Is Nothing) Then
                Me._Users = MyBase.CreateQuery(Of Users)("[Users]")
            End If
            Return Me._Users
        End Get
    End Property
    Private _Users As Global.System.Data.Objects.ObjectQuery(Of Users)
    '''<summary>
    '''There are no comments for Companies in the schema.
    '''</summary>
    Public Sub AddToCompanies(ByVal companies As Companies)
        MyBase.AddObject("Companies", companies)
    End Sub
    '''<summary>
    '''There are no comments for Users in the schema.
    '''</summary>
    Public Sub AddToUsers(ByVal users As Users)
        MyBase.AddObject("Users", users)
    End Sub
End Class
'''<summary>
'''There are no comments for CompanyModel.Companies in the schema.
'''</summary>
'''<KeyProperties>
'''CompanyId
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="CompanyModel", Name:="Companies"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class Companies
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new Companies object.
    '''</summary>
    '''<param name="companyId">Initial value of CompanyId.</param>
    '''<param name="companyName">Initial value of CompanyName.</param>
    '''<param name="dateAdded">Initial value of DateAdded.</param>
    Public Shared Function CreateCompanies(ByVal companyId As Integer, ByVal companyName As String, ByVal dateAdded As Date) As Companies
        Dim companies As Companies = New Companies
        companies.CompanyId = companyId
        companies.CompanyName = companyName
        companies.DateAdded = dateAdded
        Return companies
    End Function
    '''<summary>
    '''There are no comments for Property CompanyId in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property CompanyId() As Integer
        Get
            Return Me._CompanyId
        End Get
        Set
            Me.OnCompanyIdChanging(value)
            Me.ReportPropertyChanging("CompanyId")
            Me._CompanyId = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("CompanyId")
            Me.OnCompanyIdChanged
        End Set
    End Property
    Private _CompanyId As Integer
    Partial Private Sub OnCompanyIdChanging(ByVal value As Integer)
        End Sub
    Partial Private Sub OnCompanyIdChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property CompanyName in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property CompanyName() As String
        Get
            Return Me._CompanyName
        End Get
        Set
            Me.OnCompanyNameChanging(value)
            Me.ReportPropertyChanging("CompanyName")
            Me._CompanyName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("CompanyName")
            Me.OnCompanyNameChanged
        End Set
    End Property
    Private _CompanyName As String
    Partial Private Sub OnCompanyNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnCompanyNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property DateAdded in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property DateAdded() As Date
        Get
            Return Me._DateAdded
        End Get
        Set
            Me.OnDateAddedChanging(value)
            Me.ReportPropertyChanging("DateAdded")
            Me._DateAdded = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("DateAdded")
            Me.OnDateAddedChanged
        End Set
    End Property
    Private _DateAdded As Date
    Partial Private Sub OnDateAddedChanging(ByVal value As Date)
        End Sub
    Partial Private Sub OnDateAddedChanged()
        End Sub
End Class
'''<summary>
'''There are no comments for CompanyModel.Users in the schema.
'''</summary>
'''<KeyProperties>
'''UserId
'''</KeyProperties>
<Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="CompanyModel", Name:="Users"),  _
 Global.System.Runtime.Serialization.DataContractAttribute(IsReference:=true),  _
 Global.System.Serializable()>  _
Partial Public Class Users
    Inherits Global.System.Data.Objects.DataClasses.EntityObject
    '''<summary>
    '''Create a new Users object.
    '''</summary>
    '''<param name="userId">Initial value of UserId.</param>
    '''<param name="userName">Initial value of UserName.</param>
    '''<param name="password">Initial value of Password.</param>
    '''<param name="role">Initial value of Role.</param>
    Public Shared Function CreateUsers(ByVal userId As Integer, ByVal userName As String, ByVal password As String, ByVal role As String) As Users
        Dim users As Users = New Users
        users.UserId = userId
        users.UserName = userName
        users.Password = password
        users.Role = role
        Return users
    End Function
    '''<summary>
    '''There are no comments for Property UserId in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property UserId() As Integer
        Get
            Return Me._UserId
        End Get
        Set
            Me.OnUserIdChanging(value)
            Me.ReportPropertyChanging("UserId")
            Me._UserId = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
            Me.ReportPropertyChanged("UserId")
            Me.OnUserIdChanged
        End Set
    End Property
    Private _UserId As Integer
    Partial Private Sub OnUserIdChanging(ByVal value As Integer)
        End Sub
    Partial Private Sub OnUserIdChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property UserName in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property UserName() As String
        Get
            Return Me._UserName
        End Get
        Set
            Me.OnUserNameChanging(value)
            Me.ReportPropertyChanging("UserName")
            Me._UserName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("UserName")
            Me.OnUserNameChanged
        End Set
    End Property
    Private _UserName As String
    Partial Private Sub OnUserNameChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnUserNameChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Password in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Password() As String
        Get
            Return Me._Password
        End Get
        Set
            Me.OnPasswordChanging(value)
            Me.ReportPropertyChanging("Password")
            Me._Password = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Password")
            Me.OnPasswordChanged
        End Set
    End Property
    Private _Password As String
    Partial Private Sub OnPasswordChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnPasswordChanged()
        End Sub
    '''<summary>
    '''There are no comments for Property Role in the schema.
    '''</summary>
    <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
     Global.System.Runtime.Serialization.DataMemberAttribute()>  _
    Public Property Role() As String
        Get
            Return Me._Role
        End Get
        Set
            Me.OnRoleChanging(value)
            Me.ReportPropertyChanging("Role")
            Me._Role = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false)
            Me.ReportPropertyChanged("Role")
            Me.OnRoleChanged
        End Set
    End Property
    Private _Role As String
    Partial Private Sub OnRoleChanging(ByVal value As String)
        End Sub
    Partial Private Sub OnRoleChanged()
        End Sub
End Class