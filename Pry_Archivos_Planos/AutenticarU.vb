Imports System
Imports System.Text
'Imports System.Collections
'Imports System.DirectoryServices
'Imports System.Configuration
'Module AutenticarU


'    Private _path As String
'    Private _filterAttribute As String
'    Private _descripcion As String

'    'Public Sub New(ByVal path As String)
'    '    _path = path
'    'End Sub

'    Public ReadOnly Property isDisplayName() As Integer
'        Get
'            Return _descripcion
'        End Get
'    End Property

'    Public Function Devuelve_Propiedad(ByVal Domain As String, ByVal username As String, ByVal Propiedad As String) As String
'        Dim _path As String = "LDAP://aliar.com.co/DC=aliar,DC=com,DC=co"
'        Dim domainAndUsername As String = (Domain & "\") + username
'        Dim entry As New DirectoryEntry(_path, domainAndUsername, Nothing)


'        Try
'            Dim search As New DirectorySearcher(entry)
'            search.Filter = "(&(objectClass=user)(anr=" + username + "))"
'            Dim resEnt As SearchResult = search.FindOne()
'            Dim de As DirectoryEntry = resEnt.GetDirectoryEntry()

'            _descripcion = de.Properties(Propiedad).Value.ToString

'            entry.Close()
'        Catch ex As Exception
'            Return "Error al traer la informacion"
'        End Try

'        Return _descripcion
'    End Function

'    Public Function IsAuthenticated(ByVal Domain As String, ByVal username As String) As Boolean
'        Dim Success As Boolean = False
'        Dim Entry As New System.DirectoryServices.DirectoryEntry("LDAP://" & Domain, username, Nothing)
'        Dim Searcher As New System.DirectoryServices.DirectorySearcher(Entry)
'        Searcher.SearchScope = DirectoryServices.SearchScope.OneLevel
'        Try
'            Dim Results As System.DirectoryServices.SearchResult = Searcher.FindOne
'            Success = Not (Results Is Nothing)
'        Catch
'            Success = False
'        End Try
'        Devuelve_Propiedad("aliar.com.co", "carloosp", Nothing)
'        GetGroups()
'        Return Success

'    End Function

'    Public Function GetGroups() As String
'        Dim _path As String = "LDAP://aliar.com.co/DC=aliar,DC=com,DC=co"
'        Dim search As New DirectorySearcher(_path)
'        search.Filter = "(cn=" & _filterAttribute & ")"
'        search.PropertiesToLoad.Add("memberOf")
'        Dim groupNames As New StringBuilder()

'        Try
'            Dim result As SearchResult = search.FindOne()

'            Dim propertyCount As Integer = result.Properties("memberOf").Count

'            Dim dn As String
'            Dim equalsIndex As Integer, commaIndex As Integer

'            For propertyCounter As Integer = 0 To propertyCount - 1
'                dn = DirectCast(result.Properties("memberOf")(propertyCounter), String)

'                equalsIndex = dn.IndexOf("=", 1)
'                commaIndex = dn.IndexOf(",", 1)
'                If -1 = equalsIndex Then
'                    Return Nothing
'                End If

'                groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
'                groupNames.Append("|")

'            Next
'        Catch ex As Exception
'            Throw New Exception("Error obtaining group names. " & ex.Message)
'        End Try
'        Return groupNames.ToString()
'    End Function

'End Module
