<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActivosFijos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnNominaPlanoOrigen = New System.Windows.Forms.TabControl()
        Me.TabPage_ActFijos = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_archivo_plano_activos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_archivo_excel_activos = New System.Windows.Forms.TextBox()
        Me.TabPage_Activaciones = New System.Windows.Forms.TabPage()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Dtp_fecha_activaciones = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tip_doc = New System.Windows.Forms.TextBox()
        Me.lbl_tip_documento = New System.Windows.Forms.Label()
        Me.lbl_plano = New System.Windows.Forms.Label()
        Me.txt_plano = New System.Windows.Forms.TextBox()
        Me.lbl_excel = New System.Windows.Forms.Label()
        Me.txt_archivoexcel = New System.Windows.Forms.TextBox()
        Me.TabPage_MovContable = New System.Windows.Forms.TabPage()
        Me.txtnotas = New System.Windows.Forms.TextBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_tip_doc_mov = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_co = New System.Windows.Forms.TextBox()
        Me.lbl_centro_operativo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_plano_mov = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_excel_movimiento = New System.Windows.Forms.TextBox()
        Me.TabPage_Carnicos = New System.Windows.Forms.TabPage()
        Me.txt_cuentaxcobrarcar = New System.Windows.Forms.TextBox()
        Me.lbl_cuentaxcobrar_car = New System.Windows.Forms.Label()
        Me.txt_cuentacontab_car = New System.Windows.Forms.TextBox()
        Me.lbl_cuenta_contablecar = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_notas_car = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha_car = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_tipdoc_car = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_co_car = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_plano_carnicos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_excel_carnicos = New System.Windows.Forms.TextBox()
        Me.TabPage_Precios = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_plano_precios = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_excel_precios = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage_Presup_Vendedor = New System.Windows.Forms.TabPage()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbo_presupuesto_vend = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_periodo_pres_vend = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_plano_pres_vend = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_excel_pres_vend = New System.Windows.Forms.TextBox()
        Me.TabPage_Presup_Jefe = New System.Windows.Forms.TabPage()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cbo_presupuesto_jef2 = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_periodo_pres_jef = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_plano_pres_jef = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_excel_pres_jef = New System.Windows.Forms.TextBox()
        Me.TabPage_ExtractoBan = New System.Windows.Forms.TabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_plano_bancolombia = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_excel_bancolombia = New System.Windows.Forms.TextBox()
        Me.TabPage_ExtractoBog = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_plano_bogota = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txt_excel_bogota = New System.Windows.Forms.TextBox()
        Me.TabPage_Items = New System.Windows.Forms.TabPage()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_plano_items = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_csv_items = New System.Windows.Forms.TextBox()
        Me.TabPage_act_items = New System.Windows.Forms.TabPage()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txt_plano_act_items = New System.Windows.Forms.TextBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txt_csv_act_items = New System.Windows.Forms.TextBox()
        Me.TabPage_Clas_items = New System.Windows.Forms.TabPage()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txt_plano_clasitems = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txt_csv_clasitems = New System.Windows.Forms.TextBox()
        Me.TabPage_Sol_Compras = New System.Windows.Forms.TabPage()
        Me.txt_tercero_sol_compra = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_notas_sol_compra = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha_sol_compra = New System.Windows.Forms.DateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_tip_doc_sol_compra = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt_co_sol_compra = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txt_plano_sol_compra = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_csv_sol_compras = New System.Windows.Forms.TextBox()
        Me.TabPage_criterios = New System.Windows.Forms.TabPage()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txt_plano_criterios = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_csv_criterios = New System.Windows.Forms.TextBox()
        Me.TabPage_Bajas = New System.Windows.Forms.TabPage()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt_notas_bajas = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha_doc_bajas = New System.Windows.Forms.DateTimePicker()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txt_tip_doc_bajas = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txt_co_bajas = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txt_plano_bajas = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.txt_csv_bajas = New System.Windows.Forms.TextBox()
        Me.TabPage_cuentasxpagar = New System.Windows.Forms.TabPage()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txt_notas_cuenta = New System.Windows.Forms.TextBox()
        Me.Dtp_fecha_doc_cuentas = New System.Windows.Forms.DateTimePicker()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.txt_tip_doc_cuentas = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txt_co_cuentas = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.txt_plano_cuentas = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txt_csv_cuentas = New System.Windows.Forms.TextBox()
        Me.TabPage_Traslados_AF = New System.Windows.Forms.TabPage()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_notas_traslados = New System.Windows.Forms.TextBox()
        Me.Dtp_fechadoc_traslados = New System.Windows.Forms.DateTimePicker()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txt_tipdoc_traslados = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txt_co_traslados = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txt_plano_traslados = New System.Windows.Forms.TextBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.txt_csv_traslados = New System.Windows.Forms.TextBox()
        Me.TabPage_Codigo_barras = New System.Windows.Forms.TabPage()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txt_planocodigobarras = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.txt_codigobarras = New System.Windows.Forms.TextBox()
        Me.TabPage_Mov_Inventarios = New System.Windows.Forms.TabPage()
        Me.txt_doc_alterno_inv = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.txt_bodega_entrada_inv = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.txt_bodega_salida_inv = New System.Windows.Forms.TextBox()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.txt_id_con_inv = New System.Windows.Forms.TextBox()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txt_clase_doc_inv = New System.Windows.Forms.TextBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txt_notas_inv = New System.Windows.Forms.TextBox()
        Me.Dtp_fechadoc_inv = New System.Windows.Forms.DateTimePicker()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txt_tip_doc_inv = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.txt_co_inv = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.txt_plano_inv = New System.Windows.Forms.TextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.txt_csv_inv = New System.Windows.Forms.TextBox()
        Me.TabPage_Entidades_Proveedores = New System.Windows.Forms.TabPage()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.txt_plano_proveedores = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.txt_proveedores = New System.Windows.Forms.TextBox()
        Me.TabPage_Entidades_Clientes = New System.Windows.Forms.TabPage()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.txt_clientesPlano = New System.Windows.Forms.TextBox()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.txt_clientesXLS = New System.Windows.Forms.TextBox()
        Me.TabPage_Cambio_Estado_Activos_Fijos = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbActivar = New System.Windows.Forms.RadioButton()
        Me.rbSuspender = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbniif = New System.Windows.Forms.CheckBox()
        Me.cbpcga = New System.Windows.Forms.CheckBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.txtExcelCambioEstadoActFijos = New System.Windows.Forms.TextBox()
        Me.TabPage_Mov_Contab_New = New System.Windows.Forms.TabPage()
        Me.txtNotasMovContab = New System.Windows.Forms.TextBox()
        Me.dtpFechaDocMovCont = New System.Windows.Forms.DateTimePicker()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txtTipodocMovCont = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.txtCoMovContable = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.txtArchivoPlanoMovCont = New System.Windows.Forms.TextBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.txtArchivoExcelMovCont = New System.Windows.Forms.TextBox()
        Me.TabPage_ImpuestosYRetenciones = New System.Windows.Forms.TabPage()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.txt_ImpyRet_plano = New System.Windows.Forms.TextBox()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.txt_ImpYRet_excel = New System.Windows.Forms.TextBox()
        Me.TabPage_CostoEstandar = New System.Windows.Forms.TabPage()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.txtPlanoExcel = New System.Windows.Forms.TextBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.txtExcelCostos = New System.Windows.Forms.TextBox()
        Me.TabPageDistribucionCostos = New System.Windows.Forms.TabPage()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.txtRutaPlanoDistribucionCostos = New System.Windows.Forms.TextBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.txtExcelDistribucionCostos = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.cboBanco = New System.Windows.Forms.ComboBox()
        Me.txtGenerarNomina = New System.Windows.Forms.Button()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.dtpFechaNomina = New System.Windows.Forms.DateTimePicker()
        Me.txtNitBancoNomina = New System.Windows.Forms.TextBox()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.txtAuxiliarNomina = New System.Windows.Forms.TextBox()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.txtNotasNomina = New System.Windows.Forms.TextBox()
        Me.txtTipoDctoNomina = New System.Windows.Forms.TextBox()
        Me.txtCONomina = New System.Windows.Forms.TextBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.txtRutaPlanoNomina = New System.Windows.Forms.TextBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.txtRutaNomina = New System.Windows.Forms.TextBox()
        Me.TabPageCompraServicios = New System.Windows.Forms.TabPage()
        Me.txtCentroCostosCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.txtCondicionPagoCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.txtFacturaCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.txtPrefijoFacturaCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.txtTipoProveedorCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.txtSucursarCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.txtNitCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.txtRutaPlanoCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.txtRutaExcelCompraServicios = New System.Windows.Forms.TextBox()
        Me.txtNotasCompraServicios = New System.Windows.Forms.TextBox()
        Me.txtTipoDoctoCompraServicios = New System.Windows.Forms.TextBox()
        Me.txtCoCompraServicios = New System.Windows.Forms.TextBox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.dtpFechaCompraServicios = New System.Windows.Forms.DateTimePicker()
        Me.TabPageImportarTercero = New System.Windows.Forms.TabPage()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.txtPlanoExcelTerceros = New System.Windows.Forms.TextBox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.txtExcelTerceros = New System.Windows.Forms.TextBox()
        Me.TabPageActualizarCodBarras = New System.Windows.Forms.TabPage()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.txtLogActCodBarras = New System.Windows.Forms.TextBox()
        Me.Label146 = New System.Windows.Forms.Label()
        Me.txtExcelActCodBarras = New System.Windows.Forms.TextBox()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.TabPagePlanoNomSAP = New System.Windows.Forms.TabPage()
        Me.Label148 = New System.Windows.Forms.Label()
        Me.cboBancoSap = New System.Windows.Forms.ComboBox()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.dtpFechaNomSAP = New System.Windows.Forms.DateTimePicker()
        Me.txtCLNominaSAP = New System.Windows.Forms.TextBox()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.txtRutaExcelGenerado = New System.Windows.Forms.TextBox()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.txtRutaNomPlano = New System.Windows.Forms.TextBox()
        Me.btnGenerarXlsNomina = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.SaveFileDialog21 = New System.Windows.Forms.SaveFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_est_activos = New System.Windows.Forms.Button()
        Me.btn_excel_activos = New System.Windows.Forms.Button()
        Me.btn_plano_activos = New System.Windows.Forms.Button()
        Me.btn_salir_activos = New System.Windows.Forms.Button()
        Me.btn_generar_activos = New System.Windows.Forms.Button()
        Me.btn_limpiar_activos = New System.Windows.Forms.Button()
        Me.btn_est_activaciones = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_plano = New System.Windows.Forms.Button()
        Me.btn_seleccionar = New System.Windows.Forms.Button()
        Me.btn_est_movimiento = New System.Windows.Forms.Button()
        Me.btn_excel_movimiento = New System.Windows.Forms.Button()
        Me.btn_plano_movimiento = New System.Windows.Forms.Button()
        Me.btn_salir_movimiento = New System.Windows.Forms.Button()
        Me.btn_generar_movimiento = New System.Windows.Forms.Button()
        Me.btn_limpiar_movimiento = New System.Windows.Forms.Button()
        Me.btn_est_carnicos = New System.Windows.Forms.Button()
        Me.btn_excel_carnicos = New System.Windows.Forms.Button()
        Me.btn_plano_carnicos = New System.Windows.Forms.Button()
        Me.btn_salir_carnicos = New System.Windows.Forms.Button()
        Me.btn_carnicos = New System.Windows.Forms.Button()
        Me.btn_limpiar_carnicos = New System.Windows.Forms.Button()
        Me.btn_est_precios = New System.Windows.Forms.Button()
        Me.btn_excel_precios = New System.Windows.Forms.Button()
        Me.btn_plano_precios = New System.Windows.Forms.Button()
        Me.btn_salir_precios = New System.Windows.Forms.Button()
        Me.btn_generar_precios = New System.Windows.Forms.Button()
        Me.btn_limpiar_precios = New System.Windows.Forms.Button()
        Me.btn_est_pres_vend = New System.Windows.Forms.Button()
        Me.btn_excel_pres_ven = New System.Windows.Forms.Button()
        Me.btn_plano_pres_vend = New System.Windows.Forms.Button()
        Me.btn_salir_pres_vend = New System.Windows.Forms.Button()
        Me.btn_generar_plano_pres_ven = New System.Windows.Forms.Button()
        Me.btn_limpiar_pres_ven = New System.Windows.Forms.Button()
        Me.btn_est_jefe_ventas = New System.Windows.Forms.Button()
        Me.btn_excel_pres_jef = New System.Windows.Forms.Button()
        Me.btn_plano_pres_jef = New System.Windows.Forms.Button()
        Me.btn_salir_pres_jef = New System.Windows.Forms.Button()
        Me.btn_generar_plano_pres_jef = New System.Windows.Forms.Button()
        Me.btn_limpiar_pres_jef = New System.Windows.Forms.Button()
        Me.btn_est_bancolombia = New System.Windows.Forms.Button()
        Me.btn_excel_bancolombia = New System.Windows.Forms.Button()
        Me.btn_plano_bancolombia = New System.Windows.Forms.Button()
        Me.btn_salir_bancolombia = New System.Windows.Forms.Button()
        Me.btn_generar_bancolombia = New System.Windows.Forms.Button()
        Me.btn_limpiar_bancolombia = New System.Windows.Forms.Button()
        Me.btn_est_bancobogota = New System.Windows.Forms.Button()
        Me.btn_excel_bogota = New System.Windows.Forms.Button()
        Me.btn_plano_bogota = New System.Windows.Forms.Button()
        Me.btn_salir_bogota = New System.Windows.Forms.Button()
        Me.btn_generar_bogota = New System.Windows.Forms.Button()
        Me.btn_limpiar_bogota = New System.Windows.Forms.Button()
        Me.btn_est_items = New System.Windows.Forms.Button()
        Me.btn_csv_items = New System.Windows.Forms.Button()
        Me.btn_plano_items = New System.Windows.Forms.Button()
        Me.btn_salir_items = New System.Windows.Forms.Button()
        Me.btn_generar_items = New System.Windows.Forms.Button()
        Me.btn_limpiar_items = New System.Windows.Forms.Button()
        Me.btn_est_act_items = New System.Windows.Forms.Button()
        Me.btn_csv_act_items = New System.Windows.Forms.Button()
        Me.btn_plano_act_items = New System.Windows.Forms.Button()
        Me.btn_salir_act_items = New System.Windows.Forms.Button()
        Me.btn_generar_act_items = New System.Windows.Forms.Button()
        Me.btn_limpiar_act_items = New System.Windows.Forms.Button()
        Me.btn_est_clasitems = New System.Windows.Forms.Button()
        Me.btn_csv_clasitems = New System.Windows.Forms.Button()
        Me.btn_plano_clasitems = New System.Windows.Forms.Button()
        Me.btn_salir_clasitems = New System.Windows.Forms.Button()
        Me.btn_generar_clasitems = New System.Windows.Forms.Button()
        Me.btn_limpiar_clasitems = New System.Windows.Forms.Button()
        Me.btn_est_sol_compra = New System.Windows.Forms.Button()
        Me.btn_csv_sol_compra = New System.Windows.Forms.Button()
        Me.btn_plano_sol_compra = New System.Windows.Forms.Button()
        Me.btn_salir_sol_compras = New System.Windows.Forms.Button()
        Me.Btn_generar_sol_compras = New System.Windows.Forms.Button()
        Me.btn_limpiar_sol_compra = New System.Windows.Forms.Button()
        Me.btn_est_criterios = New System.Windows.Forms.Button()
        Me.btn_csv_criterios = New System.Windows.Forms.Button()
        Me.btn_plano_criterios = New System.Windows.Forms.Button()
        Me.btn_salir_criterios = New System.Windows.Forms.Button()
        Me.btn_generar_criterios = New System.Windows.Forms.Button()
        Me.btn_limipiar_criterios = New System.Windows.Forms.Button()
        Me.btn_est_bajas = New System.Windows.Forms.Button()
        Me.btn_csv_bajas = New System.Windows.Forms.Button()
        Me.btn_planos_bajas = New System.Windows.Forms.Button()
        Me.btn_salir_bajas = New System.Windows.Forms.Button()
        Me.btn_generar_bajas = New System.Windows.Forms.Button()
        Me.btn_limpiar_bajas = New System.Windows.Forms.Button()
        Me.btn_est_cuentas = New System.Windows.Forms.Button()
        Me.btn_csv_cuentas = New System.Windows.Forms.Button()
        Me.btn_plano_cuentas = New System.Windows.Forms.Button()
        Me.btn_salir_cuentas = New System.Windows.Forms.Button()
        Me.btn_generar_cuentas = New System.Windows.Forms.Button()
        Me.btn_limpiar_cuentas = New System.Windows.Forms.Button()
        Me.btn_est_traslados = New System.Windows.Forms.Button()
        Me.btn_traslados = New System.Windows.Forms.Button()
        Me.btn_plano_traslados = New System.Windows.Forms.Button()
        Me.btn_salir_traslados = New System.Windows.Forms.Button()
        Me.btn_generar_traslados = New System.Windows.Forms.Button()
        Me.btn_limpiar_traslados = New System.Windows.Forms.Button()
        Me.btn_est_codigobarras = New System.Windows.Forms.Button()
        Me.btn_codigobarras = New System.Windows.Forms.Button()
        Me.btn_planocodigobarras = New System.Windows.Forms.Button()
        Me.btn_salircodigobarras = New System.Windows.Forms.Button()
        Me.btn_generarcodigobarras = New System.Windows.Forms.Button()
        Me.btn_limpiarcodigobarras = New System.Windows.Forms.Button()
        Me.btn_est_inv = New System.Windows.Forms.Button()
        Me.btn_csv_inv = New System.Windows.Forms.Button()
        Me.btn_plano_inv = New System.Windows.Forms.Button()
        Me.btn_salir_inv = New System.Windows.Forms.Button()
        Me.btn_generar_inv = New System.Windows.Forms.Button()
        Me.btn_limpiar_inv = New System.Windows.Forms.Button()
        Me.csv_est_entidades_proveedores = New System.Windows.Forms.Button()
        Me.btn_seleccionar_proveedor_csv = New System.Windows.Forms.Button()
        Me.btn_generar_plano_proveedor = New System.Windows.Forms.Button()
        Me.btn_salir_entidades_proveedores = New System.Windows.Forms.Button()
        Me.btn_generar_entidades_proveedores = New System.Windows.Forms.Button()
        Me.btn_limpiar_entidades_proveedores = New System.Windows.Forms.Button()
        Me.xls_est_entidades_clientes = New System.Windows.Forms.Button()
        Me.btn_clientesXLS = New System.Windows.Forms.Button()
        Me.btn_cleintesPlano = New System.Windows.Forms.Button()
        Me.btn_salirentcli = New System.Windows.Forms.Button()
        Me.btn_generar_entidades_clientes = New System.Windows.Forms.Button()
        Me.btn_limpiar_entidades_clientes = New System.Windows.Forms.Button()
        Me.btnCargueEstadoActivosFijos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnGenerarCambioEstadoActivosFijos = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnExportarEstMovCont = New System.Windows.Forms.Button()
        Me.btnExcelMovConta = New System.Windows.Forms.Button()
        Me.btnExportarPlanoMovCont = New System.Windows.Forms.Button()
        Me.btnSalirMovConta = New System.Windows.Forms.Button()
        Me.btnGenerarMovContab = New System.Windows.Forms.Button()
        Me.btnLimpiarMovCont = New System.Windows.Forms.Button()
        Me.btn_estruc_ImpYret = New System.Windows.Forms.Button()
        Me.btn_seleccionar_impyret_excel = New System.Windows.Forms.Button()
        Me.btn_seleccionar_planoImpyRet = New System.Windows.Forms.Button()
        Me.btn_salir_impyret = New System.Windows.Forms.Button()
        Me.btn_generar_impyret = New System.Windows.Forms.Button()
        Me.btn_limpiar_estyret = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSeleccionarArchivoCosto = New System.Windows.Forms.Button()
        Me.btnExportarArchivoCosto = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnSalirDistribucionCostos = New System.Windows.Forms.Button()
        Me.btnGenerarDistribucionCostos = New System.Windows.Forms.Button()
        Me.btnLimpiarDistribucionCostos = New System.Windows.Forms.Button()
        Me.btnRutaGenerarNomina = New System.Windows.Forms.Button()
        Me.btnNominaPlano = New System.Windows.Forms.Button()
        Me.btnExportarEstructuraCompraServicios = New System.Windows.Forms.Button()
        Me.btnSeleccionarExcelCompraServicios = New System.Windows.Forms.Button()
        Me.btnExportarPlanoCompraServicios = New System.Windows.Forms.Button()
        Me.btnSalirCompraServicios = New System.Windows.Forms.Button()
        Me.btnGenerarCompraServicios = New System.Windows.Forms.Button()
        Me.btnLimpiarCompraServicios = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.btnExcelActCodBarras = New System.Windows.Forms.Button()
        Me.btnGenerarActCodBarras = New System.Windows.Forms.Button()
        Me.btnRutaGeneraExcel = New System.Windows.Forms.Button()
        Me.btnRutaPlanoNomina = New System.Windows.Forms.Button()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.txtConceptoNomSAP = New System.Windows.Forms.TextBox()
        Me.btnNominaPlanoOrigen.SuspendLayout()
        Me.TabPage_ActFijos.SuspendLayout()
        Me.TabPage_Activaciones.SuspendLayout()
        Me.TabPage_MovContable.SuspendLayout()
        Me.TabPage_Carnicos.SuspendLayout()
        Me.TabPage_Precios.SuspendLayout()
        Me.TabPage_Presup_Vendedor.SuspendLayout()
        Me.TabPage_Presup_Jefe.SuspendLayout()
        Me.TabPage_ExtractoBan.SuspendLayout()
        Me.TabPage_ExtractoBog.SuspendLayout()
        Me.TabPage_Items.SuspendLayout()
        Me.TabPage_act_items.SuspendLayout()
        Me.TabPage_Clas_items.SuspendLayout()
        Me.TabPage_Sol_Compras.SuspendLayout()
        Me.TabPage_criterios.SuspendLayout()
        Me.TabPage_Bajas.SuspendLayout()
        Me.TabPage_cuentasxpagar.SuspendLayout()
        Me.TabPage_Traslados_AF.SuspendLayout()
        Me.TabPage_Codigo_barras.SuspendLayout()
        Me.TabPage_Mov_Inventarios.SuspendLayout()
        Me.TabPage_Entidades_Proveedores.SuspendLayout()
        Me.TabPage_Entidades_Clientes.SuspendLayout()
        Me.TabPage_Cambio_Estado_Activos_Fijos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage_Mov_Contab_New.SuspendLayout()
        Me.TabPage_ImpuestosYRetenciones.SuspendLayout()
        Me.TabPage_CostoEstandar.SuspendLayout()
        Me.TabPageDistribucionCostos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPageCompraServicios.SuspendLayout()
        Me.TabPageImportarTercero.SuspendLayout()
        Me.TabPageActualizarCodBarras.SuspendLayout()
        Me.TabPagePlanoNomSAP.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.OldLace
        Me.TreeView1.Location = New System.Drawing.Point(6, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(258, 367)
        Me.TreeView1.TabIndex = 0
        '
        'btnNominaPlanoOrigen
        '
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_ActFijos)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Activaciones)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_MovContable)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Carnicos)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Precios)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Presup_Vendedor)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Presup_Jefe)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_ExtractoBan)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_ExtractoBog)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Items)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_act_items)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Clas_items)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Sol_Compras)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_criterios)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Bajas)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_cuentasxpagar)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Traslados_AF)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Codigo_barras)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Mov_Inventarios)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Entidades_Proveedores)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Entidades_Clientes)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Cambio_Estado_Activos_Fijos)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_Mov_Contab_New)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_ImpuestosYRetenciones)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage_CostoEstandar)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPageDistribucionCostos)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPage1)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPageCompraServicios)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPageImportarTercero)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPageActualizarCodBarras)
        Me.btnNominaPlanoOrigen.Controls.Add(Me.TabPagePlanoNomSAP)
        Me.btnNominaPlanoOrigen.Location = New System.Drawing.Point(270, 12)
        Me.btnNominaPlanoOrigen.Name = "btnNominaPlanoOrigen"
        Me.btnNominaPlanoOrigen.SelectedIndex = 0
        Me.btnNominaPlanoOrigen.Size = New System.Drawing.Size(701, 367)
        Me.btnNominaPlanoOrigen.TabIndex = 1
        Me.btnNominaPlanoOrigen.Visible = False
        '
        'TabPage_ActFijos
        '
        Me.TabPage_ActFijos.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage_ActFijos.Controls.Add(Me.btn_est_activos)
        Me.TabPage_ActFijos.Controls.Add(Me.Label4)
        Me.TabPage_ActFijos.Controls.Add(Me.btn_excel_activos)
        Me.TabPage_ActFijos.Controls.Add(Me.btn_plano_activos)
        Me.TabPage_ActFijos.Controls.Add(Me.btn_salir_activos)
        Me.TabPage_ActFijos.Controls.Add(Me.btn_generar_activos)
        Me.TabPage_ActFijos.Controls.Add(Me.btn_limpiar_activos)
        Me.TabPage_ActFijos.Controls.Add(Me.Label1)
        Me.TabPage_ActFijos.Controls.Add(Me.txt_archivo_plano_activos)
        Me.TabPage_ActFijos.Controls.Add(Me.Label2)
        Me.TabPage_ActFijos.Controls.Add(Me.txt_archivo_excel_activos)
        Me.TabPage_ActFijos.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ActFijos.Name = "TabPage_ActFijos"
        Me.TabPage_ActFijos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_ActFijos.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_ActFijos.TabIndex = 1
        Me.TabPage_ActFijos.Text = "Activos Fijos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(316, 26)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "PLANO DE ACTIVOS FIJOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Archivo Plano"
        '
        'txt_archivo_plano_activos
        '
        Me.txt_archivo_plano_activos.Enabled = False
        Me.txt_archivo_plano_activos.Location = New System.Drawing.Point(16, 196)
        Me.txt_archivo_plano_activos.Name = "txt_archivo_plano_activos"
        Me.txt_archivo_plano_activos.Size = New System.Drawing.Size(518, 20)
        Me.txt_archivo_plano_activos.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Archivo de Excel"
        '
        'txt_archivo_excel_activos
        '
        Me.txt_archivo_excel_activos.Enabled = False
        Me.txt_archivo_excel_activos.Location = New System.Drawing.Point(16, 103)
        Me.txt_archivo_excel_activos.Name = "txt_archivo_excel_activos"
        Me.txt_archivo_excel_activos.Size = New System.Drawing.Size(518, 20)
        Me.txt_archivo_excel_activos.TabIndex = 9
        '
        'TabPage_Activaciones
        '
        Me.TabPage_Activaciones.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage_Activaciones.Controls.Add(Me.btn_est_activaciones)
        Me.TabPage_Activaciones.Controls.Add(Me.Label37)
        Me.TabPage_Activaciones.Controls.Add(Me.Dtp_fecha_activaciones)
        Me.TabPage_Activaciones.Controls.Add(Me.Label3)
        Me.TabPage_Activaciones.Controls.Add(Me.txt_tip_doc)
        Me.TabPage_Activaciones.Controls.Add(Me.lbl_tip_documento)
        Me.TabPage_Activaciones.Controls.Add(Me.lbl_plano)
        Me.TabPage_Activaciones.Controls.Add(Me.txt_plano)
        Me.TabPage_Activaciones.Controls.Add(Me.lbl_excel)
        Me.TabPage_Activaciones.Controls.Add(Me.txt_archivoexcel)
        Me.TabPage_Activaciones.Controls.Add(Me.btn_salir)
        Me.TabPage_Activaciones.Controls.Add(Me.btn_generar)
        Me.TabPage_Activaciones.Controls.Add(Me.btn_limpiar)
        Me.TabPage_Activaciones.Controls.Add(Me.btn_plano)
        Me.TabPage_Activaciones.Controls.Add(Me.btn_seleccionar)
        Me.TabPage_Activaciones.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Activaciones.Name = "TabPage_Activaciones"
        Me.TabPage_Activaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Activaciones.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Activaciones.TabIndex = 0
        Me.TabPage_Activaciones.Text = "Activaciones"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(238, 75)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(47, 17)
        Me.Label37.TabIndex = 41
        Me.Label37.Text = "Fecha"
        '
        'Dtp_fecha_activaciones
        '
        Me.Dtp_fecha_activaciones.Location = New System.Drawing.Point(308, 72)
        Me.Dtp_fecha_activaciones.Name = "Dtp_fecha_activaciones"
        Me.Dtp_fecha_activaciones.Size = New System.Drawing.Size(217, 20)
        Me.Dtp_fecha_activaciones.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "PLANO DE ACTIVACIONES"
        '
        'txt_tip_doc
        '
        Me.txt_tip_doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tip_doc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_doc.Location = New System.Drawing.Point(161, 69)
        Me.txt_tip_doc.MaxLength = 3
        Me.txt_tip_doc.Name = "txt_tip_doc"
        Me.txt_tip_doc.Size = New System.Drawing.Size(59, 26)
        Me.txt_tip_doc.TabIndex = 10
        Me.txt_tip_doc.Text = "AFD"
        '
        'lbl_tip_documento
        '
        Me.lbl_tip_documento.AutoSize = True
        Me.lbl_tip_documento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tip_documento.Location = New System.Drawing.Point(16, 75)
        Me.lbl_tip_documento.Name = "lbl_tip_documento"
        Me.lbl_tip_documento.Size = New System.Drawing.Size(132, 17)
        Me.lbl_tip_documento.TabIndex = 9
        Me.lbl_tip_documento.Text = "Tipo de Documento"
        '
        'lbl_plano
        '
        Me.lbl_plano.AutoSize = True
        Me.lbl_plano.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_plano.Location = New System.Drawing.Point(16, 191)
        Me.lbl_plano.Name = "lbl_plano"
        Me.lbl_plano.Size = New System.Drawing.Size(95, 17)
        Me.lbl_plano.TabIndex = 5
        Me.lbl_plano.Text = "Archivo Plano"
        '
        'txt_plano
        '
        Me.txt_plano.Enabled = False
        Me.txt_plano.Location = New System.Drawing.Point(19, 220)
        Me.txt_plano.Name = "txt_plano"
        Me.txt_plano.Size = New System.Drawing.Size(506, 20)
        Me.txt_plano.TabIndex = 3
        '
        'lbl_excel
        '
        Me.lbl_excel.AutoSize = True
        Me.lbl_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_excel.Location = New System.Drawing.Point(16, 122)
        Me.lbl_excel.Name = "lbl_excel"
        Me.lbl_excel.Size = New System.Drawing.Size(112, 17)
        Me.lbl_excel.TabIndex = 2
        Me.lbl_excel.Text = "Archivo de Excel"
        '
        'txt_archivoexcel
        '
        Me.txt_archivoexcel.Enabled = False
        Me.txt_archivoexcel.Location = New System.Drawing.Point(19, 153)
        Me.txt_archivoexcel.Name = "txt_archivoexcel"
        Me.txt_archivoexcel.Size = New System.Drawing.Size(506, 20)
        Me.txt_archivoexcel.TabIndex = 0
        '
        'TabPage_MovContable
        '
        Me.TabPage_MovContable.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage_MovContable.Controls.Add(Me.btn_est_movimiento)
        Me.TabPage_MovContable.Controls.Add(Me.txtnotas)
        Me.TabPage_MovContable.Controls.Add(Me.dtp_fecha)
        Me.TabPage_MovContable.Controls.Add(Me.Label10)
        Me.TabPage_MovContable.Controls.Add(Me.Label9)
        Me.TabPage_MovContable.Controls.Add(Me.txt_tip_doc_mov)
        Me.TabPage_MovContable.Controls.Add(Me.Label8)
        Me.TabPage_MovContable.Controls.Add(Me.txt_co)
        Me.TabPage_MovContable.Controls.Add(Me.lbl_centro_operativo)
        Me.TabPage_MovContable.Controls.Add(Me.Label5)
        Me.TabPage_MovContable.Controls.Add(Me.Label6)
        Me.TabPage_MovContable.Controls.Add(Me.txt_plano_mov)
        Me.TabPage_MovContable.Controls.Add(Me.Label7)
        Me.TabPage_MovContable.Controls.Add(Me.txt_excel_movimiento)
        Me.TabPage_MovContable.Controls.Add(Me.btn_excel_movimiento)
        Me.TabPage_MovContable.Controls.Add(Me.btn_plano_movimiento)
        Me.TabPage_MovContable.Controls.Add(Me.btn_salir_movimiento)
        Me.TabPage_MovContable.Controls.Add(Me.btn_generar_movimiento)
        Me.TabPage_MovContable.Controls.Add(Me.btn_limpiar_movimiento)
        Me.TabPage_MovContable.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_MovContable.Name = "TabPage_MovContable"
        Me.TabPage_MovContable.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_MovContable.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_MovContable.TabIndex = 2
        Me.TabPage_MovContable.Text = "Movimiento Contable"
        '
        'txtnotas
        '
        Me.txtnotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnotas.Location = New System.Drawing.Point(56, 99)
        Me.txtnotas.MaxLength = 255
        Me.txtnotas.Multiline = True
        Me.txtnotas.Name = "txtnotas"
        Me.txtnotas.Size = New System.Drawing.Size(627, 60)
        Me.txtnotas.TabIndex = 41
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(482, 71)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(201, 20)
        Me.dtp_fecha.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Notas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(353, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Fecha Documento"
        '
        'txt_tip_doc_mov
        '
        Me.txt_tip_doc_mov.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tip_doc_mov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_doc_mov.Location = New System.Drawing.Point(306, 67)
        Me.txt_tip_doc_mov.MaxLength = 3
        Me.txt_tip_doc_mov.Name = "txt_tip_doc_mov"
        Me.txt_tip_doc_mov.Size = New System.Drawing.Size(44, 26)
        Me.txt_tip_doc_mov.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(169, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Tipo de Documento"
        '
        'txt_co
        '
        Me.txt_co.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_co.Location = New System.Drawing.Point(126, 67)
        Me.txt_co.MaxLength = 3
        Me.txt_co.Name = "txt_co"
        Me.txt_co.Size = New System.Drawing.Size(40, 26)
        Me.txt_co.TabIndex = 33
        '
        'lbl_centro_operativo
        '
        Me.lbl_centro_operativo.AutoSize = True
        Me.lbl_centro_operativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_centro_operativo.Location = New System.Drawing.Point(9, 73)
        Me.lbl_centro_operativo.Name = "lbl_centro_operativo"
        Me.lbl_centro_operativo.Size = New System.Drawing.Size(116, 17)
        Me.lbl_centro_operativo.TabIndex = 32
        Me.lbl_centro_operativo.Text = "Centro Operativo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(127, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(422, 26)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "PLANO DE MOVIMIENTO CONTABLE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Archivo Plano"
        '
        'txt_plano_mov
        '
        Me.txt_plano_mov.Enabled = False
        Me.txt_plano_mov.Location = New System.Drawing.Point(12, 234)
        Me.txt_plano_mov.Name = "txt_plano_mov"
        Me.txt_plano_mov.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_mov.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Archivo de Excel"
        '
        'txt_excel_movimiento
        '
        Me.txt_excel_movimiento.Enabled = False
        Me.txt_excel_movimiento.Location = New System.Drawing.Point(12, 183)
        Me.txt_excel_movimiento.Name = "txt_excel_movimiento"
        Me.txt_excel_movimiento.Size = New System.Drawing.Size(518, 20)
        Me.txt_excel_movimiento.TabIndex = 22
        '
        'TabPage_Carnicos
        '
        Me.TabPage_Carnicos.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TabPage_Carnicos.Controls.Add(Me.btn_est_carnicos)
        Me.TabPage_Carnicos.Controls.Add(Me.txt_cuentaxcobrarcar)
        Me.TabPage_Carnicos.Controls.Add(Me.lbl_cuentaxcobrar_car)
        Me.TabPage_Carnicos.Controls.Add(Me.txt_cuentacontab_car)
        Me.TabPage_Carnicos.Controls.Add(Me.lbl_cuenta_contablecar)
        Me.TabPage_Carnicos.Controls.Add(Me.Label17)
        Me.TabPage_Carnicos.Controls.Add(Me.txt_notas_car)
        Me.TabPage_Carnicos.Controls.Add(Me.Dtp_fecha_car)
        Me.TabPage_Carnicos.Controls.Add(Me.Label11)
        Me.TabPage_Carnicos.Controls.Add(Me.txt_tipdoc_car)
        Me.TabPage_Carnicos.Controls.Add(Me.Label12)
        Me.TabPage_Carnicos.Controls.Add(Me.txt_co_car)
        Me.TabPage_Carnicos.Controls.Add(Me.Label13)
        Me.TabPage_Carnicos.Controls.Add(Me.Label14)
        Me.TabPage_Carnicos.Controls.Add(Me.Label15)
        Me.TabPage_Carnicos.Controls.Add(Me.txt_plano_carnicos)
        Me.TabPage_Carnicos.Controls.Add(Me.Label16)
        Me.TabPage_Carnicos.Controls.Add(Me.txt_excel_carnicos)
        Me.TabPage_Carnicos.Controls.Add(Me.btn_excel_carnicos)
        Me.TabPage_Carnicos.Controls.Add(Me.btn_plano_carnicos)
        Me.TabPage_Carnicos.Controls.Add(Me.btn_salir_carnicos)
        Me.TabPage_Carnicos.Controls.Add(Me.btn_carnicos)
        Me.TabPage_Carnicos.Controls.Add(Me.btn_limpiar_carnicos)
        Me.TabPage_Carnicos.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Carnicos.Name = "TabPage_Carnicos"
        Me.TabPage_Carnicos.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Carnicos.TabIndex = 3
        Me.TabPage_Carnicos.Text = "Carnicos"
        '
        'txt_cuentaxcobrarcar
        '
        Me.txt_cuentaxcobrarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuentaxcobrarcar.Location = New System.Drawing.Point(482, 99)
        Me.txt_cuentaxcobrarcar.MaxLength = 20
        Me.txt_cuentaxcobrarcar.Name = "txt_cuentaxcobrarcar"
        Me.txt_cuentaxcobrarcar.Size = New System.Drawing.Size(201, 26)
        Me.txt_cuentaxcobrarcar.TabIndex = 63
        Me.txt_cuentaxcobrarcar.Text = "13050501"
        '
        'lbl_cuentaxcobrar_car
        '
        Me.lbl_cuentaxcobrar_car.AutoSize = True
        Me.lbl_cuentaxcobrar_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuentaxcobrar_car.Location = New System.Drawing.Point(345, 103)
        Me.lbl_cuentaxcobrar_car.Name = "lbl_cuentaxcobrar_car"
        Me.lbl_cuentaxcobrar_car.Size = New System.Drawing.Size(125, 17)
        Me.lbl_cuentaxcobrar_car.TabIndex = 62
        Me.lbl_cuentaxcobrar_car.Text = "Cuenta por Cobrar"
        '
        'txt_cuentacontab_car
        '
        Me.txt_cuentacontab_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cuentacontab_car.Location = New System.Drawing.Point(126, 99)
        Me.txt_cuentacontab_car.MaxLength = 20
        Me.txt_cuentacontab_car.Name = "txt_cuentacontab_car"
        Me.txt_cuentacontab_car.Size = New System.Drawing.Size(207, 26)
        Me.txt_cuentacontab_car.TabIndex = 61
        Me.txt_cuentacontab_car.Text = "13659502"
        '
        'lbl_cuenta_contablecar
        '
        Me.lbl_cuenta_contablecar.AutoSize = True
        Me.lbl_cuenta_contablecar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuenta_contablecar.Location = New System.Drawing.Point(9, 103)
        Me.lbl_cuenta_contablecar.Name = "lbl_cuenta_contablecar"
        Me.lbl_cuenta_contablecar.Size = New System.Drawing.Size(113, 17)
        Me.lbl_cuenta_contablecar.TabIndex = 60
        Me.lbl_cuenta_contablecar.Text = "Cuenta Contable"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 139)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 17)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Notas"
        '
        'txt_notas_car
        '
        Me.txt_notas_car.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_car.Location = New System.Drawing.Point(56, 139)
        Me.txt_notas_car.MaxLength = 255
        Me.txt_notas_car.Multiline = True
        Me.txt_notas_car.Name = "txt_notas_car"
        Me.txt_notas_car.Size = New System.Drawing.Size(627, 39)
        Me.txt_notas_car.TabIndex = 58
        Me.txt_notas_car.Text = "CRUCE CARNICOS MARZO 2015"
        '
        'Dtp_fecha_car
        '
        Me.Dtp_fecha_car.Location = New System.Drawing.Point(482, 63)
        Me.Dtp_fecha_car.Name = "Dtp_fecha_car"
        Me.Dtp_fecha_car.Size = New System.Drawing.Size(201, 20)
        Me.Dtp_fecha_car.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(353, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Fecha Documento"
        '
        'txt_tipdoc_car
        '
        Me.txt_tipdoc_car.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tipdoc_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipdoc_car.Location = New System.Drawing.Point(306, 59)
        Me.txt_tipdoc_car.MaxLength = 3
        Me.txt_tipdoc_car.Name = "txt_tipdoc_car"
        Me.txt_tipdoc_car.Size = New System.Drawing.Size(44, 26)
        Me.txt_tipdoc_car.TabIndex = 55
        Me.txt_tipdoc_car.Text = "NOM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(169, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 17)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Tipo de Documento"
        '
        'txt_co_car
        '
        Me.txt_co_car.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_co_car.Location = New System.Drawing.Point(126, 59)
        Me.txt_co_car.MaxLength = 3
        Me.txt_co_car.Name = "txt_co_car"
        Me.txt_co_car.Size = New System.Drawing.Size(40, 26)
        Me.txt_co_car.TabIndex = 53
        Me.txt_co_car.Text = "190"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 17)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Centro Operativo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(214, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(264, 26)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "PLANO DE CARNICOS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 232)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 17)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Archivo Plano"
        '
        'txt_plano_carnicos
        '
        Me.txt_plano_carnicos.Enabled = False
        Me.txt_plano_carnicos.Location = New System.Drawing.Point(12, 253)
        Me.txt_plano_carnicos.Name = "txt_plano_carnicos"
        Me.txt_plano_carnicos.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_carnicos.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 17)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Archivo de Excel"
        '
        'txt_excel_carnicos
        '
        Me.txt_excel_carnicos.Enabled = False
        Me.txt_excel_carnicos.Location = New System.Drawing.Point(12, 202)
        Me.txt_excel_carnicos.Name = "txt_excel_carnicos"
        Me.txt_excel_carnicos.Size = New System.Drawing.Size(518, 20)
        Me.txt_excel_carnicos.TabIndex = 42
        '
        'TabPage_Precios
        '
        Me.TabPage_Precios.BackColor = System.Drawing.Color.Khaki
        Me.TabPage_Precios.Controls.Add(Me.btn_est_precios)
        Me.TabPage_Precios.Controls.Add(Me.Label19)
        Me.TabPage_Precios.Controls.Add(Me.txt_plano_precios)
        Me.TabPage_Precios.Controls.Add(Me.Label20)
        Me.TabPage_Precios.Controls.Add(Me.txt_excel_precios)
        Me.TabPage_Precios.Controls.Add(Me.Label18)
        Me.TabPage_Precios.Controls.Add(Me.btn_excel_precios)
        Me.TabPage_Precios.Controls.Add(Me.btn_plano_precios)
        Me.TabPage_Precios.Controls.Add(Me.btn_salir_precios)
        Me.TabPage_Precios.Controls.Add(Me.btn_generar_precios)
        Me.TabPage_Precios.Controls.Add(Me.btn_limpiar_precios)
        Me.TabPage_Precios.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Precios.Name = "TabPage_Precios"
        Me.TabPage_Precios.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Precios.TabIndex = 4
        Me.TabPage_Precios.Text = "Precios"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 17)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Archivo Plano"
        '
        'txt_plano_precios
        '
        Me.txt_plano_precios.Enabled = False
        Me.txt_plano_precios.Location = New System.Drawing.Point(12, 176)
        Me.txt_plano_precios.Name = "txt_plano_precios"
        Me.txt_plano_precios.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_precios.TabIndex = 55
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(9, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 17)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "Archivo de Excel"
        '
        'txt_excel_precios
        '
        Me.txt_excel_precios.Enabled = False
        Me.txt_excel_precios.Location = New System.Drawing.Point(12, 111)
        Me.txt_excel_precios.Name = "txt_excel_precios"
        Me.txt_excel_precios.Size = New System.Drawing.Size(518, 20)
        Me.txt_excel_precios.TabIndex = 53
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(213, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(246, 26)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "PLANO DE PRECIOS"
        '
        'TabPage_Presup_Vendedor
        '
        Me.TabPage_Presup_Vendedor.BackColor = System.Drawing.Color.MistyRose
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.btn_est_pres_vend)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.Label26)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.cbo_presupuesto_vend)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.Label24)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.txt_periodo_pres_vend)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.Label23)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.Label21)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.txt_plano_pres_vend)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.Label22)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.txt_excel_pres_vend)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.btn_excel_pres_ven)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.btn_plano_pres_vend)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.btn_salir_pres_vend)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.btn_generar_plano_pres_ven)
        Me.TabPage_Presup_Vendedor.Controls.Add(Me.btn_limpiar_pres_ven)
        Me.TabPage_Presup_Vendedor.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Presup_Vendedor.Name = "TabPage_Presup_Vendedor"
        Me.TabPage_Presup_Vendedor.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Presup_Vendedor.TabIndex = 5
        Me.TabPage_Presup_Vendedor.Text = "Presupuesto Vendedor"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(172, 76)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 17)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Presupuesto"
        '
        'cbo_presupuesto_vend
        '
        Me.cbo_presupuesto_vend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_presupuesto_vend.FormattingEnabled = True
        Me.cbo_presupuesto_vend.Location = New System.Drawing.Point(267, 74)
        Me.cbo_presupuesto_vend.Name = "cbo_presupuesto_vend"
        Me.cbo_presupuesto_vend.Size = New System.Drawing.Size(263, 26)
        Me.cbo_presupuesto_vend.TabIndex = 77
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(9, 76)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 17)
        Me.Label24.TabIndex = 73
        Me.Label24.Text = "Periodo"
        '
        'txt_periodo_pres_vend
        '
        Me.txt_periodo_pres_vend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_periodo_pres_vend.Location = New System.Drawing.Point(72, 71)
        Me.txt_periodo_pres_vend.MaxLength = 6
        Me.txt_periodo_pres_vend.Name = "txt_periodo_pres_vend"
        Me.txt_periodo_pres_vend.Size = New System.Drawing.Size(80, 24)
        Me.txt_periodo_pres_vend.TabIndex = 72
        Me.txt_periodo_pres_vend.Text = "201501"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(119, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(450, 26)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "PLANO PRESUPUESTO VENDEDORES"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 17)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Archivo Plano"
        '
        'txt_plano_pres_vend
        '
        Me.txt_plano_pres_vend.Enabled = False
        Me.txt_plano_pres_vend.Location = New System.Drawing.Point(12, 194)
        Me.txt_plano_pres_vend.Name = "txt_plano_pres_vend"
        Me.txt_plano_pres_vend.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_pres_vend.TabIndex = 64
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 114)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 17)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Archivo de Excel"
        '
        'txt_excel_pres_vend
        '
        Me.txt_excel_pres_vend.Enabled = False
        Me.txt_excel_pres_vend.Location = New System.Drawing.Point(12, 137)
        Me.txt_excel_pres_vend.Name = "txt_excel_pres_vend"
        Me.txt_excel_pres_vend.Size = New System.Drawing.Size(518, 20)
        Me.txt_excel_pres_vend.TabIndex = 62
        '
        'TabPage_Presup_Jefe
        '
        Me.TabPage_Presup_Jefe.BackColor = System.Drawing.Color.MistyRose
        Me.TabPage_Presup_Jefe.Controls.Add(Me.btn_est_jefe_ventas)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.Label27)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.cbo_presupuesto_jef2)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.Label29)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.txt_periodo_pres_jef)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.Label30)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.Label31)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.txt_plano_pres_jef)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.Label32)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.txt_excel_pres_jef)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.btn_excel_pres_jef)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.btn_plano_pres_jef)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.btn_salir_pres_jef)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.btn_generar_plano_pres_jef)
        Me.TabPage_Presup_Jefe.Controls.Add(Me.btn_limpiar_pres_jef)
        Me.TabPage_Presup_Jefe.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Presup_Jefe.Name = "TabPage_Presup_Jefe"
        Me.TabPage_Presup_Jefe.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Presup_Jefe.TabIndex = 6
        Me.TabPage_Presup_Jefe.Text = "Presupuesto Jefe Venta"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(171, 76)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 17)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Presupuesto"
        '
        'cbo_presupuesto_jef2
        '
        Me.cbo_presupuesto_jef2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_presupuesto_jef2.FormattingEnabled = True
        Me.cbo_presupuesto_jef2.Location = New System.Drawing.Point(264, 75)
        Me.cbo_presupuesto_jef2.Name = "cbo_presupuesto_jef2"
        Me.cbo_presupuesto_jef2.Size = New System.Drawing.Size(266, 26)
        Me.cbo_presupuesto_jef2.TabIndex = 93
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(9, 75)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 17)
        Me.Label29.TabIndex = 90
        Me.Label29.Text = "Periodo"
        '
        'txt_periodo_pres_jef
        '
        Me.txt_periodo_pres_jef.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_periodo_pres_jef.Location = New System.Drawing.Point(72, 72)
        Me.txt_periodo_pres_jef.MaxLength = 6
        Me.txt_periodo_pres_jef.Name = "txt_periodo_pres_jef"
        Me.txt_periodo_pres_jef.Size = New System.Drawing.Size(80, 24)
        Me.txt_periodo_pres_jef.TabIndex = 89
        Me.txt_periodo_pres_jef.Text = "201501"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(107, 18)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(483, 26)
        Me.Label30.TabIndex = 88
        Me.Label30.Text = "PLANO PRESUPUESTO JEFE DE VENTAS"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(9, 174)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(95, 17)
        Me.Label31.TabIndex = 82
        Me.Label31.Text = "Archivo Plano"
        '
        'txt_plano_pres_jef
        '
        Me.txt_plano_pres_jef.Enabled = False
        Me.txt_plano_pres_jef.Location = New System.Drawing.Point(12, 195)
        Me.txt_plano_pres_jef.Name = "txt_plano_pres_jef"
        Me.txt_plano_pres_jef.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_pres_jef.TabIndex = 81
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(9, 115)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(112, 17)
        Me.Label32.TabIndex = 80
        Me.Label32.Text = "Archivo de Excel"
        '
        'txt_excel_pres_jef
        '
        Me.txt_excel_pres_jef.Enabled = False
        Me.txt_excel_pres_jef.Location = New System.Drawing.Point(12, 138)
        Me.txt_excel_pres_jef.Name = "txt_excel_pres_jef"
        Me.txt_excel_pres_jef.Size = New System.Drawing.Size(518, 20)
        Me.txt_excel_pres_jef.TabIndex = 79
        '
        'TabPage_ExtractoBan
        '
        Me.TabPage_ExtractoBan.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TabPage_ExtractoBan.Controls.Add(Me.btn_est_bancolombia)
        Me.TabPage_ExtractoBan.Controls.Add(Me.Label33)
        Me.TabPage_ExtractoBan.Controls.Add(Me.Label34)
        Me.TabPage_ExtractoBan.Controls.Add(Me.txt_plano_bancolombia)
        Me.TabPage_ExtractoBan.Controls.Add(Me.Label35)
        Me.TabPage_ExtractoBan.Controls.Add(Me.txt_excel_bancolombia)
        Me.TabPage_ExtractoBan.Controls.Add(Me.btn_excel_bancolombia)
        Me.TabPage_ExtractoBan.Controls.Add(Me.btn_plano_bancolombia)
        Me.TabPage_ExtractoBan.Controls.Add(Me.btn_salir_bancolombia)
        Me.TabPage_ExtractoBan.Controls.Add(Me.btn_generar_bancolombia)
        Me.TabPage_ExtractoBan.Controls.Add(Me.btn_limpiar_bancolombia)
        Me.TabPage_ExtractoBan.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ExtractoBan.Name = "TabPage_ExtractoBan"
        Me.TabPage_ExtractoBan.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_ExtractoBan.TabIndex = 7
        Me.TabPage_ExtractoBan.Text = "Extracto Bancolombia Virtual"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(128, 29)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(424, 26)
        Me.Label33.TabIndex = 104
        Me.Label33.Text = "EXTRACTO BANCOLOMBIA VIRTUAL"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(9, 173)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(95, 17)
        Me.Label34.TabIndex = 98
        Me.Label34.Text = "Archivo Plano"
        '
        'txt_plano_bancolombia
        '
        Me.txt_plano_bancolombia.Enabled = False
        Me.txt_plano_bancolombia.Location = New System.Drawing.Point(12, 206)
        Me.txt_plano_bancolombia.Name = "txt_plano_bancolombia"
        Me.txt_plano_bancolombia.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_bancolombia.TabIndex = 97
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(9, 85)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 17)
        Me.Label35.TabIndex = 96
        Me.Label35.Text = "Archivo de Excel"
        '
        'txt_excel_bancolombia
        '
        Me.txt_excel_bancolombia.Enabled = False
        Me.txt_excel_bancolombia.Location = New System.Drawing.Point(12, 120)
        Me.txt_excel_bancolombia.Name = "txt_excel_bancolombia"
        Me.txt_excel_bancolombia.Size = New System.Drawing.Size(518, 20)
        Me.txt_excel_bancolombia.TabIndex = 95
        '
        'TabPage_ExtractoBog
        '
        Me.TabPage_ExtractoBog.BackColor = System.Drawing.Color.AntiqueWhite
        Me.TabPage_ExtractoBog.Controls.Add(Me.btn_est_bancobogota)
        Me.TabPage_ExtractoBog.Controls.Add(Me.Label25)
        Me.TabPage_ExtractoBog.Controls.Add(Me.Label28)
        Me.TabPage_ExtractoBog.Controls.Add(Me.txt_plano_bogota)
        Me.TabPage_ExtractoBog.Controls.Add(Me.Label36)
        Me.TabPage_ExtractoBog.Controls.Add(Me.txt_excel_bogota)
        Me.TabPage_ExtractoBog.Controls.Add(Me.btn_excel_bogota)
        Me.TabPage_ExtractoBog.Controls.Add(Me.btn_plano_bogota)
        Me.TabPage_ExtractoBog.Controls.Add(Me.btn_salir_bogota)
        Me.TabPage_ExtractoBog.Controls.Add(Me.btn_generar_bogota)
        Me.TabPage_ExtractoBog.Controls.Add(Me.btn_limpiar_bogota)
        Me.TabPage_ExtractoBog.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ExtractoBog.Name = "TabPage_ExtractoBog"
        Me.TabPage_ExtractoBog.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_ExtractoBog.TabIndex = 8
        Me.TabPage_ExtractoBog.Text = "Extracto Banco de Bogota"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(156, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(375, 26)
        Me.Label25.TabIndex = 114
        Me.Label25.Text = "EXTRACTO BANCO DE BOGOTA"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 173)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(95, 17)
        Me.Label28.TabIndex = 108
        Me.Label28.Text = "Archivo Plano"
        '
        'txt_plano_bogota
        '
        Me.txt_plano_bogota.Enabled = False
        Me.txt_plano_bogota.Location = New System.Drawing.Point(12, 206)
        Me.txt_plano_bogota.Name = "txt_plano_bogota"
        Me.txt_plano_bogota.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_bogota.TabIndex = 107
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(9, 85)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(112, 17)
        Me.Label36.TabIndex = 106
        Me.Label36.Text = "Archivo de Excel"
        '
        'txt_excel_bogota
        '
        Me.txt_excel_bogota.Enabled = False
        Me.txt_excel_bogota.Location = New System.Drawing.Point(12, 120)
        Me.txt_excel_bogota.Name = "txt_excel_bogota"
        Me.txt_excel_bogota.Size = New System.Drawing.Size(518, 20)
        Me.txt_excel_bogota.TabIndex = 105
        '
        'TabPage_Items
        '
        Me.TabPage_Items.BackColor = System.Drawing.Color.DarkKhaki
        Me.TabPage_Items.Controls.Add(Me.btn_est_items)
        Me.TabPage_Items.Controls.Add(Me.Label38)
        Me.TabPage_Items.Controls.Add(Me.Label39)
        Me.TabPage_Items.Controls.Add(Me.txt_plano_items)
        Me.TabPage_Items.Controls.Add(Me.Label40)
        Me.TabPage_Items.Controls.Add(Me.txt_csv_items)
        Me.TabPage_Items.Controls.Add(Me.btn_csv_items)
        Me.TabPage_Items.Controls.Add(Me.btn_plano_items)
        Me.TabPage_Items.Controls.Add(Me.btn_salir_items)
        Me.TabPage_Items.Controls.Add(Me.btn_generar_items)
        Me.TabPage_Items.Controls.Add(Me.btn_limpiar_items)
        Me.TabPage_Items.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Items.Name = "TabPage_Items"
        Me.TabPage_Items.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Items.TabIndex = 9
        Me.TabPage_Items.Text = "Items"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(267, 25)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(170, 26)
        Me.Label38.TabIndex = 126
        Me.Label38.Text = "PLANO ITEMS"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(9, 173)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(95, 17)
        Me.Label39.TabIndex = 120
        Me.Label39.Text = "Archivo Plano"
        '
        'txt_plano_items
        '
        Me.txt_plano_items.Enabled = False
        Me.txt_plano_items.Location = New System.Drawing.Point(12, 206)
        Me.txt_plano_items.Name = "txt_plano_items"
        Me.txt_plano_items.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_items.TabIndex = 119
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(9, 85)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(112, 17)
        Me.Label40.TabIndex = 118
        Me.Label40.Text = "Archivo de Excel"
        '
        'txt_csv_items
        '
        Me.txt_csv_items.Enabled = False
        Me.txt_csv_items.Location = New System.Drawing.Point(12, 120)
        Me.txt_csv_items.Name = "txt_csv_items"
        Me.txt_csv_items.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_items.TabIndex = 117
        '
        'TabPage_act_items
        '
        Me.TabPage_act_items.BackColor = System.Drawing.Color.DarkKhaki
        Me.TabPage_act_items.Controls.Add(Me.btn_est_act_items)
        Me.TabPage_act_items.Controls.Add(Me.Label77)
        Me.TabPage_act_items.Controls.Add(Me.Label78)
        Me.TabPage_act_items.Controls.Add(Me.txt_plano_act_items)
        Me.TabPage_act_items.Controls.Add(Me.Label79)
        Me.TabPage_act_items.Controls.Add(Me.txt_csv_act_items)
        Me.TabPage_act_items.Controls.Add(Me.btn_csv_act_items)
        Me.TabPage_act_items.Controls.Add(Me.btn_plano_act_items)
        Me.TabPage_act_items.Controls.Add(Me.btn_salir_act_items)
        Me.TabPage_act_items.Controls.Add(Me.btn_generar_act_items)
        Me.TabPage_act_items.Controls.Add(Me.btn_limpiar_act_items)
        Me.TabPage_act_items.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_act_items.Name = "TabPage_act_items"
        Me.TabPage_act_items.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_act_items.TabIndex = 16
        Me.TabPage_act_items.Text = "Actualiza Items"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(155, 27)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(405, 26)
        Me.Label77.TabIndex = 137
        Me.Label77.Text = "PLANO ACTUALIZACION DE ITEMS"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(9, 175)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(95, 17)
        Me.Label78.TabIndex = 131
        Me.Label78.Text = "Archivo Plano"
        '
        'txt_plano_act_items
        '
        Me.txt_plano_act_items.Enabled = False
        Me.txt_plano_act_items.Location = New System.Drawing.Point(12, 208)
        Me.txt_plano_act_items.Name = "txt_plano_act_items"
        Me.txt_plano_act_items.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_act_items.TabIndex = 130
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(9, 87)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(112, 17)
        Me.Label79.TabIndex = 129
        Me.Label79.Text = "Archivo de Excel"
        '
        'txt_csv_act_items
        '
        Me.txt_csv_act_items.Enabled = False
        Me.txt_csv_act_items.Location = New System.Drawing.Point(12, 122)
        Me.txt_csv_act_items.Name = "txt_csv_act_items"
        Me.txt_csv_act_items.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_act_items.TabIndex = 128
        '
        'TabPage_Clas_items
        '
        Me.TabPage_Clas_items.BackColor = System.Drawing.Color.DarkKhaki
        Me.TabPage_Clas_items.Controls.Add(Me.btn_est_clasitems)
        Me.TabPage_Clas_items.Controls.Add(Me.Label42)
        Me.TabPage_Clas_items.Controls.Add(Me.Label43)
        Me.TabPage_Clas_items.Controls.Add(Me.txt_plano_clasitems)
        Me.TabPage_Clas_items.Controls.Add(Me.Label44)
        Me.TabPage_Clas_items.Controls.Add(Me.txt_csv_clasitems)
        Me.TabPage_Clas_items.Controls.Add(Me.btn_csv_clasitems)
        Me.TabPage_Clas_items.Controls.Add(Me.btn_plano_clasitems)
        Me.TabPage_Clas_items.Controls.Add(Me.btn_salir_clasitems)
        Me.TabPage_Clas_items.Controls.Add(Me.btn_generar_clasitems)
        Me.TabPage_Clas_items.Controls.Add(Me.btn_limpiar_clasitems)
        Me.TabPage_Clas_items.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Clas_items.Name = "TabPage_Clas_items"
        Me.TabPage_Clas_items.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Clas_items.TabIndex = 10
        Me.TabPage_Clas_items.Text = "Clasificacion de Items"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(140, 25)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(399, 26)
        Me.Label42.TabIndex = 137
        Me.Label42.Text = "PLANO CLASIFICACION DE ITEMS"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(9, 175)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(95, 17)
        Me.Label43.TabIndex = 131
        Me.Label43.Text = "Archivo Plano"
        '
        'txt_plano_clasitems
        '
        Me.txt_plano_clasitems.Enabled = False
        Me.txt_plano_clasitems.Location = New System.Drawing.Point(12, 208)
        Me.txt_plano_clasitems.Name = "txt_plano_clasitems"
        Me.txt_plano_clasitems.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_clasitems.TabIndex = 130
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(9, 87)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(112, 17)
        Me.Label44.TabIndex = 129
        Me.Label44.Text = "Archivo de Excel"
        '
        'txt_csv_clasitems
        '
        Me.txt_csv_clasitems.Enabled = False
        Me.txt_csv_clasitems.Location = New System.Drawing.Point(12, 122)
        Me.txt_csv_clasitems.Name = "txt_csv_clasitems"
        Me.txt_csv_clasitems.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_clasitems.TabIndex = 128
        '
        'TabPage_Sol_Compras
        '
        Me.TabPage_Sol_Compras.BackColor = System.Drawing.Color.Tan
        Me.TabPage_Sol_Compras.Controls.Add(Me.txt_tercero_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label52)
        Me.TabPage_Sol_Compras.Controls.Add(Me.txt_notas_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Dtp_fecha_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label45)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label46)
        Me.TabPage_Sol_Compras.Controls.Add(Me.txt_tip_doc_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label47)
        Me.TabPage_Sol_Compras.Controls.Add(Me.txt_co_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label48)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label49)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label50)
        Me.TabPage_Sol_Compras.Controls.Add(Me.txt_plano_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Label51)
        Me.TabPage_Sol_Compras.Controls.Add(Me.txt_csv_sol_compras)
        Me.TabPage_Sol_Compras.Controls.Add(Me.btn_est_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.btn_csv_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.btn_plano_sol_compra)
        Me.TabPage_Sol_Compras.Controls.Add(Me.btn_salir_sol_compras)
        Me.TabPage_Sol_Compras.Controls.Add(Me.Btn_generar_sol_compras)
        Me.TabPage_Sol_Compras.Controls.Add(Me.btn_limpiar_sol_compra)
        Me.TabPage_Sol_Compras.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Sol_Compras.Name = "TabPage_Sol_Compras"
        Me.TabPage_Sol_Compras.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Sol_Compras.TabIndex = 11
        Me.TabPage_Sol_Compras.Text = "Solicitudes de Compra"
        '
        'txt_tercero_sol_compra
        '
        Me.txt_tercero_sol_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tercero_sol_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tercero_sol_compra.Location = New System.Drawing.Point(546, 107)
        Me.txt_tercero_sol_compra.MaxLength = 15
        Me.txt_tercero_sol_compra.Name = "txt_tercero_sol_compra"
        Me.txt_tercero_sol_compra.Size = New System.Drawing.Size(137, 26)
        Me.txt_tercero_sol_compra.TabIndex = 89
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(482, 113)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(58, 17)
        Me.Label52.TabIndex = 88
        Me.Label52.Text = "Tercero"
        '
        'txt_notas_sol_compra
        '
        Me.txt_notas_sol_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas_sol_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_sol_compra.Location = New System.Drawing.Point(56, 101)
        Me.txt_notas_sol_compra.MaxLength = 255
        Me.txt_notas_sol_compra.Multiline = True
        Me.txt_notas_sol_compra.Name = "txt_notas_sol_compra"
        Me.txt_notas_sol_compra.Size = New System.Drawing.Size(420, 65)
        Me.txt_notas_sol_compra.TabIndex = 86
        '
        'Dtp_fecha_sol_compra
        '
        Me.Dtp_fecha_sol_compra.Location = New System.Drawing.Point(482, 73)
        Me.Dtp_fecha_sol_compra.Name = "Dtp_fecha_sol_compra"
        Me.Dtp_fecha_sol_compra.Size = New System.Drawing.Size(201, 20)
        Me.Dtp_fecha_sol_compra.TabIndex = 85
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(9, 113)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(45, 17)
        Me.Label45.TabIndex = 84
        Me.Label45.Text = "Notas"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(353, 75)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(123, 17)
        Me.Label46.TabIndex = 83
        Me.Label46.Text = "Fecha Documento"
        '
        'txt_tip_doc_sol_compra
        '
        Me.txt_tip_doc_sol_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tip_doc_sol_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_doc_sol_compra.Location = New System.Drawing.Point(306, 69)
        Me.txt_tip_doc_sol_compra.MaxLength = 3
        Me.txt_tip_doc_sol_compra.Name = "txt_tip_doc_sol_compra"
        Me.txt_tip_doc_sol_compra.Size = New System.Drawing.Size(44, 26)
        Me.txt_tip_doc_sol_compra.TabIndex = 82
        Me.txt_tip_doc_sol_compra.Text = "SOC"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(169, 75)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(132, 17)
        Me.Label47.TabIndex = 81
        Me.Label47.Text = "Tipo de Documento"
        '
        'txt_co_sol_compra
        '
        Me.txt_co_sol_compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_co_sol_compra.Location = New System.Drawing.Point(126, 69)
        Me.txt_co_sol_compra.MaxLength = 3
        Me.txt_co_sol_compra.Name = "txt_co_sol_compra"
        Me.txt_co_sol_compra.Size = New System.Drawing.Size(40, 26)
        Me.txt_co_sol_compra.TabIndex = 80
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(9, 75)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(116, 17)
        Me.Label48.TabIndex = 79
        Me.Label48.Text = "Centro Operativo"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(127, 19)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(446, 26)
        Me.Label49.TabIndex = 78
        Me.Label49.Text = "PLANO DE SOLICITUDES DE COMPRA"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(9, 223)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(95, 17)
        Me.Label50.TabIndex = 72
        Me.Label50.Text = "Archivo Plano"
        '
        'txt_plano_sol_compra
        '
        Me.txt_plano_sol_compra.Enabled = False
        Me.txt_plano_sol_compra.Location = New System.Drawing.Point(12, 244)
        Me.txt_plano_sol_compra.Name = "txt_plano_sol_compra"
        Me.txt_plano_sol_compra.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_sol_compra.TabIndex = 71
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(9, 172)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(112, 17)
        Me.Label51.TabIndex = 70
        Me.Label51.Text = "Archivo de Excel"
        '
        'txt_csv_sol_compras
        '
        Me.txt_csv_sol_compras.Enabled = False
        Me.txt_csv_sol_compras.Location = New System.Drawing.Point(12, 193)
        Me.txt_csv_sol_compras.Name = "txt_csv_sol_compras"
        Me.txt_csv_sol_compras.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_sol_compras.TabIndex = 69
        '
        'TabPage_criterios
        '
        Me.TabPage_criterios.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage_criterios.Controls.Add(Me.btn_est_criterios)
        Me.TabPage_criterios.Controls.Add(Me.Label53)
        Me.TabPage_criterios.Controls.Add(Me.Label54)
        Me.TabPage_criterios.Controls.Add(Me.txt_plano_criterios)
        Me.TabPage_criterios.Controls.Add(Me.Label55)
        Me.TabPage_criterios.Controls.Add(Me.txt_csv_criterios)
        Me.TabPage_criterios.Controls.Add(Me.btn_csv_criterios)
        Me.TabPage_criterios.Controls.Add(Me.btn_plano_criterios)
        Me.TabPage_criterios.Controls.Add(Me.btn_salir_criterios)
        Me.TabPage_criterios.Controls.Add(Me.btn_generar_criterios)
        Me.TabPage_criterios.Controls.Add(Me.btn_limipiar_criterios)
        Me.TabPage_criterios.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_criterios.Name = "TabPage_criterios"
        Me.TabPage_criterios.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_criterios.TabIndex = 12
        Me.TabPage_criterios.Text = "Clasificación Activos Fijos"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(92, 26)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(505, 26)
        Me.Label53.TabIndex = 148
        Me.Label53.Text = "PLANO CLASIFICACION DE ACTIVOS FIJOS"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(9, 176)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(95, 17)
        Me.Label54.TabIndex = 142
        Me.Label54.Text = "Archivo Plano"
        '
        'txt_plano_criterios
        '
        Me.txt_plano_criterios.Enabled = False
        Me.txt_plano_criterios.Location = New System.Drawing.Point(12, 209)
        Me.txt_plano_criterios.Name = "txt_plano_criterios"
        Me.txt_plano_criterios.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_criterios.TabIndex = 141
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(9, 88)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(112, 17)
        Me.Label55.TabIndex = 140
        Me.Label55.Text = "Archivo de Excel"
        '
        'txt_csv_criterios
        '
        Me.txt_csv_criterios.Enabled = False
        Me.txt_csv_criterios.Location = New System.Drawing.Point(12, 123)
        Me.txt_csv_criterios.Name = "txt_csv_criterios"
        Me.txt_csv_criterios.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_criterios.TabIndex = 139
        '
        'TabPage_Bajas
        '
        Me.TabPage_Bajas.BackColor = System.Drawing.Color.LightSalmon
        Me.TabPage_Bajas.Controls.Add(Me.Label63)
        Me.TabPage_Bajas.Controls.Add(Me.txt_notas_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.Dtp_fecha_doc_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.Label57)
        Me.TabPage_Bajas.Controls.Add(Me.Label58)
        Me.TabPage_Bajas.Controls.Add(Me.txt_tip_doc_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.Label59)
        Me.TabPage_Bajas.Controls.Add(Me.txt_co_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.Label60)
        Me.TabPage_Bajas.Controls.Add(Me.Label61)
        Me.TabPage_Bajas.Controls.Add(Me.txt_plano_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.Label62)
        Me.TabPage_Bajas.Controls.Add(Me.txt_csv_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.btn_est_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.btn_csv_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.btn_planos_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.btn_salir_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.btn_generar_bajas)
        Me.TabPage_Bajas.Controls.Add(Me.btn_limpiar_bajas)
        Me.TabPage_Bajas.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Bajas.Name = "TabPage_Bajas"
        Me.TabPage_Bajas.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Bajas.TabIndex = 13
        Me.TabPage_Bajas.Text = "Bajas de Activos Fijos"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(122, 26)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(439, 26)
        Me.Label63.TabIndex = 149
        Me.Label63.Text = "PLANO DE BAJAS DE ACTIVOS FIJOS"
        '
        'txt_notas_bajas
        '
        Me.txt_notas_bajas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas_bajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_bajas.Location = New System.Drawing.Point(55, 102)
        Me.txt_notas_bajas.MaxLength = 255
        Me.txt_notas_bajas.Multiline = True
        Me.txt_notas_bajas.Name = "txt_notas_bajas"
        Me.txt_notas_bajas.Size = New System.Drawing.Size(627, 52)
        Me.txt_notas_bajas.TabIndex = 106
        '
        'Dtp_fecha_doc_bajas
        '
        Me.Dtp_fecha_doc_bajas.Location = New System.Drawing.Point(481, 74)
        Me.Dtp_fecha_doc_bajas.Name = "Dtp_fecha_doc_bajas"
        Me.Dtp_fecha_doc_bajas.Size = New System.Drawing.Size(201, 20)
        Me.Dtp_fecha_doc_bajas.TabIndex = 105
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(8, 114)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(45, 17)
        Me.Label57.TabIndex = 104
        Me.Label57.Text = "Notas"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(352, 76)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(123, 17)
        Me.Label58.TabIndex = 103
        Me.Label58.Text = "Fecha Documento"
        '
        'txt_tip_doc_bajas
        '
        Me.txt_tip_doc_bajas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tip_doc_bajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_doc_bajas.Location = New System.Drawing.Point(305, 70)
        Me.txt_tip_doc_bajas.MaxLength = 3
        Me.txt_tip_doc_bajas.Name = "txt_tip_doc_bajas"
        Me.txt_tip_doc_bajas.Size = New System.Drawing.Size(44, 26)
        Me.txt_tip_doc_bajas.TabIndex = 102
        Me.txt_tip_doc_bajas.Text = "AFB"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(168, 76)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(132, 17)
        Me.Label59.TabIndex = 101
        Me.Label59.Text = "Tipo de Documento"
        '
        'txt_co_bajas
        '
        Me.txt_co_bajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_co_bajas.Location = New System.Drawing.Point(125, 70)
        Me.txt_co_bajas.MaxLength = 3
        Me.txt_co_bajas.Name = "txt_co_bajas"
        Me.txt_co_bajas.Size = New System.Drawing.Size(40, 26)
        Me.txt_co_bajas.TabIndex = 100
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(8, 76)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(116, 17)
        Me.Label60.TabIndex = 99
        Me.Label60.Text = "Centro Operativo"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(8, 216)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(95, 17)
        Me.Label61.TabIndex = 93
        Me.Label61.Text = "Archivo Plano"
        '
        'txt_plano_bajas
        '
        Me.txt_plano_bajas.Enabled = False
        Me.txt_plano_bajas.Location = New System.Drawing.Point(11, 237)
        Me.txt_plano_bajas.Name = "txt_plano_bajas"
        Me.txt_plano_bajas.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_bajas.TabIndex = 92
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(8, 165)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(112, 17)
        Me.Label62.TabIndex = 91
        Me.Label62.Text = "Archivo de Excel"
        '
        'txt_csv_bajas
        '
        Me.txt_csv_bajas.Enabled = False
        Me.txt_csv_bajas.Location = New System.Drawing.Point(11, 186)
        Me.txt_csv_bajas.Name = "txt_csv_bajas"
        Me.txt_csv_bajas.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_bajas.TabIndex = 90
        '
        'TabPage_cuentasxpagar
        '
        Me.TabPage_cuentasxpagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TabPage_cuentasxpagar.Controls.Add(Me.btn_est_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Label65)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.txt_notas_cuenta)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Dtp_fecha_doc_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Label66)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.txt_tip_doc_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Label67)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.txt_co_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Label68)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Label69)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Label70)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.txt_plano_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.Label71)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.txt_csv_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.btn_csv_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.btn_plano_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.btn_salir_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.btn_generar_cuentas)
        Me.TabPage_cuentasxpagar.Controls.Add(Me.btn_limpiar_cuentas)
        Me.TabPage_cuentasxpagar.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_cuentasxpagar.Name = "TabPage_cuentasxpagar"
        Me.TabPage_cuentasxpagar.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_cuentasxpagar.TabIndex = 14
        Me.TabPage_cuentasxpagar.Text = "Cuentas x Pagar"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(9, 104)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(45, 17)
        Me.Label65.TabIndex = 83
        Me.Label65.Text = "Notas"
        '
        'txt_notas_cuenta
        '
        Me.txt_notas_cuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas_cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_cuenta.Location = New System.Drawing.Point(56, 104)
        Me.txt_notas_cuenta.MaxLength = 255
        Me.txt_notas_cuenta.Multiline = True
        Me.txt_notas_cuenta.Name = "txt_notas_cuenta"
        Me.txt_notas_cuenta.Size = New System.Drawing.Size(627, 39)
        Me.txt_notas_cuenta.TabIndex = 82
        '
        'Dtp_fecha_doc_cuentas
        '
        Me.Dtp_fecha_doc_cuentas.Location = New System.Drawing.Point(482, 69)
        Me.Dtp_fecha_doc_cuentas.Name = "Dtp_fecha_doc_cuentas"
        Me.Dtp_fecha_doc_cuentas.Size = New System.Drawing.Size(201, 20)
        Me.Dtp_fecha_doc_cuentas.TabIndex = 81
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(353, 71)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(123, 17)
        Me.Label66.TabIndex = 80
        Me.Label66.Text = "Fecha Documento"
        '
        'txt_tip_doc_cuentas
        '
        Me.txt_tip_doc_cuentas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tip_doc_cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_doc_cuentas.Location = New System.Drawing.Point(306, 65)
        Me.txt_tip_doc_cuentas.MaxLength = 3
        Me.txt_tip_doc_cuentas.Name = "txt_tip_doc_cuentas"
        Me.txt_tip_doc_cuentas.Size = New System.Drawing.Size(44, 26)
        Me.txt_tip_doc_cuentas.TabIndex = 79
        Me.txt_tip_doc_cuentas.Text = "NIF"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(169, 71)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(132, 17)
        Me.Label67.TabIndex = 78
        Me.Label67.Text = "Tipo de Documento"
        '
        'txt_co_cuentas
        '
        Me.txt_co_cuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_co_cuentas.Location = New System.Drawing.Point(126, 65)
        Me.txt_co_cuentas.MaxLength = 3
        Me.txt_co_cuentas.Name = "txt_co_cuentas"
        Me.txt_co_cuentas.Size = New System.Drawing.Size(40, 26)
        Me.txt_co_cuentas.TabIndex = 77
        Me.txt_co_cuentas.Text = "190"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(9, 71)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(116, 17)
        Me.Label68.TabIndex = 76
        Me.Label68.Text = "Centro Operativo"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(165, 13)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(364, 26)
        Me.Label69.TabIndex = 75
        Me.Label69.Text = "PLANO DE CUENTAS X PAGAR"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(9, 197)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(95, 17)
        Me.Label70.TabIndex = 69
        Me.Label70.Text = "Archivo Plano"
        '
        'txt_plano_cuentas
        '
        Me.txt_plano_cuentas.Enabled = False
        Me.txt_plano_cuentas.Location = New System.Drawing.Point(12, 218)
        Me.txt_plano_cuentas.Name = "txt_plano_cuentas"
        Me.txt_plano_cuentas.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_cuentas.TabIndex = 68
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(9, 146)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(112, 17)
        Me.Label71.TabIndex = 67
        Me.Label71.Text = "Archivo de Excel"
        '
        'txt_csv_cuentas
        '
        Me.txt_csv_cuentas.Enabled = False
        Me.txt_csv_cuentas.Location = New System.Drawing.Point(12, 167)
        Me.txt_csv_cuentas.Name = "txt_csv_cuentas"
        Me.txt_csv_cuentas.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_cuentas.TabIndex = 66
        '
        'TabPage_Traslados_AF
        '
        Me.TabPage_Traslados_AF.BackColor = System.Drawing.Color.Thistle
        Me.TabPage_Traslados_AF.Controls.Add(Me.btn_est_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Label56)
        Me.TabPage_Traslados_AF.Controls.Add(Me.txt_notas_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Dtp_fechadoc_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Label64)
        Me.TabPage_Traslados_AF.Controls.Add(Me.txt_tipdoc_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Label72)
        Me.TabPage_Traslados_AF.Controls.Add(Me.txt_co_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Label73)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Label74)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Label75)
        Me.TabPage_Traslados_AF.Controls.Add(Me.txt_plano_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.Label76)
        Me.TabPage_Traslados_AF.Controls.Add(Me.txt_csv_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.btn_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.btn_plano_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.btn_salir_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.btn_generar_traslados)
        Me.TabPage_Traslados_AF.Controls.Add(Me.btn_limpiar_traslados)
        Me.TabPage_Traslados_AF.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Traslados_AF.Name = "TabPage_Traslados_AF"
        Me.TabPage_Traslados_AF.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Traslados_AF.TabIndex = 15
        Me.TabPage_Traslados_AF.Text = "Traslados Activos Fijos"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(9, 113)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(45, 17)
        Me.Label56.TabIndex = 106
        Me.Label56.Text = "Notas"
        '
        'txt_notas_traslados
        '
        Me.txt_notas_traslados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas_traslados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_traslados.Location = New System.Drawing.Point(56, 113)
        Me.txt_notas_traslados.MaxLength = 255
        Me.txt_notas_traslados.Multiline = True
        Me.txt_notas_traslados.Name = "txt_notas_traslados"
        Me.txt_notas_traslados.Size = New System.Drawing.Size(627, 39)
        Me.txt_notas_traslados.TabIndex = 105
        '
        'Dtp_fechadoc_traslados
        '
        Me.Dtp_fechadoc_traslados.Location = New System.Drawing.Point(482, 78)
        Me.Dtp_fechadoc_traslados.Name = "Dtp_fechadoc_traslados"
        Me.Dtp_fechadoc_traslados.Size = New System.Drawing.Size(201, 20)
        Me.Dtp_fechadoc_traslados.TabIndex = 104
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(353, 80)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(123, 17)
        Me.Label64.TabIndex = 103
        Me.Label64.Text = "Fecha Documento"
        '
        'txt_tipdoc_traslados
        '
        Me.txt_tipdoc_traslados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tipdoc_traslados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tipdoc_traslados.Location = New System.Drawing.Point(306, 74)
        Me.txt_tipdoc_traslados.MaxLength = 3
        Me.txt_tipdoc_traslados.Name = "txt_tipdoc_traslados"
        Me.txt_tipdoc_traslados.Size = New System.Drawing.Size(44, 26)
        Me.txt_tipdoc_traslados.TabIndex = 102
        Me.txt_tipdoc_traslados.Text = "AFT"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(169, 80)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(132, 17)
        Me.Label72.TabIndex = 101
        Me.Label72.Text = "Tipo de Documento"
        '
        'txt_co_traslados
        '
        Me.txt_co_traslados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_co_traslados.Location = New System.Drawing.Point(126, 74)
        Me.txt_co_traslados.MaxLength = 3
        Me.txt_co_traslados.Name = "txt_co_traslados"
        Me.txt_co_traslados.Size = New System.Drawing.Size(40, 26)
        Me.txt_co_traslados.TabIndex = 100
        Me.txt_co_traslados.Text = "190"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(9, 80)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(116, 17)
        Me.Label73.TabIndex = 99
        Me.Label73.Text = "Centro Operativo"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(96, 24)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(505, 26)
        Me.Label74.TabIndex = 98
        Me.Label74.Text = "PLANO DE TRASLADOS DE ACTIVOS FIJOS"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(9, 206)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(95, 17)
        Me.Label75.TabIndex = 92
        Me.Label75.Text = "Archivo Plano"
        '
        'txt_plano_traslados
        '
        Me.txt_plano_traslados.Enabled = False
        Me.txt_plano_traslados.Location = New System.Drawing.Point(12, 227)
        Me.txt_plano_traslados.Name = "txt_plano_traslados"
        Me.txt_plano_traslados.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_traslados.TabIndex = 91
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(9, 155)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(112, 17)
        Me.Label76.TabIndex = 90
        Me.Label76.Text = "Archivo de Excel"
        '
        'txt_csv_traslados
        '
        Me.txt_csv_traslados.Enabled = False
        Me.txt_csv_traslados.Location = New System.Drawing.Point(12, 176)
        Me.txt_csv_traslados.Name = "txt_csv_traslados"
        Me.txt_csv_traslados.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_traslados.TabIndex = 89
        '
        'TabPage_Codigo_barras
        '
        Me.TabPage_Codigo_barras.Controls.Add(Me.btn_est_codigobarras)
        Me.TabPage_Codigo_barras.Controls.Add(Me.Label80)
        Me.TabPage_Codigo_barras.Controls.Add(Me.Label81)
        Me.TabPage_Codigo_barras.Controls.Add(Me.txt_planocodigobarras)
        Me.TabPage_Codigo_barras.Controls.Add(Me.Label82)
        Me.TabPage_Codigo_barras.Controls.Add(Me.txt_codigobarras)
        Me.TabPage_Codigo_barras.Controls.Add(Me.btn_codigobarras)
        Me.TabPage_Codigo_barras.Controls.Add(Me.btn_planocodigobarras)
        Me.TabPage_Codigo_barras.Controls.Add(Me.btn_salircodigobarras)
        Me.TabPage_Codigo_barras.Controls.Add(Me.btn_generarcodigobarras)
        Me.TabPage_Codigo_barras.Controls.Add(Me.btn_limpiarcodigobarras)
        Me.TabPage_Codigo_barras.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Codigo_barras.Name = "TabPage_Codigo_barras"
        Me.TabPage_Codigo_barras.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Codigo_barras.TabIndex = 17
        Me.TabPage_Codigo_barras.Text = "Codigo de Barras"
        Me.TabPage_Codigo_barras.UseVisualStyleBackColor = True
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(163, 24)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(339, 26)
        Me.Label80.TabIndex = 137
        Me.Label80.Text = "PLANO CODIGO DE BARRAS"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(9, 175)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(95, 17)
        Me.Label81.TabIndex = 131
        Me.Label81.Text = "Archivo Plano"
        '
        'txt_planocodigobarras
        '
        Me.txt_planocodigobarras.Enabled = False
        Me.txt_planocodigobarras.Location = New System.Drawing.Point(12, 208)
        Me.txt_planocodigobarras.Name = "txt_planocodigobarras"
        Me.txt_planocodigobarras.Size = New System.Drawing.Size(518, 20)
        Me.txt_planocodigobarras.TabIndex = 130
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(9, 87)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(112, 17)
        Me.Label82.TabIndex = 129
        Me.Label82.Text = "Archivo de Excel"
        '
        'txt_codigobarras
        '
        Me.txt_codigobarras.Enabled = False
        Me.txt_codigobarras.Location = New System.Drawing.Point(12, 122)
        Me.txt_codigobarras.Name = "txt_codigobarras"
        Me.txt_codigobarras.Size = New System.Drawing.Size(518, 20)
        Me.txt_codigobarras.TabIndex = 128
        '
        'TabPage_Mov_Inventarios
        '
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_doc_alterno_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label94)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_bodega_entrada_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label93)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_bodega_salida_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label92)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_id_con_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label91)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_clase_doc_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label90)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label83)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_notas_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Dtp_fechadoc_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label84)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_tip_doc_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label85)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_co_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label86)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label87)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label88)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_plano_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.Label89)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.txt_csv_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.btn_est_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.btn_csv_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.btn_plano_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.btn_salir_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.btn_generar_inv)
        Me.TabPage_Mov_Inventarios.Controls.Add(Me.btn_limpiar_inv)
        Me.TabPage_Mov_Inventarios.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Mov_Inventarios.Name = "TabPage_Mov_Inventarios"
        Me.TabPage_Mov_Inventarios.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Mov_Inventarios.TabIndex = 18
        Me.TabPage_Mov_Inventarios.Text = "Movimiento de Inventarios"
        Me.TabPage_Mov_Inventarios.UseVisualStyleBackColor = True
        '
        'txt_doc_alterno_inv
        '
        Me.txt_doc_alterno_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_doc_alterno_inv.Location = New System.Drawing.Point(12, 162)
        Me.txt_doc_alterno_inv.MaxLength = 15
        Me.txt_doc_alterno_inv.Name = "txt_doc_alterno_inv"
        Me.txt_doc_alterno_inv.Size = New System.Drawing.Size(154, 26)
        Me.txt_doc_alterno_inv.TabIndex = 136
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(25, 142)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(129, 17)
        Me.Label94.TabIndex = 135
        Me.Label94.Text = "Documento Alterno"
        '
        'txt_bodega_entrada_inv
        '
        Me.txt_bodega_entrada_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bodega_entrada_inv.Location = New System.Drawing.Point(418, 102)
        Me.txt_bodega_entrada_inv.MaxLength = 5
        Me.txt_bodega_entrada_inv.Name = "txt_bodega_entrada_inv"
        Me.txt_bodega_entrada_inv.Size = New System.Drawing.Size(55, 26)
        Me.txt_bodega_entrada_inv.TabIndex = 134
        Me.txt_bodega_entrada_inv.Text = "23202"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(479, 108)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(111, 17)
        Me.Label93.TabIndex = 133
        Me.Label93.Text = "Bodega Entrada"
        '
        'txt_bodega_salida_inv
        '
        Me.txt_bodega_salida_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bodega_salida_inv.Location = New System.Drawing.Point(596, 102)
        Me.txt_bodega_salida_inv.MaxLength = 5
        Me.txt_bodega_salida_inv.Name = "txt_bodega_salida_inv"
        Me.txt_bodega_salida_inv.Size = New System.Drawing.Size(54, 26)
        Me.txt_bodega_salida_inv.TabIndex = 132
        Me.txt_bodega_salida_inv.Text = "23201"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(316, 108)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(100, 17)
        Me.Label92.TabIndex = 131
        Me.Label92.Text = "Bodega Salida"
        '
        'txt_id_con_inv
        '
        Me.txt_id_con_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_con_inv.Location = New System.Drawing.Point(261, 102)
        Me.txt_id_con_inv.MaxLength = 3
        Me.txt_id_con_inv.Name = "txt_id_con_inv"
        Me.txt_id_con_inv.Size = New System.Drawing.Size(40, 26)
        Me.txt_id_con_inv.TabIndex = 130
        Me.txt_id_con_inv.Text = "607"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(172, 108)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(83, 17)
        Me.Label91.TabIndex = 129
        Me.Label91.Text = "Id Concepto"
        '
        'txt_clase_doc_inv
        '
        Me.txt_clase_doc_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clase_doc_inv.Location = New System.Drawing.Point(126, 102)
        Me.txt_clase_doc_inv.MaxLength = 2
        Me.txt_clase_doc_inv.Name = "txt_clase_doc_inv"
        Me.txt_clase_doc_inv.Size = New System.Drawing.Size(40, 26)
        Me.txt_clase_doc_inv.TabIndex = 128
        Me.txt_clase_doc_inv.Text = "67"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(9, 108)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(119, 17)
        Me.Label90.TabIndex = 127
        Me.Label90.Text = "Clase Documento"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(181, 142)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(45, 17)
        Me.Label83.TabIndex = 125
        Me.Label83.Text = "Notas"
        '
        'txt_notas_inv
        '
        Me.txt_notas_inv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_notas_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_notas_inv.Location = New System.Drawing.Point(232, 139)
        Me.txt_notas_inv.MaxLength = 255
        Me.txt_notas_inv.Multiline = True
        Me.txt_notas_inv.Name = "txt_notas_inv"
        Me.txt_notas_inv.Size = New System.Drawing.Size(451, 59)
        Me.txt_notas_inv.TabIndex = 124
        '
        'Dtp_fechadoc_inv
        '
        Me.Dtp_fechadoc_inv.Location = New System.Drawing.Point(482, 70)
        Me.Dtp_fechadoc_inv.Name = "Dtp_fechadoc_inv"
        Me.Dtp_fechadoc_inv.Size = New System.Drawing.Size(201, 20)
        Me.Dtp_fechadoc_inv.TabIndex = 123
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(353, 72)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(123, 17)
        Me.Label84.TabIndex = 122
        Me.Label84.Text = "Fecha Documento"
        '
        'txt_tip_doc_inv
        '
        Me.txt_tip_doc_inv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_tip_doc_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tip_doc_inv.Location = New System.Drawing.Point(306, 66)
        Me.txt_tip_doc_inv.MaxLength = 3
        Me.txt_tip_doc_inv.Name = "txt_tip_doc_inv"
        Me.txt_tip_doc_inv.Size = New System.Drawing.Size(44, 26)
        Me.txt_tip_doc_inv.TabIndex = 121
        Me.txt_tip_doc_inv.Text = "TRA"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(169, 72)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(132, 17)
        Me.Label85.TabIndex = 120
        Me.Label85.Text = "Tipo de Documento"
        '
        'txt_co_inv
        '
        Me.txt_co_inv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_co_inv.Location = New System.Drawing.Point(126, 66)
        Me.txt_co_inv.MaxLength = 3
        Me.txt_co_inv.Name = "txt_co_inv"
        Me.txt_co_inv.Size = New System.Drawing.Size(40, 26)
        Me.txt_co_inv.TabIndex = 119
        Me.txt_co_inv.Text = "232"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(9, 72)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(116, 17)
        Me.Label86.TabIndex = 118
        Me.Label86.Text = "Centro Operativo"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(170, 23)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(299, 26)
        Me.Label87.TabIndex = 117
        Me.Label87.Text = "PLANO DE INVENTARIOS"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(9, 242)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(95, 17)
        Me.Label88.TabIndex = 111
        Me.Label88.Text = "Archivo Plano"
        '
        'txt_plano_inv
        '
        Me.txt_plano_inv.Enabled = False
        Me.txt_plano_inv.Location = New System.Drawing.Point(12, 263)
        Me.txt_plano_inv.Name = "txt_plano_inv"
        Me.txt_plano_inv.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_inv.TabIndex = 110
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(9, 191)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(112, 17)
        Me.Label89.TabIndex = 109
        Me.Label89.Text = "Archivo de Excel"
        '
        'txt_csv_inv
        '
        Me.txt_csv_inv.Enabled = False
        Me.txt_csv_inv.Location = New System.Drawing.Point(12, 212)
        Me.txt_csv_inv.Name = "txt_csv_inv"
        Me.txt_csv_inv.Size = New System.Drawing.Size(518, 20)
        Me.txt_csv_inv.TabIndex = 108
        '
        'TabPage_Entidades_Proveedores
        '
        Me.TabPage_Entidades_Proveedores.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.csv_est_entidades_proveedores)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.Label95)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.Label96)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.txt_plano_proveedores)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.Label97)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.txt_proveedores)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.btn_seleccionar_proveedor_csv)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.btn_generar_plano_proveedor)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.btn_salir_entidades_proveedores)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.btn_generar_entidades_proveedores)
        Me.TabPage_Entidades_Proveedores.Controls.Add(Me.btn_limpiar_entidades_proveedores)
        Me.TabPage_Entidades_Proveedores.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Entidades_Proveedores.Name = "TabPage_Entidades_Proveedores"
        Me.TabPage_Entidades_Proveedores.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Entidades_Proveedores.TabIndex = 19
        Me.TabPage_Entidades_Proveedores.Text = "Entidades de Proveedores"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(143, 38)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(424, 26)
        Me.Label95.TabIndex = 148
        Me.Label95.Text = "PLANO ENTIDADES PROVEEDORES"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(9, 177)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(95, 17)
        Me.Label96.TabIndex = 142
        Me.Label96.Text = "Archivo Plano"
        '
        'txt_plano_proveedores
        '
        Me.txt_plano_proveedores.Enabled = False
        Me.txt_plano_proveedores.Location = New System.Drawing.Point(12, 210)
        Me.txt_plano_proveedores.Name = "txt_plano_proveedores"
        Me.txt_plano_proveedores.Size = New System.Drawing.Size(518, 20)
        Me.txt_plano_proveedores.TabIndex = 141
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(9, 89)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(112, 17)
        Me.Label97.TabIndex = 140
        Me.Label97.Text = "Archivo de Excel"
        '
        'txt_proveedores
        '
        Me.txt_proveedores.Enabled = False
        Me.txt_proveedores.Location = New System.Drawing.Point(12, 124)
        Me.txt_proveedores.Name = "txt_proveedores"
        Me.txt_proveedores.Size = New System.Drawing.Size(518, 20)
        Me.txt_proveedores.TabIndex = 139
        '
        'TabPage_Entidades_Clientes
        '
        Me.TabPage_Entidades_Clientes.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.xls_est_entidades_clientes)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.Label110)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.Label111)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.txt_clientesPlano)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.Label112)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.txt_clientesXLS)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.btn_clientesXLS)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.btn_cleintesPlano)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.btn_salirentcli)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.btn_generar_entidades_clientes)
        Me.TabPage_Entidades_Clientes.Controls.Add(Me.btn_limpiar_entidades_clientes)
        Me.TabPage_Entidades_Clientes.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Entidades_Clientes.Name = "TabPage_Entidades_Clientes"
        Me.TabPage_Entidades_Clientes.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Entidades_Clientes.TabIndex = 23
        Me.TabPage_Entidades_Clientes.Text = "Entidades de Clientes"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(168, 32)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(356, 26)
        Me.Label110.TabIndex = 159
        Me.Label110.Text = "PLANO ENTIDADES CLIENTES"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.Location = New System.Drawing.Point(9, 171)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(95, 17)
        Me.Label111.TabIndex = 153
        Me.Label111.Text = "Archivo Plano"
        '
        'txt_clientesPlano
        '
        Me.txt_clientesPlano.Enabled = False
        Me.txt_clientesPlano.Location = New System.Drawing.Point(12, 204)
        Me.txt_clientesPlano.Name = "txt_clientesPlano"
        Me.txt_clientesPlano.Size = New System.Drawing.Size(518, 20)
        Me.txt_clientesPlano.TabIndex = 152
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(9, 83)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(112, 17)
        Me.Label112.TabIndex = 151
        Me.Label112.Text = "Archivo de Excel"
        '
        'txt_clientesXLS
        '
        Me.txt_clientesXLS.Enabled = False
        Me.txt_clientesXLS.Location = New System.Drawing.Point(12, 118)
        Me.txt_clientesXLS.Name = "txt_clientesXLS"
        Me.txt_clientesXLS.Size = New System.Drawing.Size(518, 20)
        Me.txt_clientesXLS.TabIndex = 150
        '
        'TabPage_Cambio_Estado_Activos_Fijos
        '
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.GroupBox2)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.GroupBox1)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.Label98)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.Label99)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.txtExcelCambioEstadoActFijos)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.btnCargueEstadoActivosFijos)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.Button2)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.btnGenerarCambioEstadoActivosFijos)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Controls.Add(Me.Button4)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Name = "TabPage_Cambio_Estado_Activos_Fijos"
        Me.TabPage_Cambio_Estado_Activos_Fijos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Cambio_Estado_Activos_Fijos.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Cambio_Estado_Activos_Fijos.TabIndex = 20
        Me.TabPage_Cambio_Estado_Activos_Fijos.Text = "Cambio Estado Activos Fijos"
        Me.TabPage_Cambio_Estado_Activos_Fijos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbActivar)
        Me.GroupBox2.Controls.Add(Me.rbSuspender)
        Me.GroupBox2.Location = New System.Drawing.Point(338, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 64)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACTUALIZACION DE ESTADO"
        '
        'rbActivar
        '
        Me.rbActivar.AutoSize = True
        Me.rbActivar.Location = New System.Drawing.Point(133, 30)
        Me.rbActivar.Name = "rbActivar"
        Me.rbActivar.Size = New System.Drawing.Size(71, 17)
        Me.rbActivar.TabIndex = 1
        Me.rbActivar.TabStop = True
        Me.rbActivar.Text = "ACTIVAR"
        Me.rbActivar.UseVisualStyleBackColor = True
        '
        'rbSuspender
        '
        Me.rbSuspender.AutoSize = True
        Me.rbSuspender.Location = New System.Drawing.Point(18, 30)
        Me.rbSuspender.Name = "rbSuspender"
        Me.rbSuspender.Size = New System.Drawing.Size(92, 17)
        Me.rbSuspender.TabIndex = 0
        Me.rbSuspender.TabStop = True
        Me.rbSuspender.Text = "SUSPENDER"
        Me.rbSuspender.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbniif)
        Me.GroupBox1.Controls.Add(Me.cbpcga)
        Me.GroupBox1.Location = New System.Drawing.Point(110, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 64)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LIBROS A ACTUALIZAR"
        '
        'cbniif
        '
        Me.cbniif.AutoSize = True
        Me.cbniif.Location = New System.Drawing.Point(118, 31)
        Me.cbniif.Name = "cbniif"
        Me.cbniif.Size = New System.Drawing.Size(46, 17)
        Me.cbniif.TabIndex = 1
        Me.cbniif.Text = "NIIF"
        Me.cbniif.UseVisualStyleBackColor = True
        '
        'cbpcga
        '
        Me.cbpcga.AutoSize = True
        Me.cbpcga.Location = New System.Drawing.Point(14, 31)
        Me.cbpcga.Name = "cbpcga"
        Me.cbpcga.Size = New System.Drawing.Size(55, 17)
        Me.cbpcga.TabIndex = 0
        Me.cbpcga.Text = "PCGA"
        Me.cbpcga.UseVisualStyleBackColor = True
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(170, 20)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(392, 26)
        Me.Label98.TabIndex = 28
        Me.Label98.Text = "CAMBIO ESTADO ACTIVOS FIJOS"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(15, 51)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(112, 17)
        Me.Label99.TabIndex = 23
        Me.Label99.Text = "Archivo de Excel"
        '
        'txtExcelCambioEstadoActFijos
        '
        Me.txtExcelCambioEstadoActFijos.Enabled = False
        Me.txtExcelCambioEstadoActFijos.Location = New System.Drawing.Point(18, 83)
        Me.txtExcelCambioEstadoActFijos.Name = "txtExcelCambioEstadoActFijos"
        Me.txtExcelCambioEstadoActFijos.Size = New System.Drawing.Size(518, 20)
        Me.txtExcelCambioEstadoActFijos.TabIndex = 22
        '
        'TabPage_Mov_Contab_New
        '
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.btnExportarEstMovCont)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.txtNotasMovContab)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.dtpFechaDocMovCont)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.Label100)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.Label101)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.txtTipodocMovCont)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.Label102)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.txtCoMovContable)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.Label103)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.Label104)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.Label105)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.txtArchivoPlanoMovCont)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.Label106)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.txtArchivoExcelMovCont)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.btnExcelMovConta)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.btnExportarPlanoMovCont)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.btnSalirMovConta)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.btnGenerarMovContab)
        Me.TabPage_Mov_Contab_New.Controls.Add(Me.btnLimpiarMovCont)
        Me.TabPage_Mov_Contab_New.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Mov_Contab_New.Name = "TabPage_Mov_Contab_New"
        Me.TabPage_Mov_Contab_New.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Mov_Contab_New.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_Mov_Contab_New.TabIndex = 21
        Me.TabPage_Mov_Contab_New.Text = "Movimiento Contable New"
        Me.TabPage_Mov_Contab_New.UseVisualStyleBackColor = True
        '
        'txtNotasMovContab
        '
        Me.txtNotasMovContab.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotasMovContab.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotasMovContab.Location = New System.Drawing.Point(56, 101)
        Me.txtNotasMovContab.MaxLength = 255
        Me.txtNotasMovContab.Multiline = True
        Me.txtNotasMovContab.Name = "txtNotasMovContab"
        Me.txtNotasMovContab.Size = New System.Drawing.Size(627, 60)
        Me.txtNotasMovContab.TabIndex = 86
        '
        'dtpFechaDocMovCont
        '
        Me.dtpFechaDocMovCont.Location = New System.Drawing.Point(482, 73)
        Me.dtpFechaDocMovCont.Name = "dtpFechaDocMovCont"
        Me.dtpFechaDocMovCont.Size = New System.Drawing.Size(201, 20)
        Me.dtpFechaDocMovCont.TabIndex = 85
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(9, 118)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(45, 17)
        Me.Label100.TabIndex = 84
        Me.Label100.Text = "Notas"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(353, 75)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(123, 17)
        Me.Label101.TabIndex = 83
        Me.Label101.Text = "Fecha Documento"
        '
        'txtTipodocMovCont
        '
        Me.txtTipodocMovCont.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipodocMovCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipodocMovCont.Location = New System.Drawing.Point(306, 69)
        Me.txtTipodocMovCont.MaxLength = 3
        Me.txtTipodocMovCont.Name = "txtTipodocMovCont"
        Me.txtTipodocMovCont.Size = New System.Drawing.Size(44, 26)
        Me.txtTipodocMovCont.TabIndex = 82
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(169, 75)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(132, 17)
        Me.Label102.TabIndex = 81
        Me.Label102.Text = "Tipo de Documento"
        '
        'txtCoMovContable
        '
        Me.txtCoMovContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoMovContable.Location = New System.Drawing.Point(126, 69)
        Me.txtCoMovContable.MaxLength = 3
        Me.txtCoMovContable.Name = "txtCoMovContable"
        Me.txtCoMovContable.Size = New System.Drawing.Size(40, 26)
        Me.txtCoMovContable.TabIndex = 80
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(9, 75)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(116, 17)
        Me.Label103.TabIndex = 79
        Me.Label103.Text = "Centro Operativo"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(127, 19)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(422, 26)
        Me.Label104.TabIndex = 78
        Me.Label104.Text = "PLANO DE MOVIMIENTO CONTABLE"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(9, 215)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(95, 17)
        Me.Label105.TabIndex = 72
        Me.Label105.Text = "Archivo Plano"
        '
        'txtArchivoPlanoMovCont
        '
        Me.txtArchivoPlanoMovCont.Enabled = False
        Me.txtArchivoPlanoMovCont.Location = New System.Drawing.Point(12, 236)
        Me.txtArchivoPlanoMovCont.Name = "txtArchivoPlanoMovCont"
        Me.txtArchivoPlanoMovCont.Size = New System.Drawing.Size(518, 20)
        Me.txtArchivoPlanoMovCont.TabIndex = 71
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(9, 164)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(112, 17)
        Me.Label106.TabIndex = 70
        Me.Label106.Text = "Archivo de Excel"
        '
        'txtArchivoExcelMovCont
        '
        Me.txtArchivoExcelMovCont.Enabled = False
        Me.txtArchivoExcelMovCont.Location = New System.Drawing.Point(12, 185)
        Me.txtArchivoExcelMovCont.Name = "txtArchivoExcelMovCont"
        Me.txtArchivoExcelMovCont.Size = New System.Drawing.Size(518, 20)
        Me.txtArchivoExcelMovCont.TabIndex = 69
        '
        'TabPage_ImpuestosYRetenciones
        '
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.btn_estruc_ImpYret)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.Label107)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.Label108)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.txt_ImpyRet_plano)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.Label109)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.txt_ImpYRet_excel)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.btn_seleccionar_impyret_excel)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.btn_seleccionar_planoImpyRet)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.btn_salir_impyret)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.btn_generar_impyret)
        Me.TabPage_ImpuestosYRetenciones.Controls.Add(Me.btn_limpiar_estyret)
        Me.TabPage_ImpuestosYRetenciones.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_ImpuestosYRetenciones.Name = "TabPage_ImpuestosYRetenciones"
        Me.TabPage_ImpuestosYRetenciones.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_ImpuestosYRetenciones.TabIndex = 22
        Me.TabPage_ImpuestosYRetenciones.Text = "Impuestos Y Retenciones"
        Me.TabPage_ImpuestosYRetenciones.UseVisualStyleBackColor = True
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(163, 26)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(351, 26)
        Me.Label107.TabIndex = 159
        Me.Label107.Text = "IMPUESTOS Y RETENCIONES"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(9, 177)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(95, 17)
        Me.Label108.TabIndex = 153
        Me.Label108.Text = "Archivo Plano"
        '
        'txt_ImpyRet_plano
        '
        Me.txt_ImpyRet_plano.Enabled = False
        Me.txt_ImpyRet_plano.Location = New System.Drawing.Point(12, 210)
        Me.txt_ImpyRet_plano.Name = "txt_ImpyRet_plano"
        Me.txt_ImpyRet_plano.Size = New System.Drawing.Size(518, 20)
        Me.txt_ImpyRet_plano.TabIndex = 152
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.Location = New System.Drawing.Point(9, 89)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(112, 17)
        Me.Label109.TabIndex = 151
        Me.Label109.Text = "Archivo de Excel"
        '
        'txt_ImpYRet_excel
        '
        Me.txt_ImpYRet_excel.Enabled = False
        Me.txt_ImpYRet_excel.Location = New System.Drawing.Point(12, 124)
        Me.txt_ImpYRet_excel.Name = "txt_ImpYRet_excel"
        Me.txt_ImpYRet_excel.Size = New System.Drawing.Size(518, 20)
        Me.txt_ImpYRet_excel.TabIndex = 150
        '
        'TabPage_CostoEstandar
        '
        Me.TabPage_CostoEstandar.Controls.Add(Me.Button1)
        Me.TabPage_CostoEstandar.Controls.Add(Me.Label113)
        Me.TabPage_CostoEstandar.Controls.Add(Me.Label114)
        Me.TabPage_CostoEstandar.Controls.Add(Me.txtPlanoExcel)
        Me.TabPage_CostoEstandar.Controls.Add(Me.Label115)
        Me.TabPage_CostoEstandar.Controls.Add(Me.txtExcelCostos)
        Me.TabPage_CostoEstandar.Controls.Add(Me.btnSeleccionarArchivoCosto)
        Me.TabPage_CostoEstandar.Controls.Add(Me.btnExportarArchivoCosto)
        Me.TabPage_CostoEstandar.Controls.Add(Me.Button6)
        Me.TabPage_CostoEstandar.Controls.Add(Me.Button7)
        Me.TabPage_CostoEstandar.Controls.Add(Me.Button8)
        Me.TabPage_CostoEstandar.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_CostoEstandar.Name = "TabPage_CostoEstandar"
        Me.TabPage_CostoEstandar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_CostoEstandar.Size = New System.Drawing.Size(693, 341)
        Me.TabPage_CostoEstandar.TabIndex = 24
        Me.TabPage_CostoEstandar.Text = "Costo Estandar"
        Me.TabPage_CostoEstandar.UseVisualStyleBackColor = True
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(223, 24)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(229, 26)
        Me.Label113.TabIndex = 170
        Me.Label113.Text = "COSTO ESTANDAR"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(9, 177)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(95, 17)
        Me.Label114.TabIndex = 164
        Me.Label114.Text = "Archivo Plano"
        '
        'txtPlanoExcel
        '
        Me.txtPlanoExcel.Enabled = False
        Me.txtPlanoExcel.Location = New System.Drawing.Point(12, 210)
        Me.txtPlanoExcel.Name = "txtPlanoExcel"
        Me.txtPlanoExcel.Size = New System.Drawing.Size(518, 20)
        Me.txtPlanoExcel.TabIndex = 163
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(9, 89)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(112, 17)
        Me.Label115.TabIndex = 162
        Me.Label115.Text = "Archivo de Excel"
        '
        'txtExcelCostos
        '
        Me.txtExcelCostos.Enabled = False
        Me.txtExcelCostos.Location = New System.Drawing.Point(12, 124)
        Me.txtExcelCostos.Name = "txtExcelCostos"
        Me.txtExcelCostos.Size = New System.Drawing.Size(518, 20)
        Me.txtExcelCostos.TabIndex = 161
        '
        'TabPageDistribucionCostos
        '
        Me.TabPageDistribucionCostos.Controls.Add(Me.Button3)
        Me.TabPageDistribucionCostos.Controls.Add(Me.Label116)
        Me.TabPageDistribucionCostos.Controls.Add(Me.Label117)
        Me.TabPageDistribucionCostos.Controls.Add(Me.txtRutaPlanoDistribucionCostos)
        Me.TabPageDistribucionCostos.Controls.Add(Me.Label118)
        Me.TabPageDistribucionCostos.Controls.Add(Me.txtExcelDistribucionCostos)
        Me.TabPageDistribucionCostos.Controls.Add(Me.Button5)
        Me.TabPageDistribucionCostos.Controls.Add(Me.Button9)
        Me.TabPageDistribucionCostos.Controls.Add(Me.btnSalirDistribucionCostos)
        Me.TabPageDistribucionCostos.Controls.Add(Me.btnGenerarDistribucionCostos)
        Me.TabPageDistribucionCostos.Controls.Add(Me.btnLimpiarDistribucionCostos)
        Me.TabPageDistribucionCostos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDistribucionCostos.Name = "TabPageDistribucionCostos"
        Me.TabPageDistribucionCostos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDistribucionCostos.Size = New System.Drawing.Size(693, 341)
        Me.TabPageDistribucionCostos.TabIndex = 25
        Me.TabPageDistribucionCostos.Text = "Distribución de Costos"
        Me.TabPageDistribucionCostos.UseVisualStyleBackColor = True
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(204, 14)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(326, 26)
        Me.Label116.TabIndex = 181
        Me.Label116.Text = "DISTRIBUCIÓN DE COSTOS"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(9, 165)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(143, 17)
        Me.Label117.TabIndex = 175
        Me.Label117.Text = "Ruta Archivos Planos"
        '
        'txtRutaPlanoDistribucionCostos
        '
        Me.txtRutaPlanoDistribucionCostos.Enabled = False
        Me.txtRutaPlanoDistribucionCostos.Location = New System.Drawing.Point(12, 198)
        Me.txtRutaPlanoDistribucionCostos.Name = "txtRutaPlanoDistribucionCostos"
        Me.txtRutaPlanoDistribucionCostos.Size = New System.Drawing.Size(518, 20)
        Me.txtRutaPlanoDistribucionCostos.TabIndex = 174
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(9, 77)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(112, 17)
        Me.Label118.TabIndex = 173
        Me.Label118.Text = "Archivo de Excel"
        '
        'txtExcelDistribucionCostos
        '
        Me.txtExcelDistribucionCostos.Enabled = False
        Me.txtExcelDistribucionCostos.Location = New System.Drawing.Point(12, 112)
        Me.txtExcelDistribucionCostos.Name = "txtExcelDistribucionCostos"
        Me.txtExcelDistribucionCostos.Size = New System.Drawing.Size(518, 20)
        Me.txtExcelDistribucionCostos.TabIndex = 172
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label127)
        Me.TabPage1.Controls.Add(Me.cboBanco)
        Me.TabPage1.Controls.Add(Me.txtGenerarNomina)
        Me.TabPage1.Controls.Add(Me.Label126)
        Me.TabPage1.Controls.Add(Me.dtpFechaNomina)
        Me.TabPage1.Controls.Add(Me.txtNitBancoNomina)
        Me.TabPage1.Controls.Add(Me.Label125)
        Me.TabPage1.Controls.Add(Me.txtAuxiliarNomina)
        Me.TabPage1.Controls.Add(Me.Label124)
        Me.TabPage1.Controls.Add(Me.txtNotasNomina)
        Me.TabPage1.Controls.Add(Me.txtTipoDctoNomina)
        Me.TabPage1.Controls.Add(Me.txtCONomina)
        Me.TabPage1.Controls.Add(Me.Label123)
        Me.TabPage1.Controls.Add(Me.Label122)
        Me.TabPage1.Controls.Add(Me.Label121)
        Me.TabPage1.Controls.Add(Me.Label120)
        Me.TabPage1.Controls.Add(Me.txtRutaPlanoNomina)
        Me.TabPage1.Controls.Add(Me.Label119)
        Me.TabPage1.Controls.Add(Me.txtRutaNomina)
        Me.TabPage1.Controls.Add(Me.btnRutaGenerarNomina)
        Me.TabPage1.Controls.Add(Me.btnNominaPlano)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(693, 341)
        Me.TabPage1.TabIndex = 26
        Me.TabPage1.Text = "Plano Nomina"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(9, 78)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(60, 17)
        Me.Label127.TabIndex = 200
        Me.Label127.Text = "BANCO:"
        '
        'cboBanco
        '
        Me.cboBanco.FormattingEnabled = True
        Me.cboBanco.Items.AddRange(New Object() {"BANCOLOMBIA", "BOGOTA"})
        Me.cboBanco.Location = New System.Drawing.Point(75, 74)
        Me.cboBanco.Name = "cboBanco"
        Me.cboBanco.Size = New System.Drawing.Size(161, 21)
        Me.cboBanco.TabIndex = 199
        '
        'txtGenerarNomina
        '
        Me.txtGenerarNomina.Location = New System.Drawing.Point(12, 266)
        Me.txtGenerarNomina.Name = "txtGenerarNomina"
        Me.txtGenerarNomina.Size = New System.Drawing.Size(126, 23)
        Me.txtGenerarNomina.TabIndex = 198
        Me.txtGenerarNomina.Text = "GENERAR PLANO"
        Me.txtGenerarNomina.UseVisualStyleBackColor = True
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(9, 12)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(57, 17)
        Me.Label126.TabIndex = 197
        Me.Label126.Text = "FECHA:"
        '
        'dtpFechaNomina
        '
        Me.dtpFechaNomina.Location = New System.Drawing.Point(66, 12)
        Me.dtpFechaNomina.Name = "dtpFechaNomina"
        Me.dtpFechaNomina.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNomina.TabIndex = 196
        '
        'txtNitBancoNomina
        '
        Me.txtNitBancoNomina.Location = New System.Drawing.Point(514, 48)
        Me.txtNitBancoNomina.Name = "txtNitBancoNomina"
        Me.txtNitBancoNomina.Size = New System.Drawing.Size(68, 20)
        Me.txtNitBancoNomina.TabIndex = 195
        Me.txtNitBancoNomina.Text = "890903938"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.Location = New System.Drawing.Point(422, 49)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(86, 17)
        Me.Label125.TabIndex = 194
        Me.Label125.Text = "NIT BANCO:"
        '
        'txtAuxiliarNomina
        '
        Me.txtAuxiliarNomina.Location = New System.Drawing.Point(348, 47)
        Me.txtAuxiliarNomina.Name = "txtAuxiliarNomina"
        Me.txtAuxiliarNomina.Size = New System.Drawing.Size(68, 20)
        Me.txtAuxiliarNomina.TabIndex = 193
        Me.txtAuxiliarNomina.Text = "11100507"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.Location = New System.Drawing.Point(217, 48)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(125, 17)
        Me.Label124.TabIndex = 192
        Me.Label124.Text = "AUXILIAR BANCO:"
        '
        'txtNotasNomina
        '
        Me.txtNotasNomina.Location = New System.Drawing.Point(75, 100)
        Me.txtNotasNomina.Name = "txtNotasNomina"
        Me.txtNotasNomina.Size = New System.Drawing.Size(432, 20)
        Me.txtNotasNomina.TabIndex = 191
        '
        'txtTipoDctoNomina
        '
        Me.txtTipoDctoNomina.Location = New System.Drawing.Point(179, 48)
        Me.txtTipoDctoNomina.Name = "txtTipoDctoNomina"
        Me.txtTipoDctoNomina.Size = New System.Drawing.Size(32, 20)
        Me.txtTipoDctoNomina.TabIndex = 190
        Me.txtTipoDctoNomina.Text = "CPG"
        '
        'txtCONomina
        '
        Me.txtCONomina.Location = New System.Drawing.Point(42, 48)
        Me.txtCONomina.Name = "txtCONomina"
        Me.txtCONomina.Size = New System.Drawing.Size(31, 20)
        Me.txtCONomina.TabIndex = 189
        Me.txtCONomina.Text = "190"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(75, 48)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(98, 17)
        Me.Label123.TabIndex = 188
        Me.Label123.Text = "TIPO DOCTO:"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(9, 101)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(60, 17)
        Me.Label122.TabIndex = 187
        Me.Label122.Text = "NOTAS:"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(9, 48)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(32, 17)
        Me.Label121.TabIndex = 186
        Me.Label121.Text = "CO:"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(9, 206)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(150, 17)
        Me.Label120.TabIndex = 184
        Me.Label120.Text = "Ruta Plano Generado:"
        '
        'txtRutaPlanoNomina
        '
        Me.txtRutaPlanoNomina.Enabled = False
        Me.txtRutaPlanoNomina.Location = New System.Drawing.Point(162, 206)
        Me.txtRutaPlanoNomina.Name = "txtRutaPlanoNomina"
        Me.txtRutaPlanoNomina.Size = New System.Drawing.Size(313, 20)
        Me.txtRutaPlanoNomina.TabIndex = 183
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(9, 150)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(107, 17)
        Me.Label119.TabIndex = 181
        Me.Label119.Text = "Planos Nomina:"
        '
        'txtRutaNomina
        '
        Me.txtRutaNomina.Enabled = False
        Me.txtRutaNomina.Location = New System.Drawing.Point(162, 150)
        Me.txtRutaNomina.Name = "txtRutaNomina"
        Me.txtRutaNomina.Size = New System.Drawing.Size(313, 20)
        Me.txtRutaNomina.TabIndex = 180
        '
        'TabPageCompraServicios
        '
        Me.TabPageCompraServicios.Controls.Add(Me.txtCentroCostosCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label141)
        Me.TabPageCompraServicios.Controls.Add(Me.txtCondicionPagoCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label140)
        Me.TabPageCompraServicios.Controls.Add(Me.txtFacturaCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label139)
        Me.TabPageCompraServicios.Controls.Add(Me.txtPrefijoFacturaCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label138)
        Me.TabPageCompraServicios.Controls.Add(Me.txtTipoProveedorCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label137)
        Me.TabPageCompraServicios.Controls.Add(Me.txtSucursarCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label136)
        Me.TabPageCompraServicios.Controls.Add(Me.txtNitCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label135)
        Me.TabPageCompraServicios.Controls.Add(Me.Label133)
        Me.TabPageCompraServicios.Controls.Add(Me.txtRutaPlanoCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label134)
        Me.TabPageCompraServicios.Controls.Add(Me.txtRutaExcelCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.txtNotasCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.txtTipoDoctoCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.txtCoCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.Label130)
        Me.TabPageCompraServicios.Controls.Add(Me.Label131)
        Me.TabPageCompraServicios.Controls.Add(Me.Label132)
        Me.TabPageCompraServicios.Controls.Add(Me.Label129)
        Me.TabPageCompraServicios.Controls.Add(Me.Label128)
        Me.TabPageCompraServicios.Controls.Add(Me.dtpFechaCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.btnExportarEstructuraCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.btnSeleccionarExcelCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.btnExportarPlanoCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.btnSalirCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.btnGenerarCompraServicios)
        Me.TabPageCompraServicios.Controls.Add(Me.btnLimpiarCompraServicios)
        Me.TabPageCompraServicios.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCompraServicios.Name = "TabPageCompraServicios"
        Me.TabPageCompraServicios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCompraServicios.Size = New System.Drawing.Size(693, 341)
        Me.TabPageCompraServicios.TabIndex = 27
        Me.TabPageCompraServicios.Text = "Compra Servicios"
        Me.TabPageCompraServicios.UseVisualStyleBackColor = True
        '
        'txtCentroCostosCompraServicios
        '
        Me.txtCentroCostosCompraServicios.Location = New System.Drawing.Point(389, 98)
        Me.txtCentroCostosCompraServicios.Name = "txtCentroCostosCompraServicios"
        Me.txtCentroCostosCompraServicios.Size = New System.Drawing.Size(65, 20)
        Me.txtCentroCostosCompraServicios.TabIndex = 236
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.Location = New System.Drawing.Point(228, 99)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(155, 17)
        Me.Label141.TabIndex = 235
        Me.Label141.Text = "CENTRO DE COSTOS:"
        '
        'txtCondicionPagoCompraServicios
        '
        Me.txtCondicionPagoCompraServicios.Location = New System.Drawing.Point(167, 96)
        Me.txtCondicionPagoCompraServicios.Name = "txtCondicionPagoCompraServicios"
        Me.txtCondicionPagoCompraServicios.Size = New System.Drawing.Size(35, 20)
        Me.txtCondicionPagoCompraServicios.TabIndex = 234
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.Location = New System.Drawing.Point(6, 97)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(155, 17)
        Me.Label140.TabIndex = 233
        Me.Label140.Text = "CONDICIÓN DE PAGO:"
        '
        'txtFacturaCompraServicios
        '
        Me.txtFacturaCompraServicios.Location = New System.Drawing.Point(610, 62)
        Me.txtFacturaCompraServicios.Name = "txtFacturaCompraServicios"
        Me.txtFacturaCompraServicios.Size = New System.Drawing.Size(72, 20)
        Me.txtFacturaCompraServicios.TabIndex = 232
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.Location = New System.Drawing.Point(528, 61)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(76, 17)
        Me.Label139.TabIndex = 231
        Me.Label139.Text = "FACTURA:"
        '
        'txtPrefijoFacturaCompraServicios
        '
        Me.txtPrefijoFacturaCompraServicios.Location = New System.Drawing.Point(485, 62)
        Me.txtPrefijoFacturaCompraServicios.Name = "txtPrefijoFacturaCompraServicios"
        Me.txtPrefijoFacturaCompraServicios.Size = New System.Drawing.Size(35, 20)
        Me.txtPrefijoFacturaCompraServicios.TabIndex = 230
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label138.Location = New System.Drawing.Point(342, 62)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(137, 17)
        Me.Label138.TabIndex = 229
        Me.Label138.Text = "PREFIJO FACTURA:"
        '
        'txtTipoProveedorCompraServicios
        '
        Me.txtTipoProveedorCompraServicios.Location = New System.Drawing.Point(286, 62)
        Me.txtTipoProveedorCompraServicios.Name = "txtTipoProveedorCompraServicios"
        Me.txtTipoProveedorCompraServicios.Size = New System.Drawing.Size(35, 20)
        Me.txtTipoProveedorCompraServicios.TabIndex = 228
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label137.Location = New System.Drawing.Point(152, 62)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(136, 17)
        Me.Label137.TabIndex = 227
        Me.Label137.Text = "TIPO PROVEEDOR:"
        '
        'txtSucursarCompraServicios
        '
        Me.txtSucursarCompraServicios.Location = New System.Drawing.Point(98, 61)
        Me.txtSucursarCompraServicios.Name = "txtSucursarCompraServicios"
        Me.txtSucursarCompraServicios.Size = New System.Drawing.Size(35, 20)
        Me.txtSucursarCompraServicios.TabIndex = 226
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.Location = New System.Drawing.Point(6, 61)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(86, 17)
        Me.Label136.TabIndex = 225
        Me.Label136.Text = "SUCURSAL:"
        '
        'txtNitCompraServicios
        '
        Me.txtNitCompraServicios.Location = New System.Drawing.Point(531, 28)
        Me.txtNitCompraServicios.Name = "txtNitCompraServicios"
        Me.txtNitCompraServicios.Size = New System.Drawing.Size(106, 20)
        Me.txtNitCompraServicios.TabIndex = 224
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.Location = New System.Drawing.Point(491, 28)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(34, 17)
        Me.Label135.TabIndex = 223
        Me.Label135.Text = "NIT:"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(3, 208)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(143, 17)
        Me.Label133.TabIndex = 216
        Me.Label133.Text = "Ruta Archivos Planos"
        '
        'txtRutaPlanoCompraServicios
        '
        Me.txtRutaPlanoCompraServicios.Enabled = False
        Me.txtRutaPlanoCompraServicios.Location = New System.Drawing.Point(6, 234)
        Me.txtRutaPlanoCompraServicios.Name = "txtRutaPlanoCompraServicios"
        Me.txtRutaPlanoCompraServicios.Size = New System.Drawing.Size(518, 20)
        Me.txtRutaPlanoCompraServicios.TabIndex = 215
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(3, 160)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(112, 17)
        Me.Label134.TabIndex = 214
        Me.Label134.Text = "Archivo de Excel"
        '
        'txtRutaExcelCompraServicios
        '
        Me.txtRutaExcelCompraServicios.Enabled = False
        Me.txtRutaExcelCompraServicios.Location = New System.Drawing.Point(6, 183)
        Me.txtRutaExcelCompraServicios.Name = "txtRutaExcelCompraServicios"
        Me.txtRutaExcelCompraServicios.Size = New System.Drawing.Size(518, 20)
        Me.txtRutaExcelCompraServicios.TabIndex = 213
        '
        'txtNotasCompraServicios
        '
        Me.txtNotasCompraServicios.Location = New System.Drawing.Point(69, 133)
        Me.txtNotasCompraServicios.Name = "txtNotasCompraServicios"
        Me.txtNotasCompraServicios.Size = New System.Drawing.Size(432, 20)
        Me.txtNotasCompraServicios.TabIndex = 212
        '
        'txtTipoDoctoCompraServicios
        '
        Me.txtTipoDoctoCompraServicios.Location = New System.Drawing.Point(453, 28)
        Me.txtTipoDoctoCompraServicios.Name = "txtTipoDoctoCompraServicios"
        Me.txtTipoDoctoCompraServicios.Size = New System.Drawing.Size(32, 20)
        Me.txtTipoDoctoCompraServicios.TabIndex = 211
        '
        'txtCoCompraServicios
        '
        Me.txtCoCompraServicios.Location = New System.Drawing.Point(316, 28)
        Me.txtCoCompraServicios.Name = "txtCoCompraServicios"
        Me.txtCoCompraServicios.Size = New System.Drawing.Size(31, 20)
        Me.txtCoCompraServicios.TabIndex = 210
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(349, 28)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(98, 17)
        Me.Label130.TabIndex = 209
        Me.Label130.Text = "TIPO DOCTO:"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(3, 134)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(60, 17)
        Me.Label131.TabIndex = 208
        Me.Label131.Text = "NOTAS:"
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(283, 28)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(32, 17)
        Me.Label132.TabIndex = 207
        Me.Label132.Text = "CO:"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(251, 3)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(159, 17)
        Me.Label129.TabIndex = 200
        Me.Label129.Text = "COMPRA SERVICIOS"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(6, 28)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(57, 17)
        Me.Label128.TabIndex = 199
        Me.Label128.Text = "FECHA:"
        '
        'dtpFechaCompraServicios
        '
        Me.dtpFechaCompraServicios.Location = New System.Drawing.Point(63, 28)
        Me.dtpFechaCompraServicios.Name = "dtpFechaCompraServicios"
        Me.dtpFechaCompraServicios.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaCompraServicios.TabIndex = 198
        '
        'TabPageImportarTercero
        '
        Me.TabPageImportarTercero.Controls.Add(Me.Button10)
        Me.TabPageImportarTercero.Controls.Add(Me.Label142)
        Me.TabPageImportarTercero.Controls.Add(Me.Label143)
        Me.TabPageImportarTercero.Controls.Add(Me.txtPlanoExcelTerceros)
        Me.TabPageImportarTercero.Controls.Add(Me.Label144)
        Me.TabPageImportarTercero.Controls.Add(Me.txtExcelTerceros)
        Me.TabPageImportarTercero.Controls.Add(Me.Button11)
        Me.TabPageImportarTercero.Controls.Add(Me.Button12)
        Me.TabPageImportarTercero.Controls.Add(Me.Button13)
        Me.TabPageImportarTercero.Controls.Add(Me.Button14)
        Me.TabPageImportarTercero.Controls.Add(Me.Button15)
        Me.TabPageImportarTercero.Location = New System.Drawing.Point(4, 22)
        Me.TabPageImportarTercero.Name = "TabPageImportarTercero"
        Me.TabPageImportarTercero.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageImportarTercero.Size = New System.Drawing.Size(693, 341)
        Me.TabPageImportarTercero.TabIndex = 28
        Me.TabPageImportarTercero.Text = "Importar Terceros"
        Me.TabPageImportarTercero.UseVisualStyleBackColor = True
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.Location = New System.Drawing.Point(220, 18)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(272, 26)
        Me.Label142.TabIndex = 181
        Me.Label142.Text = "IMPORTAR TERCEROS"
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label143.Location = New System.Drawing.Point(6, 171)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(95, 17)
        Me.Label143.TabIndex = 175
        Me.Label143.Text = "Archivo Plano"
        '
        'txtPlanoExcelTerceros
        '
        Me.txtPlanoExcelTerceros.Enabled = False
        Me.txtPlanoExcelTerceros.Location = New System.Drawing.Point(9, 204)
        Me.txtPlanoExcelTerceros.Name = "txtPlanoExcelTerceros"
        Me.txtPlanoExcelTerceros.Size = New System.Drawing.Size(518, 20)
        Me.txtPlanoExcelTerceros.TabIndex = 174
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label144.Location = New System.Drawing.Point(6, 83)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(112, 17)
        Me.Label144.TabIndex = 173
        Me.Label144.Text = "Archivo de Excel"
        '
        'txtExcelTerceros
        '
        Me.txtExcelTerceros.Enabled = False
        Me.txtExcelTerceros.Location = New System.Drawing.Point(9, 118)
        Me.txtExcelTerceros.Name = "txtExcelTerceros"
        Me.txtExcelTerceros.Size = New System.Drawing.Size(518, 20)
        Me.txtExcelTerceros.TabIndex = 172
        '
        'TabPageActualizarCodBarras
        '
        Me.TabPageActualizarCodBarras.Controls.Add(Me.Button16)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.Label147)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.txtLogActCodBarras)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.Label146)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.txtExcelActCodBarras)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.Label145)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.Button18)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.Button19)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.btnExcelActCodBarras)
        Me.TabPageActualizarCodBarras.Controls.Add(Me.btnGenerarActCodBarras)
        Me.TabPageActualizarCodBarras.Location = New System.Drawing.Point(4, 22)
        Me.TabPageActualizarCodBarras.Name = "TabPageActualizarCodBarras"
        Me.TabPageActualizarCodBarras.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageActualizarCodBarras.Size = New System.Drawing.Size(693, 341)
        Me.TabPageActualizarCodBarras.TabIndex = 29
        Me.TabPageActualizarCodBarras.Text = "Actualiza Cod. Barras Act. Fijos"
        Me.TabPageActualizarCodBarras.UseVisualStyleBackColor = True
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label147.Location = New System.Drawing.Point(14, 156)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(36, 17)
        Me.Label147.TabIndex = 190
        Me.Label147.Text = "Log:"
        '
        'txtLogActCodBarras
        '
        Me.txtLogActCodBarras.ForeColor = System.Drawing.Color.Red
        Me.txtLogActCodBarras.Location = New System.Drawing.Point(17, 176)
        Me.txtLogActCodBarras.Multiline = True
        Me.txtLogActCodBarras.Name = "txtLogActCodBarras"
        Me.txtLogActCodBarras.Size = New System.Drawing.Size(670, 74)
        Me.txtLogActCodBarras.TabIndex = 189
        '
        'Label146
        '
        Me.Label146.AutoSize = True
        Me.Label146.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label146.Location = New System.Drawing.Point(14, 78)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(112, 17)
        Me.Label146.TabIndex = 184
        Me.Label146.Text = "Archivo de Excel"
        '
        'txtExcelActCodBarras
        '
        Me.txtExcelActCodBarras.Enabled = False
        Me.txtExcelActCodBarras.Location = New System.Drawing.Point(17, 113)
        Me.txtExcelActCodBarras.Name = "txtExcelActCodBarras"
        Me.txtExcelActCodBarras.Size = New System.Drawing.Size(518, 20)
        Me.txtExcelActCodBarras.TabIndex = 183
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label145.Location = New System.Drawing.Point(65, 29)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(555, 26)
        Me.Label145.TabIndex = 182
        Me.Label145.Text = "ACTUALIZACIÓN COD. BARRAS ACTIVOS FIJOS"
        '
        'TabPagePlanoNomSAP
        '
        Me.TabPagePlanoNomSAP.Controls.Add(Me.txtConceptoNomSAP)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.Label150)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.Label148)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.cboBancoSap)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.Label149)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.dtpFechaNomSAP)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.txtCLNominaSAP)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.Label154)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.btnRutaGeneraExcel)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.Label155)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.txtRutaExcelGenerado)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.Label156)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.txtRutaNomPlano)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.btnRutaPlanoNomina)
        Me.TabPagePlanoNomSAP.Controls.Add(Me.btnGenerarXlsNomina)
        Me.TabPagePlanoNomSAP.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePlanoNomSAP.Name = "TabPagePlanoNomSAP"
        Me.TabPagePlanoNomSAP.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePlanoNomSAP.Size = New System.Drawing.Size(693, 341)
        Me.TabPagePlanoNomSAP.TabIndex = 30
        Me.TabPagePlanoNomSAP.Text = "PLANO NOMINA SAP"
        Me.TabPagePlanoNomSAP.UseVisualStyleBackColor = True
        '
        'Label148
        '
        Me.Label148.AutoSize = True
        Me.Label148.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label148.Location = New System.Drawing.Point(20, 117)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(52, 17)
        Me.Label148.TabIndex = 220
        Me.Label148.Text = "Banco:"
        '
        'cboBancoSap
        '
        Me.cboBancoSap.FormattingEnabled = True
        Me.cboBancoSap.Items.AddRange(New Object() {"BANCOLOMBIA", "BOGOTA"})
        Me.cboBancoSap.Location = New System.Drawing.Point(231, 113)
        Me.cboBancoSap.Name = "cboBancoSap"
        Me.cboBancoSap.Size = New System.Drawing.Size(200, 21)
        Me.cboBancoSap.TabIndex = 219
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label149.Location = New System.Drawing.Point(20, 36)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(51, 17)
        Me.Label149.TabIndex = 218
        Me.Label149.Text = "Fecha:"
        '
        'dtpFechaNomSAP
        '
        Me.dtpFechaNomSAP.Location = New System.Drawing.Point(231, 33)
        Me.dtpFechaNomSAP.Name = "dtpFechaNomSAP"
        Me.dtpFechaNomSAP.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaNomSAP.TabIndex = 217
        '
        'txtCLNominaSAP
        '
        Me.txtCLNominaSAP.Location = New System.Drawing.Point(596, 32)
        Me.txtCLNominaSAP.Name = "txtCLNominaSAP"
        Me.txtCLNominaSAP.Size = New System.Drawing.Size(47, 20)
        Me.txtCLNominaSAP.TabIndex = 210
        Me.txtCLNominaSAP.Text = "1000"
        Me.txtCLNominaSAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label154.Location = New System.Drawing.Point(536, 32)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(29, 17)
        Me.Label154.TabIndex = 207
        Me.Label154.Text = "CL:"
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label155.Location = New System.Drawing.Point(20, 212)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(198, 17)
        Me.Label155.TabIndex = 205
        Me.Label155.Text = "Ruta Archivo Excel Generado:"
        '
        'txtRutaExcelGenerado
        '
        Me.txtRutaExcelGenerado.Enabled = False
        Me.txtRutaExcelGenerado.Location = New System.Drawing.Point(231, 212)
        Me.txtRutaExcelGenerado.Name = "txtRutaExcelGenerado"
        Me.txtRutaExcelGenerado.Size = New System.Drawing.Size(412, 20)
        Me.txtRutaExcelGenerado.TabIndex = 204
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label156.Location = New System.Drawing.Point(20, 156)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(107, 17)
        Me.Label156.TabIndex = 202
        Me.Label156.Text = "Planos Nomina:"
        '
        'txtRutaNomPlano
        '
        Me.txtRutaNomPlano.Enabled = False
        Me.txtRutaNomPlano.Location = New System.Drawing.Point(231, 156)
        Me.txtRutaNomPlano.Name = "txtRutaNomPlano"
        Me.txtRutaNomPlano.Size = New System.Drawing.Size(412, 20)
        Me.txtRutaNomPlano.TabIndex = 201
        '
        'btnGenerarXlsNomina
        '
        Me.btnGenerarXlsNomina.Location = New System.Drawing.Point(491, 286)
        Me.btnGenerarXlsNomina.Name = "btnGenerarXlsNomina"
        Me.btnGenerarXlsNomina.Size = New System.Drawing.Size(195, 32)
        Me.btnGenerarXlsNomina.TabIndex = 0
        Me.btnGenerarXlsNomina.Text = "Generar Archivo Excel"
        Me.btnGenerarXlsNomina.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(891, 381)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(79, 13)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "Version 1.3.2 C"
        '
        'btn_est_activos
        '
        Me.btn_est_activos.BackColor = System.Drawing.Color.White
        Me.btn_est_activos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_activos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_activos.Location = New System.Drawing.Point(540, 281)
        Me.btn_est_activos.Name = "btn_est_activos"
        Me.btn_est_activos.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_activos.TabIndex = 66
        Me.btn_est_activos.Text = "Exportar Estructura"
        Me.btn_est_activos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_activos.UseVisualStyleBackColor = False
        '
        'btn_excel_activos
        '
        Me.btn_excel_activos.BackColor = System.Drawing.Color.White
        Me.btn_excel_activos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_activos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_activos.Location = New System.Drawing.Point(540, 95)
        Me.btn_excel_activos.Name = "btn_excel_activos"
        Me.btn_excel_activos.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_activos.TabIndex = 19
        Me.btn_excel_activos.Text = "Seleccionar Archivo"
        Me.btn_excel_activos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_activos.UseVisualStyleBackColor = False
        '
        'btn_plano_activos
        '
        Me.btn_plano_activos.BackColor = System.Drawing.Color.White
        Me.btn_plano_activos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_activos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_activos.Location = New System.Drawing.Point(540, 188)
        Me.btn_plano_activos.Name = "btn_plano_activos"
        Me.btn_plano_activos.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_activos.TabIndex = 18
        Me.btn_plano_activos.Text = "Exportar Archivo Plano"
        Me.btn_plano_activos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_activos.UseVisualStyleBackColor = False
        '
        'btn_salir_activos
        '
        Me.btn_salir_activos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_activos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_activos.Location = New System.Drawing.Point(380, 273)
        Me.btn_salir_activos.Name = "btn_salir_activos"
        Me.btn_salir_activos.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_activos.TabIndex = 17
        Me.btn_salir_activos.Text = "Salir"
        Me.btn_salir_activos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_activos.UseVisualStyleBackColor = True
        '
        'btn_generar_activos
        '
        Me.btn_generar_activos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_activos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_activos.Location = New System.Drawing.Point(70, 273)
        Me.btn_generar_activos.Name = "btn_generar_activos"
        Me.btn_generar_activos.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_activos.TabIndex = 16
        Me.btn_generar_activos.Text = "Generar"
        Me.btn_generar_activos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_activos.UseVisualStyleBackColor = True
        '
        'btn_limpiar_activos
        '
        Me.btn_limpiar_activos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_activos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_activos.Location = New System.Drawing.Point(227, 273)
        Me.btn_limpiar_activos.Name = "btn_limpiar_activos"
        Me.btn_limpiar_activos.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_activos.TabIndex = 15
        Me.btn_limpiar_activos.Text = "Limpiar"
        Me.btn_limpiar_activos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_activos.UseVisualStyleBackColor = True
        '
        'btn_est_activaciones
        '
        Me.btn_est_activaciones.BackColor = System.Drawing.Color.White
        Me.btn_est_activaciones.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_activaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_activaciones.Location = New System.Drawing.Point(531, 291)
        Me.btn_est_activaciones.Name = "btn_est_activaciones"
        Me.btn_est_activaciones.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_activaciones.TabIndex = 67
        Me.btn_est_activaciones.Text = "Exportar Estructura"
        Me.btn_est_activaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_activaciones.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.Location = New System.Drawing.Point(372, 283)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_generar
        '
        Me.btn_generar.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar.Location = New System.Drawing.Point(86, 283)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar.TabIndex = 7
        Me.btn_generar.Text = "Generar"
        Me.btn_generar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar.Location = New System.Drawing.Point(228, 283)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar.TabIndex = 6
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'btn_plano
        '
        Me.btn_plano.BackColor = System.Drawing.Color.White
        Me.btn_plano.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_plano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano.Location = New System.Drawing.Point(531, 146)
        Me.btn_plano.Name = "btn_plano"
        Me.btn_plano.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano.TabIndex = 4
        Me.btn_plano.Text = "Seleccionar Archivo"
        Me.btn_plano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano.UseVisualStyleBackColor = False
        '
        'btn_seleccionar
        '
        Me.btn_seleccionar.BackColor = System.Drawing.Color.White
        Me.btn_seleccionar.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar.Location = New System.Drawing.Point(531, 213)
        Me.btn_seleccionar.Name = "btn_seleccionar"
        Me.btn_seleccionar.Size = New System.Drawing.Size(147, 35)
        Me.btn_seleccionar.TabIndex = 1
        Me.btn_seleccionar.Text = "Exportar Archivo Plano"
        Me.btn_seleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar.UseVisualStyleBackColor = False
        '
        'btn_est_movimiento
        '
        Me.btn_est_movimiento.BackColor = System.Drawing.Color.White
        Me.btn_est_movimiento.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_movimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_movimiento.Location = New System.Drawing.Point(536, 285)
        Me.btn_est_movimiento.Name = "btn_est_movimiento"
        Me.btn_est_movimiento.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_movimiento.TabIndex = 68
        Me.btn_est_movimiento.Text = "Exportar Estructura"
        Me.btn_est_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_movimiento.UseVisualStyleBackColor = False
        '
        'btn_excel_movimiento
        '
        Me.btn_excel_movimiento.BackColor = System.Drawing.Color.White
        Me.btn_excel_movimiento.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_movimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_movimiento.Location = New System.Drawing.Point(536, 175)
        Me.btn_excel_movimiento.Name = "btn_excel_movimiento"
        Me.btn_excel_movimiento.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_movimiento.TabIndex = 30
        Me.btn_excel_movimiento.Text = "Seleccionar Archivo"
        Me.btn_excel_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_movimiento.UseVisualStyleBackColor = False
        '
        'btn_plano_movimiento
        '
        Me.btn_plano_movimiento.BackColor = System.Drawing.Color.White
        Me.btn_plano_movimiento.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_movimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_movimiento.Location = New System.Drawing.Point(536, 226)
        Me.btn_plano_movimiento.Name = "btn_plano_movimiento"
        Me.btn_plano_movimiento.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_movimiento.TabIndex = 29
        Me.btn_plano_movimiento.Text = "Exportar Archivo Plano"
        Me.btn_plano_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_movimiento.UseVisualStyleBackColor = False
        '
        'btn_salir_movimiento
        '
        Me.btn_salir_movimiento.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_movimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_movimiento.Location = New System.Drawing.Point(356, 277)
        Me.btn_salir_movimiento.Name = "btn_salir_movimiento"
        Me.btn_salir_movimiento.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_movimiento.TabIndex = 28
        Me.btn_salir_movimiento.Text = "Salir"
        Me.btn_salir_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_movimiento.UseVisualStyleBackColor = True
        '
        'btn_generar_movimiento
        '
        Me.btn_generar_movimiento.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_movimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_movimiento.Location = New System.Drawing.Point(91, 277)
        Me.btn_generar_movimiento.Name = "btn_generar_movimiento"
        Me.btn_generar_movimiento.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_movimiento.TabIndex = 27
        Me.btn_generar_movimiento.Text = "Generar"
        Me.btn_generar_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_movimiento.UseVisualStyleBackColor = True
        '
        'btn_limpiar_movimiento
        '
        Me.btn_limpiar_movimiento.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_movimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_movimiento.Location = New System.Drawing.Point(223, 277)
        Me.btn_limpiar_movimiento.Name = "btn_limpiar_movimiento"
        Me.btn_limpiar_movimiento.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_movimiento.TabIndex = 26
        Me.btn_limpiar_movimiento.Text = "Limpiar"
        Me.btn_limpiar_movimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_movimiento.UseVisualStyleBackColor = True
        '
        'btn_est_carnicos
        '
        Me.btn_est_carnicos.BackColor = System.Drawing.Color.White
        Me.btn_est_carnicos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_carnicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_carnicos.Location = New System.Drawing.Point(536, 296)
        Me.btn_est_carnicos.Name = "btn_est_carnicos"
        Me.btn_est_carnicos.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_carnicos.TabIndex = 65
        Me.btn_est_carnicos.Text = "Exportar Estructura"
        Me.btn_est_carnicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_carnicos.UseVisualStyleBackColor = False
        '
        'btn_excel_carnicos
        '
        Me.btn_excel_carnicos.BackColor = System.Drawing.Color.White
        Me.btn_excel_carnicos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_carnicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_carnicos.Location = New System.Drawing.Point(536, 194)
        Me.btn_excel_carnicos.Name = "btn_excel_carnicos"
        Me.btn_excel_carnicos.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_carnicos.TabIndex = 50
        Me.btn_excel_carnicos.Text = "Seleccionar Archivo"
        Me.btn_excel_carnicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_carnicos.UseVisualStyleBackColor = False
        '
        'btn_plano_carnicos
        '
        Me.btn_plano_carnicos.BackColor = System.Drawing.Color.White
        Me.btn_plano_carnicos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_carnicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_carnicos.Location = New System.Drawing.Point(536, 245)
        Me.btn_plano_carnicos.Name = "btn_plano_carnicos"
        Me.btn_plano_carnicos.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_carnicos.TabIndex = 49
        Me.btn_plano_carnicos.Text = "Exportar Archivo Plano"
        Me.btn_plano_carnicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_carnicos.UseVisualStyleBackColor = False
        '
        'btn_salir_carnicos
        '
        Me.btn_salir_carnicos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_carnicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_carnicos.Location = New System.Drawing.Point(368, 288)
        Me.btn_salir_carnicos.Name = "btn_salir_carnicos"
        Me.btn_salir_carnicos.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_carnicos.TabIndex = 48
        Me.btn_salir_carnicos.Text = "Salir"
        Me.btn_salir_carnicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_carnicos.UseVisualStyleBackColor = True
        '
        'btn_carnicos
        '
        Me.btn_carnicos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_carnicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_carnicos.Location = New System.Drawing.Point(78, 288)
        Me.btn_carnicos.Name = "btn_carnicos"
        Me.btn_carnicos.Size = New System.Drawing.Size(88, 43)
        Me.btn_carnicos.TabIndex = 47
        Me.btn_carnicos.Text = "Generar"
        Me.btn_carnicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_carnicos.UseVisualStyleBackColor = True
        '
        'btn_limpiar_carnicos
        '
        Me.btn_limpiar_carnicos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_carnicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_carnicos.Location = New System.Drawing.Point(223, 288)
        Me.btn_limpiar_carnicos.Name = "btn_limpiar_carnicos"
        Me.btn_limpiar_carnicos.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_carnicos.TabIndex = 46
        Me.btn_limpiar_carnicos.Text = "Limpiar"
        Me.btn_limpiar_carnicos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_carnicos.UseVisualStyleBackColor = True
        '
        'btn_est_precios
        '
        Me.btn_est_precios.BackColor = System.Drawing.Color.White
        Me.btn_est_precios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_precios.Location = New System.Drawing.Point(536, 256)
        Me.btn_est_precios.Name = "btn_est_precios"
        Me.btn_est_precios.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_precios.TabIndex = 66
        Me.btn_est_precios.Text = "Exportar Estructura"
        Me.btn_est_precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_precios.UseVisualStyleBackColor = False
        '
        'btn_excel_precios
        '
        Me.btn_excel_precios.BackColor = System.Drawing.Color.White
        Me.btn_excel_precios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_precios.Location = New System.Drawing.Point(536, 103)
        Me.btn_excel_precios.Name = "btn_excel_precios"
        Me.btn_excel_precios.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_precios.TabIndex = 61
        Me.btn_excel_precios.Text = "Seleccionar Archivo"
        Me.btn_excel_precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_precios.UseVisualStyleBackColor = False
        '
        'btn_plano_precios
        '
        Me.btn_plano_precios.BackColor = System.Drawing.Color.White
        Me.btn_plano_precios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_precios.Location = New System.Drawing.Point(536, 168)
        Me.btn_plano_precios.Name = "btn_plano_precios"
        Me.btn_plano_precios.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_precios.TabIndex = 60
        Me.btn_plano_precios.Text = "Exportar Archivo Plano"
        Me.btn_plano_precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_precios.UseVisualStyleBackColor = False
        '
        'btn_salir_precios
        '
        Me.btn_salir_precios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_precios.Location = New System.Drawing.Point(363, 248)
        Me.btn_salir_precios.Name = "btn_salir_precios"
        Me.btn_salir_precios.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_precios.TabIndex = 59
        Me.btn_salir_precios.Text = "Salir"
        Me.btn_salir_precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_precios.UseVisualStyleBackColor = True
        '
        'btn_generar_precios
        '
        Me.btn_generar_precios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_precios.Location = New System.Drawing.Point(82, 248)
        Me.btn_generar_precios.Name = "btn_generar_precios"
        Me.btn_generar_precios.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_precios.TabIndex = 58
        Me.btn_generar_precios.Text = "Generar"
        Me.btn_generar_precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_precios.UseVisualStyleBackColor = True
        '
        'btn_limpiar_precios
        '
        Me.btn_limpiar_precios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_precios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_precios.Location = New System.Drawing.Point(223, 248)
        Me.btn_limpiar_precios.Name = "btn_limpiar_precios"
        Me.btn_limpiar_precios.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_precios.TabIndex = 57
        Me.btn_limpiar_precios.Text = "Limpiar"
        Me.btn_limpiar_precios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_precios.UseVisualStyleBackColor = True
        '
        'btn_est_pres_vend
        '
        Me.btn_est_pres_vend.BackColor = System.Drawing.Color.White
        Me.btn_est_pres_vend.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_pres_vend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_pres_vend.Location = New System.Drawing.Point(536, 264)
        Me.btn_est_pres_vend.Name = "btn_est_pres_vend"
        Me.btn_est_pres_vend.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_pres_vend.TabIndex = 79
        Me.btn_est_pres_vend.Text = "Exportar Estructura"
        Me.btn_est_pres_vend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_pres_vend.UseVisualStyleBackColor = False
        '
        'btn_excel_pres_ven
        '
        Me.btn_excel_pres_ven.BackColor = System.Drawing.Color.White
        Me.btn_excel_pres_ven.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_pres_ven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_pres_ven.Location = New System.Drawing.Point(536, 129)
        Me.btn_excel_pres_ven.Name = "btn_excel_pres_ven"
        Me.btn_excel_pres_ven.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_pres_ven.TabIndex = 70
        Me.btn_excel_pres_ven.Text = "Seleccionar Archivo"
        Me.btn_excel_pres_ven.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_pres_ven.UseVisualStyleBackColor = False
        '
        'btn_plano_pres_vend
        '
        Me.btn_plano_pres_vend.BackColor = System.Drawing.Color.White
        Me.btn_plano_pres_vend.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_pres_vend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_pres_vend.Location = New System.Drawing.Point(536, 186)
        Me.btn_plano_pres_vend.Name = "btn_plano_pres_vend"
        Me.btn_plano_pres_vend.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_pres_vend.TabIndex = 69
        Me.btn_plano_pres_vend.Text = "Exportar Archivo Plano"
        Me.btn_plano_pres_vend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_pres_vend.UseVisualStyleBackColor = False
        '
        'btn_salir_pres_vend
        '
        Me.btn_salir_pres_vend.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_pres_vend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_pres_vend.Location = New System.Drawing.Point(367, 256)
        Me.btn_salir_pres_vend.Name = "btn_salir_pres_vend"
        Me.btn_salir_pres_vend.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_pres_vend.TabIndex = 68
        Me.btn_salir_pres_vend.Text = "Salir"
        Me.btn_salir_pres_vend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_pres_vend.UseVisualStyleBackColor = True
        '
        'btn_generar_plano_pres_ven
        '
        Me.btn_generar_plano_pres_ven.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_plano_pres_ven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_plano_pres_ven.Location = New System.Drawing.Point(82, 256)
        Me.btn_generar_plano_pres_ven.Name = "btn_generar_plano_pres_ven"
        Me.btn_generar_plano_pres_ven.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_plano_pres_ven.TabIndex = 67
        Me.btn_generar_plano_pres_ven.Text = "Generar"
        Me.btn_generar_plano_pres_ven.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_plano_pres_ven.UseVisualStyleBackColor = True
        '
        'btn_limpiar_pres_ven
        '
        Me.btn_limpiar_pres_ven.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_pres_ven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_pres_ven.Location = New System.Drawing.Point(223, 256)
        Me.btn_limpiar_pres_ven.Name = "btn_limpiar_pres_ven"
        Me.btn_limpiar_pres_ven.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_pres_ven.TabIndex = 66
        Me.btn_limpiar_pres_ven.Text = "Limpiar"
        Me.btn_limpiar_pres_ven.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_pres_ven.UseVisualStyleBackColor = True
        '
        'btn_est_jefe_ventas
        '
        Me.btn_est_jefe_ventas.BackColor = System.Drawing.Color.White
        Me.btn_est_jefe_ventas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_jefe_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_jefe_ventas.Location = New System.Drawing.Point(536, 265)
        Me.btn_est_jefe_ventas.Name = "btn_est_jefe_ventas"
        Me.btn_est_jefe_ventas.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_jefe_ventas.TabIndex = 96
        Me.btn_est_jefe_ventas.Text = "Exportar Estructura"
        Me.btn_est_jefe_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_jefe_ventas.UseVisualStyleBackColor = False
        '
        'btn_excel_pres_jef
        '
        Me.btn_excel_pres_jef.BackColor = System.Drawing.Color.White
        Me.btn_excel_pres_jef.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_pres_jef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_pres_jef.Location = New System.Drawing.Point(536, 130)
        Me.btn_excel_pres_jef.Name = "btn_excel_pres_jef"
        Me.btn_excel_pres_jef.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_pres_jef.TabIndex = 87
        Me.btn_excel_pres_jef.Text = "Seleccionar Archivo"
        Me.btn_excel_pres_jef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_pres_jef.UseVisualStyleBackColor = False
        '
        'btn_plano_pres_jef
        '
        Me.btn_plano_pres_jef.BackColor = System.Drawing.Color.White
        Me.btn_plano_pres_jef.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_pres_jef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_pres_jef.Location = New System.Drawing.Point(536, 187)
        Me.btn_plano_pres_jef.Name = "btn_plano_pres_jef"
        Me.btn_plano_pres_jef.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_pres_jef.TabIndex = 86
        Me.btn_plano_pres_jef.Text = "Exportar Archivo Plano"
        Me.btn_plano_pres_jef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_pres_jef.UseVisualStyleBackColor = False
        '
        'btn_salir_pres_jef
        '
        Me.btn_salir_pres_jef.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_pres_jef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_pres_jef.Location = New System.Drawing.Point(359, 257)
        Me.btn_salir_pres_jef.Name = "btn_salir_pres_jef"
        Me.btn_salir_pres_jef.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_pres_jef.TabIndex = 85
        Me.btn_salir_pres_jef.Text = "Salir"
        Me.btn_salir_pres_jef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_pres_jef.UseVisualStyleBackColor = True
        '
        'btn_generar_plano_pres_jef
        '
        Me.btn_generar_plano_pres_jef.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_plano_pres_jef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_plano_pres_jef.Location = New System.Drawing.Point(85, 257)
        Me.btn_generar_plano_pres_jef.Name = "btn_generar_plano_pres_jef"
        Me.btn_generar_plano_pres_jef.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_plano_pres_jef.TabIndex = 84
        Me.btn_generar_plano_pres_jef.Text = "Generar"
        Me.btn_generar_plano_pres_jef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_plano_pres_jef.UseVisualStyleBackColor = True
        '
        'btn_limpiar_pres_jef
        '
        Me.btn_limpiar_pres_jef.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_pres_jef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_pres_jef.Location = New System.Drawing.Point(223, 257)
        Me.btn_limpiar_pres_jef.Name = "btn_limpiar_pres_jef"
        Me.btn_limpiar_pres_jef.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_pres_jef.TabIndex = 83
        Me.btn_limpiar_pres_jef.Text = "Limpiar"
        Me.btn_limpiar_pres_jef.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_pres_jef.UseVisualStyleBackColor = True
        '
        'btn_est_bancolombia
        '
        Me.btn_est_bancolombia.BackColor = System.Drawing.Color.White
        Me.btn_est_bancolombia.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_bancolombia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_bancolombia.Location = New System.Drawing.Point(536, 276)
        Me.btn_est_bancolombia.Name = "btn_est_bancolombia"
        Me.btn_est_bancolombia.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_bancolombia.TabIndex = 106
        Me.btn_est_bancolombia.Text = "Exportar Estructura"
        Me.btn_est_bancolombia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_bancolombia.UseVisualStyleBackColor = False
        '
        'btn_excel_bancolombia
        '
        Me.btn_excel_bancolombia.BackColor = System.Drawing.Color.White
        Me.btn_excel_bancolombia.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_bancolombia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_bancolombia.Location = New System.Drawing.Point(536, 112)
        Me.btn_excel_bancolombia.Name = "btn_excel_bancolombia"
        Me.btn_excel_bancolombia.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_bancolombia.TabIndex = 103
        Me.btn_excel_bancolombia.Text = "Seleccionar Archivo"
        Me.btn_excel_bancolombia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_bancolombia.UseVisualStyleBackColor = False
        '
        'btn_plano_bancolombia
        '
        Me.btn_plano_bancolombia.BackColor = System.Drawing.Color.White
        Me.btn_plano_bancolombia.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_bancolombia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_bancolombia.Location = New System.Drawing.Point(536, 198)
        Me.btn_plano_bancolombia.Name = "btn_plano_bancolombia"
        Me.btn_plano_bancolombia.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_bancolombia.TabIndex = 102
        Me.btn_plano_bancolombia.Text = "Exportar Archivo Plano"
        Me.btn_plano_bancolombia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_bancolombia.UseVisualStyleBackColor = False
        '
        'btn_salir_bancolombia
        '
        Me.btn_salir_bancolombia.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_bancolombia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_bancolombia.Location = New System.Drawing.Point(362, 268)
        Me.btn_salir_bancolombia.Name = "btn_salir_bancolombia"
        Me.btn_salir_bancolombia.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_bancolombia.TabIndex = 101
        Me.btn_salir_bancolombia.Text = "Salir"
        Me.btn_salir_bancolombia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_bancolombia.UseVisualStyleBackColor = True
        '
        'btn_generar_bancolombia
        '
        Me.btn_generar_bancolombia.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_bancolombia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_bancolombia.Location = New System.Drawing.Point(85, 268)
        Me.btn_generar_bancolombia.Name = "btn_generar_bancolombia"
        Me.btn_generar_bancolombia.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_bancolombia.TabIndex = 100
        Me.btn_generar_bancolombia.Text = "Generar"
        Me.btn_generar_bancolombia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_bancolombia.UseVisualStyleBackColor = True
        '
        'btn_limpiar_bancolombia
        '
        Me.btn_limpiar_bancolombia.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_bancolombia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_bancolombia.Location = New System.Drawing.Point(223, 268)
        Me.btn_limpiar_bancolombia.Name = "btn_limpiar_bancolombia"
        Me.btn_limpiar_bancolombia.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_bancolombia.TabIndex = 99
        Me.btn_limpiar_bancolombia.Text = "Limpiar"
        Me.btn_limpiar_bancolombia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_bancolombia.UseVisualStyleBackColor = True
        '
        'btn_est_bancobogota
        '
        Me.btn_est_bancobogota.BackColor = System.Drawing.Color.White
        Me.btn_est_bancobogota.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_bancobogota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_bancobogota.Location = New System.Drawing.Point(536, 276)
        Me.btn_est_bancobogota.Name = "btn_est_bancobogota"
        Me.btn_est_bancobogota.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_bancobogota.TabIndex = 116
        Me.btn_est_bancobogota.Text = "Exportar Estructura"
        Me.btn_est_bancobogota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_bancobogota.UseVisualStyleBackColor = False
        '
        'btn_excel_bogota
        '
        Me.btn_excel_bogota.BackColor = System.Drawing.Color.White
        Me.btn_excel_bogota.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_excel_bogota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_excel_bogota.Location = New System.Drawing.Point(536, 112)
        Me.btn_excel_bogota.Name = "btn_excel_bogota"
        Me.btn_excel_bogota.Size = New System.Drawing.Size(147, 35)
        Me.btn_excel_bogota.TabIndex = 113
        Me.btn_excel_bogota.Text = "Seleccionar Archivo"
        Me.btn_excel_bogota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_excel_bogota.UseVisualStyleBackColor = False
        '
        'btn_plano_bogota
        '
        Me.btn_plano_bogota.BackColor = System.Drawing.Color.White
        Me.btn_plano_bogota.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_bogota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_bogota.Location = New System.Drawing.Point(536, 198)
        Me.btn_plano_bogota.Name = "btn_plano_bogota"
        Me.btn_plano_bogota.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_bogota.TabIndex = 112
        Me.btn_plano_bogota.Text = "Exportar Archivo Plano"
        Me.btn_plano_bogota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_bogota.UseVisualStyleBackColor = False
        '
        'btn_salir_bogota
        '
        Me.btn_salir_bogota.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_bogota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_bogota.Location = New System.Drawing.Point(364, 268)
        Me.btn_salir_bogota.Name = "btn_salir_bogota"
        Me.btn_salir_bogota.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_bogota.TabIndex = 111
        Me.btn_salir_bogota.Text = "Salir"
        Me.btn_salir_bogota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_bogota.UseVisualStyleBackColor = True
        '
        'btn_generar_bogota
        '
        Me.btn_generar_bogota.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_bogota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_bogota.Location = New System.Drawing.Point(80, 268)
        Me.btn_generar_bogota.Name = "btn_generar_bogota"
        Me.btn_generar_bogota.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_bogota.TabIndex = 110
        Me.btn_generar_bogota.Text = "Generar"
        Me.btn_generar_bogota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_bogota.UseVisualStyleBackColor = True
        '
        'btn_limpiar_bogota
        '
        Me.btn_limpiar_bogota.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_bogota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_bogota.Location = New System.Drawing.Point(223, 268)
        Me.btn_limpiar_bogota.Name = "btn_limpiar_bogota"
        Me.btn_limpiar_bogota.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_bogota.TabIndex = 109
        Me.btn_limpiar_bogota.Text = "Limpiar"
        Me.btn_limpiar_bogota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_bogota.UseVisualStyleBackColor = True
        '
        'btn_est_items
        '
        Me.btn_est_items.BackColor = System.Drawing.Color.White
        Me.btn_est_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_items.Location = New System.Drawing.Point(536, 276)
        Me.btn_est_items.Name = "btn_est_items"
        Me.btn_est_items.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_items.TabIndex = 127
        Me.btn_est_items.Text = "Exportar Estructura"
        Me.btn_est_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_items.UseVisualStyleBackColor = False
        '
        'btn_csv_items
        '
        Me.btn_csv_items.BackColor = System.Drawing.Color.White
        Me.btn_csv_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_items.Location = New System.Drawing.Point(536, 112)
        Me.btn_csv_items.Name = "btn_csv_items"
        Me.btn_csv_items.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_items.TabIndex = 125
        Me.btn_csv_items.Text = "Seleccionar Archivo"
        Me.btn_csv_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_items.UseVisualStyleBackColor = False
        '
        'btn_plano_items
        '
        Me.btn_plano_items.BackColor = System.Drawing.Color.White
        Me.btn_plano_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_items.Location = New System.Drawing.Point(536, 198)
        Me.btn_plano_items.Name = "btn_plano_items"
        Me.btn_plano_items.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_items.TabIndex = 124
        Me.btn_plano_items.Text = "Exportar Archivo Plano"
        Me.btn_plano_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_items.UseVisualStyleBackColor = False
        '
        'btn_salir_items
        '
        Me.btn_salir_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_items.Location = New System.Drawing.Point(364, 268)
        Me.btn_salir_items.Name = "btn_salir_items"
        Me.btn_salir_items.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_items.TabIndex = 123
        Me.btn_salir_items.Text = "Salir"
        Me.btn_salir_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_items.UseVisualStyleBackColor = True
        '
        'btn_generar_items
        '
        Me.btn_generar_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_items.Location = New System.Drawing.Point(80, 268)
        Me.btn_generar_items.Name = "btn_generar_items"
        Me.btn_generar_items.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_items.TabIndex = 122
        Me.btn_generar_items.Text = "Generar"
        Me.btn_generar_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_items.UseVisualStyleBackColor = True
        '
        'btn_limpiar_items
        '
        Me.btn_limpiar_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_items.Location = New System.Drawing.Point(223, 268)
        Me.btn_limpiar_items.Name = "btn_limpiar_items"
        Me.btn_limpiar_items.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_items.TabIndex = 121
        Me.btn_limpiar_items.Text = "Limpiar"
        Me.btn_limpiar_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_items.UseVisualStyleBackColor = True
        '
        'btn_est_act_items
        '
        Me.btn_est_act_items.BackColor = System.Drawing.Color.White
        Me.btn_est_act_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_act_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_act_items.Location = New System.Drawing.Point(536, 278)
        Me.btn_est_act_items.Name = "btn_est_act_items"
        Me.btn_est_act_items.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_act_items.TabIndex = 138
        Me.btn_est_act_items.Text = "Exportar Estructura"
        Me.btn_est_act_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_act_items.UseVisualStyleBackColor = False
        '
        'btn_csv_act_items
        '
        Me.btn_csv_act_items.BackColor = System.Drawing.Color.White
        Me.btn_csv_act_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_act_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_act_items.Location = New System.Drawing.Point(536, 114)
        Me.btn_csv_act_items.Name = "btn_csv_act_items"
        Me.btn_csv_act_items.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_act_items.TabIndex = 136
        Me.btn_csv_act_items.Text = "Seleccionar Archivo"
        Me.btn_csv_act_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_act_items.UseVisualStyleBackColor = False
        '
        'btn_plano_act_items
        '
        Me.btn_plano_act_items.BackColor = System.Drawing.Color.White
        Me.btn_plano_act_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_act_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_act_items.Location = New System.Drawing.Point(536, 200)
        Me.btn_plano_act_items.Name = "btn_plano_act_items"
        Me.btn_plano_act_items.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_act_items.TabIndex = 135
        Me.btn_plano_act_items.Text = "Exportar Archivo Plano"
        Me.btn_plano_act_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_act_items.UseVisualStyleBackColor = False
        '
        'btn_salir_act_items
        '
        Me.btn_salir_act_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_act_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_act_items.Location = New System.Drawing.Point(364, 270)
        Me.btn_salir_act_items.Name = "btn_salir_act_items"
        Me.btn_salir_act_items.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_act_items.TabIndex = 134
        Me.btn_salir_act_items.Text = "Salir"
        Me.btn_salir_act_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_act_items.UseVisualStyleBackColor = True
        '
        'btn_generar_act_items
        '
        Me.btn_generar_act_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_act_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_act_items.Location = New System.Drawing.Point(80, 270)
        Me.btn_generar_act_items.Name = "btn_generar_act_items"
        Me.btn_generar_act_items.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_act_items.TabIndex = 133
        Me.btn_generar_act_items.Text = "Generar"
        Me.btn_generar_act_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_act_items.UseVisualStyleBackColor = True
        '
        'btn_limpiar_act_items
        '
        Me.btn_limpiar_act_items.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_act_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_act_items.Location = New System.Drawing.Point(223, 270)
        Me.btn_limpiar_act_items.Name = "btn_limpiar_act_items"
        Me.btn_limpiar_act_items.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_act_items.TabIndex = 132
        Me.btn_limpiar_act_items.Text = "Limpiar"
        Me.btn_limpiar_act_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_act_items.UseVisualStyleBackColor = True
        '
        'btn_est_clasitems
        '
        Me.btn_est_clasitems.BackColor = System.Drawing.Color.White
        Me.btn_est_clasitems.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_clasitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_clasitems.Location = New System.Drawing.Point(536, 278)
        Me.btn_est_clasitems.Name = "btn_est_clasitems"
        Me.btn_est_clasitems.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_clasitems.TabIndex = 138
        Me.btn_est_clasitems.Text = "Exportar Estructura"
        Me.btn_est_clasitems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_clasitems.UseVisualStyleBackColor = False
        '
        'btn_csv_clasitems
        '
        Me.btn_csv_clasitems.BackColor = System.Drawing.Color.White
        Me.btn_csv_clasitems.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_clasitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_clasitems.Location = New System.Drawing.Point(536, 114)
        Me.btn_csv_clasitems.Name = "btn_csv_clasitems"
        Me.btn_csv_clasitems.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_clasitems.TabIndex = 136
        Me.btn_csv_clasitems.Text = "Seleccionar Archivo"
        Me.btn_csv_clasitems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_clasitems.UseVisualStyleBackColor = False
        '
        'btn_plano_clasitems
        '
        Me.btn_plano_clasitems.BackColor = System.Drawing.Color.White
        Me.btn_plano_clasitems.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_clasitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_clasitems.Location = New System.Drawing.Point(536, 200)
        Me.btn_plano_clasitems.Name = "btn_plano_clasitems"
        Me.btn_plano_clasitems.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_clasitems.TabIndex = 135
        Me.btn_plano_clasitems.Text = "Exportar Archivo Plano"
        Me.btn_plano_clasitems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_clasitems.UseVisualStyleBackColor = False
        '
        'btn_salir_clasitems
        '
        Me.btn_salir_clasitems.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_clasitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_clasitems.Location = New System.Drawing.Point(364, 270)
        Me.btn_salir_clasitems.Name = "btn_salir_clasitems"
        Me.btn_salir_clasitems.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_clasitems.TabIndex = 134
        Me.btn_salir_clasitems.Text = "Salir"
        Me.btn_salir_clasitems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_clasitems.UseVisualStyleBackColor = True
        '
        'btn_generar_clasitems
        '
        Me.btn_generar_clasitems.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_clasitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_clasitems.Location = New System.Drawing.Point(80, 270)
        Me.btn_generar_clasitems.Name = "btn_generar_clasitems"
        Me.btn_generar_clasitems.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_clasitems.TabIndex = 133
        Me.btn_generar_clasitems.Text = "Generar"
        Me.btn_generar_clasitems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_clasitems.UseVisualStyleBackColor = True
        '
        'btn_limpiar_clasitems
        '
        Me.btn_limpiar_clasitems.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_clasitems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_clasitems.Location = New System.Drawing.Point(223, 270)
        Me.btn_limpiar_clasitems.Name = "btn_limpiar_clasitems"
        Me.btn_limpiar_clasitems.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_clasitems.TabIndex = 132
        Me.btn_limpiar_clasitems.Text = "Limpiar"
        Me.btn_limpiar_clasitems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_clasitems.UseVisualStyleBackColor = True
        '
        'btn_est_sol_compra
        '
        Me.btn_est_sol_compra.BackColor = System.Drawing.Color.White
        Me.btn_est_sol_compra.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_sol_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_sol_compra.Location = New System.Drawing.Point(536, 287)
        Me.btn_est_sol_compra.Name = "btn_est_sol_compra"
        Me.btn_est_sol_compra.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_sol_compra.TabIndex = 87
        Me.btn_est_sol_compra.Text = "Exportar Estructura"
        Me.btn_est_sol_compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_sol_compra.UseVisualStyleBackColor = False
        '
        'btn_csv_sol_compra
        '
        Me.btn_csv_sol_compra.BackColor = System.Drawing.Color.White
        Me.btn_csv_sol_compra.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_sol_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_sol_compra.Location = New System.Drawing.Point(536, 185)
        Me.btn_csv_sol_compra.Name = "btn_csv_sol_compra"
        Me.btn_csv_sol_compra.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_sol_compra.TabIndex = 77
        Me.btn_csv_sol_compra.Text = "Seleccionar Archivo"
        Me.btn_csv_sol_compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_sol_compra.UseVisualStyleBackColor = False
        '
        'btn_plano_sol_compra
        '
        Me.btn_plano_sol_compra.BackColor = System.Drawing.Color.White
        Me.btn_plano_sol_compra.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_sol_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_sol_compra.Location = New System.Drawing.Point(536, 236)
        Me.btn_plano_sol_compra.Name = "btn_plano_sol_compra"
        Me.btn_plano_sol_compra.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_sol_compra.TabIndex = 76
        Me.btn_plano_sol_compra.Text = "Exportar Archivo Plano"
        Me.btn_plano_sol_compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_sol_compra.UseVisualStyleBackColor = False
        '
        'btn_salir_sol_compras
        '
        Me.btn_salir_sol_compras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_sol_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_sol_compras.Location = New System.Drawing.Point(356, 279)
        Me.btn_salir_sol_compras.Name = "btn_salir_sol_compras"
        Me.btn_salir_sol_compras.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_sol_compras.TabIndex = 75
        Me.btn_salir_sol_compras.Text = "Salir"
        Me.btn_salir_sol_compras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_sol_compras.UseVisualStyleBackColor = True
        '
        'Btn_generar_sol_compras
        '
        Me.Btn_generar_sol_compras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.Btn_generar_sol_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_generar_sol_compras.Location = New System.Drawing.Point(91, 279)
        Me.Btn_generar_sol_compras.Name = "Btn_generar_sol_compras"
        Me.Btn_generar_sol_compras.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_generar_sol_compras.Size = New System.Drawing.Size(88, 43)
        Me.Btn_generar_sol_compras.TabIndex = 74
        Me.Btn_generar_sol_compras.Text = "Generar"
        Me.Btn_generar_sol_compras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_generar_sol_compras.UseVisualStyleBackColor = True
        '
        'btn_limpiar_sol_compra
        '
        Me.btn_limpiar_sol_compra.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_sol_compra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_sol_compra.Location = New System.Drawing.Point(223, 279)
        Me.btn_limpiar_sol_compra.Name = "btn_limpiar_sol_compra"
        Me.btn_limpiar_sol_compra.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_sol_compra.TabIndex = 73
        Me.btn_limpiar_sol_compra.Text = "Limpiar"
        Me.btn_limpiar_sol_compra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_sol_compra.UseVisualStyleBackColor = True
        '
        'btn_est_criterios
        '
        Me.btn_est_criterios.BackColor = System.Drawing.Color.White
        Me.btn_est_criterios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_criterios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_criterios.Location = New System.Drawing.Point(536, 279)
        Me.btn_est_criterios.Name = "btn_est_criterios"
        Me.btn_est_criterios.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_criterios.TabIndex = 149
        Me.btn_est_criterios.Text = "Exportar Estructura"
        Me.btn_est_criterios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_criterios.UseVisualStyleBackColor = False
        '
        'btn_csv_criterios
        '
        Me.btn_csv_criterios.BackColor = System.Drawing.Color.White
        Me.btn_csv_criterios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_criterios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_criterios.Location = New System.Drawing.Point(536, 115)
        Me.btn_csv_criterios.Name = "btn_csv_criterios"
        Me.btn_csv_criterios.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_criterios.TabIndex = 147
        Me.btn_csv_criterios.Text = "Seleccionar Archivo"
        Me.btn_csv_criterios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_criterios.UseVisualStyleBackColor = False
        '
        'btn_plano_criterios
        '
        Me.btn_plano_criterios.BackColor = System.Drawing.Color.White
        Me.btn_plano_criterios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_criterios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_criterios.Location = New System.Drawing.Point(536, 201)
        Me.btn_plano_criterios.Name = "btn_plano_criterios"
        Me.btn_plano_criterios.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_criterios.TabIndex = 146
        Me.btn_plano_criterios.Text = "Exportar Archivo Plano"
        Me.btn_plano_criterios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_criterios.UseVisualStyleBackColor = False
        '
        'btn_salir_criterios
        '
        Me.btn_salir_criterios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_criterios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_criterios.Location = New System.Drawing.Point(364, 271)
        Me.btn_salir_criterios.Name = "btn_salir_criterios"
        Me.btn_salir_criterios.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_criterios.TabIndex = 145
        Me.btn_salir_criterios.Text = "Salir"
        Me.btn_salir_criterios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_criterios.UseVisualStyleBackColor = True
        '
        'btn_generar_criterios
        '
        Me.btn_generar_criterios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_criterios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_criterios.Location = New System.Drawing.Point(80, 271)
        Me.btn_generar_criterios.Name = "btn_generar_criterios"
        Me.btn_generar_criterios.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_criterios.TabIndex = 144
        Me.btn_generar_criterios.Text = "Generar"
        Me.btn_generar_criterios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_criterios.UseVisualStyleBackColor = True
        '
        'btn_limipiar_criterios
        '
        Me.btn_limipiar_criterios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limipiar_criterios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limipiar_criterios.Location = New System.Drawing.Point(223, 271)
        Me.btn_limipiar_criterios.Name = "btn_limipiar_criterios"
        Me.btn_limipiar_criterios.Size = New System.Drawing.Size(88, 43)
        Me.btn_limipiar_criterios.TabIndex = 143
        Me.btn_limipiar_criterios.Text = "Limpiar"
        Me.btn_limipiar_criterios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limipiar_criterios.UseVisualStyleBackColor = True
        '
        'btn_est_bajas
        '
        Me.btn_est_bajas.BackColor = System.Drawing.Color.White
        Me.btn_est_bajas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_bajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_bajas.Location = New System.Drawing.Point(535, 288)
        Me.btn_est_bajas.Name = "btn_est_bajas"
        Me.btn_est_bajas.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_bajas.TabIndex = 107
        Me.btn_est_bajas.Text = "Exportar Estructura"
        Me.btn_est_bajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_bajas.UseVisualStyleBackColor = False
        '
        'btn_csv_bajas
        '
        Me.btn_csv_bajas.BackColor = System.Drawing.Color.White
        Me.btn_csv_bajas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_bajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_bajas.Location = New System.Drawing.Point(535, 178)
        Me.btn_csv_bajas.Name = "btn_csv_bajas"
        Me.btn_csv_bajas.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_bajas.TabIndex = 98
        Me.btn_csv_bajas.Text = "Seleccionar Archivo"
        Me.btn_csv_bajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_bajas.UseVisualStyleBackColor = False
        '
        'btn_planos_bajas
        '
        Me.btn_planos_bajas.BackColor = System.Drawing.Color.White
        Me.btn_planos_bajas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_planos_bajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_planos_bajas.Location = New System.Drawing.Point(535, 229)
        Me.btn_planos_bajas.Name = "btn_planos_bajas"
        Me.btn_planos_bajas.Size = New System.Drawing.Size(147, 35)
        Me.btn_planos_bajas.TabIndex = 97
        Me.btn_planos_bajas.Text = "Exportar Archivo Plano"
        Me.btn_planos_bajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_planos_bajas.UseVisualStyleBackColor = False
        '
        'btn_salir_bajas
        '
        Me.btn_salir_bajas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_bajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_bajas.Location = New System.Drawing.Point(355, 280)
        Me.btn_salir_bajas.Name = "btn_salir_bajas"
        Me.btn_salir_bajas.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_bajas.TabIndex = 96
        Me.btn_salir_bajas.Text = "Salir"
        Me.btn_salir_bajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_bajas.UseVisualStyleBackColor = True
        '
        'btn_generar_bajas
        '
        Me.btn_generar_bajas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_bajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_bajas.Location = New System.Drawing.Point(90, 280)
        Me.btn_generar_bajas.Name = "btn_generar_bajas"
        Me.btn_generar_bajas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_generar_bajas.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_bajas.TabIndex = 95
        Me.btn_generar_bajas.Text = "Generar"
        Me.btn_generar_bajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_bajas.UseVisualStyleBackColor = True
        '
        'btn_limpiar_bajas
        '
        Me.btn_limpiar_bajas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_bajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_bajas.Location = New System.Drawing.Point(222, 280)
        Me.btn_limpiar_bajas.Name = "btn_limpiar_bajas"
        Me.btn_limpiar_bajas.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_bajas.TabIndex = 94
        Me.btn_limpiar_bajas.Text = "Limpiar"
        Me.btn_limpiar_bajas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_bajas.UseVisualStyleBackColor = True
        '
        'btn_est_cuentas
        '
        Me.btn_est_cuentas.BackColor = System.Drawing.Color.White
        Me.btn_est_cuentas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_cuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_cuentas.Location = New System.Drawing.Point(536, 275)
        Me.btn_est_cuentas.Name = "btn_est_cuentas"
        Me.btn_est_cuentas.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_cuentas.TabIndex = 88
        Me.btn_est_cuentas.Text = "Exportar Estructura"
        Me.btn_est_cuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_cuentas.UseVisualStyleBackColor = False
        '
        'btn_csv_cuentas
        '
        Me.btn_csv_cuentas.BackColor = System.Drawing.Color.White
        Me.btn_csv_cuentas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_cuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_cuentas.Location = New System.Drawing.Point(536, 159)
        Me.btn_csv_cuentas.Name = "btn_csv_cuentas"
        Me.btn_csv_cuentas.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_cuentas.TabIndex = 74
        Me.btn_csv_cuentas.Text = "Seleccionar Archivo"
        Me.btn_csv_cuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_cuentas.UseVisualStyleBackColor = False
        '
        'btn_plano_cuentas
        '
        Me.btn_plano_cuentas.BackColor = System.Drawing.Color.White
        Me.btn_plano_cuentas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_cuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_cuentas.Location = New System.Drawing.Point(536, 210)
        Me.btn_plano_cuentas.Name = "btn_plano_cuentas"
        Me.btn_plano_cuentas.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_cuentas.TabIndex = 73
        Me.btn_plano_cuentas.Text = "Exportar Archivo Plano"
        Me.btn_plano_cuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_cuentas.UseVisualStyleBackColor = False
        '
        'btn_salir_cuentas
        '
        Me.btn_salir_cuentas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_cuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_cuentas.Location = New System.Drawing.Point(368, 267)
        Me.btn_salir_cuentas.Name = "btn_salir_cuentas"
        Me.btn_salir_cuentas.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_cuentas.TabIndex = 72
        Me.btn_salir_cuentas.Text = "Salir"
        Me.btn_salir_cuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_cuentas.UseVisualStyleBackColor = True
        '
        'btn_generar_cuentas
        '
        Me.btn_generar_cuentas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_cuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_cuentas.Location = New System.Drawing.Point(78, 267)
        Me.btn_generar_cuentas.Name = "btn_generar_cuentas"
        Me.btn_generar_cuentas.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_cuentas.TabIndex = 71
        Me.btn_generar_cuentas.Text = "Generar"
        Me.btn_generar_cuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_cuentas.UseVisualStyleBackColor = True
        '
        'btn_limpiar_cuentas
        '
        Me.btn_limpiar_cuentas.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_cuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_cuentas.Location = New System.Drawing.Point(223, 267)
        Me.btn_limpiar_cuentas.Name = "btn_limpiar_cuentas"
        Me.btn_limpiar_cuentas.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_cuentas.TabIndex = 70
        Me.btn_limpiar_cuentas.Text = "Limpiar"
        Me.btn_limpiar_cuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_cuentas.UseVisualStyleBackColor = True
        '
        'btn_est_traslados
        '
        Me.btn_est_traslados.BackColor = System.Drawing.Color.White
        Me.btn_est_traslados.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_traslados.Location = New System.Drawing.Point(536, 284)
        Me.btn_est_traslados.Name = "btn_est_traslados"
        Me.btn_est_traslados.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_traslados.TabIndex = 107
        Me.btn_est_traslados.Text = "Exportar Estructura"
        Me.btn_est_traslados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_traslados.UseVisualStyleBackColor = False
        '
        'btn_traslados
        '
        Me.btn_traslados.BackColor = System.Drawing.Color.White
        Me.btn_traslados.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_traslados.Location = New System.Drawing.Point(536, 168)
        Me.btn_traslados.Name = "btn_traslados"
        Me.btn_traslados.Size = New System.Drawing.Size(147, 35)
        Me.btn_traslados.TabIndex = 97
        Me.btn_traslados.Text = "Seleccionar Archivo"
        Me.btn_traslados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_traslados.UseVisualStyleBackColor = False
        '
        'btn_plano_traslados
        '
        Me.btn_plano_traslados.BackColor = System.Drawing.Color.White
        Me.btn_plano_traslados.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_traslados.Location = New System.Drawing.Point(536, 219)
        Me.btn_plano_traslados.Name = "btn_plano_traslados"
        Me.btn_plano_traslados.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_traslados.TabIndex = 96
        Me.btn_plano_traslados.Text = "Exportar Archivo Plano"
        Me.btn_plano_traslados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_traslados.UseVisualStyleBackColor = False
        '
        'btn_salir_traslados
        '
        Me.btn_salir_traslados.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_traslados.Location = New System.Drawing.Point(368, 276)
        Me.btn_salir_traslados.Name = "btn_salir_traslados"
        Me.btn_salir_traslados.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_traslados.TabIndex = 95
        Me.btn_salir_traslados.Text = "Salir"
        Me.btn_salir_traslados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_traslados.UseVisualStyleBackColor = True
        '
        'btn_generar_traslados
        '
        Me.btn_generar_traslados.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_traslados.Location = New System.Drawing.Point(78, 276)
        Me.btn_generar_traslados.Name = "btn_generar_traslados"
        Me.btn_generar_traslados.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_traslados.TabIndex = 94
        Me.btn_generar_traslados.Text = "Generar"
        Me.btn_generar_traslados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_traslados.UseVisualStyleBackColor = True
        '
        'btn_limpiar_traslados
        '
        Me.btn_limpiar_traslados.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_traslados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_traslados.Location = New System.Drawing.Point(223, 276)
        Me.btn_limpiar_traslados.Name = "btn_limpiar_traslados"
        Me.btn_limpiar_traslados.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_traslados.TabIndex = 93
        Me.btn_limpiar_traslados.Text = "Limpiar"
        Me.btn_limpiar_traslados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_traslados.UseVisualStyleBackColor = True
        '
        'btn_est_codigobarras
        '
        Me.btn_est_codigobarras.BackColor = System.Drawing.Color.White
        Me.btn_est_codigobarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_codigobarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_codigobarras.Location = New System.Drawing.Point(536, 278)
        Me.btn_est_codigobarras.Name = "btn_est_codigobarras"
        Me.btn_est_codigobarras.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_codigobarras.TabIndex = 138
        Me.btn_est_codigobarras.Text = "Exportar Estructura"
        Me.btn_est_codigobarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_codigobarras.UseVisualStyleBackColor = False
        '
        'btn_codigobarras
        '
        Me.btn_codigobarras.BackColor = System.Drawing.Color.White
        Me.btn_codigobarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_codigobarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_codigobarras.Location = New System.Drawing.Point(536, 114)
        Me.btn_codigobarras.Name = "btn_codigobarras"
        Me.btn_codigobarras.Size = New System.Drawing.Size(147, 35)
        Me.btn_codigobarras.TabIndex = 136
        Me.btn_codigobarras.Text = "Seleccionar Archivo"
        Me.btn_codigobarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_codigobarras.UseVisualStyleBackColor = False
        '
        'btn_planocodigobarras
        '
        Me.btn_planocodigobarras.BackColor = System.Drawing.Color.White
        Me.btn_planocodigobarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_planocodigobarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_planocodigobarras.Location = New System.Drawing.Point(536, 200)
        Me.btn_planocodigobarras.Name = "btn_planocodigobarras"
        Me.btn_planocodigobarras.Size = New System.Drawing.Size(147, 35)
        Me.btn_planocodigobarras.TabIndex = 135
        Me.btn_planocodigobarras.Text = "Exportar Archivo Plano"
        Me.btn_planocodigobarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_planocodigobarras.UseVisualStyleBackColor = False
        '
        'btn_salircodigobarras
        '
        Me.btn_salircodigobarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salircodigobarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salircodigobarras.Location = New System.Drawing.Point(364, 270)
        Me.btn_salircodigobarras.Name = "btn_salircodigobarras"
        Me.btn_salircodigobarras.Size = New System.Drawing.Size(88, 43)
        Me.btn_salircodigobarras.TabIndex = 134
        Me.btn_salircodigobarras.Text = "Salir"
        Me.btn_salircodigobarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salircodigobarras.UseVisualStyleBackColor = True
        '
        'btn_generarcodigobarras
        '
        Me.btn_generarcodigobarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generarcodigobarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generarcodigobarras.Location = New System.Drawing.Point(80, 270)
        Me.btn_generarcodigobarras.Name = "btn_generarcodigobarras"
        Me.btn_generarcodigobarras.Size = New System.Drawing.Size(88, 43)
        Me.btn_generarcodigobarras.TabIndex = 133
        Me.btn_generarcodigobarras.Text = "Generar"
        Me.btn_generarcodigobarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generarcodigobarras.UseVisualStyleBackColor = True
        '
        'btn_limpiarcodigobarras
        '
        Me.btn_limpiarcodigobarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiarcodigobarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiarcodigobarras.Location = New System.Drawing.Point(223, 270)
        Me.btn_limpiarcodigobarras.Name = "btn_limpiarcodigobarras"
        Me.btn_limpiarcodigobarras.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiarcodigobarras.TabIndex = 132
        Me.btn_limpiarcodigobarras.Text = "Limpiar"
        Me.btn_limpiarcodigobarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiarcodigobarras.UseVisualStyleBackColor = True
        '
        'btn_est_inv
        '
        Me.btn_est_inv.BackColor = System.Drawing.Color.White
        Me.btn_est_inv.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_est_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_est_inv.Location = New System.Drawing.Point(536, 300)
        Me.btn_est_inv.Name = "btn_est_inv"
        Me.btn_est_inv.Size = New System.Drawing.Size(147, 35)
        Me.btn_est_inv.TabIndex = 126
        Me.btn_est_inv.Text = "Exportar Estructura"
        Me.btn_est_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_est_inv.UseVisualStyleBackColor = False
        '
        'btn_csv_inv
        '
        Me.btn_csv_inv.BackColor = System.Drawing.Color.White
        Me.btn_csv_inv.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_csv_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_csv_inv.Location = New System.Drawing.Point(536, 204)
        Me.btn_csv_inv.Name = "btn_csv_inv"
        Me.btn_csv_inv.Size = New System.Drawing.Size(147, 35)
        Me.btn_csv_inv.TabIndex = 116
        Me.btn_csv_inv.Text = "Seleccionar Archivo"
        Me.btn_csv_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_csv_inv.UseVisualStyleBackColor = False
        '
        'btn_plano_inv
        '
        Me.btn_plano_inv.BackColor = System.Drawing.Color.White
        Me.btn_plano_inv.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_plano_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_plano_inv.Location = New System.Drawing.Point(536, 255)
        Me.btn_plano_inv.Name = "btn_plano_inv"
        Me.btn_plano_inv.Size = New System.Drawing.Size(147, 35)
        Me.btn_plano_inv.TabIndex = 115
        Me.btn_plano_inv.Text = "Exportar Archivo Plano"
        Me.btn_plano_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_plano_inv.UseVisualStyleBackColor = False
        '
        'btn_salir_inv
        '
        Me.btn_salir_inv.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_inv.Location = New System.Drawing.Point(368, 292)
        Me.btn_salir_inv.Name = "btn_salir_inv"
        Me.btn_salir_inv.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_inv.TabIndex = 114
        Me.btn_salir_inv.Text = "Salir"
        Me.btn_salir_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_inv.UseVisualStyleBackColor = True
        '
        'btn_generar_inv
        '
        Me.btn_generar_inv.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_inv.Location = New System.Drawing.Point(78, 292)
        Me.btn_generar_inv.Name = "btn_generar_inv"
        Me.btn_generar_inv.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_inv.TabIndex = 113
        Me.btn_generar_inv.Text = "Generar"
        Me.btn_generar_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_inv.UseVisualStyleBackColor = True
        '
        'btn_limpiar_inv
        '
        Me.btn_limpiar_inv.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_inv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_inv.Location = New System.Drawing.Point(223, 292)
        Me.btn_limpiar_inv.Name = "btn_limpiar_inv"
        Me.btn_limpiar_inv.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_inv.TabIndex = 112
        Me.btn_limpiar_inv.Text = "Limpiar"
        Me.btn_limpiar_inv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_inv.UseVisualStyleBackColor = True
        '
        'csv_est_entidades_proveedores
        '
        Me.csv_est_entidades_proveedores.BackColor = System.Drawing.Color.White
        Me.csv_est_entidades_proveedores.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.csv_est_entidades_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.csv_est_entidades_proveedores.Location = New System.Drawing.Point(536, 280)
        Me.csv_est_entidades_proveedores.Name = "csv_est_entidades_proveedores"
        Me.csv_est_entidades_proveedores.Size = New System.Drawing.Size(147, 35)
        Me.csv_est_entidades_proveedores.TabIndex = 149
        Me.csv_est_entidades_proveedores.Text = "Exportar Estructura"
        Me.csv_est_entidades_proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.csv_est_entidades_proveedores.UseVisualStyleBackColor = False
        '
        'btn_seleccionar_proveedor_csv
        '
        Me.btn_seleccionar_proveedor_csv.BackColor = System.Drawing.Color.White
        Me.btn_seleccionar_proveedor_csv.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_seleccionar_proveedor_csv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar_proveedor_csv.Location = New System.Drawing.Point(536, 116)
        Me.btn_seleccionar_proveedor_csv.Name = "btn_seleccionar_proveedor_csv"
        Me.btn_seleccionar_proveedor_csv.Size = New System.Drawing.Size(147, 35)
        Me.btn_seleccionar_proveedor_csv.TabIndex = 147
        Me.btn_seleccionar_proveedor_csv.Text = "Seleccionar Archivo"
        Me.btn_seleccionar_proveedor_csv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar_proveedor_csv.UseVisualStyleBackColor = False
        '
        'btn_generar_plano_proveedor
        '
        Me.btn_generar_plano_proveedor.BackColor = System.Drawing.Color.White
        Me.btn_generar_plano_proveedor.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_generar_plano_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_plano_proveedor.Location = New System.Drawing.Point(536, 202)
        Me.btn_generar_plano_proveedor.Name = "btn_generar_plano_proveedor"
        Me.btn_generar_plano_proveedor.Size = New System.Drawing.Size(147, 35)
        Me.btn_generar_plano_proveedor.TabIndex = 146
        Me.btn_generar_plano_proveedor.Text = "Exportar Archivo Plano"
        Me.btn_generar_plano_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_plano_proveedor.UseVisualStyleBackColor = False
        '
        'btn_salir_entidades_proveedores
        '
        Me.btn_salir_entidades_proveedores.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_entidades_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_entidades_proveedores.Location = New System.Drawing.Point(364, 272)
        Me.btn_salir_entidades_proveedores.Name = "btn_salir_entidades_proveedores"
        Me.btn_salir_entidades_proveedores.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_entidades_proveedores.TabIndex = 145
        Me.btn_salir_entidades_proveedores.Text = "Salir"
        Me.btn_salir_entidades_proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_entidades_proveedores.UseVisualStyleBackColor = True
        '
        'btn_generar_entidades_proveedores
        '
        Me.btn_generar_entidades_proveedores.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_entidades_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_entidades_proveedores.Location = New System.Drawing.Point(80, 272)
        Me.btn_generar_entidades_proveedores.Name = "btn_generar_entidades_proveedores"
        Me.btn_generar_entidades_proveedores.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_entidades_proveedores.TabIndex = 144
        Me.btn_generar_entidades_proveedores.Text = "Generar"
        Me.btn_generar_entidades_proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_entidades_proveedores.UseVisualStyleBackColor = True
        '
        'btn_limpiar_entidades_proveedores
        '
        Me.btn_limpiar_entidades_proveedores.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_entidades_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_entidades_proveedores.Location = New System.Drawing.Point(223, 272)
        Me.btn_limpiar_entidades_proveedores.Name = "btn_limpiar_entidades_proveedores"
        Me.btn_limpiar_entidades_proveedores.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_entidades_proveedores.TabIndex = 143
        Me.btn_limpiar_entidades_proveedores.Text = "Limpiar"
        Me.btn_limpiar_entidades_proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_entidades_proveedores.UseVisualStyleBackColor = True
        '
        'xls_est_entidades_clientes
        '
        Me.xls_est_entidades_clientes.BackColor = System.Drawing.Color.White
        Me.xls_est_entidades_clientes.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.xls_est_entidades_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.xls_est_entidades_clientes.Location = New System.Drawing.Point(536, 274)
        Me.xls_est_entidades_clientes.Name = "xls_est_entidades_clientes"
        Me.xls_est_entidades_clientes.Size = New System.Drawing.Size(147, 35)
        Me.xls_est_entidades_clientes.TabIndex = 160
        Me.xls_est_entidades_clientes.Text = "Exportar Estructura"
        Me.xls_est_entidades_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.xls_est_entidades_clientes.UseVisualStyleBackColor = False
        '
        'btn_clientesXLS
        '
        Me.btn_clientesXLS.BackColor = System.Drawing.Color.White
        Me.btn_clientesXLS.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_clientesXLS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_clientesXLS.Location = New System.Drawing.Point(536, 110)
        Me.btn_clientesXLS.Name = "btn_clientesXLS"
        Me.btn_clientesXLS.Size = New System.Drawing.Size(147, 35)
        Me.btn_clientesXLS.TabIndex = 158
        Me.btn_clientesXLS.Text = "Seleccionar Archivo"
        Me.btn_clientesXLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_clientesXLS.UseVisualStyleBackColor = False
        '
        'btn_cleintesPlano
        '
        Me.btn_cleintesPlano.BackColor = System.Drawing.Color.White
        Me.btn_cleintesPlano.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_cleintesPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cleintesPlano.Location = New System.Drawing.Point(536, 196)
        Me.btn_cleintesPlano.Name = "btn_cleintesPlano"
        Me.btn_cleintesPlano.Size = New System.Drawing.Size(147, 35)
        Me.btn_cleintesPlano.TabIndex = 157
        Me.btn_cleintesPlano.Text = "Exportar Archivo Plano"
        Me.btn_cleintesPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cleintesPlano.UseVisualStyleBackColor = False
        '
        'btn_salirentcli
        '
        Me.btn_salirentcli.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salirentcli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salirentcli.Location = New System.Drawing.Point(364, 266)
        Me.btn_salirentcli.Name = "btn_salirentcli"
        Me.btn_salirentcli.Size = New System.Drawing.Size(88, 43)
        Me.btn_salirentcli.TabIndex = 156
        Me.btn_salirentcli.Text = "Salir"
        Me.btn_salirentcli.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salirentcli.UseVisualStyleBackColor = True
        '
        'btn_generar_entidades_clientes
        '
        Me.btn_generar_entidades_clientes.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_entidades_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_entidades_clientes.Location = New System.Drawing.Point(80, 266)
        Me.btn_generar_entidades_clientes.Name = "btn_generar_entidades_clientes"
        Me.btn_generar_entidades_clientes.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_entidades_clientes.TabIndex = 155
        Me.btn_generar_entidades_clientes.Text = "Generar"
        Me.btn_generar_entidades_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_entidades_clientes.UseVisualStyleBackColor = True
        '
        'btn_limpiar_entidades_clientes
        '
        Me.btn_limpiar_entidades_clientes.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_entidades_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_entidades_clientes.Location = New System.Drawing.Point(223, 266)
        Me.btn_limpiar_entidades_clientes.Name = "btn_limpiar_entidades_clientes"
        Me.btn_limpiar_entidades_clientes.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_entidades_clientes.TabIndex = 154
        Me.btn_limpiar_entidades_clientes.Text = "Limpiar"
        Me.btn_limpiar_entidades_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_entidades_clientes.UseVisualStyleBackColor = True
        '
        'btnCargueEstadoActivosFijos
        '
        Me.btnCargueEstadoActivosFijos.BackColor = System.Drawing.Color.White
        Me.btnCargueEstadoActivosFijos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btnCargueEstadoActivosFijos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargueEstadoActivosFijos.Location = New System.Drawing.Point(542, 75)
        Me.btnCargueEstadoActivosFijos.Name = "btnCargueEstadoActivosFijos"
        Me.btnCargueEstadoActivosFijos.Size = New System.Drawing.Size(147, 35)
        Me.btnCargueEstadoActivosFijos.TabIndex = 27
        Me.btnCargueEstadoActivosFijos.Text = "Seleccionar Archivo"
        Me.btnCargueEstadoActivosFijos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargueEstadoActivosFijos.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(376, 277)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 43)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Salir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnGenerarCambioEstadoActivosFijos
        '
        Me.btnGenerarCambioEstadoActivosFijos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btnGenerarCambioEstadoActivosFijos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarCambioEstadoActivosFijos.Location = New System.Drawing.Point(66, 277)
        Me.btnGenerarCambioEstadoActivosFijos.Name = "btnGenerarCambioEstadoActivosFijos"
        Me.btnGenerarCambioEstadoActivosFijos.Size = New System.Drawing.Size(88, 43)
        Me.btnGenerarCambioEstadoActivosFijos.TabIndex = 25
        Me.btnGenerarCambioEstadoActivosFijos.Text = "Generar"
        Me.btnGenerarCambioEstadoActivosFijos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerarCambioEstadoActivosFijos.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(223, 277)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 43)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Limpiar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnExportarEstMovCont
        '
        Me.btnExportarEstMovCont.BackColor = System.Drawing.Color.White
        Me.btnExportarEstMovCont.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btnExportarEstMovCont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarEstMovCont.Location = New System.Drawing.Point(536, 287)
        Me.btnExportarEstMovCont.Name = "btnExportarEstMovCont"
        Me.btnExportarEstMovCont.Size = New System.Drawing.Size(147, 35)
        Me.btnExportarEstMovCont.TabIndex = 87
        Me.btnExportarEstMovCont.Text = "Exportar Estructura"
        Me.btnExportarEstMovCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarEstMovCont.UseVisualStyleBackColor = False
        '
        'btnExcelMovConta
        '
        Me.btnExcelMovConta.BackColor = System.Drawing.Color.White
        Me.btnExcelMovConta.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btnExcelMovConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcelMovConta.Location = New System.Drawing.Point(536, 177)
        Me.btnExcelMovConta.Name = "btnExcelMovConta"
        Me.btnExcelMovConta.Size = New System.Drawing.Size(147, 35)
        Me.btnExcelMovConta.TabIndex = 77
        Me.btnExcelMovConta.Text = "Seleccionar Archivo"
        Me.btnExcelMovConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcelMovConta.UseVisualStyleBackColor = False
        '
        'btnExportarPlanoMovCont
        '
        Me.btnExportarPlanoMovCont.BackColor = System.Drawing.Color.White
        Me.btnExportarPlanoMovCont.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btnExportarPlanoMovCont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPlanoMovCont.Location = New System.Drawing.Point(536, 228)
        Me.btnExportarPlanoMovCont.Name = "btnExportarPlanoMovCont"
        Me.btnExportarPlanoMovCont.Size = New System.Drawing.Size(147, 35)
        Me.btnExportarPlanoMovCont.TabIndex = 76
        Me.btnExportarPlanoMovCont.Text = "Exportar Archivo Plano"
        Me.btnExportarPlanoMovCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarPlanoMovCont.UseVisualStyleBackColor = False
        '
        'btnSalirMovConta
        '
        Me.btnSalirMovConta.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btnSalirMovConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirMovConta.Location = New System.Drawing.Point(356, 279)
        Me.btnSalirMovConta.Name = "btnSalirMovConta"
        Me.btnSalirMovConta.Size = New System.Drawing.Size(88, 43)
        Me.btnSalirMovConta.TabIndex = 75
        Me.btnSalirMovConta.Text = "Salir"
        Me.btnSalirMovConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalirMovConta.UseVisualStyleBackColor = True
        '
        'btnGenerarMovContab
        '
        Me.btnGenerarMovContab.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btnGenerarMovContab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarMovContab.Location = New System.Drawing.Point(91, 279)
        Me.btnGenerarMovContab.Name = "btnGenerarMovContab"
        Me.btnGenerarMovContab.Size = New System.Drawing.Size(88, 43)
        Me.btnGenerarMovContab.TabIndex = 74
        Me.btnGenerarMovContab.Text = "Generar"
        Me.btnGenerarMovContab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerarMovContab.UseVisualStyleBackColor = True
        '
        'btnLimpiarMovCont
        '
        Me.btnLimpiarMovCont.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btnLimpiarMovCont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarMovCont.Location = New System.Drawing.Point(223, 279)
        Me.btnLimpiarMovCont.Name = "btnLimpiarMovCont"
        Me.btnLimpiarMovCont.Size = New System.Drawing.Size(88, 43)
        Me.btnLimpiarMovCont.TabIndex = 73
        Me.btnLimpiarMovCont.Text = "Limpiar"
        Me.btnLimpiarMovCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarMovCont.UseVisualStyleBackColor = True
        '
        'btn_estruc_ImpYret
        '
        Me.btn_estruc_ImpYret.BackColor = System.Drawing.Color.White
        Me.btn_estruc_ImpYret.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btn_estruc_ImpYret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_estruc_ImpYret.Location = New System.Drawing.Point(536, 280)
        Me.btn_estruc_ImpYret.Name = "btn_estruc_ImpYret"
        Me.btn_estruc_ImpYret.Size = New System.Drawing.Size(147, 35)
        Me.btn_estruc_ImpYret.TabIndex = 160
        Me.btn_estruc_ImpYret.Text = "Exportar Estructura"
        Me.btn_estruc_ImpYret.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_estruc_ImpYret.UseVisualStyleBackColor = False
        '
        'btn_seleccionar_impyret_excel
        '
        Me.btn_seleccionar_impyret_excel.BackColor = System.Drawing.Color.White
        Me.btn_seleccionar_impyret_excel.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btn_seleccionar_impyret_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar_impyret_excel.Location = New System.Drawing.Point(536, 116)
        Me.btn_seleccionar_impyret_excel.Name = "btn_seleccionar_impyret_excel"
        Me.btn_seleccionar_impyret_excel.Size = New System.Drawing.Size(147, 35)
        Me.btn_seleccionar_impyret_excel.TabIndex = 158
        Me.btn_seleccionar_impyret_excel.Text = "Seleccionar Archivo"
        Me.btn_seleccionar_impyret_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar_impyret_excel.UseVisualStyleBackColor = False
        '
        'btn_seleccionar_planoImpyRet
        '
        Me.btn_seleccionar_planoImpyRet.BackColor = System.Drawing.Color.White
        Me.btn_seleccionar_planoImpyRet.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btn_seleccionar_planoImpyRet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_seleccionar_planoImpyRet.Location = New System.Drawing.Point(536, 202)
        Me.btn_seleccionar_planoImpyRet.Name = "btn_seleccionar_planoImpyRet"
        Me.btn_seleccionar_planoImpyRet.Size = New System.Drawing.Size(147, 35)
        Me.btn_seleccionar_planoImpyRet.TabIndex = 157
        Me.btn_seleccionar_planoImpyRet.Text = "Exportar Archivo Plano"
        Me.btn_seleccionar_planoImpyRet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_seleccionar_planoImpyRet.UseVisualStyleBackColor = False
        '
        'btn_salir_impyret
        '
        Me.btn_salir_impyret.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btn_salir_impyret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir_impyret.Location = New System.Drawing.Point(364, 272)
        Me.btn_salir_impyret.Name = "btn_salir_impyret"
        Me.btn_salir_impyret.Size = New System.Drawing.Size(88, 43)
        Me.btn_salir_impyret.TabIndex = 156
        Me.btn_salir_impyret.Text = "Salir"
        Me.btn_salir_impyret.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_salir_impyret.UseVisualStyleBackColor = True
        '
        'btn_generar_impyret
        '
        Me.btn_generar_impyret.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btn_generar_impyret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_generar_impyret.Location = New System.Drawing.Point(80, 272)
        Me.btn_generar_impyret.Name = "btn_generar_impyret"
        Me.btn_generar_impyret.Size = New System.Drawing.Size(88, 43)
        Me.btn_generar_impyret.TabIndex = 155
        Me.btn_generar_impyret.Text = "Generar"
        Me.btn_generar_impyret.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_generar_impyret.UseVisualStyleBackColor = True
        '
        'btn_limpiar_estyret
        '
        Me.btn_limpiar_estyret.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btn_limpiar_estyret.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_estyret.Location = New System.Drawing.Point(223, 272)
        Me.btn_limpiar_estyret.Name = "btn_limpiar_estyret"
        Me.btn_limpiar_estyret.Size = New System.Drawing.Size(88, 43)
        Me.btn_limpiar_estyret.TabIndex = 154
        Me.btn_limpiar_estyret.Text = "Limpiar"
        Me.btn_limpiar_estyret.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_limpiar_estyret.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(536, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 35)
        Me.Button1.TabIndex = 171
        Me.Button1.Text = "Exportar Estructura"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnSeleccionarArchivoCosto
        '
        Me.btnSeleccionarArchivoCosto.BackColor = System.Drawing.Color.White
        Me.btnSeleccionarArchivoCosto.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btnSeleccionarArchivoCosto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionarArchivoCosto.Location = New System.Drawing.Point(536, 116)
        Me.btnSeleccionarArchivoCosto.Name = "btnSeleccionarArchivoCosto"
        Me.btnSeleccionarArchivoCosto.Size = New System.Drawing.Size(147, 35)
        Me.btnSeleccionarArchivoCosto.TabIndex = 169
        Me.btnSeleccionarArchivoCosto.Text = "Seleccionar Archivo"
        Me.btnSeleccionarArchivoCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionarArchivoCosto.UseVisualStyleBackColor = False
        '
        'btnExportarArchivoCosto
        '
        Me.btnExportarArchivoCosto.BackColor = System.Drawing.Color.White
        Me.btnExportarArchivoCosto.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btnExportarArchivoCosto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarArchivoCosto.Location = New System.Drawing.Point(536, 202)
        Me.btnExportarArchivoCosto.Name = "btnExportarArchivoCosto"
        Me.btnExportarArchivoCosto.Size = New System.Drawing.Size(147, 35)
        Me.btnExportarArchivoCosto.TabIndex = 168
        Me.btnExportarArchivoCosto.Text = "Exportar Archivo Plano"
        Me.btnExportarArchivoCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarArchivoCosto.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(364, 272)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 43)
        Me.Button6.TabIndex = 167
        Me.Button6.Text = "Salir"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(80, 272)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(88, 43)
        Me.Button7.TabIndex = 166
        Me.Button7.Text = "Generar"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(223, 272)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 43)
        Me.Button8.TabIndex = 165
        Me.Button8.Text = "Limpiar"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(536, 268)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(147, 35)
        Me.Button3.TabIndex = 182
        Me.Button3.Text = "Exportar Estructura"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(536, 104)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(147, 35)
        Me.Button5.TabIndex = 180
        Me.Button5.Text = "Seleccionar Archivo"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(536, 190)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(147, 35)
        Me.Button9.TabIndex = 179
        Me.Button9.Text = "Exportar Archivo Plano"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btnSalirDistribucionCostos
        '
        Me.btnSalirDistribucionCostos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btnSalirDistribucionCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirDistribucionCostos.Location = New System.Drawing.Point(364, 260)
        Me.btnSalirDistribucionCostos.Name = "btnSalirDistribucionCostos"
        Me.btnSalirDistribucionCostos.Size = New System.Drawing.Size(88, 43)
        Me.btnSalirDistribucionCostos.TabIndex = 178
        Me.btnSalirDistribucionCostos.Text = "Salir"
        Me.btnSalirDistribucionCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalirDistribucionCostos.UseVisualStyleBackColor = True
        '
        'btnGenerarDistribucionCostos
        '
        Me.btnGenerarDistribucionCostos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btnGenerarDistribucionCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarDistribucionCostos.Location = New System.Drawing.Point(80, 260)
        Me.btnGenerarDistribucionCostos.Name = "btnGenerarDistribucionCostos"
        Me.btnGenerarDistribucionCostos.Size = New System.Drawing.Size(88, 43)
        Me.btnGenerarDistribucionCostos.TabIndex = 177
        Me.btnGenerarDistribucionCostos.Text = "Generar"
        Me.btnGenerarDistribucionCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerarDistribucionCostos.UseVisualStyleBackColor = True
        '
        'btnLimpiarDistribucionCostos
        '
        Me.btnLimpiarDistribucionCostos.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btnLimpiarDistribucionCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarDistribucionCostos.Location = New System.Drawing.Point(223, 260)
        Me.btnLimpiarDistribucionCostos.Name = "btnLimpiarDistribucionCostos"
        Me.btnLimpiarDistribucionCostos.Size = New System.Drawing.Size(88, 43)
        Me.btnLimpiarDistribucionCostos.TabIndex = 176
        Me.btnLimpiarDistribucionCostos.Text = "Limpiar"
        Me.btnLimpiarDistribucionCostos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarDistribucionCostos.UseVisualStyleBackColor = True
        '
        'btnRutaGenerarNomina
        '
        Me.btnRutaGenerarNomina.BackColor = System.Drawing.Color.White
        Me.btnRutaGenerarNomina.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btnRutaGenerarNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRutaGenerarNomina.Location = New System.Drawing.Point(481, 198)
        Me.btnRutaGenerarNomina.Name = "btnRutaGenerarNomina"
        Me.btnRutaGenerarNomina.Size = New System.Drawing.Size(38, 35)
        Me.btnRutaGenerarNomina.TabIndex = 185
        Me.btnRutaGenerarNomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRutaGenerarNomina.UseVisualStyleBackColor = False
        '
        'btnNominaPlano
        '
        Me.btnNominaPlano.BackColor = System.Drawing.Color.White
        Me.btnNominaPlano.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btnNominaPlano.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNominaPlano.Location = New System.Drawing.Point(481, 142)
        Me.btnNominaPlano.Name = "btnNominaPlano"
        Me.btnNominaPlano.Size = New System.Drawing.Size(38, 35)
        Me.btnNominaPlano.TabIndex = 182
        Me.btnNominaPlano.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNominaPlano.UseVisualStyleBackColor = False
        '
        'btnExportarEstructuraCompraServicios
        '
        Me.btnExportarEstructuraCompraServicios.BackColor = System.Drawing.Color.White
        Me.btnExportarEstructuraCompraServicios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.btnExportarEstructuraCompraServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarEstructuraCompraServicios.Location = New System.Drawing.Point(530, 304)
        Me.btnExportarEstructuraCompraServicios.Name = "btnExportarEstructuraCompraServicios"
        Me.btnExportarEstructuraCompraServicios.Size = New System.Drawing.Size(147, 35)
        Me.btnExportarEstructuraCompraServicios.TabIndex = 222
        Me.btnExportarEstructuraCompraServicios.Text = "Exportar Estructura"
        Me.btnExportarEstructuraCompraServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarEstructuraCompraServicios.UseVisualStyleBackColor = False
        '
        'btnSeleccionarExcelCompraServicios
        '
        Me.btnSeleccionarExcelCompraServicios.BackColor = System.Drawing.Color.White
        Me.btnSeleccionarExcelCompraServicios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btnSeleccionarExcelCompraServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionarExcelCompraServicios.Location = New System.Drawing.Point(530, 175)
        Me.btnSeleccionarExcelCompraServicios.Name = "btnSeleccionarExcelCompraServicios"
        Me.btnSeleccionarExcelCompraServicios.Size = New System.Drawing.Size(147, 35)
        Me.btnSeleccionarExcelCompraServicios.TabIndex = 221
        Me.btnSeleccionarExcelCompraServicios.Text = "Seleccionar Archivo"
        Me.btnSeleccionarExcelCompraServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSeleccionarExcelCompraServicios.UseVisualStyleBackColor = False
        '
        'btnExportarPlanoCompraServicios
        '
        Me.btnExportarPlanoCompraServicios.BackColor = System.Drawing.Color.White
        Me.btnExportarPlanoCompraServicios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btnExportarPlanoCompraServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportarPlanoCompraServicios.Location = New System.Drawing.Point(530, 226)
        Me.btnExportarPlanoCompraServicios.Name = "btnExportarPlanoCompraServicios"
        Me.btnExportarPlanoCompraServicios.Size = New System.Drawing.Size(147, 35)
        Me.btnExportarPlanoCompraServicios.TabIndex = 220
        Me.btnExportarPlanoCompraServicios.Text = "Exportar Archivo Plano"
        Me.btnExportarPlanoCompraServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExportarPlanoCompraServicios.UseVisualStyleBackColor = False
        '
        'btnSalirCompraServicios
        '
        Me.btnSalirCompraServicios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.btnSalirCompraServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalirCompraServicios.Location = New System.Drawing.Point(358, 296)
        Me.btnSalirCompraServicios.Name = "btnSalirCompraServicios"
        Me.btnSalirCompraServicios.Size = New System.Drawing.Size(88, 43)
        Me.btnSalirCompraServicios.TabIndex = 219
        Me.btnSalirCompraServicios.Text = "Salir"
        Me.btnSalirCompraServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalirCompraServicios.UseVisualStyleBackColor = True
        '
        'btnGenerarCompraServicios
        '
        Me.btnGenerarCompraServicios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btnGenerarCompraServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarCompraServicios.Location = New System.Drawing.Point(74, 296)
        Me.btnGenerarCompraServicios.Name = "btnGenerarCompraServicios"
        Me.btnGenerarCompraServicios.Size = New System.Drawing.Size(88, 43)
        Me.btnGenerarCompraServicios.TabIndex = 218
        Me.btnGenerarCompraServicios.Text = "Generar"
        Me.btnGenerarCompraServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerarCompraServicios.UseVisualStyleBackColor = True
        '
        'btnLimpiarCompraServicios
        '
        Me.btnLimpiarCompraServicios.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.btnLimpiarCompraServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarCompraServicios.Location = New System.Drawing.Point(217, 296)
        Me.btnLimpiarCompraServicios.Name = "btnLimpiarCompraServicios"
        Me.btnLimpiarCompraServicios.Size = New System.Drawing.Size(88, 43)
        Me.btnLimpiarCompraServicios.TabIndex = 217
        Me.btnLimpiarCompraServicios.Text = "Limpiar"
        Me.btnLimpiarCompraServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarCompraServicios.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(533, 274)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(147, 35)
        Me.Button10.TabIndex = 182
        Me.Button10.Text = "Exportar Estructura"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.Button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button11.Location = New System.Drawing.Point(533, 110)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(147, 35)
        Me.Button11.TabIndex = 180
        Me.Button11.Text = "Seleccionar Archivo"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(533, 196)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(147, 35)
        Me.Button12.TabIndex = 179
        Me.Button12.Text = "Exportar Archivo Plano"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(361, 266)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(88, 43)
        Me.Button13.TabIndex = 178
        Me.Button13.Text = "Salir"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(77, 266)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(88, 43)
        Me.Button14.TabIndex = 177
        Me.Button14.Text = "Generar"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.Location = New System.Drawing.Point(220, 266)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(88, 43)
        Me.Button15.TabIndex = 176
        Me.Button15.Text = "Limpiar"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.i2
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.Location = New System.Drawing.Point(513, 277)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(147, 35)
        Me.Button16.TabIndex = 191
        Me.Button16.Text = "Exportar Estructura"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button18
        '
        Me.Button18.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Salir
        Me.Button18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.Location = New System.Drawing.Point(297, 273)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(88, 43)
        Me.Button18.TabIndex = 188
        Me.Button18.Text = "Salir"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.Icon_cleanup
        Me.Button19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button19.Location = New System.Drawing.Point(156, 273)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(88, 43)
        Me.Button19.TabIndex = 187
        Me.Button19.Text = "Limpiar"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button19.UseVisualStyleBackColor = True
        '
        'btnExcelActCodBarras
        '
        Me.btnExcelActCodBarras.BackColor = System.Drawing.Color.White
        Me.btnExcelActCodBarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btnExcelActCodBarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcelActCodBarras.Location = New System.Drawing.Point(541, 105)
        Me.btnExcelActCodBarras.Name = "btnExcelActCodBarras"
        Me.btnExcelActCodBarras.Size = New System.Drawing.Size(147, 35)
        Me.btnExcelActCodBarras.TabIndex = 186
        Me.btnExcelActCodBarras.Text = "Seleccionar Archivo"
        Me.btnExcelActCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcelActCodBarras.UseVisualStyleBackColor = False
        '
        'btnGenerarActCodBarras
        '
        Me.btnGenerarActCodBarras.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.can_stock_photo_csp0696884
        Me.btnGenerarActCodBarras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGenerarActCodBarras.Location = New System.Drawing.Point(17, 273)
        Me.btnGenerarActCodBarras.Name = "btnGenerarActCodBarras"
        Me.btnGenerarActCodBarras.Size = New System.Drawing.Size(88, 43)
        Me.btnGenerarActCodBarras.TabIndex = 185
        Me.btnGenerarActCodBarras.Text = "Generar"
        Me.btnGenerarActCodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGenerarActCodBarras.UseVisualStyleBackColor = True
        '
        'btnRutaGeneraExcel
        '
        Me.btnRutaGeneraExcel.BackColor = System.Drawing.Color.White
        Me.btnRutaGeneraExcel.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.images
        Me.btnRutaGeneraExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRutaGeneraExcel.Location = New System.Drawing.Point(649, 203)
        Me.btnRutaGeneraExcel.Name = "btnRutaGeneraExcel"
        Me.btnRutaGeneraExcel.Size = New System.Drawing.Size(38, 35)
        Me.btnRutaGeneraExcel.TabIndex = 206
        Me.btnRutaGeneraExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRutaGeneraExcel.UseVisualStyleBackColor = False
        '
        'btnRutaPlanoNomina
        '
        Me.btnRutaPlanoNomina.BackColor = System.Drawing.Color.White
        Me.btnRutaPlanoNomina.Image = Global.Pry_Archivos_Planos.My.Resources.Resources.bloc_de_notas_proteccion_datos
        Me.btnRutaPlanoNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRutaPlanoNomina.Location = New System.Drawing.Point(649, 147)
        Me.btnRutaPlanoNomina.Name = "btnRutaPlanoNomina"
        Me.btnRutaPlanoNomina.Size = New System.Drawing.Size(38, 35)
        Me.btnRutaPlanoNomina.TabIndex = 203
        Me.btnRutaPlanoNomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRutaPlanoNomina.UseVisualStyleBackColor = False
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label150.Location = New System.Drawing.Point(20, 66)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(76, 17)
        Me.Label150.TabIndex = 221
        Me.Label150.Text = "Concepto: "
        '
        'txtConceptoNomSAP
        '
        Me.txtConceptoNomSAP.Location = New System.Drawing.Point(231, 65)
        Me.txtConceptoNomSAP.Name = "txtConceptoNomSAP"
        Me.txtConceptoNomSAP.Size = New System.Drawing.Size(412, 20)
        Me.txtConceptoNomSAP.TabIndex = 222
        Me.txtConceptoNomSAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FrmActivosFijos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 396)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.btnNominaPlanoOrigen)
        Me.Controls.Add(Me.TreeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmActivosFijos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Archivos Planos"
        Me.btnNominaPlanoOrigen.ResumeLayout(False)
        Me.TabPage_ActFijos.ResumeLayout(False)
        Me.TabPage_ActFijos.PerformLayout()
        Me.TabPage_Activaciones.ResumeLayout(False)
        Me.TabPage_Activaciones.PerformLayout()
        Me.TabPage_MovContable.ResumeLayout(False)
        Me.TabPage_MovContable.PerformLayout()
        Me.TabPage_Carnicos.ResumeLayout(False)
        Me.TabPage_Carnicos.PerformLayout()
        Me.TabPage_Precios.ResumeLayout(False)
        Me.TabPage_Precios.PerformLayout()
        Me.TabPage_Presup_Vendedor.ResumeLayout(False)
        Me.TabPage_Presup_Vendedor.PerformLayout()
        Me.TabPage_Presup_Jefe.ResumeLayout(False)
        Me.TabPage_Presup_Jefe.PerformLayout()
        Me.TabPage_ExtractoBan.ResumeLayout(False)
        Me.TabPage_ExtractoBan.PerformLayout()
        Me.TabPage_ExtractoBog.ResumeLayout(False)
        Me.TabPage_ExtractoBog.PerformLayout()
        Me.TabPage_Items.ResumeLayout(False)
        Me.TabPage_Items.PerformLayout()
        Me.TabPage_act_items.ResumeLayout(False)
        Me.TabPage_act_items.PerformLayout()
        Me.TabPage_Clas_items.ResumeLayout(False)
        Me.TabPage_Clas_items.PerformLayout()
        Me.TabPage_Sol_Compras.ResumeLayout(False)
        Me.TabPage_Sol_Compras.PerformLayout()
        Me.TabPage_criterios.ResumeLayout(False)
        Me.TabPage_criterios.PerformLayout()
        Me.TabPage_Bajas.ResumeLayout(False)
        Me.TabPage_Bajas.PerformLayout()
        Me.TabPage_cuentasxpagar.ResumeLayout(False)
        Me.TabPage_cuentasxpagar.PerformLayout()
        Me.TabPage_Traslados_AF.ResumeLayout(False)
        Me.TabPage_Traslados_AF.PerformLayout()
        Me.TabPage_Codigo_barras.ResumeLayout(False)
        Me.TabPage_Codigo_barras.PerformLayout()
        Me.TabPage_Mov_Inventarios.ResumeLayout(False)
        Me.TabPage_Mov_Inventarios.PerformLayout()
        Me.TabPage_Entidades_Proveedores.ResumeLayout(False)
        Me.TabPage_Entidades_Proveedores.PerformLayout()
        Me.TabPage_Entidades_Clientes.ResumeLayout(False)
        Me.TabPage_Entidades_Clientes.PerformLayout()
        Me.TabPage_Cambio_Estado_Activos_Fijos.ResumeLayout(False)
        Me.TabPage_Cambio_Estado_Activos_Fijos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage_Mov_Contab_New.ResumeLayout(False)
        Me.TabPage_Mov_Contab_New.PerformLayout()
        Me.TabPage_ImpuestosYRetenciones.ResumeLayout(False)
        Me.TabPage_ImpuestosYRetenciones.PerformLayout()
        Me.TabPage_CostoEstandar.ResumeLayout(False)
        Me.TabPage_CostoEstandar.PerformLayout()
        Me.TabPageDistribucionCostos.ResumeLayout(False)
        Me.TabPageDistribucionCostos.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPageCompraServicios.ResumeLayout(False)
        Me.TabPageCompraServicios.PerformLayout()
        Me.TabPageImportarTercero.ResumeLayout(False)
        Me.TabPageImportarTercero.PerformLayout()
        Me.TabPageActualizarCodBarras.ResumeLayout(False)
        Me.TabPageActualizarCodBarras.PerformLayout()
        Me.TabPagePlanoNomSAP.ResumeLayout(False)
        Me.TabPagePlanoNomSAP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btnNominaPlanoOrigen As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Activaciones As System.Windows.Forms.TabPage
    Friend WithEvents TabPage_ActFijos As System.Windows.Forms.TabPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lbl_excel As System.Windows.Forms.Label
    Friend WithEvents btn_seleccionar As System.Windows.Forms.Button
    Friend WithEvents txt_archivoexcel As System.Windows.Forms.TextBox
    Friend WithEvents lbl_plano As System.Windows.Forms.Label
    Friend WithEvents btn_plano As System.Windows.Forms.Button
    Friend WithEvents txt_plano As System.Windows.Forms.TextBox
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_salir_activos As System.Windows.Forms.Button
    Friend WithEvents btn_generar_activos As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_activos As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_archivo_plano_activos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_archivo_excel_activos As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tip_documento As System.Windows.Forms.Label
    Friend WithEvents txt_tip_doc As System.Windows.Forms.TextBox
    Friend WithEvents btn_excel_activos As System.Windows.Forms.Button
    Friend WithEvents btn_plano_activos As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage_MovContable As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_excel_movimiento As System.Windows.Forms.Button
    Friend WithEvents btn_plano_movimiento As System.Windows.Forms.Button
    Friend WithEvents btn_salir_movimiento As System.Windows.Forms.Button
    Friend WithEvents btn_generar_movimiento As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_movimiento As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_mov As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_excel_movimiento As System.Windows.Forms.TextBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_tip_doc_mov As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_co As System.Windows.Forms.TextBox
    Friend WithEvents lbl_centro_operativo As System.Windows.Forms.Label
    Friend WithEvents txtnotas As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_Carnicos As System.Windows.Forms.TabPage
    Friend WithEvents txt_notas_car As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fecha_car As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_tipdoc_car As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_co_car As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btn_excel_carnicos As System.Windows.Forms.Button
    Friend WithEvents btn_plano_carnicos As System.Windows.Forms.Button
    Friend WithEvents btn_salir_carnicos As System.Windows.Forms.Button
    Friend WithEvents btn_carnicos As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_carnicos As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_carnicos As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_excel_carnicos As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbl_cuentaxcobrar_car As System.Windows.Forms.Label
    Friend WithEvents txt_cuentacontab_car As System.Windows.Forms.TextBox
    Friend WithEvents lbl_cuenta_contablecar As System.Windows.Forms.Label
    Friend WithEvents txt_cuentaxcobrarcar As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_Precios As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_excel_precios As System.Windows.Forms.Button
    Friend WithEvents btn_plano_precios As System.Windows.Forms.Button
    Friend WithEvents btn_salir_precios As System.Windows.Forms.Button
    Friend WithEvents btn_generar_precios As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_precios As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_precios As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_excel_precios As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_Presup_Vendedor As System.Windows.Forms.TabPage
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_periodo_pres_vend As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btn_excel_pres_ven As System.Windows.Forms.Button
    Friend WithEvents btn_plano_pres_vend As System.Windows.Forms.Button
    Friend WithEvents btn_salir_pres_vend As System.Windows.Forms.Button
    Friend WithEvents btn_generar_plano_pres_ven As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_pres_ven As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_pres_vend As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_excel_pres_vend As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbo_presupuesto_vend As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage_Presup_Jefe As System.Windows.Forms.TabPage
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cbo_presupuesto_jef2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_periodo_pres_jef As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btn_excel_pres_jef As System.Windows.Forms.Button
    Friend WithEvents btn_plano_pres_jef As System.Windows.Forms.Button
    Friend WithEvents btn_salir_pres_jef As System.Windows.Forms.Button
    Friend WithEvents btn_generar_plano_pres_jef As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_pres_jef As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_pres_jef As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_excel_pres_jef As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_ExtractoBan As System.Windows.Forms.TabPage
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btn_excel_bancolombia As System.Windows.Forms.Button
    Friend WithEvents btn_plano_bancolombia As System.Windows.Forms.Button
    Friend WithEvents btn_salir_bancolombia As System.Windows.Forms.Button
    Friend WithEvents btn_generar_bancolombia As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_bancolombia As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_bancolombia As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_excel_bancolombia As System.Windows.Forms.TextBox
    Friend WithEvents TabPage_ExtractoBog As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btn_excel_bogota As System.Windows.Forms.Button
    Friend WithEvents btn_plano_bogota As System.Windows.Forms.Button
    Friend WithEvents btn_salir_bogota As System.Windows.Forms.Button
    Friend WithEvents btn_generar_bogota As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_bogota As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_bogota As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txt_excel_bogota As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Dtp_fecha_activaciones As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_est_carnicos As System.Windows.Forms.Button
    Friend WithEvents btn_est_activos As System.Windows.Forms.Button
    Friend WithEvents btn_est_activaciones As System.Windows.Forms.Button
    Friend WithEvents btn_est_movimiento As System.Windows.Forms.Button
    Friend WithEvents btn_est_precios As System.Windows.Forms.Button
    Friend WithEvents btn_est_pres_vend As System.Windows.Forms.Button
    Friend WithEvents btn_est_jefe_ventas As System.Windows.Forms.Button
    Friend WithEvents btn_est_bancolombia As System.Windows.Forms.Button
    Friend WithEvents btn_est_bancobogota As System.Windows.Forms.Button
    Friend WithEvents TabPage_Items As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_items As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_items As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_items As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_items As System.Windows.Forms.Button
    Friend WithEvents btn_plano_items As System.Windows.Forms.Button
    Friend WithEvents btn_salir_items As System.Windows.Forms.Button
    Friend WithEvents btn_generar_items As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_items As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TabPage_Clas_items As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_clasitems As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_clasitems As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_clasitems As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_clasitems As System.Windows.Forms.Button
    Friend WithEvents btn_plano_clasitems As System.Windows.Forms.Button
    Friend WithEvents btn_salir_clasitems As System.Windows.Forms.Button
    Friend WithEvents btn_generar_clasitems As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_clasitems As System.Windows.Forms.Button
    Friend WithEvents TabPage_Sol_Compras As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_sol_compra As System.Windows.Forms.Button
    Friend WithEvents txt_notas_sol_compra As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fecha_sol_compra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txt_tip_doc_sol_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txt_co_sol_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_sol_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_sol_compras As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_sol_compra As System.Windows.Forms.Button
    Friend WithEvents btn_plano_sol_compra As System.Windows.Forms.Button
    Friend WithEvents btn_salir_sol_compras As System.Windows.Forms.Button
    Friend WithEvents Btn_generar_sol_compras As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_sol_compra As System.Windows.Forms.Button
    Friend WithEvents txt_tercero_sol_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TabPage_criterios As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_criterios As System.Windows.Forms.Button
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_criterios As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_criterios As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_criterios As System.Windows.Forms.Button
    Friend WithEvents btn_plano_criterios As System.Windows.Forms.Button
    Friend WithEvents btn_salir_criterios As System.Windows.Forms.Button
    Friend WithEvents btn_generar_criterios As System.Windows.Forms.Button
    Friend WithEvents btn_limipiar_criterios As System.Windows.Forms.Button
    Friend WithEvents TabPage_Bajas As System.Windows.Forms.TabPage
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents btn_est_bajas As System.Windows.Forms.Button
    Friend WithEvents txt_notas_bajas As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fecha_doc_bajas As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txt_tip_doc_bajas As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txt_co_bajas As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_bajas As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_bajas As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_bajas As System.Windows.Forms.Button
    Friend WithEvents btn_planos_bajas As System.Windows.Forms.Button
    Friend WithEvents btn_salir_bajas As System.Windows.Forms.Button
    Friend WithEvents btn_generar_bajas As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_bajas As System.Windows.Forms.Button
    Friend WithEvents TabPage_cuentasxpagar As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_cuentas As System.Windows.Forms.Button
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents txt_notas_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fecha_doc_cuentas As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents txt_tip_doc_cuentas As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents txt_co_cuentas As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_cuentas As System.Windows.Forms.TextBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_cuentas As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_cuentas As System.Windows.Forms.Button
    Friend WithEvents btn_plano_cuentas As System.Windows.Forms.Button
    Friend WithEvents btn_salir_cuentas As System.Windows.Forms.Button
    Friend WithEvents btn_generar_cuentas As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_cuentas As System.Windows.Forms.Button
    Friend WithEvents TabPage_Traslados_AF As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_traslados As System.Windows.Forms.Button
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txt_notas_traslados As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fechadoc_traslados As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents txt_tipdoc_traslados As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txt_co_traslados As System.Windows.Forms.TextBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_traslados As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_traslados As System.Windows.Forms.TextBox
    Friend WithEvents btn_traslados As System.Windows.Forms.Button
    Friend WithEvents btn_plano_traslados As System.Windows.Forms.Button
    Friend WithEvents btn_salir_traslados As System.Windows.Forms.Button
    Friend WithEvents btn_generar_traslados As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_traslados As System.Windows.Forms.Button
    Friend WithEvents TabPage_act_items As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_act_items As System.Windows.Forms.Button
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_act_items As System.Windows.Forms.TextBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_act_items As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_act_items As System.Windows.Forms.Button
    Friend WithEvents btn_plano_act_items As System.Windows.Forms.Button
    Friend WithEvents btn_salir_act_items As System.Windows.Forms.Button
    Friend WithEvents btn_generar_act_items As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_act_items As System.Windows.Forms.Button
    Friend WithEvents TabPage_Codigo_barras As System.Windows.Forms.TabPage
    Friend WithEvents btn_est_codigobarras As System.Windows.Forms.Button
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents txt_planocodigobarras As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents txt_codigobarras As System.Windows.Forms.TextBox
    Friend WithEvents btn_codigobarras As System.Windows.Forms.Button
    Friend WithEvents btn_planocodigobarras As System.Windows.Forms.Button
    Friend WithEvents btn_salircodigobarras As System.Windows.Forms.Button
    Friend WithEvents btn_generarcodigobarras As System.Windows.Forms.Button
    Friend WithEvents btn_limpiarcodigobarras As System.Windows.Forms.Button
    Friend WithEvents TabPage_Mov_Inventarios As System.Windows.Forms.TabPage
    Friend WithEvents txt_doc_alterno_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents txt_bodega_entrada_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents txt_bodega_salida_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents txt_id_con_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents txt_clase_doc_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents btn_est_inv As System.Windows.Forms.Button
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents txt_notas_inv As System.Windows.Forms.TextBox
    Friend WithEvents Dtp_fechadoc_inv As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents txt_tip_doc_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents txt_co_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_inv As System.Windows.Forms.TextBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents txt_csv_inv As System.Windows.Forms.TextBox
    Friend WithEvents btn_csv_inv As System.Windows.Forms.Button
    Friend WithEvents btn_plano_inv As System.Windows.Forms.Button
    Friend WithEvents btn_salir_inv As System.Windows.Forms.Button
    Friend WithEvents btn_generar_inv As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_inv As System.Windows.Forms.Button
    Friend WithEvents TabPage_Entidades_Proveedores As System.Windows.Forms.TabPage
    Friend WithEvents csv_est_entidades_proveedores As System.Windows.Forms.Button
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents txt_plano_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents txt_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents btn_seleccionar_proveedor_csv As System.Windows.Forms.Button
    Friend WithEvents btn_generar_plano_proveedor As System.Windows.Forms.Button
    Friend WithEvents btn_salir_entidades_proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_generar_entidades_proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_entidades_proveedores As System.Windows.Forms.Button
    Friend WithEvents TabPage_Cambio_Estado_Activos_Fijos As TabPage
    Friend WithEvents Label98 As Label
    Friend WithEvents btnCargueEstadoActivosFijos As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnGenerarCambioEstadoActivosFijos As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label99 As Label
    Friend WithEvents txtExcelCambioEstadoActFijos As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbActivar As RadioButton
    Friend WithEvents rbSuspender As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbniif As CheckBox
    Friend WithEvents cbpcga As CheckBox
    Friend WithEvents TabPage_Mov_Contab_New As TabPage
    Friend WithEvents btnExportarEstMovCont As Button
    Friend WithEvents txtNotasMovContab As TextBox
    Friend WithEvents dtpFechaDocMovCont As DateTimePicker
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents txtTipodocMovCont As TextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents txtCoMovContable As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents txtArchivoPlanoMovCont As TextBox
    Friend WithEvents Label106 As Label
    Friend WithEvents txtArchivoExcelMovCont As TextBox
    Friend WithEvents btnExcelMovConta As Button
    Friend WithEvents btnExportarPlanoMovCont As Button
    Friend WithEvents btnSalirMovConta As Button
    Friend WithEvents btnGenerarMovContab As Button
    Friend WithEvents btnLimpiarMovCont As Button
    Friend WithEvents TabPage_ImpuestosYRetenciones As System.Windows.Forms.TabPage
    Friend WithEvents btn_estruc_ImpYret As System.Windows.Forms.Button
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents txt_ImpyRet_plano As System.Windows.Forms.TextBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents txt_ImpYRet_excel As System.Windows.Forms.TextBox
    Friend WithEvents btn_seleccionar_impyret_excel As System.Windows.Forms.Button
    Friend WithEvents btn_seleccionar_planoImpyRet As System.Windows.Forms.Button
    Friend WithEvents btn_salir_impyret As System.Windows.Forms.Button
    Friend WithEvents btn_generar_impyret As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_estyret As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog21 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabPage_Entidades_Clientes As System.Windows.Forms.TabPage
    Friend WithEvents xls_est_entidades_clientes As System.Windows.Forms.Button
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents txt_clientesPlano As System.Windows.Forms.TextBox
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents txt_clientesXLS As System.Windows.Forms.TextBox
    Friend WithEvents btn_clientesXLS As System.Windows.Forms.Button
    Friend WithEvents btn_cleintesPlano As System.Windows.Forms.Button
    Friend WithEvents btn_salirentcli As System.Windows.Forms.Button
    Friend WithEvents btn_generar_entidades_clientes As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_entidades_clientes As System.Windows.Forms.Button
    Friend WithEvents TabPage_CostoEstandar As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label113 As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents txtPlanoExcel As TextBox
    Friend WithEvents Label115 As Label
    Friend WithEvents txtExcelCostos As TextBox
    Friend WithEvents btnSeleccionarArchivoCosto As Button
    Friend WithEvents btnExportarArchivoCosto As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TabPageDistribucionCostos As TabPage
    Friend WithEvents Button3 As Button
    Friend WithEvents Label116 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents txtRutaPlanoDistribucionCostos As TextBox
    Friend WithEvents Label118 As Label
    Friend WithEvents txtExcelDistribucionCostos As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents btnSalirDistribucionCostos As Button
    Friend WithEvents btnGenerarDistribucionCostos As Button
    Friend WithEvents btnLimpiarDistribucionCostos As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtGenerarNomina As Button
    Friend WithEvents Label126 As Label
    Friend WithEvents dtpFechaNomina As DateTimePicker
    Friend WithEvents txtNitBancoNomina As TextBox
    Friend WithEvents Label125 As Label
    Friend WithEvents txtAuxiliarNomina As TextBox
    Friend WithEvents Label124 As Label
    Friend WithEvents txtNotasNomina As TextBox
    Friend WithEvents txtTipoDctoNomina As TextBox
    Friend WithEvents txtCONomina As TextBox
    Friend WithEvents Label123 As Label
    Friend WithEvents Label122 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents btnRutaGenerarNomina As Button
    Friend WithEvents Label120 As Label
    Friend WithEvents txtRutaPlanoNomina As TextBox
    Friend WithEvents Label119 As Label
    Friend WithEvents txtRutaNomina As TextBox
    Friend WithEvents btnNominaPlano As Button
    Friend WithEvents Label127 As Label
    Friend WithEvents cboBanco As ComboBox
    Friend WithEvents TabPageCompraServicios As TabPage
    Friend WithEvents txtCentroCostosCompraServicios As TextBox
    Friend WithEvents Label141 As Label
    Friend WithEvents txtCondicionPagoCompraServicios As TextBox
    Friend WithEvents Label140 As Label
    Friend WithEvents txtFacturaCompraServicios As TextBox
    Friend WithEvents Label139 As Label
    Friend WithEvents txtPrefijoFacturaCompraServicios As TextBox
    Friend WithEvents Label138 As Label
    Friend WithEvents txtTipoProveedorCompraServicios As TextBox
    Friend WithEvents Label137 As Label
    Friend WithEvents txtSucursarCompraServicios As TextBox
    Friend WithEvents Label136 As Label
    Friend WithEvents txtNitCompraServicios As TextBox
    Friend WithEvents Label135 As Label
    Friend WithEvents btnExportarEstructuraCompraServicios As Button
    Friend WithEvents Label133 As Label
    Friend WithEvents txtRutaPlanoCompraServicios As TextBox
    Friend WithEvents Label134 As Label
    Friend WithEvents txtRutaExcelCompraServicios As TextBox
    Friend WithEvents btnSeleccionarExcelCompraServicios As Button
    Friend WithEvents btnExportarPlanoCompraServicios As Button
    Friend WithEvents btnSalirCompraServicios As Button
    Friend WithEvents btnGenerarCompraServicios As Button
    Friend WithEvents btnLimpiarCompraServicios As Button
    Friend WithEvents txtNotasCompraServicios As TextBox
    Friend WithEvents txtTipoDoctoCompraServicios As TextBox
    Friend WithEvents txtCoCompraServicios As TextBox
    Friend WithEvents Label130 As Label
    Friend WithEvents Label131 As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents Label129 As Label
    Friend WithEvents Label128 As Label
    Friend WithEvents dtpFechaCompraServicios As DateTimePicker
    Friend WithEvents TabPageImportarTercero As TabPage
    Friend WithEvents Button10 As Button
    Friend WithEvents Label142 As Label
    Friend WithEvents Label143 As Label
    Friend WithEvents txtPlanoExcelTerceros As TextBox
    Friend WithEvents Label144 As Label
    Friend WithEvents txtExcelTerceros As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents TabPageActualizarCodBarras As TabPage
    Friend WithEvents Label145 As Label
    Friend WithEvents Label147 As Label
    Friend WithEvents txtLogActCodBarras As TextBox
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Label146 As Label
    Friend WithEvents txtExcelActCodBarras As TextBox
    Friend WithEvents btnExcelActCodBarras As Button
    Friend WithEvents btnGenerarActCodBarras As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents TabPagePlanoNomSAP As TabPage
    Friend WithEvents btnGenerarXlsNomina As Button
    Friend WithEvents Label148 As Label
    Friend WithEvents cboBancoSap As ComboBox
    Friend WithEvents Label149 As Label
    Friend WithEvents dtpFechaNomSAP As DateTimePicker
    Friend WithEvents txtCLNominaSAP As TextBox
    Friend WithEvents Label154 As Label
    Friend WithEvents btnRutaGeneraExcel As Button
    Friend WithEvents Label155 As Label
    Friend WithEvents txtRutaExcelGenerado As TextBox
    Friend WithEvents Label156 As Label
    Friend WithEvents txtRutaNomPlano As TextBox
    Friend WithEvents btnRutaPlanoNomina As Button
    Friend WithEvents txtConceptoNomSAP As TextBox
    Friend WithEvents Label150 As Label
End Class
