<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class appfracciones
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.txtd1 = New System.Windows.Forms.TextBox()
        Me.txtd2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrd = New System.Windows.Forms.TextBox()
        Me.txtrn = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Suma = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Resta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(39, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suma y resta de fraccionarios de igual denominador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(75, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fracción 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(75, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fracción 2"
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(209, 125)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(64, 23)
        Me.txtn1.TabIndex = 3
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(209, 170)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(64, 23)
        Me.txtn2.TabIndex = 4
        '
        'txtd1
        '
        Me.txtd1.Location = New System.Drawing.Point(318, 125)
        Me.txtd1.Name = "txtd1"
        Me.txtd1.Size = New System.Drawing.Size(64, 23)
        Me.txtd1.TabIndex = 5
        '
        'txtd2
        '
        Me.txtd2.Location = New System.Drawing.Point(318, 170)
        Me.txtd2.Name = "txtd2"
        Me.txtd2.Size = New System.Drawing.Size(64, 23)
        Me.txtd2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(287, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "/"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(287, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "/"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(287, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "/"
        '
        'txtrd
        '
        Me.txtrd.Enabled = False
        Me.txtrd.Location = New System.Drawing.Point(318, 220)
        Me.txtrd.Name = "txtrd"
        Me.txtrd.Size = New System.Drawing.Size(64, 23)
        Me.txtrd.TabIndex = 11
        '
        'txtrn
        '
        Me.txtrn.Enabled = False
        Me.txtrn.Location = New System.Drawing.Point(209, 220)
        Me.txtrn.Name = "txtrn"
        Me.txtrn.Size = New System.Drawing.Size(64, 23)
        Me.txtrn.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(75, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Resultado"
        '
        'Suma
        '
        Me.Suma.Location = New System.Drawing.Point(420, 125)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(108, 23)
        Me.Suma.TabIndex = 13
        Me.Suma.Text = "Suma"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(420, 222)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(108, 23)
        Me.Borrar.TabIndex = 14
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.Location = New System.Drawing.Point(420, 170)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(108, 23)
        Me.Resta.TabIndex = 15
        Me.Resta.Text = "Resta"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'appfracciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 331)
        Me.Controls.Add(Me.Resta)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Suma)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtrd)
        Me.Controls.Add(Me.txtrn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtd2)
        Me.Controls.Add(Me.txtd1)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "appfracciones"
        Me.Text = "fracciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtn1 As TextBox
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents txtd1 As TextBox
    Friend WithEvents txtd2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtrd As TextBox
    Friend WithEvents txtrn As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Suma As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Resta As Button
End Class
