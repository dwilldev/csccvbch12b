﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
	Inherits CSCI1620Lab5b.BaseForm

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(235, 107)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(136, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Programmed By: Derek Will"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(273, 140)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(60, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Version 2.0"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(240, 176)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(126, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Last Update 08/05/2018"
		'
		'AboutForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(606, 295)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "AboutForm"
		Me.Text = "AboutForm"
		Me.Controls.SetChildIndex(Me.Label1, 0)
		Me.Controls.SetChildIndex(Me.Label2, 0)
		Me.Controls.SetChildIndex(Me.Label3, 0)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
End Class
