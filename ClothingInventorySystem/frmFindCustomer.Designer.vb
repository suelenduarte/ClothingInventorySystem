<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindCustomer
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
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.txtSearchByLastName = New System.Windows.Forms.TextBox()
        Me.lblSearchByLastName = New System.Windows.Forms.Label()
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgvCustomers.Location = New System.Drawing.Point(34, 169)
        Me.dgvCustomers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.Size = New System.Drawing.Size(800, 500)
        Me.dgvCustomers.TabIndex = 14
        '
        'txtSearchByLastName
        '
        Me.txtSearchByLastName.Location = New System.Drawing.Point(285, 66)
        Me.txtSearchByLastName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchByLastName.Multiline = True
        Me.txtSearchByLastName.Name = "txtSearchByLastName"
        Me.txtSearchByLastName.Size = New System.Drawing.Size(318, 29)
        Me.txtSearchByLastName.TabIndex = 15
        '
        'lblSearchByLastName
        '
        Me.lblSearchByLastName.AutoSize = True
        Me.lblSearchByLastName.Location = New System.Drawing.Point(62, 74)
        Me.lblSearchByLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchByLastName.Name = "lblSearchByLastName"
        Me.lblSearchByLastName.Size = New System.Drawing.Size(193, 20)
        Me.lblSearchByLastName.TabIndex = 16
        Me.lblSearchByLastName.Text = "Enter a partial Last Name:"
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.BackColor = System.Drawing.Color.DarkMagenta
        Me.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomer.ForeColor = System.Drawing.Color.White
        Me.btnSearchCustomer.Location = New System.Drawing.Point(636, 57)
        Me.btnSearchCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(159, 45)
        Me.btnSearchCustomer.TabIndex = 17
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = False
        '
        'frmFindCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(884, 761)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.lblSearchByLastName)
        Me.Controls.Add(Me.txtSearchByLastName)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmFindCustomer"
        Me.Text = "Find Customer"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents txtSearchByLastName As TextBox
    Friend WithEvents lblSearchByLastName As Label
    Friend WithEvents btnSearchCustomer As Button
End Class
