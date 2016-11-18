<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtPage = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(136, 146)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(56, 23)
        Me.btnOk.TabIndex = 10
        Me.btnOk.Text = "確定"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtPage
        '
        Me.txtPage.Location = New System.Drawing.Point(61, 106)
        Me.txtPage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPage.Name = "txtPage"
        Me.txtPage.Size = New System.Drawing.Size(132, 22)
        Me.txtPage.TabIndex = 9
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(61, 64)
        Me.txtAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(132, 22)
        Me.txtAdd.TabIndex = 8
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(61, 23)
        Me.txtCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(132, 22)
        Me.txtCompany.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "網站"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "住址"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "公司"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 188)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtPage)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnOk As System.Windows.Forms.Button
    Private WithEvents txtPage As System.Windows.Forms.TextBox
    Private WithEvents txtAdd As System.Windows.Forms.TextBox
    Private WithEvents txtCompany As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label

End Class
