Imports System.Data.SqlClient
Public Class clsConexion
    Implements IDisposable
    Dim Mycnn As SqlConnection
    Public ReadOnly Property conexion() As SqlConnection
        Get
            Return Mycnn
        End Get
    End Property
    Public Function conectar(ByVal ss As String, ByVal sss As String) As SqlConnection
        Try

            Dim sCnn As String = "Data Source= 10.252.0.158\ALIAR;Initial Catalog=ALIARREPORTES;User Id=Reportes;Password=Report2014; MultipleActiveResultSets=True"
            Mycnn = New SqlConnection(sCnn)
            Mycnn.Open()
        Catch ex As Exception
            Throw
        End Try
    End Function
    Public Sub Dispose() Implements System.IDisposable.Dispose
        If Not Mycnn Is Nothing Then
            Mycnn.Close()
            Mycnn = Nothing
        End If
    End Sub
    Public ReadOnly Property begin() As SqlTransaction
        Get
            Return Mycnn.BeginTransaction
        End Get
    End Property
    Public ReadOnly Property beginB() As SqlTransaction
        Get
            Return Mycnn.BeginTransaction(IsolationLevel.Serializable)
        End Get
    End Property
End Class
