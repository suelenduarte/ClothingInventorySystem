<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListAllProductsInCategory
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
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.lblSearchByCategory = New System.Windows.Forms.Label()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCategory
        '
        Me.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCategory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategory.Location = New System.Drawing.Point(34, 107)
        Me.dgvCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.Size = New System.Drawing.Size(800, 556)
        Me.dgvCategory.TabIndex = 16
        '
        'cboCategories
        '
        Me.cboCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategories.ForeColor = System.Drawing.Color.White
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Location = New System.Drawing.Point(418, 49)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(272, 21)
        Me.cboCategories.TabIndex = 54
        '
        'lblSearchByCategory
        '
        Me.lblSearchByCategory.AutoSize = True
        Me.lblSearchByCategory.Location = New System.Drawing.Point(171, 49)
        Me.lblSearchByCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchByCategory.Name = "lblSearchByCategory"
        Me.lblSearchByCategory.Size = New System.Drawing.Size(211, 20)
        Me.lblSearchByCategory.TabIndex = 55
        Me.lblSearchByCategory.Text = "Search Product by Category:"
        '
        'frmListAllProductsInCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(884, 846)
        Me.Controls.Add(Me.lblSearchByCategory)
        Me.Controls.Add(Me.cboCategories)
        Me.Controls.Add(Me.dgvCategory)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmListAllProductsInCategory"
        Me.Text = "Products with Category"
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCategory As DataGridView
    Private WithEvents cboCategories As ComboBox
    Friend WithEvents lblSearchByCategory As Label
End Class
