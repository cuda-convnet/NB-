Module MyDeclare
    ''' <summary>
    ''' Des 加密
    ''' </summary>
    ''' <param name="Key">加密密钥</param>
    ''' <param name="InputData">输入明文</param>
    ''' <param name="OutPutData">输出密文</param>
    ''' <remarks></remarks>
    Declare Function DES Lib "DesInterface.dll" (ByVal Key As String, ByVal InputData As String, ByRef OutPutData As String) As Long

    ''' <summary>
    ''' Des 解密
    ''' </summary>
    ''' <param name="Key">加密密钥</param>
    ''' <param name="InputData">输入密文</param>
    ''' <param name="OutPutData">输出明文</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Declare Function _DES Lib "DesInterface.dll" (ByVal Key As String, ByVal InputData As String, ByRef OutPutData As String) As Long

    ''' <summary>
    ''' 3Des 加密
    ''' </summary>
    ''' <param name="Key">加密密钥</param>
    ''' <param name="InputData">输入明文</param>
    ''' <param name="OutPutData">输出密文</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Declare Function SDES Lib "DesInterface.dll" (ByVal Key As String, ByVal InputData As String, ByRef OutPutData As String) As Long

    ''' <summary>
    ''' 3Des 解密
    ''' </summary>
    ''' <param name="Key">加密密钥</param>
    ''' <param name="InputData">输入密文</param>
    ''' <param name="OutPutData">输出明文</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Declare Function _SDES Lib "DesInterface.dll" (ByVal Key As String, ByVal InputData As String, ByRef OutPutData As String) As Long
End Module
