﻿Public Class CurrentPassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        write()
        
    End Sub
    Private Sub write()
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

        outcome = TextBox1.Text

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
        Dim red As String = IO.File.ReadLines(Application.StartupPath + "\Users\" + Login.UsernameTextBox.Text + "\Userinfo\usercredentials.ini")(1)
        If red = lbl.Text Then
            Main()
            MsgBox("New password set!")
            Me.Close()
        End If
    End Sub
    Private Sub Main()
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

        outcome = UserControl.passtxt.Text

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
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, False)
        objWriter.Write(UserControl.Label12.Text + vbCrLf + lbl.Text + vbCrLf + lala.Text + vbCrLf + UserControl.fname.Text)
        objWriter.Close()
    End Sub
End Class