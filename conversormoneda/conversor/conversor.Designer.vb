<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class conversor
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
        Me.calcular = New System.Windows.Forms.Button()
        Me.borrar = New System.Windows.Forms.Button()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.monedasalida = New System.Windows.Forms.ComboBox()
        Me.total = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Conversión de moneda de peso colombiano a"
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(319, 67)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(75, 23)
        Me.calcular.TabIndex = 1
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(319, 105)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(75, 23)
        Me.borrar.TabIndex = 2
        Me.borrar.Text = "Borrar"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(56, 51)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 23)
        Me.cantidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Peso colombiano"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Es igual a"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(193, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "A"
        '
        'monedasalida
        '
        Me.monedasalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.monedasalida.FormattingEnabled = True
        Me.monedasalida.Items.AddRange(New Object() {"Dólar", "Libra esterlina", "Euro", "Yuan chino", "Rublo Ruso", "Yen japones"})
        Me.monedasalida.Location = New System.Drawing.Point(161, 105)
        Me.monedasalida.Name = "monedasalida"
        Me.monedasalida.Size = New System.Drawing.Size(100, 23)
        Me.monedasalida.TabIndex = 10
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Location = New System.Drawing.Point(182, 154)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(37, 15)
        Me.total.TabIndex = 11
        Me.total.Text = "------"
        '
        'conversor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 209)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.monedasalida)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.Label1)
        Me.Name = "conversor"
        Me.Text = "conversor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents calcular As Button
    Friend WithEvents borrar As Button
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents monedasalida As ComboBox
    Friend WithEvents total As Label
End Class
