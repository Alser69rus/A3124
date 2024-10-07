Imports System.ComponentModel
Imports System.Math
'Imports Microsoft.Office.Interop.Excel

Public Class cOscill

    Private G As Graphics
    Private W As Single
    Private H As Single
    Private X0, Y0 As Single

    Private gW As Single
    Private gH As Single

#Region "Свойства"
    Private mLeft As Single = 20
    <Category("My Property")> _
    Public Property AxisLeft() As Single
        Get
            Return mLeft
        End Get
        Set(ByVal value As Single)
            mLeft = value
        End Set
    End Property

    Private mRight As Single = 20
    <Category("My Property")> _
    Public Property AxisRight() As Single
        Get
            Return mRight
        End Get
        Set(ByVal value As Single)
            mRight = value
        End Set
    End Property

    Private mTop As Single = 20
    <Category("My Property")> _
    Public Property AxisTop() As Single
        Get
            Return mTop
        End Get
        Set(ByVal value As Single)
            mTop = value
        End Set
    End Property

    Private mBottom As Single = 20
    <Category("My Property")> _
    Public Property AxisBot() As Single
        Get
            Return mBottom
        End Get
        Set(ByVal value As Single)
            mBottom = value
        End Set
    End Property

    Private mXmin As Single = 0
    <Category("My Property")> _
    Public Property Xmin() As Single
        Get
            Return mXmin
        End Get
        Set(ByVal value As Single)
            mXmin = value
            ChangeGraphics()
            G.Clear(Me.BackColor)
            DrawBound(G)
            Me.Invalidate()
        End Set
    End Property

    Private mXmax As Single = 100
    <Category("My Property")> _
    Public Property Xmax() As Single
        Get
            Return mXmax
        End Get
        Set(ByVal value As Single)
            mXmax = value
            ChangeGraphics()
            G.Clear(Me.BackColor)
            DrawBound(G)
            Me.Invalidate()
        End Set
    End Property

    Private mYmin As Single = 0
    <Category("My Property")> _
    Public Property Ymin() As Single
        Get
            Return mYmin
        End Get
        Set(ByVal value As Single)
            mYmin = value
            ChangeGraphics()
            G.Clear(Me.BackColor)
            DrawBound(G)
            Me.Invalidate()
        End Set
    End Property

    Private mYmax As Single = 100
    <Category("My Property")> _
    Public Property Ymax() As Single
        Get
            Return mYmax
        End Get
        Set(ByVal value As Single)
            mYmax = value
            ChangeGraphics()
            G.Clear(Me.BackColor)
            DrawBound(G)
            Me.Invalidate()
        End Set
    End Property

    Private mStepY As Single = 10
    <Category("My Property")> _
    Public Property StepY() As Single
        Get
            Return mStepY
        End Get
        Set(ByVal value As Single)
            mStepY = value
        End Set
    End Property

    Private mStepX As Single = 10
    <Category("My Property")> _
    Public Property StepX() As Single
        Get
            Return mStepX
        End Get
        Set(ByVal value As Single)
            mStepX = value
        End Set
    End Property

    Private mPointHight As Single = 6
    <Category("My Property")> _
    Public Property PointHight() As Single
        Get
            Return mPointHight
        End Get
        Set(ByVal value As Single)
            mPointHight = value
        End Set
    End Property

    Private mFontAxis As Font = Me.Font
    <Category("My Property")> _
    Public Property FontAxis() As Font
        Get
            Return mFontAxis
        End Get
        Set(ByVal value As Font)
            mFontAxis = value
        End Set
    End Property

    Private mFontPoint As Font = Me.Font
    <Category("My Property")> _
    Public Property FontPoint() As Font
        Get
            Return mFontPoint
        End Get
        Set(ByVal value As Font)
            mFontPoint = value
        End Set
    End Property

    Private mFontTitle As Font = Me.Font
    <Category("My Property")> _
    Public Property FontTitle() As Font
        Get
            Return mFontTitle
        End Get
        Set(ByVal value As Font)
            mFontTitle = value
        End Set
    End Property

    Private mTextAxisX As String = "Ось X"
    <Category("My Property")> _
    Public Property TextAxisX() As String
        Get
            Return mTextAxisX
        End Get
        Set(ByVal value As String)
            mTextAxisX = value
        End Set
    End Property

    Private mTextAxisY As String = "Ось Y"
    <Category("My Property")> _
    Public Property TextAxisY() As String
        Get
            Return mTextAxisY
        End Get
        Set(ByVal value As String)
            mTextAxisY = value
        End Set
    End Property

    Private mTitleText As String = "График"
    <Category("My Property")> _
    Public Property TitleText() As String
        Get
            Return mTitleText
        End Get
        Set(ByVal value As String)
            mTitleText = value
        End Set
    End Property

    Private mTextTitleOffset As Single = 0
    <Category("My Property")> _
    Public Property TextTitleOffset() As Single
        Get
            Return mTextTitleOffset
        End Get
        Set(ByVal value As Single)
            mTextTitleOffset = value
        End Set
    End Property

    Private mTextAxisXoffset As Single = 0
    <Category("My Property")> _
    Public Property TextAxisXoffset() As Single
        Get
            Return mTextAxisXoffset
        End Get
        Set(ByVal value As Single)
            mTextAxisXoffset = value
        End Set
    End Property

    Private mTextAxisYoffset As Single = 0
    <Category("My Property")> _
    Public Property TextAxisYoffset() As Single
        Get
            Return mTextAxisYoffset
        End Get
        Set(ByVal value As Single)
            mTextAxisYoffset = value
        End Set
    End Property

    Private mPointSize As Single = 4
    <Category("My Property")> _
    Public Property PointSize() As Single
        Get
            Return mPointSize
        End Get
        Set(ByVal value As Single)
            mPointSize = value
        End Set
    End Property

    Private mGrafColor As Color = Color.Red
    <Category("My Property")> _
    Public Property GrafColor() As Color
        Get
            Return mGrafColor
        End Get
        Set(ByVal value As Color)
            mGrafColor = value
        End Set
    End Property

    Private mSmoothing As Boolean = False
    <Category("My Property")> _
    Public Property Smoothing() As Boolean
        Get
            Return mSmoothing
        End Get
        Set(ByVal value As Boolean)
            mSmoothing = value
        End Set
    End Property

