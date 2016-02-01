<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FT2000toFT991
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
        Me.cboFT991Port = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboRMSPort = New System.Windows.Forms.ComboBox()
        Me.btnSaveSettings = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboFT991Baud = New System.Windows.Forms.ComboBox()
        Me.cboRMSBaud = New System.Windows.Forms.ComboBox()
        Me.cboFT991RTS = New System.Windows.Forms.ComboBox()
        Me.cboRMSRTS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboFT991Port
        '
        Me.cboFT991Port.FormattingEnabled = True
        Me.cboFT991Port.Location = New System.Drawing.Point(101, 18)
        Me.cboFT991Port.Name = "cboFT991Port"
        Me.cboFT991Port.Size = New System.Drawing.Size(90, 21)
        Me.cboFT991Port.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FT-991"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RMS Express"
        '
        'cboRMSPort
        '
        Me.cboRMSPort.FormattingEnabled = True
        Me.cboRMSPort.Location = New System.Drawing.Point(198, 18)
        Me.cboRMSPort.Name = "cboRMSPort"
        Me.cboRMSPort.Size = New System.Drawing.Size(93, 21)
        Me.cboRMSPort.TabIndex = 0
        '
        'btnSaveSettings
        '
        Me.btnSaveSettings.Location = New System.Drawing.Point(313, 13)
        Me.btnSaveSettings.Name = "btnSaveSettings"
        Me.btnSaveSettings.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveSettings.TabIndex = 3
        Me.btnSaveSettings.Text = "Save Settings"
        Me.btnSaveSettings.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(313, 42)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cboFT991Port, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboRMSPort, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cboFT991Baud, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboRMSBaud, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboFT991RTS, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cboRMSRTS, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(295, 104)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'cboFT991Baud
        '
        Me.cboFT991Baud.FormattingEnabled = True
        Me.cboFT991Baud.Items.AddRange(New Object() {"38400", "19200", "9600", "4800"})
        Me.cboFT991Baud.Location = New System.Drawing.Point(101, 46)
        Me.cboFT991Baud.Name = "cboFT991Baud"
        Me.cboFT991Baud.Size = New System.Drawing.Size(90, 21)
        Me.cboFT991Baud.TabIndex = 1
        '
        'cboRMSBaud
        '
        Me.cboRMSBaud.FormattingEnabled = True
        Me.cboRMSBaud.Items.AddRange(New Object() {"38400", "19200", "9600", "4800"})
        Me.cboRMSBaud.Location = New System.Drawing.Point(198, 46)
        Me.cboRMSBaud.Name = "cboRMSBaud"
        Me.cboRMSBaud.Size = New System.Drawing.Size(93, 21)
        Me.cboRMSBaud.TabIndex = 2
        '
        'cboFT991RTS
        '
        Me.cboFT991RTS.FormattingEnabled = True
        Me.cboFT991RTS.Items.AddRange(New Object() {"True", "False"})
        Me.cboFT991RTS.Location = New System.Drawing.Point(101, 74)
        Me.cboFT991RTS.Name = "cboFT991RTS"
        Me.cboFT991RTS.Size = New System.Drawing.Size(90, 21)
        Me.cboFT991RTS.TabIndex = 3
        '
        'cboRMSRTS
        '
        Me.cboRMSRTS.FormattingEnabled = True
        Me.cboRMSRTS.Items.AddRange(New Object() {"True", "False"})
        Me.cboRMSRTS.Location = New System.Drawing.Point(198, 74)
        Me.cboRMSRTS.Name = "cboRMSRTS"
        Me.cboRMSRTS.Size = New System.Drawing.Size(93, 21)
        Me.cboRMSRTS.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Serial Port"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Baud Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "RTS Enable"
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(12, 123)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(376, 126)
        Me.txtLog.TabIndex = 6
        '
        'FT2000toFT991
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 261)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.btnSaveSettings)
        Me.Name = "FT2000toFT991"
        Me.Text = "FT2000 to FT991"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboFT991Port As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboRMSPort As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveSettings As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cboFT991Baud As ComboBox
    Friend WithEvents cboRMSBaud As ComboBox
    Friend WithEvents cboRMSRTS As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboFT991RTS As ComboBox
    Friend WithEvents txtLog As TextBox
End Class
