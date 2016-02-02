Imports System.Deployment.Application
Imports System.IO.Ports

Public Class FT2000toFT991

    Dim serialPortsFT991 As List(Of String) = New List(Of String)
    Dim serialPortsRMS As List(Of String) = New List(Of String)

    Dim comFT991 As IO.Ports.SerialPort = Nothing
    Dim comRMS As IO.Ports.SerialPort = Nothing

    Sub getSerialPorts()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            serialPortsFT991.Add(sp)
            serialPortsRMS.Add(sp)
        Next
    End Sub

    Private Sub FT2000toFT991_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim v As String
        Try
            v = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString

        Catch ex As Exception
            v = "0.0.0.0"

        End Try
        Me.Text = "FT2000 to FT991 - v" & v




        getSerialPorts()

        cboFT991Port.DataSource = serialPortsFT991
        cboRMSPort.DataSource = serialPortsRMS

        getSettings()



    End Sub

    Private Sub getSettings()
        If serialPortsFT991.Contains(My.Settings.FT991Port) Then
            cboFT991Port.SelectedIndex = serialPortsRMS.IndexOf(My.Settings.FT991Port)
        End If
        If cboFT991Baud.Items.Contains(My.Settings.FT991Baud) Then
            cboFT991Baud.SelectedIndex = cboFT991Baud.Items.IndexOf(My.Settings.FT991Baud)
        End If
        If cboFT991RTS.Items.Contains(My.Settings.FT991RTS) Then
            cboFT991RTS.SelectedIndex = cboFT991RTS.Items.IndexOf(My.Settings.FT991RTS)
        End If

        If serialPortsRMS.Contains(My.Settings.RMSPort) Then
            cboRMSPort.SelectedIndex = serialPortsRMS.IndexOf(My.Settings.RMSPort)
        End If
        If cboRMSBaud.Items.Contains(My.Settings.RMSBaud) Then
            cboRMSBaud.SelectedIndex = cboRMSBaud.Items.IndexOf(My.Settings.RMSBaud)
        End If
        If cboRMSRTS.Items.Contains(My.Settings.RMSRTS) Then
            cboRMSRTS.SelectedIndex = cboRMSRTS.Items.IndexOf(My.Settings.RMSRTS)

        End If

    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.FT991Port = cboFT991Port.SelectedItem
        My.Settings.FT991Baud = cboFT991Baud.SelectedItem
        My.Settings.FT991RTS = cboFT991RTS.SelectedItem

        My.Settings.RMSPort = cboRMSPort.SelectedItem
        My.Settings.RMSBaud = cboRMSBaud.SelectedItem
        My.Settings.RMSRTS = cboRMSRTS.SelectedItem

        My.Settings.Save()

        getSettings()

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        connectPorts()

    End Sub

    Private Sub connectPorts()
        comFT991 = My.Computer.Ports.OpenSerialPort(cboFT991Port.SelectedItem)
        comFT991.BaudRate = CInt(My.Settings.FT991Baud)
        comFT991.RtsEnable = CBool(My.Settings.FT991RTS)
        comFT991.Parity = Parity.None
        comFT991.StopBits = StopBits.One
        comFT991.DataBits = 8

        comRMS = My.Computer.Ports.OpenSerialPort(cboRMSPort.SelectedItem)
        comRMS.BaudRate = CInt(My.Settings.RMSBaud)
        comRMS.RtsEnable = CBool(My.Settings.RMSRTS)
        comRMS.Parity = Parity.None
        comRMS.StopBits = StopBits.One
        comRMS.DataBits = 8

        AddHandler comRMS.DataReceived, AddressOf DataReceivedHandler


    End Sub

    Private Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Dim sp As SerialPort = CType(sender, SerialPort)
        Dim indata As String = sp.ReadExisting()
        Dim ar As Array = indata.Split(";")

        For Each c As String In ar

            If Microsoft.VisualBasic.Left(c, 2) = "FA" Then
                Dim fa = "FA0" & Microsoft.VisualBasic.Right(c, Len(c) - 2) & ";"
                Dim fb = "FB0" & Microsoft.VisualBasic.Right(c, Len(c) - 2) & ";"

                If comFT991.IsOpen Then
                    comFT991.Write(fa)
                    comFT991.Write(fb)
                    Console.WriteLine(fa)

                Else
                    Console.WriteLine("FT991 Not Open")
                End If

                Console.Write(c)
            ElseIf Microsoft.VisualBasic.Left(c, 2) = "MD" Then
                c = c & ";"
                If comFT991.IsOpen Then
                    comFT991.Write(c)
                Else
                    Console.WriteLine("FT991 Not Open")
                End If

                Console.Write(c)
            Else
                Console.WriteLine()
                Console.Write(c)

            End If
        Next



    End Sub


End Class