#End Region

#Region "Методы"
    Private bmp As Bitmap

    Private Sub ChangeGraphics()
        W = Me.ClientRectangle.Width - 1
        H = Me.ClientRectangle.Height - 1
        gW = W - mLeft - mRight
        gH = H - mTop - mBottom
        X0 = mLeft
        Y0 = H - mBottom
        If H > 0 And W > 0 Then
            bmp = New Bitmap(CInt(W), CInt(H))
            'bmp.SetResolution(1024.0!, 1024.0!)

            G = Graphics.FromImage(bmp)

            Me.BackgroundImage = bmp
        End If

        'Debug.Print("ChangeGraphics")
    End Sub

    Private Sub DrawBound(ByVal g As Graphics)

        DrawGridX(g)
        DrawGridY(g)
        DrawPointX(g)
        DrawPointY(g)
        DrawPointAxisX(g)
        mMaxWightTextY = DrawPointAxisY(g)

        DrawTextX(g)
        DrawTextY(g)

        DrawTitle(g)
        'ax Y
        g.DrawLine(New Pen(Color.Black, 2), mLeft, mTop, mLeft, H - mBottom)
        'ax X
        g.DrawLine(New Pen(Color.Black, 2), mLeft, H - mBottom - gH / 2, W - mRight, H - mBottom - gH / 2)

        'Debug.Print("DrawBound")
    End Sub

    Private Sub DrawPointX(ByVal g As Graphics)
        g.ResetTransform()

        For i As Single = mXmin + mStepX To mXmax Step mStepX
            Dim delta As Single = gW / (mXmax - mXmin)
            g.DrawLine(Pens.Black, X0 + i * delta, Y0 + mPointHight / 2, X0 + i * delta, Y0 - mPointHight / 2)
            g.DrawLine(Pens.Black, X0 + i * delta, Y0 + mPointHight / 2 - gH / 2, X0 + i * delta, Y0 - mPointHight / 2 - gH / 2)
        Next i

    End Sub

    Private Sub DrawPointY(ByVal g As Graphics)
        g.ResetTransform()

        For i As Single = mYmin To mYmax Step mStepY
            Dim delta As Single = gH / (mYmax - mYmin)
            g.DrawLine(Pens.Black, X0 + mPointHight / 2, Y0 - i * delta, X0 - mPointHight / 2, Y0 - i * delta)
        Next i
    End Sub

    Private Sub DrawGridX(ByVal g As Graphics)
        g.ResetTransform()

        For i As Single = mXmin + mStepX To mXmax Step mStepX
            Dim delta As Single = gW / (mXmax - mXmin)
            g.DrawLine(New Pen(Color.LightGray, 1), X0 + i * delta, Y0, X0 + i * delta, Y0 - gH)
        Next i

        'Debug.Print("DrawPointX")
    End Sub

    Private Sub DrawGridY(ByVal g As Graphics)
        g.ResetTransform()

        For i As Single = mYmin To mYmax Step mStepY
            Dim delta As Single = gH / (mYmax - mYmin)
            g.DrawLine(New Pen(Color.LightGray, 1), X0, Y0 - i * delta, X0 + gW, Y0 - i * delta)
        Next i
        'Debug.Print("DrawPointY")
    End Sub

    Private Sub DrawPointAxisX(ByVal g As Graphics)
        g.ResetTransform()

        Dim drawFormat As New StringFormat
        drawFormat.LineAlignment = StringAlignment.Near
        drawFormat.Alignment = StringAlignment.Center

        For i As Single = mXmin + mStepX To mXmax Step mStepX
            Dim delta As Single = gW / (mXmax - mXmin)
            g.DrawString(i.ToString, mFontPoint, Brushes.Black, X0 + i * delta, Y0 + mPointHight / 2, drawFormat)

        Next i

        'Debug.Print("DrawPointAxisX")
    End Sub

    Private Function DrawPointAxisY(ByVal g As Graphics) As Single
        Dim lenght As Single
        DrawPointAxisY = 0

        g.ResetTransform()

        Dim drawFormat As New StringFormat
        drawFormat.LineAlignment = StringAlignment.Center
        drawFormat.Alignment = StringAlignment.Far

        Dim cnt As Integer = 0
        Dim val As Integer

        For i As Single = mYmax To mYmin Step -mStepY
            Dim delta As Single = gH / (mYmax - mYmin)
            val = mYmax - 2 * cnt * mStepY
            cnt += 1
            g.DrawString(val.ToString, mFontPoint, Brushes.Black, X0 - mPointHight / 2, Y0 - i * delta, drawFormat)
            lenght = g.MeasureString(val.ToString, mFontPoint).Width

            If lenght > DrawPointAxisY Then DrawPointAxisY = lenght
        Next i
        'Debug.Print("DrawPointAxisY")
    End Function

    Private Sub DrawTextX(ByVal g As Graphics)
        g.ResetTransform()

        Dim rect As New System.Drawing.Rectangle(X0, Y0 + (mPointHight / 2) + mFontPoint.Height + mTextAxisXoffset, gW, mFontAxis.Height)
        Dim drawFormat As New StringFormat

        drawFormat.LineAlignment = StringAlignment.Center
        drawFormat.Alignment = StringAlignment.Center
        g.DrawString(TextAxisX, mFontAxis, Brushes.Black, rect, drawFormat)
        'Debug.Print("DrawTextX")
    End Sub

    Dim mMaxWightTextY As Single = 0

    Private Sub DrawTextY(ByVal g As Graphics)
        g.ResetTransform()

        Dim rect As New System.Drawing.Rectangle(X0 - mFontAxis.Height, mTop, mFontAxis.Height, gH)
        Dim drawFormat As New StringFormat

        drawFormat.LineAlignment = StringAlignment.Center
        drawFormat.Alignment = StringAlignment.Center
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical
        g.TranslateTransform(X0 - mMaxWightTextY - mTextAxisXoffset - mFontAxis.Height / 2, mTop + gH / 2)
        g.RotateTransform(180)
        g.DrawString(TextAxisY, mFontAxis, Brushes.Black, 0, 0, drawFormat)
        'Debug.Print("DrawTextY")
    End Sub

    Private Sub DrawTitle(ByVal g As Graphics)
        g.ResetTransform()

        Dim rect As New System.Drawing.Rectangle(X0, 1 + mTextTitleOffset, gW, mTop - 2)
        Dim drawFormat As New StringFormat

        drawFormat.LineAlignment = StringAlignment.Center
        drawFormat.Alignment = StringAlignment.Center
        drawFormat.FormatFlags = StringFormatFlags.DisplayFormatControl

        g.DrawString(mTitleText, mFontTitle, Brushes.Black, rect, drawFormat)
        'Debug.Print("DrawTitle")
    End Sub


    Dim path_refresh As New Drawing2D.GraphicsPath

    Private kx As Single=0

    Private Overloads Sub DrawCurve(ByVal g As Graphics, ByRef values As Single(), ByVal color As Color, Optional ByVal clear As Boolean = True)
        Dim sX, sY As Single

        If clear = True Then
            g.ResetTransform()

            g.Clear(Me.BackColor)

            'g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            'g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

            DrawBound(g)
        End If


        'Me.Invalidate(New Region(path_refresh))

        Dim points_line(values.GetUpperBound(0)) As Point
        Dim points_refresh(values.Length * 2 - 1) As Point

        kx = mXmax / values.GetUpperBound(0)
        Dim old As Single = values(0)



        For i As Integer = 0 To values.GetUpperBound(0)

            ConvertCoords(i * kx, values(i), sX, sY)
            points_line(i) = New System.Drawing.Point(sX, sY)

            If i > 0 Then
                If values(i) <= old Then
                    points_refresh(i - 1) = New System.Drawing.Point(sX + 0, sY - 4)
                    'points_refresh(values.Length * 2 - 1 - i) = New System.Drawing.Point(sX + 2, sY - 2)
                Else
                    points_refresh(i - 1) = New System.Drawing.Point(sX + 0, sY - 4)
                    'points_refresh(values.Length * 2 - 1 - i) = New System.Drawing.Point(sX - 2, sY - 2)
                End If
            Else
                'points_refresh(0) = New System.Drawing.Point(sX, sY - 2)
            End If


            old = values(i)
        Next

        path_refresh = New Drawing2D.GraphicsPath
        path_refresh.AddPolygon(points_refresh)

        If mSmoothing Then
            g.DrawCurve(New Pen(color), points_line, 0.5)
        Else
            g.DrawLines(New Pen(color, 0.5), points_line)
            'g.DrawLines(New Pen(Drawing.Color.Green, 0.5), points_refresh)

            'g.DrawPolygon(Pens.Black, points_refresh)

        End If

        'g.DrawLine(Pens.Green, mLeft + 1, 25, gH - 1, 25)

        Me.Invalidate(New Region(New Rectangle(mLeft + 1, mTop + 1, gW - 1, gH - 1)))
        'Me.Invalidate(New Region(path_refresh))
        'Debug.Print("DrawCurve")
    End Sub

    Public Overloads Sub DrawCurveXY(ByVal g As Graphics, ByRef valuesX As Single(), ByRef valuesY As Single(), ByVal color As Color)
        Dim sX, sY As Single

        g.ResetTransform()

        g.Clear(Me.BackColor)

        'g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        'g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality

        DrawBound(g)

        'Me.Invalidate(New Region(path_refresh))

        Dim points_line(valuesX.GetUpperBound(0)) As Point
        Dim points_refresh(valuesX.Length * 2 - 1) As Point

        Dim kx As Single = mXmax / valuesX.GetUpperBound(0)
        Dim old As Single = valuesY(0)



        For i As Integer = 0 To valuesX.GetUpperBound(0)

            ConvertCoords(valuesX(i), valuesY(i), sX, sY)
            points_line(i) = New System.Drawing.Point(sX, sY)

            If i > 0 Then
                If valuesY(i) <= old Then
                    points_refresh(i - 1) = New System.Drawing.Point(sX + 0, sY - 4)
                    'points_refresh(values.Length * 2 - 1 - i) = New System.Drawing.Point(sX + 2, sY - 2)
                Else
                    points_refresh(i - 1) = New System.Drawing.Point(sX + 0, sY - 4)
                    'points_refresh(values.Length * 2 - 1 - i) = New System.Drawing.Point(sX - 2, sY - 2)
                End If
            Else
                'points_refresh(0) = New System.Drawing.Point(sX, sY - 2)
            End If


            old = valuesY(i)
        Next

        path_refresh = New Drawing2D.GraphicsPath
        path_refresh.AddPolygon(points_refresh)

        If mSmoothing Then
            g.DrawCurve(New Pen(color), points_line, 0.5)
        Else
            g.DrawLines(New Pen(color, 0.5), points_line)
            'g.DrawLines(New Pen(Drawing.Color.Green, 0.5), points_refresh)

            'g.DrawPolygon(Pens.Black, points_refresh)

        End If

        'g.DrawLine(Pens.Green, mLeft + 1, 25, gH - 1, 25)

        Me.Invalidate(New Region(New Rectangle(mLeft + 1, mTop + 1, gW - 1, gH - 1)))
        'Me.Invalidate(New Region(path_refresh))
    End Sub

    Private Overloads Sub ConvertCoords(ByVal X As Single, ByVal Y As Single, ByRef X_screen As Single, ByRef Y_screen As Single)
        If Y > mYmax Then Y = mYmax
        If Y < -mYmax Then Y = -mYmax

        X_screen = X0 + GetXscreen(X)
        Y_screen = Y0 - GetYscreen(Y) - gH / 2
    End Sub

    Private Function GetXscreen(ByVal X As Single) As Single
        Return (X * gW) / (mXmax - mXmin)
    End Function

    Private Function GetYscreen(ByVal Y As Single) As Single
        Return (Y * gH) / (mYmax - mYmin) / 2
    End Function

