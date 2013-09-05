<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtHistorial = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.lvUsuarios = New System.Windows.Forms.ListView()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHistorial
        '
        Me.txtHistorial.BackColor = System.Drawing.Color.White
        Me.txtHistorial.Location = New System.Drawing.Point(12, 27)
        Me.txtHistorial.Multiline = True
        Me.txtHistorial.Name = "txtHistorial"
        Me.txtHistorial.ReadOnly = True
        Me.txtHistorial.Size = New System.Drawing.Size(507, 295)
        Me.txtHistorial.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(662, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'txtMensaje
        '
        Me.txtMensaje.AcceptsReturn = True
        Me.txtMensaje.Location = New System.Drawing.Point(12, 328)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(507, 38)
        Me.txtMensaje.TabIndex = 2
        '
        'lvUsuarios
        '
        Me.lvUsuarios.Location = New System.Drawing.Point(525, 27)
        Me.lvUsuarios.Name = "lvUsuarios"
        Me.lvUsuarios.Size = New System.Drawing.Size(125, 295)
        Me.lvUsuarios.TabIndex = 3
        Me.lvUsuarios.UseCompatibleStateImageBehavior = False
        Me.lvUsuarios.View = System.Windows.Forms.View.List
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(525, 328)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(125, 38)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 378)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.lvUsuarios)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.txtHistorial)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmServer"
        Me.Text = "PiChat - Servidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHistorial As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents txtMensaje As System.Windows.Forms.TextBox
    Friend WithEvents lvUsuarios As System.Windows.Forms.ListView
    Friend WithEvents btnEnviar As System.Windows.Forms.Button

End Class
