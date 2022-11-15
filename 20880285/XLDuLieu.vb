Imports System.Data.OleDb
Module XLDuLieu
    Dim ChuoiKetNoi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;Persist Security Info=True"
    Public Function DocDuLieu(ByVal select_command As String) As DataTable
        Dim connection As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim command As OleDbCommand = New OleDbCommand(select_command, connection)
        Dim dt As DataTable = New DataTable()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        adapter.Fill(dt)
        Return dt
    End Function

    Public Sub GhiDuLieu(ByVal ten_bang As String, ByVal dt As DataTable)
        Dim connection As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim sql As String = String.Format("Select * from {0}", ten_bang)
        Dim command As OleDbCommand = New OleDbCommand(sql, connection)
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(adapter)
        AddHandler adapter.RowUpdated, AddressOf CapNhatMaSo
        adapter.Update(dt)
    End Sub

    Private Sub CapNhatMaSo(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        Dim ket_noi As OleDbConnection = e.Command.Connection
        If e.StatementType = StatementType.Insert Then
            Dim Lenh As OleDbCommand = New OleDbCommand("Select @@IDENTITY", ket_noi)
            Dim ma_so As Integer = Integer.Parse(Lenh.ExecuteScalar())
            e.Row(0) = ma_so
        End If
    End Sub

    Public Function DocCauTruc(ByVal select_command As String) As DataTable
        Dim connection As OleDbConnection = New OleDbConnection(ChuoiKetNoi)
        Dim command As OleDbCommand = New OleDbCommand(select_command, connection)
        Dim dt As DataTable = New DataTable()
        Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
        adapter.FillSchema(dt, SchemaType.Source)
        Return dt
    End Function
End Module
