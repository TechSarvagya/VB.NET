Imports System.Data.OleDb
Public Class Form1
    Dim pt As Integer = 0
    Dim t1 As Integer = 10
    Dim t2 As Integer = 0
    Dim x
    Dim questions As String() = New String(12) {}
    Dim i As Integer = 0
    Dim dt As New DataTable()
    Dim conn As New OleDbConnection
    Dim ds As New OleDbDataAdapter
    Dim command As New OleDbCommand

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label1.ForeColor = Color.Red Then
            Label1.ForeColor = Color.Blue
        Else
            Label1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Timer1.Enabled = True


        Timer1.Start()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        x = InputBox("Enter your name", "name input", "unknown")
        TextBox5.Text = x
        Label1.Visible = False
        PictureBox1.Visible = False
        TextBox1.Visible = False
        RichTextBox1.Visible = False
        Button1.Visible = False
        Timer1.Stop()

        Panel1.Visible = True
        Timer2.Enabled = True

        Timer2.Start()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If t2 = 0 Then
            t2 = 60
            t1 = t1 - 1


        End If

        t2 = t2 - 1


        TextBox2.Text = t1
        TextBox3.Text = t2

        If (t1 = 0 And t2 = 0) Then
            Timer2.Stop()

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0 ; Data Source=C:\Users\HP\OneDrive\Documents\Database1.accdb"

        questions(0) = RichTextBox2.Text

        TextBox2.Text = t1
        TextBox3.Text = t2
        questions(1) = "Shivi 's favourite mobile game?"
        questions(2) = "Shivi 's favourite fast food?"
        questions(3) = "Shivi 's favourite sweet?"
        questions(4) = "Shivi 's favourite cartoon?"
        questions(5) = "Flavour of  Shivi's last year's birthday cake?"
        questions(6) = "Does shivi need someone to play with?"
        questions(7) = "The person who irrtates shivi the most"
        questions(8) = "Shivi has a vein visible on which of the following body parts?"
        questions(9) = "Colour of the first pillow on which Shivi used to lay down in yamuna vihar"
        questions(10) = "The first hindi word spoken by shivi?"
        questions(11) = "Your first meeting with shivi."
        questions(12) = "Qualities that you Like in shivi"

    End Sub






    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked And (RichTextBox2.Text = questions(2) Or RichTextBox2.Text = questions(5)) = True Then

            TextBox4.Text = TextBox4.Text + 1
        End If



        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False
        End If


        If i = 2 Or i = 5 Then


            If CheckBox1.Checked = False Then

                TextBox4.Text = TextBox4.Text - 1

            End If

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked And (RichTextBox2.Text = questions(0) Or RichTextBox2.Text = questions(4) Or RichTextBox2.Text = questions(6) Or RichTextBox2.Text = questions(9)) = True Then

            TextBox4.Text = TextBox4.Text + 1
        End If


        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
            CheckBox4.Checked = False

        End If
        If i = 0 Or i = 4 Or i = 6 Or i = 9 Then
            If CheckBox3.Checked = False Then

                TextBox4.Text = TextBox4.Text - 1

            End If
        End If



    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked And (RichTextBox2.Text = questions(1) Or RichTextBox2.Text = questions(7) Or RichTextBox2.Text = questions(3)) = True Then

            TextBox4.Text = TextBox4.Text + 1

        End If
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            CheckBox4.Checked = False

        End If
        If i = 1 Or i = 7 Or i = 3 Then
            If CheckBox2.Checked = False Then

                TextBox4.Text = TextBox4.Text - 1

            End If
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked And (RichTextBox2.Text = questions(8) Or RichTextBox2.Text = questions(10)) = True Then

            TextBox4.Text = TextBox4.Text + 1

        End If
        If CheckBox4.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox1.Checked = False


        End If
        If i = 8 Or i = 10 Then

            If CheckBox4.Checked = False Then

                TextBox4.Text = TextBox4.Text - 1

            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = i + 1
        If i <= 12 Then
            RichTextBox2.Text = questions(i)

        End If
        If i = 1 Then
            CheckBox1.Text = "temple run"
            CheckBox2.Text = "squid game"
            CheckBox3.Text = "Talking tom"
            CheckBox4.Text = "Hill Climb Racing"
        ElseIf i = 4 Then
            CheckBox1.Text = "Shinchan"
            CheckBox2.Text = "Doraemon"
            CheckBox3.Text = "Pinaki & Happy:The Bhoot Bandhus"
            CheckBox4.Text = "Chota Bheem"
        ElseIf i = 6 Then
            CheckBox1.Text = "Maybe"
            CheckBox2.Text = "yes"
            CheckBox3.Text = "no"
            CheckBox4.Text = "None of the above"
        ElseIf i = 9 Then
            CheckBox1.Text = "blue"
            CheckBox2.Text = "Red"
            CheckBox3.Text = "Black"
            CheckBox4.Text = "Orange"
        ElseIf i = 3 Then

            CheckBox1.Text = "Rasgulla"
            CheckBox2.Text = "Chocolate"
            CheckBox3.Text = "Gulab Jamun"
            CheckBox4.Text = "Ghevar"

        ElseIf i = 7 Then
            CheckBox1.Text = "Ridhi"
            CheckBox2.Text = "Aryash"
            CheckBox3.Text = "Sarvagya"
            CheckBox4.Text = "Devendra Kumar Pandey"
        ElseIf i = 2 Then
            CheckBox1.Text = "French Fries"
            CheckBox2.Text = "Pizza"
            CheckBox3.Text = "Burger"
            CheckBox4.Text = "Pizza McPuff"
        ElseIf i = 5 Then
            CheckBox1.Text = "Butterscotch"
            CheckBox2.Text = "Vanilla"
            CheckBox3.Text = "Chocolate"
            CheckBox4.Text = "Red Velvet"
        ElseIf i = 8 Then
            CheckBox1.Text = "Below the left eye"
            CheckBox2.Text = "On the Forehead"
            CheckBox3.Text = "On the Neck"
            CheckBox4.Text = "Near the top of nose"
        ElseIf i = 10 Then
            CheckBox1.Text = "Ekdum"
            CheckBox2.Text = "Nahi"
            CheckBox3.Text = "Behen"
            CheckBox4.Text = "Bhai"
        ElseIf i = 11 Then
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            CheckBox3.Visible = False
            CheckBox4.Visible = False
            RichTextBox3.Visible = True
        ElseIf i = 12 Then
            CheckBox1.Visible = False
            CheckBox2.Visible = False
            CheckBox3.Visible = False
            CheckBox4.Visible = False
            RichTextBox3.Visible = False
            RichTextBox4.Visible = True
            Button2.Text = "Finish"
        ElseIf i = 13 Then
            Button2.Visible = False
            RichTextBox5.Visible = True
            RichTextBox4.Visible = False
            Timer2.Stop()
            RichTextBox2.Text = "So " + x + " Your Points Are: "
            RichTextBox5.Text = TextBox4.Text
            On Error GoTo lb
            command = New OleDbCommand("INSERT INTO Table1(Name,Points,FirstMeet,QualitiesLiked) VALUES(@Name,@Points,@FirstMeet ,@QualitiesLiked)", conn)
            command.Parameters.AddWithValue("@Name", TextBox5.Text)
            command.Parameters.AddWithValue("@Points", TextBox4.Text)
            command.Parameters.AddWithValue("@FirstMeet", RichTextBox4.Text)
            command.Parameters.AddWithValue("@QualitiesLiked", RichTextBox5.Text)
            conn.Open()
            If command.ExecuteNonQuery() > 0 Then
            End If

            conn.Close()
lb:
        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class
