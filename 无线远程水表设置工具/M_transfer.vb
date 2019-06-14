Imports vb6 = Microsoft.VisualBasic.Compatibility.VB6
Imports vb = Microsoft.VisualBasic
Module M_transfer

    Public Function GetData(ByRef input As String, ByVal length As Integer) As String
        Dim output As String
        If (input.Length > length) Then
            output = input.Substring(0, length)
            input = input.Substring(length, input.Length - length)
        Else
            output = input
            input = ""
        End If
        Return output
    End Function

    Public Function StrDotBCD(ByVal inputStr As String, dotLenth As Integer) As String
        If (inputStr = "0") Then
            Return inputStr
        End If
        If (inputStr = "") Then
            Return "0"
        End If
        If (inputStr.Length <= dotLenth) Then
            Return "0." + inputStr.PadLeft(dotLenth, "0")
        ElseIf dotLenth = 0 Then
            Return inputStr
        Else
            Return inputStr.Substring(0, inputStr.Length - dotLenth) + "." + inputStr.Substring(inputStr.Length - dotLenth)
        End If
    End Function
    Public Function HexStrDotBCD(ByVal inputStr As String, dotLenth As Integer) As String
        If (inputStr = "0") Then
            Return inputStr
        End If
        If (inputStr = "") Then
            Return "0"
        End If
        inputStr = HEXTODEC(inputStr)
        If (inputStr.Length <= dotLenth) Then

            Return "0." + inputStr.PadLeft(dotLenth, "0")
        ElseIf dotLenth = 0 Then
            Return inputStr
        Else
            Return inputStr.Substring(0, inputStr.Length - dotLenth) + "." + inputStr.Substring(inputStr.Length - dotLenth)
        End If
    End Function

    Public Function BCDDotStr(ByVal inputStr As String, lenth As Integer, dotLenth As Integer) As String
        Dim sTemp As String
        Dim mMulti = Convert.ToDecimal("1".PadRight(dotLenth + 1, "0"))
        If (inputStr = "") Then
            inputStr = "0"
        End If
        sTemp = (Convert.ToDecimal(inputStr) * mMulti).ToString("0")

        If (sTemp.Length > lenth) Then

            Return sTemp.Substring(sTemp.Length - lenth, lenth)

        Else

            Return sTemp.PadLeft(lenth, "0")
        End If
    End Function

    Public Function HexDotStr(inputStr As String, lenth As Integer, dotLenth As Integer) As String

        Dim sTemp As String
        Dim mMulti As Decimal = Convert.ToDecimal("1".PadRight(dotLenth + 1, "0"))
        If (inputStr = "") Then
            inputStr = "0"
        End If

        sTemp = dectohex(Convert.ToInt64(Convert.ToDecimal(inputStr) * mMulti))

        If (sTemp.Length > lenth) Then
            Return sTemp.Substring(sTemp.Length - lenth, lenth)
        Else
            Return sTemp.PadLeft(lenth, "0")
        End If
    End Function

    '以下为对十进制与十六进制相互转换的函数
    Function dectohex(ByVal hugenum As String) As String ' trans hugenum to hex
        Dim i As Object ' trans hugenum to hex
        Do While Len(hugenum) > 2
            'UPGRADE_WARNING: Mod 有新行为。 单击以获得更多信息:“ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"”
            dectohex = Hex(Val(Right(hugenum, 4)) Mod 16) & dectohex
            For i = 1 To 4 'devide hugenum by 16
                hugenum = half(hugenum)
            Next
        Loop
        dectohex = Hex(Val(hugenum)) & dectohex
    End Function
    '十六进制抟换为十进制
    Function HEXTODEC(ByVal X As String) As String

        Dim a() As String, i As Long, UNIT As Integer
        Dim str As String = New String("0", (6 - Len(X) Mod 6) Mod 6)

        X = str & X

        UNIT = Len(X) \ 6 - 1
        ReDim a(UNIT)
        For i = 0 To UNIT
            a(i) = CLng("&h" & Mid(X, i * 6 + 1, 6))
        Next
        For i = 0 To UNIT
            a(i) = multi(a(i), POWERS(UNIT - i))
            HEXTODEC = sums(HEXTODEC, a(i))
        Next
    End Function
    Function sums(ByVal X As String, ByVal Y As String) As String ' sum of two hugehexnum（两个大数之和）
        Dim max As Long, temp As Long, i As Long, result As Object
        max = IIf(Len(X) >= Len(Y), Len(X), Len(Y))
        Dim str As String = New String("0", CStr(max))
        X = Right(str & X, max)
        Y = Right(str & Y, max)
        ReDim result(max)
        For i = max To 1 Step -1
            result(i) = Val(Mid(X, i, 1)) + Val(Mid(Y, i, 1))
        Next
        For i = max To 1 Step -1
            temp = result(i) \ 10
            result(i) = result(i) Mod 10
            result(i - 1) = result(i - 1) + temp
        Next
        If result(0) = 0 Then result(0) = ""
        sums = Join(result, "")
        Erase result
    End Function

    Function multi(ByVal X As String, ByVal Y As String) As String 'multi of two huge hexnum（两个大数之积）
        Dim result As Object
        Dim xl As Long, yl As Long, temp As Long, i As Long
        xl = Len(Trim(X))
        yl = Len(Trim(Y))
        ReDim result(xl + yl)
        For i = 1 To xl
            For temp = 1 To yl
                result(i + temp) = result(i + temp) + Val(Mid(X, i, 1)) * Val(Mid(Y, temp, 1))
            Next
        Next
        For i = xl + yl To 2 Step -1
            temp = result(i) \ 10
            result(i) = result(i) Mod 10
            result(i - 1) = result(i - 1) + temp
        Next
        If result(1) = "0" Then result(1) = ""
        multi = Join(result, "")
        Erase result
    End Function
    Function POWERS(ByVal X As Integer) As String ' GET 16777216^X,ie 16^(6*x)（16777216的X 次方）
        POWERS = 1
        Dim i As Integer
        For i = 1 To X
            POWERS = multi(POWERS, CLng(&H1000000))
        Next
    End Function
    Function half(ByVal X As String) As String 'get half of x（取半）
        X = 0 & X
        Dim i As Integer
        'Dim result As String
        Dim result(Len(X)) As String
        For i = 2 To Len(X)
            result(i) = CStr(Val(Mid(X, i, 1)) \ 2 + IIf(Val(Mid(X, i - 1, 1)) Mod 2 = 1, 5, 0))
        Next
        half = Join(result, "")
        If Left(half, 1) = "0" Then half = Right(half, Len(half) - 1) ' no zero ahead
    End Function
    '*************************************************************************************
    'describe：把十进制数变为二进制数
    'Out：DecimalToBinary
    'In: DecimalValue需要转化的数值,MinimumDigits需要转化的长度
    'author:Dave fox
    '*************************************************************************************
    Public Function DecimalToBinary(ByVal DecimalValue As Long, ByVal MinimumDigits As Integer) As String

        ' Returns a string containing the binary
        ' representation of a positive integer.

        Dim result As String
        Dim ExtraDigitsNeeded As Integer
        Dim str As String = New String("0", ExtraDigitsNeeded)

        ' Make sure value is not negative.
        DecimalValue = Math.Abs(DecimalValue)

        ' Construct the binary value.
        Do
            result = CStr(DecimalValue Mod 2) & result
            DecimalValue = DecimalValue \ 2
        Loop While DecimalValue > 0

        ' Add leading zeros if needed.

        ExtraDigitsNeeded = MinimumDigits - Len(result)
        If ExtraDigitsNeeded > 0 Then
            result = str & result
        End If

        DecimalToBinary = result

    End Function


    '以下为对十进制转换为十六进制在前面补零的函数
    Function dectohex1(ByVal hugenum As String, ByVal MinimumDigits As Integer) As String ' trans hugenum to hex
        Dim ExtraDigitsNeeded As Integer
        Dim i As Object ' trans hugenum to hex
        Do While Len(hugenum) > 2
            'UPGRADE_WARNING: Mod 有新行为。 单击以获得更多信息:“ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"”
            dectohex1 = Hex(Val(Right(hugenum, 4)) Mod 16) & dectohex1
            For i = 1 To 4 'devide hugenum by 16
                hugenum = half(hugenum)
            Next
        Loop
        dectohex1 = Hex(Val(hugenum)) & dectohex1

        ExtraDigitsNeeded = MinimumDigits - Len(dectohex1)
        Dim str As String = New String("0", ExtraDigitsNeeded)
        If ExtraDigitsNeeded > 0 Then
            dectohex1 = str & dectohex1
        End If
        dectohex1 = dectohex1
    End Function
    '字节校验和
    Public Function hexAddSum(ByVal number As String) As String
        Dim i, n As Integer
        Dim m As String
        Dim sum As String
        n = Len(Trim(number))
        For i = 1 To n Step 2
            'm = Val("&H" + Mid(number, i, 2))
            'sum = Val("&H" + sum)
            m = Val(HEXTODEC(Mid(number, i, 2)))
            sum = Val(HEXTODEC(sum))
            sum = dectohex((Val(sum) + Val(m)))
            sum = Right(sum, 2)
        Next
        hexAddSum = sum.PadLeft(2, "0")
    End Function
    Public Function hexAddSum_4(ByVal number As String) As String
        Dim i, n As Integer
        Dim m As String
        Dim sum As String
        n = Len(Trim(number))
        For i = 1 To n Step 2
            'm = Val("&H" + Mid(number, i, 2))
            'sum = Val("&H" + sum)
            m = Val(HEXTODEC(Mid(number, i, 2)))
            sum = Val(HEXTODEC(sum))
            sum = dectohex((Val(sum) + Val(m)))
            sum = sum.PadLeft(4,"00")
        Next
        hexAddSum_4 = sum
    End Function

    Public Function hexAddSum1(ByVal number As String) As String
        Dim i, n As Integer
        Dim m As String
        Dim sum As String
        n = Len(Trim(number))
        For i = 1 To n Step 2
            'm = Val("&H" + Mid(number, i, 2))
            'sum = Val("&H" + sum)
            m = Val((Mid(number, i, 2)))
            sum = Val((sum))
            sum = Val(sum) + Val(m)
            'Sum = Right(Sum, 2)
        Next
        hexAddSum1 = dectohex(sum)
    End Function

    '    '二进制转换为十进制
    '    Public Function B_To_D(ByVal Bin As String) As Integer
    '        Dim i As Long
    '        For i = 1 To Len(Bin)
    '            B_To_D = B_To_D * 2 + Val(Mid(Bin, i, 1))
    '        Next i
    '    End Function
    '判断是否为数字型
    Public Function IsNumber(ByVal sData As String) As Integer
        Dim i As Long
        Dim j As Integer
        On Error GoTo ConflictHandler
        If Len(sData) = 0 Then
            i = CLng(sData)
        Else
            For j = 1 To Len(sData)
                i = CLng(Mid(sData, j, 1))
            Next
        End If
        IsNumber = 0
        On Error GoTo 0
        Exit Function
