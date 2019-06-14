<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrom
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrom))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RecTxt = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TxtMeterNumOld = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMeterNumNew = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSimNum = New System.Windows.Forms.TextBox()
        Me.TxtModeNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BntReadCard = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTimeOutRemote = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTimeOutLocal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbParity = New System.Windows.Forms.ComboBox()
        Me.CmbBound = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CommStatus = New System.Windows.Forms.Label()
        Me.BntOpen = New System.Windows.Forms.Button()
        Me.CmbPort = New System.Windows.Forms.ComboBox()
        Me.端口号 = New System.Windows.Forms.Label()
        Me.BntClose = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtMeterNum = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.DtpStart = New System.Windows.Forms.DateTimePicker()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TxtVaule = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OkMeterTableAdapter = New NB检测工具.Rt_DetectDataSetTableAdapters.OkMeterTableAdapter()
        Me.Rt_DetectDataSet = New NB检测工具.Rt_DetectDataSet()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Rt_DetectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.RecTxt)
        Me.GroupBox4.Location = New System.Drawing.Point(916, 12)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Size = New System.Drawing.Size(784, 1036)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "数据展示"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(22, 962)
        Me.Button5.Margin = New System.Windows.Forms.Padding(6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(750, 56)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "清除窗体"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RecTxt
        '
        Me.RecTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RecTxt.BackColor = System.Drawing.Color.White
        Me.RecTxt.EnableAutoDragDrop = True
        Me.RecTxt.Location = New System.Drawing.Point(22, 40)
        Me.RecTxt.Margin = New System.Windows.Forms.Padding(6)
        Me.RecTxt.Name = "RecTxt"
        Me.RecTxt.ReadOnly = True
        Me.RecTxt.Size = New System.Drawing.Size(750, 906)
        Me.RecTxt.TabIndex = 0
        Me.RecTxt.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.TxtMeterNumOld)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtMeterNumNew)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(862, 148)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "表号设置"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(478, 88)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(162, 28)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "表号自增长"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TxtMeterNumOld
        '
        Me.TxtMeterNumOld.BackColor = System.Drawing.SystemColors.Control
        Me.TxtMeterNumOld.Enabled = False
        Me.TxtMeterNumOld.Location = New System.Drawing.Point(196, 36)
        Me.TxtMeterNumOld.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMeterNumOld.MaxLength = 10
        Me.TxtMeterNumOld.Name = "TxtMeterNumOld"
        Me.TxtMeterNumOld.Size = New System.Drawing.Size(248, 35)
        Me.TxtMeterNumOld.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "新表号"
        '
        'TxtMeterNumNew
        '
        Me.TxtMeterNumNew.Location = New System.Drawing.Point(196, 92)
        Me.TxtMeterNumNew.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMeterNumNew.MaxLength = 14
        Me.TxtMeterNumNew.Name = "TxtMeterNumNew"
        Me.TxtMeterNumNew.Size = New System.Drawing.Size(248, 35)
        Me.TxtMeterNumNew.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "表内原表号"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(702, 40)
        Me.Button2.Margin = New System.Windows.Forms.Padding(6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 44)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "设置"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SIM卡号"
        '
        'TxtSimNum
        '
        Me.TxtSimNum.BackColor = System.Drawing.SystemColors.Control
        Me.TxtSimNum.Location = New System.Drawing.Point(132, 34)
        Me.TxtSimNum.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSimNum.Name = "TxtSimNum"
        Me.TxtSimNum.ReadOnly = True
        Me.TxtSimNum.Size = New System.Drawing.Size(230, 35)
        Me.TxtSimNum.TabIndex = 5
        '
        'TxtModeNum
        '
        Me.TxtModeNum.BackColor = System.Drawing.SystemColors.Control
        Me.TxtModeNum.Location = New System.Drawing.Point(484, 34)
        Me.TxtModeNum.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtModeNum.Name = "TxtModeNum"
        Me.TxtModeNum.ReadOnly = True
        Me.TxtModeNum.Size = New System.Drawing.Size(224, 35)
        Me.TxtModeNum.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(392, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "模组号"
        '
        'BntReadCard
        '
        Me.BntReadCard.Location = New System.Drawing.Point(746, 32)
        Me.BntReadCard.Margin = New System.Windows.Forms.Padding(6)
        Me.BntReadCard.Name = "BntReadCard"
        Me.BntReadCard.Size = New System.Drawing.Size(128, 50)
        Me.BntReadCard.TabIndex = 0
        Me.BntReadCard.Text = "设备信息"
        Me.BntReadCard.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtTimeOutRemote)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtTimeOutLocal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CmbParity)
        Me.GroupBox1.Controls.Add(Me.CmbBound)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CommStatus)
        Me.GroupBox1.Controls.Add(Me.BntOpen)
        Me.GroupBox1.Controls.Add(Me.CmbPort)
        Me.GroupBox1.Controls.Add(Me.端口号)
        Me.GroupBox1.Controls.Add(Me.BntClose)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(900, 202)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "串口设置"
        '
        'TxtTimeOutRemote
        '
        Me.TxtTimeOutRemote.Location = New System.Drawing.Point(190, 146)
        Me.TxtTimeOutRemote.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTimeOutRemote.MaxLength = 10
        Me.TxtTimeOutRemote.Name = "TxtTimeOutRemote"
        Me.TxtTimeOutRemote.Size = New System.Drawing.Size(168, 35)
        Me.TxtTimeOutRemote.TabIndex = 14
        Me.TxtTimeOutRemote.Text = "2000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 152)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 24)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "远传超时(ms)"
        '
        'TxtTimeOutLocal
        '
        Me.TxtTimeOutLocal.Location = New System.Drawing.Point(536, 144)
        Me.TxtTimeOutLocal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTimeOutLocal.MaxLength = 10
        Me.TxtTimeOutLocal.Name = "TxtTimeOutLocal"
        Me.TxtTimeOutLocal.Size = New System.Drawing.Size(168, 35)
        Me.TxtTimeOutLocal.TabIndex = 12
        Me.TxtTimeOutLocal.Text = "200"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(374, 152)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 24)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = " 超时(ms)"
        '
        'CmbParity
        '
        Me.CmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbParity.FormattingEnabled = True
        Me.CmbParity.Items.AddRange(New Object() {"Odd ", "Even", "None"})
        Me.CmbParity.Location = New System.Drawing.Point(190, 96)
        Me.CmbParity.Margin = New System.Windows.Forms.Padding(6)
        Me.CmbParity.Name = "CmbParity"
        Me.CmbParity.Size = New System.Drawing.Size(168, 32)
        Me.CmbParity.TabIndex = 10
        '
        'CmbBound
        '
        Me.CmbBound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBound.FormattingEnabled = True
        Me.CmbBound.Items.AddRange(New Object() {"2400", "4800", "9600", "19200", "38400", "43000", "56000", "57600", "115200"})
        Me.CmbBound.Location = New System.Drawing.Point(536, 88)
        Me.CmbBound.Margin = New System.Windows.Forms.Padding(6)
        Me.CmbBound.Name = "CmbBound"
        Me.CmbBound.Size = New System.Drawing.Size(168, 32)
        Me.CmbBound.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 106)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "奇偶校验"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(388, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 24)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "波特率"
        '
        'CommStatus
        '
        Me.CommStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommStatus.AutoSize = True
        Me.CommStatus.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CommStatus.Location = New System.Drawing.Point(528, 24)
        Me.CommStatus.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.CommStatus.Name = "CommStatus"
        Me.CommStatus.Size = New System.Drawing.Size(0, 48)
        Me.CommStatus.TabIndex = 6
        Me.CommStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BntOpen
        '
        Me.BntOpen.Location = New System.Drawing.Point(378, 34)
        Me.BntOpen.Margin = New System.Windows.Forms.Padding(6)
        Me.BntOpen.Name = "BntOpen"
        Me.BntOpen.Size = New System.Drawing.Size(128, 46)
        Me.BntOpen.TabIndex = 5
        Me.BntOpen.Text = "枚举设备"
        Me.BntOpen.UseVisualStyleBackColor = True
        '
        'CmbPort
        '
        Me.CmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPort.FormattingEnabled = True
        Me.CmbPort.Location = New System.Drawing.Point(190, 40)
        Me.CmbPort.Margin = New System.Windows.Forms.Padding(6)
        Me.CmbPort.Name = "CmbPort"
        Me.CmbPort.Size = New System.Drawing.Size(168, 32)
        Me.CmbPort.TabIndex = 3
        '
        '端口号
        '
        Me.端口号.AutoSize = True
        Me.端口号.Location = New System.Drawing.Point(12, 54)
        Me.端口号.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.端口号.Name = "端口号"
        Me.端口号.Size = New System.Drawing.Size(82, 24)
        Me.端口号.TabIndex = 1
        Me.端口号.Text = "端口号"
        '
        'BntClose
        '
        Me.BntClose.Location = New System.Drawing.Point(742, 140)
        Me.BntClose.Margin = New System.Windows.Forms.Padding(6)
        Me.BntClose.Name = "BntClose"
        Me.BntClose.Size = New System.Drawing.Size(128, 46)
        Me.BntClose.TabIndex = 0
        Me.BntClose.Text = "开关"
        Me.BntClose.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtMeterNum)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.TxtModeNum)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TxtSimNum)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.BntReadCard)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 216)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(908, 94)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "设备信息"
        '
        'TxtMeterNum
        '
        Me.TxtMeterNum.BackColor = System.Drawing.SystemColors.Control
        Me.TxtMeterNum.Location = New System.Drawing.Point(132, 84)
        Me.TxtMeterNum.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMeterNum.Name = "TxtMeterNum"
        Me.TxtMeterNum.ReadOnly = True
        Me.TxtMeterNum.Size = New System.Drawing.Size(230, 35)
        Me.TxtMeterNum.TabIndex = 8
        Me.TxtMeterNum.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 94)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 24)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "表号"
        Me.Label11.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button7)
        Me.GroupBox7.Controls.Add(Me.Button8)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 316)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox7.Size = New System.Drawing.Size(862, 114)
        Me.GroupBox7.TabIndex = 12
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "控制功能"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(192, 40)
        Me.Button7.Margin = New System.Windows.Forms.Padding(6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 52)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "开阀"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(494, 40)
        Me.Button8.Margin = New System.Windows.Forms.Padding(6)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(124, 52)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "关阀"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button3)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Controls.Add(Me.Button10)
        Me.GroupBox8.Location = New System.Drawing.Point(16, 182)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox8.Size = New System.Drawing.Size(862, 122)
        Me.GroupBox8.TabIndex = 13
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "模块状态"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 40)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 52)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "启用工厂模式"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(592, 40)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 52)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "启用正常模式"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(84, 40)
        Me.Button10.Margin = New System.Windows.Forms.Padding(6)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(204, 52)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "读设备状态"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button4)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 442)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox6.Size = New System.Drawing.Size(862, 112)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "连通性测试"
        Me.GroupBox6.UseCompatibleTextRendering = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(280, 40)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(276, 52)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "测试平台连通性"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 316)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 732)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.GroupBox7)
        Me.TabPage1.Controls.Add(Me.GroupBox8)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(884, 685)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "NB-IoT电路板检测"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.TextBox1)
        Me.GroupBox10.Controls.Add(Me.Button11)
        Me.GroupBox10.Location = New System.Drawing.Point(26, 568)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox10.Size = New System.Drawing.Size(862, 102)
        Me.GroupBox10.TabIndex = 15
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "数据保存"
        Me.GroupBox10.UseCompatibleTextRendering = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 52)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 24)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "批号"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(152, 46)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 14
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 35)
        Me.TextBox1.TabIndex = 14
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(464, 38)
        Me.Button11.Margin = New System.Windows.Forms.Padding(6)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(136, 52)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "数据保存"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(8, 39)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(884, 685)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "检测数据查询"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DataGridView1)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox9.Size = New System.Drawing.Size(864, 511)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "查询结果"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 36)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(852, 467)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.DtpEnd)
        Me.GroupBox3.Controls.Add(Me.DtpStart)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.TxtVaule)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(864, 152)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "查询条件设置"
        '
        'DtpEnd
        '
        Me.DtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpEnd.Location = New System.Drawing.Point(521, 100)
        Me.DtpEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpEnd.Name = "DtpEnd"
        Me.DtpEnd.Size = New System.Drawing.Size(168, 35)
        Me.DtpEnd.TabIndex = 20
        '
        'DtpStart
        '
        Me.DtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpStart.Location = New System.Drawing.Point(521, 40)
        Me.DtpStart.Margin = New System.Windows.Forms.Padding(4)
        Me.DtpStart.Name = "DtpStart"
        Me.DtpStart.Size = New System.Drawing.Size(168, 35)
        Me.DtpStart.TabIndex = 19
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(728, 90)
        Me.Button9.Margin = New System.Windows.Forms.Padding(6)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 46)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "导出"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TxtVaule
        '
        Me.TxtVaule.Location = New System.Drawing.Point(14, 89)
        Me.TxtVaule.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtVaule.MaxLength = 10
        Me.TxtVaule.Name = "TxtVaule"
        Me.TxtVaule.Size = New System.Drawing.Size(168, 35)
        Me.TxtVaule.TabIndex = 16
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(728, 36)
        Me.Button6.Margin = New System.Windows.Forms.Padding(6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(128, 46)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "查询"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 40)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 24)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "查询值"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(398, 100)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "结束时间"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(398, 47)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "起始时间"
        '
        'OkMeterTableAdapter
        '
        Me.OkMeterTableAdapter.ClearBeforeFill = True
        '
        'Rt_DetectDataSet
        '
        Me.Rt_DetectDataSet.DataSetName = "Rt_DetectDataSet"
        Me.Rt_DetectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(227, 47)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(162, 28)
        Me.CheckBox2.TabIndex = 21
        Me.CheckBox2.Text = "按时间区间"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'MainFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1716, 1060)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MainFrom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NB检测工具"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Rt_DetectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BntReadCard As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CommStatus As System.Windows.Forms.Label
    Friend WithEvents BntOpen As System.Windows.Forms.Button
    Friend WithEvents CmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents 端口号 As System.Windows.Forms.Label
    Friend WithEvents BntClose As System.Windows.Forms.Button
    Friend WithEvents RecTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtModeNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSimNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMeterNumOld As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMeterNumNew As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbParity As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBound As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTimeOutRemote As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTimeOutLocal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtMeterNum As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents TxtVaule As TextBox
    Friend WithEvents DtpEnd As DateTimePicker
    Friend WithEvents DtpStart As DateTimePicker
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button11 As Button
    Friend WithEvents OkMeterTableAdapter As Rt_DetectDataSetTableAdapters.OkMeterTableAdapter
    Friend WithEvents Rt_DetectDataSet As Rt_DetectDataSet
    Friend WithEvents CheckBox2 As CheckBox
End Class
