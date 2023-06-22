'Public Class ADUser

'    Public Property Sid() As Byte()
'    End Property

'    Public Property Name() As String
'    End Property

'    Public Property DistinguishedName() As String
'    End Property

'    Public Property SAMAccountName() As String
'    End Property

'    Public Property RoleType() As Integer
'    End Property

'    Public Sub New(ByVal sid() As Byte, ByVal name As String, ByVal distinguishedName As String, ByVal sAMAccountName As String)
'        MyBase.New()
'        Sid = sid
'        Name = name
'        DistinguishedName = distinguishedName
'        SAMAccountName = sAMAccountName
'    End Sub

'    Public Function sIDtoString() As String
'        Dim sid As Security.Principal.SecurityIdentifier = New SecurityIdentifier(sid, 0)
'        Return sid.ToString
'    End Function
'End Class
'Dim el As Y
'Dim todo As m
'Dim devuelve As que
'Dim los As todos
'Dim de As usuarios
'Dim grupo As un
'Dim forma As de
'recursiva:

'Namespace Alpha.Code

'    Public Class SecurityContextEx

'        Public Shared Function getDomainName() As String
'            Return Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties.DomainName
'        End Function

'        Public Shared Function getLDAPDomainName(ByVal domainName As String) As String
'            Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder
'            Dim dcItems() As String = domainName.Split(".".ToCharArray)
'            sb.Append("LDAP://")
'            For Each item As String In dcItems
'                sb.AppendFormat("DC={0},", item)
'            Next
'            Return sb.ToString.Substring(0, (sb.ToString.Length - 1))
'        End Function

'        Public Shared Function GetUsersInGroup(ByVal group As String) As List(Of ADUser)
'            Dim users As List(Of ADUser) = New List(Of ADUser)
'            Dim ldapDomainName As String = SecurityContext.getLDAPDomainName(SecurityContext.getDomainName)
'            Dim domainName As String = ldapDomainName.Replace("LDAP://", String.Empty)
'            Dim groupMemebers As List(Of String) = New List(Of String)
'            Dim de As DirectoryEntry = New DirectoryEntry(ldapDomainName)
'            Dim ds As DirectorySearcher = New DirectorySearcher(de, "(objectClass=person)")
'            ds.Filter = ("(&(objectClass=group)(cn=" _
'                        + (group + "))"))
'            For Each result As SearchResult In ds.FindAll
'                Dim dir As var = result.GetDirectoryEntry
'                Dim list As var = dir.Invoke("Members")
'                Dim entries As IEnumerable = CType(list, IEnumerable)
'                For Each entry As var In entries
'                    Dim member As DirectoryEntry = New DirectoryEntry(entry)
'                    If (member.SchemaClassName = "group") Then
'                        Dim usersInGroup As List(Of ADUser) = GetUsersInGroup(member.Properties("name")(0).ToString)
'                        For Each aduser As ADUser In usersInGroup
'                                If Not users.ToDictionary(() => {  }, u.Name).ContainsKey(aduser.Name) Then
'                                users.Add(aduser)
'                            End If
'                        Next
'                    Else
'                        Dim aduser As ADUser = New ADUser(CType(member.Properties("objectSid")(0), Byte()), member.Properties("name")(0).ToString, member.Properties("distinguishedName")(0).ToString, member.Properties("sAMAccountName")(0).ToString)
'                        users.Add(aduser)
'                    End If
'                Next
'            Next
'            Return users
'        End Function
'    End Class
'End Namespace