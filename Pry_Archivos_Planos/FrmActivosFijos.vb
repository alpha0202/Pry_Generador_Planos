Imports System.IO
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb.OleDbCommand
Imports System.Text.RegularExpressions
Imports System.Data
Imports System.Data.OleDb
Imports Pry_Archivos_Planos.ClsUtiles
Imports Pry_Archivos_Planos.clsConexion
Imports System.Security.Principal
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports OleDbConnection = System.Data.OleDb.OleDbConnection
Imports DataTable = System.Data.DataTable

'Imports Excel = Microsoft.Office.Interop.Excel



Public Class FrmActivosFijos

    Dim SQLcnn As New clsConexion
    Dim sCmd As String
    Dim line, rutaPlanoNomina, rutaExcelGenerado, filePath, filePath2, filePath3, filePath4, filePath5, filePath6, filePath7, filePath8, filePath9, filePath10, filePath11, filePath12, filePath13, filePath14, filePath15, filePath16, filePath17, filePath18, filePath19, filePath20, filePath21, filePath22, Valor As String
    Dim OBJTABLE, OBJTABLE_ACTIVOS, OBJTABLE_MOVIMIENTO, OBJTABLE_CARNICOS, OBJTABLE_PRECIOS, OBJTABLE_PRES_VEND, OBJTABLE_PRES_JEF, OBJTABLE_BANCOLOMBIA, OBJTABLE_BOGOTA, OBJTABLE_ITEMS, OBJTABLE_ACT_ITEMS, OBJTABLE_CLASITEMS, OBJTABLE_SOLCOMPRAS, OBJTABLE_CRITERIOS, OBJTABLE_BAJAS, OBJTABLE_CUENTASXPAGAR, OBJTABLE_TRASLADOS, OBJTABLE_CODIGOBARRAS, OBJTABLE_MOV_INVENTARIOS, OBJTABLE_ENTIDADES_PROVEEDORES, OBJTABLE_IMPUESTOS_RETENCIONES, OBJTABLE_SQL, OBJTABLE_ENTIDADES_CLIENTES As New DataTable
    Dim windowsIdentity As New WindowsIdentity(WindowsIdentity.GetCurrent.Token, AuthenticationType)
    Dim lSt_CodUsuario As String
    Dim AuthenticationType = "WindowsAuthentication"
    '  Dim variable_accesodirecto As String = "180,890207037"
    ' Dim variable_accesodirecto As String = Command()
    Dim variable_centro_operativo, variable_NIT As String


    Private Sub FrmActivosFijos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '' If e.Node.Text = "ENTRADAS DE INVENTARIOS" Then

        Dim objetoUsuario, gruposSeguridad
        Dim ultimoInicioSesion As String
        Dim nombreUsuario As String
        Dim estadoCuenta As String
        Dim gruposSeguridadUsuario As String
        Dim GRUPO_AD As String = "ImportPlanos"
        Dim dominio As String




        'MsgBox(variable_accesodirecto)
        variable_centro_operativo = Frm_Compañias.cbo_empresas.SelectedItem(0).ToString
        variable_NIT = Frm_Compañias.cbo_empresas.SelectedItem(2).ToString


        dominio = "aliar.com.co"
        lSt_CodUsuario = ""
        lSt_CodUsuario = windowsIdentity.Name
        lSt_CodUsuario = Replace(lSt_CodUsuario, "ALIAR\", "")
        'lSt_CodUsuario = "JOSEACAC"

        dominio = dominio

        nombreUsuario = lSt_CodUsuario

        On Error Resume Next

        objetoUsuario = GetObject("WinNT://" + dominio + "/" + nombreUsuario + ",user")
        '    If Err.Number = 0 Then
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


        'Dim strTest As String
        'Dim strArray() As String

        'strTest = gruposSeguridadUsuario
        'strArray = Split(RTrim(strTest), ",")

        'If LTrim(strArray(1).ToString) = GRUPO_AD Or LTrim(strArray(0).ToString) = GRUPO_AD Or LTrim(strArray(2).ToString) = GRUPO_AD Or LTrim(strArray(3).ToString) = GRUPO_AD Or LTrim(strArray(4).ToString) = GRUPO_AD Then
        If InStr(gruposSeguridadUsuario, GRUPO_AD, CompareMethod.Text) <> 0 Then
            '' SE ASIGNA TAMAÑO A CAJAS DE TEXTO

            txt_archivoexcel.AutoSize = False
            txt_archivoexcel.Size = New Size(500, 25)
            txt_plano.AutoSize = False
            txt_plano.Size = New Size(500, 25)
            txt_tip_doc.AutoSize = False
            txt_tip_doc.Size = New Size(40, 25)
            txt_archivo_excel_activos.AutoSize = False
            txt_archivo_excel_activos.Size = New Size(500, 25)
            txt_archivo_plano_activos.AutoSize = False
            txt_archivo_plano_activos.Size = New Size(500, 25)

            txt_co.AutoSize = False
            txt_co.Size = New Size(40, 25)
            txt_tip_doc_mov.AutoSize = False
            txt_tip_doc_mov.Size = New Size(40, 25)
            txt_excel_movimiento.AutoSize = False
            txt_excel_movimiento.Size = New Size(500, 25)
            txt_plano_mov.AutoSize = False
            txt_plano_mov.Size = New Size(500, 25)


            txt_periodo_pres_vend.AutoSize = False
            txt_periodo_pres_vend.Size = New Size(55, 25)

            txt_periodo_pres_jef.AutoSize = False
            txt_periodo_pres_jef.Size = New Size(55, 25)

            cbo_presupuesto_vend.Items.Add("Presupuesto en Unidades")
            cbo_presupuesto_vend.Items.Add("Presupuesto en Kilos")
            cbo_presupuesto_vend.Items.Add("Presupuesto en valor")

            cbo_presupuesto_jef2.Items.Add("Presupuesto en Unidades")
            cbo_presupuesto_jef2.Items.Add("Presupuesto en Kilos")
            cbo_presupuesto_jef2.Items.Add("Presupuesto en valor")

            txt_excel_bancolombia.AutoSize = False
            txt_excel_bancolombia.Size = New Size(500, 25)
            txt_plano_bancolombia.AutoSize = False
            txt_plano_bancolombia.Size = New Size(500, 25)

            txt_excel_bogota.AutoSize = False
            txt_excel_bogota.Size = New Size(500, 25)
            txt_plano_bogota.AutoSize = False
            txt_plano_bogota.Size = New Size(500, 25)


            ''SE LLENA ARBOL CON MENUS

            Dim nodo As New TreeNode("FINANCIERO")
            Dim nodo1 As New TreeNode("COMERCIAL")
            Dim nodo3 As New TreeNode("ACTIVACIONES")
            Dim nodo2 As New TreeNode("ACTIVOS FIJOS")
            Dim nodo26 As New TreeNode("CAMBIO ESTADO ACTIVOS FIJOS")
            Dim nodo4 As New TreeNode("MOVIMIENTO CONTABLE")
            'Dim nodo27 As New TreeNode("MOVIMIENTO CONTABLE NEW")
            Dim nodo16 As New TreeNode("CLASIFICACION DE ACTIVOS FIJOS")
            Dim nodo5 As New TreeNode("CARNICOS")
            Dim nodo6 As New TreeNode("PRECIOS")
            Dim nodo7 As New TreeNode("PRESUPUESTO VENDEDOR")
            Dim nodo8 As New TreeNode("PRESUPUESTO JEFE DE VENTAS")
            Dim nodo9 As New TreeNode("EXTRACTO BANCOLOMBIA VIRTUAL")
            Dim nodo10 As New TreeNode("EXTRACTO BANCO DE BOGOTA")
            Dim nodo11 As New TreeNode("MAESTROS")
            Dim nodo12 As New TreeNode("ITEMS")
            Dim nodo13 As New TreeNode("CLASIFICACION DE ITEMS")
            Dim nodo14 As New TreeNode("COMPRAS")
            Dim nodo15 As New TreeNode("SOLICITUDES DE COMPRAS")
            Dim nodo17 As New TreeNode("BAJAS DE ACTIVOS FIJOS")
            Dim nodo18 As New TreeNode("CUENTAS X PAGAR")
            Dim nodo19 As New TreeNode("TRASLADOS DE ACTIVOS FIJOS")
            Dim nodo20 As New TreeNode("ACTUALIZACION DE ITEMS")
            Dim nodo21 As New TreeNode("CODIGO DE BARRAS")
            Dim nodo22 As New TreeNode("MOVIMIENTO DE INVENTARIOS")
            Dim nodo23 As New TreeNode("TRASLADOS DE INVENTARIOS")
            Dim nodo24 As New TreeNode("ENTRADAS DE INVENTARIOS")
            Dim nodo25 As New TreeNode("PLANO ENTIDADES PROVEEDORES")
            Dim nodo27 As New TreeNode("IMPUESTOS Y RETENCIONES")
            Dim nodo28 As New TreeNode("PLANO ENTIDADES CLIENTES")
            Dim nodo29 As New TreeNode("COSTO ESTANDAR")
            Dim nodo30 As New TreeNode("DISTRIBUCIÓN DE COSTOS")
            Dim nodo31 As New TreeNode("SALIDA DE INVENTARIOS")
            Dim nodo32 As New TreeNode("PLANO NOMINA")
            Dim nodo33 As New TreeNode("COMPRA DE SERVICIOS")
            Dim nodo34 As New TreeNode("IMPORTAR TERCEROS")
            Dim nodo35 As New TreeNode("ACT. COD. BARRAS ACTIVOS FIJOS")
            Dim nodo36 As New TreeNode("PLANO NOMINA SAP")

            nodo.Nodes.Add(nodo2)
            nodo.Nodes.Add(nodo3)
            nodo.Nodes.Add(nodo26)
            nodo.Nodes.Add(nodo16)
            nodo.Nodes.Add(nodo17)
            nodo.Nodes.Add(nodo4)
            'nodo.Nodes.Add(nodo27)
            nodo.Nodes.Add(nodo18)
            nodo.Nodes.Add(nodo19)
            nodo.Nodes.Add(nodo5)
            nodo.Nodes.Add(nodo9)
            nodo.Nodes.Add(nodo10)
            nodo1.Nodes.Add(nodo6)
            nodo1.Nodes.Add(nodo7)
            nodo1.Nodes.Add(nodo8)
            nodo11.Nodes.Add(nodo12)
            nodo11.Nodes.Add(nodo21)
            nodo11.Nodes.Add(nodo20)
            nodo11.Nodes.Add(nodo13)
            nodo11.Nodes.Add(nodo25)
            nodo11.Nodes.Add(nodo28)
            nodo11.Nodes.Add(nodo29)
            nodo14.Nodes.Add(nodo15)
            nodo22.Nodes.Add(nodo23)
            nodo22.Nodes.Add(nodo24)
            nodo22.Nodes.Add(nodo31)
            nodo11.Nodes.Add(nodo27)
            nodo.Nodes.Add(nodo30)
            nodo.Nodes.Add(nodo32)
            nodo.Nodes.Add(nodo33)
            nodo11.Nodes.Add(nodo34)
            nodo.Nodes.Add(nodo35)
            nodo.Nodes.Add(nodo36)

            ' nodo.Nodes.Add(nodo5)
            Me.TreeView1.Nodes.Add(nodo)
            Me.TreeView1.Nodes.Add(nodo1)
            Me.TreeView1.Nodes.Add(nodo11)
            Me.TreeView1.Nodes.Add(nodo14)
            Me.TreeView1.Nodes.Add(nodo22)




        Else
            MsgBox("El usuario " + nombreUsuario + " no esta autorizado para ingresar. Comuniquese con el Administrador...!!! ", vbExclamation + vbOKOnly)
            Close()
        End If


        '    '' Mostramos los datos del usuario

        '    'MsgBox("Nombre completo: " & objetoUsuario.Get("Fullname") & vbCrLf & _
        '    '    "Descripción: " & objetoUsuario.Get("Description") & vbCrLf & _
        '    '    "Nombre: " & objetoUsuario.Get("Name") & vbCrLf & _
        '    '    "Carpeta de inicio: " & objetoUsuario.Get("HomeDirectory") & vbCrLf & _
        '    '    "Script de inicio: " & objetoUsuario.Get("LoginScript") & vbCrLf & _
        '    '    "Último inicio de sesión: " & ultimoInicioSesion & vbCrLf & _
        '    '    "Perfil: " & objetoUsuario.Get("Profile") & vbCrLf & _
        '    '    "Estado de la cuenta: " & estadoCuenta & vbCrLf & _
        '    '    "Grupos seguridad: " & gruposSeguridadUsuario, vbInformation + vbOKOnly)
        '    objetoUsuario = Nothing
        'Else
        '    MsgBox("El usuario " + nombreUsuario + " no existe ", vbExclamation + vbOKOnly)
        'End If

        'End If
    End Sub



    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        btnNominaPlanoOrigen.Visible = True
        TabPage_ActFijos.Parent = Nothing
        TabPage_MovContable.Parent = Nothing
        TabPage_Carnicos.Parent = Nothing
        TabPage_Precios.Parent = Nothing
        TabPage_Presup_Vendedor.Parent = Nothing
        TabPage_Presup_Jefe.Parent = Nothing
        TabPage_ExtractoBan.Parent = Nothing
        TabPage_ExtractoBog.Parent = Nothing
        TabPage_Items.Parent = Nothing
        TabPage_Clas_items.Parent = Nothing
        TabPage_Sol_Compras.Parent = Nothing
        TabPage_criterios.Parent = Nothing
        TabPage_Bajas.Parent = Nothing
        TabPage_cuentasxpagar.Parent = Nothing
        TabPage_Traslados_AF.Parent = Nothing
        TabPage_act_items.Parent = Nothing
        TabPage_Codigo_barras.Parent = Nothing
        TabPage_Mov_Inventarios.Parent = Nothing
        TabPage_Entidades_Proveedores.Parent = Nothing
        TabPage_Activaciones.Parent = Nothing
        TabPage_Cambio_Estado_Activos_Fijos.Parent = Nothing
        TabPage_Mov_Contab_New.Parent = Nothing
        TabPage_Activaciones.Parent = Nothing
        TabPage_ImpuestosYRetenciones.Parent = Nothing
        TabPage_Entidades_Clientes.Parent = Nothing
        TabPage_CostoEstandar.Parent = Nothing
        TabPageDistribucionCostos.Parent = Nothing
        TabPage1.Parent = Nothing
        TabPageCompraServicios.Parent = Nothing
        TabPageImportarTercero.Parent = Nothing
        TabPageActualizarCodBarras.Parent = Nothing
        TabPagePlanoNomSAP.Parent = Nothing
        ''SE MUESTRA TABCONTROL SEGUN LA SELECCION DEL MENU ARBOL

        If e.Node.Text = "DISTRIBUCIÓN DE COSTOS" Then
            TabPageDistribucionCostos.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "COSTO ESTANDAR" Then
            TabPage_CostoEstandar.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "ACTIVACIONES" Then
            TabPage_Activaciones.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "CAMBIO ESTADO ACTIVOS FIJOS" Then
            TabPage_Cambio_Estado_Activos_Fijos.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "ACTIVOS FIJOS" Then
            TabPage_ActFijos.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "ACTIVOS FIJOS" Then
            TabPage_ActFijos.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "MOVIMIENTO CONTABLE" Then
            'TabPage_MovContable.Parent = TabControl1
            TabPage_Mov_Contab_New.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "CARNICOS" Then
            TabPage_Carnicos.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "PRECIOS" Then
            TabPage_Precios.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "PRESUPUESTO VENDEDOR" Then
            TabPage_Presup_Vendedor.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "PRESUPUESTO JEFE DE VENTAS" Then
            TabPage_Presup_Jefe.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "EXTRACTO BANCOLOMBIA VIRTUAL" Then
            TabPage_ExtractoBan.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "EXTRACTO BANCO DE BOGOTA" Then
            TabPage_ExtractoBog.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "ITEMS" Then
            TabPage_Items.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "CLASIFICACION DE ITEMS" Then
            TabPage_Clas_items.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "SOLICITUDES DE COMPRAS" Then
            TabPage_Sol_Compras.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "CLASIFICACION DE ACTIVOS FIJOS" Then
            TabPage_criterios.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "BAJAS DE ACTIVOS FIJOS" Then
            TabPage_Bajas.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "CUENTAS X PAGAR" Then
            TabPage_cuentasxpagar.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "TRASLADOS DE ACTIVOS FIJOS" Then
            TabPage_Traslados_AF.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "ACTUALIZACION DE ITEMS" Then
            TabPage_act_items.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "CODIGO DE BARRAS" Then
            TabPage_Codigo_barras.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "ACT. COD. BARRAS ACTIVOS FIJOS" Then
            TabPageActualizarCodBarras.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "TRASLADOS DE INVENTARIOS" Then
            TabPage_Mov_Inventarios.Parent = btnNominaPlanoOrigen
            txt_co_inv.Text = "232"
            txt_tip_doc_inv.Text = "TRA"
            txt_clase_doc_inv.Text = "67"
            txt_id_con_inv.Text = "607"
            txt_bodega_entrada_inv.Visible = True
            txt_bodega_salida_inv.Visible = True
            txt_bodega_entrada_inv.Text = "23202"
            txt_bodega_salida_inv.Text = "23201"
            Label87.Text = "PLANO DE INVENTARIOS"
        End If

        If e.Node.Text = "ENTRADAS DE INVENTARIOS" Then
            TabPage_Mov_Inventarios.Parent = btnNominaPlanoOrigen
            txt_co_inv.Text = "194"
            txt_tip_doc_inv.Text = "EIM"
            txt_clase_doc_inv.Text = "61"
            txt_id_con_inv.Text = "601"
            txt_bodega_entrada_inv.Text = ""
            txt_bodega_entrada_inv.Visible = False
            txt_bodega_salida_inv.Text = "19463"
            txt_bodega_salida_inv.Visible = True
            Label87.Text = "PLANO ENTRADAS DE INVENTARIOS"
        End If

        If e.Node.Text = "SALIDA DE INVENTARIOS" Then
            TabPage_Mov_Inventarios.Parent = btnNominaPlanoOrigen
            txt_co_inv.Text = "194"
            txt_tip_doc_inv.Text = "EIM"
            txt_clase_doc_inv.Text = "62"
            txt_id_con_inv.Text = "602"
            txt_bodega_entrada_inv.Text = "19463"
            txt_bodega_entrada_inv.Visible = True
            txt_bodega_salida_inv.Visible = False
            txt_bodega_salida_inv.Text = ""
            Label87.Text = "PLANO SALIDA DE INVENTARIOS"
        End If

        If e.Node.Text = "PLANO ENTIDADES PROVEEDORES" Then
            TabPage_Entidades_Proveedores.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "IMPUESTOS Y RETENCIONES" Then
            TabPage_ImpuestosYRetenciones.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "PLANO ENTIDADES CLIENTES" Then
            TabPage_Entidades_Clientes.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "PLANO NOMINA" Then
            TabPage1.Parent = btnNominaPlanoOrigen
        End If
        If e.Node.Text = "PLANO NOMINA SAP" Then
            TabPagePlanoNomSAP.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "COMPRA DE SERVICIOS" Then
            TabPageCompraServicios.Parent = btnNominaPlanoOrigen
        End If

        If e.Node.Text = "IMPORTAR TERCEROS" Then
            TabPageImportarTercero.Parent = btnNominaPlanoOrigen
        End If




    End Sub

    Public Shared Function PadL(ByVal cExpression As String, ByVal nResultSize As Integer, ByVal cPaddingChar As Char) As String

        ''SE ORDENA CONTENIDO DE ARCHIVO PLANO DE IZQUEIRDA A DERECHA

        Return cExpression.PadLeft(nResultSize, cPaddingChar)

    End Function

    Public Shared Function PadLR(ByVal cExpression As String, ByVal nResultSize As Integer, ByVal cPaddingChar As Char) As String

        ''SE ORDENA CONTENIDO DE ARCHIVO PLANO DE IZQUEIRDA A DERECHA

        Return cExpression.PadRight(nResultSize, cPaddingChar)

    End Function

    Private Sub btn_generar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar.Click

        If txt_tip_doc.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tip_doc.Focus()
            Exit Sub
        End If

        If txt_archivoexcel.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_archivoexcel.Focus()
            Exit Sub
        End If

        If txt_plano.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano.Focus()
            Exit Sub
        End If

        Generar_plano()

    End Sub

    Public Sub Generar_plano()

        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath = txt_plano.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath)

        If exists Then
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE.Rows.Clear()
                System.IO.File.Delete(filePath)
                Try
                    Dim Fec As DateTime = Dtp_fecha_activaciones.Text
                    Dim m, a As String
                    FileOpen(1, filePath, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    PrintLine(1, line)
                    line = fijo2 & PadL("0368", 4, " ")
                    line = line & PadL("", 2, "0")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL("190", 3, " ")
                    line = line & PadL(txt_tip_doc.Text, 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadL(Fec.ToString("yyyyMMdd"), 8, " ")
                    line = line & PadL("092", 3, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadLR("ACTIVACION", 10, " ")
                    line = line & PadL("", 1, " ")
                    m = Fec.ToString("MMMM")
                    m = UCase(m)
                    a = Year(Fec)
                    line = line & PadLR(m & " " & a, 14, " ")
                    line = line & PadL("", 230, " ")
                    PrintLine(1, line)

                    txt_archivoexcel.Text = OpenFileDialog1.FileName
                    'cargar_csv_activaciones()
                    OBJTABLE = GetDataExcel(txt_archivoexcel.Text, Hojaslibro(txt_archivoexcel.Text))
                    Me.Label1.Text = "2"
                    Me.Label2.Text = ""
                    Dim r

                    For j As Integer = 0 To OBJTABLE.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))

                        line = r & PadL("0368", 4, " ")
                        line = line & PadL("92", 2, " ")
                        line = line & PadL("02", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL("190", 3, " ")
                        line = line & PadL(txt_tip_doc.Text, 3, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadL(Trim(OBJTABLE.Rows(j).Item(0).ToString), 9, "0")
                        line = line & PadL("", 20, " ")
                        line = line & PadL("", 3, "0")
                        line = line & PadL(Fec.ToString("yyyyMMdd"), 8, " ")
                        PrintLine(1, line)
                    Next


                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_archivoexcel.Text & "', '" & txt_plano.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)


                    OBJTABLE.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                Dim Fec As DateTime = Dtp_fecha_activaciones.Text
                Dim m, a As String
                FileOpen(1, filePath, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                PrintLine(1, line)
                line = fijo2 & PadL("0368", 4, " ")
                line = line & PadL("", 2, "0")
                line = line & PadL("02", 2, " ")
                line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                line = line & PadL("1", 1, " ")
                line = line & PadL("190", 3, " ")
                line = line & PadL(txt_tip_doc.Text, 3, " ")
                line = line & PadL("", 8, "0")
                line = line & PadL(Fec.ToString("yyyyMMdd"), 8, " ")
                line = line & PadL("092", 3, " ")
                line = line & PadL("1", 1, " ")
                line = line & PadL("0", 1, " ")
                line = line & PadLR("ACTIVACION", 10, " ")
                line = line & PadL("", 1, " ")
                m = Fec.ToString("MMMM")
                m = UCase(m)
                a = Year(Fec)
                line = line & PadLR(m & " " & a, 14, " ")
                line = line & PadL("", 230, " ")
                PrintLine(1, line)

                txt_archivoexcel.Text = OpenFileDialog1.FileName
                'cargar_csv_activaciones()
                OBJTABLE = GetDataExcel(txt_archivoexcel.Text, Hojaslibro(txt_archivoexcel.Text))
                Me.Label1.Text = "2"
                Me.Label2.Text = ""
                Dim r

                For j As Integer = 0 To OBJTABLE.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))

                    line = r & PadL("0368", 4, " ")
                    line = line & PadL("92", 2, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL("190", 3, " ")
                    line = line & PadL(txt_tip_doc.Text, 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadL(Trim(OBJTABLE.Rows(j).Item(0).ToString), 9, "0")
                    line = line & PadL("", 20, " ")
                    line = line & PadL("", 3, "0")
                    line = line & PadL(Fec.ToString("yyyyMMdd"), 8, " ")
                    PrintLine(1, line)
                Next


                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_archivoexcel.Text & "', '" & txt_plano.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE.Clear()


                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub cargar_csv_activos()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_ACTIVOS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_archivo_excel_activos.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_ACTIVOS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_ACTIVOS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_ACTIVOS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_criterios()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_CRITERIOS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_criterios.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_CRITERIOS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_CRITERIOS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_CRITERIOS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub


    Private Sub cargar_csv_codigobarras()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_CODIGOBARRAS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_codigobarras.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_CODIGOBARRAS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_CODIGOBARRAS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_CODIGOBARRAS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_entidades_proveedores()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_ENTIDADES_PROVEEDORES.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_proveedores.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_ENTIDADES_PROVEEDORES.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_ENTIDADES_PROVEEDORES.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_ENTIDADES_PROVEEDORES.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub


    Private Sub cargar_csv_activaciones()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_archivoexcel.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub


    Private Sub cargar_csv_movimiento()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_MOVIMIENTO.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_excel_movimiento.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_MOVIMIENTO.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_MOVIMIENTO.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_MOVIMIENTO.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_solicitudes_compra()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_SOLCOMPRAS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_sol_compras.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_SOLCOMPRAS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_SOLCOMPRAS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_SOLCOMPRAS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_bajas()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_BAJAS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_bajas.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_BAJAS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_BAJAS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_BAJAS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub


    Private Sub cargar_csv_traslados()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_TRASLADOS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_traslados.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_TRASLADOS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_TRASLADOS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_TRASLADOS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_cuentasxpagar_movimiento()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_CUENTASXPAGAR.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_cuentas.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_CUENTASXPAGAR.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_CUENTASXPAGAR.NewRow

                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                    If MiFila.Item(i) = "CON" Then
                        OBJTABLE_CUENTASXPAGAR.Rows.Add(MiFila)
                    Else
                    End If
                Next
            End While
            'Cerramos el reader
            miReader.Close()

        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_cuentasxpagar()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_CUENTASXPAGAR.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_cuentas.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_CUENTASXPAGAR.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_CUENTASXPAGAR.NewRow

                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                    If MiFila.Item(i) = "CXP" Then
                        OBJTABLE_CUENTASXPAGAR.Rows.Add(MiFila)
                    Else
                    End If
                Next
            End While
            'Cerramos el reader
            miReader.Close()

        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_carnicos()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_CARNICOS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_excel_carnicos.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_CARNICOS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_CARNICOS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_CARNICOS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_precios()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_PRECIOS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_excel_precios.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_PRECIOS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_PRECIOS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_PRECIOS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_pres_vend()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_PRES_VEND.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_excel_pres_vend.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_PRES_VEND.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_PRES_VEND.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_PRES_VEND.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_pres_jef()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_PRES_JEF.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_excel_pres_jef.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_PRES_JEF.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_PRES_JEF.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_PRES_JEF.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_bancolombia()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_BANCOLOMBIA.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_excel_bancolombia.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_BANCOLOMBIA.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_BANCOLOMBIA.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_BANCOLOMBIA.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_bancobogota()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_BOGOTA.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_excel_bogota.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_BOGOTA.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_BOGOTA.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_BOGOTA.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_items()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_ITEMS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_items.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_ITEMS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_ITEMS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_ITEMS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_act_items()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_ACT_ITEMS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_act_items.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_ACT_ITEMS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_ACT_ITEMS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_ACT_ITEMS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub cargar_csv_clasitems()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_CLASITEMS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_clasitems.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_CLASITEMS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_CLASITEMS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_CLASITEMS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub


    Private Sub cargar_csv_inv()

        'declaramos la Tabla donde añadiremos los datos y la fila correspondiente

        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Erase fieldValues
        OBJTABLE_MOV_INVENTARIOS.Reset()
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(txt_csv_inv.Text)
            fieldValues = miReader.ReadLine().Split(",")
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                OBJTABLE_MOV_INVENTARIOS.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(",")
                MiFila = OBJTABLE_MOV_INVENTARIOS.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                OBJTABLE_MOV_INVENTARIOS.Rows.Add(MiFila)
            End While
            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
        End Try

    End Sub

    Private Sub btn_plano_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog1.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_archivoexcel.Text = OpenFileDialog1.FileName
        filePath = txt_archivoexcel.Text
        ' FileOpen(1, filePath, OpenMode.Output)
        If OpenFileDialog1.FileName = "OpenFileDialog1" Then
            txt_archivoexcel.Text = ""
        End If
    End Sub

    Private Sub btn_seleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_seleccionar.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano.Text = SaveFileDialog1.FileName
        filePath = txt_plano.Text
    End Sub

    Private Sub btn_limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar.Click

        ''SE LIMPIAN CAJAS DE TEXTO

        txt_archivoexcel.Text = ""
        txt_plano.Text = ""

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub txt_tip_doc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tip_doc.KeyPress

        ''SE CONVIERTEN CARACTERES DE CAJA DE TEXTO EN MAYUSCULA

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_excel_activos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_activos.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_archivo_excel_activos.Text = OpenFileDialog1.FileName
        filePath = txt_archivo_excel_activos.Text
        ' FileOpen(1, filePath, OpenMode.Output)
        If OpenFileDialog1.FileName = "OpenFileDialog2" Then
            txt_archivo_excel_activos.Text = ""
        End If
    End Sub

    Private Sub btn_plano_activos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_activos.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_archivo_plano_activos.Text = SaveFileDialog1.FileName
        filePath = txt_archivo_plano_activos.Text
    End Sub

    Private Sub btn_limpiar_activos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_activos.Click

        ''SE LIMPIAN CAJAS DE TEXTO

        txt_archivo_excel_activos.Text = ""
        txt_archivo_plano_activos.Text = ""

    End Sub

    Private Sub btn_generar_activos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_activos.Click

        If txt_archivo_excel_activos.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_archivo_excel_activos.Focus()
            Exit Sub
        End If

        If txt_archivo_plano_activos.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_archivo_plano_activos.Focus()
            Exit Sub
        End If

        Generar_plano_activos()

    End Sub

    ''' <summary>
    ''' JAIROLAG - Recuperar el nombre del primer libro
    ''' </summary>
    ''' <param name="rutaLibro"></param>
    ''' <remarks></remarks>
    Function Hojaslibro(ByVal rutaLibro As String) As String
        Dim libro As String
        Dim xlApp As New Excel.Application ' Aplicación Excel
        Dim wb As Excel.Workbook            ' Libro de trabajo

        ' Abrimos el libro de trabajo.
        '
        wb = xlApp.Workbooks.Open(Filename:=rutaLibro)

        ' Recorrermos la colección de hojas de cálculo
        Dim valoresCombo As New System.Collections.Generic.Dictionary(Of Object, Object)

        For Each sheet As Excel.Worksheet In wb.Worksheets
            libro = sheet.Name
        Next

        ' Cerramos el libro de trabajo.
        '
        wb.Close()
        wb = Nothing

        ' Cerramos Excel.
        '
        xlApp.Quit()
        xlApp = Nothing

        Return libro
    End Function
    ''' <summary>
    ''' JAIROLAG - metodo que lee la informacion del excel y lo devuelve en datatable
    ''' </summary>
    ''' <param name="fileName"></param>
    ''' <param name="sheetName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetDataExcel(
 ByVal fileName As String, ByVal sheetName As String) As DataTable

        ' Comprobamos los parámetros.
        '
        If ((String.IsNullOrEmpty(fileName)) OrElse
          (String.IsNullOrEmpty(sheetName))) Then _
          Throw New ArgumentNullException()

        Try
            Dim extension As String = IO.Path.GetExtension(fileName)

            Dim connString As String = "Data Source=" & fileName

            If (extension = ".xls") Then
                connString &= ";Provider=Microsoft.Jet.OLEDB.4.0;" &
                       "Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"

            ElseIf (extension = ".xlsx") Then
                connString &= ";Provider=Microsoft.ACE.OLEDB.12.0;" &
                       "Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1'"
            Else
                Throw New ArgumentException(
                  "La extensión " & extension & " del archivo no está permitida.")
            End If

            Using conexion As New OleDbConnection(connString)

                Dim sql As String = "SELECT * FROM [" & sheetName & "$]"
                Dim adaptador As New OleDbDataAdapter(sql, conexion)

                Dim dt As New DataTable("Excel")

                adaptador.Fill(dt)

                Return dt

            End Using

        Catch ex As Exception
            Throw

        End Try

    End Function


    Public Sub Generar_plano_activos()



        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        filePath2 = txt_archivo_plano_activos.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath2)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_ACTIVOS.Rows.Clear()
                System.IO.File.Delete(filePath2)
                Try

                    FileOpen(1, filePath2, OpenMode.Output)
                    line = line & PadL(Trim("000000100000001" & variable_centro_operativo), 18, " ")
                    PrintLine(1, line)
                    txt_archivo_excel_activos.Text = OpenFileDialog1.FileName
                    'cargar_csv_activos()
                    ''JAIROLAG - se modifica para que realice el cargue por excel
                    OBJTABLE_ACTIVOS = GetDataExcel(txt_archivo_excel_activos.Text, Hojaslibro(txt_archivo_excel_activos.Text))
                    Me.Label1.Text = "1"
                    Dim r, codigo, referencia, descripcion, descripcion_corta, tipo_act, centro_operacion, centro_costos, tercero, valor_adquisicion, periodo, salvamento
                    Dim fecha_ok, fecha_compra As String



                    For j As Integer = 0 To OBJTABLE_ACTIVOS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        'PrintLine(1, line)
                        line = r & PadL(Trim("0262"), 4, " ")
                        line = line & PadL("", 2, "0")
                        line = line & PadL("03", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL("", 1, "0")

                        codigo = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(0).ToString)
                        codigo = codigo.PadLeft(9, CChar("0"))
                        line = line & PadL(Trim(codigo), 9, "0")

                        referencia = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(1).ToString)
                        line = line & PadLR(Trim(referencia), 20, " ")

                        'descripcion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(2).ToString)
                        'line = line & PadLR(Trim(descripcion), 40, " ")

                        descripcion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(2).ToString)
                        Dim descrip As String = Mid(descripcion, 1, 40)
                        line = line & PadLR(Trim(descrip), 40, " ")

                        'descripcion_corta = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(3).ToString)
                        'line = line & PadLR(Trim(descripcion_corta), 20, " ")

                        descripcion_corta = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(3).ToString)
                        Dim descrip_corta As String = Mid(descripcion_corta, 1, 20)
                        line = line & PadLR(Trim(descrip_corta), 20, " ")

                        tipo_act = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(4).ToString)
                        line = line & PadLR(Trim(tipo_act), 10, " ")

                        centro_operacion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(5).ToString)
                        line = line & PadL(Trim(centro_operacion), 3, " ")

                        ' line = line & PadL("199", 3, " ")
                        line = line & PadLR("99", 20, " ")
                        centro_costos = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(6).ToString)
                        line = line & PadLR(Trim(centro_costos), 15, " ")

                        tercero = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(7).ToString)
                        line = line & PadLR(Trim(tercero), 15, " ")



                        ' line = line & PadL("100", 3, " ")

                        line = line & PadL("1", 1, "0")

                        Dim Indicador_ajustable
                        Indicador_ajustable = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(19).ToString)
                        line = line & PadL(Trim(Indicador_ajustable), 1, "0")

                        line = line & PadL("0", 1, "0")

                        line = line & PadL("", 150, " ")
                        line = line & PadL("00000001", 8, " ")
                        'fecha_compra = line & PadLR(fecha_compra, 6, " ")
                        fecha_compra = OBJTABLE_ACTIVOS.Rows(j).Item(8).ToString
                        fecha_ok = CDate(fecha_compra).ToString("yyyyMMdd")
                        line = line & PadLR(fecha_ok, 8, " ")



                        'Dim val_valor_adquisicion
                        valor_adquisicion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(9).ToString)
                        If valor_adquisicion = "" Then
                            line = line & PadL("000000000000000.0000", 20, "")
                        Else
                            valor_adquisicion = Convert.ToDecimal(valor_adquisicion).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor_adquisicion, ",", "")
                            line = line & PadL(Trim(val_valor), 20, "0")
                        End If


                        'valor_adquisicion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(9).ToString)
                        'valor_adquisicion = Convert.ToDecimal(valor_adquisicion).ToString("N4")
                        'Dim val_adquisicion As String
                        'val_adquisicion = Replace(valor_adquisicion, ",", "")
                        'line = line & PadL(Trim(val_adquisicion), 20, "0")


                        line = line & PadLR("01", 2, " ")
                        'line = line & PadLR("0", 1, "0")
                        'line = line & PadLR("1", 1, "0")

                        periodo = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(10).ToString)
                        line = line & PadL(Trim(periodo), 4, "0")

                        line = line & PadLR("", 15, "0")
                        line = line & PadLR(".0000", 5, " ")

                        'salvamento = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(17).ToString)
                        'salvamento = Convert.ToDecimal(salvamento).ToString("N4")
                        'Dim val_salvamento As String
                        'val_salvamento = Replace(salvamento, ",", "")
                        'line = line & PadL(Trim(val_salvamento), 20, "0")


                        salvamento = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(17).ToString)
                        If salvamento = "" Then
                            line = line & PadL("000000000000000.0000", 20, "")
                        Else
                            salvamento = Convert.ToDecimal(salvamento).ToString("N4")
                            Dim val_salvamento As String
                            val_salvamento = Replace(salvamento, ",", "")
                            line = line & PadL(Trim(val_salvamento), 20, "0")
                        End If



                        line = line & PadLR("000.000000", 10, " ")

                        Dim proveedor, sucursal, dcto_ref, observaciones

                        'proveedor = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(12).ToString)
                        'line = line & PadL(Trim(proveedor), 15, " ")jj

                        proveedor = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(12).ToString)
                        Dim val_proveedor As String = Mid(proveedor, 1, 15)
                        line = line & PadLR(Trim(val_proveedor), 15, " ")

                        sucursal = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(13).ToString)
                        line = line & PadLR(Trim(sucursal), 3, " ")

                        'dcto_ref = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(14).ToString)
                        'line = line & PadL(Trim(dcto_ref), 15, " ")

                        dcto_ref = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(14).ToString)
                        Dim val_dcto_ref As String = Mid(dcto_ref, 1, 15)
                        line = line & PadLR(Trim(val_dcto_ref), 15, " ")

                        'observaciones = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(18).ToString)
                        'line = line & PadL(Trim(observaciones), 100, " ")

                        observaciones = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(18).ToString)
                        Dim val_observaciones As String = Mid(observaciones, 1, 100)
                        line = line & PadLR(Trim(val_observaciones), 100, " ")


                        Dim Val_adq_niif
                        Val_adq_niif = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(20).ToString)
                        If Val_adq_niif = "" Then
                            line = line & PadL("000000000000000.0000", 20, "")
                        Else
                            Val_adq_niif = Convert.ToDecimal(Val_adq_niif).ToString("N4")
                            Dim val_Val_adq_niif As String
                            val_Val_adq_niif = Replace(Val_adq_niif, ",", "")
                            line = line & PadL(Trim(val_Val_adq_niif), 20, "0")
                        End If



                        line = line & PadLR("1", 1, " ")

                        Dim periodo_depreciar_niif
                        periodo_depreciar_niif = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(11).ToString)
                        line = line & PadL(Trim(periodo_depreciar_niif), 4, "0")



                        line = line & PadLR("000000000000000.0000", 20, " ")


                        Dim salvamento_NIIF
                        salvamento_NIIF = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(21).ToString)
                        If salvamento_NIIF = "" Then
                            line = line & PadL("000000000000000.0000", 20, "")
                        Else
                            salvamento_NIIF = Convert.ToDecimal(salvamento_NIIF).ToString("N4")
                            Dim val_salvamento As String
                            val_salvamento = Replace(salvamento_NIIF, ",", "")
                            line = line & PadL(Trim(val_salvamento), 20, "0")
                        End If

                        line = line & PadLR("000.000000", 10, " ")



                        PrintLine(1, line)

                    Next

                    'PrintLine(1, line)
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    OBJTABLE_ACTIVOS.Clear()
                    sCmd = "INSERT INTO    al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_archivo_excel_activos.Text & "', '" & txt_archivo_plano_activos.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_archivo_plano_activos.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try
                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath2, OpenMode.Output)
                line = line & PadL(Trim("000000100000001" & variable_centro_operativo), 18, " ")
                PrintLine(1, line)
                txt_archivo_excel_activos.Text = OpenFileDialog1.FileName
                ''JAIROLAG - se modifica para que realice el cargue por excel
                OBJTABLE_ACTIVOS = GetDataExcel(txt_archivo_excel_activos.Text, Hojaslibro(txt_archivo_excel_activos.Text))
                Me.Label1.Text = "1"
                Dim r, codigo, referencia, descripcion, descripcion_corta, tipo_act, centro_operacion, centro_costos, tercero, valor_adquisicion, periodo, salvamento
                Dim fecha_ok, fecha_compra As String

                For j As Integer = 0 To OBJTABLE_ACTIVOS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    'PrintLine(1, line)
                    line = r & PadL(Trim("0262"), 4, " ")
                    line = line & PadL("", 2, "0")
                    line = line & PadL("03", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL("", 1, "0")

                    codigo = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(0).ToString)
                    codigo = codigo.PadLeft(9, CChar("0"))
                    line = line & PadL(Trim(codigo), 9, "0")

                    referencia = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(1).ToString)
                    line = line & PadLR(Trim(referencia), 20, " ")

                    'descripcion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(2).ToString)
                    'line = line & PadLR(Trim(descripcion), 40, " ")

                    descripcion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(2).ToString)
                    Dim descrip As String = Mid(descripcion, 1, 40)
                    line = line & PadLR(Trim(descrip), 40, " ")

                    'descripcion_corta = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(3).ToString)
                    'line = line & PadLR(Trim(descripcion_corta), 20, " ")

                    descripcion_corta = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(3).ToString)
                    Dim descrip_corta As String = Mid(descripcion_corta, 1, 20)
                    line = line & PadLR(Trim(descrip_corta), 20, " ")

                    tipo_act = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(4).ToString)
                    line = line & PadLR(Trim(tipo_act), 10, " ")

                    centro_operacion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(5).ToString)
                    line = line & PadL(Trim(centro_operacion), 3, " ")

                    ' line = line & PadL("199", 3, " ")
                    line = line & PadLR("99", 20, " ")
                    centro_costos = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(6).ToString)
                    line = line & PadLR(Trim(centro_costos), 15, " ")

                    tercero = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(7).ToString)
                    line = line & PadLR(Trim(tercero), 15, " ")



                    ' line = line & PadL("100", 3, " ")

                    line = line & PadL("1", 1, "0")

                    Dim Indicador_ajustable
                    Indicador_ajustable = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(19).ToString)
                    line = line & PadL(Trim(Indicador_ajustable), 1, "0")

                    line = line & PadL("0", 1, "0")

                    line = line & PadL("", 150, " ")
                    line = line & PadL("00000001", 8, " ")
                    'fecha_compra = line & PadLR(fecha_compra, 6, " ")
                    fecha_compra = OBJTABLE_ACTIVOS.Rows(j).Item(8).ToString
                    fecha_ok = CDate(fecha_compra).ToString("yyyyMMdd")
                    line = line & PadLR(fecha_ok, 8, " ")



                    'Dim val_valor_adquisicion
                    valor_adquisicion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(9).ToString)
                    If valor_adquisicion = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else
                        valor_adquisicion = Convert.ToDecimal(valor_adquisicion).ToString("N4")
                        Dim val_valor As String
                        val_valor = Replace(valor_adquisicion, ",", "")
                        line = line & PadL(Trim(val_valor), 20, "0")
                    End If


                    'valor_adquisicion = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(9).ToString)
                    'valor_adquisicion = Convert.ToDecimal(valor_adquisicion).ToString("N4")
                    'Dim val_adquisicion As String
                    'val_adquisicion = Replace(valor_adquisicion, ",", "")
                    'line = line & PadL(Trim(val_adquisicion), 20, "0")


                    line = line & PadLR("01", 2, " ")
                    'line = line & PadLR("0", 1, "0")
                    'line = line & PadLR("1", 1, "0")

                    periodo = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(10).ToString)
                    line = line & PadL(Trim(periodo), 4, "0")

                    line = line & PadLR("", 15, "0")
                    line = line & PadLR(".0000", 5, " ")

                    'salvamento = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(17).ToString)
                    'salvamento = Convert.ToDecimal(salvamento).ToString("N4")
                    'Dim val_salvamento As String
                    'val_salvamento = Replace(salvamento, ",", "")
                    'line = line & PadL(Trim(val_salvamento), 20, "0")


                    salvamento = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(17).ToString)
                    If salvamento = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else
                        salvamento = Convert.ToDecimal(salvamento).ToString("N4")
                        Dim val_salvamento As String
                        val_salvamento = Replace(salvamento, ",", "")
                        line = line & PadL(Trim(val_salvamento), 20, "0")
                    End If



                    line = line & PadLR("000.000000", 10, " ")

                    Dim proveedor, sucursal, dcto_ref, observaciones

                    'proveedor = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(12).ToString)
                    'line = line & PadL(Trim(proveedor), 15, " ")jj

                    proveedor = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(12).ToString)
                    Dim val_proveedor As String = Mid(proveedor, 1, 15)
                    line = line & PadLR(Trim(val_proveedor), 15, " ")

                    sucursal = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(13).ToString)
                    line = line & PadLR(Trim(sucursal), 3, " ")

                    'dcto_ref = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(14).ToString)
                    'line = line & PadL(Trim(dcto_ref), 15, " ")

                    dcto_ref = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(14).ToString)
                    Dim val_dcto_ref As String = Mid(dcto_ref, 1, 15)
                    line = line & PadLR(Trim(val_dcto_ref), 15, " ")

                    'observaciones = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(18).ToString)
                    'line = line & PadL(Trim(observaciones), 100, " ")

                    observaciones = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(18).ToString)
                    Dim val_observaciones As String = Mid(observaciones, 1, 100)
                    line = line & PadLR(Trim(val_observaciones), 100, " ")


                    Dim Val_adq_niif
                    Val_adq_niif = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(20).ToString)
                    If Val_adq_niif = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else
                        Val_adq_niif = Convert.ToDecimal(Val_adq_niif).ToString("N4")
                        Dim val_Val_adq_niif As String
                        val_Val_adq_niif = Replace(Val_adq_niif, ",", "")
                        line = line & PadL(Trim(val_Val_adq_niif), 20, "0")
                    End If



                    line = line & PadLR("1", 1, " ")

                    Dim periodo_depreciar_niif
                    periodo_depreciar_niif = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(11).ToString)
                    line = line & PadL(Trim(periodo_depreciar_niif), 4, "0")



                    line = line & PadLR("000000000000000.0000", 20, " ")

                    Dim salvamento_NIIF
                    salvamento_NIIF = Trim(OBJTABLE_ACTIVOS.Rows(j).Item(21).ToString)
                    If salvamento_NIIF = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else
                        salvamento_NIIF = Convert.ToDecimal(salvamento_NIIF).ToString("N4")
                        Dim val_salvamento As String
                        val_salvamento = Replace(salvamento_NIIF, ",", "")
                        line = line & PadL(Trim(val_salvamento), 20, "0")
                    End If

                    ''  line = line & PadL(Trim(val_salvamento), 20, "0")

                    line = line & PadLR("000.000000", 10, " ")



                    PrintLine(1, line)

                Next

                'PrintLine(1, line)
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                OBJTABLE_ACTIVOS.Clear()
                sCmd = "INSERT INTO    al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_archivo_excel_activos.Text & "', '" & txt_archivo_plano_activos.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_archivo_plano_activos.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub btn_salir_activos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_activos.Click
        End
    End Sub

    Private Sub txt_tip_doc_mov_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tip_doc_mov.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_salir_movimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_movimiento.Click
        End
    End Sub

    Private Sub txt_co_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_co.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_limpiar_movimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_movimiento.Click

        txt_co.Text = ""
        txt_tip_doc_mov.Text = ""
        txtnotas.Text = ""
        txt_excel_movimiento.Text = ""
        txt_plano_mov.Text = ""

    End Sub

    Private Sub btn_excel_movimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_movimiento.Click

        ''SE SELECCIONA ARCHIVO CSV

        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_excel_movimiento.Text = OpenFileDialog1.FileName
        filePath3 = txt_excel_movimiento.Text
        If OpenFileDialog1.FileName = "OpenFileDialog3" Then
            txt_excel_movimiento.Text = ""
        End If

    End Sub

    Private Sub btn_plano_movimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_movimiento.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_mov.Text = SaveFileDialog1.FileName
        filePath3 = txt_plano_mov.Text
    End Sub

    Private Sub btn_generar_movimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_movimiento.Click

        If txt_co.Text = "" Then
            MsgBox("Ingrese el centro operativo", MsgBoxStyle.Critical)
            txt_co.Focus()
            Exit Sub
        End If

        If txt_tip_doc_mov.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tip_doc_mov.Focus()
            Exit Sub
        End If

        If txtnotas.Text = "" Then
            MsgBox("Por favor ingrese una Nota valida para el encabezado", MsgBoxStyle.Critical)
            txtnotas.Focus()
            Exit Sub
        End If

        If txt_excel_movimiento.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_excel_movimiento.Focus()
            Exit Sub
        End If


        If txt_plano_mov.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_mov.Focus()
            Exit Sub
        End If

        Generar_plano_movimientos()

    End Sub

    Public Sub Generar_plano_movimientos()

        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath3 = txt_plano_mov.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath3)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_MOVIMIENTO.Rows.Clear()
                System.IO.File.Delete(filePath3)
                Dim fecha_doc
                Try
                    FileOpen(1, filePath3, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    PrintLine(1, line)
                    line = fijo2 & PadL("0350", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("01", 2, " ")
                    line = line & PadL(variable_centro_operativo, 3, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL(Trim(txt_co.Text), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_mov.Text), 3, " ")
                    line = line & PadL("", 8, "0")

                    ' fecha_compra = OBJTABLE_ACTIVOS.Rows(j).Item(7).ToString
                    fecha_doc = CDate(dtp_fecha.Text).ToString("yyyyMMdd")
                    line = line & PadL(fecha_doc, 8, " ")
                    line = line & PadLR(Trim(variable_NIT), 15, " ")
                    line = line & PadL("000", 3, " ")
                    line = line & PadL("30", 2, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadLR(Trim(txtnotas.Text), 255, " ")

                    txt_excel_movimiento.Text = OpenFileDialog1.FileName
                    'cargar_csv_movimiento()
                    OBJTABLE_MOVIMIENTO = GetDataExcel(txt_excel_movimiento.Text, Hojaslibro(txt_excel_movimiento.Text))
                    Me.Label1.Text = "2"
                    Me.Label2.Text = ""
                    Dim r

                    For j As Integer = 0 To OBJTABLE_MOVIMIENTO.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = r & PadL("0351", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("01", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL(OBJTABLE_MOVIMIENTO.Rows(j).Item(0).ToString, 3, " ")
                        line = line & PadL(Trim(txt_tip_doc_mov.Text), 3, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(1).ToString), 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(2).ToString), 15, " ")
                        line = line & PadL(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(0).ToString), 3, " ")
                        line = line & PadL("99", 2, "0")
                        line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(3).ToString), 15, " ")
                        'line = line & PadL("", 10, " ")
                        line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(10).ToString), 10, " ")

                        Dim debito
                        debito = OBJTABLE_MOVIMIENTO.Rows(j).Item(4).ToString
                        If debito = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If debito < 0 Then
                                debito = "-" & debito
                                debito = Convert.ToDecimal(debito).ToString("N4")
                                Dim val_debito As String
                                val_debito = Replace(debito, ",", "")
                                line = line & "-" & PadL(RTrim(val_debito), 20, "0")
                            Else
                                debito = "+" & debito
                                debito = Convert.ToDecimal(debito).ToString("N4")
                                Dim val_debito As String
                                val_debito = Replace(debito, ",", "")
                                line = line & "+" & PadL(RTrim(val_debito), 20, "0")
                            End If

                        End If

                        Dim credito
                        credito = OBJTABLE_MOVIMIENTO.Rows(j).Item(5).ToString
                        If credito = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If credito < 0 Then
                                credito = "-" & credito
                                credito = Convert.ToDecimal(credito).ToString("N4")
                                Dim val_credito As String
                                val_credito = Replace(credito, ",", "")
                                line = line & "-" & PadL(RTrim(val_credito), 20, "0")
                            Else
                                credito = "+" & credito
                                credito = Convert.ToDecimal(credito).ToString("N4")
                                Dim val_credito As String
                                val_credito = Replace(credito, ",", "")
                                line = line & "+" & PadL(RTrim(val_credito), 20, "0")
                            End If

                        End If


                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")

                        Dim base_gravable
                        base_gravable = OBJTABLE_MOVIMIENTO.Rows(j).Item(7).ToString
                        If base_gravable = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else
                            If base_gravable < 0 Then
                                base_gravable = "-" & base_gravable
                                base_gravable = Convert.ToDecimal(base_gravable).ToString("N4")
                                Dim val_base_gravable As String
                                val_base_gravable = Replace(base_gravable, ",", "")
                                line = line & "-" & PadL(RTrim(val_base_gravable), 20, "0")
                            Else
                                base_gravable = "+" & base_gravable
                                base_gravable = Convert.ToDecimal(base_gravable).ToString("N4")
                                Dim val_base_gravable As String
                                val_base_gravable = Replace(base_gravable, ",", "")
                                line = line & "+" & PadL(RTrim(val_base_gravable), 20, "0")
                            End If
                        End If

                        'line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        'line = line & PadL("", 2, " ")
                        'line = line & PadL("", 8, "0")

                        line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(8).ToString), 2, " ")
                        line = line & PadL(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(9).ToString), 8, "0")
                        line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(6).ToString), 255, " ")
                    Next

                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora


                    OBJTABLE_MOVIMIENTO.Clear()
                    sCmd = "INSERT INTO    al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_movimiento.Text & "', '" & txt_plano_mov.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_mov.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Dim fecha_doc

            Try
                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath3, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                PrintLine(1, line)
                line = fijo2 & PadL("0350", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("01", 2, " ")
                line = line & PadL(variable_centro_operativo, 3, " ")
                line = line & PadL("1", 1, " ")
                line = line & PadL(Trim(txt_co.Text), 3, " ")
                line = line & PadL(Trim(txt_tip_doc_mov.Text), 3, " ")
                line = line & PadL("", 8, "0")

                ' fecha_compra = OBJTABLE_ACTIVOS.Rows(j).Item(7).ToString
                fecha_doc = CDate(dtp_fecha.Text).ToString("yyyyMMdd")
                line = line & PadL(fecha_doc, 8, " ")
                line = line & PadLR(Trim(variable_NIT), 15, " ")
                line = line & PadL("000", 3, " ")
                line = line & PadL("30", 2, " ")
                line = line & PadL("0", 1, " ")
                line = line & PadL("0", 1, " ")
                line = line & PadLR(Trim(txtnotas.Text), 255, " ")

                txt_excel_movimiento.Text = OpenFileDialog1.FileName
                'cargar_csv_movimiento()
                OBJTABLE_MOVIMIENTO = GetDataExcel(txt_excel_movimiento.Text, Hojaslibro(txt_excel_movimiento.Text))
                Me.Label1.Text = "2"
                Me.Label2.Text = ""
                Dim r



                For j As Integer = 0 To OBJTABLE_MOVIMIENTO.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = r & PadL("0351", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("01", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(0).ToString), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_mov.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(1).ToString), 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(2).ToString), 15, " ")
                    line = line & PadL(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(0).ToString), 3, " ")
                    line = line & PadL("99", 2, "0")
                    line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(3).ToString), 15, " ")

                    'line = line & PadL("", 10, " ")
                    line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(10).ToString), 10, " ")

                    Dim debito
                    debito = OBJTABLE_MOVIMIENTO.Rows(j).Item(4).ToString
                    If debito = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If debito < 0 Then
                            debito = "-" & debito
                            debito = Convert.ToDecimal(debito).ToString("N4")
                            Dim val_debito As String
                            val_debito = Replace(debito, ",", "")
                            line = line & "-" & PadL(RTrim(val_debito), 20, "0")
                        Else
                            debito = "+" & debito
                            debito = Convert.ToDecimal(debito).ToString("N4")
                            Dim val_debito As String
                            val_debito = Replace(debito, ",", "")
                            line = line & "+" & PadL(RTrim(val_debito), 20, "0")
                        End If

                    End If

                    Dim credito
                    credito = OBJTABLE_MOVIMIENTO.Rows(j).Item(5).ToString
                    If credito = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If credito < 0 Then
                            credito = "-" & credito
                            credito = Convert.ToDecimal(credito).ToString("N4")
                            Dim val_credito As String
                            val_credito = Replace(credito, ",", "")
                            line = line & "-" & PadL(RTrim(val_credito), 20, "0")
                        Else
                            credito = "+" & credito
                            credito = Convert.ToDecimal(credito).ToString("N4")
                            Dim val_credito As String
                            val_credito = Replace(credito, ",", "")
                            line = line & "+" & PadL(RTrim(val_credito), 20, "0")
                        End If

                    End If


                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    'line = line & PadL("+" & "000000000000000.0000", 20, " ")

                    Dim base_gravable
                    base_gravable = OBJTABLE_MOVIMIENTO.Rows(j).Item(7).ToString
                    If base_gravable = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else
                        If base_gravable < 0 Then
                            base_gravable = "-" & base_gravable
                            base_gravable = Convert.ToDecimal(base_gravable).ToString("N4")
                            Dim val_base_gravable As String
                            val_base_gravable = Replace(base_gravable, ",", "")
                            line = line & "-" & PadL(RTrim(val_base_gravable), 20, "0")
                        Else
                            base_gravable = "+" & base_gravable
                            base_gravable = Convert.ToDecimal(base_gravable).ToString("N4")
                            Dim val_base_gravable As String
                            val_base_gravable = Replace(base_gravable, ",", "")
                            line = line & "+" & PadL(RTrim(val_base_gravable), 20, "0")
                        End If
                    End If

                    'line = line & PadL("", 2, " ")
                    'line = line & PadL("", 8, "0")

                    line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(8).ToString), 2, " ")
                    line = line & PadL(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(9).ToString), 8, "0")
                    line = line & PadLR(Trim(OBJTABLE_MOVIMIENTO.Rows(j).Item(6).ToString), 255, " ")

                Next

                PrintLine(1, line)
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                OBJTABLE_MOVIMIENTO.Clear()
                sCmd = "INSERT INTO    al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_movimiento.Text & "', '" & txt_plano_mov.Text & "', getdate() , '" & lSt_CodUsuario & "'  )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_mov.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub txtnotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub btn_carnicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carnicos.Click

        If txt_co_car.Text = "" Then
            MsgBox("Ingrese el centro operativo", MsgBoxStyle.Critical)
            txt_co_car.Focus()
            Exit Sub
        End If

        If txt_tipdoc_car.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tipdoc_car.Focus()
            Exit Sub
        End If

        If txt_cuentacontab_car.Text = "" Then
            MsgBox("Ingrese la cuenta contable", MsgBoxStyle.Critical)
            txt_cuentacontab_car.Focus()
            Exit Sub
        End If

        If txt_cuentaxcobrarcar.Text = "" Then
            MsgBox("Ingrese la cuenta por cobrar", MsgBoxStyle.Critical)
            txt_cuentaxcobrarcar.Focus()
            Exit Sub
        End If


        If txt_notas_car.Text = "" Then
            MsgBox("Por favor ingrese una Nota valida para el encabezado", MsgBoxStyle.Critical)
            txt_notas_car.Focus()
            Exit Sub
        End If

        If txt_excel_carnicos.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_excel_carnicos.Focus()
            Exit Sub
        End If


        If txt_plano_carnicos.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_carnicos.Focus()
            Exit Sub
        End If

        Generar_plano_carnicos()

    End Sub

    Private Sub Generar_plano_carnicos()

        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath4 = txt_plano_carnicos.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath4)

        If exists Then

            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_CARNICOS.Rows.Clear()
                System.IO.File.Delete(filePath4)
                Dim fecha_doc
                Try
                    FileOpen(1, filePath4, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    PrintLine(1, line)
                    line = ""

                    line = fijo2 & PadL("0350", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("01", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL(Trim(txt_co_car.Text), 3, " ")
                    line = line & PadL(Trim(txt_tipdoc_car.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    fecha_doc = CDate(Dtp_fecha_car.Text).ToString("yyyyMMdd")
                    line = line & PadL(fecha_doc, 8, " ")
                    line = line & PadLR(Trim(variable_NIT), 15, " ")
                    line = line & PadL("000", 3, " ")
                    line = line & PadL("30", 2, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadLR(Trim(txt_notas_car.Text), 255, " ")

                    txt_excel_carnicos.Text = OpenFileDialog1.FileName
                    'cargar_csv_carnicos()
                    OBJTABLE_CARNICOS = GetDataExcel(txt_excel_carnicos.Text, Hojaslibro(txt_excel_carnicos.Text))
                    Me.Label1.Text = "2"
                    Me.Label2.Text = ""
                    Dim r


                    ''Se graba cuentas x cobrar

                    For j As Integer = 0 To OBJTABLE_CARNICOS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("0351", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("01", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL(Trim(txt_co_car.Text), 3, " ")
                        line = line & PadL(Trim(txt_tipdoc_car.Text), 3, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadLR(Trim(txt_cuentacontab_car.Text), 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_CARNICOS.Rows(j).Item(1).ToString), 15, " ")
                        line = line & PadL(Trim(txt_co_car.Text), 3, " ")
                        line = line & PadL("99", 2, "0")
                        line = line & PadL("", 15, " ")
                        line = line & PadL("", 10, " ")


                        Dim valor
                        valor = OBJTABLE_CARNICOS.Rows(j).Item(8).ToString
                        If valor = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If valor < 0 Then
                                valor = "-" & valor
                                valor = Convert.ToDecimal(valor).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor, ",", "")
                                line = line & "-" & PadL(Trim(val_valor), 20, "0")
                            Else
                                valor = "+" & valor
                                valor = Convert.ToDecimal(valor).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor, ",", "")
                                line = line & "+" & PadL(Trim(val_valor), 20, "0")
                            End If

                        End If

                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("", 2, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadL("", 255, " ")

                    Next


                    ' Se graba cuenta contable

                    For j As Integer = 0 To OBJTABLE_CARNICOS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("0351", 4, " ")
                        line = line & PadL("01", 2, " ")
                        line = line & PadL("01", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")


                        line = line & PadL(Trim(txt_co_car.Text), 3, " ")

                        line = line & PadL(Trim(txt_tipdoc_car.Text), 3, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadLR(Trim(txt_cuentaxcobrarcar.Text), 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_CARNICOS.Rows(j).Item(1).ToString), 15, " ")

                        line = line & PadLR(Trim(OBJTABLE_CARNICOS.Rows(j).Item(3).ToString), 3, " ")
                        'line = line & PadL(Trim(txt_co_car.Text), 3, "")
                        line = line & PadL("99", 2, "0")
                        line = line & PadL("", 15, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")

                        Dim valor
                        valor = OBJTABLE_CARNICOS.Rows(j).Item(8).ToString
                        If valor = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If valor < 0 Then
                                valor = "-" & valor
                                valor = Convert.ToDecimal(valor).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor, ",", "")
                                line = line & "-" & PadL(Trim(val_valor), 20, "0")
                            Else
                                valor = "+" & valor
                                valor = Convert.ToDecimal(valor).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor, ",", "")
                                line = line & "+" & PadL(Trim(val_valor), 20, "0")
                            End If

                        End If

                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("", 255, " ")
                        line = line & PadL(Trim(OBJTABLE_CARNICOS.Rows(j).Item(2).ToString), 3, "0")
                        line = line & PadLR(Trim(OBJTABLE_CARNICOS.Rows(j).Item(6).ToString), 3, " ")
                        line = line & PadL(Trim(OBJTABLE_CARNICOS.Rows(j).Item(7).ToString), 8, "0")
                        line = line & PadL("", 3, "0")

                        Dim fecha_ven, fec As String
                        fec = OBJTABLE_CARNICOS.Rows(j).Item(5).ToString
                        fecha_ven = CDate(fec).ToString("yyyyMMdd")
                        line = line & PadL(fecha_ven, 8, " ")
                        line = line & PadL(fecha_ven, 8, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadLR("500", 15, " ")
                        line = line & PadLR(Trim(txt_notas_car.Text), 255, " ")

                    Next


                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora


                    OBJTABLE_CARNICOS.Clear()
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_carnicos.Text & "', '" & txt_plano_carnicos.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_carnicos.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Dim fecha_doc

            Try

                Me.Cursor = Cursors.WaitCursor
                FileOpen(1, filePath4, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                PrintLine(1, line)
                line = ""
                line = fijo2 & PadL("0350", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("01", 2, " ")
                line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                line = line & PadL("1", 1, " ")
                line = line & PadL(Trim(txt_co_car.Text), 3, " ")
                line = line & PadL(Trim(txt_tipdoc_car.Text), 3, " ")
                line = line & PadL(Trim(""), 8, "0")
                fecha_doc = CDate(Dtp_fecha_car.Text).ToString("yyyyMMdd")
                line = line & PadL(Trim(fecha_doc), 8, " ")
                line = line & PadLR(Trim(variable_NIT), 15, " ") '' REVISAR ACA
                line = line & PadL(Trim("000"), 3, " ")
                line = line & PadL(Trim("30"), 2, " ")
                line = line & PadL(Trim("0"), 1, " ")
                line = line & PadL(Trim("0"), 1, " ")
                line = line & PadLR(Trim(txt_notas_car.Text), 255, " ")

                txt_excel_carnicos.Text = OpenFileDialog1.FileName
                'cargar_csv_carnicos()
                OBJTABLE_CARNICOS = GetDataExcel(txt_excel_carnicos.Text, Hojaslibro(txt_excel_carnicos.Text))
                Me.Label1.Text = "2"
                Me.Label2.Text = ""
                Dim r




                ''Se graba cuentas x cobrar

                For j As Integer = 0 To OBJTABLE_CARNICOS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("0351", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("01", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL(Trim(txt_co_car.Text), 3, " ")
                    line = line & PadL(Trim(txt_tipdoc_car.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadLR(Trim(txt_cuentacontab_car.Text), 20, " ")
                    line = line & PadLR(OBJTABLE_CARNICOS.Rows(j).Item(1).ToString, 15, " ")
                    line = line & PadL(Trim(txt_co_car.Text), 3, " ")
                    line = line & PadL("99", 2, "0")
                    line = line & PadL("", 15, " ")
                    line = line & PadL("", 10, " ")


                    Dim valor
                    valor = OBJTABLE_CARNICOS.Rows(j).Item(8).ToString
                    If valor = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If valor < 0 Then
                            valor = "-" & valor
                            valor = Convert.ToDecimal(valor).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & "-" & PadL(Trim(val_valor), 20, "0")
                        Else
                            valor = "+" & valor
                            valor = Convert.ToDecimal(valor).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & "+" & PadL(Trim(val_valor), 20, "0")
                        End If

                    End If

                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("", 2, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadL("", 255, " ")

                Next


                ' Se graba cuenta contable

                For j As Integer = 0 To OBJTABLE_CARNICOS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("0351", 4, " ")
                    line = line & PadL("01", 2, " ")
                    line = line & PadL("01", 2, " ")
                    line = line & PadL(RTrim(variable_centro_operativo), 3, " ")


                    line = line & PadL(Trim(txt_co_car.Text), 3, " ")

                    line = line & PadL(Trim(txt_tipdoc_car.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadLR(Trim(txt_cuentaxcobrarcar.Text), 20, " ")
                    line = line & PadLR(OBJTABLE_CARNICOS.Rows(j).Item(1).ToString, 15, " ")

                    line = line & PadLR(OBJTABLE_CARNICOS.Rows(j).Item(3).ToString, 3, " ")
                    'line = line & PadL(Trim(txt_co_car.Text), 3, "")
                    line = line & PadL("99", 2, "0")
                    line = line & PadL("", 15, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")

                    Dim valor
                    valor = OBJTABLE_CARNICOS.Rows(j).Item(8).ToString
                    If valor = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If valor < 0 Then
                            valor = "-" & valor
                            valor = Convert.ToDecimal(valor).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & "-" & PadL(Trim(val_valor), 20, "0")
                        Else
                            valor = "+" & valor
                            valor = Convert.ToDecimal(valor).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & "+" & PadL(Trim(val_valor), 20, "0")
                        End If

                    End If

                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("", 255, " ")
                    line = line & PadL(OBJTABLE_CARNICOS.Rows(j).Item(2).ToString, 3, "0")
                    line = line & PadLR(OBJTABLE_CARNICOS.Rows(j).Item(6).ToString, 3, " ")
                    line = line & PadL(OBJTABLE_CARNICOS.Rows(j).Item(7).ToString, 8, "0")
                    line = line & PadL("", 3, "0")

                    Dim fecha_ven, fec As String
                    fec = OBJTABLE_CARNICOS.Rows(j).Item(5).ToString
                    fecha_ven = CDate(fec).ToString("yyyyMMdd")
                    line = line & PadL(fecha_ven, 8, " ")
                    line = line & PadL(fecha_ven, 8, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadLR("500", 15, " ")
                    line = line & PadLR(Trim(txt_notas_car.Text), 255, " ")

                Next


                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora


                OBJTABLE_CARNICOS.Clear()
                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_carnicos.Text & "', '" & txt_plano_carnicos.Text & "', getdate() , '" & lSt_CodUsuario & "'  )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_carnicos.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub btn_excel_carnicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_carnicos.Click

        ''SE SELECCIONA ARCHIVO CSV

        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        'OpenFileDialog4.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.ShowDialog()
        txt_excel_carnicos.Text = OpenFileDialog1.FileName
        filePath4 = txt_excel_carnicos.Text
        If OpenFileDialog1.FileName = "OpenFileDialog4" Then
            txt_excel_carnicos.Text = ""
        End If
    End Sub

    Private Sub btn_plano_carnicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_carnicos.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_carnicos.Text = SaveFileDialog1.FileName
        filePath4 = txt_plano_carnicos.Text
    End Sub

    Private Sub btn_salir_carnicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_carnicos.Click
        End
    End Sub

    Private Sub btn_limpiar_carnicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_carnicos.Click


        txt_co_car.Text = ""
        txt_tipdoc_car.Text = ""
        txt_cuentacontab_car.Text = ""
        txt_cuentaxcobrarcar.Text = ""
        txt_notas_car.Text = ""
        txt_excel_carnicos.Text = ""
        txt_plano_carnicos.Text = ""

    End Sub

    Private Sub txt_cuentacontab_car_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cuentacontab_car.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cuentaxcobrarcar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cuentaxcobrarcar.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_generar_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_precios.Click

        If txt_excel_precios.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_excel_precios.Focus()
            Exit Sub
        End If


        If txt_plano_precios.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_precios.Focus()
            Exit Sub
        End If

        generar_plano_precios()


    End Sub


    Private Sub generar_plano_precios()


        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath5 = txt_plano_precios.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath5)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_PRECIOS.Rows.Clear()
                System.IO.File.Delete(filePath5)
                Try
                    FileOpen(1, filePath5, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    'PrintLine(1, line)
                    ' line = ""
                    txt_excel_precios.Text = OpenFileDialog1.FileName
                    'cargar_csv_precios()

                    OBJTABLE_PRECIOS = GetDataExcel(txt_excel_precios.Text, Hojaslibro(txt_excel_precios.Text))

                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""
                    Dim r

                    For j As Integer = 0 To OBJTABLE_PRECIOS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""

                        line = r & PadL("0126", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("02", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL("1", 1, " ")
                        line = line & PadL(Trim(OBJTABLE_PRECIOS.Rows(j).Item(0).ToString), 3, " ")
                        line = line & PadL("", 7, "0")
                        line = line & PadLR(Trim(OBJTABLE_PRECIOS.Rows(j).Item(1).ToString), 50, " ")
                        line = line & PadL("", 20, " ")
                        line = line & PadL("", 20, " ")
                        line = line & PadL("", 20, " ")
                        Dim fecha_activacion, fecha_act
                        fecha_activacion = OBJTABLE_PRECIOS.Rows(j).Item(4).ToString
                        fecha_act = CDate(fecha_activacion).ToString("yyyyMMdd")
                        line = line & PadL(fecha_act, 8, " ")
                        line = line & PadL("", 8, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadLR(Trim(OBJTABLE_PRECIOS.Rows(j).Item(2).ToString), 4, " ")

                        Dim valor
                        valor = OBJTABLE_PRECIOS.Rows(j).Item(3).ToString
                        If valor = "" Then
                            line = line & PadL("000000000000000.0000", 20, "")
                        Else

                            If valor < 0 Then
                                valor = valor
                                valor = Convert.ToDecimal(valor).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor, ",", "")
                                line = line & PadL(Trim(val_valor), 20, "0")
                            Else
                                valor = valor
                                valor = Convert.ToDecimal(valor).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor, ",", "")
                                line = line & PadL(Trim(val_valor), 20, "0")
                            End If

                        End If



                        Dim valor_precio_min
                        valor_precio_min = OBJTABLE_PRECIOS.Rows(j).Item(5).ToString
                        If valor_precio_min = "" Then
                            line = line & PadL("000000000000000.0000", 20, "")
                        Else

                            If valor_precio_min < 0 Then
                                valor_precio_min = valor_precio_min
                                valor_precio_min = Convert.ToDecimal(valor_precio_min).ToString("N4")
                                Dim val_valor_min As String
                                val_valor_min = Replace(valor_precio_min, ",", "")
                                line = line & PadL(Trim(val_valor_min), 20, "0")
                            Else
                                valor_precio_min = valor_precio_min
                                valor_precio_min = Convert.ToDecimal(valor_precio_min).ToString("N4")
                                Dim val_valor_min As String
                                val_valor_min = Replace(valor_precio_min, ",", "")
                                line = line & PadL(Trim(val_valor_min), 20, "0")
                            End If

                        End If



                        Dim valor_precio_max
                        valor_precio_max = OBJTABLE_PRECIOS.Rows(j).Item(6).ToString
                        If valor_precio_max = "" Then
                            line = line & PadL("000000000000000.0000", 20, "")
                        Else

                            If valor_precio_max < 0 Then
                                valor_precio_max = valor_precio_max
                                valor_precio_max = Convert.ToDecimal(valor_precio_max).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor_precio_max, ",", "")
                                line = line & PadL(Trim(val_valor), 20, "0")
                            Else
                                valor_precio_max = valor_precio_max
                                valor_precio_max = Convert.ToDecimal(valor_precio_max).ToString("N4")
                                Dim val_valor As String
                                val_valor = Replace(valor_precio_max, ",", "")
                                line = line & PadL(Trim(val_valor), 20, "0")
                            End If

                        End If


                        'line = line & PadL("000000000000000.0000", 20, " ")
                        'line = line & PadL("000000000000000.0000", 20, " ")
                        ' line = line & PadL(Trim(OBJTABLE_PRECIOS.Rows(j).Item(5).ToString), 20, "0")
                        'line = line & PadL(Trim(OBJTABLE_PRECIOS.Rows(j).Item(6).ToString), 20, "0")
                        line = line & PadL("000000000000000.0000", 20, " ")

                    Next

                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_precios.Text & "', '" & txt_plano_precios.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)


                    OBJTABLE_PRECIOS.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_precios.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try
                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath5, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                'PrintLine(1, line)
                'line = ""
                txt_excel_precios.Text = OpenFileDialog1.FileName
                'cargar_csv_precios()
                OBJTABLE_PRECIOS = GetDataExcel(txt_excel_precios.Text, Hojaslibro(txt_excel_precios.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""
                Dim r

                For j As Integer = 0 To OBJTABLE_PRECIOS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""

                    line = r & PadL("0126", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL(Trim(OBJTABLE_PRECIOS.Rows(j).Item(0).ToString), 3, " ")
                    line = line & PadL("", 7, "0")
                    line = line & PadLR(Trim(OBJTABLE_PRECIOS.Rows(j).Item(1).ToString), 50, " ")
                    line = line & PadL("", 20, " ")
                    line = line & PadL("", 20, " ")
                    line = line & PadL("", 20, " ")
                    Dim fecha_activacion, fecha_act
                    fecha_activacion = OBJTABLE_PRECIOS.Rows(j).Item(4).ToString
                    fecha_act = CDate(fecha_activacion).ToString("yyyyMMdd")
                    line = line & PadL(fecha_act, 8, " ")
                    line = line & PadL("", 8, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadLR(Trim(OBJTABLE_PRECIOS.Rows(j).Item(2).ToString), 4, " ")

                    Dim valor
                    valor = OBJTABLE_PRECIOS.Rows(j).Item(3).ToString
                    If valor = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else

                        If valor < 0 Then
                            valor = valor
                            valor = Convert.ToDecimal(valor).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & PadL(Trim(val_valor), 20, "0")
                        Else
                            valor = valor
                            valor = Convert.ToDecimal(valor).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & PadL(Trim(val_valor), 20, "0")
                        End If

                    End If


                    Dim valor_precio_min
                    valor_precio_min = OBJTABLE_PRECIOS.Rows(j).Item(5).ToString
                    If valor_precio_min = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else

                        If valor_precio_min < 0 Then
                            valor_precio_min = valor_precio_min
                            valor_precio_min = Convert.ToDecimal(valor_precio_min).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor_precio_min, ",", "")
                            line = line & PadL(Trim(val_valor), 20, "0")
                        Else
                            valor_precio_min = valor_precio_min
                            valor_precio_min = Convert.ToDecimal(valor_precio_min).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor_precio_min, ",", "")
                            line = line & PadL(Trim(val_valor), 20, "0")
                        End If

                    End If



                    Dim valor_precio_max
                    valor_precio_max = OBJTABLE_PRECIOS.Rows(j).Item(6).ToString
                    If valor_precio_max = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else

                        If valor_precio_max < 0 Then
                            valor_precio_max = valor_precio_max
                            valor_precio_max = Convert.ToDecimal(valor_precio_max).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor_precio_max, ",", "")
                            line = line & PadL(Trim(val_valor), 20, "0")
                        Else
                            valor_precio_max = valor_precio_max
                            valor_precio_max = Convert.ToDecimal(valor_precio_max).ToString("N4")
                            Dim val_valor As String
                            val_valor = Replace(valor_precio_max, ",", "")
                            line = line & PadL(Trim(val_valor), 20, "0")
                        End If

                    End If



                    line = line & PadL("000000000000000.0000", 20, " ")

                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_precios.Text & "', '" & txt_plano_precios.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_PRECIOS.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_precios.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btn_limpiar_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_precios.Click

        txt_excel_precios.Text = ""
        txt_plano_precios.Text = ""

    End Sub

    Private Sub btn_salir_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_precios.Click
        End
    End Sub

    Private Sub btn_excel_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_precios.Click
        ''SE SELECCIONA ARCHIVO CSV

        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_excel_precios.Text = OpenFileDialog1.FileName
        filePath5 = txt_excel_precios.Text
        If OpenFileDialog1.FileName = "OpenFileDialog5" Then
            txt_excel_precios.Text = ""
        End If
    End Sub

    Private Sub btn_plano_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_precios.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_precios.Text = SaveFileDialog1.FileName
        filePath5 = txt_plano_precios.Text
    End Sub

    Private Sub btn_limpiar_pres_ven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_pres_ven.Click

        txt_periodo_pres_vend.Text = ""
        cbo_presupuesto_vend.Text = ""
        txt_excel_pres_vend.Text = ""
        txt_plano_pres_vend.Text = ""
    End Sub

    Private Sub btn_plano_pres_vend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_pres_vend.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_pres_vend.Text = SaveFileDialog1.FileName
        filePath6 = txt_plano_pres_vend.Text
    End Sub

    Private Sub btn_excel_pres_ven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_pres_ven.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_excel_pres_vend.Text = OpenFileDialog1.FileName
        filePath6 = txt_excel_pres_vend.Text
        If OpenFileDialog1.FileName = "OpenFileDialog6" Then
            txt_excel_pres_vend.Text = ""
        End If

    End Sub

    Private Sub txt_periodo_pres_vend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_periodo_pres_vend.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_pres_ven_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_salir_pres_vend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_pres_vend.Click
        End
    End Sub

    Private Sub txt_co_car_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_co_car.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_tipdoc_car_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tipdoc_car.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_generar_plano_pres_ven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_plano_pres_ven.Click


        If txt_periodo_pres_vend.Text = "" Then
            MsgBox("Ingrese un periodo valido", MsgBoxStyle.Critical)
            txt_periodo_pres_vend.Focus()
            Exit Sub
        End If


        If cbo_presupuesto_vend.Text = "" Then
            MsgBox("Seleccione un tipo de presupuesto valido", MsgBoxStyle.Critical)
            cbo_presupuesto_vend.Focus()
            Exit Sub
        End If

        If txt_excel_pres_vend.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_excel_pres_vend.Focus()
            Exit Sub
        End If


        If txt_plano_pres_vend.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_pres_vend.Focus()
            Exit Sub
        End If

        generar_plano_pres_vend()

    End Sub

    Private Sub generar_plano_pres_vend()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath6 = txt_plano_pres_vend.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath6)


        If exists Then

            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.No Then
                Return
            End If

        End If

        Me.Cursor = Cursors.WaitCursor

        FileClose(1)
        OBJTABLE_PRES_VEND.Rows.Clear()
        System.IO.File.Delete(filePath6)
        Try
            FileOpen(1, filePath6, OpenMode.Output)
            line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
            'PrintLine(1, line)
            ' line = ""
            txt_excel_pres_vend.Text = OpenFileDialog1.FileName
            'cargar_csv_pres_vend()
            OBJTABLE_PRES_VEND = GetDataExcel(txt_excel_pres_vend.Text, Hojaslibro(txt_excel_pres_vend.Text))
            Me.Label1.Text = "1"
            Me.Label2.Text = ""
            Dim r

            For j As Integer = 0 To OBJTABLE_PRES_VEND.Rows.Count - 1
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                PrintLine(1, line)
                line = ""

                line = r & PadL("0491", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("01", 2, " ")
                line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                line = line & PadL("1", 1, " ")

                Dim unidades, kilos, valorP As String
                If cbo_presupuesto_vend.SelectedItem = "Presupuesto en Unidades" Then
                    unidades = "004"
                    line = line & PadL(Trim(unidades), 3, " ")
                ElseIf cbo_presupuesto_vend.SelectedItem = "Presupuesto en valor" Then
                    valorP = "006"
                    line = line & PadL(Trim(valorP), 3, " ")
                Else
                    kilos = "002"
                    line = line & PadL(Trim(kilos), 3, " ")
                End If

                line = line & PadL(Trim(txt_periodo_pres_vend.Text), 6, "0")
                line = line & PadL("", 3, " ")
                line = line & PadL("", 5, " ")
                line = line & PadLR(Trim(OBJTABLE_PRES_VEND.Rows(j).Item(3).ToString), 15, " ")
                line = line & PadL("", 15, " ")
                line = line & PadL("", 7, "0")
                line = line & PadLR(Trim(OBJTABLE_PRES_VEND.Rows(j).Item(0).ToString), 50, " ")
                line = line & PadL("", 151, " ")


                If cbo_presupuesto_vend.SelectedItem = "Presupuesto en Unidades" Then
                    line = line & PadL("000000000000000.0000", 20, " ")
                    Dim uni
                    uni = OBJTABLE_PRES_VEND.Rows(j).Item(1).ToString
                    If uni = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else
                        Valor = Convert.ToDecimal(uni).ToString("N4")
                        Dim val_valor As String
                        val_valor = Replace(Valor, ",", "")
                        line = line & PadL(Trim(val_valor), 20, "0")
                    End If

                ElseIf cbo_presupuesto_vend.SelectedItem = "Presupuesto en valor" Then
                    Dim valor As Decimal
                    valor = Convert.ToDecimal(OBJTABLE_PRES_VEND.Rows(j).Item(4).ToString).ToString("N4")
                    Dim val_valor As String
                    val_valor = Replace(valor.ToString, ",", "")
                    line = line & PadL(Trim(val_valor), 20, "0")
                    line = line & PadL("000000000000000.0000", 20, " ")
                Else
                    line = line & PadL("000000000000000.0000", 20, " ")
                    Dim kil
                    kil = OBJTABLE_PRES_VEND.Rows(j).Item(2).ToString
                    Valor = Convert.ToDecimal(kil).ToString("N4")
                    Dim val_valor As String
                    val_valor = Replace(Valor, ",", "")
                    line = line & PadL(Trim(val_valor), 20, "0")

                End If

                line = line & PadL("000000000000000.0000", 20, "0")

            Next

            PrintLine(1, line)
            line = ""
            Me.Label1.Text.PadLeft(7, CChar("0"))
            Me.Label1.Text = Me.Label1.Text + 1
            r = Me.Label1.Text
            r = r.PadLeft(7, CChar("0"))
            line = r & PadL("99990001" & variable_centro_operativo, 11, "")
            PrintLine(1, line)
            line = ""
            FileClose(1)

            Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim hora As String = Now.ToString("HH:mm:ss")
            Dim fecha_registro As String
            fecha_registro = var & " " & hora


            sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_pres_vend.Text & "', '" & txt_plano_pres_vend.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
            Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)


            OBJTABLE_PRES_VEND.Clear()

            Me.Cursor = Cursors.Default

            Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                FileClose(1)
            ElseIf result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(txt_plano_pres_vend.Text)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        '    Else

        '    End If


        'Else

        '    Try

        '        Me.Cursor = Cursors.WaitCursor

        '        FileOpen(1, filePath6, OpenMode.Output)
        '        line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
        '        'PrintLine(1, line)
        '        ' line = ""
        '        txt_excel_pres_vend.Text = OpenFileDialog6.FileName
        '        'cargar_csv_pres_vend()
        '        OBJTABLE_PRES_VEND = GetDataExcel(txt_excel_pres_vend.Text, Hojaslibro(txt_excel_pres_vend.Text))
        '        Me.Label1.Text = "1"
        '        Me.Label2.Text = ""
        '        Dim r

        '        For j As Integer = 0 To OBJTABLE_PRES_VEND.Rows.Count - 1
        '            Me.Label1.Text.PadLeft(7, CChar("0"))
        '            Me.Label1.Text = Me.Label1.Text + 1
        '            r = Me.Label1.Text
        '            r = r.PadLeft(7, CChar("0"))
        '            PrintLine(1, line)
        '            line = ""

        '            line = r & PadL("0491", 4, " ")
        '            line = line & PadL("00", 2, " ")
        '            line = line & PadL("01", 2, " ")
        '            line = line & PadL(Trim(variable_centro_operativo), 3, " ")
        '            line = line & PadL("1", 1, " ")

        '            Dim unidades, kilos, valorP As String
        '            If cbo_presupuesto_vend.SelectedItem = "Presupuesto en Unidades" Then
        '                unidades = "004"
        '                line = line & PadL(Trim(unidades), 3, " ")
        '            ElseIf cbo_presupuesto_vend.SelectedItem = "Presupuesto en valor" Then
        '                valorP = "006"
        '                line = line & PadL(Trim(valorP), 3, " ")
        '            Else
        '                kilos = "002"
        '                line = line & PadL(Trim(kilos), 3, " ")
        '            End If

        '            line = line & PadL(Trim(txt_periodo_pres_vend.Text), 6, "0")
        '            line = line & PadL("", 3, " ")
        '            line = line & PadL("", 5, " ")
        '            line = line & PadLR(Trim(OBJTABLE_PRES_VEND.Rows(j).Item(3).ToString), 15, " ")
        '            line = line & PadL("", 15, " ")
        '            line = line & PadL("", 7, "0")
        '            line = line & PadLR(Trim(OBJTABLE_PRES_VEND.Rows(j).Item(0).ToString), 50, " ")
        '            line = line & PadL("", 151, " ")

        '            If cbo_presupuesto_vend.SelectedItem = "Presupuesto en Unidades" Then
        '                line = line & PadL("000000000000000.0000", 20, " ")
        '                Dim uni
        '                uni = OBJTABLE_PRES_VEND.Rows(j).Item(1).ToString
        '                If uni = "" Then
        '                    line = line & PadL("000000000000000.0000", 20, "")
        '                Else
        '                    Valor = Convert.ToDecimal(uni).ToString("N4")
        '                    Dim val_valor As String
        '                    val_valor = Replace(Valor, ",", "")
        '                    line = line & PadL(Trim(val_valor), 20, "0")
        '                End If

        '            ElseIf cbo_presupuesto_vend.SelectedItem = "Presupuesto en valor" Then
        '                Dim valor As Decimal
        '                valor = Convert.ToDecimal(OBJTABLE_PRES_VEND.Rows(j).Item(4).ToString).ToString("N4")
        '                Dim val_valor As String
        '                val_valor = Replace(valor.ToString, ",", "")
        '                line = line & PadL(Trim(val_valor), 20, "0")
        '                line = line & PadL("000000000000000.0000", 20, " ")
        '            Else
        '                line = line & PadL("000000000000000.0000", 20, " ")
        '                Dim kil
        '                kil = OBJTABLE_PRES_VEND.Rows(j).Item(2).ToString
        '                Valor = Convert.ToDecimal(kil).ToString("N4")
        '                Dim val_valor As String
        '                val_valor = Replace(Valor, ",", "")
        '                line = line & PadL(Trim(val_valor), 20, "0")

        '            End If

        '            line = line & PadL("000000000000000.0000", 20, "0")

        '        Next

        '        PrintLine(1, line)
        '        line = ""
        '        Me.Label1.Text.PadLeft(7, CChar("0"))
        '        Me.Label1.Text = Me.Label1.Text + 1
        '        r = Me.Label1.Text
        '        r = r.PadLeft(7, CChar("0"))
        '        line = r & PadL("99990001" & variable_centro_operativo, 11, "")
        '        PrintLine(1, line)
        '        line = ""
        '        FileClose(1)


        '        Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
        '        Dim hora As String = Now.ToString("HH:mm:ss")
        '        Dim fecha_registro As String
        '        fecha_registro = var & " " & hora


        '        sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_pres_vend.Text & "', '" & txt_plano_pres_vend.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
        '        Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

        '        OBJTABLE_PRES_VEND.Clear()

        '        Me.Cursor = Cursors.Default

        '        Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
        '        If result = DialogResult.No Then
        '        ElseIf result = DialogResult.Yes Then
        '            System.Diagnostics.Process.Start(txt_plano_pres_vend.Text)
        '            Exit Sub
        '        End If

        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)

        '    End Try

        'End If

    End Sub

    Private Sub txt_periodo_pres_jef_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_periodo_pres_jef.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cod_pres_jef_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_excel_pres_jef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_pres_jef.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_excel_pres_jef.Text = OpenFileDialog1.FileName
        filePath7 = txt_excel_pres_jef.Text
        If OpenFileDialog1.FileName = "OpenFileDialog7" Then
            txt_excel_pres_jef.Text = ""
        End If
    End Sub

    Private Sub btn_plano_pres_jef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_pres_jef.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_pres_jef.Text = SaveFileDialog1.FileName
        filePath7 = txt_plano_pres_jef.Text
    End Sub

    Private Sub btn_limpiar_pres_jef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_pres_jef.Click
        txt_periodo_pres_jef.Text = ""
        cbo_presupuesto_jef2.Text = ""
        txt_excel_pres_jef.Text = ""
        txt_plano_pres_jef.Text = ""
    End Sub

    Private Sub btn_salir_pres_jef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_pres_jef.Click
        End
    End Sub

    Private Sub btn_generar_plano_pres_jef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_plano_pres_jef.Click

        If txt_periodo_pres_jef.Text = "" Then
            MsgBox("Ingrese un periodo valido", MsgBoxStyle.Critical)
            txt_periodo_pres_jef.Focus()
            Exit Sub
        End If


        If cbo_presupuesto_jef2.Text = "" Then
            MsgBox("Seleccione un tipo de presupuesto valido", MsgBoxStyle.Critical)
            cbo_presupuesto_jef2.Focus()
            Exit Sub
        End If

        If txt_periodo_pres_jef.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_excel_pres_jef.Focus()
            Exit Sub
        End If


        If txt_plano_pres_jef.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_pres_jef.Focus()
            Exit Sub
        End If

        generar_plano_pres_jef()

    End Sub

    Private Sub generar_plano_pres_jef()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath7 = txt_plano_pres_jef.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath7)


        If exists Then

            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.No Then
                Return
            End If

        End If


        'Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
        'If resultado = DialogResult.Yes Then

        Me.Cursor = Cursors.WaitCursor

        FileClose(1)
        OBJTABLE_PRES_JEF.Rows.Clear()
        System.IO.File.Delete(filePath7)
        Try
            FileOpen(1, filePath7, OpenMode.Output)
            line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
            'PrintLine(1, line)
            ' line = ""

            txt_excel_pres_jef.Text = OpenFileDialog1.FileName
            'cargar_csv_pres_jef()
            OBJTABLE_PRES_JEF = GetDataExcel(txt_excel_pres_jef.Text, Hojaslibro(txt_excel_pres_jef.Text))
            Me.Label1.Text = "1"
            Me.Label2.Text = ""
            Dim r

            For j As Integer = 0 To OBJTABLE_PRES_JEF.Rows.Count - 1
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                PrintLine(1, line)
                line = ""

                line = r & PadL("0491", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("01", 2, " ")
                line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                line = line & PadL("1", 1, " ")

                Dim unidades, kilos, valorP As String
                If cbo_presupuesto_jef2.SelectedItem = "Presupuesto en Unidades" Then
                    unidades = "003"
                    line = line & PadL(Trim(unidades), 3, " ")
                ElseIf cbo_presupuesto_jef2.SelectedItem = "Presupuesto en valor" Then
                    valorP = "005"
                    line = line & PadL(Trim(valorP), 3, " ")
                Else
                    kilos = "001"
                    line = line & PadL(Trim(kilos), 3, " ")
                End If

                line = line & PadL(Trim(txt_periodo_pres_jef.Text), 6, "0")
                line = line & PadL("", 3, " ")
                line = line & PadL("", 5, " ")
                line = line & PadL("", 15, " ")
                line = line & PadL("", 15, " ")
                line = line & PadL("", 7, "0")
                line = line & PadLR(Trim(OBJTABLE_PRES_JEF.Rows(j).Item(0).ToString), 50, " ")
                line = line & PadL("", 112, " ")
                line = line & PadL("003", 3, " ")
                line = line & PadLR(Trim(OBJTABLE_PRES_JEF.Rows(j).Item(3).ToString), 10, " ")
                line = line & PadL("", 26, " ")

                If cbo_presupuesto_jef2.SelectedItem = "Presupuesto en Unidades" Then
                    line = line & PadL("000000000000000.0000", 20, "")
                    Dim uni
                    uni = OBJTABLE_PRES_JEF.Rows(j).Item(1).ToString
                    If uni = "" Then
                        line = line & PadL("000000000000000.0000", 20, "")
                    Else
                        Valor = Convert.ToDecimal(uni).ToString("N4")
                        Dim val_valor As String
                        val_valor = Replace(Valor, ",", "")
                        line = line & PadL(Trim(val_valor), 20, "0")
                    End If

                ElseIf cbo_presupuesto_jef2.SelectedItem = "Presupuesto en valor" Then

                    Dim valor As Decimal
                    valor = Convert.ToDecimal(OBJTABLE_PRES_JEF.Rows(j).Item(4).ToString).ToString("N4")
                    Dim val_valor As String
                    val_valor = Replace(valor.ToString, ",", "")
                    line = line & PadL(Trim(val_valor), 20, "0")
                    line = line & PadL("000000000000000.0000", 20, "")
                Else
                    line = line & PadL("000000000000000.0000", 20, "")
                    Dim kil
                    kil = OBJTABLE_PRES_JEF.Rows(j).Item(2).ToString
                    Valor = Convert.ToDecimal(kil).ToString("N4")
                    Dim val_valor As String
                    val_valor = Replace(Valor, ",", "")
                    line = line & PadL(Trim(val_valor), 20, "0")

                End If
                line = line & PadL("000000000000000.0000", 20, "0")
            Next

            PrintLine(1, line)
            line = ""
            Me.Label1.Text.PadLeft(7, CChar("0"))
            Me.Label1.Text = Me.Label1.Text + 1
            r = Me.Label1.Text
            r = r.PadLeft(7, CChar("0"))
            line = r & PadL("99990001" & variable_centro_operativo, 11, "")
            PrintLine(1, line)
            line = ""
            FileClose(1)

            Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim hora As String = Now.ToString("HH:mm:ss")
            Dim fecha_registro As String
            fecha_registro = var & " " & hora


            sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_pres_jef.Text & "', '" & txt_plano_pres_jef.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
            Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)


            OBJTABLE_PRES_JEF.Clear()

            Me.Cursor = Cursors.Default

            Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                FileClose(1)
            ElseIf result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(txt_plano_pres_jef.Text)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        'Else

        'End If


        'Else

        'Try
        '    Me.Cursor = Cursors.WaitCursor

        '    FileOpen(1, filePath7, OpenMode.Output)
        '    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
        '    PrintLine(1, line)
        '    ' line = ""
        '    ' Print(1, "This is a test.")
        '    txt_excel_pres_jef.Text = OpenFileDialog7.FileName
        '    'cargar_csv_pres_jef()
        '    OBJTABLE_PRES_JEF = GetDataExcel(txt_excel_pres_jef.Text, Hojaslibro(txt_excel_pres_jef.Text))
        '    Me.Label1.Text = "1"
        '    Me.Label2.Text = ""
        '    Dim r

        '    For j As Integer = 0 To OBJTABLE_PRES_JEF.Rows.Count - 1
        '        Me.Label1.Text.PadLeft(7, CChar("0"))
        '        Me.Label1.Text = Me.Label1.Text + 1
        '        r = Me.Label1.Text
        '        r = r.PadLeft(7, CChar("0"))
        '        'PrintLine(1, line)
        '        ' line = ""

        '        line = r & PadL("0491", 4, " ")
        '        line = line & PadL("00", 2, " ")
        '        line = line & PadL("01", 2, " ")
        '        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
        '        line = line & PadL("1", 1, " ")

        '        Dim unidades, kilos, valorP As String
        '        If cbo_presupuesto_jef2.SelectedItem = "Presupuesto en Unidades" Then
        '            unidades = "003"
        '            line = line & PadL(Trim(unidades), 3, " ")
        '        ElseIf cbo_presupuesto_jef2.SelectedItem = "Presupuesto en valor" Then
        '            valorP = "005"
        '            line = line & PadL(Trim(valorP), 3, " ")
        '        Else
        '            kilos = "001"
        '            line = line & PadL(Trim(kilos), 3, " ")
        '        End If

        '        line = line & PadL(Trim(txt_periodo_pres_jef.Text), 6, "0")
        '        line = line & PadL("", 3, " ")
        '        line = line & PadL("", 5, " ")
        '        line = line & PadL("", 15, " ")
        '        line = line & PadL("", 15, " ")
        '        line = line & PadL("", 7, "0")
        '        line = line & PadLR(Trim(OBJTABLE_PRES_JEF.Rows(j).Item(0).ToString), 50, " ")
        '        line = line & PadL("", 112, " ")
        '        line = line & PadL("003", 3, " ")
        '        line = line & PadLR(Trim(OBJTABLE_PRES_JEF.Rows(j).Item(3).ToString), 10, " ")
        '        line = line & PadL("", 26, " ")
        '        line = line & PadL("000000000000000.0000", 20, "0")


        '        If cbo_presupuesto_jef2.SelectedItem = "Presupuesto en Unidades" Then
        '            line = line & PadL("000000000000000.0000", 20, "")
        '            Dim uni
        '            uni = OBJTABLE_PRES_JEF.Rows(j).Item(1).ToString
        '            If uni = "" Then
        '                line = line & PadL("000000000000000.0000", 20, "")
        '            Else
        '                Valor = Convert.ToDecimal(uni).ToString("N4")
        '                Dim val_valor As String
        '                val_valor = Replace(Valor, ",", "")
        '                line = line & PadL(Trim(val_valor), 20, "0")
        '            End If

        '        ElseIf cbo_presupuesto_jef2.SelectedItem = "Presupuesto en valor" Then

        '            Dim valor As Decimal
        '            valor = Convert.ToDecimal(OBJTABLE_PRES_JEF.Rows(j).Item(4).ToString).ToString("N4")
        '            Dim val_valor As String
        '            val_valor = Replace(valor.ToString, ",", "")
        '            line = line & PadL(Trim(val_valor), 20, "0")
        '            line = line & PadL("000000000000000.0000", 20, "")
        '        Else
        '            line = line & PadL("000000000000000.0000", 20, "")
        '            Dim kil
        '            kil = OBJTABLE_PRES_JEF.Rows(j).Item(2).ToString
        '            Valor = Convert.ToDecimal(kil).ToString("N4")
        '            Dim val_valor As String
        '            val_valor = Replace(Valor, ",", "")
        '            line = line & PadL(Trim(val_valor), 20, "0")

        '        End If
        '        line = line & PadL("000000000000000.0000", 20, "0")

        '        PrintLine(1, line)
        '        'line = ""


        '        '' mirar el cambio de printline de este for y debajo y compararlo con el de arriba.. este se modifico
        '    Next


        '    Me.Label1.Text.PadLeft(7, CChar("0"))
        '    Me.Label1.Text = Me.Label1.Text + 1
        '    r = Me.Label1.Text
        '    r = r.PadLeft(7, CChar("0"))
        '    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
        '    PrintLine(1, line)
        '    line = ""
        '    FileClose(1)

        '    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
        '    Dim hora As String = Now.ToString("HH:mm:ss")
        '    Dim fecha_registro As String
        '    fecha_registro = var & " " & hora


        '    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_pres_jef.Text & "', '" & txt_plano_pres_jef.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
        '    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

        '    OBJTABLE_PRES_JEF.Clear()


        '    Me.Cursor = Cursors.Default

        '    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
        '    If result = DialogResult.No Then
        '    ElseIf result = DialogResult.Yes Then
        '        System.Diagnostics.Process.Start(txt_plano_pres_jef.Text)
        '        Exit Sub
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try

        'End If

    End Sub

    Private Sub btn_salir_bancolombia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_bancolombia.Click
        End
    End Sub

    Private Sub btn_generar_bancolombia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_bancolombia.Click


        If txt_excel_bancolombia.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_excel_bancolombia.Focus()
            Exit Sub
        End If

        If txt_plano_bancolombia.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_bancolombia.Focus()
            Exit Sub
        End If


        generar_plano_bancolombia()

    End Sub

    Private Sub generar_plano_bancolombia()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath8 = txt_plano_bancolombia.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath8)


        If exists Then

            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_BANCOLOMBIA.Rows.Clear()
                System.IO.File.Delete(filePath8)
                Try

                    FileOpen(1, filePath8, OpenMode.Output)

                    txt_excel_bancolombia.Text = OpenFileDialog1.FileName
                    'cargar_csv_bancolombia()
                    OBJTABLE_BANCOLOMBIA = GetDataExcel(txt_excel_bancolombia.Text, Hojaslibro(txt_excel_bancolombia.Text))
                    For j As Integer = 0 To OBJTABLE_BANCOLOMBIA.Rows.Count - 1

                        line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(0).ToString, 4, " ")


                        Dim valor, contador
                        valor = OBJTABLE_BANCOLOMBIA.Rows(j).Item(1).ToString
                        'contador = Len(valor)

                        'If contador >= 10 Then
                        '    valor = Convert.ToDecimal(valor).ToString("N1")
                        '    Dim val_valor As String
                        '    val_valor = Replace(valor, ",", "")
                        '    line = line & PadLR(Trim(val_valor), 12, " ")
                        'Else
                        '    valor = Convert.ToDecimal(valor).ToString("N2")
                        '    Dim val_valor As String
                        '    val_valor = Replace(valor, ",", "")
                        '    line = line & PadLR(Trim(val_valor), 12, " ")
                        'End If

                        valor = Convert.ToDecimal(valor).ToString("N2")
                        contador = Len(valor)
                        If contador > 14 Then
                            valor = Convert.ToDecimal(valor).ToString("N1")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & PadLR(Trim(val_valor), 12, " ")
                        Else
                            valor = Convert.ToDecimal(valor).ToString("N2")
                            Dim val_valor As String
                            val_valor = Replace(valor, ",", "")
                            line = line & PadLR(Trim(val_valor), 12, " ")
                        End If


                        line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(2).ToString, 4, " ")
                        line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(3).ToString, 2, " ")
                        line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(4).ToString, 2, " ")


                        Dim nota
                        nota = Trim(OBJTABLE_BANCOLOMBIA.Rows(j).Item(5).ToString)
                        nota = Mid(nota, 1, 12)
                        line = line & PadLR(nota, 12, " ")

                        Dim cheque As String
                        cheque = Trim(OBJTABLE_BANCOLOMBIA.Rows(j).Item(6).ToString)
                        cheque = CStr(cheque)
                        If cheque = "" Then
                            cheque = 0
                            line = line & PadLR(cheque, 6, " ")
                        Else
                            cheque = Mid(cheque, 1, 7)
                            line = line & PadLR(cheque, 6, " ")
                        End If


                        PrintLine(1, line)
                        line = ""

                    Next


                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_bancolombia.Text & "', '" & txt_plano_bancolombia.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_BANCOLOMBIA.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_bancolombia.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath8, OpenMode.Output)
                'line = line & PadL("000000100000001" & variable_centro_operativo, 18, "")
                ''PrintLine(1, line)
                '' line = ""
                txt_excel_bancolombia.Text = OpenFileDialog1.FileName
                'cargar_csv_bancolombia()
                OBJTABLE_BANCOLOMBIA = GetDataExcel(txt_excel_bancolombia.Text, Hojaslibro(txt_excel_bancolombia.Text))
                'Me.Label1.Text = "1"
                'Me.Label2.Text = ""
                'Dim r

                'PrintLine(1, line)
                'line = ""

                For j As Integer = 0 To OBJTABLE_BANCOLOMBIA.Rows.Count - 1

                    line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(0).ToString, 4, " ")

                    Dim valor, contador
                    valor = OBJTABLE_BANCOLOMBIA.Rows(j).Item(1).ToString
                    'contador = Len(valor)

                    'If contador >= 10 Then
                    '    valor = Convert.ToDecimal(valor).ToString("N1")
                    '    Dim val_valor As String
                    '    val_valor = Replace(valor, ",", "")
                    '    line = line & PadLR(Trim(val_valor), 12, " ")
                    'Else
                    '    valor = Convert.ToDecimal(valor).ToString("N2")
                    '    Dim val_valor As String
                    '    val_valor = Replace(valor, ",", "")
                    '    line = line & PadLR(Trim(val_valor), 12, " ")
                    'End If

                    valor = Convert.ToDecimal(valor).ToString("N2")
                    contador = Len(valor)
                    If contador > 14 Then
                        valor = Convert.ToDecimal(valor).ToString("N1")
                        Dim val_valor As String
                        val_valor = Replace(valor, ",", "")
                        line = line & PadLR(Trim(val_valor), 12, " ")
                    Else
                        valor = Convert.ToDecimal(valor).ToString("N2")
                        Dim val_valor As String
                        val_valor = Replace(valor, ",", "")
                        line = line & PadLR(Trim(val_valor), 12, " ")
                    End If





                    line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(2).ToString, 4, " ")
                    line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(3).ToString, 2, " ")
                    line = line & PadLR(OBJTABLE_BANCOLOMBIA.Rows(j).Item(4).ToString, 2, " ")

                    Dim nota
                    nota = Trim(OBJTABLE_BANCOLOMBIA.Rows(j).Item(5).ToString)
                    nota = Mid(nota, 1, 12)
                    line = line & PadLR(nota, 12, " ")

                    Dim cheque As String
                    cheque = Trim(OBJTABLE_BANCOLOMBIA.Rows(j).Item(6).ToString)
                    cheque = CStr(cheque)
                    If cheque = "" Then
                        cheque = 0
                        line = line & PadLR(cheque, 6, " ")
                    Else
                        cheque = Mid(cheque, 1, 6)
                        line = line & PadLR(cheque, 6, " ")
                    End If

                    PrintLine(1, line)
                    line = ""

                Next

                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_bancolombia.Text & "', '" & txt_plano_bancolombia.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_BANCOLOMBIA.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_bancolombia.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub btn_limpiar_bancolombia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_bancolombia.Click
        txt_excel_bancolombia.Text = ""
        txt_plano_bancolombia.Text = ""
    End Sub

    Private Sub btn_excel_bancolombia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_bancolombia.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_excel_bancolombia.Text = OpenFileDialog1.FileName
        filePath8 = txt_excel_bancolombia.Text
        ' FileOpen(1, filePath, OpenMode.Output)
        If OpenFileDialog1.FileName = "OpenFileDialog8" Then
            txt_excel_bancolombia.Text = ""
        End If
    End Sub

    Private Sub btn_plano_bancolombia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_bancolombia.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_bancolombia.Text = SaveFileDialog1.FileName
        filePath8 = txt_plano_bancolombia.Text
    End Sub

    Private Sub btn_limpiar_bogota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_bogota.Click

        txt_excel_bogota.Text = ""
        txt_plano_bogota.Text = ""

    End Sub

    Private Sub btn_excel_bogota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_excel_bogota.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_excel_bogota.Text = OpenFileDialog1.FileName
        filePath9 = txt_excel_bogota.Text
        ' FileOpen(1, filePath, OpenMode.Output)
        If OpenFileDialog1.FileName = "OpenFileDialog9" Then
            txt_excel_bogota.Text = ""
        End If

    End Sub

    Private Sub btn_plano_bogota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_bogota.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_bogota.Text = SaveFileDialog1.FileName
        filePath9 = txt_plano_bogota.Text
    End Sub

    Private Sub btn_generar_bogota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_bogota.Click

        If txt_excel_bogota.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_excel_bogota.Focus()
            Exit Sub
        End If

        If txt_plano_bogota.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_bogota.Focus()
            Exit Sub
        End If


        generar_plano_bogota()

    End Sub

    Private Sub generar_plano_bogota()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath9 = txt_plano_bogota.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath9)


        If exists Then

            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_BOGOTA.Rows.Clear()
                System.IO.File.Delete(filePath9)
                Try

                    FileOpen(1, filePath9, OpenMode.Output)

                    txt_excel_bogota.Text = OpenFileDialog1.FileName
                    'cargar_csv_bancobogota()
                    OBJTABLE_BOGOTA = GetDataExcel(txt_excel_bogota.Text, Hojaslibro(txt_excel_bogota.Text))
                    For j As Integer = 0 To OBJTABLE_BOGOTA.Rows.Count - 1

                        line = line & PadLR("**", 2, " ")
                        line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(1).ToString, 6, " ")
                        line = line & PadLR("*********", 9, " ")
                        line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(3).ToString, 4, " ")
                        line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(4).ToString, 2, " ")
                        line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(5).ToString, 2, " ")

                        line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(6).ToString, 10, " ")

                        Dim valor
                        valor = OBJTABLE_BOGOTA.Rows(j).Item(7).ToString
                        valor = Convert.ToDecimal(valor).ToString("N2")
                        Dim val_valor As String
                        val_valor = Replace(valor, ",", "")
                        line = line & PadLR(Trim(val_valor), 17, " ")

                        Dim nota, NOTAS
                        nota = Trim(OBJTABLE_BOGOTA.Rows(j).Item(8).ToString)
                        NOTAS = Mid(nota, 1, 60)
                        line = line & PadLR(NOTAS, 60, " ")

                        PrintLine(1, line)
                        line = ""

                    Next


                    FileClose(1)



                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_bogota.Text & "', '" & txt_plano_bogota.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_BOGOTA.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_bogota.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath9, OpenMode.Output)

                txt_excel_bogota.Text = OpenFileDialog1.FileName
                'cargar_csv_bancobogota()
                OBJTABLE_BOGOTA = GetDataExcel(txt_excel_bogota.Text, Hojaslibro(txt_excel_bogota.Text))
                For j As Integer = 0 To OBJTABLE_BOGOTA.Rows.Count - 1

                    line = line & PadLR("**", 2, " ")
                    line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(1).ToString, 6, " ")
                    line = line & PadLR("*********", 9, " ")
                    line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(3).ToString, 4, " ")
                    line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(4).ToString, 2, " ")
                    line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(5).ToString, 2, " ")

                    line = line & PadLR(OBJTABLE_BOGOTA.Rows(j).Item(6).ToString, 10, " ")

                    Dim valor
                    valor = OBJTABLE_BOGOTA.Rows(j).Item(7).ToString
                    valor = Convert.ToDecimal(valor).ToString("N2")
                    Dim val_valor As String
                    val_valor = Replace(valor, ",", "")
                    line = line & PadLR(Trim(val_valor), 17, " ")

                    Dim nota, NOTAS
                    nota = Trim(OBJTABLE_BOGOTA.Rows(j).Item(8).ToString)
                    NOTAS = Mid(nota, 1, 60)
                    line = line & PadLR(NOTAS, 60, " ")

                    PrintLine(1, line)
                    line = ""

                Next

                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_excel_bogota.Text & "', '" & txt_plano_bogota.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_BOGOTA.Clear()


                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_bogota.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btn_salir_bogota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_bogota.Click
        End
    End Sub

    'Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean

    '    'Creamos las variables
    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

    '    Try
    '        'Añadimos el Libro al programa, y la hoja al libro
    '        exLibro = exApp.Workbooks.Add
    '        exHoja = exLibro.Worksheets.Add()

    '        ' ¿Cuantas columnas y cuantas filas?
    '        Dim NCol As Integer = ElGrid.ColumnCount
    '        Dim NRow As Integer = ElGrid.RowCount

    '        'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
    '        For i As Integer = 1 To NCol
    '            exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
    '            'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
    '        Next

    '        For Fila As Integer = 0 To NRow - 1
    '            For Col As Integer = 0 To NCol - 1
    '                exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
    '            Next
    '        Next
    '        'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
    '        exHoja.Rows.Item(1).Font.Bold = 1
    '        exHoja.Rows.Item(1).HorizontalAlignment = 3
    '        exHoja.Columns.AutoFit()


    '        'Aplicación visible
    '        exApp.Application.Visible = True
    '        exHoja = Nothing
    '        exLibro = Nothing
    '        exApp = Nothing

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
    '        Return False
    '    End Try

    '    Return True

    'End Function

    'Private Sub btnexportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexportar.Click
    '    GridAExcel(dgvpendientes)
    'End Sub


    Private Sub exportar_plantilla_activos()

        System.Diagnostics.Process.Start(".\Planos\Activos_Fijos.xls")

        'SaveFileDialog2.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"
        ''SaveFileDialog2.ShowDialog()

        'If SaveFileDialog2.ShowDialog = DialogResult.Cancel Then

        'Else

        '    ' txt_archivo_plano_activos.Text = SaveFileDialog2.FileName
        '    ' filePath = txt_archivo_plano_activos.Text

        '    Dim csvFile As String = SaveFileDialog2.FileName
        '    ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
        '    Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

        '    outFile.WriteLine("codigo,referencia,descripcion,descripcion_corta,tipo act,C.opera,C.Costos,Tercero respons,fecha compra,valor adquisicion,periodo depreciar COLGAP,periodo depreciar NIIF,proveedor,sucursal_proveedor,doc_referencia,mayor,Genéticas (descripción larga),Valor salvamento,Notas,Indicador Ajustable,Valor de Adquisicon NIIF,Valor salvamento NIIF")
        '    'outFile.WriteLine("1.23, 4.56, 7.89")
        '    'outFile.WriteLine("3.21, 6.54, 9.87")
        '    outFile.Close()

        '    'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
        '    MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
        '    'System.Diagnostics.Process.Start(csvFile)
        'End If

    End Sub

    Private Sub btn_est_activos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_activos.Click
        System.Diagnostics.Process.Start(".\Planos\Activos_Fijos.xls")
        'exportar_plantilla_activos()
    End Sub

    Private Sub exportar_plantilla_activaciones()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then


        Else

            ' txt_archivo_plano_activos.Text = SaveFileDialog2.FileName
            ' filePath = txt_archivo_plano_activos.Text

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("codigo")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)

        End If


    End Sub

    Private Sub btn_est_activaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_activaciones.Click
        System.Diagnostics.Process.Start(".\Planos\Activaciones.xls")
        'exportar_plantilla_activaciones()
    End Sub

    Private Sub exportar_plantilla_movimiento()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then


        Else


            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("co,cuenta,tercero,ccostos,debito,credito,notas,basegravable,docto_banco,num_docto_banco,Aux_flujo")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)

        End If
    End Sub


    Private Sub exportar_plantilla_traslados()

        'SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"
        SaveFileDialog1.Filter = "(*.xls)|*.xls|Excel Files|*.xls"
        ' OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then


        Else


            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("referencia,tipo_inventario,centro_operativo,centro_costo,tercero")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)

        End If
    End Sub


    Private Sub btn_est_movimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_movimiento.Click
        System.Diagnostics.Process.Start(".\Planos\Movimientos_Contable.xls")
        'exportar_plantilla_movimiento()
    End Sub

    Private Sub exportar_plantilla_carnicos()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("razon social,cliente,sucursal,co,fechadocto,fechavto,documento,numdcto,valor")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_est_carnicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_carnicos.Click
        System.Diagnostics.Process.Start(".\Planos\Carnicos.xls")
        'exportar_plantilla_carnicos()
    End Sub

    Private Sub exportar_plantilla_precios()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then


        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("cod_lista,referencia,um,precio,fecha_activacion,precio_min,precio_max")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_est_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_precios.Click
        System.Diagnostics.Process.Start(".\Planos\Precios.xls")
        'exportar_plantilla_precios()
    End Sub

    Private Sub exportar_plantilla_pres_vend()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then


        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("referencia,unidades,kilos,vendedor")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_est_pres_vend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_pres_vend.Click
        System.Diagnostics.Process.Start(".\Planos\Presupuesto_Vendedores.xls")
        'exportar_plantilla_pres_vend()
    End Sub

    Private Sub exportar_plantilla_pres_jef()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("referencia,unidades,kilos,jefeventa")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_est_jefe_ventas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_jefe_ventas.Click
        System.Diagnostics.Process.Start(".\Planos\Presupuesto_Jefe_Ventas.xls")
        'exportar_plantilla_pres_jef()
    End Sub

    Private Sub exportar_plantilla_bancolombia()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then


        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("codigo,valor,a,m,d,descripcion,doc")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)

        End If

    End Sub

    Private Sub exportar_plantilla_bancolombia(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_bancolombia.Click
        System.Diagnostics.Process.Start(".\Planos\Extracto_Bancolombia_Virtual.xls")
        'exportar_plantilla_bancolombia()
    End Sub

    Private Sub exportar_plantilla_bancobogota()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then


        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("E2,codigo,E9,A,M,D,Documento,Déposito,Descripcion")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub exportar_plantilla_items()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("f120_referencia,f120_descripcion,f120_descripcion_corta,f120_id_grupo_impositivo,f120_id_tipo_inv_serv,f120_ind_tipo_item,f120_ind_compra,f120_ind_venta,f120_ind_manufactura,f120_id_unidad_inventario,f120_id_unidad_orden,f120_factor_orden,f120_factor_peso_orden,f120_id_unidad_adicional,f120_factor_adicional,f120_factor_peso_adicional")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_est_bancobogota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_bancobogota.Click
        System.Diagnostics.Process.Start(".\Planos\Extracto_Banco_Bogota.xls")
        'exportar_plantilla_bancobogota()
    End Sub

    Private Sub btn_salir_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_items.Click
        End
    End Sub

    Private Sub btn_limpiar_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_items.Click

        txt_csv_items.Text = ""
        txt_plano_items.Text = ""

    End Sub

    Private Sub btn_generar_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_items.Click

        If txt_csv_items.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_items.Focus()
            Exit Sub
        End If

        If txt_plano_items.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_items.Focus()
            Exit Sub
        End If

        generar_plano_items()

    End Sub

    Private Sub generar_plano_items()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath10 = txt_plano_items.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath10)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_ITEMS.Rows.Clear()
                System.IO.File.Delete(filePath10)
                Try
                    FileOpen(1, filePath10, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    'PrintLine(1, line)
                    ' line = ""
                    txt_csv_items.Text = OpenFileDialog1.FileName
                    'cargar_csv_items()
                    OBJTABLE_ITEMS = GetDataExcel(txt_csv_items.Text, Hojaslibro(txt_csv_items.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""
                    Dim r

                    For j As Integer = 0 To OBJTABLE_ITEMS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""

                        line = r & PadL("0120", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("04", 2, " ")
                        line = line & PadL("180", 3, " ")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("0", 7, "0")
                        line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(0).ToString), 50, " ") 'referencia
                        Dim des_larga
                        des_larga = Trim(OBJTABLE_ITEMS.Rows(j).Item(1).ToString)
                        des_larga = Mid(des_larga, 1, 40)
                        line = line & PadLR(des_larga, 40, " ") 'Descripción del item

                        'line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(1).ToString), 40, " ")
                        Dim des_corta
                        des_corta = Trim(OBJTABLE_ITEMS.Rows(j).Item(2).ToString)
                        des_corta = Mid(des_corta, 1, 20)
                        line = line & PadLR(des_corta, 20, " ") ' Descripción corta
                        line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(3).ToString), 4, " ") 'Grupo impositivo
                        line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(4).ToString), 10, " ") 'Tipo de inventario
                        line = line & PadL("", 4, " ") 'Grupo descuento
                        Dim tipoItem As Integer = CInt(Trim(OBJTABLE_ITEMS.Rows(j).Item(5).ToString))
                        'tipo item 2  es servicio
                        If tipoItem <> 2 Then
                            line = line & PadL("1", 3, "0") 'Segmento de costo
                        Else
                            line = line & PadL("0", 3, "0") 'Segmento de costo
                        End If



                        line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(5).ToString), 1, "0")
                        line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(6).ToString), 1, "0")
                        line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(7).ToString), 1, "0")
                        line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(8).ToString), 1, "0")
                        line = line & PadL("11", 2, "0") 'aca

                        'line = line & PadL("11", 2, " ")
                        'line = line & PadL("00", 2, " ")
                        'line = line & PadL("11", 2, " ")


                        line = line & PadL("0", 4, "0")
                        line = line & PadL("", 18, " ")
                        line = line & PadL("", 18, " ")
                        line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(9).ToString), 4, " ")
                        line = line & PadL("000001.0000", 11, "0")
                        line = line & PadL("000001.0000", 11, "0")

                        'aca
                        line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(13).ToString), 4, " ")

                        Dim factor_adicional
                        factor_adicional = OBJTABLE_ITEMS.Rows(j).Item(14).ToString


                        If factor_adicional = "" Then
                            'debito = debito
                            line = line & PadLR("000000.0000", 11, "")
                        Else

                            Dim parte_entera_factor_adicional
                            parte_entera_factor_adicional = Int(factor_adicional)
                            parte_entera_factor_adicional = parte_entera_factor_adicional.ToString().PadLeft(6, "0")

                            Dim parte_decimal_factor_adicional = OBJTABLE_ITEMS.Rows(j).Item(14).ToString
                            parte_decimal_factor_adicional = Convert.ToDecimal(parte_decimal_factor_adicional).ToString("N4")
                            Dim val_parte_decimal_factor_adicional
                            val_parte_decimal_factor_adicional = Mid(parte_decimal_factor_adicional, InStrRev(parte_decimal_factor_adicional, ".") + 1)

                            Dim val_factor_adicional
                            val_factor_adicional = parte_entera_factor_adicional + "." + val_parte_decimal_factor_adicional
                            line = line & PadLR(Trim(val_factor_adicional), 11, "0")
                        End If
                        ''line = line & PadL("000000.0000", 1, "0")


                        Dim factor_peso_adicional
                        factor_peso_adicional = OBJTABLE_ITEMS.Rows(j).Item(15).ToString


                        If factor_adicional = "" Then
                            'debito = debito
                            line = line & PadLR("000000.0000", 11, "")
                        Else

                            Dim parte_entera_factor_peso_adicional
                            parte_entera_factor_peso_adicional = Int(factor_peso_adicional)
                            parte_entera_factor_peso_adicional = parte_entera_factor_peso_adicional.ToString().PadLeft(6, "0")

                            Dim parte_decimal_factor_peso_adicional = OBJTABLE_ITEMS.Rows(j).Item(15).ToString
                            parte_decimal_factor_peso_adicional = Convert.ToDecimal(parte_decimal_factor_peso_adicional).ToString("N4")
                            Dim val_parte_decimal_factor_peso_adicional
                            val_parte_decimal_factor_peso_adicional = Mid(parte_decimal_factor_peso_adicional, InStrRev(parte_decimal_factor_peso_adicional, ".") + 1)

                            Dim val_factor_peso_adicional
                            val_factor_peso_adicional = parte_entera_factor_peso_adicional + "." + val_parte_decimal_factor_peso_adicional
                            line = line & PadLR(Trim(val_factor_peso_adicional), 11, "0")
                        End If

                        ''line = line & PadL("000000.0000", 1, "0")



                        line = line & PadL("000000.0000", 1, "")
                        line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(10).ToString), 4, " ")
                        'line = line & PadL("000001.0000", 1, "")
                        Dim factor_peso_orden2
                        factor_peso_orden2 = OBJTABLE_ITEMS.Rows(j).Item(11).ToString

                        Dim parte_entera2
                        parte_entera2 = Int(factor_peso_orden2)
                        parte_entera2 = parte_entera2.ToString().PadLeft(6, "0")

                        Dim parte_decimal2 = OBJTABLE_ITEMS.Rows(j).Item(11).ToString
                        parte_decimal2 = Convert.ToDecimal(parte_decimal2).ToString("N4")
                        Dim val_parte_decimal2
                        val_parte_decimal2 = Mid(parte_decimal2, InStrRev(parte_decimal2, ".") + 1)

                        Dim val_factor_peso_orden2
                        val_factor_peso_orden2 = parte_entera2 + "." + val_parte_decimal2


                        line = line & PadLR(Trim(val_factor_peso_orden2), 11, "0")

                        Dim factor_peso_orden
                        factor_peso_orden = OBJTABLE_ITEMS.Rows(j).Item(12).ToString

                        Dim parte_entera
                        parte_entera = Int(factor_peso_orden)
                        parte_entera = parte_entera.ToString().PadLeft(6, "0")

                        Dim parte_decimal = OBJTABLE_ITEMS.Rows(j).Item(12).ToString
                        parte_decimal = Convert.ToDecimal(parte_decimal).ToString("N4")
                        Dim val_parte_decimal
                        val_parte_decimal = Mid(parte_decimal, InStrRev(parte_decimal, ".") + 1)

                        Dim val_factor_peso_orden
                        val_factor_peso_orden = parte_entera + "." + val_parte_decimal


                        line = line & PadLR(Trim(val_factor_peso_orden), 11, "0")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("", 4, " ")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("1", 1, "0")
                        line = line & PadL("", 8, " ")
                        Dim fecha_activacion, fecha_act
                        fecha_activacion = DateTime.Now
                        fecha_act = CDate(fecha_activacion).ToString("yyyyMMdd")
                        line = line & PadLR(fecha_act, 6, " ")
                        line = line & PadL("", 255, " ")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("", 10, " ")
                        line = line & PadL("0", 1, "0")


                    Next

                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_items.Text & "', '" & txt_plano_items.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)


                    OBJTABLE_PRECIOS.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_items.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath10, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                'PrintLine(1, line)
                'line = ""
                txt_csv_items.Text = OpenFileDialog1.FileName
                'cargar_csv_items()
                OBJTABLE_ITEMS = GetDataExcel(txt_csv_items.Text, Hojaslibro(txt_csv_items.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""
                Dim r

                For j As Integer = 0 To OBJTABLE_ITEMS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""

                    line = r & PadL("0120", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("04", 2, " ")
                    line = line & PadL("180", 3, " ")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("0", 7, "0")
                    line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(0).ToString), 50, " ")
                    'line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(1).ToString), 40, " ")
                    Dim des_larga
                    des_larga = Trim(OBJTABLE_ITEMS.Rows(j).Item(1).ToString)
                    des_larga = Mid(des_larga, 1, 40)
                    line = line & PadLR(des_larga, 40, " ")
                    Dim des_corta
                    des_corta = Trim(OBJTABLE_ITEMS.Rows(j).Item(2).ToString)
                    des_corta = Mid(des_corta, 1, 20)
                    line = line & PadLR(des_corta, 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(3).ToString), 4, " ")
                    line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(4).ToString), 10, " ")
                    line = line & PadL("", 4, " ")
                    Dim tipoItem As Integer = CInt(Trim(OBJTABLE_ITEMS.Rows(j).Item(5).ToString))
                    'tipo item 2 es servicio
                    If tipoItem <> 2 Then
                        line = line & PadL("1", 3, "0") 'Segmento de costo
                    Else
                        line = line & PadL("0", 3, "0") 'Segmento de costo
                    End If


                    'line = line & PadL("11", 2, " ")
                    'line = line & PadL("00", 2, " ")
                    'line = line & PadL("11", 2, " ")

                    line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(5).ToString), 1, "0")
                    line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(6).ToString), 1, "0")
                    line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(7).ToString), 1, "0")
                    line = line & PadL(Trim(OBJTABLE_ITEMS.Rows(j).Item(8).ToString), 1, "0")
                    line = line & PadL("11", 2, "0")


                    line = line & PadL("0", 4, "0")
                    line = line & PadL("", 18, " ")
                    line = line & PadL("", 18, " ")
                    line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(9).ToString), 4, " ")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    'line = line & PadL("", 4, " ")
                    'line = line & PadL("000000.0000", 1, "")
                    'line = line & PadL("000000.0000", 1, "")


                    'aca
                    line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(13).ToString), 4, " ")

                    Dim factor_adicional
                    factor_adicional = OBJTABLE_ITEMS.Rows(j).Item(14).ToString


                    If factor_adicional = "" Then
                        'debito = debito
                        line = line & PadLR("000000.0000", 11, "")
                    Else

                        Dim parte_entera_factor_adicional
                        parte_entera_factor_adicional = Int(factor_adicional)
                        parte_entera_factor_adicional = parte_entera_factor_adicional.ToString().PadLeft(6, "0")

                        Dim parte_decimal_factor_adicional = OBJTABLE_ITEMS.Rows(j).Item(14).ToString
                        parte_decimal_factor_adicional = Convert.ToDecimal(parte_decimal_factor_adicional).ToString("N4")
                        Dim val_parte_decimal_factor_adicional
                        val_parte_decimal_factor_adicional = Mid(parte_decimal_factor_adicional, InStrRev(parte_decimal_factor_adicional, ".") + 1)

                        Dim val_factor_adicional
                        val_factor_adicional = parte_entera_factor_adicional + "." + val_parte_decimal_factor_adicional
                        line = line & PadLR(Trim(val_factor_adicional), 11, "0")
                    End If
                    ''line = line & PadL("000000.0000", 1, "0")


                    Dim factor_peso_adicional
                    factor_peso_adicional = OBJTABLE_ITEMS.Rows(j).Item(15).ToString


                    If factor_adicional = "" Then
                        'debito = debito
                        line = line & PadLR("000000.0000", 11, "")
                    Else

                        Dim parte_entera_factor_peso_adicional
                        parte_entera_factor_peso_adicional = Int(factor_peso_adicional)
                        parte_entera_factor_peso_adicional = parte_entera_factor_peso_adicional.ToString().PadLeft(6, "0")

                        Dim parte_decimal_factor_peso_adicional = OBJTABLE_ITEMS.Rows(j).Item(15).ToString
                        parte_decimal_factor_peso_adicional = Convert.ToDecimal(parte_decimal_factor_peso_adicional).ToString("N4")
                        Dim val_parte_decimal_factor_peso_adicional
                        val_parte_decimal_factor_peso_adicional = Mid(parte_decimal_factor_peso_adicional, InStrRev(parte_decimal_factor_peso_adicional, ".") + 1)

                        Dim val_factor_peso_adicional
                        val_factor_peso_adicional = parte_entera_factor_peso_adicional + "." + val_parte_decimal_factor_peso_adicional
                        line = line & PadLR(Trim(val_factor_peso_adicional), 11, "0")
                    End If

                    ''line = line & PadL("000000.0000", 1, "0")


                    line = line & PadL("000000.0000", 1, "")
                    line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(10).ToString), 4, " ")


                    Dim factor_peso_orden2
                    factor_peso_orden2 = OBJTABLE_ITEMS.Rows(j).Item(11).ToString

                    Dim parte_entera2
                    parte_entera2 = Int(factor_peso_orden2)
                    parte_entera2 = parte_entera2.ToString().PadLeft(6, "0")

                    Dim parte_decimal2 = OBJTABLE_ITEMS.Rows(j).Item(11).ToString
                    parte_decimal2 = Convert.ToDecimal(parte_decimal2).ToString("N4")
                    Dim val_parte_decimal2
                    val_parte_decimal2 = Mid(parte_decimal2, InStrRev(parte_decimal2, ".") + 1)

                    Dim val_factor_peso_orden2
                    val_factor_peso_orden2 = parte_entera2 + "." + val_parte_decimal2


                    line = line & PadLR(Trim(val_factor_peso_orden2), 11, "0")


                    ''line = line & PadL("000001.0000", 1, "")

                    Dim factor_peso_orden
                    factor_peso_orden = OBJTABLE_ITEMS.Rows(j).Item(12).ToString

                    Dim parte_entera
                    parte_entera = Int(factor_peso_orden)
                    parte_entera = parte_entera.ToString().PadLeft(6, "0")

                    Dim parte_decimal = OBJTABLE_ITEMS.Rows(j).Item(12).ToString
                    parte_decimal = Convert.ToDecimal(parte_decimal).ToString("N4")
                    Dim val_parte_decimal
                    val_parte_decimal = Mid(parte_decimal, InStrRev(parte_decimal, ".") + 1)

                    Dim val_factor_peso_orden
                    val_factor_peso_orden = parte_entera + "." + val_parte_decimal


                    line = line & PadLR(Trim(val_factor_peso_orden), 11, "0")

                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("", 4, " ")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("1", 1, "0")
                    line = line & PadL("", 8, " ")
                    Dim fecha_activacion, fecha_act
                    fecha_activacion = DateTime.Now
                    fecha_act = CDate(fecha_activacion).ToString("yyyyMMdd")
                    line = line & PadLR(fecha_act, 6, " ")
                    line = line & PadL("", 255, " ")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("", 10, " ")
                    line = line & PadL("0", 1, "0")


                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_items.Text & "', '" & txt_plano_items.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_ITEMS.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_items.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btn_csv_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csv_items.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_items.Text = OpenFileDialog1.FileName
        filePath10 = txt_csv_items.Text
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog10" Then
            txt_csv_items.Text = ""
        End If


    End Sub

    Private Sub btn_plano_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_items.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_items.Text = SaveFileDialog1.FileName
        filePath10 = txt_plano_items.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_items.Text = ""
            txt_plano_items.Text = ""
        End If

    End Sub

    Private Sub btn_est_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_items.Click
        System.Diagnostics.Process.Start(".\Planos\Items.xls")
        'exportar_plantilla_items()
    End Sub

    Private Sub btn_csv_clasitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csv_clasitems.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_clasitems.Text = OpenFileDialog1.FileName
        filePath11 = txt_csv_clasitems.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog11" Then
            txt_csv_clasitems.Text = ""
        End If

    End Sub

    Private Sub btn_plano_clasitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_clasitems.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_clasitems.Text = SaveFileDialog1.FileName
        filePath11 = txt_plano_clasitems.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_clasitems.Text = ""
            txt_plano_clasitems.Text = ""
        End If


    End Sub

    Private Sub btn_salir_clasitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_clasitems.Click
        End
    End Sub

    Private Sub btn_limpiar_clasitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_clasitems.Click

        txt_csv_clasitems.Text = ""
        txt_plano_clasitems.Text = ""

    End Sub

    Private Sub exportar_plantilla_clasitems()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("codigo,plan,mayor")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_est_clasitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_clasitems.Click
        System.Diagnostics.Process.Start(".\Planos\ClasificacionItems.xls")
        'exportar_plantilla_clasitems()
    End Sub

    Private Sub btn_generar_clasitems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_clasitems.Click

        If txt_csv_clasitems.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_clasitems.Focus()
            Exit Sub
        End If

        If txt_plano_clasitems.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_clasitems.Focus()
            Exit Sub
        End If

        generar_plano_clasitems()

    End Sub


    Private Sub generar_plano_clasitems()


        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath11 = txt_plano_clasitems.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath11)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_CLASITEMS.Rows.Clear()
                System.IO.File.Delete(filePath11)
                Try
                    FileOpen(1, filePath11, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    'PrintLine(1, line)
                    ' line = ""
                    txt_csv_clasitems.Text = OpenFileDialog1.FileName
                    'cargar_csv_clasitems()

                    OBJTABLE_CLASITEMS = GetDataExcel(txt_csv_clasitems.Text, Hojaslibro(txt_csv_clasitems.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""
                    Dim r

                    For j As Integer = 0 To OBJTABLE_CLASITEMS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""

                        line = r & PadL("0125", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("02", 2, " ")
                        line = line & PadL("180", 3, " ")
                        line = line & PadL("1", 1, "0")
                        line = line & PadL("0", 7, "0")
                        line = line & PadLR(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(0).ToString), 50, " ")
                        line = line & PadL(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(1).ToString), 3, "0")
                        'line = line & PadL(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(2).ToString), Nothing, Nothing)

                        ''Cuando es 006 - se habilitan las 2
                        'line = line & PadL(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(2).ToString), 2, "0")
                        'line = line & PadL("", 2, " ")

                        'Cuando es 007
                        line = line & PadLR(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(2).ToString), 4, " ")


                    Next

                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_clasitems.Text & "', '" & txt_plano_clasitems.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_CLASITEMS.Clear()


                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_clasitems.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath11, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                'PrintLine(1, line)
                'line = ""
                txt_csv_clasitems.Text = OpenFileDialog1.FileName
                'cargar_csv_clasitems()
                OBJTABLE_CLASITEMS = GetDataExcel(txt_csv_clasitems.Text, Hojaslibro(txt_csv_clasitems.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""
                Dim r

                For j As Integer = 0 To OBJTABLE_CLASITEMS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""

                    line = r & PadL("0125", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL("180", 3, " ")
                    line = line & PadL("1", 1, "0")
                    line = line & PadL("0", 7, "0")
                    line = line & PadLR(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(0).ToString), 50, " ")
                    line = line & PadL(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(1).ToString), 3, "0")
                    ' line = line & PadL(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(2).ToString), Nothing, Nothing)

                    'Cuando es 006 - se habilitan las 2
                    'line = line & PadL(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(2).ToString), 2, "0")
                    'line = line & PadL("", 2, " ")

                    'Cuando es 007
                    line = line & PadLR(Trim(OBJTABLE_CLASITEMS.Rows(j).Item(2).ToString), 4, " ")

                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_clasitems.Text & "', '" & txt_plano_clasitems.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_CLASITEMS.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_clasitems.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btn_salir_sol_compras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_sol_compras.Click
        End
    End Sub

    Private Sub Btn_generar_sol_compras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_generar_sol_compras.Click

        If txt_co_sol_compra.Text = "" Then
            MsgBox("Ingrese el centro operativo", MsgBoxStyle.Critical)
            txt_co_sol_compra.Focus()
            Exit Sub
        End If

        If txt_tip_doc_sol_compra.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tip_doc_sol_compra.Focus()
            Exit Sub
        End If

        If txt_notas_sol_compra.Text = "" Then
            MsgBox("Por favor ingrese una Nota valida para el encabezado", MsgBoxStyle.Critical)
            txt_notas_sol_compra.Focus()
            Exit Sub
        End If

        If txt_tercero_sol_compra.Text = "" Then
            MsgBox("Por favor ingrese una tercero válido", MsgBoxStyle.Critical)
            txt_tercero_sol_compra.Focus()
            Exit Sub
        End If

        If txt_csv_sol_compras.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_sol_compras.Focus()
            Exit Sub
        End If


        If txt_plano_sol_compra.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_sol_compra.Focus()
            Exit Sub
        End If

        Generar_plano_solicitudes_compra()

    End Sub

    Private Sub Generar_plano_solicitudes_compra()


        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath12 = txt_plano_sol_compra.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath12)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_SOLCOMPRAS.Rows.Clear()
                System.IO.File.Delete(filePath12)
                Dim fecha_doc
                Try
                    Me.Cursor = Cursors.WaitCursor

                    FileOpen(1, filePath12, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    PrintLine(1, line)
                    line = fijo2 & PadL("0420", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("04", 2, " ")
                    line = line & PadL(variable_centro_operativo, 3, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL(Trim(txt_co_sol_compra.Text), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_sol_compra.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    fecha_doc = CDate(Dtp_fecha_sol_compra.Text).ToString("yyyyMMdd")
                    line = line & PadL(fecha_doc, 8, " ")
                    line = line & PadL("401", 3, " ")
                    line = line & PadL("401", 3, " ")
                    line = line & PadL("401", 3, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadL("0", 1, " ")
                    line = line & PadLR(Trim(txt_tercero_sol_compra.Text), 15, " ")
                    line = line & PadL("", 15, " ")
                    line = line & PadL("", 3, " ")
                    line = line & PadL("", 3, " ")
                    line = line & PadL("", 1, "0")
                    line = line & PadL("", 3, " ")
                    line = line & PadL("", 3, " ")
                    line = line & PadL("00000000.0000", 13, " ")
                    line = line & PadL("", 3, " ")
                    line = line & PadL("00000000.0000", 13, " ")
                    line = line & PadL("000.0000", 8, " ")
                    line = line & PadL("000.0000", 8, " ")
                    line = line & PadLR(Trim(txt_notas_sol_compra.Text), 255, " ")
                    line = line & PadL("", 1, "0")
                    line = line & PadL("", 348, " ")
                    line = line & PadL("", 1, "0")


                    txt_csv_sol_compras.Text = OpenFileDialog1.FileName
                    'cargar_csv_solicitudes_compra()
                    OBJTABLE_SOLCOMPRAS = GetDataExcel(txt_csv_sol_compras.Text, Hojaslibro(txt_csv_sol_compras.Text))
                    Me.Label1.Text = "2"
                    Me.Label2.Text = ""

                    Dim r

                    For j As Integer = 0 To OBJTABLE_SOLCOMPRAS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = r & PadL("0421", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("03", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL(Trim(txt_co_sol_compra.Text), 3, " ")
                        line = line & PadL(Trim(txt_tip_doc_sol_compra.Text), 3, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadL("", 10, "0")
                        line = line & PadL("", 55, " ")
                        line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(0).ToString), 5, " ")
                        line = line & PadL("401", 3, " ")
                        line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(1).ToString), 2, "0")
                        line = line & PadL("", 1, "0")
                        line = line & PadL(Trim(txt_co_sol_compra.Text), 3, " ")
                        line = line & PadL("", 2, " ")
                        line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(2).ToString), 15, " ")
                        line = line & PadL("", 15, " ")
                        line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(4).ToString), 4, " ")

                        Dim cantidad
                        cantidad = OBJTABLE_SOLCOMPRAS.Rows(j).Item(5).ToString
                        If cantidad = "" Then
                            line = line & PadL("000000000000000.0000", 20, " ")
                        Else
                            cantidad = Convert.ToDecimal(cantidad).ToString("N4")
                            Dim val_cantidad As String
                            val_cantidad = Replace(cantidad, ",", "")
                            line = line & PadL(LTrim(val_cantidad), 20, "0")
                        End If

                        Dim fecha_entrega
                        fecha_entrega = (OBJTABLE_SOLCOMPRAS.Rows(j).Item(6).ToString)
                        fecha_entrega = CDate(fecha_entrega).ToString("yyyyMMdd")
                        line = line & PadL(fecha_doc, 8, " ")

                        line = line & PadL("", 15, " ")
                        line = line & PadL("000000000000000.0000", 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(7).ToString), 255, " ")
                        line = line & PadL("", 2000, " ")
                        line = line & PadL("", 44, " ")
                        line = line & PadL("", 7, "0")
                        line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(3).ToString), 50, " ")
                        line = line & PadL("", 60, " ")
                        line = line & PadLR("99", 20, " ")

                    Next

                    PrintLine(1, line)
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    OBJTABLE_SOLCOMPRAS.Clear()
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_sol_compras.Text & "', '" & txt_plano_sol_compra.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_sol_compra.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Dim fecha_doc

            Try
                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath12, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                PrintLine(1, line)
                line = fijo2 & PadL("0420", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("04", 2, " ")
                line = line & PadL(variable_centro_operativo, 3, " ")
                line = line & PadL("0", 1, " ")
                line = line & PadL("1", 1, " ")
                line = line & PadL(Trim(txt_co_sol_compra.Text), 3, " ")
                line = line & PadL(Trim(txt_tip_doc_sol_compra.Text), 3, " ")
                line = line & PadL("", 8, "0")
                fecha_doc = CDate(Dtp_fecha_sol_compra.Text).ToString("yyyyMMdd")
                line = line & PadL(fecha_doc, 8, " ")
                line = line & PadL("401", 3, " ")
                line = line & PadL("401", 3, " ")
                line = line & PadL("401", 3, " ")
                line = line & PadL("0", 1, " ")
                line = line & PadL("0", 1, " ")
                line = line & PadLR(Trim(txt_tercero_sol_compra.Text), 15, " ")
                line = line & PadL("", 15, " ")
                line = line & PadL("", 3, " ")
                line = line & PadL("", 3, " ")
                line = line & PadL("", 1, "0")
                line = line & PadL("", 3, " ")
                line = line & PadL("", 3, " ")
                line = line & PadL("00000000.0000", 13, " ")
                line = line & PadL("", 3, " ")
                line = line & PadL("00000000.0000", 13, " ")
                line = line & PadL("000.0000", 8, " ")
                line = line & PadL("000.0000", 8, " ")
                line = line & PadLR(Trim(txt_notas_sol_compra.Text), 255, " ")
                line = line & PadL("", 1, "0")
                line = line & PadL("", 348, " ")
                line = line & PadL("", 1, "0")


                txt_csv_sol_compras.Text = OpenFileDialog1.FileName
                'cargar_csv_solicitudes_compra()
                OBJTABLE_SOLCOMPRAS = GetDataExcel(txt_csv_sol_compras.Text, Hojaslibro(txt_csv_sol_compras.Text))
                Me.Label1.Text = "2"
                Me.Label2.Text = ""

                Dim r

                For j As Integer = 0 To OBJTABLE_SOLCOMPRAS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = r & PadL("0421", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("03", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL(Trim(txt_co_sol_compra.Text), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_sol_compra.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadL("", 10, "0")
                    line = line & PadL("", 55, " ")
                    line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(0).ToString), 5, " ")
                    line = line & PadL("401", 3, " ")
                    line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(1).ToString), 2, "0")
                    line = line & PadL("", 1, "0")
                    line = line & PadL(Trim(txt_co_sol_compra.Text), 3, " ")
                    line = line & PadL("", 2, " ")
                    line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(2).ToString), 15, " ")
                    line = line & PadL("", 15, " ")
                    line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(4).ToString), 4, " ")

                    Dim cantidad
                    cantidad = OBJTABLE_SOLCOMPRAS.Rows(j).Item(5).ToString
                    If cantidad = "" Then
                        line = line & PadL("000000000000000.0000", 20, " ")
                    Else
                        cantidad = Convert.ToDecimal(cantidad).ToString("N4")
                        Dim val_cantidad As String
                        val_cantidad = Replace(cantidad, ",", "")
                        line = line & PadL(LTrim(val_cantidad), 20, "0")
                    End If

                    Dim fecha_entrega
                    fecha_entrega = (OBJTABLE_SOLCOMPRAS.Rows(j).Item(6).ToString)
                    fecha_entrega = CDate(fecha_entrega).ToString("yyyyMMdd")
                    line = line & PadL(fecha_doc, 8, " ")

                    line = line & PadL("", 15, " ")
                    line = line & PadL("000000000000000.0000", 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(7).ToString), 255, " ")
                    line = line & PadL("", 2000, " ")
                    line = line & PadL("", 44, " ")
                    line = line & PadL("", 7, "0")
                    line = line & PadLR(Trim(OBJTABLE_SOLCOMPRAS.Rows(j).Item(3).ToString), 50, " ")
                    line = line & PadL("", 60, " ")
                    line = line & PadLR("99", 20, " ")

                Next

                PrintLine(1, line)
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                OBJTABLE_SOLCOMPRAS.Clear()
                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_sol_compras.Text & "', '" & txt_plano_sol_compra.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    FileClose(1)
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_sol_compra.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub




    Private Sub btn_csv_sol_compra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csv_sol_compra.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_sol_compras.Text = OpenFileDialog1.FileName
        filePath12 = txt_csv_sol_compras.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog12" Then
            txt_csv_sol_compras.Text = ""
        End If

    End Sub

    Private Sub btn_plano_sol_compra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_sol_compra.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_sol_compra.Text = SaveFileDialog1.FileName
        filePath12 = txt_plano_sol_compra.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_sol_compras.Text = ""
            txt_plano_sol_compra.Text = ""
        End If

    End Sub

    Private Sub btn_limpiar_sol_compra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_sol_compra.Click

        txt_co_sol_compra.Text = ""
        txt_tip_doc_sol_compra.Text = ""
        txt_notas_sol_compra.Text = ""
        txt_tercero_sol_compra.Text = ""
        txt_csv_sol_compras.Text = ""
        txt_plano_sol_compra.Text = ""

    End Sub

    Private Sub btn_est_sol_compra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_sol_compra.Click
        System.Diagnostics.Process.Start(".\Planos\SolicitudesCompra.xls")
        'exportar_plantilla_solicitudes_compra()
    End Sub

    Private Sub exportar_plantilla_solicitudes_compra()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("BODEGA,MOTIVO,CENTRO COSTO,REFERENCIA,UNIDAD MEDIDA,CANT,FECHA ENTREGA,NOTAS")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If
    End Sub

    Private Sub txt_co_sol_compra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_co_sol_compra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_tip_doc_sol_compra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tip_doc_sol_compra.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_tercero_sol_compra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tercero_sol_compra.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_salir_criterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_criterios.Click
        End
    End Sub

    Private Sub btn_csv_criterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csv_criterios.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_criterios.Text = OpenFileDialog1.FileName
        filePath13 = txt_csv_criterios.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog13" Then
            txt_csv_criterios.Text = ""
        End If

    End Sub

    Private Sub btn_plano_criterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_criterios.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_criterios.Text = SaveFileDialog1.FileName
        filePath13 = txt_plano_criterios.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_criterios.Text = ""
            txt_plano_criterios.Text = ""
        End If

    End Sub

    Private Sub btn_limipiar_criterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limipiar_criterios.Click

        txt_csv_criterios.Text = ""
        txt_plano_criterios.Text = ""

    End Sub

    Private Sub btn_generar_criterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_criterios.Click

        If txt_csv_criterios.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_criterios.Focus()
            Exit Sub
        End If

        If txt_plano_criterios.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_criterios.Focus()
            Exit Sub
        End If

        generar_plano_criterios()

    End Sub

    Private Sub generar_plano_criterios()


        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000001"
        FileClose(1)
        filePath13 = txt_plano_criterios.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath13)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Try

                    Me.Cursor = Cursors.WaitCursor

                    FileClose(1)
                    OBJTABLE_CRITERIOS.Rows.Clear()
                    System.IO.File.Delete(filePath13)
                    Me.Cursor = Cursors.WaitCursor

                    FileOpen(1, filePath13, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    ' PrintLine(1, line)

                    txt_csv_criterios.Text = OpenFileDialog1.FileName
                    'cargar_csv_criterios()
                    OBJTABLE_CRITERIOS = GetDataExcel(txt_csv_criterios.Text, Hojaslibro(txt_csv_criterios.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""

                    Dim r

                    For j As Integer = 0 To OBJTABLE_CRITERIOS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("0264", 4, "0")
                        line = line & PadL("00", 2, "0")
                        line = line & PadL("01", 2, "0")
                        line = line & PadL(variable_centro_operativo, 3, "0")
                        line = line & PadL("1", 1, "0")
                        line = line & PadL("0", 9, "0")
                        ' line = line & PadLR(Trim(OBJTABLE_CRITERIOS.Rows(j).Item(0).ToString), 20, " ")

                        Dim referencia
                        referencia = Trim(OBJTABLE_CRITERIOS.Rows(j).Item(0).ToString)
                        Dim ref As String = Mid(referencia, 1, 20)
                        line = line & PadLR(Trim(ref), 20, " ")

                        line = line & PadL(Trim(OBJTABLE_CRITERIOS.Rows(j).Item(1).ToString), 3, "0")
                        line = line & PadLR(Trim(OBJTABLE_CRITERIOS.Rows(j).Item(2).ToString), 4, " ")

                    Next


                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_criterios.Text & "', '" & txt_plano_criterios.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_CRITERIOS.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_criterios.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath13, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                ' PrintLine(1, line)

                txt_csv_criterios.Text = OpenFileDialog1.FileName
                'cargar_csv_criterios()
                OBJTABLE_CRITERIOS = GetDataExcel(txt_csv_criterios.Text, Hojaslibro(txt_csv_criterios.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""

                Dim r

                For j As Integer = 0 To OBJTABLE_CRITERIOS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("0264", 4, "0")
                    line = line & PadL("00", 2, "0")
                    line = line & PadL("01", 2, "0")
                    line = line & PadL(variable_centro_operativo, 3, "0")
                    line = line & PadL("1", 1, "0")
                    line = line & PadL("0", 9, "0")
                    ' line = line & PadLR(Trim(OBJTABLE_CRITERIOS.Rows(j).Item(0).ToString), 20, " ")

                    Dim referencia
                    referencia = Trim(OBJTABLE_CRITERIOS.Rows(j).Item(0).ToString)
                    Dim ref As String = Mid(referencia, 1, 20)
                    line = line & PadLR(Trim(ref), 20, " ")

                    line = line & PadL(Trim(OBJTABLE_CRITERIOS.Rows(j).Item(1).ToString), 3, "0")
                    line = line & PadLR(Trim(OBJTABLE_CRITERIOS.Rows(j).Item(2).ToString), 4, " ")

                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_criterios.Text & "', '" & txt_plano_criterios.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_CRITERIOS.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_criterios.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btn_est_criterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_criterios.Click
        System.Diagnostics.Process.Start(".\Planos\ClasificacionActivosFijos.xls")
        'exportar_plantilla_criterios()
    End Sub

    Private Sub exportar_plantilla_criterios()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("referencia,id_plan_criterios,id_criterio_mayor")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If
    End Sub

    Private Sub btn_csv_bajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csv_bajas.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_bajas.Text = OpenFileDialog1.FileName
        filePath14 = txt_csv_bajas.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog14" Then
            txt_csv_bajas.Text = ""
        End If

    End Sub

    Private Sub btn_planos_bajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_planos_bajas.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_bajas.Text = SaveFileDialog1.FileName
        filePath14 = txt_plano_bajas.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_bajas.Text = ""
            txt_plano_bajas.Text = ""
        End If

    End Sub

    Private Sub btn_limpiar_bajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_bajas.Click
        txt_co_bajas.Text = ""
        txt_tip_doc_bajas.Text = ""
        txt_notas_bajas.Text = ""
        txt_csv_bajas.Text = ""
        txt_plano_bajas.Text = ""
    End Sub

    Private Sub btn_salir_bajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_bajas.Click
        End
    End Sub

    Private Sub btn_generar_bajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_bajas.Click

        If txt_co_bajas.Text = "" Then
            MsgBox("Ingrese el centro operativo", MsgBoxStyle.Critical)
            txt_co_bajas.Focus()
            Exit Sub
        End If

        If txt_tip_doc_bajas.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tip_doc_bajas.Focus()
            Exit Sub
        End If

        If txt_notas_bajas.Text = "" Then
            MsgBox("Por favor ingrese una Nota valida para el encabezado", MsgBoxStyle.Critical)
            txt_notas_bajas.Focus()
            Exit Sub
        End If


        If txt_csv_bajas.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_bajas.Focus()
            Exit Sub
        End If


        If txt_plano_bajas.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_bajas.Focus()
            Exit Sub
        End If

        Generar_plano_bajas()

    End Sub

    Private Sub Generar_plano_bajas()


        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath14 = txt_plano_bajas.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath14)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_BAJAS.Rows.Clear()
                System.IO.File.Delete(filePath14)
                Dim fecha_doc

                Try
                    Me.Cursor = Cursors.WaitCursor

                    FileOpen(1, filePath14, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    PrintLine(1, line)
                    line = fijo2 & PadL("0368", 4, "0")
                    line = line & PadL("00", 2, "0")
                    line = line & PadL("02", 2, "0")
                    line = line & PadL(variable_centro_operativo, 3, "0")
                    line = line & PadL("1", 1, "0")
                    line = line & PadL(Trim(txt_co_bajas.Text), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_bajas.Text), 3, " ")
                    line = line & PadL("0", 8, "0")
                    fecha_doc = CDate(Dtp_fecha_doc_bajas.Text).ToString("yyyyMMdd")
                    line = line & PadL(fecha_doc, 8, " ")
                    line = line & PadL("097", 3, "000")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("0", 1, "0")
                    line = line & PadLR(Trim(txt_notas_bajas.Text), 255, " ")


                    txt_csv_bajas.Text = OpenFileDialog1.FileName
                    'cargar_csv_bajas()
                    OBJTABLE_BAJAS = GetDataExcel(txt_csv_bajas.Text, Hojaslibro(txt_csv_bajas.Text))
                    Me.Label1.Text = "2"
                    Me.Label2.Text = ""

                    Dim r

                    For j As Integer = 0 To OBJTABLE_BAJAS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = r & PadL("0368", 4, " ")
                        line = line & PadL("97", 2, " ")
                        line = line & PadL("02", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL(Trim(OBJTABLE_BAJAS.Rows(j).Item(0).ToString), 3, " ")
                        line = line & PadL(Trim(txt_tip_doc_bajas.Text), 3, " ")
                        line = line & PadL("0", 8, "0")
                        line = line & PadL("0", 9, "0")
                        line = line & PadLR(Trim(OBJTABLE_BAJAS.Rows(j).Item(1).ToString), 20, " ")
                        line = line & PadL(Trim(OBJTABLE_BAJAS.Rows(j).Item(2).ToString), 3, "0")
                        line = line & PadL(Trim(OBJTABLE_BAJAS.Rows(j).Item(3).ToString), 2, "0")
                        line = line & PadLR(Trim(OBJTABLE_BAJAS.Rows(j).Item(4).ToString), 100, " ")


                    Next


                    PrintLine(1, line)
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    OBJTABLE_BAJAS.Clear()
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_bajas.Text & "', '" & txt_plano_bajas.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_bajas.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Dim fecha_doc

            Try
                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath14, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                PrintLine(1, line)
                line = fijo2 & PadL("0368", 4, "0")
                line = line & PadL("00", 2, "0")
                line = line & PadL("02", 2, "0")
                line = line & PadL(variable_centro_operativo, 3, "0")
                line = line & PadL("1", 1, "0")
                line = line & PadL(Trim(txt_co_bajas.Text), 3, " ")
                line = line & PadL(Trim(txt_tip_doc_bajas.Text), 3, " ")
                line = line & PadL("0", 8, "0")
                fecha_doc = CDate(Dtp_fecha_doc_bajas.Text).ToString("yyyyMMdd")
                line = line & PadL(fecha_doc, 8, " ")
                line = line & PadL("097", 3, "000")
                line = line & PadL("0", 1, "0")
                line = line & PadL("0", 1, "0")
                line = line & PadLR(Trim(txt_notas_bajas.Text), 255, " ")


                txt_csv_bajas.Text = OpenFileDialog1.FileName
                'cargar_csv_bajas()
                OBJTABLE_BAJAS = GetDataExcel(txt_csv_bajas.Text, Hojaslibro(txt_csv_bajas.Text))
                Me.Label1.Text = "2"
                Me.Label2.Text = ""

                Dim r

                For j As Integer = 0 To OBJTABLE_BAJAS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = r & PadL("0368", 4, " ")
                    line = line & PadL("97", 2, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL(Trim(OBJTABLE_BAJAS.Rows(j).Item(0).ToString), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_bajas.Text), 3, " ")
                    line = line & PadL("0", 8, "0")
                    line = line & PadL("0", 9, "0")
                    line = line & PadLR(Trim(OBJTABLE_BAJAS.Rows(j).Item(1).ToString), 20, " ")
                    line = line & PadL(Trim(OBJTABLE_BAJAS.Rows(j).Item(2).ToString), 3, "0")
                    line = line & PadL(Trim(OBJTABLE_BAJAS.Rows(j).Item(3).ToString), 2, "0")
                    line = line & PadLR(Trim(OBJTABLE_BAJAS.Rows(j).Item(4).ToString), 100, " ")


                Next

                PrintLine(1, line)
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                OBJTABLE_BAJAS.Clear()
                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_bajas.Text & "', '" & txt_plano_bajas.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    FileClose(1)
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_bajas.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub


    Private Sub btn_est_bajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_bajas.Click
        System.Diagnostics.Process.Start(".\Planos\Bajas_Activos_Fijos.xls")
        'exportar_plantilla_bajas()
    End Sub

    Private Sub exportar_plantilla_bajas()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("centro operación,referencia,adicion,motivo,notas")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If
    End Sub

    Private Sub btn_csv_cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csv_cuentas.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_cuentas.Text = OpenFileDialog1.FileName
        filePath15 = txt_co_cuentas.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog15" Then
            txt_csv_cuentas.Text = ""
        End If

    End Sub

    Private Sub btn_plano_cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_cuentas.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_cuentas.Text = SaveFileDialog1.FileName
        filePath15 = txt_plano_cuentas.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_cuentas.Text = ""
            txt_plano_cuentas.Text = ""
        End If


    End Sub

    Private Sub btn_est_cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_cuentas.Click
        System.Diagnostics.Process.Start(".\Planos\CuentasXporPagar.xls")
        'exportar_plantilla_cuentas()
    End Sub

    Private Sub exportar_plantilla_cuentas()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("TIPO,CO,Cuenta,Tercero,Sucursal,Centro Costos,Valor DB,Valor Cr,Valor DB 2,Valor Cr 2,Tipo Doc,Nro Doc,Vencimiento,Notas")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_salir_cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_cuentas.Click
        End
    End Sub

    Private Sub btn_limpiar_cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_cuentas.Click

        txt_co_cuentas.Text = ""
        txt_tip_doc_cuentas.Text = ""
        ' txt_cuenta_cont_cuenta.Text = ""
        'txt_cuentasxcobrar_cuentas.Text = ""
        txt_notas_cuenta.Text = ""
        ' txt_tercero_cuenta.Text = ""
        txt_csv_cuentas.Text = ""
        txt_plano_cuentas.Text = ""


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        rbActivar.Checked = False
        rbSuspender.Checked = False
        cbpcga.Checked = False
        cbniif.Checked = False
        txtExcelCambioEstadoActFijos.Text = ""
    End Sub

    Private Sub btnGenerarCambioEstadoActivosFijos_Click(sender As Object, e As EventArgs) Handles btnGenerarCambioEstadoActivosFijos.Click
        Try
            If txtExcelCambioEstadoActFijos.Text = "" Then
                MessageBox.Show("Debe seleccionar el excel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If cbpcga.Checked = False And cbniif.Checked = False Then
                MessageBox.Show("Seleccione los libros a actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If rbActivar.Checked = False And rbSuspender.Checked = False Then
                MessageBox.Show("Seleccione una opcion de actualizacion de estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            'cargar informacion
            Dim dt As New DataTable
            dt = GetDataExcel(txtExcelCambioEstadoActFijos.Text, Hojaslibro(txtExcelCambioEstadoActFijos.Text))
            If dt.Rows.Count = 0 Then
                MessageBox.Show("El excel no contiene filas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            CambiosEstadoActivosFijos(dt)
            sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txtExcelCambioEstadoActFijos.Text & "', ' ', getdate() , '" & lSt_CodUsuario & "' )"
            Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub CambiosEstadoActivosFijos(ByVal dt As DataTable)
        Dim xml As String = ""

        For Each dr As DataRow In dt.Rows
            If dr(0).ToString <> "" Then

                Dim codigo As Decimal
                Dim texto As String = dr(0).ToString()
                texto = Microsoft.VisualBasic.Left(texto, 9)

                codigo = CDec(texto) * 1

                xml = xml + "<row codigo='" + codigo.ToString + "' />"
            End If
        Next
        Dim conexion As New clsConexionNew
        Dim LstParametros As New List(Of Parametros)()
        LstParametros.Add(New Parametros("@xml", xml.Replace("'", Chr(34)), SqlDbType.Xml))
        LstParametros.Add(New Parametros("@pcga", cbpcga.Checked, SqlDbType.Bit))
        LstParametros.Add(New Parametros("@niif", cbniif.Checked, SqlDbType.Bit))
        LstParametros.Add(New Parametros("@Actualizacion", IIf(rbActivar.Checked, "A", "S"), SqlDbType.Char))

        Dim respuesta As String
        respuesta = conexion.SPGetEscalar("SP_ActivacionEstadoActivosFijos", LstParametros)
        If respuesta = "" Then
            MessageBox.Show("Cargado Correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            rbActivar.Checked = False
            rbSuspender.Checked = False
            cbpcga.Checked = False
            cbniif.Checked = False
            txtExcelCambioEstadoActFijos.Text = ""
        Else
            MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnCargueEstadoActivosFijos_Click(sender As Object, e As EventArgs) Handles btnCargueEstadoActivosFijos.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txtExcelCambioEstadoActFijos.Text = OpenFileDialog1.FileName
        filePath20 = txtExcelCambioEstadoActFijos.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog20" Then
            txtExcelCambioEstadoActFijos.Text = ""
        End If
    End Sub

    Private Sub btnGenerarMovContab_Click(sender As Object, e As EventArgs) Handles btnGenerarMovContab.Click

        If txtCoMovContable.Text = "" Then
            MessageBox.Show("Debe ingresar el centro operativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCoMovContable.Focus()
            Return
        End If

        If txtTipodocMovCont.Text = "" Then
            MessageBox.Show("Debe ingresar el tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTipodocMovCont.Focus()
            Return
        End If


        If txtArchivoExcelMovCont.Text = "" Then
            MessageBox.Show("Debe seleccionar el archivo excel a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtArchivoExcelMovCont.Focus()
            Return
        End If

        If txtArchivoPlanoMovCont.Text = "" Then
            MessageBox.Show("Debe seleccionar la ruta del archivo plano a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtArchivoPlanoMovCont.Focus()
            Return
        End If



        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim conexion As New clsConexionNew
            dt = GetDataExcel(txtArchivoExcelMovCont.Text, Hojaslibro(txtArchivoExcelMovCont.Text))
            ds.Tables.Add(dt)
            Dim texto As String = ds.GetXml

            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@Details", texto, SqlDbType.Xml))
            LstParametros.Add(New Parametros("@EMPRESA", variable_centro_operativo, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@IDTERCERO", variable_NIT, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@CO", txtCoMovContable.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@TIPODOCTO", txtTipodocMovCont.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@FECHA", dtpFechaDocMovCont.Value, SqlDbType.Date))
            LstParametros.Add(New Parametros("@NOTAS", txtNotasMovContab.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@USUARIO", My.User.Name, SqlDbType.VarChar))

            Dim resultado As String
            resultado = conexion.SPGetEscalar("SP_PlanoMovientosContables", LstParametros)
            If resultado = "" Then
                Dim exists As Boolean = System.IO.File.Exists(txtArchivoPlanoMovCont.Text)

                If exists Then
                    System.IO.File.Delete(txtArchivoPlanoMovCont.Text)
                End If


                Dim sql As String = "select sarta from Tbl_Plano where Usuario = '" + My.User.Name + "' order by Sarta"
                Dim sarta As DataTable = New DataTable
                sarta = conexion.ObtenerDataTable(sql)
                Dim plano As New StreamWriter(txtArchivoPlanoMovCont.Text)
                For Each dr As DataRow In sarta.Rows
                    plano.Write(dr(0).ToString & vbNewLine)
                Next
                plano.Flush()
                plano.Close()

                MessageBox.Show("Se genero correctamente el plano", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Try
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txtArchivoExcelMovCont.Text & "', ' ', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)
                Catch ex As Exception

                End Try

            Else
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnExcelMovConta_Click(sender As Object, e As EventArgs) Handles btnExcelMovConta.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txtArchivoExcelMovCont.Text = OpenFileDialog1.FileName
        filePath20 = txtArchivoExcelMovCont.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog20" Then
            txtArchivoExcelMovCont.Text = ""
        End If
    End Sub

    Private Sub TabPage_Mov_Contab_New_Click(sender As Object, e As EventArgs) Handles TabPage_Mov_Contab_New.Click

    End Sub

    Private Sub btnExportarPlanoMovCont_Click(sender As Object, e As EventArgs) Handles btnExportarPlanoMovCont.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txtArchivoPlanoMovCont.Text = SaveFileDialog1.FileName
        filePath20 = txtArchivoPlanoMovCont.Text

        If SaveFileDialog1.FileName = "" Then
            txtArchivoPlanoMovCont.Text = ""
        End If
    End Sub

    Private Sub btnExportarEstMovCont_Click(sender As Object, e As EventArgs) Handles btnExportarEstMovCont.Click
        System.Diagnostics.Process.Start(".\Planos\MOVCONTABLE.xls")

    End Sub

    Private Sub btnLimpiarMovCont_Click(sender As Object, e As EventArgs) Handles btnLimpiarMovCont.Click
        txtCoMovContable.Text = ""
        txtTipodocMovCont.Text = ""
        txtNotasMovContab.Text = ""
        txtArchivoExcelMovCont.Text = ""
        txtArchivoPlanoMovCont.Text = ""
    End Sub

    Private Sub btnSalirMovConta_Click(sender As Object, e As EventArgs) Handles btnSalirMovConta.Click
        End
    End Sub

    Private Sub btn_generar_cuentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_cuentas.Click

        If txt_co_cuentas.Text = "" Then
            MsgBox("Ingrese el centro operativo", MsgBoxStyle.Critical)
            txt_co_cuentas.Focus()
            Exit Sub
        End If

        If txt_tip_doc_cuentas.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tip_doc_cuentas.Focus()
            Exit Sub
        End If

        'If txt_cuenta_cont_cuenta.Text = "" Then
        '    MsgBox("Ingrese la cuenta contable", MsgBoxStyle.Critical)
        '    txt_cuenta_cont_cuenta.Focus()
        '    Exit Sub
        'End If

        'If txt_tercero_cuenta.Text = "" Then
        '    MsgBox("Ingrese un tercero válido", MsgBoxStyle.Critical)
        '    txt_tercero_cuenta.Focus()
        '    Exit Sub
        'End If

        'If txt_cuentasxcobrar_cuentas.Text = "" Then
        '    MsgBox("Ingrese la cuenta por cobrar", MsgBoxStyle.Critical)
        '    txt_cuentasxcobrar_cuentas.Focus()
        '    Exit Sub
        'End If


        If txt_notas_cuenta.Text = "" Then
            MsgBox("Por favor ingrese una Nota valida para el encabezado", MsgBoxStyle.Critical)
            txt_notas_cuenta.Focus()
            Exit Sub
        End If

        If txt_csv_cuentas.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_cuentas.Focus()
            Exit Sub
        End If


        If txt_plano_cuentas.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_cuentas.Focus()
            Exit Sub
        End If

        Generar_plano_cuentasxcobrar()



    End Sub


    Private Sub Generar_plano_cuentasxcobrar()

        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath15 = txt_plano_cuentas.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath15)

        If exists Then

            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_CUENTASXPAGAR.Rows.Clear()
                System.IO.File.Delete(filePath15)
                Dim fecha_doc


                Try

                    Me.Cursor = Cursors.WaitCursor
                    FileOpen(1, filePath15, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    PrintLine(1, line)
                    line = ""
                    line = fijo2 & PadL("0350", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL(Trim(txt_co_cuentas.Text), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_cuentas.Text), 3, " ")
                    line = line & PadL(Trim(""), 8, "0")
                    fecha_doc = CDate(Dtp_fecha_doc_cuentas.Text).ToString("yyyyMMdd")
                    line = line & PadL(Trim(fecha_doc), 8, " ")
                    line = line & PadLR(Trim(variable_NIT), 15, " ")
                    'line = line & PadL(Trim("000"), 3, " ")
                    line = line & PadL(Trim("30"), 5, "0")
                    line = line & PadL(Trim("0"), 1, "0")
                    line = line & PadL(Trim("0"), 1, "0")
                    line = line & PadLR(Trim(txt_notas_cuenta.Text), 255, " ")
                    line = line & PadL("", 15, " ")

                    txt_csv_cuentas.Text = OpenFileDialog1.FileName
                    'cargar_csv_cuentasxpagar_movimiento()
                    OBJTABLE_CUENTASXPAGAR = GetDataExcel(txt_csv_cuentas.Text, Hojaslibro(txt_csv_cuentas.Text))
                    Me.Label1.Text = "2"
                    Me.Label2.Text = ""
                    Dim r


                    'Se graba Movimiento

                    For j As Integer = 0 To OBJTABLE_CUENTASXPAGAR.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("0351", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("04", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        line = line & PadL(Trim(txt_co_cuentas.Text), 3, " ")
                        line = line & PadL(Trim(txt_tip_doc_cuentas.Text), 3, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(2).ToString), 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(3).ToString), 15, " ")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(1).ToString), 3, " ")
                        line = line & PadLR("99", 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(5).ToString), 15, " ")
                        line = line & PadL("", 10, " ")


                        Dim DEBITO
                        DEBITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(6).ToString
                        If DEBITO = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If DEBITO < 0 Then
                                DEBITO = "-" & DEBITO
                                DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                                Dim val_DEBITO As String
                                val_DEBITO = Replace(DEBITO, ",", "")
                                line = line & "-" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                            Else
                                DEBITO = "+" & DEBITO
                                DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                                Dim val_DEBITO As String
                                val_DEBITO = Replace(DEBITO, ",", "")
                                line = line & "+" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                            End If

                        End If

                        Dim CREDITO
                        CREDITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(7).ToString
                        If CREDITO = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If CREDITO < 0 Then
                                CREDITO = "-" & CREDITO
                                CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                                Dim val_CREDITO As String
                                val_CREDITO = Replace(CREDITO, ",", "")
                                line = line & "-" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                            Else
                                CREDITO = "+" & CREDITO
                                CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                                Dim val_CREDITO As String
                                val_CREDITO = Replace(CREDITO, ",", "")
                                line = line & "+" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                            End If

                        End If


                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")

                        Dim DEBITO2
                        DEBITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(8).ToString
                        If DEBITO2 = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If DEBITO2 < 0 Then
                                DEBITO2 = "-" & DEBITO2
                                DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                                Dim val_DEBITO2 As String
                                val_DEBITO2 = Replace(DEBITO2, ",", "")
                                line = line & "-" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                            Else
                                DEBITO2 = "+" & DEBITO2
                                DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                                Dim val_DEBITO2 As String
                                val_DEBITO2 = Replace(DEBITO2, ",", "")
                                line = line & "+" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                            End If

                        End If

                        Dim CREDITO2
                        CREDITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(9).ToString
                        If CREDITO2 = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If CREDITO2 < 0 Then
                                CREDITO2 = "-" & CREDITO2
                                CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                                Dim val_CREDITO2 As String
                                val_CREDITO2 = Replace(CREDITO2, ",", "")
                                line = line & "-" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                            Else
                                CREDITO2 = "+" & CREDITO2
                                CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                                Dim val_CREDITO2 As String
                                val_CREDITO2 = Replace(CREDITO2, ",", "")
                                line = line & "+" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                            End If

                        End If

                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")


                        line = line & PadL("", 2, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadL("", 30, " ")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(13).ToString), 255, " ")

                    Next


                    'Se graba cuentas x PAGAR


                    txt_csv_cuentas.Text = OpenFileDialog1.FileName
                    'cargar_csv_cuentasxpagar()
                    OBJTABLE_CUENTASXPAGAR = GetDataExcel(txt_csv_cuentas.Text, Hojaslibro(txt_csv_cuentas.Text))

                    For j As Integer = 0 To OBJTABLE_CUENTASXPAGAR.Rows.Count - 1

                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("0351", 4, " ")
                        line = line & PadL("02", 2, " ")
                        line = line & PadL("06", 2, " ")
                        line = line & PadL(RTrim(variable_centro_operativo), 3, " ")


                        line = line & PadL(Trim(txt_co_cuentas.Text), 3, " ")

                        line = line & PadL(Trim(txt_tip_doc_cuentas.Text), 3, " ")
                        line = line & PadL("", 8, "0")

                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(2).ToString), 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(3).ToString), 15, " ")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(1).ToString), 3, " ")

                        line = line & PadLR("99", 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(5).ToString), 15, " ")

                        Dim DEBITO
                        DEBITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(6).ToString
                        If DEBITO = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If DEBITO < 0 Then
                                DEBITO = "-" & DEBITO
                                DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                                Dim val_DEBITO As String
                                val_DEBITO = Replace(DEBITO, ",", "")
                                line = line & "-" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                            Else
                                DEBITO = "+" & DEBITO
                                DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                                Dim val_DEBITO As String
                                val_DEBITO = Replace(DEBITO, ",", "")
                                line = line & "+" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                            End If

                        End If

                        Dim CREDITO
                        CREDITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(7).ToString
                        If CREDITO = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If CREDITO < 0 Then
                                CREDITO = "-" & CREDITO
                                CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                                Dim val_CREDITO As String
                                val_CREDITO = Replace(CREDITO, ",", "")
                                line = line & "-" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                            Else
                                CREDITO = "+" & CREDITO
                                CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                                Dim val_CREDITO As String
                                val_CREDITO = Replace(CREDITO, ",", "")
                                line = line & "+" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                            End If

                        End If


                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")

                        Dim DEBITO2
                        DEBITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(8).ToString
                        If DEBITO2 = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If DEBITO2 < 0 Then
                                DEBITO2 = "-" & DEBITO2
                                DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                                Dim val_DEBITO2 As String
                                val_DEBITO2 = Replace(DEBITO2, ",", "")
                                line = line & "-" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                            Else
                                DEBITO2 = "+" & DEBITO2
                                DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                                Dim val_DEBITO2 As String
                                val_DEBITO2 = Replace(DEBITO2, ",", "")
                                line = line & "+" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                            End If

                        End If

                        Dim CREDITO2
                        CREDITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(9).ToString
                        If CREDITO2 = "" Then
                            'debito = debito
                            line = line & PadL("+" & "000000000000000.0000", 20, "")
                        Else

                            If CREDITO2 < 0 Then
                                CREDITO2 = "-" & CREDITO2
                                CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                                Dim val_CREDITO2 As String
                                val_CREDITO2 = Replace(CREDITO2, ",", "")
                                line = line & "-" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                            Else
                                CREDITO2 = "+" & CREDITO2
                                CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                                Dim val_CREDITO2 As String
                                val_CREDITO2 = Replace(CREDITO2, ",", "")
                                line = line & "+" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                            End If

                        End If

                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        'line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        'line = line & PadL("+" & "000000000000000.0000", 20, " ")

                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(13).ToString), 255, " ")
                        line = line & PadL(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(4).ToString), 3, "0")
                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(10).ToString), 20, " ")
                        line = line & PadL(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(11).ToString), 8, "0")

                        line = line & PadL("", 3, "0")
                        line = line & PadL("", 10, " ")


                        Dim fecha_ven, fec, fec2, fec3, fecha_pronto_pago, fecha_doc_cruce As String
                        fec = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(12).ToString
                        fecha_ven = CDate(fec).ToString("yyyyMMdd")
                        line = line & PadL(fecha_ven, 8, " ")

                        fec2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(12).ToString
                        fecha_pronto_pago = CDate(fec2).ToString("yyyyMMdd")
                        line = line & PadL(fecha_pronto_pago, 8, " ")

                        fec3 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(12).ToString
                        fecha_doc_cruce = CDate(fec3).ToString("yyyyMMdd")
                        line = line & PadL(fecha_doc_cruce, 8, " ")


                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")
                        line = line & PadL("+" & "000000000000000.0000", 20, " ")

                        line = line & PadL("", 8, " ")

                        line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(13).ToString), 255, " ")

                    Next


                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora


                    OBJTABLE_CARNICOS.Clear()
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_cuentas.Text & "', '" & txt_plano_cuentas.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_cuentas.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Dim fecha_doc

            Try

                Me.Cursor = Cursors.WaitCursor
                FileOpen(1, filePath15, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                PrintLine(1, line)
                line = ""
                line = fijo2 & PadL("0350", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("02", 2, " ")
                line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                line = line & PadL("1", 1, " ")
                line = line & PadL(Trim(txt_co_cuentas.Text), 3, " ")
                line = line & PadL(Trim(txt_tip_doc_cuentas.Text), 3, " ")
                line = line & PadL(Trim(""), 8, "0")
                fecha_doc = CDate(Dtp_fecha_doc_cuentas.Text).ToString("yyyyMMdd")
                line = line & PadL(Trim(fecha_doc), 8, " ")
                line = line & PadLR(Trim(variable_NIT), 15, " ")
                'line = line & PadL(Trim("000"), 3, " ")
                line = line & PadL(Trim("30"), 5, "0")
                line = line & PadL(Trim("0"), 1, "0")
                line = line & PadL(Trim("0"), 1, "0")
                line = line & PadLR(Trim(txt_notas_cuenta.Text), 255, " ")
                line = line & PadL("", 15, " ")

                txt_csv_cuentas.Text = OpenFileDialog1.FileName
                cargar_csv_cuentasxpagar_movimiento()

                Me.Label1.Text = "2"
                Me.Label2.Text = ""
                Dim r


                'Se graba Movimiento

                For j As Integer = 0 To OBJTABLE_CUENTASXPAGAR.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("0351", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("04", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL(Trim(txt_co_cuentas.Text), 3, " ")
                    line = line & PadL(Trim(txt_tip_doc_cuentas.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(2).ToString), 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(3).ToString), 15, " ")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(1).ToString), 3, " ")
                    line = line & PadLR("99", 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(5).ToString), 15, " ")
                    line = line & PadL("", 10, " ")


                    Dim DEBITO
                    DEBITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(6).ToString
                    If DEBITO = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If DEBITO < 0 Then
                            DEBITO = "-" & DEBITO
                            DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                            Dim val_DEBITO As String
                            val_DEBITO = Replace(DEBITO, ",", "")
                            line = line & "-" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                        Else
                            DEBITO = "+" & DEBITO
                            DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                            Dim val_DEBITO As String
                            val_DEBITO = Replace(DEBITO, ",", "")
                            line = line & "+" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                        End If

                    End If

                    Dim CREDITO
                    CREDITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(7).ToString
                    If CREDITO = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If CREDITO < 0 Then
                            CREDITO = "-" & CREDITO
                            CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                            Dim val_CREDITO As String
                            val_CREDITO = Replace(CREDITO, ",", "")
                            line = line & "-" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                        Else
                            CREDITO = "+" & CREDITO
                            CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                            Dim val_CREDITO As String
                            val_CREDITO = Replace(CREDITO, ",", "")
                            line = line & "+" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                        End If

                    End If


                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")

                    Dim DEBITO2
                    DEBITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(8).ToString
                    If DEBITO2 = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If DEBITO2 < 0 Then
                            DEBITO2 = "-" & DEBITO2
                            DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                            Dim val_DEBITO2 As String
                            val_DEBITO2 = Replace(DEBITO2, ",", "")
                            line = line & "-" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                        Else
                            DEBITO2 = "+" & DEBITO2
                            DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                            Dim val_DEBITO2 As String
                            val_DEBITO2 = Replace(DEBITO2, ",", "")
                            line = line & "+" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                        End If

                    End If

                    Dim CREDITO2
                    CREDITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(9).ToString
                    If CREDITO2 = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If CREDITO2 < 0 Then
                            CREDITO2 = "-" & CREDITO2
                            CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                            Dim val_CREDITO2 As String
                            val_CREDITO2 = Replace(CREDITO2, ",", "")
                            line = line & "-" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                        Else
                            CREDITO2 = "+" & CREDITO2
                            CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                            Dim val_CREDITO2 As String
                            val_CREDITO2 = Replace(CREDITO2, ",", "")
                            line = line & "+" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                        End If

                    End If

                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")


                    line = line & PadL("", 2, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadL("", 30, " ")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(13).ToString), 255, " ")

                Next


                'Se graba cuentas x PAGAR


                txt_csv_cuentas.Text = OpenFileDialog1.FileName
                cargar_csv_cuentasxpagar()


                For j As Integer = 0 To OBJTABLE_CUENTASXPAGAR.Rows.Count - 1

                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("0351", 4, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL("06", 2, " ")
                    line = line & PadL(RTrim(variable_centro_operativo), 3, " ")


                    line = line & PadL(Trim(txt_co_cuentas.Text), 3, " ")

                    line = line & PadL(Trim(txt_tip_doc_cuentas.Text), 3, " ")
                    line = line & PadL("", 8, "0")

                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(2).ToString), 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(3).ToString), 15, " ")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(1).ToString), 3, " ")

                    line = line & PadLR("99", 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(5).ToString), 15, " ")

                    Dim DEBITO
                    DEBITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(6).ToString
                    If DEBITO = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If DEBITO < 0 Then
                            DEBITO = "-" & DEBITO
                            DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                            Dim val_DEBITO As String
                            val_DEBITO = Replace(DEBITO, ",", "")
                            line = line & "-" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                        Else
                            DEBITO = "+" & DEBITO
                            DEBITO = Convert.ToDecimal(DEBITO).ToString("N2")
                            Dim val_DEBITO As String
                            val_DEBITO = Replace(DEBITO, ",", "")
                            line = line & "+" & PadL(Trim(val_DEBITO) & "00", 20, "0")
                        End If

                    End If

                    Dim CREDITO
                    CREDITO = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(7).ToString
                    If CREDITO = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If CREDITO < 0 Then
                            CREDITO = "-" & CREDITO
                            CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                            Dim val_CREDITO As String
                            val_CREDITO = Replace(CREDITO, ",", "")
                            line = line & "-" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                        Else
                            CREDITO = "+" & CREDITO
                            CREDITO = Convert.ToDecimal(CREDITO).ToString("N2")
                            Dim val_CREDITO As String
                            val_CREDITO = Replace(CREDITO, ",", "")
                            line = line & "+" & PadL(Trim(val_CREDITO) & "00", 20, "0")
                        End If

                    End If


                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")

                    Dim DEBITO2
                    DEBITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(8).ToString
                    If DEBITO2 = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If DEBITO2 < 0 Then
                            DEBITO2 = "-" & DEBITO2
                            DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                            Dim val_DEBITO2 As String
                            val_DEBITO2 = Replace(DEBITO2, ",", "")
                            line = line & "-" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                        Else
                            DEBITO2 = "+" & DEBITO2
                            DEBITO2 = Convert.ToDecimal(DEBITO2).ToString("N2")
                            Dim val_DEBITO2 As String
                            val_DEBITO2 = Replace(DEBITO2, ",", "")
                            line = line & "+" & PadL(Trim(val_DEBITO2) & "00", 20, "0")
                        End If

                    End If

                    Dim CREDITO2
                    CREDITO2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(9).ToString
                    If CREDITO2 = "" Then
                        'debito = debito
                        line = line & PadL("+" & "000000000000000.0000", 20, "")
                    Else

                        If CREDITO2 < 0 Then
                            CREDITO2 = "-" & CREDITO2
                            CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                            Dim val_CREDITO2 As String
                            val_CREDITO2 = Replace(CREDITO2, ",", "")
                            line = line & "-" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                        Else
                            CREDITO2 = "+" & CREDITO2
                            CREDITO2 = Convert.ToDecimal(CREDITO2).ToString("N2")
                            Dim val_CREDITO2 As String
                            val_CREDITO2 = Replace(CREDITO2, ",", "")
                            line = line & "+" & PadL(Trim(val_CREDITO2) & "00", 20, "0")
                        End If

                    End If

                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    'line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    'line = line & PadL("+" & "000000000000000.0000", 20, " ")

                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(13).ToString), 255, " ")
                    line = line & PadL(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(4).ToString), 3, "0")
                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(10).ToString), 20, " ")
                    line = line & PadL(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(11).ToString), 8, "0")

                    line = line & PadL("", 3, "0")
                    line = line & PadL("", 10, " ")


                    Dim fecha_ven, fec, fec2, fec3, fecha_pronto_pago, fecha_doc_cruce As String
                    fec = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(12).ToString
                    fecha_ven = CDate(fec).ToString("yyyyMMdd")
                    line = line & PadL(fecha_ven, 8, " ")

                    fec2 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(12).ToString
                    fecha_pronto_pago = CDate(fec2).ToString("yyyyMMdd")
                    line = line & PadL(fecha_pronto_pago, 8, " ")

                    fec3 = OBJTABLE_CUENTASXPAGAR.Rows(j).Item(12).ToString
                    fecha_doc_cruce = CDate(fec3).ToString("yyyyMMdd")
                    line = line & PadL(fecha_doc_cruce, 8, " ")


                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")
                    line = line & PadL("+" & "000000000000000.0000", 20, " ")

                    line = line & PadL("", 8, " ")

                    line = line & PadLR(Trim(OBJTABLE_CUENTASXPAGAR.Rows(j).Item(13).ToString), 255, " ")

                Next


                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                OBJTABLE_CUENTASXPAGAR.Clear()
                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_cuentas.Text & "', '" & txt_plano_cuentas.Text & "', getdate() , '" & lSt_CodUsuario & "'  )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_cuentas.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub btn_salir_traslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_traslados.Click
        End
    End Sub

    Private Sub btn_limpiar_traslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_traslados.Click

        txt_co_traslados.Text = ""
        txt_tipdoc_traslados.Text = ""
        txt_notas_traslados.Text = ""
        txt_csv_traslados.Text = ""
        txt_plano_traslados.Text = ""


    End Sub

    Private Sub btn_traslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_traslados.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_traslados.Text = OpenFileDialog1.FileName
        filePath16 = txt_csv_traslados.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog16" Then
            txt_csv_traslados.Text = ""
        End If

    End Sub

    Private Sub btn_plano_traslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_traslados.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_traslados.Text = SaveFileDialog1.FileName
        filePath16 = txt_plano_traslados.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_traslados.Text = ""
            txt_plano_traslados.Text = ""
        End If

    End Sub

    Private Sub btn_generar_traslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_traslados.Click

        If txt_co_traslados.Text = "" Then
            MsgBox("Ingrese el centro operativo", MsgBoxStyle.Critical)
            txt_co_traslados.Focus()
            Exit Sub
        End If

        If txt_tipdoc_traslados.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tipdoc_traslados.Focus()
            Exit Sub
        End If


        If txt_notas_traslados.Text = "" Then
            MsgBox("Por favor ingrese una Nota valida para el encabezado", MsgBoxStyle.Critical)
            txt_notas_traslados.Focus()
            Exit Sub
        End If

        If txt_csv_traslados.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_traslados.Focus()
            Exit Sub
        End If


        If txt_plano_traslados.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_traslados.Focus()
            Exit Sub
        End If

        Generar_plano_traslados()

    End Sub


    Private Sub Generar_plano_traslados()

        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath16 = txt_plano_traslados.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath16)

        If exists Then

            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_TRASLADOS.Rows.Clear()
                System.IO.File.Delete(filePath16)
                Dim fecha_doc


                Try

                    Me.Cursor = Cursors.WaitCursor
                    FileOpen(1, filePath16, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    PrintLine(1, line)
                    line = ""
                    line = fijo2 & PadL("0368", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    line = line & PadL("1", 1, " ")
                    line = line & PadL(Trim(txt_co_traslados.Text), 3, " ")
                    'line = line & PadL("190", 3, " ")
                    line = line & PadL(Trim(txt_tipdoc_traslados.Text), 3, " ")
                    line = line & PadL(Trim(""), 8, "0")
                    fecha_doc = CDate(Dtp_fechadoc_traslados.Text).ToString("yyyyMMdd")
                    line = line & PadL(Trim(fecha_doc), 8, " ")
                    line = line & PadL(Trim("095"), 3, "0")
                    line = line & PadL(Trim("0"), 1, "0")
                    line = line & PadL(Trim("0"), 1, "0")
                    line = line & PadLR(Trim(txt_notas_traslados.Text), 255, " ")


                    txt_csv_traslados.Text = OpenFileDialog1.FileName
                    'cargar_csv_traslados()
                    OBJTABLE_TRASLADOS = GetDataExcel(txt_csv_traslados.Text, Hojaslibro(txt_csv_traslados.Text))
                    Me.Label1.Text = "2"
                    Me.Label2.Text = ""
                    Dim r


                    For j As Integer = 0 To OBJTABLE_TRASLADOS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("0368", 4, " ")
                        line = line & PadL("95", 2, " ")
                        line = line & PadL("02", 2, " ")
                        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                        'line = line & PadL("190", 3, " ")
                        line = line & PadL(Trim(txt_co_traslados.Text), 3, " ")
                        line = line & PadL(Trim(txt_tipdoc_traslados.Text), 3, " ")
                        line = line & PadL("", 8, "0")
                        line = line & PadL("", 9, "0")

                        Dim referencia
                        referencia = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(0).ToString)
                        Dim ref As String = Mid(referencia, 1, 20)
                        line = line & PadLR(Trim(ref), 20, " ")

                        Dim tipo_inventario
                        tipo_inventario = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(1).ToString)
                        Dim tip As String = Mid(tipo_inventario, 1, 10)
                        line = line & PadLR(Trim(tip), 10, " ")

                        Dim CO
                        CO = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(2).ToString)
                        Dim coo As String = Mid(CO, 1, 3)
                        line = line & PadLR(Trim(coo), 3, " ")

                        line = line & PadLR("99", 20, " ")

                        Dim CC
                        CC = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(3).ToString)
                        Dim ccc As String = Mid(CC, 1, 15)
                        line = line & PadLR(Trim(ccc), 15, " ")


                        Dim tercero
                        tercero = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(4).ToString)
                        Dim ter As String = Mid(tercero, 1, 15)
                        line = line & PadLR(Trim(ter), 15, " ")

                    Next


                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    OBJTABLE_TRASLADOS.Clear()
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_traslados.Text & "', '" & txt_plano_traslados.Text & "', getdate() , '" & lSt_CodUsuario & "'  )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_traslados.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Dim fecha_doc

            Try

                Me.Cursor = Cursors.WaitCursor
                FileOpen(1, filePath16, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                PrintLine(1, line)
                line = ""
                line = fijo2 & PadL("0368", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("02", 2, " ")
                line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                line = line & PadL("1", 1, " ")
                line = line & PadL(Trim(txt_co_traslados.Text), 3, " ")
                'line = line & PadL("190", 3, " ")
                line = line & PadL(Trim(txt_tipdoc_traslados.Text), 3, " ")
                line = line & PadL(Trim(""), 8, "0")
                fecha_doc = CDate(Dtp_fechadoc_traslados.Text).ToString("yyyyMMdd")
                line = line & PadL(Trim(fecha_doc), 8, " ")
                line = line & PadL(Trim("095"), 3, "0")
                line = line & PadL(Trim("0"), 1, "0")
                line = line & PadL(Trim("0"), 1, "0")
                line = line & PadLR(Trim(txt_notas_traslados.Text), 255, " ")

                txt_csv_traslados.Text = OpenFileDialog1.FileName
                'cargar_csv_traslados()
                OBJTABLE_TRASLADOS = GetDataExcel(txt_csv_traslados.Text, Hojaslibro(txt_csv_traslados.Text))
                Me.Label1.Text = "2"
                Me.Label2.Text = ""
                Dim r


                For j As Integer = 0 To OBJTABLE_TRASLADOS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("0368", 4, " ")
                    line = line & PadL("95", 2, " ")
                    line = line & PadL("02", 2, " ")
                    line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                    ' line = line & PadL("190", 3, " ")
                    line = line & PadL(Trim(txt_co_traslados.Text), 3, " ")
                    line = line & PadL(Trim(txt_tipdoc_traslados.Text), 3, " ")
                    line = line & PadL("", 8, "0")
                    line = line & PadL("", 9, "0")

                    Dim referencia
                    referencia = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(0).ToString)
                    Dim ref As String = Mid(referencia, 1, 20)
                    line = line & PadLR(Trim(ref), 20, " ")

                    Dim tipo_inventario
                    tipo_inventario = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(1).ToString)
                    Dim tip As String = Mid(tipo_inventario, 1, 10)
                    line = line & PadLR(Trim(tip), 10, " ")

                    Dim CO
                    CO = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(2).ToString)
                    Dim coo As String = Mid(CO, 1, 3)
                    line = line & PadLR(Trim(coo), 3, " ")

                    line = line & PadLR("99", 20, " ")

                    Dim CC
                    CC = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(3).ToString)
                    Dim ccc As String = Mid(CC, 1, 15)
                    line = line & PadLR(Trim(ccc), 15, " ")

                    Dim tercero
                    tercero = Trim(OBJTABLE_TRASLADOS.Rows(j).Item(4).ToString)
                    Dim ter As String = Mid(tercero, 1, 15)
                    line = line & PadLR(Trim(ter), 15, " ")

                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                OBJTABLE_TRASLADOS.Clear()
                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_traslados.Text & "', '" & txt_plano_traslados.Text & "', getdate() , '" & lSt_CodUsuario & "'  )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_traslados.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub btn_est_traslados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_traslados.Click
        System.Diagnostics.Process.Start(".\Planos\Traslados_Activos_Fijos.xls")
        'exportar_plantilla_traslados()
    End Sub

    Private Sub btn_csv_act_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_csv_act_items.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_act_items.Text = OpenFileDialog1.FileName
        filePath17 = txt_csv_act_items.Text
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog17" Then
            txt_csv_act_items.Text = ""
        End If

    End Sub

    Private Sub btn_plano_act_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_plano_act_items.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_act_items.Text = SaveFileDialog1.FileName
        filePath17 = txt_plano_act_items.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_act_items.Text = ""
            txt_plano_act_items.Text = ""
        End If

    End Sub

    Private Sub btn_est_act_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_est_act_items.Click
        System.Diagnostics.Process.Start(".\Planos\Actualizacion_Items.xls")
        'exportar_plantilla_act_items()
    End Sub

    Private Sub btnSeleccionarArchivoCosto_Click(sender As Object, e As EventArgs) Handles btnSeleccionarArchivoCosto.Click
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txtExcelCostos.Text = OpenFileDialog1.FileName
        filePath16 = txtExcelCostos.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog16" Then
            txtExcelCostos.Text = ""
        End If
    End Sub

    Private Sub btnExportarArchivoCosto_Click(sender As Object, e As EventArgs) Handles btnExportarArchivoCosto.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txtPlanoExcel.Text = SaveFileDialog1.FileName
        filePath16 = txtPlanoExcel.Text

        If SaveFileDialog1.FileName = "" Then
            txtExcelCostos.Text = ""
            txtPlanoExcel.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click



        If txtExcelCostos.Text = "" Then
            MessageBox.Show("Debe seleccionar el archivo excel a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExcelCostos.Focus()
            Return
        End If

        If txtPlanoExcel.Text = "" Then
            MessageBox.Show("Debe seleccionar la ruta del archivo plano a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPlanoExcel.Focus()
            Return
        End If



        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim conexion As New clsConexionNew
            dt = GetDataExcel(txtExcelCostos.Text, Hojaslibro(txtExcelCostos.Text))
            ds.Tables.Add(dt)
            Dim texto As String = ds.GetXml

            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@xml", texto, SqlDbType.Xml))
            LstParametros.Add(New Parametros("@EMPRESA", variable_centro_operativo, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@IDTERCERO", variable_NIT, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@USUARIO", My.User.Name, SqlDbType.VarChar))

            Dim resultado As String
            resultado = conexion.SPGetEscalar("SP_PlanoCostoEstandar", LstParametros)
            If resultado = "" Then
                Dim exists As Boolean = System.IO.File.Exists(txtPlanoExcel.Text)

                If exists Then
                    System.IO.File.Delete(txtPlanoExcel.Text)
                End If


                Dim sql As String = "select sarta from Tbl_Plano where Usuario = '" + My.User.Name + "' order by Sarta"
                Dim sarta As DataTable = New DataTable
                sarta = conexion.ObtenerDataTable(sql)
                Dim plano As New StreamWriter(txtPlanoExcel.Text)
                For Each dr As DataRow In sarta.Rows
                    plano.Write(dr(0).ToString & vbNewLine)
                Next
                plano.Flush()
                plano.Close()

                MessageBox.Show("Se genero correctamente el plano", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Try
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txtArchivoExcelMovCont.Text & "', ' ', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)
                Catch ex As Exception

                End Try

            Else
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtExcelCostos.Text = ""
        txtPlanoExcel.Text = ""

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(".\Planos\Formato Costo Estandar.xlsx")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txtExcelDistribucionCostos.Text = OpenFileDialog1.FileName
        filePath20 = txtExcelDistribucionCostos.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog20" Then
            txtExcelDistribucionCostos.Text = ""
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO

        'SaveFileDialog20.Filter = "TXT Files (*.txt*)|*.txt"
        'SaveFileDialog20.ShowDialog()
        'txtRutaPlanoDistribucionCostos.Text = SaveFileDialog20.FileName
        'filePath20 = txtRutaPlanoDistribucionCostos.Text

        'If SaveFileDialog20.FileName = "" Then
        '    txtRutaPlanoDistribucionCostos.Text = ""
        'End If
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            txtRutaPlanoDistribucionCostos.Text = FolderBrowserDialog1.SelectedPath
        Else
            txtRutaPlanoDistribucionCostos.Text = ""
        End If

    End Sub

    Private Sub btnGenerarDistribucionCostos_Click(sender As Object, e As EventArgs) Handles btnGenerarDistribucionCostos.Click



        If txtExcelDistribucionCostos.Text = "" Then
            MessageBox.Show("Debe seleccionar el archivo excel a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExcelDistribucionCostos.Focus()
            Return
        End If

        If txtRutaPlanoDistribucionCostos.Text = "" Then
            MessageBox.Show("Debe seleccionar la ruta del archivo plano a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtArchivoPlanoMovCont.Focus()
            Return
        End If



        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim conexion As New clsConexionNew
            dt = GetDataExcel(txtExcelDistribucionCostos.Text, Hojaslibro(txtExcelDistribucionCostos.Text))
            ds.Tables.Add(dt)
            Dim texto As String = ds.GetXml

            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@Details", texto, SqlDbType.Xml))
            LstParametros.Add(New Parametros("@USUARIO", My.User.Name, SqlDbType.VarChar))

            Dim resultado As String
            resultado = conexion.SPGetEscalar("SP_PlanoDistribucionCostos", LstParametros)
            If resultado = "" Then

                Dim ruta As String = txtRutaPlanoDistribucionCostos.Text
                Dim sql As String = "SELECT DISTINCT Prioridad  FROM Tbl_Distribucion
					WHERE Usuario  = '" + My.User.Name + "'"
                Dim dtPrioridad As New DataTable
                dtPrioridad = conexion.ObtenerDataTable(sql)

                For Each dr As DataRow In dtPrioridad.Rows()

                    Dim exists As Boolean
                    exists = System.IO.File.Exists(ruta + "\" + dr(0).ToString() + ".txt")

                    If exists Then
                        System.IO.File.Delete(ruta + "\" + dr(0).ToString() + ".txt")
                    End If

                    sql = "SELECT sarta  FROM Plano_Sarta  where prioridad = " + dr(0).ToString() + " and usuario = '" + My.User.Name + "' order by orden, registro"
                    Dim dtsarta As DataTable = New DataTable
                    dtsarta = conexion.ObtenerDataTable(sql)
                    Dim planoSarta As New StreamWriter(ruta + "\" + dr(0).ToString() + ".txt")
                    For Each drSarta As DataRow In dtsarta.Rows
                        planoSarta.Write(drSarta(0).ToString & vbNewLine)
                    Next
                    planoSarta.Flush()
                    planoSarta.Close()

                Next


                MessageBox.Show("Se generaron correctamente los planos", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Try
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txtArchivoExcelMovCont.Text & "', ' ', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)
                Catch ex As Exception

                End Try

            Else
                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start(".\Planos\Formato Distribución de costos.xlsx")
    End Sub

    Private Sub btnLimpiarDistribucionCostos_Click(sender As Object, e As EventArgs) Handles btnLimpiarDistribucionCostos.Click
        txtExcelDistribucionCostos.Text = ""
        txtRutaPlanoDistribucionCostos.Text = ""
    End Sub

    Private Sub btnSalirDistribucionCostos_Click(sender As Object, e As EventArgs) Handles btnSalirDistribucionCostos.Click
        Me.Dispose()
    End Sub

    Private Sub btnNominaPlano_Click(sender As Object, e As EventArgs) Handles btnNominaPlano.Click

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        OpenFileDialog1.ShowDialog()
        txtRutaNomina.Text = OpenFileDialog1.FileName
        filePath20 = txtRutaNomina.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "" Then
            txtRutaNomina.Text = ""
        End If




    End Sub

    Private Sub btnRutaGenerarNomina_Click(sender As Object, e As EventArgs) Handles btnRutaGenerarNomina.Click

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txtRutaPlanoNomina.Text = SaveFileDialog1.FileName
        filePath22 = txtRutaPlanoNomina.Text

        If SaveFileDialog1.FileName = "" Then
            txtRutaPlanoNomina.Text = ""
        End If

    End Sub

    Private Sub txtGenerarNomina_Click(sender As Object, e As EventArgs) Handles txtGenerarNomina.Click

        Try
            If txtRutaPlanoNomina.Text = "" Then
                MessageBox.Show("Seleccione la ruta donde se va generar el plano")
                Return
            End If

            If txtRutaNomina.Text = "" Then
                MessageBox.Show("Seleccione la ruta del plano de nomina")
                Return
            End If

            filePath21 = txtRutaPlanoNomina.Text
            Dim exists As Boolean
            exists = System.IO.File.Exists(filePath21)
            If exists Then
                System.IO.File.Delete(filePath21)
            End If


            Dim arrayValores As New ArrayList()
            Dim inicio As Int16
            Dim nroLineas As Int16

            If cboBanco.Text <> "" Then
                If cboBanco.Text = "BANCOLOMBIA" Then
                    inicio = 76
                    nroLineas = 14
                ElseIf cboBanco.Text = "BOGOTA" Then
                    inicio = 75
                    nroLineas = 13
                End If

            Else
                MessageBox.Show("Seleccione el banco")
                Return
            End If

            Dim lines As String() = System.IO.File.ReadAllLines(txtRutaNomina.Text)
            For Each line As String In lines
                arrayValores.Add(line.Substring(inicio, nroLineas))
            Next

            Dim conexion As clsConexionNew = New clsConexionNew()
            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@valores", String.Join(";", CType(arrayValores.ToArray(Type.GetType("System.String")), String())), SqlDbType.VarChar))
            LstParametros.Add(New Parametros("fecha", dtpFechaNomina.Value, SqlDbType.Date))
            LstParametros.Add(New Parametros("@notas", txtNotasNomina.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@co", txtCONomina.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@tipoDocto", txtTipoDctoNomina.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@uxiliar", txtAuxiliarNomina.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@nit", txtNitBancoNomina.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@usuario", My.User.Name.ToString(), SqlDbType.VarChar))
            Dim dt As DataTable = New DataTable()
            Dim mensaje As String
            mensaje = conexion.SPGetEscalar("SP_PlanoNomina", LstParametros).ToString
            If Not String.IsNullOrEmpty(mensaje) Then
                Throw New ArgumentException(mensaje)
            End If

            Dim sql As String = "select sarta from PLANO_NOMINA where usuario = '" + My.User.Name + "' order by orden"
            dt = conexion.ObtenerDataTable(sql)

            Dim plano As New StreamWriter(txtRutaPlanoNomina.Text)
            For Each dr As DataRow In dt.Rows
                plano.Write(dr(0).ToString & vbNewLine)
            Next
            plano.Flush()
            plano.Close()



            MessageBox.Show("Se Genero Correctamente")



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnGenerarCompraServicios_Click(sender As Object, e As EventArgs) Handles btnGenerarCompraServicios.Click
        If txtCoCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar el centro operativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCoCompraServicios.Focus()
            Return
        End If

        If txtTipoDoctoCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar el tipo de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTipoDoctoCompraServicios.Focus()
            Return
        End If

        If txtNitCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar el NIT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNitCompraServicios.Focus()
            Return
        End If

        If txtSucursarCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar la sucursal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSucursarCompraServicios.Focus()
            Return
        End If


        If txtTipoProveedorCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar el tipo de proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTipoProveedorCompraServicios.Focus()
            Return
        End If


        'If txtPrefijoFacturaCompraServicios.Text = "" Then
        '    MessageBox.Show("Debe ingresar el prefijo de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtPrefijoFacturaCompraServicios.Focus()
        '    Return
        'End If


        If txtFacturaCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFacturaCompraServicios.Focus()
            Return
        End If


        If txtCondicionPagoCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar la condicion de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCondicionPagoCompraServicios.Focus()
            Return
        End If

        If txtCentroCostosCompraServicios.Text = "" Then
            MessageBox.Show("Debe ingresar el centro de costos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCentroCostosCompraServicios.Focus()
            Return
        End If




        If txtRutaExcelCompraServicios.Text = "" Then
            MessageBox.Show("Debe seleccionar el archivo excel a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRutaExcelCompraServicios.Focus()
            Return
        End If

        If txtRutaPlanoCompraServicios.Text = "" Then
            MessageBox.Show("Debe seleccionar la ruta del archivo plano a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRutaPlanoCompraServicios.Focus()
            Return
        End If



        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim conexion As New clsConexionNew
            dt = GetDataExcel(txtRutaExcelCompraServicios.Text, Hojaslibro(txtRutaExcelCompraServicios.Text))
            ds.Tables.Add(dt)
            Dim texto As String = ds.GetXml

            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@Details", texto, SqlDbType.Xml))
            LstParametros.Add(New Parametros("@FECHA", dtpFechaCompraServicios.Value, SqlDbType.Date))
            LstParametros.Add(New Parametros("@CO", txtCoCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@TIPODOCTO", txtTipoDoctoCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@NIT", txtNitCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@SUCURSAL", txtSucursarCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@TIPOPROVEEDOR", txtTipoProveedorCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@PREFIJO", txtPrefijoFacturaCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@FACTURA", txtFacturaCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@CONDICIONPAGO", txtCondicionPagoCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@CENTROCOSTOS", txtCentroCostosCompraServicios.Text, SqlDbType.VarChar))

            LstParametros.Add(New Parametros("@NOTAS", txtNotasCompraServicios.Text, SqlDbType.VarChar))
            LstParametros.Add(New Parametros("@USUARIO", My.User.Name, SqlDbType.VarChar))

            Dim resultado As New DataTable
            resultado = conexion.SPObtenerDataTable("SP_PlanoCompraServicios", LstParametros)
            If resultado.Rows.Count > 0 Then
                Dim exists As Boolean = System.IO.File.Exists(txtRutaPlanoCompraServicios.Text)

                If exists Then
                    System.IO.File.Delete(txtRutaPlanoCompraServicios.Text)
                End If


                'Dim sql As String = "select sarta from Tbl_Plano where Usuario = '" + My.User.Name + "' order by Sarta"
                'Dim sarta As DataTable = New DataTable
                'sarta = conexion.ObtenerDataTable(sql)
                Dim plano As New StreamWriter(txtRutaPlanoCompraServicios.Text)
                For Each dr As DataRow In resultado.Rows
                    plano.Write(dr(0).ToString & vbNewLine)
                Next
                plano.Flush()
                plano.Close()

                MessageBox.Show("Se genero correctamente el plano", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Try
                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txtRutaExcelCompraServicios.Text & "', ' ', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)
                Catch ex As Exception

                End Try

            Else
                MessageBox.Show("ERROR AL GENERAR EL PLANO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiarCompraServicios_Click(sender As Object, e As EventArgs) Handles btnLimpiarCompraServicios.Click
        txtRutaExcelCompraServicios.Text = ""
        txtRutaPlanoCompraServicios.Text = ""
    End Sub

    Private Sub btnExportarEstructuraCompraServicios_Click(sender As Object, e As EventArgs) Handles btnExportarEstructuraCompraServicios.Click
        System.Diagnostics.Process.Start(".\Planos\ESTRUCTURA COMPRA SERVICIOS.xlsx")
    End Sub

    Private Sub btnSeleccionarExcelCompraServicios_Click(sender As Object, e As EventArgs) Handles btnSeleccionarExcelCompraServicios.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txtRutaExcelCompraServicios.Text = OpenFileDialog1.FileName
        filePath20 = txtRutaExcelCompraServicios.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog20" Then
            txtRutaExcelCompraServicios.Text = ""
        End If
    End Sub

    Private Sub btnExportarPlanoCompraServicios_Click(sender As Object, e As EventArgs) Handles btnExportarPlanoCompraServicios.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txtRutaPlanoCompraServicios.Text = SaveFileDialog1.FileName
        filePath16 = txtPlanoExcel.Text
    End Sub

    Private Sub TabPage_CostoEstandar_Click(sender As Object, e As EventArgs) Handles TabPage_CostoEstandar.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txtExcelTerceros.Text = OpenFileDialog1.FileName
        filePath16 = txtExcelTerceros.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "" Then
            txtExcelTerceros.Text = ""
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txtPlanoExcelTerceros.Text = SaveFileDialog1.FileName
        filePath16 = txtPlanoExcelTerceros.Text

        If SaveFileDialog1.FileName = "" Then
            txtPlanoExcelTerceros.Text = ""
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        System.Diagnostics.Process.Start(".\Planos\TercerosNew.xlsx")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If txtExcelTerceros.Text = "" Then
            MessageBox.Show("Debe seleccionar el archivo excel a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExcelTerceros.Focus()
            Return
        End If

        If txtPlanoExcelTerceros.Text = "" Then
            MessageBox.Show("Debe seleccionar la ruta del archivo plano a generar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPlanoExcelTerceros.Focus()
            Return
        End If



        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim conexion As New clsConexionNew
            dt = GetDataExcel(txtExcelTerceros.Text, Hojaslibro(txtExcelTerceros.Text))
            ds.Tables.Add(dt)
            Dim texto As String = ds.GetXml


            Dim exists As Boolean = System.IO.File.Exists(txtPlanoExcelTerceros.Text)

            If exists Then
                System.IO.File.Delete(txtPlanoExcelTerceros.Text)
            End If



            Dim sarta As DataTable = New DataTable
            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@Details", texto, SqlDbType.Xml))

            sarta = conexion.SPObtenerDataTable("SP_PlanoImportarTerceros", LstParametros)
            Dim plano As New StreamWriter(txtPlanoExcelTerceros.Text)
            For Each dr As DataRow In sarta.Rows
                plano.Write(dr(0).ToString & vbNewLine)
            Next
            plano.Flush()
            plano.Close()

            MessageBox.Show("Se genero correctamente el plano", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Try
                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txtExcelTerceros.Text & "', ' ', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)
            Catch ex As Exception

            End Try



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        txtExcelTerceros.Text = ""
        txtPlanoExcelTerceros.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Dispose()
    End Sub

    Private Sub btnExcelActCodBarras_Click(sender As Object, e As EventArgs) Handles btnExcelActCodBarras.Click
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txtExcelActCodBarras.Text = OpenFileDialog1.FileName
        filePath16 = txtExcelActCodBarras.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "" Then
            txtExcelActCodBarras.Text = ""
        End If
    End Sub

    Private Sub btnGenerarActCodBarras_Click(sender As Object, e As EventArgs) Handles btnGenerarActCodBarras.Click

        If txtExcelActCodBarras.Text = "" Then
            MessageBox.Show("Debe seleccionar el archivo excel a cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtExcelActCodBarras.Focus()
            Return
        End If
        txtLogActCodBarras.Text = ""
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim conexion As New clsConexionNew
            dt = GetDataExcel(txtExcelActCodBarras.Text, Hojaslibro(txtExcelActCodBarras.Text))
            ds.Tables.Add(dt)
            Dim texto As String = ds.GetXml

            Dim LstParametros As New List(Of Parametros)()
            LstParametros.Add(New Parametros("@Details", texto, SqlDbType.Xml))
            LstParametros.Add(New Parametros("@USUARIO", My.User.Name, SqlDbType.VarChar))

            Dim resultado As String
            Dim dsResultado As New DataSet
            dsResultado = conexion.SPGetDataSet("SP_ActualizarCodBarrasActivosFijos", LstParametros)
            Dim dr As DataRow
            dr = dsResultado.Tables(0).Rows(0)
            resultado = dr(0).ToString()
            If resultado = "" Then
                MessageBox.Show("Se realizo el cargue correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Se encontraron errores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim errorResultado As String = resultado & vbCrLf

                For Each item As DataRow In dsResultado.Tables(1).Rows
                    errorResultado = errorResultado + "AF: " + item(0).ToString() + " - Cod. Barras: " + item(1).ToString() + " - Error: " + item(2).ToString() & vbCrLf
                Next

                txtLogActCodBarras.Text = errorResultado

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        txtExcelActCodBarras.Text = ""
        txtLogActCodBarras.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Me.Dispose()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        System.Diagnostics.Process.Start(".\Planos\ACTIVOS FIJOS.xlsx")
    End Sub
   
    Private Sub btnGenerarXlsNomina_Click(sender As Object, e As EventArgs) Handles btnGenerarXlsNomina.Click


        Try

            Dim excelApp As New Excel.Application
            Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
            'Dim excelSheet As Excel.Worksheet = CType(excelBook.Sheets(1), Excel.Worksheet)
            Dim filePathExcel As String
            'Dim MyDateTime As DateTime = Now()
            Dim MyDateTime As DateTime = dtpFechaNomSAP.Value
            Dim fecha, Mes, Anno, cl, conceptoPago As String
            cl = txtCLNominaSAP.Text
            Dim round As Boolean = False
            conceptoPago = txtConceptoNomSAP.Text.ToUpper()
            Dim bancoSeleccionado As String = ""
            Dim totalValores As Decimal = 0
            Dim totalValores_Archivos As Decimal = 0

            Dim inicio As Int16
            Dim nroLineas As Int16


            If txtRutaNomPlano.Text = "" Then
                MessageBox.Show("Seleccione la ruta del archivo plano.")
                Return
            End If


            If txtRutaExcelGenerado.Text = "" Then
                MessageBox.Show("Seleccione la ruta para guardar archivo excel.")
                Return
            End If

            If txtConceptoNomSAP.Text = "" Then
                MessageBox.Show("Debe escribir el concepto.")
                Return
            End If

            filePathExcel = txtRutaExcelGenerado.Text




            'verificar existencia el archvio excel, de lo contrario, creará el nuevo archivo
            Dim exists As Boolean
            exists = System.IO.File.Exists(filePathExcel)
            If Not exists Then
                excelBook.SaveAs(filePathExcel)
                excelBook.Close()
                excelApp.Quit()
                excelBook = Nothing
                excelApp = Nothing


            Else
                'System.IO.File.Delete(filePathExcel)
                Dim nombreArchivo = filePathExcel
                excelBook.SaveAs(filePathExcel)
                excelBook.Close()
                excelApp.Quit()
                excelBook = Nothing
                excelApp = Nothing


            End If



            Dim filePath As String = txtRutaNomPlano.Text
            Dim fileContent As String = My.Computer.FileSystem.ReadAllText(filePath)
            Dim _lines As String() = System.IO.File.ReadAllLines(filePath)
            Dim arrayValores As New ArrayList()


            fecha = MyDateTime.ToString("yyyyMMdd")
            Mes = MyDateTime.ToString("MMMM").ToUpper()
            Anno = MyDateTime.ToString("yyyy")
            Frm_Wait.Show()


            'Creación de datatable con sus cabeceras de columnas
            Dim dtExcelNomina As New DataTable
            Dim dtUltimaFila As New DataTable
            Dim rowExcel As DataRow


            dtExcelNomina.Columns.Add("znumdoc")
            dtExcelNomina.Columns.Add("ztipo")
            dtExcelNomina.Columns.Add("blart")
            dtExcelNomina.Columns.Add("bukrs")
            dtExcelNomina.Columns.Add("waers")
            dtExcelNomina.Columns.Add("budat")
            dtExcelNomina.Columns.Add("bldat")
            dtExcelNomina.Columns.Add("xblnr")
            dtExcelNomina.Columns.Add("bktxt")
            dtExcelNomina.Columns.Add("ldgrp")
            dtExcelNomina.Columns.Add("newbs")
            dtExcelNomina.Columns.Add("newko")
            dtExcelNomina.Columns.Add("hkont")
            dtExcelNomina.Columns.Add("newum")
            dtExcelNomina.Columns.Add("wrbtr")
            dtExcelNomina.Columns.Add("dmbtr")
            dtExcelNomina.Columns.Add("dmbe2")
            dtExcelNomina.Columns.Add("mwskz")
            dtExcelNomina.Columns.Add("kostl")
            dtExcelNomina.Columns.Add("prctr")
            dtExcelNomina.Columns.Add("projk")
            dtExcelNomina.Columns.Add("aufnr")
            dtExcelNomina.Columns.Add("valut")
            dtExcelNomina.Columns.Add("zuonr")
            dtExcelNomina.Columns.Add("sgtxt")
            dtExcelNomina.Columns.Add("xref1")
            dtExcelNomina.Columns.Add("xref3")



            If cboBancoSap.Text <> "" Then
                If cboBancoSap.Text = "BANCOLOMBIA" Then
                    bancoSeleccionado = "1110050702"
                    inicio = 76
                    nroLineas = 14
                ElseIf cboBancoSap.Text = "BOGOTA" Then
                    bancoSeleccionado = "1110050102"
                    inicio = 75
                    nroLineas = 13
                End If
            Else
                MessageBox.Show("Seleccione el banco")
                Return
            End If


            'lectura de .txt a partir del tipo banco, para sacar los valorer y 
            'acomodarlos fila a fila
            Dim lineas As String() = System.IO.File.ReadAllLines(filePath)
            Dim totalLineasPlano As Decimal = lineas.Count()
            Dim max_LineasxArchivo As Decimal = 900
            Dim contadorArray As Decimal = 0
            Dim contadorLineasxTablas As Decimal = 0
            For Each line As String In lineas

                arrayValores.Add(line.Substring(inicio, nroLineas))

            Next






            If totalLineasPlano <= max_LineasxArchivo Then

                For i As Integer = 0 To lineas.Length - 1
                    Dim lineaArray() As String = arrayValores(i).Split(vbTab)

                    'Dim line() As String = lineas(i).Split(vbTab)
                    For j As Integer = 0 To lineaArray.Length - 1


                        rowExcel = dtExcelNomina.NewRow
                        rowExcel("znumdoc") = "1"
                        rowExcel("ztipo") = "2"
                        rowExcel("blart") = "SA"
                        rowExcel("bukrs") = cl
                        rowExcel("waers") = "COP"
                        rowExcel("budat") = fecha
                        rowExcel("bldat") = fecha
                        rowExcel("xblnr") = conceptoPago
                        rowExcel("bktxt") = conceptoPago + " " + Mes + " " + Anno
                        rowExcel("ldgrp") = ""
                        rowExcel("newbs") = "50"
                        rowExcel("newko") = bancoSeleccionado
                        rowExcel("hkont") = ""
                        rowExcel("newum") = ""
                        rowExcel("wrbtr") = String.Concat("-", lineaArray(j).ToString()) 'valores 
                        rowExcel("dmbtr") = String.Concat("-", lineaArray(j).ToString()) 'valores
                        rowExcel("dmbe2") = ""
                        rowExcel("mwskz") = ""
                        rowExcel("kostl") = ""
                        rowExcel("prctr") = "11A0403005"
                        rowExcel("projk") = ""
                        rowExcel("aufnr") = ""
                        rowExcel("valut") = fecha
                        rowExcel("zuonr") = ""
                        rowExcel("sgtxt") = conceptoPago + " " + Mes + " " + Anno
                        rowExcel("xref1") = ""
                        rowExcel("xref3") = ""


                        dtExcelNomina.Rows.Add(rowExcel)
                        totalValores += Decimal.Parse(lineaArray(j).ToString())
                        dtUltimaFila = dtExcelNomina
                    Next
                Next
                Filas_Finales(dtUltimaFila, cl, fecha, conceptoPago, Mes, Anno, totalValores, round = True)
                CambiarValor_PrimeraFila(dtUltimaFila, round = True)
                ExportToExcel(dtUltimaFila, filePathExcel, "Hoja1")
                'ExportarDataTableAExcel(dtUltimaFila, filePathExcel.Replace(".xlsx", "") + "_" + contadorArchivos.ToString())
                dtUltimaFila.Clear()
                dtExcelNomina.Clear()
                totalValores = Nothing
                arrayValores = Nothing
                round = False
                LimpiarControles_NominaSAP()
                'Dispose()
            Else


                Dim contadorArchivos As Integer = 0
                Dim contadorLineas As Integer = 0

                For i As Integer = 0 To lineas.Length - 1
                    Dim lineaArray() As String = arrayValores(i).Split(vbTab)

                    'Dim line() As String = lineas(i).Split(vbTab)
                    'For j As Integer = 0 To lineaArray.Length - 1

                    rowExcel = dtExcelNomina.NewRow
                    rowExcel("znumdoc") = "1"
                    rowExcel("ztipo") = "2"
                    rowExcel("blart") = "SA"
                    rowExcel("bukrs") = cl
                    rowExcel("waers") = "COP"
                    rowExcel("budat") = fecha
                    rowExcel("bldat") = fecha
                    rowExcel("xblnr") = conceptoPago
                    rowExcel("bktxt") = conceptoPago + " " + Mes + " " + Anno
                    rowExcel("ldgrp") = ""
                    rowExcel("newbs") = "50"
                    rowExcel("newko") = bancoSeleccionado
                    rowExcel("hkont") = ""
                    rowExcel("newum") = ""
                    rowExcel("wrbtr") = String.Concat("-", lineaArray(0).ToString()) 'valores 
                    rowExcel("dmbtr") = String.Concat("-", lineaArray(0).ToString()) 'valores
                    rowExcel("dmbe2") = ""
                    rowExcel("mwskz") = ""
                    rowExcel("kostl") = ""
                    rowExcel("prctr") = "11A0403005"
                    rowExcel("projk") = ""
                    rowExcel("aufnr") = ""
                    rowExcel("valut") = fecha
                    rowExcel("zuonr") = ""
                    rowExcel("sgtxt") = conceptoPago + " " + Mes + " " + Anno
                    rowExcel("xref1") = ""
                    rowExcel("xref3") = ""


                    dtExcelNomina.Rows.Add(rowExcel)
                    totalValores += Decimal.Parse(lineaArray(0).ToString())
                    dtUltimaFila = dtExcelNomina
                    contadorLineas += 1
                    If contadorLineas >= max_LineasxArchivo Then
                        contadorArchivos += 1
                        If contadorArchivos <= 1 Then
                            round = True
                        End If

                        Filas_Finales(dtUltimaFila, cl, fecha, conceptoPago, Mes, Anno, totalValores, round)
                        CambiarValor_PrimeraFila(dtUltimaFila, round)
                        ExportarDataTableAExcel(dtUltimaFila, filePathExcel.Replace(".xlsx", "") + "_" + contadorArchivos.ToString())
                        dtUltimaFila.Clear()
                        dtExcelNomina.Clear()
                        totalValores = 0
                        contadorLineas = 0
                        round = False

                    End If


                    'Next
                Next

                If contadorArchivos = 0 Or contadorLineas > 0 Then
                    contadorArchivos += 1
                    Filas_Finales(dtUltimaFila, cl, fecha, conceptoPago, Mes, Anno, totalValores, round)
                    'CambiarValor_PrimeraFila(dtUltimaFila)
                    ExportarDataTableAExcel(dtUltimaFila, filePathExcel.Replace(".xlsx", "") + "_" + contadorArchivos.ToString())
                    dtUltimaFila.Clear()
                    dtExcelNomina.Clear()
                    totalValores = 0
                    round = False
                End If











                '''''
                'evaluar la cantidad de archivos que se deberán generar
                'con respecto a la cantidad de líneas que se encuentren en el archivo txt.
                '''''
                'Dim nroArchivos_Generar As Decimal = totalLineasPlano / max_LineasxArchivo
                'Dim nroLineas_Archivos As Decimal = totalLineasPlano / System.Math.Round(nroArchivos_Generar, MidpointRounding.AwayFromZero)

                'Dim numeroLineasxArchivo As Decimal = System.Math.Round(nroLineas_Archivos, MidpointRounding.AwayFromZero)
                'Dim numeroArchivos_Generar As Decimal = System.Math.Round(nroArchivos_Generar, MidpointRounding.AwayFromZero)

                ''Dim diferenciaTotal_Lineas As Decimal = (numeroLineasxArchivo * numeroArchivos_Generar)


                'Dim posLineas As Decimal = 0
                ''Dim contadorArchivos As Decimal = 0
                'Dim acumuladorLineas_Plano As Decimal = 0
                'Try
                '    Do While contadorLineasxTablas <= numeroLineasxArchivo
                '        posLineas += 1

                '        Dim lineArrayNew() As String = arrayValores(contadorLineasxTablas).Split(vbTab)
                '        For index As Decimal = 0 To lineArrayNew.Length - 1
                '            rowExcel = dtExcelNomina.NewRow
                '            rowExcel("znumdoc") = "1"
                '            rowExcel("ztipo") = "2"
                '            rowExcel("blart") = "SA"
                '            rowExcel("bukrs") = cl
                '            rowExcel("waers") = "COP"
                '            rowExcel("budat") = fecha
                '            rowExcel("bldat") = fecha
                '            rowExcel("xblnr") = conceptoPago
                '            rowExcel("bktxt") = conceptoPago + " " + Mes + " " + Anno
                '            rowExcel("ldgrp") = ""
                '            rowExcel("newbs") = "50"
                '            rowExcel("newko") = bancoSeleccionado
                '            rowExcel("hkont") = ""
                '            rowExcel("newum") = ""
                '            rowExcel("wrbtr") = String.Concat("-", lineArrayNew(index).ToString()) 'valores 
                '            rowExcel("dmbtr") = String.Concat("-", lineArrayNew(index).ToString()) 'valores
                '            rowExcel("dmbe2") = ""
                '            rowExcel("mwskz") = ""
                '            rowExcel("kostl") = ""
                '            rowExcel("prctr") = "11A0403005"
                '            rowExcel("projk") = ""
                '            rowExcel("aufnr") = ""
                '            rowExcel("valut") = fecha
                '            rowExcel("zuonr") = ""
                '            rowExcel("sgtxt") = conceptoPago + " " + Mes + " " + Anno
                '            rowExcel("xref1") = ""
                '            rowExcel("xref3") = ""


                '            dtExcelNomina.Rows.Add(rowExcel)
                '            totalValores += Decimal.Parse(lineArrayNew(index).ToString())
                '            dtUltimaFila = dtExcelNomina

                '        Next
                '        contadorLineasxTablas += 1

                '        If contadorLineasxTablas = numeroLineasxArchivo Then
                '            Filas_Finales(dtUltimaFila, cl, fecha, conceptoPago, Mes, Anno, totalValores, round)
                '            CambiarValor_PrimeraFila(dtUltimaFila)

                '            'es el primer archivo, tiene el nombre original(no se altera el nombre del archivo excel)
                '            ExportToExcel(dtUltimaFila, filePathExcel, "Hoja1")
                '            'ExportarDataTableAExcel(dtUltimaFila, filePathExcel)
                '            dtUltimaFila.Clear()
                '            dtExcelNomina.Clear()
                '            acumuladorLineas_Plano = posLineas
                '            contadorArchivos += 1
                '            contadorLineasxTablas = Nothing
                '            'LimpiarControles_NominaSAP()
                '            'Dispose()
                '            Continue Do

                '        End If


                '    Loop
                'Catch ex As Exception
                '    MessageBox.Show(ex.Message)
                'End Try


                'Do While contadorArchivos < numeroArchivos_Generar

                '    contadorLineasxTablas = 0
                '    For k As Decimal = posLineas To lineas.Length - 1
                '        Dim lineaArray() As String = arrayValores(k).Split(vbTab)
                '        For j As Integer = 0 To lineaArray.Length - 1

                '            rowExcel = dtExcelNomina.NewRow
                '            rowExcel("znumdoc") = "1"
                '            rowExcel("ztipo") = "2"
                '            rowExcel("blart") = "SA"
                '            rowExcel("bukrs") = cl
                '            rowExcel("waers") = "COP"
                '            rowExcel("budat") = fecha
                '            rowExcel("bldat") = fecha
                '            rowExcel("xblnr") = conceptoPago
                '            rowExcel("bktxt") = conceptoPago + " " + Mes + " " + Anno
                '            rowExcel("ldgrp") = ""
                '            rowExcel("newbs") = "50"
                '            rowExcel("newko") = bancoSeleccionado
                '            rowExcel("hkont") = ""
                '            rowExcel("newum") = ""
                '            rowExcel("wrbtr") = String.Concat("-", lineaArray(j).ToString()) 'valores 
                '            rowExcel("dmbtr") = String.Concat("-", lineaArray(j).ToString()) 'valores
                '            rowExcel("dmbe2") = ""
                '            rowExcel("mwskz") = ""
                '            rowExcel("kostl") = ""
                '            rowExcel("prctr") = "11A0403005"
                '            rowExcel("projk") = ""
                '            rowExcel("aufnr") = ""
                '            rowExcel("valut") = fecha
                '            rowExcel("zuonr") = ""
                '            rowExcel("sgtxt") = conceptoPago + " " + Mes + " " + Anno
                '            rowExcel("xref1") = ""
                '            rowExcel("xref3") = ""


                '            dtExcelNomina.Rows.Add(rowExcel)
                '            totalValores_Archivos += Decimal.Parse(lineaArray(j).ToString())
                '            'totalValores += Decimal.Parse(lineaArray(j).ToString())
                '            dtUltimaFila = dtExcelNomina

                '        Next
                '        contadorLineasxTablas += 1
                '        acumuladorLineas_Plano += 1
                '        If contadorLineasxTablas = numeroLineasxArchivo Then

                '            Filas_Finales(dtUltimaFila, cl, fecha, conceptoPago, Mes, Anno, totalValores_Archivos, round = False)
                '            CambiarValor_PrimeraFila(dtUltimaFila)
                '            Dim nuevaRuta = CrearRutaArchivo(filePathExcel, acumuladorLineas_Plano)
                '            'es el primer archivo, tiene el nombre original
                '            'ExportToExcel(dtUltimaFila, nuevaRuta, "Hoja1")
                '            ExportarDataTableAExcel(dtUltimaFila, nuevaRuta)
                '            contadorArchivos += 1
                '            totalValores_Archivos = Nothing
                '            contadorLineasxTablas = Nothing
                '            posLineas = acumuladorLineas_Plano
                '            dtExcelNomina.Clear()
                '            Continue For
                '        End If

                '    Next
                '    'Dispose()

                '    'Filas_Finales(dtUltimaFila, cl, fecha, conceptoPago, Mes, Anno, totalValores, round = False)
                '    'CambiarValor_PrimeraFila(dtUltimaFila)
                '    'Dim nuevaRuta = CrearRutaArchivo(filePathExcel)
                '    ''es el primer archivo, tiene el nombre original
                '    'ExportToExcel(dtUltimaFila, nuevaRuta, "Hoja1")
                '    'contadorArchivos -= 1
                '    'LimpiarControles_NominaSAP()
                '    'Return

                'Loop

                'If (totalLineasPlano - acumuladorLineas_Plano) <> 0 Then
                '    Try
                '        contadorLineasxTablas = 0
                '        For k As Integer = acumuladorLineas_Plano To lineas.Length - 1
                '            Dim lineaArray() As String = arrayValores(k).Split(vbTab)
                '            For j As Integer = 0 To lineaArray.Length - 1

                '                rowExcel = dtExcelNomina.NewRow
                '                rowExcel("znumdoc") = "1"
                '                rowExcel("ztipo") = "2"
                '                rowExcel("blart") = "SA"
                '                rowExcel("bukrs") = cl
                '                rowExcel("waers") = "COP"
                '                rowExcel("budat") = fecha
                '                rowExcel("bldat") = fecha
                '                rowExcel("xblnr") = conceptoPago
                '                rowExcel("bktxt") = conceptoPago + " " + Mes + " " + Anno
                '                rowExcel("ldgrp") = ""
                '                rowExcel("newbs") = "50"
                '                rowExcel("newko") = bancoSeleccionado
                '                rowExcel("hkont") = ""
                '                rowExcel("newum") = ""
                '                rowExcel("wrbtr") = String.Concat("-", lineaArray(j).ToString()) 'valores 
                '                rowExcel("dmbtr") = String.Concat("-", lineaArray(j).ToString()) 'valores
                '                rowExcel("dmbe2") = ""
                '                rowExcel("mwskz") = ""
                '                rowExcel("kostl") = ""
                '                rowExcel("prctr") = "11A0403005"
                '                rowExcel("projk") = ""
                '                rowExcel("aufnr") = ""
                '                rowExcel("valut") = fecha
                '                rowExcel("zuonr") = ""
                '                rowExcel("sgtxt") = conceptoPago + " " + Mes + " " + Anno
                '                rowExcel("xref1") = ""
                '                rowExcel("xref3") = ""


                '                dtExcelNomina.Rows.Add(rowExcel)
                '                totalValores_Archivos += Decimal.Parse(lineaArray(j).ToString())
                '                'totalValores += Decimal.Parse(lineaArray(j).ToString())
                '                dtUltimaFila = dtExcelNomina

                '            Next
                '            contadorLineasxTablas += 1
                '            acumuladorLineas_Plano += 1
                '            If acumuladorLineas_Plano = totalLineasPlano Then

                '                Filas_Finales(dtUltimaFila, cl, fecha, conceptoPago, Mes, Anno, totalValores_Archivos, round = False)
                '                CambiarValor_PrimeraFila(dtUltimaFila)
                '                Dim nuevaRuta = CrearRutaArchivo(filePathExcel, acumuladorLineas_Plano)
                '                'es el primer archivo, tiene el nombre original
                '                'ExportToExcel(dtUltimaFila, nuevaRuta, "Hoja1")
                '                ExportarDataTableAExcel(dtUltimaFila, nuevaRuta)
                '                contadorArchivos += 1
                '                totalValores_Archivos = Nothing
                '                posLineas = acumuladorLineas_Plano
                '                dtExcelNomina.Clear()
                '                Continue For
                '            End If


                '        Next
                '        'Dispose()
                '    Catch ex As Exception
                '        MessageBox.Show(ex.Message)
                '    End Try


                'End If




            End If







            'ExportarDataTableAExcel(dtExcelNomina, folderPath + fileName + "1")
            'ExportToExcel(dtUltimaFila, filePathExcel, "Hoja1")
            LimpiarControles_NominaSAP()



        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Filas_Finales(dtUltimaFila As DataTable, cl As String, fecha As String, conceptoPago As String, Mes As String, Anno As String, totalValores As Decimal, round As Boolean)
        'insertar ultima fila despues de todos los registros.
        If dtUltimaFila.Rows.Count > 0 Then
            Dim lastRow As DataRow = dtUltimaFila.Rows(dtUltimaFila.Rows.Count - 1)
            Dim last As Integer = dtUltimaFila.Rows.Count + 1

            Dim insertLastRow As DataRow
            insertLastRow = dtUltimaFila.NewRow

            insertLastRow("znumdoc") = "1"
            insertLastRow("ztipo") = "2"
            insertLastRow("blart") = "SA"
            insertLastRow("bukrs") = cl
            insertLastRow("waers") = "COP"
            insertLastRow("budat") = fecha
            insertLastRow("bldat") = fecha
            insertLastRow("xblnr") = conceptoPago
            insertLastRow("bktxt") = conceptoPago + " " + Mes + " " + Anno
            insertLastRow("ldgrp") = ""
            insertLastRow("newbs") = "40"
            insertLastRow("newko") = "2505050100"
            insertLastRow("hkont") = ""
            insertLastRow("newum") = ""
            insertLastRow("wrbtr") = totalValores.ToString()
            insertLastRow("dmbtr") = totalValores.ToString()
            insertLastRow("dmbe2") = ""
            insertLastRow("mwskz") = ""
            insertLastRow("kostl") = ""
            insertLastRow("prctr") = "11A0403005"
            insertLastRow("projk") = ""
            insertLastRow("aufnr") = ""
            insertLastRow("valut") = fecha
            insertLastRow("zuonr") = ""
            insertLastRow("sgtxt") = conceptoPago + " " + Mes + " " + Anno
            insertLastRow("xref1") = ""
            insertLastRow("xref3") = ""

            dtUltimaFila.Rows.InsertAt(insertLastRow, last)
            If round Then
                dtUltimaFila.Rows.RemoveAt(0)
            End If

        End If

    End Sub


    Private Sub CambiarValor_PrimeraFila(dtUltimaFila As DataTable, round As Boolean)
        'cambiar valor del campo"ztipo" en la primera fila, por 1 
        If round Then
            Dim rowFirst As DataRow = dtUltimaFila.Rows(0)
            Dim value As String = rowFirst("ztipo").ToString()
            dtUltimaFila.Rows(0)("ztipo") = "1"

        End If


        'Dim rowFirst As DataRow = dtExcelNomina.Rows(0)
        'Dim value As String = rowFirst("ztipo").ToString()
        'dtExcelNomina.Rows(0)("ztipo") = "1"
    End Sub

    Function CrearRutaArchivo(filePathExcel As String, contadorFilasTabla As Integer) As String
        Dim excelApp As New Excel.Application
        Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
        Dim exists As Boolean


        Dim testFile As System.IO.FileInfo
        testFile = My.Computer.FileSystem.GetFileInfo(filePathExcel)
        Dim folderPath As String = testFile.DirectoryName
        Dim fileName As String = System.IO.Path.GetFileNameWithoutExtension(filePathExcel)
        Dim fileExt As String = System.IO.Path.GetExtension(filePathExcel)
        Dim newFileName As String = fileName + "_" + contadorFilasTabla.ToString() + fileExt
        Dim newRutaFull As String = folderPath + "\" + newFileName

        exists = System.IO.File.Exists(newRutaFull)
        If Not exists Then
            excelBook.SaveAs(newRutaFull)
            excelBook.Close()
            excelApp.Quit()
            excelBook = Nothing
            excelApp = Nothing

        End If
        Return newRutaFull
    End Function

    Private Sub LimpiarControles_NominaSAP()
        txtRutaExcelGenerado.Text = ""
        txtConceptoNomSAP.Text = ""
        txtRutaNomPlano.Text = ""
        cboBancoSap.Text = ""
        Frm_Wait.Close()

    End Sub

    'Otro método para exportar datatable a excel
    Public Sub ExportarDataTableAExcel(dataTable As DataTable, rutaArchivo As String)
        ' Crear una instancia de Excel
        Dim excelApp As New Excel.Application()
        excelApp.Visible = False ' No mostrar la aplicación de Excel

        ' Crear un nuevo libro de Excel
        Dim libroExcel As Excel.Workbook = excelApp.Workbooks.Add()

        ' Obtener la hoja activa (por defecto es Sheet1)
        Dim hojaExcel As Excel.Worksheet = libroExcel.ActiveSheet

        ' Establecer los datos del DataTable en la hoja de Excel
        Dim columnas As Integer = dataTable.Columns.Count
        Dim filas As Integer = dataTable.Rows.Count

        ' Establecer los encabezados de columna en la primera fila
        For col = 1 To columnas
            hojaExcel.Cells(1, col) = dataTable.Columns(col - 1).ColumnName
        Next

        ' Establecer los datos de cada celda en las filas siguientes
        For fila = 0 To filas - 1
            For col = 0 To columnas - 1
                hojaExcel.Cells(fila + 2, col + 1) = dataTable.Rows(fila)(col).ToString()
            Next
        Next

        ' Guardar el libro de Excel en la ruta especificada
        libroExcel.SaveAs(rutaArchivo)

        ' Cerrar el libro de Excel y liberar los recursos
        libroExcel.Close()
        excelApp.Quit()

        ' Liberar los objetos COM utilizados
        System.Runtime.InteropServices.Marshal.ReleaseComObject(hojaExcel)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(libroExcel)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)


        ' Mostrar un mensaje de éxito
        MessageBox.Show("Exportación completada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub




    'función para exportar contenido datatable a excel
    Public Sub ExportToExcel(ByVal dt As DataTable,
                         ByVal fileName As String,
                         ByVal sheetName As String)

        ' Verificamos los parámetros pasados
        '
        If ((dt Is Nothing) OrElse
        (String.IsNullOrEmpty(fileName)) OrElse
        (String.IsNullOrEmpty(sheetName))) Then _
        Throw New ArgumentNullException()

        Dim app As Excel.Application = Nothing
        Dim book As Excel.Workbook = Nothing
        Dim sheet As Excel.Worksheet = Nothing

        Try
            ' Referenciamos la aplicación Excel.
            '
            app = New Excel.Application()

            ' Abrimos el libro de trabajo.
            '
            book = app.Workbooks.Open(fileName)

            ' Referenciamos la hoja de cálculo del libro.
            '
            sheet = DirectCast(book.Sheets(sheetName), Excel.Worksheet)

            With sheet
                ' Limpiamos el contenido de toda la hoja.
                '
                .Cells.Select()
                .Cells.ClearContents()

                ' Seleccionamos la primera celda de la hoja.
                '
                .Range("A1").Select()

                ' Escribimos los nombres de las columnas en la primera
                ' celda de la primera fila de la hoja de cálculo
                '
                Dim fila As Integer = 1
                Dim columna As Integer = 1

                For Each dc As DataColumn In dt.Columns
                    .Cells(fila, columna) = dc.ColumnName
                    columna += 1
                Next

                ' Establecemos los atributos de la fuente para las
                ' celdas de la primera fila.
                '
                With .Range(.Cells(1, 1), .Cells(1, dt.Columns.Count)).Font
                    .Name = "Calibri"
                    .Bold = True
                    .Size = 12
                End With

                ' Insertamos los datos en la hoja de cálculo, comenzando por la
                ' fila número 2, ya que la primera fila está ocupada
                ' por el nombre de las columnas.
                '
                fila = 2

                For Each row As DataRow In dt.Rows

                    ' Primera columna
                    columna = 1

                    For Each dc As DataColumn In dt.Columns
                        .Cells(fila, columna) = row(dc.ColumnName)

                        ' Siguiente columna
                        columna += 1
                    Next

                    ' Siguiente fila
                    fila += 1

                Next

                ' Autoajustamos el ancho de todas las columnas utilizadas.
                '
                .Columns().AutoFit()

            End With
            Frm_Wait.Close()
            MessageBox.Show("Exportación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            ' Se ha producido una excepción;
            ' indicamos que el libro ha sido guardado.
            Frm_Wait.Close()
            If (book IsNot Nothing) Then
                book.Saved = True
            End If

            ' Devolvemos la excepción al procedimiento llamador
            Throw

        Finally
            sheet = Nothing

            If (book IsNot Nothing) Then
                ' Si procede, guardamos el libro de trabajo.
                If (Not (book.Saved)) Then book.Save()
                ' Cerramos el libro de Excel.
                book.Close()
            End If
            book = Nothing

            If (app IsNot Nothing) Then
                ' Si procede, cerramos Excel y disminuimos el recuento
                ' de referencias al objeto Excel.Application.
                app.Quit()
                While (System.Runtime.InteropServices.Marshal.ReleaseComObject(app) > 0)
                    ' Sin implementación.
                End While
            End If
            app = Nothing


        End Try

    End Sub

    Private Sub btnRutaGeneraExcel_Click(sender As Object, e As EventArgs) Handles btnRutaGeneraExcel.Click
        If cboBancoSap.Text <> "" Then
            SaveFileDialog1.Filter = "Excel Files (*.xlsx*)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            txtRutaExcelGenerado.Text = SaveFileDialog1.FileName
            rutaExcelGenerado = txtRutaExcelGenerado.Text

            If SaveFileDialog1.FileName = "" Then
                txtRutaExcelGenerado.Text = ""
            End If
        Else
            MsgBox("No ha seleccionado el banco.")

        End If

    End Sub

    Private Sub btnRutaPlanoNomina_Click(sender As Object, e As EventArgs) Handles btnRutaPlanoNomina.Click

        If cboBancoSap.Text <> "" Then
            'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
            OpenFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
            OpenFileDialog1.ShowDialog()
            txtRutaNomPlano.Text = OpenFileDialog1.FileName
            rutaPlanoNomina = txtRutaNomPlano.Text()
            ' FileOpen(1, filePath, OpenMode.Output)

            If OpenFileDialog1.FileName = "" Then
                txtRutaNomPlano.Text = ""
            End If
        Else
            MsgBox("No ha seleccionado el banco.")
        End If


    End Sub

    Private Sub exportar_plantilla_act_items()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("f120_referencia,f120_descripcion,f120_descripcion_corta,f120_id_grupo_impositivo,f120_id_tipo_inv_serv,f120_ind_tipo_item,f120_ind_compra,f120_ind_venta,f120_ind_manufactura,f120_id_unidad_inventario,f120_id_unidad_orden,f120_factor_orden,f120_id_cod_item")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)
        End If

    End Sub

    Private Sub btn_limpiar_act_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_limpiar_act_items.Click

        txt_csv_act_items.Text = ""
        txt_plano_act_items.Text = ""

    End Sub

    Private Sub btn_generar_act_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generar_act_items.Click

        If txt_csv_act_items.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_act_items.Focus()
            Exit Sub
        End If

        If txt_plano_act_items.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_act_items.Focus()
            Exit Sub
        End If

        generar_plano_act_items()

    End Sub

    Private Sub generar_plano_act_items()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath17 = txt_plano_act_items.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath17)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_ACT_ITEMS.Rows.Clear()
                System.IO.File.Delete(filePath17)
                Try

                    FileOpen(1, filePath17, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    'PrintLine(1, line)
                    'line = ""
                    txt_csv_act_items.Text = OpenFileDialog1.FileName
                    'cargar_csv_act_items()
                    OBJTABLE_ACT_ITEMS = GetDataExcel(txt_csv_act_items.Text, Hojaslibro(txt_csv_act_items.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""
                    Dim r

                    For j As Integer = 0 To OBJTABLE_ACT_ITEMS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""

                        line = r & PadL("0120", 4, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("04", 2, " ")
                        line = line & PadL("180", 3, " ")
                        line = line & PadL("1", 1, "0")
                        'line = line & PadL("0", 7, "0")
                        line = line & PadL(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(12).ToString), 7, "0")
                        line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(0).ToString), 50, " ")
                        'line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(1).ToString), 40, " ")
                        Dim des_larga
                        des_larga = Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(1).ToString)
                        des_larga = Mid(des_larga, 1, 40)
                        line = line & PadLR(des_larga, 40, " ")
                        Dim des_corta
                        des_corta = Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(1).ToString)
                        des_corta = Mid(des_corta, 1, 20)
                        line = line & PadLR(des_corta, 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(3).ToString), 4, " ")
                        line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(4).ToString), 10, " ")
                        line = line & PadL("", 4, " ")


                        Dim tipoItem As Integer = CInt(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(5).ToString))
                        'tipo item 2  es servicio
                        If tipoItem <> 2 Then
                            line = line & PadL("1", 3, "0") 'Segmento de costo
                        Else
                            line = line & PadL("0", 3, "0") 'Segmento de costo
                        End If



                        line = line & PadL("11", 2, " ")

                        ' line = line & PadL("11", 2, " ")
                        line = line & PadL("00", 2, " ")
                        line = line & PadL("11", 2, " ")
                        line = line & PadL("0", 4, "0")
                        line = line & PadL("", 18, " ")
                        line = line & PadL("", 18, " ")
                        line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(9).ToString), 4, " ")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("", 4, " ")
                        line = line & PadL("000000.0000", 1, "")
                        line = line & PadL("000000.0000", 1, "")
                        line = line & PadL("000000.0000", 1, "")
                        line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(10).ToString), 4, " ")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("", 4, " ")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("000001.0000", 1, "")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("1", 1, "0")
                        line = line & PadL("", 8, " ")
                        'Dim fecha_activacion, fecha_act
                        'fecha_activacion = DateTime.Now
                        'fecha_act = CDate(fecha_activacion).ToString("yyyyMMdd")
                        line = line & PadLR(OBJTABLE_ACT_ITEMS.Rows(j).Item(13).ToString(), 6, " ")
                        line = line & PadL("", 255, " ")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("", 10, " ")
                        line = line & PadL("0", 1, "0")


                    Next

                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)

                    Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                    Dim hora As String = Now.ToString("HH:mm:ss")
                    Dim fecha_registro As String
                    fecha_registro = var & " " & hora

                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_act_items.Text & "', '" & txt_plano_act_items.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_ACT_ITEMS.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_act_items.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath17, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                'PrintLine(1, line)
                'line = ""
                txt_csv_act_items.Text = OpenFileDialog1.FileName
                'cargar_csv_act_items()
                OBJTABLE_ACT_ITEMS = GetDataExcel(txt_csv_act_items.Text, Hojaslibro(txt_csv_act_items.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""
                Dim r

                For j As Integer = 0 To OBJTABLE_ACT_ITEMS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""

                    line = r & PadL("0120", 4, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("04", 2, " ")
                    line = line & PadL("180", 3, " ")
                    line = line & PadL("1", 1, "0")
                    'line = line & PadL("0", 7, "0")
                    line = line & PadL(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(12).ToString), 7, "0")
                    line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(0).ToString), 50, " ")
                    'line = line & PadLR(Trim(OBJTABLE_ITEMS.Rows(j).Item(1).ToString), 40, " ")
                    Dim des_larga
                    des_larga = Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(1).ToString)
                    des_larga = Mid(des_larga, 1, 40)
                    line = line & PadLR(des_larga, 40, " ")
                    Dim des_corta
                    des_corta = Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(1).ToString)
                    des_corta = Mid(des_corta, 1, 20)
                    line = line & PadLR(des_corta, 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(3).ToString), 4, " ")
                    line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(4).ToString), 10, " ")
                    line = line & PadL("", 4, " ")
                    ''line = line & PadL("0", 3, "0")

                    Dim tipoItem As Integer = CInt(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(5).ToString))
                    'tipo item 2  es servicio
                    If tipoItem <> 2 Then
                        line = line & PadL("1", 3, "0") 'Segmento de costo
                    Else
                        line = line & PadL("0", 3, "0") 'Segmento de costo
                    End If


                    line = line & PadL("11", 2, " ")
                    line = line & PadL("00", 2, " ")
                    line = line & PadL("11", 2, " ")
                    line = line & PadL("0", 4, "0")
                    line = line & PadL("", 18, " ")
                    line = line & PadL("", 18, " ")
                    line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(9).ToString), 4, " ")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("", 4, " ")
                    line = line & PadL("000000.0000", 1, "")
                    line = line & PadL("000000.0000", 1, "")
                    line = line & PadL("000000.0000", 1, "")
                    line = line & PadLR(Trim(OBJTABLE_ACT_ITEMS.Rows(j).Item(10).ToString), 4, " ")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("", 4, " ")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("000001.0000", 1, "")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("1", 1, "0")
                    line = line & PadL("", 8, " ")
                    'Dim fecha_activacion, fecha_act
                    'fecha_activacion = DateTime.Now
                    'fecha_act = CDate(fecha_activacion).ToString("yyyyMMdd")
                    line = line & PadLR(OBJTABLE_ACT_ITEMS.Rows(j).Item(13).ToString(), 6, " ")
                    'line = line & PadLR(fecha_act, 6, " ")
                    line = line & PadL("", 255, " ")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("", 10, " ")
                    line = line & PadL("0", 1, "0")


                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, "")
                PrintLine(1, line)
                line = ""
                FileClose(1)

                Dim var As String = DateTime.Now.ToString("yyyy-MM-dd")
                Dim hora As String = Now.ToString("HH:mm:ss")
                Dim fecha_registro As String
                fecha_registro = var & " " & hora

                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_act_items.Text & "', '" & txt_plano_act_items.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_ACT_ITEMS.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_act_items.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub btn_salir_act_items_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_act_items.Click
        End
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominaPlanoOrigen.SelectedIndexChanged

    End Sub



    Private Sub btn_generarcodigobarras_Click(sender As Object, e As EventArgs) Handles btn_generarcodigobarras.Click

        If txt_codigobarras.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_codigobarras.Focus()
            Exit Sub
        End If

        If txt_planocodigobarras.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_planocodigobarras.Focus()
            Exit Sub
        End If

        generar_plano_codigobarras()

    End Sub


    Private Sub generar_plano_codigobarras()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000001"
        FileClose(1)
        filePath18 = txt_planocodigobarras.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath18)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Try

                    Me.Cursor = Cursors.WaitCursor

                    FileClose(1)
                    OBJTABLE_CODIGOBARRAS.Rows.Clear()
                    System.IO.File.Delete(filePath18)
                    Me.Cursor = Cursors.WaitCursor

                    FileOpen(1, filePath18, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    ' PrintLine(1, line)

                    txt_codigobarras.Text = OpenFileDialog1.FileName
                    'cargar_csv_codigobarras()
                    OBJTABLE_CODIGOBARRAS = GetDataExcel(txt_codigobarras.Text, Hojaslibro(txt_codigobarras.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""

                    Dim r


                    For j As Integer = 0 To OBJTABLE_CODIGOBARRAS.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("131", 4, "0")
                        line = line & PadL("00", 2, "0")
                        line = line & PadL("05", 2, "0")
                        line = line & PadL(variable_centro_operativo, 3, "0")
                        line = line & PadL("1", 1, "0")


                        line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(0).ToString), 20, " ")
                        line = line & PadL("0", 7, "0")
                        line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(1).ToString), 50, " ")
                        line = line & PadL("", 20, " ")
                        line = line & PadL("", 20, " ")
                        line = line & PadL("", 5, " ")
                        line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(2).ToString), 4, " ")

                        ''line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(3).ToString), 20, " ")


                        Dim cant_unidad_medida
                        cant_unidad_medida = OBJTABLE_CODIGOBARRAS.Rows(j).Item(3).ToString


                        If cant_unidad_medida = "" Then
                            'debito = debito
                            line = line & PadLR("000000000000000.0000", 20, "0")
                        Else

                            Dim parte_entera_cant_unidad_medida
                            parte_entera_cant_unidad_medida = Int(cant_unidad_medida)
                            parte_entera_cant_unidad_medida = parte_entera_cant_unidad_medida.ToString().PadLeft(15, "0")

                            Dim parte_decimal_cant_unidad_medida = OBJTABLE_CODIGOBARRAS.Rows(j).Item(3).ToString
                            parte_decimal_cant_unidad_medida = Convert.ToDecimal(parte_decimal_cant_unidad_medida).ToString("N4")
                            Dim val_parte_decimal_cant_unidad_medida
                            val_parte_decimal_cant_unidad_medida = Mid(parte_decimal_cant_unidad_medida, InStrRev(parte_decimal_cant_unidad_medida, ".") + 1)

                            Dim val_cant_unidad_medida
                            val_cant_unidad_medida = parte_entera_cant_unidad_medida + "." + val_parte_decimal_cant_unidad_medida
                            line = line & PadLR(Trim(val_cant_unidad_medida), 20, "0")
                        End If


                        line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(4).ToString), 1, "0")
                        line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(5).ToString), 1, "0")

                        ''line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(6).ToString), 20, " ")

                        Dim factor_operacion
                        factor_operacion = OBJTABLE_CODIGOBARRAS.Rows(j).Item(6).ToString


                        If factor_operacion = "" Then
                            'debito = debito
                            line = line & PadLR("000000000000000.0000", 20, "0")
                        Else

                            Dim parte_entera_factor_operacion
                            parte_entera_factor_operacion = Int(factor_operacion)
                            parte_entera_factor_operacion = parte_entera_factor_operacion.ToString().PadLeft(15, "0")

                            Dim parte_decimal_factor_operacion = OBJTABLE_CODIGOBARRAS.Rows(j).Item(6).ToString
                            parte_decimal_factor_operacion = Convert.ToDecimal(parte_decimal_factor_operacion).ToString("N4")
                            Dim val_parte_decimal_factor_operacion
                            val_parte_decimal_factor_operacion = Mid(parte_decimal_factor_operacion, InStrRev(parte_decimal_factor_operacion, ".") + 1)

                            Dim val_cant_factor_operacion
                            val_cant_factor_operacion = parte_entera_factor_operacion + "." + val_parte_decimal_factor_operacion
                            line = line & PadLR(Trim(val_cant_factor_operacion), 20, "0")
                        End If


                        line = line & PadLR("000000000000000.0000", 20, "0")
                        line = line & PadLR("000000000000000.0000", 20, "0")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("0", 1, "0")
                        line = line & PadL("", 3, " ")
                        line = line & PadL("1", 1, "0")


                    Next


                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_codigobarras.Text & "', '" & txt_planocodigobarras.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_CODIGOBARRAS.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                        FileClose(1)
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_planocodigobarras.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath18, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                ' PrintLine(1, line)

                txt_codigobarras.Text = OpenFileDialog1.FileName
                'cargar_csv_codigobarras()
                OBJTABLE_CODIGOBARRAS = GetDataExcel(txt_codigobarras.Text, Hojaslibro(txt_codigobarras.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""

                Dim r

                For j As Integer = 0 To OBJTABLE_CODIGOBARRAS.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("131", 4, "0")
                    line = line & PadL("00", 2, "0")
                    line = line & PadL("05", 2, "0")
                    line = line & PadL(variable_centro_operativo, 3, "0")
                    line = line & PadL("1", 1, "0")


                    line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(0).ToString), 20, " ")
                    line = line & PadL("0", 7, "0")
                    line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(1).ToString), 50, " ")
                    line = line & PadL("", 20, " ")
                    line = line & PadL("", 20, " ")
                    line = line & PadL("", 5, " ")
                    line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(2).ToString), 4, " ")

                    ''line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(3).ToString), 20, " ")


                    Dim cant_unidad_medida
                    cant_unidad_medida = OBJTABLE_CODIGOBARRAS.Rows(j).Item(3).ToString


                    If cant_unidad_medida = "" Then
                        'debito = debito
                        line = line & PadLR("000000000000000.0000", 20, "0")
                    Else

                        Dim parte_entera_cant_unidad_medida
                        parte_entera_cant_unidad_medida = Int(cant_unidad_medida)
                        parte_entera_cant_unidad_medida = parte_entera_cant_unidad_medida.ToString().PadLeft(15, "0")

                        Dim parte_decimal_cant_unidad_medida = OBJTABLE_CODIGOBARRAS.Rows(j).Item(3).ToString
                        parte_decimal_cant_unidad_medida = Convert.ToDecimal(parte_decimal_cant_unidad_medida).ToString("N4")
                        Dim val_parte_decimal_cant_unidad_medida
                        val_parte_decimal_cant_unidad_medida = Mid(parte_decimal_cant_unidad_medida, InStrRev(parte_decimal_cant_unidad_medida, ".") + 1)

                        Dim val_cant_unidad_medida
                        val_cant_unidad_medida = parte_entera_cant_unidad_medida + "." + val_parte_decimal_cant_unidad_medida
                        line = line & PadLR(Trim(val_cant_unidad_medida), 20, "0")
                    End If


                    line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(4).ToString), 1, "0")
                    line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(5).ToString), 1, "0")

                    ''line = line & PadLR(Trim(OBJTABLE_CODIGOBARRAS.Rows(j).Item(6).ToString), 20, " ")

                    Dim factor_operacion
                    factor_operacion = OBJTABLE_CODIGOBARRAS.Rows(j).Item(6).ToString


                    If factor_operacion = "" Then
                        'debito = debito
                        line = line & PadLR("000000000000000.0000", 20, "0")
                    Else

                        Dim parte_entera_factor_operacion
                        parte_entera_factor_operacion = Int(factor_operacion)
                        parte_entera_factor_operacion = parte_entera_factor_operacion.ToString().PadLeft(15, "0")

                        Dim parte_decimal_factor_operacion = OBJTABLE_CODIGOBARRAS.Rows(j).Item(6).ToString
                        parte_decimal_factor_operacion = Convert.ToDecimal(parte_decimal_factor_operacion).ToString("N4")
                        Dim val_parte_decimal_factor_operacion
                        val_parte_decimal_factor_operacion = Mid(parte_decimal_factor_operacion, InStrRev(parte_decimal_factor_operacion, ".") + 1)

                        Dim val_cant_factor_operacion
                        val_cant_factor_operacion = parte_entera_factor_operacion + "." + val_parte_decimal_factor_operacion
                        line = line & PadLR(Trim(val_cant_factor_operacion), 20, "0")
                    End If


                    line = line & PadLR("000000000000000.0000", 20, "0")
                    line = line & PadLR("000000000000000.0000", 20, "0")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("0", 1, "0")
                    line = line & PadL("", 3, " ")
                    line = line & PadL("1", 1, "0")


                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_codigobarras.Text & "', '" & txt_planocodigobarras.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_CODIGOBARRAS.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_planocodigobarras.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btn_salircodigobarras_Click(sender As Object, e As EventArgs) Handles btn_salircodigobarras.Click
        End
    End Sub

    Private Sub btn_limpiarcodigobarras_Click(sender As Object, e As EventArgs) Handles btn_limpiarcodigobarras.Click
        txt_codigobarras.Text = ""
        txt_planocodigobarras.Text = ""
    End Sub


    Private Sub btn_est_codigobarras_Click(sender As Object, e As EventArgs) Handles btn_est_codigobarras.Click
        System.Diagnostics.Process.Start(".\Planos\Codigo_Barras.xls")
        'exportar_plantilla_codigobarras()
    End Sub

    Private Sub exportar_plantilla_codigobarras()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("f131_codigo_barras,f131_referencia_item,f131_id_unidad_medida,f131_cant_unidad_medida,f131_ind_tipo,f131_ind_factor,f131_factor")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)

        End If
    End Sub

    Private Sub btn_codigobarras_Click(sender As Object, e As EventArgs) Handles btn_codigobarras.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_codigobarras.Text = OpenFileDialog1.FileName
        filePath18 = txt_codigobarras.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog18" Then
            txt_codigobarras.Text = ""
        End If


    End Sub

    Private Sub btn_planocodigobarras_Click(sender As Object, e As EventArgs) Handles btn_planocodigobarras.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_planocodigobarras.Text = SaveFileDialog1.FileName
        filePath18 = txt_planocodigobarras.Text

        If SaveFileDialog1.FileName = "" Then
            txt_codigobarras.Text = ""
            txt_planocodigobarras.Text = ""
        End If

    End Sub

    Private Sub btn_csv_inv_Click(sender As Object, e As EventArgs) Handles btn_csv_inv.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_csv_inv.Text = OpenFileDialog1.FileName
        filePath19 = txt_csv_inv.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog19" Then
            txt_csv_inv.Text = ""
        End If

    End Sub

    Private Sub btn_plano_inv_Click(sender As Object, e As EventArgs) Handles btn_plano_inv.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_inv.Text = SaveFileDialog1.FileName
        filePath19 = txt_plano_inv.Text

        If SaveFileDialog1.FileName = "" Then
            txt_csv_inv.Text = ""
            txt_plano_inv.Text = ""
        End If

    End Sub

    Private Sub btn_est_inv_Click(sender As Object, e As EventArgs) Handles btn_est_inv.Click
        System.Diagnostics.Process.Start(".\Planos\Inventarios.xls")
        'exportar_plantilla_inv()
    End Sub

    Private Sub exportar_plantilla_inv()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("Referencia,Bodega,Concepto,Motivo,Unid_Inv,Cant_Inv,Cant_Adic,UN,CC,Proyecto,Ubicación,Costo_Unitario,Ubicacion_Entrada")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)

        End If
    End Sub

    Private Sub btn_salir_inv_Click(sender As Object, e As EventArgs) Handles btn_salir_inv.Click
        End
    End Sub

    Private Sub btn_limpiar_inv_Click(sender As Object, e As EventArgs) Handles btn_limpiar_inv.Click

        txt_co_inv.Text = ""
        txt_tip_doc_inv.Text = ""
        txt_clase_doc_inv.Text = ""
        txt_id_con_inv.Text = ""
        txt_bodega_salida_inv.Text = ""
        txt_bodega_entrada_inv.Text = ""
        txt_doc_alterno_inv.Text = ""
        txt_notas_inv.Text = ""
        txt_csv_inv.Text = ""
        txt_plano_inv.Text = ""
    End Sub

    Private Sub btn_generar_inv_Click(sender As Object, e As EventArgs) Handles btn_generar_inv.Click

        If txt_co_inv.Text = "" Then
            MsgBox("Ingrese el centro operativo", MsgBoxStyle.Critical)
            txt_co_inv.Focus()
            Exit Sub
        End If

        If txt_tip_doc_inv.Text = "" Then
            MsgBox("Ingrese el tipo de documento", MsgBoxStyle.Critical)
            txt_tip_doc_inv.Focus()
            Exit Sub
        End If


        If txt_clase_doc_inv.Text = "" Then
            MsgBox("Ingrese la clase de documento", MsgBoxStyle.Critical)
            txt_clase_doc_inv.Focus()
            Exit Sub
        End If


        If txt_id_con_inv.Text = "" Then
            MsgBox("Ingrese el concepto del documento", MsgBoxStyle.Critical)
            txt_id_con_inv.Focus()
            Exit Sub
        End If


        'If txt_bodega_entrada_inv.Text = "" Then
        '    MsgBox("Ingrese la Bodega de entrada", MsgBoxStyle.Critical)
        '    txt_bodega_entrada_inv.Focus()
        '    Exit Sub
        'End If


        'If txt_bodega_salida_inv.Text = "" Then
        '    MsgBox("Ingrese la Bodega de Salida", MsgBoxStyle.Critical)
        '    txt_bodega_salida_inv.Focus()
        '    Exit Sub
        'End If


        'If txt_doc_alterno_inv.Text = "" Then
        '    MsgBox("Ingrese el Documento alterno", MsgBoxStyle.Critical)
        '    txt_doc_alterno_inv.Focus()
        '    Exit Sub
        'End If


        If txt_notas_inv.Text = "" Then
            MsgBox("Por favor ingrese una Nota valida para el encabezado", MsgBoxStyle.Critical)
            txt_notas_inv.Focus()
            Exit Sub
        End If

        If txt_csv_inv.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_csv_inv.Focus()
            Exit Sub
        End If


        If txt_plano_inv.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_plano_inv.Focus()
            Exit Sub
        End If

        Generar_plano_Inventario()

    End Sub

    Private Sub Generar_plano_Inventario()

        ''SE GENERA ARCHIVO PLANO

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000002"
        FileClose(1)
        filePath19 = txt_plano_inv.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath19)

        If exists Then
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Me.Cursor = Cursors.WaitCursor

                FileClose(1)
                OBJTABLE_MOV_INVENTARIOS.Rows.Clear()
                System.IO.File.Delete(filePath19)

            End If
        End If





        Dim fecha_doc

        Try

            Me.Cursor = Cursors.WaitCursor
            FileOpen(1, filePath19, OpenMode.Output)
            line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
            PrintLine(1, line)
            line = ""
            line = fijo2 & PadL("0450", 4, " ")
            line = line & PadL("00", 2, " ")
            line = line & PadL("02", 2, " ")
            line = line & PadL(Trim(variable_centro_operativo), 3, " ")
            line = line & PadL("1", 1, " ")
            line = line & PadL(Trim(txt_co_inv.Text), 3, " ")
            'line = line & PadL("190", 3, " ")
            line = line & PadL(Trim(txt_tip_doc_inv.Text), 3, " ")
            line = line & PadL(Trim(""), 8, "0")
            fecha_doc = CDate(Dtp_fechadoc_inv.Text).ToString("yyyyMMdd")
            line = line & PadL(Trim(fecha_doc), 8, " ")
            line = line & PadL("", 15, " ")
            line = line & PadL(Trim(txt_clase_doc_inv.Text), 3, "0")
            line = line & PadL(Trim("1"), 1, "0")
            line = line & PadL(Trim("0"), 1, "0")
            line = line & PadLR(Trim(txt_notas_inv.Text), 255, " ")
            line = line & PadL(Trim(txt_id_con_inv.Text), 3, "0")
            line = line & PadL(Trim(txt_bodega_entrada_inv.Text), 5, " ")
            line = line & PadL(Trim(txt_bodega_salida_inv.Text), 5, " ")
            line = line & PadL(Trim(txt_doc_alterno_inv.Text), 15, " ")
            line = line & PadL(Trim(""), 3, " ")
            line = line & PadL(Trim(""), 3, " ")
            line = line & PadL("0", 8, "0")

            line = line & PadL("", 138, " ")

            line = line & PadL("0000000000.0000", 15, "0")
            line = line & PadL("000000000000000.0000", 20, "0")
            line = line & PadL("000000000000000.0000", 20, "0")
            line = line & PadL("000000000000000.0000", 20, "0")
            line = line & PadL("", 255, " ")



            txt_csv_inv.Text = OpenFileDialog1.FileName
            'cargar_csv_inv()

            OBJTABLE_MOV_INVENTARIOS = GetDataExcel(txt_csv_inv.Text, Hojaslibro(txt_csv_inv.Text))
            Me.Label1.Text = "2"
            Me.Label2.Text = ""
            Dim r

            Dim primero = True

            For j As Integer = 0 To OBJTABLE_MOV_INVENTARIOS.Rows.Count - 1
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                PrintLine(1, line)
                line = ""
                line = r & PadL("0470", 4, " ")
                line = line & PadL("00", 2, " ")
                line = line & PadL("02", 2, " ")
                line = line & PadL(Trim(variable_centro_operativo), 3, " ")
                line = line & PadL(Trim(txt_co_inv.Text), 3, " ")
                line = line & PadL(Trim(txt_tip_doc_inv.Text), 3, " ")
                line = line & PadL("", 8, "0")

                ''aca

                If primero = True Then
                    Dim a = "1"
                    a = a
                    Dim resultado1
                    resultado1 = "000000000" + a
                    primero = False
                    resultado1 = Microsoft.VisualBasic.Right(resultado1, 10)
                    line = line & PadLR(resultado1, 10, "0")
                Else
                    Dim a = "1"
                    a = a + j
                    Dim resultado1
                    resultado1 = "000000000" + a
                    resultado1 = Microsoft.VisualBasic.Right(resultado1, 10)
                    line = line & PadLR(resultado1, 10, "0")
                End If


                line = line & PadL("0", 7, "0")

                Dim referencia
                referencia = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(0).ToString)
                Dim ref As String = Mid(referencia, 1, 20)
                line = line & PadLR(Trim(ref), 20, " ")

                line = line & PadL("", 20, " ")
                line = line & PadL("", 4, " ")
                line = line & PadL("", 4, " ")

                Dim Bodega
                Bodega = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(1).ToString)
                Dim bod As String = Mid(Bodega, 1, 5)
                line = line & PadLR(Trim(bod), 5, " ")

                ''line = line & PadL("", 10, " ")
                Dim Ubicacion
                Ubicacion = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(10).ToString)
                Dim Ubi As String = Mid(Ubicacion, 1, 10)
                line = line & PadLR(Trim(Ubi), 10, " ")
                'line = line & PadLR(Trim(Ubi), 10, " ")

                line = line & PadL("", 15, " ")


                Dim concepto
                concepto = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(2).ToString)
                Dim con As String = Mid(concepto, 1, 3)
                line = line & PadLR(Trim(con), 3, "0")

                Dim motivo
                motivo = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(3).ToString)
                Dim mot As String = Mid(motivo, 1, 2)
                line = line & PadLR(Trim(mot), 2, " ")


                line = line & PadL(Trim(txt_co_inv.Text), 3, " ")
                ''line = line & PadL("99", 2, " ")

                Dim uni_neg
                uni_neg = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(7).ToString)
                Dim UN As String = Mid(uni_neg, 1, 2)
                line = line & PadLR(Trim(UN), 2, " ")

                'line = line & PadL("", 15, " ")
                'line = line & PadL("", 15, " ")

                Dim cc_mov
                cc_mov = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(8).ToString)
                Dim ccmov As String = Mid(cc_mov, 1, 15)
                line = line & PadLR(Trim(ccmov), 15, " ")

                Dim proyecto
                proyecto = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(9).ToString)
                Dim pro As String = Mid(proyecto, 1, 15)
                line = line & PadLR(Trim(pro), 15, " ")


                Dim uni_inv
                uni_inv = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(4).ToString)
                Dim UI As String = Mid(uni_inv, 1, 4)
                line = line & PadLR(Trim(UI), 4, " ")


                Dim cantidad_inventario
                cantidad_inventario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(5).ToString


                If cantidad_inventario = "" Then
                    'debito = debito
                    line = line & PadLR("000000000000000.0000", 20, "")
                Else

                    Dim parte_entera_cantidad_inventario
                    parte_entera_cantidad_inventario = Int(cantidad_inventario)
                    parte_entera_cantidad_inventario = parte_entera_cantidad_inventario.ToString().PadLeft(15, "0")

                    Dim parte_decimal_cantidad_inventario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(5).ToString
                    parte_decimal_cantidad_inventario = Convert.ToDecimal(parte_decimal_cantidad_inventario).ToString("N4")
                    Dim val_parte_decimal_cantidad_inventario
                    val_parte_decimal_cantidad_inventario = Mid(parte_decimal_cantidad_inventario, InStrRev(parte_decimal_cantidad_inventario, ".") + 1)

                    Dim val_factor_adicional
                    val_factor_adicional = parte_entera_cantidad_inventario + "." + val_parte_decimal_cantidad_inventario
                    line = line & PadLR(Trim(val_factor_adicional), 20, "0")
                End If




                Dim cantidad_adicional
                cantidad_adicional = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(6).ToString


                If cantidad_adicional = "" Then
                    'debito = debito
                    line = line & PadLR("000000000000000.0000", 20, "")
                Else

                    Dim parte_entera_cantidad_adicional
                    parte_entera_cantidad_adicional = Int(cantidad_adicional)
                    parte_entera_cantidad_adicional = parte_entera_cantidad_adicional.ToString().PadLeft(15, "0")

                    Dim parte_decimal_cantidad_adicional = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(6).ToString
                    parte_decimal_cantidad_adicional = Convert.ToDecimal(parte_decimal_cantidad_adicional).ToString("N4")
                    Dim val_parte_decimal_cantidad_adicional
                    val_parte_decimal_cantidad_adicional = Mid(parte_decimal_cantidad_adicional, InStrRev(parte_decimal_cantidad_adicional, ".") + 1)

                    Dim val_factor_adicional
                    val_factor_adicional = parte_entera_cantidad_adicional + "." + val_parte_decimal_cantidad_adicional
                    line = line & PadLR(Trim(val_factor_adicional), 20, "0")
                End If




                ''  line = line & PadLR("000000000000000.0000", 20, "")

                Dim costo_unitario
                costo_unitario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(11).ToString


                If costo_unitario = "" Then
                    line = line & PadLR("000000000000000.0000", 20, "")
                Else

                    Dim parte_entera_costo_unitario
                    parte_entera_costo_unitario = Int(costo_unitario)
                    parte_entera_costo_unitario = parte_entera_costo_unitario.ToString().PadLeft(15, "0")

                    Dim parte_decimal_costo_unitario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(11).ToString
                    parte_decimal_costo_unitario = Convert.ToDecimal(parte_decimal_costo_unitario).ToString("N4")
                    Dim val_parte_decimal_costo_unitario
                    val_parte_decimal_costo_unitario = Mid(parte_decimal_costo_unitario, InStrRev(parte_decimal_costo_unitario, ".") + 1)

                    Dim val_costo_unitario
                    val_costo_unitario = parte_entera_costo_unitario + "." + val_parte_decimal_costo_unitario
                    line = line & PadLR(Trim(val_costo_unitario), 20, "0")
                End If



                ' line = line & PadL("", 2324, " ")

                line = line & PadL("", 2299, " ")

                Dim Ubicacion_entrada
                Ubicacion_entrada = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(12).ToString)
                Dim Ubi_ent As String = Mid(Ubicacion_entrada, 1, 10)
                line = line & PadLR(Trim(Ubi_ent), 10, " ")

                line = line & PadL("", 15, " ")


            Next

            PrintLine(1, line)
            line = ""
            Me.Label1.Text.PadLeft(7, CChar("0"))
            Me.Label1.Text = Me.Label1.Text + 1
            r = Me.Label1.Text
            r = r.PadLeft(7, CChar("0"))
            line = r & PadL("99990001" & variable_centro_operativo, 11, "")
            PrintLine(1, line)
            line = ""
            FileClose(1)


            OBJTABLE_MOV_INVENTARIOS.Clear()
            sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_inv.Text & "', '" & txt_plano_inv.Text & "', getdate() , '" & lSt_CodUsuario & "'  )"
            Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)


            Me.Cursor = Cursors.Default

            Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                System.Diagnostics.Process.Start(txt_plano_inv.Text)
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try





        'Else

        '    Dim fecha_doc

        '    Try

        '        Me.Cursor = Cursors.WaitCursor
        '        FileOpen(1, filePath19, OpenMode.Output)
        '        line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
        '        PrintLine(1, line)
        '        line = ""
        '        line = fijo2 & PadL("0450", 4, " ")
        '        line = line & PadL("00", 2, " ")
        '        line = line & PadL("02", 2, " ")
        '        line = line & PadL(Trim(variable_centro_operativo), 3, " ")
        '        line = line & PadL("1", 1, " ")
        '        line = line & PadL(Trim(txt_co_inv.Text), 3, " ")
        '        'line = line & PadL("190", 3, " ")
        '        line = line & PadL(Trim(txt_tip_doc_inv.Text), 3, " ")
        '        line = line & PadL(Trim(""), 8, "0")
        '        fecha_doc = CDate(Dtp_fechadoc_inv.Text).ToString("yyyyMMdd")
        '        line = line & PadL(Trim(fecha_doc), 8, " ")
        '        line = line & PadL("", 15, " ")
        '        line = line & PadL(Trim(txt_clase_doc_inv.Text), 3, "0")
        '        line = line & PadL(Trim("1"), 1, "0")
        '        line = line & PadL(Trim("0"), 1, "0")
        '        line = line & PadLR(Trim(txt_notas_inv.Text), 255, " ")
        '        line = line & PadL(Trim(txt_id_con_inv.Text), 3, "0")
        '        line = line & PadL(Trim(txt_bodega_entrada_inv.Text), 5, " ")
        '        line = line & PadL(Trim(txt_bodega_salida_inv.Text), 5, " ")
        '        line = line & PadL(Trim(txt_doc_alterno_inv.Text), 15, " ")
        '        line = line & PadL(Trim(""), 3, " ")
        '        line = line & PadL(Trim(""), 3, " ")
        '        line = line & PadL("0", 8, "0")

        '        line = line & PadL("", 138, " ")

        '        line = line & PadL("0000000000.0000", 15, "0")
        '        line = line & PadL("000000000000000.0000", 20, "0")
        '        line = line & PadL("000000000000000.0000", 20, "0")
        '        line = line & PadL("000000000000000.0000", 20, "0")
        '        line = line & PadL("", 255, " ")



        '        txt_csv_inv.Text = OpenFileDialog19.FileName
        '        'cargar_csv_inv()
        '        OBJTABLE_MOV_INVENTARIOS = GetDataExcel(txt_csv_inv.Text, Hojaslibro(txt_csv_inv.Text))
        '        Me.Label1.Text = "2"
        '        Me.Label2.Text = ""
        '        Dim r

        '        Dim primero = True

        '        For j As Integer = 0 To OBJTABLE_MOV_INVENTARIOS.Rows.Count - 1
        '            Me.Label1.Text.PadLeft(7, CChar("0"))
        '            Me.Label1.Text = Me.Label1.Text + 1
        '            r = Me.Label1.Text
        '            r = r.PadLeft(7, CChar("0"))
        '            PrintLine(1, line)
        '            line = ""
        '            line = r & PadL("0470", 4, " ")
        '            line = line & PadL("00", 2, " ")
        '            line = line & PadL("02", 2, " ")
        '            line = line & PadL(Trim(variable_centro_operativo), 3, " ")
        '            line = line & PadL(Trim(txt_co_inv.Text), 3, " ")
        '            line = line & PadL(Trim(txt_tip_doc_inv.Text), 3, " ")
        '            line = line & PadL("", 8, "0")

        '            ''aca

        '            If primero = True Then
        '                Dim a = "1"
        '                a = a
        '                Dim resultado
        '                resultado = "000000000" + a
        '                primero = False
        '                resultado = Microsoft.VisualBasic.Right(resultado, 10)
        '                line = line & PadLR(resultado, 10, "0")
        '            Else
        '                Dim a = "1"
        '                a = a + j
        '                Dim resultado
        '                resultado = "000000000" + a
        '                resultado = Microsoft.VisualBasic.Right(resultado, 10)
        '                line = line & PadLR(resultado, 10, "0")
        '            End If


        '            line = line & PadL("0", 7, "0")

        '            Dim referencia
        '            referencia = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(0).ToString)
        '            Dim ref As String = Mid(referencia, 1, 20)
        '            line = line & PadLR(Trim(ref), 20, " ")

        '            line = line & PadL("", 20, " ")
        '            line = line & PadL("", 4, " ")
        '            line = line & PadL("", 4, " ")

        '            Dim Bodega
        '            Bodega = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(1).ToString)
        '            Dim bod As String = Mid(Bodega, 1, 5)
        '            line = line & PadLR(Trim(bod), 5, " ")

        '            ''line = line & PadL("", 10, " ")
        '            Dim Ubicacion
        '            Ubicacion = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(10).ToString)
        '            Dim Ubi As String = Mid(Ubicacion, 1, 10)
        '            ' line = line & PadLR(Trim(Ubi), 10, "0")
        '            line = line & PadLR(Trim(Ubi), 10, " ")

        '            line = line & PadL("", 15, " ")


        '            Dim concepto
        '            concepto = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(2).ToString)
        '            Dim con As String = Mid(concepto, 1, 3)
        '            line = line & PadLR(Trim(con), 3, "0")

        '            Dim motivo
        '            motivo = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(3).ToString)
        '            Dim mot As String = Mid(motivo, 1, 2)
        '            line = line & PadLR(Trim(mot), 2, " ")


        '            line = line & PadL(Trim(txt_co_inv.Text), 3, " ")
        '            ''line = line & PadL("99", 2, " ")

        '            Dim uni_neg
        '            uni_neg = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(7).ToString)
        '            Dim UN As String = Mid(uni_neg, 1, 2)
        '            line = line & PadLR(Trim(UN), 2, " ")

        '            'line = line & PadL("", 15, " ")
        '            'line = line & PadL("", 15, " ")

        '            Dim cc_mov
        '            cc_mov = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(8).ToString)
        '            Dim ccmov As String = Mid(cc_mov, 1, 15)
        '            line = line & PadLR(Trim(ccmov), 15, " ")

        '            Dim proyecto
        '            proyecto = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(9).ToString)
        '            Dim pro As String = Mid(proyecto, 1, 15)
        '            line = line & PadLR(Trim(pro), 15, " ")


        '            Dim uni_inv
        '            uni_inv = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(4).ToString)
        '            Dim UI As String = Mid(uni_inv, 1, 4)
        '            line = line & PadLR(Trim(UI), 4, " ")


        '            Dim cantidad_inventario
        '            cantidad_inventario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(5).ToString


        '            If cantidad_inventario = "" Then
        '                'debito = debito
        '                line = line & PadLR("000000000000000.0000", 20, "")
        '            Else

        '                Dim parte_entera_cantidad_inventario
        '                parte_entera_cantidad_inventario = Int(cantidad_inventario)
        '                parte_entera_cantidad_inventario = parte_entera_cantidad_inventario.ToString().PadLeft(15, "0")

        '                Dim parte_decimal_cantidad_inventario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(5).ToString
        '                parte_decimal_cantidad_inventario = Convert.ToDecimal(parte_decimal_cantidad_inventario).ToString("N4")
        '                Dim val_parte_decimal_cantidad_inventario
        '                val_parte_decimal_cantidad_inventario = Mid(parte_decimal_cantidad_inventario, InStrRev(parte_decimal_cantidad_inventario, ".") + 1)

        '                Dim val_factor_adicional
        '                val_factor_adicional = parte_entera_cantidad_inventario + "." + val_parte_decimal_cantidad_inventario
        '                line = line & PadLR(Trim(val_factor_adicional), 20, "0")
        '            End If




        '            Dim cantidad_adicional
        '            cantidad_adicional = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(6).ToString


        '            If cantidad_adicional = "" Then
        '                'debito = debito
        '                line = line & PadLR("000000000000000.0000", 20, "")
        '            Else

        '                Dim parte_entera_cantidad_adicional
        '                parte_entera_cantidad_adicional = Int(cantidad_adicional)
        '                parte_entera_cantidad_adicional = parte_entera_cantidad_adicional.ToString().PadLeft(15, "0")

        '                Dim parte_decimal_cantidad_adicional = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(6).ToString
        '                parte_decimal_cantidad_adicional = Convert.ToDecimal(parte_decimal_cantidad_adicional).ToString("N4")
        '                Dim val_parte_decimal_cantidad_adicional
        '                val_parte_decimal_cantidad_adicional = Mid(parte_decimal_cantidad_adicional, InStrRev(parte_decimal_cantidad_adicional, ".") + 1)

        '                Dim val_factor_adicional
        '                val_factor_adicional = parte_entera_cantidad_adicional + "." + val_parte_decimal_cantidad_adicional
        '                line = line & PadLR(Trim(val_factor_adicional), 20, "0")
        '            End If




        '            '' line = line & PadLR("000000000000000.0000", 20, "")

        '            Dim costo_unitario
        '            costo_unitario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(11).ToString


        '            If costo_unitario = "" Then
        '                line = line & PadLR("000000000000000.0000", 20, "")
        '            Else

        '                Dim parte_entera_costo_unitario
        '                parte_entera_costo_unitario = Int(costo_unitario)
        '                parte_entera_costo_unitario = parte_entera_costo_unitario.ToString().PadLeft(15, "0")

        '                Dim parte_decimal_costo_unitario = OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(11).ToString
        '                parte_decimal_costo_unitario = Convert.ToDecimal(parte_decimal_costo_unitario).ToString("N4")
        '                Dim val_parte_decimal_costo_unitario
        '                val_parte_decimal_costo_unitario = Mid(parte_decimal_costo_unitario, InStrRev(parte_decimal_costo_unitario, ".") + 1)

        '                Dim val_costo_unitario
        '                val_costo_unitario = parte_entera_costo_unitario + "." + val_parte_decimal_costo_unitario
        '                line = line & PadLR(Trim(val_costo_unitario), 20, "0")
        '            End If


        '            line = line & PadL("", 2299, " ")

        '            Dim Ubicacion_entrada
        '            Ubicacion_entrada = Trim(OBJTABLE_MOV_INVENTARIOS.Rows(j).Item(12).ToString)
        '            Dim Ubi_ent As String = Mid(Ubicacion_entrada, 1, 10)
        '            line = line & PadLR(Trim(Ubi_ent), 10, " ")

        '            line = line & PadL("", 15, " ")


        '        Next

        '        PrintLine(1, line)
        '        line = ""
        '        Me.Label1.Text.PadLeft(7, CChar("0"))
        '        Me.Label1.Text = Me.Label1.Text + 1
        '        r = Me.Label1.Text
        '        r = r.PadLeft(7, CChar("0"))
        '        line = r & PadL("99990001" & variable_centro_operativo, 11, "")
        '        PrintLine(1, line)
        '        line = ""
        '        FileClose(1)


        '        OBJTABLE_MOV_INVENTARIOS.Clear()
        '        sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_csv_inv.Text & "', '" & txt_plano_inv.Text & "', getdate() , '" & lSt_CodUsuario & "'  )"
        '        Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

        '        Me.Cursor = Cursors.Default

        '        Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
        '        If result = DialogResult.No Then
        '        ElseIf result = DialogResult.Yes Then
        '            System.Diagnostics.Process.Start(txt_plano_inv.Text)
        '            Exit Sub
        '        End If

        'Catch ex As Exception
        'MessageBox.Show(ex.Message)

        'End Try



    End Sub


    Private Sub btn_salir_entidades_proveedores_Click(sender As Object, e As EventArgs) Handles btn_salir_entidades_proveedores.Click
        End
    End Sub

    Private Sub btn_limpiar_entidades_proveedores_Click(sender As Object, e As EventArgs) Handles btn_limpiar_entidades_proveedores.Click
        txt_proveedores.Text = ""
        txt_plano_proveedores.Text = ""
    End Sub

    Private Sub btn_seleccionar_proveedor_csv_Click(sender As Object, e As EventArgs) Handles btn_seleccionar_proveedor_csv.Click

        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_proveedores.Text = OpenFileDialog1.FileName
        filePath20 = txt_proveedores.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog20" Then
            txt_proveedores.Text = ""
        End If
    End Sub

    Private Sub btn_generar_plano_proveedor_Click(sender As Object, e As EventArgs) Handles btn_generar_plano_proveedor.Click
        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_plano_proveedores.Text = SaveFileDialog1.FileName
        filePath20 = txt_plano_proveedores.Text

        If SaveFileDialog1.FileName = "" Then
            txt_proveedores.Text = ""
            txt_plano_proveedores.Text = ""
        End If
    End Sub

    Private Sub csv_est_entidades_proveedores_Click(sender As Object, e As EventArgs) Handles csv_est_entidades_proveedores.Click
        System.Diagnostics.Process.Start(".\Planos\Entidades_Proveedores.xls")
        'exportar_entidades_proveedores()
    End Sub

    Private Sub exportar_entidades_proveedores()

        SaveFileDialog1.Filter = "(*.csv)|*.csv|All files (*.*)|*.*"

        If SaveFileDialog1.ShowDialog = DialogResult.Cancel Then

        Else

            Dim csvFile As String = SaveFileDialog1.FileName
            ' Dim csvFile As String = "D:\Estructura Archivo Plano.csv"
            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            outFile.WriteLine("Tercero,Sucursal")
            'outFile.WriteLine("1.23, 4.56, 7.89")
            'outFile.WriteLine("3.21, 6.54, 9.87")
            outFile.Close()

            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MsgBox("Estructura exportada exitosamente en:" & " " & csvFile, MsgBoxStyle.Information)
            'System.Diagnostics.Process.Start(csvFile)

        End If
    End Sub

    Private Sub btn_generar_entidades_proveedores_Click(sender As Object, e As EventArgs) Handles btn_generar_entidades_proveedores.Click

        If txt_proveedores.Text = "" Then
            MsgBox("Seleccione un archivo con extension .CSV valido para exportar", MsgBoxStyle.Critical)
            txt_codigobarras.Focus()
            Exit Sub
        End If

        If txt_plano_proveedores.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_planocodigobarras.Focus()
            Exit Sub
        End If

        generar_plano_entidades_proveedores()
    End Sub


    Private Sub generar_plano_entidades_proveedores()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000001"
        FileClose(1)
        filePath20 = txt_plano_proveedores.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath20)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Try

                    Me.Cursor = Cursors.WaitCursor

                    FileClose(1)
                    OBJTABLE_ENTIDADES_PROVEEDORES.Rows.Clear()
                    System.IO.File.Delete(filePath20)
                    Me.Cursor = Cursors.WaitCursor

                    FileOpen(1, filePath18, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    ' PrintLine(1, line)

                    txt_codigobarras.Text = OpenFileDialog1.FileName
                    'cargar_csv_entidades_proveedores()
                    OBJTABLE_ENTIDADES_PROVEEDORES = GetDataExcel(txt_proveedores.Text, Hojaslibro(txt_proveedores.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""

                    Dim r


                    For j As Integer = 0 To OBJTABLE_ENTIDADES_PROVEEDORES.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("753", 4, "0")
                        line = line & PadL("11", 2, "0")
                        line = line & PadL("02", 2, "0")
                        line = line & PadL(variable_centro_operativo, 3, "0")
                        line = line & PadL("1", 1, "0")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(0).ToString), 15, " ")
                        line = line & PadL(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(1).ToString), 3, "0")
                        line = line & PadL("", 182, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(2).ToString), 30, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(3).ToString), 30, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(4).ToString), 30, " ")
                        line = line & PadLR("00000000000000000.0000000000", 28, "0")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(5).ToString), 2000, " ")

                        Dim fecha_compra, fecha_ok As String
                        fecha_compra = OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(7).ToString

                        If fecha_compra = "" Then
                            line = line & PadL(fecha_compra, 8, " ")
                        Else
                            fecha_ok = CDate(fecha_compra).ToString("yyyyMMdd")
                            line = line & PadL(fecha_ok, 8, " ")
                        End If

                        ' line = line & PadL("", 8, " ")
                        line = line & PadL("", 10, " ")
                        line = line & PadL("", 20, " ")
                        line = line & PadLR("M202", 8, " ")
                        line = line & PadL("0", 4, "0")
                        line = line & PadL("", 10, " ")
                        line = line & PadL("", 100, " ")

                    Next


                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_proveedores.Text & "', '" & txt_plano_proveedores.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_ENTIDADES_PROVEEDORES.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_plano_proveedores.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath20, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                ' PrintLine(1, line)

                txt_archivo_excel_activos.Text = OpenFileDialog1.FileName
                'cargar_csv_entidades_proveedores()
                OBJTABLE_ENTIDADES_PROVEEDORES = GetDataExcel(txt_proveedores.Text, Hojaslibro(txt_proveedores.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""

                Dim r

                For j As Integer = 0 To OBJTABLE_ENTIDADES_PROVEEDORES.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("753", 4, "0")
                    line = line & PadL("11", 2, "0")
                    line = line & PadL("02", 2, "0")
                    line = line & PadL(variable_centro_operativo, 3, "0")
                    line = line & PadL("1", 1, "0")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(0).ToString), 15, " ")
                    line = line & PadL(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(1).ToString), 3, "0")
                    line = line & PadL("", 182, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(2).ToString), 30, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(3).ToString), 30, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(4).ToString), 30, " ")
                    line = line & PadLR("00000000000000000.0000000000", 28, "0")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(5).ToString), 2000, " ")

                    Dim fecha_compra, fecha_ok As String
                    fecha_compra = OBJTABLE_ENTIDADES_PROVEEDORES.Rows(j).Item(7).ToString

                    If fecha_compra = "" Then
                        line = line & PadL(fecha_compra, 8, " ")
                    Else
                        fecha_ok = CDate(fecha_compra).ToString("yyyyMMdd")
                        line = line & PadL(fecha_ok, 8, " ")
                    End If


                    'line = line & PadLR("Proveedores", 30, " ")
                    'line = line & PadLR("LAFT", 30, " ")
                    'line = line & PadLR("PLAFT", 30, " ")
                    'line = line & PadLR("00000000000000000.0000000000", 28, "0")
                    'line = line & PadLR("SI", 2000, " ")

                    ''Dim fecha_doc As String
                    ''fecha_doc = CDate(Date.Now).ToString("yyyyMMdd")
                    ''line = line & PadL(fecha_doc, 8, " ") ''vacio

                    'line = line & PadL("", 8, " ")
                    line = line & PadL("", 10, " ")
                    line = line & PadL("", 20, " ")
                    line = line & PadLR("M202", 8, " ")
                    line = line & PadL("0", 4, "0")
                    line = line & PadL("", 10, " ")
                    line = line & PadL("", 100, " ")

                    ''VOY ACA
                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_proveedores.Text & "', '" & txt_plano_proveedores.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_ENTIDADES_PROVEEDORES.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_plano_proveedores.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If


    End Sub

    Private Sub btn_seleccionar_impyret_excel_Click(sender As Object, e As EventArgs) Handles btn_seleccionar_impyret_excel.Click
        ''SE SELECCIONA ARCHIVO CSV

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_ImpYRet_excel.Text = OpenFileDialog1.FileName
        filePath21 = txt_ImpYRet_excel.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog21" Then
            txt_ImpYRet_excel.Text = ""
        End If
    End Sub

    Private Sub btn_salir_impyret_Click(sender As Object, e As EventArgs) Handles btn_salir_impyret.Click
        End
    End Sub

    Private Sub btn_limpiar_estyret_Click(sender As Object, e As EventArgs) Handles btn_limpiar_estyret.Click
        txt_ImpYRet_excel.Text = ""
        txt_ImpyRet_plano.Text = ""
    End Sub

    Private Sub btn_seleccionar_planoImpyRet_Click(sender As Object, e As EventArgs) Handles btn_seleccionar_planoImpyRet.Click

        ''SE SELECCIONA RUTA DONDE SE GUARDARA ARCHIVO PLANO

        SaveFileDialog21.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog21.ShowDialog()
        txt_ImpyRet_plano.Text = SaveFileDialog21.FileName
        filePath21 = txt_ImpyRet_plano.Text

        If SaveFileDialog21.FileName = "" Then
            txt_ImpyRet_plano.Text = ""
            txt_ImpyRet_plano.Text = ""
        End If
    End Sub

    Private Sub btn_generar_impyret_Click(sender As Object, e As EventArgs) Handles btn_generar_impyret.Click

        If txt_ImpYRet_excel.Text = "" Then
            MsgBox("Seleccione un archivo de Excel valido para exportar", MsgBoxStyle.Critical)
            txt_ImpYRet_excel.Focus()
            Exit Sub
        End If

        If txt_ImpyRet_plano.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_ImpyRet_plano.Focus()
            Exit Sub
        End If

        generar_plano_ImpuestosYRetenciones()

    End Sub

    Private Sub generar_plano_ImpuestosYRetenciones()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000001"
        FileClose(1)
        filePath21 = txt_ImpyRet_plano.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath21)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Try

                    Me.Cursor = Cursors.WaitCursor

                    FileClose(1)
                    OBJTABLE_IMPUESTOS_RETENCIONES.Rows.Clear()
                    System.IO.File.Delete(filePath21)
                    Me.Cursor = Cursors.WaitCursor

                    FileOpen(1, filePath21, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    ' PrintLine(1, line)

                    txt_ImpYRet_excel.Text = OpenFileDialog1.FileName
                    'cargar_csv_entidades_proveedores()
                    OBJTABLE_IMPUESTOS_RETENCIONES = GetDataExcel(txt_ImpYRet_excel.Text, Hojaslibro(txt_ImpYRet_excel.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""

                    Dim r

                    For j As Integer = 0 To OBJTABLE_IMPUESTOS_RETENCIONES.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        ' line = r & PadL("46", 4, "0")
                        line = r & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(2).ToString), 4, "0")
                        line = line & PadL("00", 2, "0")
                        line = line & PadL("01", 2, "0")
                        line = line & PadL(variable_centro_operativo, 3, "0")
                        line = line & PadL("1", 1, "0")
                        line = line & PadLR(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(0).ToString), 15, " ")
                        line = line & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(1).ToString), 3, "0")
                        'line = line & PadL("3", 3, " ")
                        'line = line & PadL("1", 2, " ")
                        line = line & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(3).ToString), 3, " ")
                        line = line & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(4).ToString), 2, " ")
                        line = line & PadL("", 4, " ")

                    Next

                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_ImpYRet_excel.Text & "', '" & txt_ImpyRet_plano.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_IMPUESTOS_RETENCIONES.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_ImpyRet_plano.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath21, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                ' PrintLine(1, line)

                txt_ImpYRet_excel.Text = OpenFileDialog1.FileName
                'cargar_csv_entidades_proveedores()
                OBJTABLE_IMPUESTOS_RETENCIONES = GetDataExcel(txt_ImpYRet_excel.Text, Hojaslibro(txt_ImpYRet_excel.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""

                Dim r

                For j As Integer = 0 To OBJTABLE_IMPUESTOS_RETENCIONES.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(2).ToString), 4, "0")
                    line = line & PadL("00", 2, "0")
                    line = line & PadL("01", 2, "0")
                    line = line & PadL(variable_centro_operativo, 3, "0")
                    line = line & PadL("1", 1, "0")
                    line = line & PadLR(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(0).ToString), 15, " ")
                    line = line & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(1).ToString), 3, "0")
                    'line = line & PadL("3", 3, " ")
                    'line = line & PadL("1", 2, " ")
                    line = line & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(3).ToString), 3, " ")
                    line = line & PadL(Trim(OBJTABLE_IMPUESTOS_RETENCIONES.Rows(j).Item(4).ToString), 2, " ")
                    line = line & PadL("", 4, " ")

                Next

                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_ImpYRet_excel.Text & "', '" & txt_ImpyRet_plano.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_IMPUESTOS_RETENCIONES.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_ImpyRet_plano.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub btn_estruc_ImpYret_Click(sender As Object, e As EventArgs) Handles btn_estruc_ImpYret.Click
        System.Diagnostics.Process.Start(".\Planos\ImpuestosYRetenciones.xls")
    End Sub

    Private Sub txtNotasMovContab_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNotasMovContab.KeyDown

    End Sub

    Private Sub txtNotasMovContab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotasMovContab.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_salirentcli_Click(sender As Object, e As EventArgs) Handles btn_salirentcli.Click
        End
    End Sub

    Private Sub btn_limpiar_entidades_clientes_Click(sender As Object, e As EventArgs) Handles btn_limpiar_entidades_clientes.Click
        txt_clientesPlano.Text = ""
        txt_clientesXLS.Text = ""
    End Sub

    Private Sub btn_clientesXLS_Click(sender As Object, e As EventArgs) Handles btn_clientesXLS.Click

        'OpenFileDialog2.Filter = "(*.xls*)|*.xls*|Excel Files|*.xls"
        OpenFileDialog1.Filter = "Excel Files|*.xls;*.xlsx"
        OpenFileDialog1.ShowDialog()
        txt_clientesXLS.Text = OpenFileDialog1.FileName
        filePath22 = txt_clientesXLS.Text()
        ' FileOpen(1, filePath, OpenMode.Output)

        If OpenFileDialog1.FileName = "OpenFileDialog22" Then
            txt_clientesXLS.Text = ""
        End If

    End Sub

    Private Sub btn_cleintesPlano_Click(sender As Object, e As EventArgs) Handles btn_cleintesPlano.Click
        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        SaveFileDialog1.ShowDialog()
        txt_clientesPlano.Text = SaveFileDialog1.FileName
        filePath22 = txt_clientesPlano.Text

        If SaveFileDialog1.FileName = "" Then
            txt_clientesXLS.Text = ""
            txt_clientesPlano.Text = ""
        End If

    End Sub

    Private Sub xls_est_entidades_clientes_Click(sender As Object, e As EventArgs) Handles xls_est_entidades_clientes.Click
        System.Diagnostics.Process.Start(".\Planos\Entidades_Clientes.xls")
    End Sub

    Private Sub btn_generar_entidades_clientes_Click(sender As Object, e As EventArgs) Handles btn_generar_entidades_clientes.Click

        If txt_clientesXLS.Text = "" Then
            MsgBox("Seleccione un archivo con extension .XLS valido para exportar", MsgBoxStyle.Critical)
            txt_clientesXLS.Focus()
            Exit Sub
        End If

        If txt_clientesPlano.Text = "" Then
            MsgBox("Seleccione la ruta donde se guardara el archivo plano", MsgBoxStyle.Critical)
            txt_clientesPlano.Focus()
            Exit Sub
        End If

        generar_plano_entidades_clientes()

    End Sub

    Private Sub generar_plano_entidades_clientes()

        Dim MyDateTime As DateTime = Now()
        Dim fecha, Mes, Ano As String
        fecha = MyDateTime.ToString("yyyyMMdd")
        Mes = MyDateTime.ToString("MMMM")
        Ano = MyDateTime.ToString("yyyy")
        UCase(Mes)
        Dim fijo2 = "0000001"
        FileClose(1)
        filePath22 = txt_clientesPlano.Text

        Dim exists As Boolean
        exists = System.IO.File.Exists(filePath22)

        If exists Then
            ' ''OBJTABLE.Rows.Clear()
            ' ''FileClose(1)
            ' ''System.IO.File.Delete(filePath)
            Dim resultado As Integer = MessageBox.Show("El Archivo ya se Encuentra Creado..!! Desea Sobreescribirlo?", "Archivos Planos", MessageBoxButtons.YesNo)
            If resultado = DialogResult.Yes Then

                Try

                    Me.Cursor = Cursors.WaitCursor

                    FileClose(1)
                    OBJTABLE_ENTIDADES_CLIENTES.Rows.Clear()
                    System.IO.File.Delete(filePath22)
                    Me.Cursor = Cursors.WaitCursor

                    FileOpen(1, filePath22, OpenMode.Output)
                    line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                    ' PrintLine(1, line)

                    txt_clientesXLS.Text = OpenFileDialog1.FileName
                    'cargar_csv_entidades_proveedores()
                    OBJTABLE_ENTIDADES_CLIENTES = GetDataExcel(txt_clientesXLS.Text, Hojaslibro(txt_clientesXLS.Text))
                    Me.Label1.Text = "1"
                    Me.Label2.Text = ""

                    Dim r


                    For j As Integer = 0 To OBJTABLE_ENTIDADES_CLIENTES.Rows.Count - 1
                        Me.Label1.Text.PadLeft(7, CChar("0"))
                        Me.Label1.Text = Me.Label1.Text + 1
                        r = Me.Label1.Text
                        r = r.PadLeft(7, CChar("0"))
                        PrintLine(1, line)
                        line = ""
                        line = r & PadL("753", 4, "0")
                        line = line & PadL("08", 2, "0")
                        line = line & PadL("03", 2, "0")
                        line = line & PadL(variable_centro_operativo, 3, "0")
                        line = line & PadL("1", 1, "0")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(0).ToString), 15, " ")
                        line = line & PadL(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(1).ToString), 3, "0")
                        line = line & PadL("", 182, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(2).ToString), 30, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(3).ToString), 30, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(4).ToString), 30, " ")


                        Dim cantidad_inventario
                        cantidad_inventario = OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(6).ToString


                        If cantidad_inventario = "" Then
                            'debito = debito
                            line = line & PadLR("00000000000000000.0000000000", 28, "")
                        Else

                            Dim parte_entera_cantidad_inventario
                            parte_entera_cantidad_inventario = Int(cantidad_inventario)
                            parte_entera_cantidad_inventario = parte_entera_cantidad_inventario.ToString().PadLeft(17, "0")

                            Dim parte_decimal_cantidad_inventario = OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(6).ToString
                            parte_decimal_cantidad_inventario = Convert.ToDecimal(parte_decimal_cantidad_inventario).ToString("N10")
                            Dim val_parte_decimal_cantidad_inventario
                            val_parte_decimal_cantidad_inventario = Mid(parte_decimal_cantidad_inventario, InStrRev(parte_decimal_cantidad_inventario, ".") + 1)

                            Dim val_factor_adicional
                            val_factor_adicional = parte_entera_cantidad_inventario + "." + val_parte_decimal_cantidad_inventario
                            line = line & PadLR(Trim(val_factor_adicional), 28, "0")
                        End If



                        ''line = line & PadLR("00000000000000000.0000000000", 28, "0")
                        ''line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(6).ToString), 28, "0")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(5).ToString), 2000, " ")

                        Dim fecha_compra, fecha_ok As String
                        fecha_compra = OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(7).ToString

                        If fecha_compra = "" Then
                            line = line & PadL(fecha_compra, 8, " ")
                        Else
                            fecha_ok = CDate(fecha_compra).ToString("yyyyMMdd")
                            line = line & PadL(fecha_ok, 8, " ")
                        End If

                        ' line = line & PadL("", 8, " ")
                        'line = line & PadL("", 10, " ")
                        'line = line & PadL("", 20, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(8).ToString), 10, " ")
                        line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(9).ToString), 20, " ")
                        line = line & PadLR("M201", 8, " ")
                        line = line & PadL("0", 4, "0")
                        line = line & PadL("", 10, " ")
                        line = line & PadL("", 100, " ")

                    Next


                    PrintLine(1, line)
                    line = ""
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                    PrintLine(1, line)
                    line = ""
                    FileClose(1)


                    sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_clientesXLS.Text & "', '" & txt_clientesPlano.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                    Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                    OBJTABLE_ENTIDADES_CLIENTES.Clear()

                    Me.Cursor = Cursors.Default

                    Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                    If result = DialogResult.No Then
                    ElseIf result = DialogResult.Yes Then
                        System.Diagnostics.Process.Start(txt_clientesPlano.Text)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try

            Else

            End If


        Else

            Try

                Me.Cursor = Cursors.WaitCursor

                FileOpen(1, filePath22, OpenMode.Output)
                line = line & PadL("000000100000001" & variable_centro_operativo, 18, " ")
                ' PrintLine(1, line)

                'txt_archivo_excel_activos.Text = OpenFileDialog20.FileName
                'cargar_csv_entidades_proveedores()
                OBJTABLE_ENTIDADES_CLIENTES = GetDataExcel(txt_clientesXLS.Text, Hojaslibro(txt_clientesXLS.Text))
                Me.Label1.Text = "1"
                Me.Label2.Text = ""

                Dim r


                For j As Integer = 0 To OBJTABLE_ENTIDADES_CLIENTES.Rows.Count - 1
                    Me.Label1.Text.PadLeft(7, CChar("0"))
                    Me.Label1.Text = Me.Label1.Text + 1
                    r = Me.Label1.Text
                    r = r.PadLeft(7, CChar("0"))
                    PrintLine(1, line)
                    line = ""
                    line = r & PadL("753", 4, "0")
                    line = line & PadL("08", 2, "0")
                    line = line & PadL("03", 2, "0")
                    line = line & PadL(variable_centro_operativo, 3, "0")
                    line = line & PadL("1", 1, "0")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(0).ToString), 15, " ")
                    line = line & PadL(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(1).ToString), 3, "0")
                    line = line & PadL("", 182, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(2).ToString), 30, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(3).ToString), 30, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(4).ToString), 30, " ")


                    Dim cantidad_inventario
                    cantidad_inventario = OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(6).ToString


                    If cantidad_inventario = "" Then
                        'debito = debito
                        line = line & PadLR("00000000000000000.0000000000", 28, "")
                    Else

                        Dim parte_entera_cantidad_inventario
                        parte_entera_cantidad_inventario = Int(cantidad_inventario)
                        parte_entera_cantidad_inventario = parte_entera_cantidad_inventario.ToString().PadLeft(17, "0")

                        Dim parte_decimal_cantidad_inventario = OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(6).ToString
                        parte_decimal_cantidad_inventario = Convert.ToDecimal(parte_decimal_cantidad_inventario).ToString("N10")
                        Dim val_parte_decimal_cantidad_inventario
                        val_parte_decimal_cantidad_inventario = Mid(parte_decimal_cantidad_inventario, InStrRev(parte_decimal_cantidad_inventario, ".") + 1)

                        Dim val_factor_adicional
                        val_factor_adicional = parte_entera_cantidad_inventario + "." + val_parte_decimal_cantidad_inventario
                        line = line & PadLR(Trim(val_factor_adicional), 28, "0")
                    End If


                    ' line = line & PadLR("00000000000000000.0000000000", 28, "0")
                    ''line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(6).ToString), 28, "0")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(5).ToString), 2000, " ")

                    Dim fecha_compra, fecha_ok As String
                    fecha_compra = OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(7).ToString

                    If fecha_compra = "" Then
                        line = line & PadL(fecha_compra, 8, " ")
                    Else
                        fecha_ok = CDate(fecha_compra).ToString("yyyyMMdd")
                        line = line & PadL(fecha_ok, 8, " ")
                    End If

                    ' line = line & PadL("", 8, " ")
                    'line = line & PadL("", 10, " ")
                    'line = line & PadL("", 20, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(8).ToString), 10, " ")
                    line = line & PadLR(Trim(OBJTABLE_ENTIDADES_CLIENTES.Rows(j).Item(9).ToString), 20, " ")
                    line = line & PadLR("M201", 8, " ")
                    line = line & PadL("0", 4, "0")
                    line = line & PadL("", 10, " ")
                    line = line & PadL("", 100, " ")

                Next


                PrintLine(1, line)
                line = ""
                Me.Label1.Text.PadLeft(7, CChar("0"))
                Me.Label1.Text = Me.Label1.Text + 1
                r = Me.Label1.Text
                r = r.PadLeft(7, CChar("0"))
                line = r & PadL("99990001" & variable_centro_operativo, 11, " ")
                PrintLine(1, line)
                line = ""
                FileClose(1)


                sCmd = "INSERT INTO al_tbl_LogInterfaces (ruta_excel, ruta_plano, fecha_elaboracion, usuario) VALUES ('" & txt_clientesXLS.Text & "', '" & txt_clientesPlano.Text & "', getdate() , '" & lSt_CodUsuario & "' )"
                Crud(sCmd, Nothing, TiposCRUD.Create, Nothing)

                OBJTABLE_ENTIDADES_CLIENTES.Clear()

                Me.Cursor = Cursors.Default

                Dim result As Integer = MessageBox.Show("Archivo Exportado Exitosamente..!! Desea Abrir el Archivo Plano?", "Archivos Planos", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                ElseIf result = DialogResult.Yes Then
                    System.Diagnostics.Process.Start(txt_clientesPlano.Text)
                    Exit Sub
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try

        End If



    End Sub


End Class
