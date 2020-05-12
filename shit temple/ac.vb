Imports System.ComponentModel
Imports System.IO

Public Class ac
    Private Declare Function apimouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal key As Integer) As Integer

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Public Const MOUSEEVENTF_MIDDLEUP = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN = &H8
    Public Const MOUSEEVENTF_RIGHTUP = &H10
    Public Const MOUSEEVENTF_MOVE = &H1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If MouseButtons = MouseButtons.Left Then
            apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        End If
    End Sub

    Private Sub HexButton1_Click(sender As Object, e As EventArgs) Handles HexButton1.Click
        If HexButton1.Text = "Stop" Then
            HexButton1.Text = "Start"
            Timer1.Stop()
        ElseIf HexButton1.Text = "Start" Then
            HexButton1.Text = "Stop"
            Timer1.Start()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://youtube.com/bhopminecraft")
    End Sub

    Private Sub ac_Load(sender As Object, e As EventArgs) Handles Me.Load
        keybinds.Start()

        Timer1.Interval = 65
    End Sub

    Private Sub ac_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Dim nameofexe As String = AppDomain.CurrentDomain.FriendlyName  'Deletes from Prefetch The File.
        Dim d As DirectoryInfo = New DirectoryInfo("C:\Windows\Prefetch")
        Dim Files As FileInfo() = d.GetFiles(nameofexe & "*")

        For Each file As FileInfo In Files
            file.Delete()
        Next

        Me.Close()

        HexButton1.Dispose()
        HexTheme1.Dispose()
        HexClose1.Dispose()


    End Sub

    Private Sub Keybinds_Tick(sender As Object, e As EventArgs) Handles keybinds.Tick 'Keybinds
        If GetAsyncKeyState(Keys.F4) Then
            If Timer1.Enabled = True Then
                HexButton1.Text = "Start"
                Timer1.Stop()
            Else
                HexButton1.Text = "Stop"
                Timer1.Start()
            End If
        End If

        If GetAsyncKeyState(Keys.F5) Then
            If Me.Visible = True Then
                Me.Visible = False
                Me.ShowInTaskbar = False
            Else
                Me.Visible = True
                Me.ShowInTaskbar = True
            End If
        End If
    End Sub


    Private Sub HexClose1_Click(sender As Object, e As EventArgs) Handles HexClose1.Click

        Me.Close()

        Dim nameofexe As String = AppDomain.CurrentDomain.FriendlyName  'Deletes from Prefetch The File.
        Dim d As DirectoryInfo = New DirectoryInfo("C:\Windows\Prefetch")
        Dim Files As FileInfo() = d.GetFiles(nameofexe & "*")

        For Each file As FileInfo In Files
            file.Delete()
        Next


        'Form
        HexMini1.Dispose()
        HexButton1.Dispose()
        HexTheme1.Dispose()
        HexClose1.Dispose()

        'Label
        Label1.Dispose()
        Label2.Dispose()
        Label3.Dispose()


    End Sub
End Class