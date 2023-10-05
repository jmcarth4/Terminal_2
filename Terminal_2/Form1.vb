'Jessica McArthur
'RCET 3371
'WK 4-1 
'4 October 2023


Imports System.Text.RegularExpressions

Public Class Form1
    Dim portState As Boolean
    Dim receiveByte(18) As Byte        'Receive Data Bytes

    'Closes Serial Ports when forms closes
    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try
    End Sub

    'Loads serial settings when load the form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComPortListBox.Items.Clear()                   'Clears old Com Ports
        portState = False                              'Disables serial port

        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity

        Timer1.Enabled = True                           'timer set to 100 ms
    End Sub

    'Finds and list all com ports present on the system
    Private Sub ComPortButton_Click(sender As Object, e As EventArgs) Handles ComPortButton.Click
        ComPortListBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortListBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
    End Sub

    'Activates selected comport
    Private Sub PortOpenButton_Click(sender As Object, e As EventArgs) Handles PortOpenButton.Click
        If PortOpenButton.Text = "Connect" Then                     'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                PortOpenButton.Text = "Disconnect"                  'Displays that con port is connected
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                PortOpenButton.Text = "Connect"
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            PortOpenButton.Text = "Connect"
        End If
    End Sub

    'Displays serial port data in a list box
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dataIn As String
        dataIn = ""
        PortDataListBox.Items.Clear()
        PortDataListBox.Items.Add("Com port = " & SerialPort1.PortName)  'Show current baud rate
        PortDataListBox.Items.Add("Baud Rate = " & SerialPort1.BaudRate) 'Show current baud rate
        PortDataListBox.Items.Add("Data bits = " & SerialPort1.DataBits)
        PortDataListBox.Items.Add("Stop bits = " & SerialPort1.StopBits)
        PortDataListBox.Items.Add("Parity = " & SerialPort1.Parity)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortListBox.SelectedIndexChanged
        Try
            SerialPort1.Close()                             'Try to close port before change

        Catch ex As Exception

        End Try

        PortOpenButton.Text = "Connect"
        portState = False
        Try
            SerialPort1.BaudRate = ComPortListBox.SelectedItem 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = ComPortListBox.SelectedItem 'Bot baud rate, save port name
        End Try
    End Sub

    'Loads baud rate values into list box
    Private Sub BaudRateButton_Click(sender As Object, e As EventArgs) Handles BaudRateButton.Click
        BaudRateListBox.Items.Clear()                          'Clear list box and load baud rate values
        BaudRateListBox.Items.Add(1200)
        BaudRateListBox.Items.Add(2400)
        BaudRateListBox.Items.Add(4800)
        BaudRateListBox.Items.Add(9600)
        BaudRateListBox.Items.Add(19200)
        BaudRateListBox.Items.Add(38400)
        BaudRateListBox.Items.Add(57600)
        BaudRateListBox.Items.Add(115200)
        BaudRateListBox.Items.Add(230400)
        BaudRateListBox.Items.Add(230400)
        BaudRateListBox.Items.Add(460800)
        BaudRateListBox.Items.Add(921600)
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Timer1.Enabled = False                                  'Stop Timer
        Dim dataOut As String                                   'Transmit Variables
        Dim dataIn1, dataIn2, dataIn3, dataIn4 As Integer
        Dim input As String

        input = TextBox1.Text                                   'Load transmit variable with information from text box
        dataOut = Regex.Replace(input, "\s", "")                'Removes all spaces from input

        If portState = True Then                                'Test if port is open
            SerialPort1.DiscardInBuffer()                       'Clears transmit buffer

            If dataOut IsNot "" Then                            'Test transmit value is not blank
                SerialPort1.Write(dataOut, 0, 4)                'Send data
                OutTermListBox.Items.Add(dataOut)               'Log sent data

            Else                                                 'Send data was blank
                Timer1.Enabled = True                            'Restart timer
                Exit Sub                                         'Leave

            End If

            Try                                                  'Attempt to receive
                System.Threading.Thread.Sleep(20)                'Time delay to ensure correct data is read
                SerialPort1.Read(receiveByte, 0, 10)             'Read Serial Port
                dataIn1 = receiveByte(0)                         'Save Byte0
                dataIn2 = receiveByte(1)                         'Save Byte1
                dataIn3 = receiveByte(2)                         'Save Byte2
                dataIn4 = receiveByte(3)                         'Save Byte3
                'Add data to input list box as ascii characters
                InTermListBox.Items.Add(Chr(dataIn1) & vbTab & Chr(dataIn2) & vbTab & Chr(dataIn3) & vbTab & Chr(dataIn4))
            Catch ex As Exception

            End Try

        Else
            MsgBox("Please configure and open serial port to procede")  'Failure if port is not open
            TextBox1.Text = " "
        End If
        Timer1.Enabled = True                                       'Restart Timer

    End Sub

    'Clears received data list box
    Private Sub InClearButton_Click(sender As Object, e As EventArgs) Handles InClearButton.Click
        InTermListBox.Items.Clear()
    End Sub

    'Clears sent data list box
    Private Sub OutClearButton_Click(sender As Object, e As EventArgs) Handles OutClearButton.Click
        OutTermListBox.Items.Clear()
    End Sub

    'Clears data input text box
    Private Sub DataInputClearButton_Click(sender As Object, e As EventArgs) Handles DataInputClearButton.Click
        TextBox1.Text = " "
    End Sub

    'Exits Program when button is pressed 
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class
