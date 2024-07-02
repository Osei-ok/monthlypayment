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
        txtPrincipal = New TextBox()
        lblprincipal = New Label()
        lblrate = New Label()
        lstRates = New ListBox()
        btnCalculate = New Button()
        Label1 = New Label()
        btnexit = New Button()
        PictureBox1 = New PictureBox()
        lblPay = New Label()
        lblPays = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtPrincipal
        ' 
        txtPrincipal.Location = New Point(182, 64)
        txtPrincipal.Name = "txtPrincipal"
        txtPrincipal.Size = New Size(100, 23)
        txtPrincipal.TabIndex = 0
        ' 
        ' lblprincipal
        ' 
        lblprincipal.AutoSize = True
        lblprincipal.Location = New Point(201, 46)
        lblprincipal.Name = "lblprincipal"
        lblprincipal.Size = New Size(53, 15)
        lblprincipal.TabIndex = 1
        lblprincipal.Text = "Principal"
        ' 
        ' lblrate
        ' 
        lblrate.AutoSize = True
        lblrate.Location = New Point(476, 47)
        lblrate.Name = "lblrate"
        lblrate.Size = New Size(54, 15)
        lblrate.TabIndex = 2
        lblrate.Text = "Rate (%):"
        ' 
        ' lstRates
        ' 
        lstRates.FormattingEnabled = True
        lstRates.ItemHeight = 15
        lstRates.Items.AddRange(New Object() {"2.0", "2.5", "3.0", "3.5", "4.0", "4.5", "5.0", "5.5", "6.0", "6.5", "7.0"})
        lstRates.Location = New Point(476, 90)
        lstRates.Name = "lstRates"
        lstRates.Size = New Size(108, 94)
        lstRates.TabIndex = 3
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(509, 256)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(152, 219)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 5
        Label1.Text = "Monthly Payment"
        ' 
        ' btnexit
        ' 
        btnexit.Location = New Point(509, 309)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(75, 23)
        btnexit.TabIndex = 6
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.photo_2023_07_31_21_17_05
        PictureBox1.Location = New Point(3, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(108, 102)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' lblPay
        ' 
        lblPay.AutoSize = True
        lblPay.Location = New Point(152, 292)
        lblPay.Name = "lblPay"
        lblPay.Size = New Size(0, 15)
        lblPay.TabIndex = 8
        ' 
        ' lblPays
        ' 
        lblPays.BackColor = SystemColors.ActiveCaption
        lblPays.BorderStyle = BorderStyle.Fixed3D
        lblPays.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblPays.Location = New Point(143, 244)
        lblPays.Name = "lblPays"
        lblPays.Size = New Size(207, 131)
        lblPays.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(716, 429)
        Controls.Add(lblPays)
        Controls.Add(lblPay)
        Controls.Add(PictureBox1)
        Controls.Add(btnexit)
        Controls.Add(Label1)
        Controls.Add(btnCalculate)
        Controls.Add(lstRates)
        Controls.Add(lblrate)
        Controls.Add(lblprincipal)
        Controls.Add(txtPrincipal)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents lblprincipal As Label
    Friend WithEvents lblrate As Label
    Friend WithEvents lstRates As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPay As Label
    Friend WithEvents lblPays As Label

End Class