ConflictHandler:
        IsNumber = 1
    End Function
    Public Function ErrLine() As String
        ErrLine = "是数字型！"
    End Function

    Function UpZero(ByVal X As String, ByVal Y As String) As String
        Dim i As Integer
        Dim z As String
        z = Trim(X)
        For i = 1 To Y - Len(z)
            '  z = "0" & z
            z = z & "0"
        Next
        UpZero = z
    End Function
    Public Function TFinit(ByVal Idata As String) As String
        Dim Newdata As String
        Dim i, slen As Integer
        On Error GoTo Data
        slen = Len(Trim(Idata))
        For i = 1 To slen
            Newdata = Mid(Idata, i, 1)
            If Newdata = 0 Then
            Else
                GoTo Data
            End If
        Next
Data:
        TFinit = Mid(Idata, i, slen - i + 1)
    End Function
    Public Function Strright(ByVal a As String) As String
        If Len(a) >= 2 Then
            Strright = Right(a, 2)
        Else
            Strright = Format(a, "00")
        End If
    End Function
    Public Function B_To_D(ByVal Bin As String) As Integer
        Dim i As Long
        For i = 1 To Len(Bin)
            B_To_D = B_To_D * 2 + Val(Mid(Bin, i, 1))
        Next i
    End Function

    Public Function dotstr82(ByVal s As String, ByVal ss As String)
        Dim i As Integer
        i = s.Length
        If s = "0" Then
            ss = s
        Else
            ss = s.Substring(0, i - 2) & "." & s.Substring(i - 2, 2)
        End If
        Return ss
    End Function
    Public Function dotstr84(ByVal s As String, ByVal ss As String)
        Dim i As Integer
        i = s.Length
        If s = "" Then
            MsgBox("返写数据为空", MsgBoxStyle.Exclamation, "提示")
            Exit Function
        End If

        If s = "0" Then
            ss = s
        Else
            ss = s.Substring(0, i - 4) & "." & s.Substring(i - 4, 4)
        End If
        Return ss

    End Function
    '倒序
    Public Function DxStr(str As String) As String
        Dim i As Integer, s As String
        For i = 1 To Len(str) Step 2
            s = Mid(str, i, 2) & s
        Next
        DxStr = s
    End Function
    '计算偶校验
    Public Function EvenCheck(str As String) As String
        Dim i, count As Integer, s As String
        s = ""
        str = DxStr(str)
        For i = 1 To Len(str) Step 2
            count = GetCount1OfValue(Convert.ToInt32(Mid(str, i, 2), 16))
            If count Mod 2 = 0 Then
                s = s & "0"
            Else
                s = s & "1"
            End If
        Next
        str = Convert.ToString(Convert.ToInt32(s, 2), 16).PadLeft(2, "0")
        Return str
    End Function
    '取数字里面含有多少个1
    Public Function GetCount1OfValue(Value As Integer) As Integer
        Dim Count As Integer = 0
        Do While Value > 0
            Value = Value And (Value - 1)
            Count += 1
        Loop
        Return Count
    End Function
    '亦或计算
    Public Function GetStrXor(key As String, Value As String) As String
        Dim i, pKey As Integer
        Dim XorRes As String = ""
        Dim Result As String = ""
        pKey = Convert.ToInt32(key, 16)
        For i = 1 To Len(Value) Step 2
            XorRes = Val("&H" & Mid(Value, i, 2)) Xor pKey
            Result = Result + Convert.ToString(Hex(XorRes)).PadLeft(2, "0")
        Next
        Return Result
    End Function

    Public Function AddSpace(StrInput As String) As String
        Dim i As Integer
        Dim strNew As String = ""
        For i = 1 To Len(StrInput) Step 2
            strNew &= Mid(StrInput, i, 2)
            If i <> Len(StrInput) Then strNew &= " "
        Next
        Return strNew
    End Function
End Module
