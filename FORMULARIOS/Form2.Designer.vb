<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.PreciosPorMayorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosPorUnidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechasAproxDeEntregasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreciosPorMayorToolStripMenuItem, Me.PreciosPorUnidadToolStripMenuItem, Me.FechasAproxDeEntregasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PreciosPorMayorToolStripMenuItem
        '
        Me.PreciosPorMayorToolStripMenuItem.Name = "PreciosPorMayorToolStripMenuItem"
        Me.PreciosPorMayorToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.PreciosPorMayorToolStripMenuItem.Text = "Catalogo "
        '
        'PreciosPorUnidadToolStripMenuItem
        '
        Me.PreciosPorUnidadToolStripMenuItem.Name = "PreciosPorUnidadToolStripMenuItem"
        Me.PreciosPorUnidadToolStripMenuItem.Size = New System.Drawing.Size(118, 20)
        Me.PreciosPorUnidadToolStripMenuItem.Text = "Precios por mayor "
        '
        'FechasAproxDeEntregasToolStripMenuItem
        '
        Me.FechasAproxDeEntregasToolStripMenuItem.Name = "FechasAproxDeEntregasToolStripMenuItem"
        Me.FechasAproxDeEntregasToolStripMenuItem.Size = New System.Drawing.Size(158, 20)
        Me.FechasAproxDeEntregasToolStripMenuItem.Text = "Fechas aprox. de entregas "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PreciosPorMayorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosPorUnidadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechasAproxDeEntregasToolStripMenuItem As ToolStripMenuItem
End Class
