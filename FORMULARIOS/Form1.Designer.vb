﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTRASEÑAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSRECOMENDADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOToolStripMenuItem, Me.CONTRASEÑAToolStripMenuItem, Me.PRODUCTOSRECOMENDADOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USUARIOToolStripMenuItem
        '
        Me.USUARIOToolStripMenuItem.Name = "USUARIOToolStripMenuItem"
        Me.USUARIOToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.USUARIOToolStripMenuItem.Text = "USUARIO "
        '
        'CONTRASEÑAToolStripMenuItem
        '
        Me.CONTRASEÑAToolStripMenuItem.Name = "CONTRASEÑAToolStripMenuItem"
        Me.CONTRASEÑAToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.CONTRASEÑAToolStripMenuItem.Text = "CONTRASEÑA "
        '
        'PRODUCTOSRECOMENDADOSToolStripMenuItem
        '
        Me.PRODUCTOSRECOMENDADOSToolStripMenuItem.Name = "PRODUCTOSRECOMENDADOSToolStripMenuItem"
        Me.PRODUCTOSRECOMENDADOSToolStripMenuItem.Size = New System.Drawing.Size(187, 20)
        Me.PRODUCTOSRECOMENDADOSToolStripMenuItem.Text = "PRODUCTOS RECOMENDADOS "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents USUARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONTRASEÑAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PRODUCTOSRECOMENDADOSToolStripMenuItem As ToolStripMenuItem
End Class
