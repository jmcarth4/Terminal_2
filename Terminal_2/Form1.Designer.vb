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
        Me.components = New System.ComponentModel.Container()
        Me.InTermListBox = New System.Windows.Forms.ListBox()
        Me.OutTermListBox = New System.Windows.Forms.ListBox()
        Me.InClearButton = New System.Windows.Forms.Button()
        Me.OutClearButton = New System.Windows.Forms.Button()
        Me.DataInputClearButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.BaudRateListBox = New System.Windows.Forms.ListBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.BaudRateButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DataInLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InTermListBox
        '
        Me.InTermListBox.FormattingEnabled = True
        Me.InTermListBox.ItemHeight = 20
        Me.InTermListBox.Location = New System.Drawing.Point(775, 233)
        Me.InTermListBox.Name = "InTermListBox"
        Me.InTermListBox.Size = New System.Drawing.Size(325, 244)
        Me.InTermListBox.TabIndex = 10
        '
        'OutTermListBox
        '
        Me.OutTermListBox.FormattingEnabled = True
        Me.OutTermListBox.ItemHeight = 20
        Me.OutTermListBox.Location = New System.Drawing.Point(504, 233)
        Me.OutTermListBox.Name = "OutTermListBox"
        Me.OutTermListBox.Size = New System.Drawing.Size(239, 244)
        Me.OutTermListBox.TabIndex = 9
        '
        'InClearButton
        '
        Me.InClearButton.Location = New System.Drawing.Point(857, 496)
        Me.InClearButton.Name = "InClearButton"
        Me.InClearButton.Size = New System.Drawing.Size(140, 66)
        Me.InClearButton.TabIndex = 12
        Me.InClearButton.Text = "Clear &Received Data"
        Me.InClearButton.UseVisualStyleBackColor = True
        '
        'OutClearButton
        '
        Me.OutClearButton.Location = New System.Drawing.Point(530, 496)
        Me.OutClearButton.Name = "OutClearButton"
        Me.OutClearButton.Size = New System.Drawing.Size(147, 61)
        Me.OutClearButton.TabIndex = 11
        Me.OutClearButton.Text = "Clear &Send Data"
        Me.OutClearButton.UseVisualStyleBackColor = True
        '
        'DataInputClearButton
        '
        Me.DataInputClearButton.Location = New System.Drawing.Point(711, 503)
        Me.DataInputClearButton.Name = "DataInputClearButton"
        Me.DataInputClearButton.Size = New System.Drawing.Size(122, 53)
        Me.DataInputClearButton.TabIndex = 13
        Me.DataInputClearButton.Text = "Clear &Input Text Box"
        Me.DataInputClearButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(711, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 7
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(679, 102)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(154, 104)
        Me.SendButton.TabIndex = 8
        Me.SendButton.Text = "Send Packet"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(309, 12)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 204)
        Me.PortDataListBox.TabIndex = 5
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(323, 273)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(128, 72)
        Me.PortOpenButton.TabIndex = 6
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(183, 12)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(110, 184)
        Me.ComPortListBox.TabIndex = 4
        '
        'BaudRateListBox
        '
        Me.BaudRateListBox.FormattingEnabled = True
        Me.BaudRateListBox.ItemHeight = 20
        Me.BaudRateListBox.Location = New System.Drawing.Point(12, 12)
        Me.BaudRateListBox.Name = "BaudRateListBox"
        Me.BaudRateListBox.Size = New System.Drawing.Size(165, 244)
        Me.BaudRateListBox.TabIndex = 1
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(1080, 525)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(136, 104)
        Me.QuitButton.TabIndex = 14
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(183, 273)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(110, 72)
        Me.ComPortButton.TabIndex = 3
        Me.ComPortButton.Text = "&Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'BaudRateButton
        '
        Me.BaudRateButton.Location = New System.Drawing.Point(32, 262)
        Me.BaudRateButton.Name = "BaudRateButton"
        Me.BaudRateButton.Size = New System.Drawing.Size(110, 83)
        Me.BaudRateButton.TabIndex = 2
        Me.BaudRateButton.Text = "&Baud Rate"
        Me.BaudRateButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataInLabel
        '
        Me.DataInLabel.AutoSize = True
        Me.DataInLabel.Location = New System.Drawing.Point(716, 35)
        Me.DataInLabel.Name = "DataInLabel"
        Me.DataInLabel.Size = New System.Drawing.Size(85, 20)
        Me.DataInLabel.TabIndex = 32
        Me.DataInLabel.Text = "Data Input"
        '
        'Form1
        '
        Me.AcceptButton = Me.SendButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.QuitButton
        Me.ClientSize = New System.Drawing.Size(1228, 669)
        Me.Controls.Add(Me.DataInLabel)
        Me.Controls.Add(Me.InTermListBox)
        Me.Controls.Add(Me.OutTermListBox)
        Me.Controls.Add(Me.InClearButton)
        Me.Controls.Add(Me.OutClearButton)
        Me.Controls.Add(Me.DataInputClearButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.PortDataListBox)
        Me.Controls.Add(Me.PortOpenButton)
        Me.Controls.Add(Me.ComPortListBox)
        Me.Controls.Add(Me.BaudRateListBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ComPortButton)
        Me.Controls.Add(Me.BaudRateButton)
        Me.Name = "Form1"
        Me.Text = "WK 4-1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InTermListBox As ListBox
    Friend WithEvents OutTermListBox As ListBox
    Friend WithEvents InClearButton As Button
    Friend WithEvents OutClearButton As Button
    Friend WithEvents DataInputClearButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SendButton As Button
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents BaudRateListBox As ListBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents ComPortButton As Button
    Friend WithEvents BaudRateButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DataInLabel As Label
End Class