#End Region

#Region "События"

    Public Sub DrawOscill(ByRef Values As Short(), ByVal koef As Single)
        Me.BeginInvoke(New delegatUIDrawOscill(AddressOf UIDrawOscill), Values, koef)
    End Sub

    Public Sub DrawOscill2(ByRef Values As Short(), ByVal koef As Single)
        Me.BeginInvoke(New delegatUIDrawOscill(AddressOf AddCurve), Values, koef)
    End Sub


    Public Sub AddCurve(ByRef Values As Short(), ByVal koef As Single)

        Dim mColor As Color = Color.Blue

        Dim a_sing(Values.GetUpperBound(0)) As Single

        Dim i As Integer = 0

        For n As Integer = 0 To Values.GetUpperBound(0)
            a_sing(n) = Values(n) / koef
        Next

        DrawCurve(G, a_sing, mColor, False)
    End Sub

    Public Enum eLineDirect
        Горизонтальное
        Вертикальное
        ГоризонтальноеВертикальное
    End Enum

    Public Sub AddMarkLine(ByRef ValueX As Short, ByRef ValueY As Short, ByVal koef As Single, ByVal mColor As Color, ByVal direct As eLineDirect)



        Dim x1, y1, x2, y2 As Single


        ConvertCoords(ValueX * kx, Ymin, x1, y1)
        ConvertCoords(ValueX * kx, Ymax, x2, y2)

        G.DrawLine(New Pen(mColor), x1, y1, x2, y2)

        ConvertCoords(Xmin, ValueY, x1, y1)
        ConvertCoords(Xmax, ValueY, x2, y2)

        G.DrawLine(New Pen(mColor), x1, y1, x2, y2)

        Me.Invalidate(New Region(New Rectangle(mLeft + 1, mTop + 1, gW - 1, gH - 1)))

    End Sub

    Private Delegate Sub delegatUIDrawOscill(ByRef Values As Short(), ByVal koef As Single)
    Private Sub UIDrawOscill(ByRef Values As Short(), ByVal koef As Single)

        Dim a_sing(Values.GetUpperBound(0)) As Single

        Dim i As Integer = 0

        For n As Integer = 0 To Values.GetUpperBound(0)
            a_sing(n) = Values(n) / koef
        Next

        DrawCurve(G, a_sing, mGrafColor)
    End Sub

    Public Sub UIDrawOscillXY(ByRef Values1 As Short(), ByRef Values2 As Short(), ByVal koef1 As Single, ByVal koef2 As Single)

        Dim a_sing1(Values1.GetUpperBound(0)) As Single
        Dim a_sing2(Values2.GetUpperBound(0)) As Single

        Dim i As Integer = 0

        For n As Integer = 0 To Values1.GetUpperBound(0)
            a_sing1(n) = Values1(n) / koef1
            a_sing2(n) = Values2(n) / koef2
        Next

        DrawCurveXY(G, a_sing1, a_sing2, mGrafColor)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        ChangeGraphics()
        G.Clear(Me.BackColor)
        DrawBound(G)
        'Debug.Print("OnCreateControl")
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        'Debug.Print("onPaint")
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(e)
        'Debug.Print("onPaintBackground")
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)

        ChangeGraphics()
        G.Clear(Me.BackColor)
        DrawBound(G)

        'Debug.Print("OnResize")
    End Sub
    Public Sub RefreshTitle()

        DrawTitle(G)

    End Sub
#End Region

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub cOscill_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        'Me.Refresh()
        Me.Update()

    End Sub
End Class







