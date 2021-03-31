Imports System.Data.SqlClient
Module Module1


    Public con As New SqlConnection

    Public Sub conectar()

        Try

            con.ConnectionString = "Data Source=DESKTOP-HMK7QBB;Initial Catalog=alumno3;Integrated Security=True"
            Con.Open()
            MessageBox.Show(Con.state.Tostring)


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

End Module
