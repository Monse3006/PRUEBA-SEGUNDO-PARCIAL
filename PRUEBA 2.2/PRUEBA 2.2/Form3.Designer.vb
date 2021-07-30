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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtMaterno = New System.Windows.Forms.TextBox()
        Me.Seguro = New System.Windows.Forms.TextBox()
        Me.TxtPaterno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboxContra = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataEmpleado = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(916, 356)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 44)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtMaterno
        '
        Me.TxtMaterno.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMaterno.Location = New System.Drawing.Point(173, 97)
        Me.TxtMaterno.Name = "TxtMaterno"
        Me.TxtMaterno.Size = New System.Drawing.Size(203, 27)
        Me.TxtMaterno.TabIndex = 13
        '
        'Seguro
        '
        Me.Seguro.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seguro.Location = New System.Drawing.Point(173, 141)
        Me.Seguro.Name = "Seguro"
        Me.Seguro.Size = New System.Drawing.Size(203, 27)
        Me.Seguro.TabIndex = 12
        '
        'TxtPaterno
        '
        Me.TxtPaterno.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaterno.Location = New System.Drawing.Point(173, 54)
        Me.TxtPaterno.Name = "TxtPaterno"
        Me.TxtPaterno.Size = New System.Drawing.Size(203, 27)
        Me.TxtPaterno.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 22)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Numero Seguro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido Materno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Apellido Paterno"
        '
        'CboxContra
        '
        Me.CboxContra.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboxContra.FormattingEnabled = True
        Me.CboxContra.Items.AddRange(New Object() {"A contrato", "Nombramiento"})
        Me.CboxContra.Location = New System.Drawing.Point(185, 204)
        Me.CboxContra.Name = "CboxContra"
        Me.CboxContra.Size = New System.Drawing.Size(121, 27)
        Me.CboxContra.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tipo de Contrato"
        '
        'DataEmpleado
        '
        Me.DataEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataEmpleado.Location = New System.Drawing.Point(395, 35)
        Me.DataEmpleado.Name = "DataEmpleado"
        Me.DataEmpleado.RowHeadersWidth = 51
        Me.DataEmpleado.RowTemplate.Height = 24
        Me.DataEmpleado.Size = New System.Drawing.Size(679, 150)
        Me.DataEmpleado.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "Apellido Paterno"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido Materno"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Numero de Seguro"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Contrato"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sueldo"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(325, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 44)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(1082, 443)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataEmpleado)
        Me.Controls.Add(Me.CboxContra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMaterno)
        Me.Controls.Add(Me.Seguro)
        Me.Controls.Add(Me.TxtPaterno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "EMPLEADO"
        CType(Me.DataEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TxtMaterno As TextBox
    Friend WithEvents Seguro As TextBox
    Friend WithEvents TxtPaterno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CboxContra As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataEmpleado As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
