Imports System.Text
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports NB检测工具.Rt_DetectDataSetTableAdapters
Imports NB检测工具.Rt_DetectDataSet
Imports NPOI.SS.UserModel
Imports NPOI.HSSF.UserModel
Imports System.IO

Public Class MainFrom
    Public comm As New SerialPort()
    Private builder As New StringBuilder()  '避免在事件处理方法中反复的创建，定义到外面。
    Private flag As String
    Private send_code As String
    Private sumhex As String
    Private meternum As String
    Private meternumold As String
    Public StrInfo As String
    Public StrDataTime As String = ""
    Public StrDataTime_1 As String = ""
    Public IntMeterNum As Integer
    Public RecDate As String
    Public Status As String
    Public DatebaseName As String = Application.StartupPath & "\DbMeterSetting"
    Private ds As New DataSet

    Private Sub BntClose_Click(sender As Object, e As EventArgs) Handles BntClose.Click

        If comm.IsOpen Then
            Try
                comm.Close()
            Catch ex As Exception
                comm = New SerialPort()
                MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
                Exit Sub
            End Try
            CommStatus.Text = "串口已关闭"
            CommStatus.ForeColor = Color.Red
            Me.GroupBox2.Enabled = False

            Me.GroupBox5.Enabled = False
            Me.GroupBox6.Enabled = False
            Me.GroupBox7.Enabled = False
            Me.GroupBox8.Enabled = False
        Else
            comm.PortName = CmbPort.Text
            comm.BaudRate = CmbBound.Text.Trim
            comm.DataBits = 8
            comm.StopBits = StopBits.One
            If CmbParity.Text = "Odd" Then
                comm.Parity = Parity.Odd
            ElseIf CmbParity.Text = "Even" Then
                comm.Parity = Parity.Even
            Else
                comm.Parity = Parity.None
            End If
            Try
                comm.Open()
            Catch ex As Exception
                comm = New SerialPort()
                MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
                Exit Sub
            End Try
            CommStatus.Text = "串口已打开"
            CommStatus.ForeColor = Color.Green
            Me.GroupBox2.Enabled = True
            Me.GroupBox5.Enabled = True
            Me.GroupBox6.Enabled = True
            Me.GroupBox7.Enabled = True
            Me.GroupBox8.Enabled = True
        End If
    End Sub
    Private Sub RecTxt_TextChanged(sender As Object, e As EventArgs) Handles RecTxt.TextChanged

    End Sub

    Private Sub BntOpen_Click(sender As Object, e As EventArgs) Handles BntOpen.Click
        '获取表号

        '初始化下拉串口名称列表框
        Dim ports As String() = SerialPort.GetPortNames()
        CmbPort.Items.Clear()
        Array.Sort(ports)
        CmbPort.Items.AddRange(ports)
        CmbPort.SelectedIndex = If(CmbPort.Items.Count > 0, 0, -1)
        If CmbPort.Text = "" Then
            BntClose.Enabled = False
        Else
            BntClose.Enabled = True
        End If
    End Sub
    Private Sub MainFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.GroupBox2.Enabled = False
        Me.GroupBox5.Enabled = False
        Me.GroupBox6.Enabled = False
        Me.GroupBox7.Enabled = False
        Me.GroupBox8.Enabled = False
        CmbBound.Text = "19200"
        CmbParity.Text = "None"
        '初始化下拉串口名称列表框
        Dim ports As String() = SerialPort.GetPortNames()
        Array.Sort(ports)
        CmbPort.Items.AddRange(ports)
        CmbPort.SelectedIndex = If(CmbPort.Items.Count > 0, 0, -1)
        'bntreadcardflag = False
        If CmbPort.Text = "" Then
            BntClose.Enabled = False
        End If
        '添加事件注册
        AddHandler comm.DataReceived, AddressOf comm_DataReceived
        '获取数据库表号
        Dim adapter As New OkMeterTableAdapter
        Dim MaxMeterNum As String
        MaxMeterNum = adapter.MaxMeterNum()
        TxtMeterNumNew.Text = (Convert.ToInt64(MaxMeterNum) + 1).ToString.PadLeft(14, "0")
    End Sub
    Private Sub comm_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)
        '添加读取数据延时
        Threading.Thread.Sleep(1000)
        '先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
        Dim n As Integer = comm.BytesToRead
        '声明一个临时数组存储当前来的串口数据
        Dim buf(n) As Byte
        '读取缓冲数据
        comm.Read(buf, 0, n)
        '清除字符串构造器的内容
        builder.Clear()
        Invoke(Sub()
                   For Each b As Byte In buf
                       builder.Append(b.ToString("X2") & " ")
                   Next

                   If builder.ToString.Replace(" ", "").Length < 6 Then
                       Me.RecTxt.AppendText("返回：  " + builder.ToString() + vbCrLf)
                       '显示最新的一行
                       RecTxt.SelectionStart = RecTxt.TextLength
                       RecTxt.Focus()
                       Exit Sub
                   End If

                   '输出数据
                   If builder.ToString.Replace(" ", "").Substring(0, 6) = "FEFEFE" Then
                       Me.RecTxt.AppendText("返回：  " + builder.ToString() + vbCrLf)
                       RecDate = builder.ToString.Replace(" ", "").Substring(6, builder.ToString.Replace(" ", "").Length - 6)
                   ElseIf builder.ToString.Replace(" ", "").Substring(2, 6) = "FEFEFE" Then
                       Me.RecTxt.AppendText("返回：  " + builder.ToString() + vbCrLf)
                       RecDate = builder.ToString.Replace(" ", "").Substring(8, builder.ToString.Replace(" ", "").Length - 8)
                   Else
                       Exit Sub
                   End If

                   Select Case flag
                       Case "读设备信息"
                           If RecDate.Length >= 70 Then
                               '表号
                               TxtMeterNum.Text = DxStr(RecDate.Substring(4, 14))
                               TxtMeterNumOld.Text = DxStr(RecDate.Substring(4, 14))
                               'SIM卡号
                               TxtSimNum.Text = DxStr(RecDate.Substring(26, 16))
                               '模组号
                               TxtModeNum.Text = DxStr(RecDate.Substring(26 + 16, 16))
                           End If

                       Case "写表号"
                           If RecDate.Length >= 30 Then
                               MessageBox.Show("表号设置成功，当前表号为: " + meternum)
                               If CheckBox1.Checked = True Then
                                   TxtMeterNumNew.Text = Convert.ToString(IntMeterNum + 1).PadLeft(14, "0")
                               End If
                               GetMeterNum()

                           End If

                       Case "读设备状态"
                           If RecDate.Length >= 32 Then
                               If RecDate.Substring(26, 2) = 1 Then
                                   Status = "生产模式"
                               Else
                                   Status = "正常模式"
                               End If
                               Me.RecTxt.AppendText("设备状态： " + Status + vbCrLf)
                           End If

                       Case "启用工厂模式"
                           If RecDate.Length >= 30 Then
                               Me.RecTxt.AppendText("操作成功" + vbCrLf)
                           End If

                       Case "启用正常模式"
                           If RecDate.Length >= 30 Then
                               Me.RecTxt.AppendText("操作成功" + vbCrLf)
                           End If

                       Case "开阀"
                           If RecDate.Length >= 30 Then
                               Me.RecTxt.AppendText("开阀成功" + vbCrLf)
                           End If

                       Case "关阀"
                           If RecDate.Length >= 30 Then
                               Me.RecTxt.AppendText("关阀成功" + vbCrLf)
                           End If

                   End Select

                   '显示最新的一行
                   RecTxt.SelectionStart = RecTxt.TextLength
                   RecTxt.Focus()
               End Sub)
    End Sub
    Private Sub sendcommand(ByVal str_code As String)
        Dim mc As MatchCollection = Regex.Matches(str_code.Replace(" ", ""), "(?i)[\da-f]{2}")
        Dim buf As New List(Of Byte)()              '填充到这个临时列表中
        '依次添加到列表中
        For Each m As Match In mc
            buf.Add(Byte.Parse(m.Value, System.Globalization.NumberStyles.HexNumber))
        Next
        '转换列表为数组后发送
        comm.Write(buf.ToArray(), 0, buf.Count)
    End Sub
    Private Sub BntReadCard_Click(sender As Object, e As EventArgs) Handles BntReadCard.Click
        GetMeterNum()
    End Sub

    Private Sub GetMeterNum()
        send_code = "FE FE FE 68 10 AA AA AA AA AA AA AA 03 02 81 0A AE 16"
        sendcommand(send_code.Replace(" ", ""))
        flag = "读设备信息"
        Me.RecTxt.AppendText(vbCrLf + flag + vbCrLf + "发送：  " + send_code + vbCrLf)
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RecTxt.Text = ""
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TxtMeterNumOld.Text = "" Then
            MsgBox("请先获取表内原表号")
            Exit Sub
        End If
        If TxtMeterNumNew.Text = "" Then
            MsgBox("请输入新表号")
            Exit Sub
        End If
        meternumold = TxtMeterNumOld.Text.Trim.PadLeft(14, "0")
        IntMeterNum = Convert.ToInt64(TxtMeterNumNew.Text, 10)
        meternum = TxtMeterNumNew.Text.Trim.PadLeft(14, "0")
        StrInfo = "6810" + DxStr(meternumold) + "1509A018" + DxStr(meternum)
        sumhex = hexAddSum(StrInfo)
        send_code = "FEFEFE" + StrInfo + sumhex + "16"
        sendcommand(send_code.Replace(" ", ""))
        flag = "写表号"
        Me.RecTxt.AppendText(vbCrLf + flag + vbCrLf + "发送：  " + AddSpace(send_code) + vbCrLf)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMeterNumOld.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMeterNumNew.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        ''16进制校验
        'If e.KeyChar >= Chr(48) And e.KeyChar <= Chr(57) Or e.KeyChar >= Chr(65) And e.KeyChar <= Chr(70) Or e.KeyChar >= Chr(97) And e.KeyChar <= Chr(102) Then
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        If TxtModeNum.Text = "" Then
            MsgBox("请先获取原表通讯信息")
            Exit Sub
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TxtMeterNumOld.Text = "" Then
            MsgBox("请先获取表内原表号")
            Exit Sub
        End If
        StrInfo = "6810" + DxStr(TxtMeterNumOld.Text) + "09028106"
        sumhex = hexAddSum(StrInfo)
        send_code = "FEFEFE" + StrInfo + sumhex + "16"
        sendcommand(send_code.Replace(" ", ""))
        flag = "读设备状态"
        Me.RecTxt.AppendText(vbCrLf + flag + vbCrLf + "发送：  " + AddSpace（send_code） + vbCrLf)
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If TxtMeterNumOld.Text = "" Then
            MsgBox("请先获取表内原表号")
            Exit Sub
        End If
        StrInfo = "6810" + DxStr(TxtMeterNumOld.Text) + "0403A01799"
        sumhex = hexAddSum(StrInfo)
        send_code = "FEFEFE" + StrInfo + sumhex + "16"
        sendcommand(send_code.Replace(" ", ""))
        flag = "开阀"
        Me.RecTxt.AppendText(vbCrLf + flag + vbCrLf + "发送：  " + AddSpace(send_code) + vbCrLf)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If TxtMeterNumOld.Text = "" Then
            MsgBox("请先获取表内原表号")
            Exit Sub
        End If
        StrInfo = "6810" + DxStr(TxtMeterNumOld.Text) + "0403A01755"
        sumhex = hexAddSum(StrInfo)
        send_code = "FEFEFE" + StrInfo + sumhex + "16"
        sendcommand(send_code.Replace(" ", ""))
        flag = "关阀"
        Me.RecTxt.AppendText(vbCrLf + flag + vbCrLf + "发送：  " + AddSpace(send_code) + vbCrLf)
    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TxtMeterNumOld.Text = "" Then
            MsgBox("请先获取表内原表号")
            Exit Sub
        End If
        StrInfo = "6810" + DxStr(TxtMeterNumOld.Text) + "2402A009"
        sumhex = hexAddSum(StrInfo)
        send_code = "FEFEFE" + StrInfo + sumhex + "16"
        sendcommand(send_code.Replace(" ", ""))
        flag = "启用工厂模式"
        Me.RecTxt.AppendText(vbCrLf + flag + vbCrLf + "发送：  " + AddSpace（send_code） + vbCrLf)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtMeterNumOld.Text = "" Then
            MsgBox("请先获取表内原表号")
            Exit Sub
        End If
        StrInfo = "6810" + DxStr(TxtMeterNumOld.Text) + "0402A019"
        sumhex = hexAddSum(StrInfo)
        send_code = "FEFEFE" + StrInfo + sumhex + "16"
        sendcommand(send_code.Replace(" ", ""))
        flag = "启用正常模式"
        Me.RecTxt.AppendText(vbCrLf + flag + vbCrLf + "发送：  " + AddSpace（send_code） + vbCrLf)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim adapter As New OkMeterTableAdapter
        Dim mTable As New OkMeterDataTable

        If CheckBox2.Checked = False And TxtVaule.Text = "" Then
            mTable = adapter.GetData()
        End If
        If CheckBox2.Checked = False And TxtVaule.Text <> "" Then
            mTable = adapter.GetDataByVaule("%" + TxtVaule.Text + "%", "%" + TxtVaule.Text + "%", "%" + TxtVaule.Text + "%", "%" + TxtVaule.Text + "%")
        End If

        If CheckBox2.Checked And TxtVaule.Text = "" Then
            mTable = adapter.GetDataByTime(DtpStart.Value.Date, DtpEnd.Value.Date)
        End If

        If CheckBox2.Checked And TxtVaule.Text <> "" Then
            mTable = adapter.GetDataByTimeAndVaule(DtpStart.Value.Date, DtpEnd.Value.Date, "%" + TxtVaule.Text + "%", "%" + TxtVaule.Text + "%", "%" + TxtVaule.Text + "%", "%" + TxtVaule.Text + "%")
        End If


        DataGridView1.DataSource = mTable
        MsgBox("总计：" + (DataGridView1.Rows.Count - 1).ToString + " 条")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Dim mWorkbook As IWorkbook = New HSSFWorkbook()
            Dim mSheet As ISheet = mWorkbook.CreateSheet("Sheet1")
            Dim styleRight As ICellStyle = mWorkbook.CreateCellStyle()
            styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER
            styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER
            Dim mCell As ICell
            Dim i As Integer, j As Integer
            '添加标头
            Dim mRow As IRow = mSheet.CreateRow(0)
            For i = 0 To DataGridView1.Columns.Count - 1
                mCell = mRow.CreateCell(i)
                mCell.SetCellValue(DataGridView1.Columns(i).HeaderText)
                mCell.CellStyle = styleRight
            Next
            '添加内容

            For i = 1 To DataGridView1.RowCount - 1
                mRow = mSheet.CreateRow(i)
                For j = 0 To DataGridView1.Columns.Count - 1
                    mCell = mRow.CreateCell(j)
                    mCell.SetCellValue(DataGridView1.Rows(i - 1).Cells(j).Value.ToString())
                    mCell.CellStyle = styleRight
                Next
            Next


            '创建文件
            Dim mDialog As New SaveFileDialog()
            mDialog.AddExtension = True
            mDialog.DefaultExt = "xls"
            mDialog.Filter = "Excel Worksheets(*.xls)|*.xls"
            mDialog.InitialDirectory = System.Environment.CurrentDirectory
            mDialog.ShowDialog()
            If Not mDialog.FileName.Equals("") Then
                Dim mFile As Stream = mDialog.OpenFile()
                mWorkbook.Write(mFile)
                mFile.Close()
                MsgBox("保存成功！")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim ret As Integer
        Dim adapter As New OkMeterTableAdapter
        If TxtMeterNumOld.Text = "" Then
            MsgBox("请先设置表号")
            Exit Sub
        End If
        ret = adapter.Insert1(Now, meternum, TxtModeNum.Text, TxtSimNum.Text, TextBox1.Text, "已检测", "功能正常")
        If ret > 0 Then
            MsgBox("保存成功")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtModeNum.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
