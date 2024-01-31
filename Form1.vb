Public Class Form1

    Dim intTurnCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gridPlaymat.Rows.Add("", "", "")
        gridPlaymat.Rows.Add("", "", "")
        gridPlaymat.Rows.Add("", "", "")

    End Sub

    Private Sub gridPlaymat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridPlaymat.CellClick
        If rbPlayer1.Checked = True Then

            If gridPlaymat.CurrentCell.Value = "O" Then
                Exit Sub
            End If

            gridPlaymat.CurrentCell.Value = "X"
            rbPlayer1.Checked = False
            rbPlayer2.Checked = True

        Else
            If gridPlaymat.CurrentCell.Value = "X" Then
                Exit Sub
            End If

            gridPlaymat.CurrentCell.Value = "O"
            rbPlayer2.Checked = False
            rbPlayer1.Checked = True
        End If

        intTurnCount = intTurnCount + 1

        'MsgBox(gridPlaymat.CurrentCell.RowIndex.ToString() + "/" + gridPlaymat.CurrentCell.ColumnIndex.ToString())

        '5

        If intTurnCount >= 5 Then
            CheckPlaymat()
        End If




    End Sub

    Public Function CheckPlaymat()

        Dim arrOptions(1) As String
        arrOptions(0) = "X"
        arrOptions(1) = "O"
        Dim arrColor(5) As Integer

        For w = 0 To 1

            '-
            For x = 0 To 2


                If (gridPlaymat(0, x).Value = arrOptions(w) And gridPlaymat(1, x).Value = arrOptions(w) And gridPlaymat(2, x).Value = arrOptions(w)) Then
                    arrColor(0) = 0
                    arrColor(1) = x
                    arrColor(2) = 1
                    arrColor(3) = x
                    arrColor(4) = 2
                    arrColor(5) = x

                    ResetMar(arrColor, arrOptions(w))
                    Exit Function
                End If

            Next


            '|
            For x = 0 To 2

                If (gridPlaymat(x, 0).Value = arrOptions(w) And gridPlaymat(x, 1).Value = arrOptions(w) And gridPlaymat(x, 2).Value = arrOptions(w)) Then
                    arrColor(0) = x
                    arrColor(1) = 0
                    arrColor(2) = x
                    arrColor(3) = 1
                    arrColor(4) = x
                    arrColor(5) = 2

                    ResetMar(arrColor, arrOptions(w))
                    Exit Function
                End If


            Next


            '\
            If (gridPlaymat(0, 0).Value = arrOptions(w) And gridPlaymat(1, 1).Value = arrOptions(w) And gridPlaymat(2, 2).Value = arrOptions(w)) Then
                arrColor(0) = 0
                arrColor(1) = 0
                arrColor(2) = 1
                arrColor(3) = 1
                arrColor(4) = 2
                arrColor(5) = 2

                ResetMar(arrColor, arrOptions(w))
                Exit Function
            End If


            '/
            If (gridPlaymat(0, 2).Value = arrOptions(w) And gridPlaymat(1, 1).Value = arrOptions(w) And gridPlaymat(2, 0).Value = arrOptions(w)) Then
                arrColor(0) = 0
                arrColor(1) = 2
                arrColor(2) = 1
                arrColor(3) = 1
                arrColor(4) = 2
                arrColor(5) = 0

                ResetMar(arrColor, arrOptions(w))
                Exit Function
            End If

        Next


        Dim RowCount = 0

        For x = 0 To 2

            For z = 0 To 2

                If Not gridPlaymat(x, z).Value = "" Then

                    RowCount = RowCount + 1

                End If


            Next

        Next

        If RowCount = 9 Then

            For x = 0 To 2

                For z = 0 To 2

                    If Not gridPlaymat(x, z).Value = "" Then

                        gridPlaymat(x, z).Style.BackColor = Color.Red

                    End If


                Next

            Next

            ResetMar(arrColor, "L")
            Exit Function

        End If



    End Function

    Public Function ResetMar(strType() As Integer, strWinner As String)

        If Not strWinner = "L" Then
            gridPlaymat(strType(0), strType(1)).Style.BackColor = Color.LightBlue
            gridPlaymat(strType(2), strType(3)).Style.BackColor = Color.LightBlue
            gridPlaymat(strType(4), strType(5)).Style.BackColor = Color.LightBlue
            MsgBox(strWinner + " wins!")
        Else
            MsgBox("No winner!")
        End If




        gridPlaymat.Rows.Clear()
        rbPlayer1.Checked = True
        rbPlayer2.Checked = False
        gridPlaymat.Rows.Add("", "", "")
        gridPlaymat.Rows.Add("", "", "")
        gridPlaymat.Rows.Add("", "", "")
        intTurnCount = 0

    End Function


    Private Sub gridPlaymat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridPlaymat.CellContentClick




    End Sub

    Private Sub rbPlayer1_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlayer1.CheckedChanged


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim arrColor(4) As Integer
        ResetMar(arrColor, "L")
    End Sub
End Class
