<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.botonmenos = New System.Windows.Forms.Button()
        Me.botonmas = New System.Windows.Forms.Button()
        Me.preciotextbox = New System.Windows.Forms.TextBox()
        Me.cantidadtextbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplicacion de tienda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(157, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calcular Subtotal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(157, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 36)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Calcular IVA"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(157, 306)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 29)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Calcular Total"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Subtotal:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(344, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "IVA(16%): "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "TOTAL:"
        '
        'botonmenos
        '
        Me.botonmenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonmenos.Location = New System.Drawing.Point(257, 167)
        Me.botonmenos.Name = "botonmenos"
        Me.botonmenos.Size = New System.Drawing.Size(40, 29)
        Me.botonmenos.TabIndex = 9
        Me.botonmenos.Text = "-1"
        Me.botonmenos.UseVisualStyleBackColor = True
        '
        'botonmas
        '
        Me.botonmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonmas.Location = New System.Drawing.Point(469, 167)
        Me.botonmas.Name = "botonmas"
        Me.botonmas.Size = New System.Drawing.Size(38, 29)
        Me.botonmas.TabIndex = 10
        Me.botonmas.Text = "+1"
        Me.botonmas.UseVisualStyleBackColor = True
        '
        'preciotextbox
        '
        Me.preciotextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preciotextbox.Location = New System.Drawing.Point(244, 128)
        Me.preciotextbox.Name = "preciotextbox"
        Me.preciotextbox.Size = New System.Drawing.Size(100, 26)
        Me.preciotextbox.TabIndex = 11
        Me.preciotextbox.Text = "0"
        '
        'cantidadtextbox
        '
        Me.cantidadtextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidadtextbox.Location = New System.Drawing.Point(330, 170)
        Me.cantidadtextbox.Name = "cantidadtextbox"
        Me.cantidadtextbox.Size = New System.Drawing.Size(100, 26)
        Me.cantidadtextbox.TabIndex = 12
        Me.cantidadtextbox.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(436, 227)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(465, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = " 0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = " 0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(220, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(422, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(412, 310)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(427, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 20)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "$"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cantidadtextbox)
        Me.Controls.Add(Me.preciotextbox)
        Me.Controls.Add(Me.botonmas)
        Me.Controls.Add(Me.botonmenos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents botonmenos As Button
    Friend WithEvents botonmas As Button
    Friend WithEvents preciotextbox As TextBox
    Friend WithEvents cantidadtextbox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
