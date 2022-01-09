Public Class Form1
    Dim Versuche As Integer
    Dim Zahl As Integer

    Dim gZahl As Integer = 100
    Dim kZahl As Integer = 1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Zahlenraten - Version " & Application.ProductVersion
        NeuesSpiel()

    End Sub


    Sub NeuesSpiel()


        Versuche = 0
        Label3.Text = "Versuche: " & Versuche


        Label4.Visible = False

        Dim rnd As New Random()
        Zahl = rnd.Next(1, 100)
        'MsgBox(Zahl)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        NeuesSpiel()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CheckInput()

    End Sub

    Sub CheckInput()

        If IsNumeric(TextBox1.Text) = True Then
            If TextBox1.Text = Zahl Then
                MsgBox("Sie haben mit " & Versuche & " Versuchen gewonnen!", vbInformation, "Zahlenraten")
                NeuesSpiel()

            Else
                Dim gg As String

                If Integer.Parse(TextBox1.Text) < Zahl Then
                    gg = "GRÖßER"
                    Label4.ForeColor = Color.Blue

                Else
                    gg = "KLEINER"
                    Label4.ForeColor = Color.Red

                End If

                Label4.Visible = True

                Label4.Text = "Meine Zahl ist " & gg            'MsgBox("Meine Zahl ist " & gg, vbInformation, "Zahlenraten")




                Versuche += 1
                Label3.Text = "Versuche: " & Versuche
            End If
        Else
            MsgBox("Bitte geben Sie NUR Zahlen ein.", vbExclamation, "Zahlenraten")

        End If

        TextBox1.Text = ""
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            CheckInput()
        End If
    End Sub
End Class
