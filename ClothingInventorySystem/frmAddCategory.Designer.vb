<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCategory
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
        Me.lblCategoryId = New System.Windows.Forms.Label()
        Me.lblCategoryName = New System.Windows.Forms.Label()
        Me.txtCategoryId = New System.Windows.Forms.TextBox()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.lbxCategory = New System.Windows.Forms.ListBox()
        Me.lblCategoryDescription = New System.Windows.Forms.Label()
        Me.txtCategoryDescription = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCategoryId
        '
        Me.lblCategoryId.AutoSize = True
        Me.lblCategoryId.Location = New System.Drawing.Point(62, 43)
        Me.lblCategoryId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoryId.Name = "lblCategoryId"
        Me.lblCategoryId.Size = New System.Drawing.Size(95, 20)
        Me.lblCategoryId.TabIndex = 0
        Me.lblCategoryId.Text = "Category Id:"
        '
        'lblCategoryName
        '
        Me.lblCategoryName.AutoSize = True
        Me.lblCategoryName.Location = New System.Drawing.Point(60, 106)
        Me.lblCategoryName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoryName.Name = "lblCategoryName"
        Me.lblCategoryName.Size = New System.Drawing.Size(123, 20)
        Me.lblCategoryName.TabIndex = 1
        Me.lblCategoryName.Text = "Category Name:"
        '
        'txtCategoryId
        '
        Me.txtCategoryId.Enabled = False
        Me.txtCategoryId.Location = New System.Drawing.Point(200, 40)
        Me.txtCategoryId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCategoryId.Name = "txtCategoryId"
        Me.txtCategoryId.Size = New System.Drawing.Size(148, 26)
        Me.txtCategoryId.TabIndex = 2
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Location = New System.Drawing.Point(200, 103)
        Me.txtCategoryName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(313, 26)
        Me.txtCategoryName.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(538, 370)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(112, 35)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(278, 370)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(112, 35)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAddCategory
        '
        Me.btnAddCategory.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCategory.ForeColor = System.Drawing.Color.White
        Me.btnAddCategory.Location = New System.Drawing.Point(26, 370)
        Me.btnAddCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(131, 35)
        Me.btnAddCategory.TabIndex = 14
        Me.btnAddCategory.Text = "Add Category"
        Me.btnAddCategory.UseVisualStyleBackColor = False
        '
        'lbxCategory
        '
        Me.lbxCategory.FormattingEnabled = True
        Me.lbxCategory.ItemHeight = 20
        Me.lbxCategory.Location = New System.Drawing.Point(538, 32)
        Me.lbxCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbxCategory.Name = "lbxCategory"
        Me.lbxCategory.Size = New System.Drawing.Size(203, 284)
        Me.lbxCategory.TabIndex = 18
        '
        'lblCategoryDescription
        '
        Me.lblCategoryDescription.AutoSize = True
        Me.lblCategoryDescription.Location = New System.Drawing.Point(22, 154)
        Me.lblCategoryDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategoryDescription.Name = "lblCategoryDescription"
        Me.lblCategoryDescription.Size = New System.Drawing.Size(161, 20)
        Me.lblCategoryDescription.TabIndex = 19
        Me.lblCategoryDescription.Text = "Category Description:"
        '
        'txtCategoryDescription
        '
        Me.txtCategoryDescription.Location = New System.Drawing.Point(193, 154)
        Me.txtCategoryDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCategoryDescription.MaxLength = 150
        Me.txtCategoryDescription.Multiline = True
        Me.txtCategoryDescription.Name = "txtCategoryDescription"
        Me.txtCategoryDescription.Size = New System.Drawing.Size(320, 162)
        Me.txtCategoryDescription.TabIndex = 20
        '
        'frmAddCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(844, 491)
        Me.Controls.Add(Me.txtCategoryDescription)
        Me.Controls.Add(Me.lblCategoryDescription)
        Me.Controls.Add(Me.lbxCategory)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAddCategory)
        Me.Controls.Add(Me.txtCategoryName)
        Me.Controls.Add(Me.txtCategoryId)
        Me.Controls.Add(Me.lblCategoryName)
        Me.Controls.Add(Me.lblCategoryId)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmAddCategory"
        Me.Text = "Add Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCategoryId As Label
    Friend WithEvents lblCategoryName As Label
    Friend WithEvents txtCategoryId As TextBox
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAddCategory As Button
    Friend WithEvents lbxCategory As ListBox
    Friend WithEvents lblCategoryDescription As Label
    Friend WithEvents txtCategoryDescription As TextBox
End Class
