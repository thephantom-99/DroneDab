<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.DroneVendingMachine1 = New DroneDad.DroneVendingMachine()
        Me.ShoppingCart = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DroneVendingMachine1
        '
        Me.DroneVendingMachine1.Location = New System.Drawing.Point(21, 12)
        Me.DroneVendingMachine1.Name = "DroneVendingMachine"
        Me.DroneVendingMachine1.Name = "DroneVendingMachine1"
        Me.DroneVendingMachine1.price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.DroneVendingMachine1.Size = New System.Drawing.Size(168, 148)
        Me.DroneVendingMachine1.TabIndex = 0
        '
        'ShoppingCart
        '
        Me.ShoppingCart.AutoSize = True
        Me.ShoppingCart.Location = New System.Drawing.Point(697, 358)
        Me.ShoppingCart.Name = "ShoppingCart"
        Me.ShoppingCart.Size = New System.Drawing.Size(53, 20)
        Me.ShoppingCart.TabIndex = 1
        Me.ShoppingCart.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ShoppingCart)
        Me.Controls.Add(Me.DroneVendingMachine1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DroneVendingMachine1 As DroneVendingMachine
    Friend WithEvents ShoppingCart As Label
End Class
