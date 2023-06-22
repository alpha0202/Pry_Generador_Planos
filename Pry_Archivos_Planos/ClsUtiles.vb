Option Strict Off

Imports System.Data.Common
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls
Imports System.Web.UI
Imports System.Text
Imports System.Web.UI.HtmlControls
Imports System.Web
Imports MovLogistica
Imports System.Windows
Imports Microsoft.VisualBasic


Public Class ClsUtiles
    Public Enum TipoAccionBasica
        Nuevo = 1
        Editar = 2
        Eliminar = 3
        Guardar = 4
        Cancelar = 5
    End Enum

    Public Enum TiposCRUD
        StoredProcedure = 0
        Create = 1
        Read = 2
        Update = 3
        Delete = 4
        ReadScalar = 5
    End Enum

    Public Enum TiposMensaje
        InformacionNoEncontrada = 0
        AccionNoCompletada = 1
        AccionCompletada = 2
        VerificarInformacion = 3
        DatoNoEncontrado = 4
    End Enum

    Public Shared Function Crud(ByVal strSql As String, ByVal Parametros As Dictionary(Of String, Object), ByVal TipoCrud As TiposCRUD, ByVal datosLog As Dictionary(Of String, Object), Optional ByVal _servidor As String = "", Optional ByVal _base As String = "") As Object
        Dim sqlcnn As New clsConexion
        _servidor = "10.20.190.1"
        _base = "ALIARREPORTES"
        '_servidor = "AL190004\SQLEXPRESS"
        '_base = "PRUEBAS"
        Select Case TipoCrud
            Case TiposCRUD.Create
                Dim objCommand As New SqlCommand
                objCommand.CommandText = strSql
                sqlcnn.conectar(_servidor, _base)
                objCommand.Connection = sqlcnn.conexion
                If Not Parametros Is Nothing Then
                    For Each elemento As KeyValuePair(Of String, Object) In Parametros
                        objCommand.Parameters.AddWithValue(elemento.Key, elemento.Value)
                    Next
                End If
                If objCommand.ExecuteNonQuery() = 0 Then
                    Crud = False
                Else
                    Crud = True
                End If
                objCommand.Connection.Close()
                sqlcnn.Dispose()
            Case TiposCRUD.Read
                Dim objTabla As New DataTable
                Dim objAdapter As SqlDataAdapter
                sqlcnn.conectar(_servidor, _base)
                objAdapter = New SqlDataAdapter(strSql, sqlcnn.conexion)
                sqlcnn.Dispose()
                If Not Parametros Is Nothing Then
                    For Each elemento As KeyValuePair(Of String, Object) In Parametros
                        objAdapter.SelectCommand.Parameters.AddWithValue(elemento.Key, elemento.Value)
                    Next
                End If
                objAdapter.Fill(objTabla)
                Crud = objTabla

                sqlcnn.Dispose()
            Case TiposCRUD.ReadScalar
                Dim objCommand As New SqlCommand
                objCommand.CommandText = strSql
                sqlcnn.conectar(_servidor, _base)
                objCommand.Connection = sqlcnn.conexion
                If Not Parametros Is Nothing Then
                    For Each elemento As KeyValuePair(Of String, Object) In Parametros
                        objCommand.Parameters.AddWithValue(elemento.Key, elemento.Value)
                    Next
                End If
                Dim objResultado As Object
                objResultado = objCommand.ExecuteScalar
                sqlcnn.Dispose()
                If objResultado Is DBNull.Value Then
                    Crud = Nothing
                Else
                    Crud = objResultado
                End If
                objCommand.Connection.Close()
                sqlcnn.Dispose()
            Case TiposCRUD.Update
                Dim objCommand As New SqlCommand
                objCommand.CommandText = strSql
                sqlcnn.conectar(_servidor, _base)
                objCommand.Connection = sqlcnn.conexion
                If Not Parametros Is Nothing Then
                    For Each elemento As KeyValuePair(Of String, Object) In Parametros
                        objCommand.Parameters.AddWithValue(elemento.Key, elemento.Value)
                    Next
                End If
                If objCommand.ExecuteNonQuery() = 0 Then
                    Crud = False
                Else
                    Crud = True
                End If
                objCommand.Connection.Close()
                sqlcnn.Dispose()
            Case TiposCRUD.Delete
                Dim objCommand As New SqlCommand
                objCommand.CommandText = strSql
                sqlcnn.conectar(_servidor, _base)
                objCommand.Connection = sqlcnn.conexion
                If Not Parametros Is Nothing Then
                    For Each elemento As KeyValuePair(Of String, Object) In Parametros
                        objCommand.Parameters.AddWithValue(elemento.Key, elemento.Value)
                    Next
                End If
                If objCommand.ExecuteNonQuery() = 0 Then
                    Crud = False
                Else
                    Crud = True
                End If
                objCommand.Connection.Close()
                sqlcnn.Dispose()
            Case TiposCRUD.StoredProcedure
                Dim objTabla As New DataTable
                Dim objAdapter As SqlDataAdapter
                sqlcnn.conectar(_servidor, _base)
                objAdapter = New SqlDataAdapter(strSql, sqlcnn.conexion)
                sqlcnn.Dispose()
                objAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                If Not Parametros Is Nothing Then
                    For Each elemento As KeyValuePair(Of String, Object) In Parametros
                        objAdapter.SelectCommand.Parameters.AddWithValue(elemento.Key, elemento.Value)
                    Next
                End If
                objAdapter.Fill(objTabla)
                Crud = objTabla

                sqlcnn.Dispose()
            Case Else
                Return Nothing
        End Select
    End Function


    Public Overloads Shared Sub CargarCombo(ByRef control As Forms.ComboBox, ByVal strSql As String, ByVal parametros As Dictionary(Of String, Object), ByVal itemTodos As Boolean)
        Dim objDatatable As DataTable
        Dim objRow As DataRow
        control.DataSource = Nothing
        control.Items.Clear()
        If strSql <> "" Then
            objDatatable = CType(Crud(strSql, parametros, TiposCRUD.Read, Nothing), DataTable)
            If objDatatable.Rows.Count > 0 Then
                If Type.GetTypeCode(objDatatable.Columns(0).DataType) = TypeCode.String And Type.GetTypeCode(objDatatable.Columns(1).DataType) = TypeCode.String Then
                    objRow = objDatatable.NewRow
                    objRow.Item(0) = ""
                    objRow.Item(1) = ""
                    objDatatable.Rows.InsertAt(objRow, 0)
                End If
                If itemTodos Then
                    If Type.GetTypeCode(objDatatable.Columns(0).DataType) = TypeCode.String And Type.GetTypeCode(objDatatable.Columns(1).DataType) = TypeCode.String Then
                        objRow = objDatatable.NewRow
                        objRow.Item(0) = "-TOD@S-"
                        objRow.Item(1) = "-TOD@S-"
                        objDatatable.Rows.InsertAt(objRow, 1)
                    End If
                End If
                control.ValueMember = objDatatable.Columns(0).ColumnName
                control.DisplayMember = objDatatable.Columns(1).ColumnName
                control.DataSource = objDatatable
            End If
        End If
    End Sub
    Public Overloads Shared Sub CargarCombo(ByRef control As Forms.ComboBox, ByVal items As Dictionary(Of Object, Object), ByVal itemTodos As Boolean)
        Dim objDatatable As New DataTable()
        Dim objRow As DataRow
        objDatatable.Columns.Add("key")
        objDatatable.Columns.Add("item")

        objRow = objDatatable.NewRow
        objRow.Item(0) = ""
        objRow.Item(1) = ""
        objDatatable.Rows.InsertAt(objRow, 0)
        If itemTodos Then
            objRow = objDatatable.NewRow
            objRow.Item(0) = "-TOD@S-"
            objRow.Item(1) = "-TOD@S-"
            objDatatable.Rows.InsertAt(objRow, 1)
        End If

        For Each item As KeyValuePair(Of Object, Object) In items
            Dim objArray() As Object = {item.Key, item.Value}
            objDatatable.Rows.Add(objArray)
        Next

        control.DisplayMember = "item"
        control.ValueMember = "key"
        control.DataSource = objDatatable

    End Sub
    'Public Overloads Shared Sub CargarCombo(ByRef control As AjaxControlToolkit.ComboBox, ByVal strSql As String, ByVal parametros As Dictionary(Of String, Object), ByVal itemTodos As Boolean)
    '    Dim objTable As DataTable
    '    Dim newitem As New ListItem
    '    control.Items.Clear()
    '    If strSql <> "" Then
    '        objTable = Crud(strSql, parametros, TiposCRUD.Read, Nothing)
    '        If objTable.Rows.Count > 0 Then
    '            control.DataValueField = objTable.Columns(0).ColumnName
    '            control.DataTextField = objTable.Columns(1).ColumnName
    '            control.DataSource = objTable
    '            control.DataBind()
    '            newitem.Text = ""
    '            newitem.Value = ""
    '            control.Items.Insert(0, newitem)
    '            If itemTodos Then
    '                newitem = New ListItem
    '                newitem.Text = "-TOD@S-"
    '                newitem.Value = "-TOD@S-"
    '                control.Items.Insert(1, newitem)
    '            End If
    '        Else
    '            control.DataSource = Nothing
    '            control.DataBind()
    '        End If
    '    Else
    '        control.DataSource = Nothing
    '        control.DataBind()
    '    End If
    'End Sub
    'Public Overloads Shared Sub CargarCombo(ByRef control As DropDownList, ByVal strSql As String, ByVal parametros As Dictionary(Of String, Object), ByVal itemTodos As Boolean)
    '    Dim objTable As DataTable
    '    Dim newitem As New ListItem
    '    control.Items.Clear()
    '    If strSql <> "" Then
    '        objTable = Crud(strSql, parametros, TiposCRUD.Read, Nothing)
    '        If objTable.Rows.Count > 0 Then
    '            control.DataValueField = objTable.Columns(0).ColumnName
    '            control.DataTextField = objTable.Columns(1).ColumnName
    '            control.DataSource = objTable
    '            control.DataBind()
    '            newitem.Text = ""
    '            newitem.Value = ""
    '            control.Items.Insert(0, newitem)
    '            If itemTodos Then
    '                newitem = New ListItem
    '                newitem.Text = "-TOD@S-"
    '                newitem.Value = "-TOD@S-"
    '                control.Items.Insert(1, newitem)
    '            End If
    '        Else
    '            control.DataSource = Nothing
    '            control.DataBind()
    '        End If
    '    Else
    '        control.DataSource = Nothing
    '        control.DataBind()
    '    End If
    'End Sub
    'Public Overloads Shared Sub CargarCombo(ByRef control As AjaxControlToolkit.ComboBox, ByVal Items As Dictionary(Of String, Object))
    '    Dim objItem As New ListItem
    '    control.DataSource = Nothing
    '    control.DataBind()
    '    control.Items.Clear()
    '    objItem.Text = ""
    '    objItem.Value = ""
    '    control.Items.Add(objItem)
    '    For Each item As KeyValuePair(Of String, Object) In Items
    '        objItem = New ListItem
    '        objItem.Text = item.Key
    '        objItem.Value = item.Value.ToString
    '        control.Items.Add(objItem)
    '    Next
    'End Sub
    'Public Overloads Shared Sub CargarCombo(ByRef control As DropDownList, ByVal Items As Dictionary(Of String, Object))
    '    Dim objItem As New ListItem
    '    control.DataSource = Nothing
    '    control.DataBind()
    '    control.Items.Clear()
    '    objItem.Text = ""
    '    objItem.Value = ""
    '    control.Items.Add(objItem)
    '    For Each item As KeyValuePair(Of String, Object) In Items
    '        objItem = New ListItem
    '        objItem.Text = item.Key
    '        objItem.Value = item.Value.ToString
    '        control.Items.Add(objItem)
    '    Next
    'End Sub

    'Public Overloads Shared Sub CargarComboPdvs(ByRef cboPdv As AjaxControlToolkit.ComboBox, ByVal Zona As String, ByVal itemTodos As Boolean)
    '    Dim strSql As String
    '    Dim parametros As New Dictionary(Of String, Object)
    '    If Zona = "-TOD@S-" Then
    '        cboPdv.Items.Clear()
    '    Else
    '        parametros.Add("@Ciudad", Zona)
    '        strSql = "SELECT IDENTIFICACION, REPLACE(NOMBRE,'PDV ','') NOMBRE FROM CLIENTES WHERE CIUDAD = @Ciudad AND habilitado = 'NO' ORDER BY NOMBRE"
    '        CargarCombo(cboPdv, strSql, parametros, itemTodos)
    '    End If
    'End Sub
    'Public Overloads Shared Sub CargarComboPdvs(ByRef cboPdv As DropDownList, ByVal Zona As String, ByVal itemTodos As Boolean)
    '    Dim strSql As String
    '    Dim parametros As New Dictionary(Of String, Object)
    '    If Zona = "-TOD@S-" Then
    '        cboPdv.Items.Clear()
    '    Else
    '        parametros.Add("@Ciudad", Zona)
    '        strSql = "SELECT IDENTIFICACION, REPLACE(NOMBRE,'PDV ','') NOMBRE FROM CLIENTES WHERE CIUDAD = @Ciudad AND habilitado = 'NO' ORDER BY NOMBRE"
    '        CargarCombo(cboPdv, strSql, parametros, itemTodos)
    '    End If
    'End Sub

    'Public Overloads Shared Sub CargarComboZonas(ByRef cboZona As AjaxControlToolkit.ComboBox, ByVal zona As String, ByVal itemTodos As Boolean)
    '    Dim strSql As String
    '    If zona = 0 Then
    '        strSql = "SELECT ID,CIUDAD FROM CIUDAD WHERE mail <> 'no' ORDER BY CIUDAD"
    '    Else
    '        strSql = "SELECT ID,CIUDAD FROM CIUDAD WHERE ID in (SELECT value FROM dbo.fn_Split('" & zona & "', ',') AS Fn_Split_15) ORDER BY CIUDAD"
    '    End If
    '    CargarCombo(cboZona, strSql, Nothing, itemTodos)
    'End Sub
    'Public Overloads Shared Sub CargarComboZonas(ByRef cboZona As DropDownList, ByVal zona As String, ByVal itemTodos As Boolean)
    '    Dim strSql As String
    '    If zona = 0 Then
    '        strSql = "SELECT ID,CIUDAD FROM CIUDAD WHERE mail <> 'no' ORDER BY CIUDAD"
    '    Else
    '        strSql = "SELECT ID,CIUDAD FROM CIUDAD WHERE ID in (SELECT value FROM dbo.fn_Split('" & zona & "', ',') AS Fn_Split_15) ORDER BY CIUDAD"
    '    End If
    '    CargarCombo(cboZona, strSql, Nothing, itemTodos)
    'End Sub

    'Public Overloads Shared Sub CargarComboBodegas(ByRef cboBodega As AjaxControlToolkit.ComboBox, ByVal bodegas As String, ByVal itemTodos As Boolean)
    '    Dim strSql As String
    '    strSql = "SELECT [Identificacion],[Nombre] FROM [lg_Bodegas] WHERE [suspendido] = 'NO' AND [Identificacion] IN ('" & bodegas & "')"
    '    CargarCombo(cboBodega, strSql, Nothing, itemTodos)
    'End Sub
    'Public Overloads Shared Sub CargarComboBodegas(ByRef cboBodega As DropDownList, ByVal bodegas As String, ByVal itemTodos As Boolean)
    '    Dim strSql As String
    '    strSql = "SELECT [Identificacion],[Nombre] FROM [lg_Bodegas] WHERE [suspendido] = 'NO' AND [Identificacion] IN ('" & bodegas & "')"
    '    CargarCombo(cboBodega, strSql, Nothing, itemTodos)
    'End Sub

    'Public Overloads Shared Sub CargarComboUnidad(ByRef cboProducto As AjaxControlToolkit.ComboBox)
    '    Dim strSql As String
    '    strSql = "SELECT unidad, nombre FROM unidades order by nombre"
    '    CargarCombo(cboProducto, strSql, Nothing, False)
    'End Sub
    'Public Overloads Shared Sub CargarComboUnidad(ByRef cboProducto As DropDownList)
    '    Dim strSql As String
    '    strSql = "SELECT unidad, nombre FROM unidades order by nombre"
    '    CargarCombo(cboProducto, strSql, Nothing, False)
    'End Sub

    'Public Overloads Shared Sub CargarComboProductos(ByRef cboProducto As AjaxControlToolkit.ComboBox, ByVal grupro As String, ByVal itemTodos As Boolean, Optional ByVal key As String = "comercial")
    '    Dim strSql As String
    '    If key = "codigo" Then
    '        If grupro = "0" Then
    '            strSql = "SELECT codigo, descripcion FROM Productos WHERE ACTIVO='SI' order by descripcion"
    '        Else
    '            strSql = "SELECT codigo, descripcion FROM Productos WHERE ACTIVO='SI' AND grupo in(" & grupro & ") order by descripcion"
    '        End If
    '    Else
    '        If grupro = "0" Then
    '            strSql = "SELECT comercial, descripcion FROM Productos WHERE ACTIVO='SI' order by descripcion"
    '        Else
    '            strSql = "SELECT comercial, descripcion FROM Productos WHERE ACTIVO='SI' AND grupo in(" & grupro & ") order by descripcion"
    '        End If
    '    End If
    '    CargarCombo(cboProducto, strSql, Nothing, itemTodos)
    'End Sub
    'Public Overloads Shared Sub CargarComboProductos(ByRef cboProducto As DropDownList, ByVal grupro As String, ByVal itemTodos As Boolean, Optional ByVal key As String = "comercial")
    '    Dim strSql As String
    '    If key = "codigo" Then
    '        If grupro = "0" Then
    '            strSql = "SELECT codigo, descripcion FROM Productos WHERE ACTIVO='SI' order by descripcion"
    '        Else
    '            strSql = "SELECT codigo, descripcion FROM Productos WHERE ACTIVO='SI' AND grupo in(" & grupro & ") order by descripcion"
    '        End If
    '    Else
    '        If grupro = "0" Then
    '            strSql = "SELECT comercial, descripcion FROM Productos WHERE ACTIVO='SI' order by descripcion"
    '        Else
    '            strSql = "SELECT comercial, descripcion FROM Productos WHERE ACTIVO='SI' AND grupo in(" & grupro & ") order by descripcion"
    '        End If
    '    End If
    '    CargarCombo(cboProducto, strSql, Nothing, itemTodos)
    'End Sub

    'Public Overloads Shared Sub MostrarMensaje(ByRef pagina As System.Web.UI.Page, ByVal tipoMensaje As TiposMensaje)
    '    Dim strMensaje As String = ""
    '    Select Case tipoMensaje
    '        Case TiposMensaje.InformacionNoEncontrada
    '            strMensaje = "La información no fue encontrada"
    '        Case TiposMensaje.AccionNoCompletada
    '            strMensaje = "No se pudo completar la acción"
    '        Case TiposMensaje.AccionCompletada
    '            strMensaje = "Acción Completada"
    '        Case TiposMensaje.VerificarInformacion
    '            strMensaje = "Verifique la información ingresada"
    '    End Select

    '    ScriptManager.RegisterStartupScript(pagina, pagina.GetType, "", "<script type='text/javascript'> alert('" & strMensaje & "') </script>", False)
    'End Sub
    'Public Overloads Shared Sub MostrarMensaje(ByRef pagina As System.Web.UI.Page, ByVal mensaje As String)
    '    ScriptManager.RegisterStartupScript(pagina, pagina.GetType, "", "<script type='text/javascript'> alert('" & mensaje & "') </script>", False)
    'End Sub
    'Public Overloads Shared Sub MostrarMensaje(ByVal tipoMensaje As TiposMensaje)
    '    Select Case tipoMensaje
    '        Case TiposMensaje.InformacionNoEncontrada
    '            MessageBox.Show("La información no fue encontrada", "Campollo", Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Exclamation)
    '        Case TiposMensaje.AccionNoCompletada
    '            MessageBox.Show("No se pudo completar la acción", "Campollo", Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Error)
    '        Case TiposMensaje.AccionCompletada
    '            MessageBox.Show("Acción Completada", "Campollo", Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Information)
    '        Case TiposMensaje.VerificarInformacion
    '            MessageBox.Show("Verifique la información ingresada", "Campollo", Forms.MessageBoxButtons.OK, Forms.MessageBoxIcon.Information)
    '    End Select
    'End Sub
    Public Overloads Shared Sub MostrarMensaje(ByVal Mensaje As String)
        MessageBox.Show(Mensaje, "Campollo", Forms.MessageBoxButtons.OK)
    End Sub

    'Public Shared Function ValidarControl(ByRef control As Object) As Boolean
    '    If TypeOf (control) Is TextBox Then
    '        Dim objTxt As TextBox = TryCast(control, TextBox)
    '        If objTxt.Text = "" Then
    '            objTxt.Focus()
    '            Return False
    '        Else
    '            Return True
    '        End If
    '    End If
    '    If TypeOf (control) Is AjaxControlToolkit.ComboBox Then
    '        Dim objCbo As AjaxControlToolkit.ComboBox = TryCast(control, AjaxControlToolkit.ComboBox)
    '        If objCbo.SelectedItem.Text = "" Then
    '            objCbo.Focus()
    '            Return False
    '        Else
    '            Return True
    '        End If
    '    End If
    '    If TypeOf (control) Is DropDownList Then
    '        Dim objCbo As DropDownList = TryCast(control, DropDownList)
    '        If objCbo.SelectedItem.Text = "" Then
    '            objCbo.Focus()
    '            Return False
    '        Else
    '            Return True
    '        End If
    '    End If
    'End Function

    'Public Shared Function ExportarGridViewHttp(ByVal gridView As GridView, ByVal strTitulo As String, ByRef objResponse As HttpResponse) As Integer
    '    Dim sb As StringBuilder = New StringBuilder()
    '    Dim SW As System.IO.StringWriter = New System.IO.StringWriter(sb)
    '    Dim htw As HtmlTextWriter = New HtmlTextWriter(SW)
    '    Dim Page As Page = New Page()
    '    Dim form As HtmlForm = New HtmlForm()
    '    gridView.EnableViewState = False
    '    Page.EnableEventValidation = False
    '    Page.DesignerInitialize()
    '    Page.Controls.Add(form)
    '    form.Controls.Add(gridView)
    '    Page.RenderControl(htw)
    '    objResponse.Clear()
    '    objResponse.Buffer = True
    '    objResponse.ContentType = "text/html"
    '    objResponse.AddHeader("Content-Disposition", "attachment;filename=" & strTitulo & ".html")
    '    objResponse.Charset = "UTF-8"
    '    objResponse.ContentEncoding = Encoding.Default
    '    objResponse.Write(sb.ToString())
    '    objResponse.Flush()
    '    objResponse.End()
    'End Function

    'Public Shared Function log_visitas(ByVal log_usuario As String, ByVal log_ipremota As String, ByVal log_entra As String, Optional ByVal _servidor As String = "", Optional ByVal _base As String = "") As Boolean
    '    Dim sqlcnn As New clsConexion
    '    Dim scmd As String
    '    Dim cmd As New SqlCommand
    '    Try
    '        scmd = "INSERT INTO log_visitas(log_usuario ,log_ipremota,log_fecha,log_entra) VALUES(@log_usuario ,@log_ipremota,@log_fecha,@log_entra)"
    '        sqlcnn.conectar(_servidor, _base)
    '        cmd.Connection = sqlcnn.conexion
    '        cmd.CommandText = scmd
    '        cmd.Parameters.AddWithValue("@log_usuario", log_usuario)
    '        cmd.Parameters.AddWithValue("@log_ipremota", log_ipremota)
    '        cmd.Parameters.AddWithValue("@log_fecha", Date.Now)
    '        cmd.Parameters.AddWithValue("@log_entra", log_entra)
    '        cmd.ExecuteNonQuery()
    '        sqlcnn.Dispose()
    '    Catch ex As Exception
    '        Return False
    '    End Try
    '    Return True

    'End Function

    Public Shared Sub CargarGrilla(ByRef control As Forms.DataGridView, ByVal strSql As String, ByVal parametros As Dictionary(Of String, Object))
        Dim objTable As DataTable
        control.DataSource = Nothing
        If strSql <> "" Then
            objTable = CType(Crud(strSql, parametros, TiposCRUD.Read, Nothing), DataTable)
            If objTable.Rows.Count > 0 Then
                control.DataSource = objTable
            End If
        End If

    End Sub

    Public Overloads Shared Sub ManejadorTab(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Forms.Keys.Enter) Then
            e.Handled = True
            Forms.SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Overloads Shared Sub ManejadorTab(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Forms.Keys.Enter Then
            e.Handled = True
            Forms.SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Shared Function ValidarEntradaCbo(ByRef control As Forms.ComboBox) As Boolean
        Dim flagResultado As Boolean = False
        For Each item As DataRowView In control.Items
            If control.Text = CType(item, DataRowView).Item(1).ToString Then
                flagResultado = True
            End If
        Next
        Return flagResultado
    End Function

    Public Shared Function Correo(ByVal msj As String, ByVal dest As String, ByVal usuario As String, Optional ByVal _servidor As String = "", Optional ByVal _base As String = "") As Boolean
        Dim sqlcnn As New clsConexion
        Dim scmd As String
        Dim cmd As New SqlCommand
        Try
            scmd = "insert into Lg_logcomunicaciones(Fecha,Evento,usuario,Destinatarios,Informado) values (@Fecha,@Alerta,@usuario,@Destinatarios,'N')"
            sqlcnn.conectar(_servidor, _base)
            cmd.Connection = sqlcnn.conexion
            cmd.CommandText = scmd
            cmd.Parameters.AddWithValue("@Fecha", Hser)
            cmd.Parameters.AddWithValue("@Alerta", msj)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@Destinatarios", dest)
            cmd.ExecuteNonQuery()
            sqlcnn.Dispose()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Shared Function Hser(Optional ByVal _servidor As String = "", Optional ByVal _base As String = "") As Date
        Dim sqlcnn As New clsConexion
        Dim cmdfecha As New SqlCommand
        Dim sqldar As SqlDataReader
        Dim fservi As Date
        sqlcnn.conectar(_servidor, _base)

        cmdfecha.Connection = sqlcnn.conexion
        cmdfecha.CommandType = CommandType.StoredProcedure
        cmdfecha.CommandText = "pa_FechaHora_Servidor"
        sqldar = cmdfecha.ExecuteReader
        If sqldar.HasRows Then
            sqldar.Read()
            fservi = CDate(sqldar(0))
        End If
        sqldar.Close()

        sqlcnn.Dispose()
        Return fservi
    End Function

    Public Shared Function ConfirmarAccion() As Boolean
        If MessageBox.Show("Esta segur@ de realizar esta acción", "aliar", Forms.MessageBoxButtons.YesNo, Forms.MessageBoxIcon.Question) = Forms.DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function
    'Public Shared Sub CargarChklist(ByRef control As Forms.CheckedListBox, ByVal strSql As String, ByVal parametros As Dictionary(Of String, Object), ByVal itemTodos As Boolean)
    '    Dim objTable As DataTable
    '    control.DataSource = Nothing
    '    control.Items.Clear()
    '    If strSql <> "" Then
    '        objTable = Crud(strSql, parametros, TiposCRUD.Read, Nothing)
    '        For I = 0 To objTable.Rows.Count - 1
    '            control.Items.Add(New Clsitem(objTable.Rows(I).Item(1), objTable.Rows(I).Item(0)))
    '        Next
    '    End If
    'End Sub

    'Public Overloads Shared Sub CargarCheckBoxListCuartos(ByRef chkCuartos As CheckBoxList, ByVal bodega As String, ByVal itemTodos As Boolean)
    '    Dim strSql As String
    '    If bodega = "-TOD@S-" Then
    '        strSql = "SELECT DISTINCT cuarto, nombre FROM cuartos WHERE [suspendido] = 'N' ORDER BY nombre"
    '    Else
    '        strSql = "SELECT cuarto, nombre FROM cuartos WHERE [suspendido] = 'N' and BODEGA='" & bodega & "' ORDER BY nombre"
    '    End If
    '    CargarCheckBoxList(chkCuartos, strSql, Nothing, itemTodos)
    'End Sub

    'Public Overloads Shared Sub CargarCheckBoxList(ByRef control As CheckBoxList, ByVal strSql As String, ByVal parametros As Dictionary(Of String, Object), ByVal itemTodos As Boolean)
    '    Dim objTable As DataTable
    '    Dim newitem As New ListItem
    '    control.Items.Clear()
    '    If strSql <> "" Then
    '        objTable = Crud(strSql, parametros, TiposCRUD.Read, Nothing)
    '        If objTable.Rows.Count > 0 Then
    '            control.DataValueField = objTable.Columns(0).ColumnName
    '            control.DataTextField = objTable.Columns(1).ColumnName
    '            control.DataSource = objTable
    '            control.DataBind()
    '            If itemTodos Then
    '                newitem = New ListItem
    '                newitem.Text = "-TOD@S-"
    '                newitem.Value = "-TOD@S-"
    '                control.Items.Insert(0, newitem)
    '            End If
    '        Else
    '            control.DataSource = Nothing
    '            control.DataBind()
    '        End If
    '    Else
    '        control.DataSource = Nothing
    '        control.DataBind()
    '    End If
    'End Sub

End Class