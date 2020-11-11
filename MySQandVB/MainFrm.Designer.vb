<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

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
        Me.dataList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.fnameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mnameTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnameTxt = New System.Windows.Forms.TextBox()
        Me.ID_Label = New System.Windows.Forms.Label()
        Me.clearBtn = New System.Windows.Forms.Button()
        CType(Me.dataList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataList
        '
        Me.dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dataList.Location = New System.Drawing.Point(275, 52)
        Me.dataList.Name = "dataList"
        Me.dataList.Size = New System.Drawing.Size(370, 274)
        Me.dataList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Firstname"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Middlename"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Lastname"
        Me.Column4.Name = "Column4"
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(20, 262)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 23)
        Me.addBtn.TabIndex = 1
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(101, 262)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(75, 23)
        Me.updateBtn.TabIndex = 2
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(182, 262)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(75, 23)
        Me.deleteBtn.TabIndex = 3
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'fnameTxt
        '
        Me.fnameTxt.Location = New System.Drawing.Point(29, 119)
        Me.fnameTxt.Name = "fnameTxt"
        Me.fnameTxt.Size = New System.Drawing.Size(211, 20)
        Me.fnameTxt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Middlename"
        '
        'mnameTxt
        '
        Me.mnameTxt.Location = New System.Drawing.Point(29, 168)
        Me.mnameTxt.Name = "mnameTxt"
        Me.mnameTxt.Size = New System.Drawing.Size(211, 20)
        Me.mnameTxt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Lastname"
        '
        'lnameTxt
        '
        Me.lnameTxt.Location = New System.Drawing.Point(29, 216)
        Me.lnameTxt.Name = "lnameTxt"
        Me.lnameTxt.Size = New System.Drawing.Size(211, 20)
        Me.lnameTxt.TabIndex = 8
        '
        'ID_Label
        '
        Me.ID_Label.AutoSize = True
        Me.ID_Label.Location = New System.Drawing.Point(32, 13)
        Me.ID_Label.Name = "ID_Label"
        Me.ID_Label.Size = New System.Drawing.Size(46, 13)
        Me.ID_Label.TabIndex = 10
        Me.ID_Label.Text = "ID_label"
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(20, 291)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(237, 23)
        Me.clearBtn.TabIndex = 11
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 357)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.ID_Label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lnameTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mnameTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fnameTxt)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.dataList)
        Me.Name = "MainFrm"
        Me.Text = "Mysql And VB Simple Crud"
        CType(Me.dataList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataList As System.Windows.Forms.DataGridView
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents updateBtn As System.Windows.Forms.Button
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents fnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_Label As System.Windows.Forms.Label
    Friend WithEvents clearBtn As System.Windows.Forms.Button

End Class
