Imports Microsoft.VisualBasic
Imports System
Namespace dxKB13085
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.button1 = New System.Windows.Forms.Button
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Location = New System.Drawing.Point(80, 86)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(131, 65)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Show Designer"
            Me.button1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(292, 266)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

