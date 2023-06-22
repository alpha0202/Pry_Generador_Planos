Imports System.Security.Principal
Imports System.DirectoryServices
Module Autenticar_usuario

    Dim windowsIdentity As New WindowsIdentity(windowsIdentity.GetCurrent.Token, AuthenticationType)
    Dim lSt_CodUsuario As String
    Dim AuthenticationType = "WindowsAuthentication"
    Public path As String
    Public filterAttribute As String
    Public _descripcion As String

    Public Function IsAuthenticated(ByVal domain As String, ByVal username As String) As Boolean


        'Dim path As String = "LDAP://midominio.com.sv/DC=midominio,DC=com,DC=sv"

        Dim path As String = "LDAP://aliar.com.co/DC=aliar,DC=com,DC=co"

        Dim domainAndUsername As String = domain & "\" & username

        Dim entry As DirectoryEntry = New DirectoryEntry(path, domainAndUsername, Nothing)

        Dim filterAttribute As String


        Try

            'Bind to the native AdsObject to force authentication.

            Dim obj As Object = entry.NativeObject

            Dim search As DirectorySearcher = New DirectorySearcher(entry)

            search.Filter = "(SAMAccountName=" & username & ")"

            search.PropertiesToLoad.Add("cn")

            Dim result As SearchResult = search.FindOne()



            If (result Is Nothing) Then

                Return False


            End If

        Catch ex As Exception

            Return False

        End Try



        obtenerDatosUsuario_Click()

        Return True

    End Function

    Public Sub obtenerDatosUsuario_Click()
        Dim objetoUsuario, gruposSeguridad
        Dim ultimoInicioSesion As String
        '   Dim dominio As String
        Dim nombreUsuario As String
        Dim estadoCuenta As String
        Dim gruposSeguridadUsuario As String

        Dim GRUPO_AD As String = "ImportPlanos"
        Dim dominio As String
        dominio = "aliar.com.co"
        lSt_CodUsuario = ""
        lSt_CodUsuario = windowsIdentity.Name
        lSt_CodUsuario = lSt_CodUsuario.Substring(6, 8)
        'lSt_CodUsuario = "LIZETSAV"

        dominio = dominio

        nombreUsuario = lSt_CodUsuario

        '   On Error GoTo cError

        On Error Resume Next

        objetoUsuario = GetObject("WinNT://" + dominio + "/" + nombreUsuario + ",user")
        If Err.Number = 0 Then
            If objetoUsuario.AccountDisabled = True Then
                estadoCuenta = "Deshabilitado"
                ultimoInicioSesion = "No existe"
            Else
                estadoCuenta = "Habilitado"
                ultimoInicioSesion = objetoUsuario.Get("Lastlogin")
            End If

            gruposSeguridad = ""
            For Each gruposSeguridad In objetoUsuario.Groups
                If gruposSeguridadUsuario = "" Then
                    gruposSeguridadUsuario = gruposSeguridad.Name
                Else
                    gruposSeguridadUsuario = gruposSeguridadUsuario + ", " + gruposSeguridad.Name

                End If
            Next



            Dim strTest As String
            Dim strArray() As String
            Dim intCount As Integer

            strTest = gruposSeguridadUsuario
            strArray = Split(strTest, ",")


            'If strArray.ToArray = "ImportPlanos" Then
            '    MsgBox("Acceso Autorizado")
            'Else

            'End If

            For x = 0 To strArray.Count - 1

                'MsgBox(strArray(x))

                If strArray(x).ToString = "ImportPlanos" Then
                    MsgBox(strArray(x))
                Else
                    End
                End If
            Next

            'For Each gruposSeguridad In objetoUsuario.Groups
            '    If gruposSeguridad.Name = GRUPO_AD Then
            '        MsgBox("Acceso Autorizado")
            '        Return
            '    Else
            '        'MsgBox("Acceso Denegado")
            '        ' End
            '    End If
            'Next

            'Dim obtener_grupo() As String
            'Dim resultado

            ''obtener_grupo = 

            'For i = 0 To UBound(obtener_grupo)
            '    resultado = obtener_grupo(i)

            'Next

            'If nombreUsuario = objetoUsuario.Get("Name") And gruposSeguridadUsuario = GRUPO_AD Then

            'Else
            'End If


            'Mostramos los datos del usuario
            MsgBox("Nombre completo: " & objetoUsuario.Get("Fullname") & vbCrLf & _
                "Descripción: " & objetoUsuario.Get("Description") & vbCrLf & _
                "Nombre: " & objetoUsuario.Get("Name") & vbCrLf & _
                "Carpeta de inicio: " & objetoUsuario.Get("HomeDirectory") & vbCrLf & _
                "Script de inicio: " & objetoUsuario.Get("LoginScript") & vbCrLf & _
                "Último inicio de sesión: " & ultimoInicioSesion & vbCrLf & _
                "Perfil: " & objetoUsuario.Get("Profile") & vbCrLf & _
                "Estado de la cuenta: " & estadoCuenta & vbCrLf & _
                "Grupos seguridad: " & gruposSeguridadUsuario, vbInformation + vbOKOnly)
            objetoUsuario = Nothing
        Else
            MsgBox("El usuario " + nombreUsuario + " no existe ", vbExclamation + vbOKOnly)
        End If

    End Sub


End Module
