<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gridPlaymat = New System.Windows.Forms.DataGridView()
        Me.rbPlayer1 = New System.Windows.Forms.RadioButton()
        Me.rbPlayer2 = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gridPlaymat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridPlaymat
        '
        Me.gridPlaymat.AllowUserToAddRows = False
        Me.gridPlaymat.AllowUserToDeleteRows = False
        Me.gridPlaymat.AllowUserToResizeColumns = False
        Me.gridPlaymat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gridPlaymat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.gridPlaymat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gridPlaymat.EnableHeadersVisualStyles = False
        Me.gridPlaymat.Location = New System.Drawing.Point(89, 133)
        Me.gridPlaymat.Name = "gridPlaymat"
        Me.gridPlaymat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridPlaymat.Size = New System.Drawing.Size(343, 141)
        Me.gridPlaymat.TabIndex = 0
        '
        'rbPlayer1
        '
        Me.rbPlayer1.AutoSize = True
        Me.rbPlayer1.Checked = True
        Me.rbPlayer1.Enabled = False
        Me.rbPlayer1.Location = New System.Drawing.Point(89, 53)
        Me.rbPlayer1.Name = "rbPlayer1"
        Me.rbPlayer1.Size = New System.Drawing.Size(79, 17)
        Me.rbPlayer1.TabIndex = 1
        Me.rbPlayer1.TabStop = True
        Me.rbPlayer1.Text = "Player 1 (X)"
        Me.rbPlayer1.UseVisualStyleBackColor = True
        '
        'rbPlayer2
        '
        Me.rbPlayer2.AutoSize = True
        Me.rbPlayer2.Enabled = False
        Me.rbPlayer2.Location = New System.Drawing.Point(342, 53)
        Me.rbPlayer2.Name = "rbPlayer2"
        Me.rbPlayer2.Size = New System.Drawing.Size(80, 17)
        Me.rbPlayer2.TabIndex = 2
        Me.rbPlayer2.Text = "Player 2 (O)"
        Me.rbPlayer2.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(217, 91)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = ""
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = ""
        Me.Column3.Name = "Column3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 345)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.rbPlayer2)
        Me.Controls.Add(Me.rbPlayer1)
        Me.Controls.Add(Me.gridPlaymat)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gridPlaymat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridPlaymat As DataGridView
    Friend WithEvents rbPlayer1 As RadioButton
    Friend WithEvents rbPlayer2 As RadioButton
    Friend WithEvents btnReset As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
