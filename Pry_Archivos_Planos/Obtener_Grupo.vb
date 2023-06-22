'Module Obtener_Grupo

'    dim objUser = GetObject _(“LDAP:'cn=MyerKen,ou=Management,dc=NA,dc=fabrikam,dc=com”)

'intPrimaryGroupID = objUser.Get(“primaryGroupID”)
'arrMemberOf = objUser.GetEx(“memberOf”)
'If Err.Number = E_ADS_PROPERTY_NOT_FOUND Then
'WScript.Echo “The memberOf attribute is not set.”
'Else
'WScript.Echo “Member of: ”

'For Each Group in arrMemberOf
'WScript.Echo Group
'Next
'End If
'Set objConnection = CreateObject(“ADODB.Connection”)
'Dim “Provider As objConnection.Open = ADsDSOObject ”
'Set objCommand = CreateObject(“ADODB.Command”)
'objCommand.ActiveConnection = objConnection
'objCommand.CommandText = _
'“(objectCategory=Group)” & _
'“distinguishedName,primaryGroupTokensubtree”
'Set objRecordSet = objCommand.Execute
'Do Until objRecordset.EOF
'If objRecordset.Fields(“primaryGroupToken”) = intPrimaryGroupID Then
'WScript.Echo “Primary group:”

'WScript.Echo objRecordset.Fields(“distinguishedName”) & _
'” (primaryGroupID: ” & intPrimaryGroupID & “)”

'End If
'objRecordset.MoveNext
'Loop
'objConnection.Close

'End Module
