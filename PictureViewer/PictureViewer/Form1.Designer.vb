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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Mostrarunaimagen = New System.Windows.Forms.Button()
        Me.borrarlaimagen = New System.Windows.Forms.Button()
        Me.cambiarfondo = New System.Windows.Forms.Button()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(534, 311)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Mostrarunaimagen)
        Me.FlowLayoutPanel1.Controls.Add(Me.borrarlaimagen)
        Me.FlowLayoutPanel1.Controls.Add(Me.cambiarfondo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Cerrar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(83, 282)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(448, 26)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Mostrarunaimagen
        '
        Me.Mostrarunaimagen.AutoSize = True
        Me.Mostrarunaimagen.Location = New System.Drawing.Point(331, 3)
        Me.Mostrarunaimagen.Name = "Mostrarunaimagen"
        Me.Mostrarunaimagen.Size = New System.Drawing.Size(114, 23)
        Me.Mostrarunaimagen.TabIndex = 0
        Me.Mostrarunaimagen.Text = "Mostrar una Imagen"
        Me.Mostrarunaimagen.UseVisualStyleBackColor = True
        '
        'borrarlaimagen
        '
        Me.borrarlaimagen.AutoSize = True
        Me.borrarlaimagen.Location = New System.Drawing.Point(226, 3)
        Me.borrarlaimagen.Name = "borrarlaimagen"
        Me.borrarlaimagen.Size = New System.Drawing.Size(99, 23)
        Me.borrarlaimagen.TabIndex = 1
        Me.borrarlaimagen.Text = "Borrar la imagen"
        Me.borrarlaimagen.UseVisualStyleBackColor = True
        '
        'cambiarfondo
        '
        Me.cambiarfondo.AutoSize = True
        Me.cambiarfondo.Location = New System.Drawing.Point(91, 3)
        Me.cambiarfondo.Name = "cambiarfondo"
        Me.cambiarfondo.Size = New System.Drawing.Size(129, 23)
        Me.cambiarfondo.TabIndex = 2
        Me.cambiarfondo.Text = "Cambiar fondo"
        Me.cambiarfondo.UseVisualStyleBackColor = True
        '
        'Cerrar
        '
        Me.Cerrar.AutoSize = True
        Me.Cerrar.Location = New System.Drawing.Point(10, 3)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(75, 23)
        Me.Cerrar.TabIndex = 3
        Me.Cerrar.Text = "Cerrar"
        Me.Cerrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(528, 273)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 282)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Stretch"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" &
    "s (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Seleccione un archivo de imagen"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 311)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Visor de Imágenes"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Mostrarunaimagen As Button
    Friend WithEvents borrarlaimagen As Button
    Friend WithEvents cambiarfondo As Button
    Friend WithEvents Cerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
