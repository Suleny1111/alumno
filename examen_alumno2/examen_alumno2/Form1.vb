Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        mostrardatos()
    End Sub
    Sub mostrardatos()
        Dim dat As New SqlDataAdapter(" select * from alumno ", con)
        Dim d As New DataSet
        dat.Fill(d)
        DataGridView1.DataSource = d.Tables(0)
        DataGridView1.Columns("nombre").HeaderText = "nombre"
        DataGridView1.Columns("apellido").HeaderText = "apellido"
        DataGridView1.Columns("cèdula").HeaderText = "cèdula"
        DataGridView1.Columns("matricula").HeaderText = "matricula"
        DataGridView1.Columns("carrera").HeaderText = "carrera"
        DataGridView1.Columns("telèfono").HeaderText = "telèfono"
        DataGridView1.Columns("direcciòn").HeaderText = "direcciòn"
    End Sub
    Private Sub cmdinsertar_Click(sender As Object, e As EventArgs) Handles cmdinsertar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = " insert into alumno (nombre,apellido,cèdula,matricula,carrera,telèfono,direcciòn) values (`" & txtNombre.Text & "`,`" & txtApellido.Text & "`, " & txtCèdula.Text & "`, "
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text)
            cmd.Parameters.AddWithValue("@cèdula", txtCèdula.Text)
            cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text)
            cmd.Parameters.AddWithValue("@carrera", txtCarrera.Text)
            cmd.Parameters.AddWithValue("@telèfono", txtTelèfono.Text)
            cmd.Parameters.AddWithValue("@direcciòn", txtDirecciòn.Text)
            Dim fila As Integer
            If fila > 0 Then
                MessageBox.Show("Datos guardados")

            End If

            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdLimpiar_Click(sender As Object, e As EventArgs) Handles cmdLimpiar.Click
        txtApellido.Clear()
        txtCarrera.Clear()
        txtCèdula.Clear()
        txtDirecciòn.Clear()
        txtMatricula.Clear()
        txtNombre.Clear()
        txtTelèfono.Clear()



    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Rows.Count > 0 Then


            If DataGridView1.SelectedRows.Count > 0 Then
                txtNombre.Text = DataGridView1.SelectedRows(0).Cells("nombre").Value
                txtApellido.Text = DataGridView1.SelectedRows(0).Cells("apellido").Value
                txtCèdula.Text = DataGridView1.SelectedRows(0).Cells("cèdula").Value
                txtMatricula.Text = DataGridView1.SelectedRows(0).Cells("matricula").Value
                txtCarrera.Text = DataGridView1.SelectedRows(0).Cells("carrera").Value
                txtTelèfono.Text = DataGridView1.SelectedRows(0).Cells("telèfono").Value
                txtDirecciòn.Text = DataGridView1.SelectedRows(0).Cells("direcciòn").Value
            End If
        End If
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim cmd As New SqlCommand
        cmd.Connection = con
        cmd.CommandText = "delete from alumno where alumnoID= '" & txtNombre.Text & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Datos eliminados")
        mostrardatos()
    End Sub

    Private Sub cmdActualizar_Click(sender As Object, e As EventArgs) Handles cmdActualizar.Click
        Try
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "update alumno set nombre" & txtNombre.Text & "`,Apellido =`" & txtApellido.Text & "`,cèdula=`" & txtCèdula.Text & "`,matricula = `" & txtMatricula.Text & "`,carrera = `" & txtCarrera.Text & "`,telèfono= `" & txtTelèfono.Text & "`,direcciòn= `" & txtDirecciòn.Text & "`"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos guardados")
            mostrardatos()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class


