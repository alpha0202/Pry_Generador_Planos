Imports Pry_Archivos_Planos.ClsUtiles
Imports Pry_Archivos_Planos.clsConexion
Imports System.Data.SqlClient

Public Class Frm_Compañias

    Private Sub Frm_Compañias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CargarCombo(cbo_empresas, "SELECT codigo,nombre ,nit FROM  al_TblCompañias", Nothing, False)

    End Sub

    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        End
    End Sub

    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click

        If cbo_empresas.Text = "" Then
            MsgBox("Por favor seleccione una compañia valida", MsgBoxStyle.Critical)
            cbo_empresas.Focus()
            Exit Sub
        End If

        FrmActivosFijos.ShowDialog()
        Me.Close()

    End Sub

    Private Sub cbo_empresas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_empresas.SelectedIndexChanged
        lbl_nit.Text = cbo_empresas.SelectedItem(2).ToString
        lbl_codigo.Text = cbo_empresas.SelectedItem(0).ToString
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class