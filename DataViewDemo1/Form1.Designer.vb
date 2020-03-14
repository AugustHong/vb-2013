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

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbAsc = New System.Windows.Forms.RadioButton()
        Me.rdbDesc = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbMath = New System.Windows.Forms.RadioButton()
        Me.rdbEng = New System.Windows.Forms.RadioButton()
        Me.rdbChi = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(527, 15)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(70, 24)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "確定"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbAsc)
        Me.GroupBox2.Controls.Add(Me.rdbDesc)
        Me.GroupBox2.Location = New System.Drawing.Point(527, 55)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(70, 90)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "排序方式"
        '
        'rdbAsc
        '
        Me.rdbAsc.AutoSize = True
        Me.rdbAsc.Location = New System.Drawing.Point(5, 40)
        Me.rdbAsc.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbAsc.Name = "rdbAsc"
        Me.rdbAsc.Size = New System.Drawing.Size(47, 16)
        Me.rdbAsc.TabIndex = 1
        Me.rdbAsc.TabStop = True
        Me.rdbAsc.Text = "遞減"
        Me.rdbAsc.UseVisualStyleBackColor = True
        '
        'rdbDesc
        '
        Me.rdbDesc.AutoSize = True
        Me.rdbDesc.Location = New System.Drawing.Point(5, 20)
        Me.rdbDesc.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbDesc.Name = "rdbDesc"
        Me.rdbDesc.Size = New System.Drawing.Size(47, 16)
        Me.rdbDesc.TabIndex = 0
        Me.rdbDesc.TabStop = True
        Me.rdbDesc.Text = "遞增"
        Me.rdbDesc.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtFilter)
        Me.GroupBox3.Location = New System.Drawing.Point(442, 171)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(155, 60)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "篩選條件式"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(14, 24)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(138, 22)
        Me.txtFilter.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbMath)
        Me.GroupBox1.Controls.Add(Me.rdbEng)
        Me.GroupBox1.Controls.Add(Me.rdbChi)
        Me.GroupBox1.Location = New System.Drawing.Point(442, 55)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(70, 90)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "排序欄位"
        '
        'rdbMath
        '
        Me.rdbMath.AutoSize = True
        Me.rdbMath.Location = New System.Drawing.Point(5, 62)
        Me.rdbMath.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbMath.Name = "rdbMath"
        Me.rdbMath.Size = New System.Drawing.Size(47, 16)
        Me.rdbMath.TabIndex = 2
        Me.rdbMath.TabStop = True
        Me.rdbMath.Text = "數學"
        Me.rdbMath.UseVisualStyleBackColor = True
        '
        'rdbEng
        '
        Me.rdbEng.AutoSize = True
        Me.rdbEng.Location = New System.Drawing.Point(5, 41)
        Me.rdbEng.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbEng.Name = "rdbEng"
        Me.rdbEng.Size = New System.Drawing.Size(47, 16)
        Me.rdbEng.TabIndex = 1
        Me.rdbEng.TabStop = True
        Me.rdbEng.Text = "英文"
        Me.rdbEng.UseVisualStyleBackColor = True
        '
        'rdbChi
        '
        Me.rdbChi.AutoSize = True
        Me.rdbChi.Location = New System.Drawing.Point(5, 20)
        Me.rdbChi.Margin = New System.Windows.Forms.Padding(2)
        Me.rdbChi.Name = "rdbChi"
        Me.rdbChi.Size = New System.Drawing.Size(47, 16)
        Me.rdbChi.TabIndex = 0
        Me.rdbChi.TabStop = True
        Me.rdbChi.Text = "國文"
        Me.rdbChi.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 53)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(396, 176)
        Me.DataGridView1.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "碁峰大學資管甲班成績單"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 248)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnOk As System.Windows.Forms.Button
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents rdbAsc As System.Windows.Forms.RadioButton
    Private WithEvents rdbDesc As System.Windows.Forms.RadioButton
    Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents txtFilter As System.Windows.Forms.TextBox
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rdbMath As System.Windows.Forms.RadioButton
    Private WithEvents rdbEng As System.Windows.Forms.RadioButton
    Private WithEvents rdbChi As System.Windows.Forms.RadioButton
    Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents Label1 As System.Windows.Forms.Label

End Class
