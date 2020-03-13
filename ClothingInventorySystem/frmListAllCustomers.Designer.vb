<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListAllCustomers
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
        Me.dvgCustomers = New System.Windows.Forms.DataGridView()
        CType(Me.dvgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgCustomers
        '
        Me.dvgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dvgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCustomers.GridColor = System.Drawing.Color.DarkOrchid
        Me.dvgCustomers.Location = New System.Drawing.Point(42, 130)
        Me.dvgCustomers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dvgCustomers.Name = "dvgCustomers"
        Me.dvgCustomers.Size = New System.Drawing.Size(800, 500)
        Me.dvgCustomers.TabIndex = 19
        '
        'frmListAllCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(884, 761)
        Me.Controls.Add(Me.dvgCustomers)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmListAllCustomers"
        Me.Text = "All Customers"
        CType(Me.dvgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dvgCustomers As DataGridView
End Class
