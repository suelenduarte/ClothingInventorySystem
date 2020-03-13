<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindProduct
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
        Me.btnSearchProducts = New System.Windows.Forms.Button()
        Me.lblSearchByName = New System.Windows.Forms.Label()
        Me.txtSearchByProductName = New System.Windows.Forms.TextBox()
        Me.dvgProducts = New System.Windows.Forms.DataGridView()
        CType(Me.dvgProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearchProducts
        '
        Me.btnSearchProducts.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnSearchProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchProducts.ForeColor = System.Drawing.Color.White
        Me.btnSearchProducts.Location = New System.Drawing.Point(621, 47)
        Me.btnSearchProducts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearchProducts.Name = "btnSearchProducts"
        Me.btnSearchProducts.Size = New System.Drawing.Size(172, 42)
        Me.btnSearchProducts.TabIndex = 21
        Me.btnSearchProducts.Text = "Search"
        Me.btnSearchProducts.UseVisualStyleBackColor = False
        '
        'lblSearchByName
        '
        Me.lblSearchByName.AutoSize = True
        Me.lblSearchByName.Location = New System.Drawing.Point(38, 58)
        Me.lblSearchByName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchByName.Name = "lblSearchByName"
        Me.lblSearchByName.Size = New System.Drawing.Size(189, 20)
        Me.lblSearchByName.TabIndex = 20
        Me.lblSearchByName.Text = "Search Product by Name:"
        '
        'txtSearchByProductName
        '
        Me.txtSearchByProductName.Location = New System.Drawing.Point(258, 54)
        Me.txtSearchByProductName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchByProductName.Multiline = True
        Me.txtSearchByProductName.Name = "txtSearchByProductName"
        Me.txtSearchByProductName.Size = New System.Drawing.Size(305, 26)
        Me.txtSearchByProductName.TabIndex = 19
        '
        'dvgProducts
        '
        Me.dvgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dvgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgProducts.Location = New System.Drawing.Point(18, 129)
        Me.dvgProducts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dvgProducts.Name = "dvgProducts"
        Me.dvgProducts.Size = New System.Drawing.Size(800, 500)
        Me.dvgProducts.TabIndex = 18
        '
        'frmFindProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(884, 761)
        Me.Controls.Add(Me.btnSearchProducts)
        Me.Controls.Add(Me.lblSearchByName)
        Me.Controls.Add(Me.txtSearchByProductName)
        Me.Controls.Add(Me.dvgProducts)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmFindProduct"
        Me.Text = "frmFindProduct"
        CType(Me.dvgProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearchProducts As Button
    Friend WithEvents lblSearchByName As Label
    Friend WithEvents txtSearchByProductName As TextBox
    Friend WithEvents dvgProducts As DataGridView
End Class
