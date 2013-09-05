Imports System.Net
Imports System.Net.WebSockets

Public Class frmServer

    Dim Socket As New ServerSocket

    Private Sub frmServer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Socket.DetenerEscucha()
        Socket = Nothing
    End Sub

    Private Sub frmServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Socket.Puerto = 9977
        Socket.IniciarEscucha()
    End Sub
End Class
