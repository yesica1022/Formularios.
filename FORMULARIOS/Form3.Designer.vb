<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DescuentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosAgrgadosAlDescuentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescuentosToolStripMenuItem, Me.UsuariosAgrgadosAlDescuentoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DescuentosToolStripMenuItem
        '
        Me.DescuentosToolStripMenuItem.Name = "DescuentosToolStripMenuItem"
        Me.DescuentosToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.DescuentosToolStripMenuItem.Text = "Descuentos "
        '
        'UsuariosAgrgadosAlDescuentoToolStripMenuItem
        '
        Me.UsuariosAgrgadosAlDescuentoToolStripMenuItem.Name = "UsuariosAgrgadosAlDescuentoToolStripMenuItem"
        Me.UsuariosAgrgadosAlDescuentoToolStripMenuItem.Size = New System.Drawing.Size(192, 20)
        Me.UsuariosAgrgadosAlDescuentoToolStripMenuItem.Text = "Usuarios agregados al descuento"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DescuentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosAgrgadosAlDescuentoToolStripMenuItem As ToolStripMenuItem
End Class
