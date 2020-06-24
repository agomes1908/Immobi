<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilho
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbBorderRight1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pbBorderbotom1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbBorderLeft1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pbBorderTop1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Location = New System.Drawing.Point(986, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 398)
        Me.Panel1.TabIndex = 49
        '
        'pbBorderRight1
        '
        Me.pbBorderRight1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderRight1.Location = New System.Drawing.Point(1003, 135)
        Me.pbBorderRight1.Name = "pbBorderRight1"
        Me.pbBorderRight1.Size = New System.Drawing.Size(5, 409)
        Me.pbBorderRight1.TabIndex = 48
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Location = New System.Drawing.Point(139, 543)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(756, 1)
        Me.Panel4.TabIndex = 51
        '
        'pbBorderbotom1
        '
        Me.pbBorderbotom1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderbotom1.Location = New System.Drawing.Point(139, 563)
        Me.pbBorderbotom1.Name = "pbBorderbotom1"
        Me.pbBorderbotom1.Size = New System.Drawing.Size(762, 5)
        Me.pbBorderbotom1.TabIndex = 50
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Location = New System.Drawing.Point(139, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 397)
        Me.Panel2.TabIndex = 53
        '
        'pbBorderLeft1
        '
        Me.pbBorderLeft1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pbBorderLeft1.Location = New System.Drawing.Point(110, 80)
        Me.pbBorderLeft1.Name = "pbBorderLeft1"
        Me.pbBorderLeft1.Size = New System.Drawing.Size(5, 404)
        Me.pbBorderLeft1.TabIndex = 52
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(206, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(757, 6)
        Me.Panel3.TabIndex = 55
        '
        'pbBorderTop1
        '
        Me.pbBorderTop1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pbBorderTop1.Location = New System.Drawing.Point(206, 44)
        Me.pbBorderTop1.Name = "pbBorderTop1"
        Me.pbBorderTop1.Size = New System.Drawing.Size(767, 5)
        Me.pbBorderTop1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Yi Baiti", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label1.Location = New System.Drawing.Point(455, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 35)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Cadastros"
        '
        'FormFilho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1131, 670)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pbBorderTop1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pbBorderLeft1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.pbBorderbotom1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbBorderRight1)
        Me.Name = "FormFilho"
        Me.Text = "FormFilho"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbBorderRight1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pbBorderbotom1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbBorderLeft1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbBorderTop1 As Panel
    Friend WithEvents Label1 As Label
End Class
