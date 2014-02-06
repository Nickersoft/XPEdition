Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports IWshRuntimeLibrary
Public Class UserControl
    <DllImport("user32")>
    Private Shared Function BringWindowToTop(ByVal hwnd As Integer) As Integer
    End Function
    Dim path As String = Application.StartupPath + "\Users\" + Login.UsernameTextBox.Text + "\UserInfo"
    Dim FILE_NAME As String = path + "\Home.txt"
    Dim medirectory As String = Application.StartupPath + "\Users"
    Private Sub daccountbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles daccountbttn.Click
        MsgBox("Are you absolutely sure you want to delete your XPEdition account?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            beef.Close()
            Dim bg As String = medirectory + "\" + Login.UsernameTextBox.Text
            Try
                Kill(bg + "\Temp\*.*")
                RmDir(bg + "\Temp")
            Catch
                RmDir(bg + "\Temp")
            End Try
            Try
                Kill(bg + "\Userinfo\*.*")
                RmDir(bg + "\Userinfo")
            Catch
                RmDir(bg + "\Userinfo")
            End Try
            Try
                Kill(bg + "\Bookmarks\*.*")
            Catch
                RmDir(bg + "\Bookmarks")
            End Try
            RmDir(bg)
            Login.Show()
            Me.Close()
            beef.Close()
            For Each ctrl As Form In Application.OpenForms
                ctrl.Close()
            Next
        Else
            Exit Sub
        End If
    End Sub

    Private Sub UserControl_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        beef.PictureBox10.BackColor = Color.Transparent
        beef.PictureBox10.BackgroundImage = Nothing
    End Sub
    Private Sub UserControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = beef
    End Sub


    Private Sub vcdbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vcdbttn.Click
        Dim lun As String = medirectory + "\" + Login.UsernameTextBox.Text
        Dim p As Process = Process.Start("Explorer", lun)
        BringWindowToTop(p.Handle.ToInt32())
    End Sub

    Private Sub encodecheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encodecheck.CheckedChanged
        If encodecheck.Checked = True Then
            ptxt.UseSystemPasswordChar = True
        Else
            ptxt.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub okexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okexit.Click
        Me.Close()
    End Sub

    Private Sub changepassbttn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changepassbttn.Click
        main()
    End Sub
    Private Sub main()
        Try
            Dim FILE_NAME As String = Application.StartupPath + "\Users\" + Login.UsernameTextBox.Text + "\userinfo\usercredentials.ini"
            Dim a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z As String
            Dim CA, CB, CC, CD, CE, CF, CG, CH, CI, CJ, CK, CL, CM, CN, CO, CP, CQ, CR, CS, CT, CU, CV, CW, CX, CY, CZ As String
            Dim num1, num2, num3, num4, num5, num6, num7, num8, num9, num0 As String
            Dim outcome As String

            num1 = "1"
            num2 = "2"
            num3 = "3"
            num4 = "4"
            num5 = "5"
            num6 = "6"
            num7 = "7"
            num8 = "8"
            num9 = "9"
            num0 = "0"

            a = "a"
            b = "b"
            c = "c"
            d = "d"
            e = "e"
            f = "f"
            g = "g"
            h = "h"
            i = "i"
            j = "j"
            k = "k"
            l = "l"
            m = "m"
            n = "n"
            o = "o"
            p = "p"
            q = "q"
            r = "r"
            s = "s"
            t = "t"
            u = "u"
            v = "v"
            w = "w"
            x = "x"
            y = "y"
            z = "z"


            CA = "A"
            CB = "B"
            CC = "C"
            CD = "D"
            CE = "E"
            CF = "F"
            CG = "G"
            CH = "H"
            CI = "I"
            CJ = "J"
            CK = "K"
            CL = "L"
            CM = "M"
            CN = "N"
            CO = "O"
            CP = "P"
            CQ = "Q"
            CR = "R"
            CS = "S"
            CT = "T"
            CU = "U"
            CV = "V"
            CW = "W"
            CX = "X"
            CY = "Y"
            CZ = "Z"

            outcome = ptxt.Text

            outcome = Replace(outcome, a, "1")
            outcome = Replace(outcome, b, "2")
            outcome = Replace(outcome, c, "3")
            outcome = Replace(outcome, d, "4")
            outcome = Replace(outcome, e, "5")
            outcome = Replace(outcome, f, "6")
            outcome = Replace(outcome, g, "7")
            outcome = Replace(outcome, h, "8")
            outcome = Replace(outcome, i, "9")
            outcome = Replace(outcome, j, "0")
            outcome = Replace(outcome, k, "a")
            outcome = Replace(outcome, l, "b")
            outcome = Replace(outcome, m, "c")
            outcome = Replace(outcome, n, "d")
            outcome = Replace(outcome, o, "e")
            outcome = Replace(outcome, p, "f")
            outcome = Replace(outcome, q, "g")
            outcome = Replace(outcome, r, "h")
            outcome = Replace(outcome, s, "i")
            outcome = Replace(outcome, t, "j")
            outcome = Replace(outcome, u, "k")
            outcome = Replace(outcome, v, "l")
            outcome = Replace(outcome, w, "m")
            outcome = Replace(outcome, x, "n")
            outcome = Replace(outcome, y, "o")
            outcome = Replace(outcome, z, "p")

            outcome = Replace(outcome, CA, "q")
            outcome = Replace(outcome, CB, "r")
            outcome = Replace(outcome, CC, "s")
            outcome = Replace(outcome, CD, "t")
            outcome = Replace(outcome, CF, "u")
            outcome = Replace(outcome, CG, "v")
            outcome = Replace(outcome, CH, "w")
            outcome = Replace(outcome, CI, "x")
            outcome = Replace(outcome, CJ, "y")
            outcome = Replace(outcome, CK, "z")
            outcome = Replace(outcome, CL, "9")
            outcome = Replace(outcome, CM, "8")
            outcome = Replace(outcome, CN, "7")
            outcome = Replace(outcome, CO, "6")
            outcome = Replace(outcome, CP, "5")
            outcome = Replace(outcome, CQ, "4")
            outcome = Replace(outcome, CR, "3")
            outcome = Replace(outcome, CS, "2")
            outcome = Replace(outcome, CT, "1")
            outcome = Replace(outcome, CU, "0")
            outcome = Replace(outcome, CV, "a")
            outcome = Replace(outcome, CW, "b")
            outcome = Replace(outcome, CX, "c")
            outcome = Replace(outcome, CY, "d")
            outcome = Replace(outcome, CZ, "e")

            outcome = Replace(outcome, num1, "9")
            outcome = Replace(outcome, num2, "8")
            outcome = Replace(outcome, num3, "7")
            outcome = Replace(outcome, num4, "6")
            outcome = Replace(outcome, num5, "5")
            outcome = Replace(outcome, num6, "4")
            outcome = Replace(outcome, num7, "3")
            outcome = Replace(outcome, num8, "2")
            outcome = Replace(outcome, num9, "1")
            outcome = Replace(outcome, num0, "0")

            Dim lbl As New Label
            lbl.Text = outcome
            Dim hi As String = IO.File.ReadLines(FILE_NAME)(2)
            Dim lala As New Label
            lala.Text = hi
            Dim fn As String = IO.File.ReadLines(FILE_NAME)(3)
            Dim fnl As New Label
            fnl.Text = fn
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
            objWriter.Write(Login.UsernameTextBox.Text + vbCrLf + lbl.Text + vbCrLf + lala.Text + vbCrLf + fnl.Text)
            objWriter.Close()
            MsgBox("Password set!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If IO.File.Exists(path + "\Home.txt") Then
            Kill(path + "\Home.txt")
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(TextBox1.Text)
            objWriter.Close()
            MsgBox("Homepage Set!")
        Else
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
            objWriter.Write(TextBox1.Text)
            objWriter.Close()
            MsgBox("Homepage Set!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            ToLetYaKnow.Text = "Browsing History"
            Dim read As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\Users\" + "\" + Login.UsernameTextBox.Text + "\Userinfo\History.txt")
            ToLetYaKnow.TextBox1.Text = read
            ToLetYaKnow.Show()
        Catch ex As Exception
            MsgBox("No browsing history found!")
        End Try
    End Sub
    Private Sub lala()
        Dim hispath As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Userinfo\History.txt"
        Dim uc As String = Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\UserControl.epc"
        If IO.File.Exists(uc) Then
            Dim parent As String = My.Computer.FileSystem.ReadAllText(uc)
            Dim chis As String = My.Computer.FileSystem.ReadAllText(hispath)
            Dim rat As New StreamWriter(Application.StartupPath & "\Users\" & parent & "\UserInfo\ChildHistoryList.txt", True)
            rat.Write(chis)
            rat.Close()
            Kill(hispath)
            MsgBox("History cleared!")
        Else
            Kill(hispath)
            MsgBox("History cleared!")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim hispath As String = medirectory + "\" + Login.UsernameTextBox.Text + "\Userinfo\History.txt"
            Kill(hispath)
            MsgBox("History cleared!")
        Catch ex As Exception
            MsgBox("No browsing history found!")
        End Try
    End Sub

    Private Sub UserControl_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub UserControl_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.BackColor = beef.BackColor

        Dim pcname As String = System.Environment.MachineName
        Dim username As String = System.Environment.UserName
        Dim osfull As String = My.Computer.Info.OSFullName
        Dim osplat As String = My.Computer.Info.OSPlatform
        Dim osver As String = My.Computer.Info.OSVersion
        Dim oslan As String = My.Computer.Info.InstalledUICulture.ToString
        Label1.Text = "Computer Name: " + pcname
        Label2.Text = "Current User: " + username
        Label3.Text = "Operating System: " + osfull
        Label4.Text = "Platform: " + osplat
        Label5.Text = "Version: " + osver
        Label6.Text = "Language: " + oslan


        Dim funame As String = IO.File.ReadLines(Application.StartupPath + "\Users\" & "\" & Login.UsernameTextBox.Text & "\Userinfo\usercredentials.ini")(3)
        fname.Text = "Full Name: " & funame
        Label12.Text = "Username: " & Login.UsernameTextBox.Text


        Dim ainfo As IO.DirectoryInfo
        ainfo = My.Computer.FileSystem.GetDirectoryInfo(medirectory + "\" + Login.UsernameTextBox.Text)
        Label9.Text = "Account created on: " & ainfo.CreationTime
        Label10.Text = "Last logged in: " & ainfo.LastAccessTime
        Label11.Text = "Last modified: " & ainfo.LastWriteTime


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim FILE_NAME As String = Application.StartupPath + "\Users\" + Login.UsernameTextBox.Text + "\userinfo\usercredentials.ini"
            Dim u As String = IO.File.ReadLines(FILE_NAME)(0)
            Dim lala As New Label
            lala.Text = u
            Dim p As String = IO.File.ReadLines(FILE_NAME)(1)
            Dim pl As New Label
            pl.Text = p
            Dim fn As String = IO.File.ReadLines(FILE_NAME)(3)
            Dim fnl As New Label
            fnl.Text = fn
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
            objWriter.Write(utxt.Text + vbCrLf + lala.Text + vbCrLf + utxt.Text + vbCrLf + fnl.Text)
            objWriter.Close()
            MsgBox("Password hint set!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Dim r As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(0)
            Dim l As New Label
            l.Text = r
            Dim w As New StreamWriter(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt", False)
            w.Write(l.Text & vbCrLf & "Yes")
            w.Close()
        Else
            Dim r As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(0)
            Dim l As New Label
            l.Text = r
            Dim w As New StreamWriter(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt", False)
            w.Write(l.Text & vbCrLf & "No")
            w.Close()
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Dim r As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(1)
            Dim l As New Label
            l.Text = r
            Dim w As New StreamWriter(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt", False)
            w.Write(l.Text & vbCrLf & "Yes")
            w.Close()
        Else
            Dim r As String = IO.File.ReadLines(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt")(1)
            Dim l As New Label
            l.Text = r
            Dim w As New StreamWriter(Application.StartupPath & "\Users\" & Login.UsernameTextBox.Text & "\showdialog.txt", False)
            w.Write(l.Text & vbCrLf & "No")
            w.Close()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Welcome.Show()
        Welcome.BringToFront()
    End Sub
End Class