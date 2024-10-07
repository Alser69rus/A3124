Imports System.Threading
Imports System.Windows.Forms
Imports System.Drawing

Public Class TreeViewEx
    Inherits TreeView
    ''' <summary>
    ''' Обновляет информацию о состоянии ожидания
    ''' </summary>
    ''' <param name="Elapsed">Время прошедшее с начала проверки</param>
    ''' <param name="Duration">Продолжительность проверки </param>
    ''' <remarks>Дублирует событие RefreshWait объекта CWaiter
    ''' Только событие генерируется в потоке ппользовательского интерфейса
    ''' </remarks>
    Public Event RefreshWait(ByVal Elapsed As TimeSpan, ByVal Duration As TimeSpan)
    ''' <summary>
    ''' Передает информацию о новом ожидании
    ''' </summary>
    ''' <param name="_Wait">Время ожидания в секундах</param>
    ''' <param name="_NoCancel">Ожидание нельзя отменить до истечения заданного времени</param>
    ''' <param name="_Message">Дополнительное информационное сообщение</param>
    ''' <remarks>Дублирует событие NewWait объекта CWaiter
    ''' Только событие генерируется в потоке ппользовательского интерфейса
    ''' </remarks>
    Public Event NewWait(ByVal _Wait As Int32, ByVal _NoCancel As Boolean, ByVal _Message As String)
    ''' <summary>
    ''' Устанавливает новое информационное сообщение
    ''' </summary>
    ''' <param name="_Message">информационное сообщение</param>
    ''' <remarks></remarks>
    Public Event NewMessage(ByVal _Message As String)

    Public Sub New()
        MyBase.New()
        'mWaiter = New CWaiter
        InitializeComponent()
    End Sub


    Public Function GetNodeByKey(ByVal Key As String) As TreeNode
        Dim ord As TreeNode() = Me.Nodes.Find(Key, True)
        If ord.Length > 0 Then
            Return ord(0)
        End If
        Return Nothing
    End Function

    Public Function AddNode(ByVal check As CCheck) As TreeNodeEx
        Dim ord As TreeNodeEx = New TreeNodeEx(check)
        AddNodeFromPath(check.Key, ord)
        Return ord
    End Function

    ''' <summary>
    ''' Добавляет объект TreeNodeEx по полному пути соответствующему свойству FullPath 
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <param name="Node"></param>
    ''' <returns></returns>
    ''' <remarks>Если Path равно Nothing то TreeNodeEx не добавляется и соответственно не отображается в данном компоненте</remarks>
    Public Function AddNodeFromPath(ByVal Path As String, ByVal Node As TreeNode) As TreeNode

        Dim aStr As String() = Path.Split(CChar("\"))
        If Path <> Nothing Then
            If aStr.Length <> 0 Then

                Dim ordNodes As TreeNodeCollection = Me.Nodes
                For i As Integer = 0 To aStr.Length - 1
                    Dim ordNode As TreeNode() = ordNodes.Find(aStr(i), False)
                    Select Case ordNode.Length
                        Case 0 'узел не найден добавляем новый
                            Dim ordNodeEx As TreeNodeEx
                            If i = aStr.Length - 1 Then
                                Node.Text = aStr(i)
                                ordNodeEx = CType(Node, TreeNodeEx)
                            Else
                                ordNodeEx = New TreeNodeEx(aStr(i))
                            End If
                            'ordNodes = ordNodes.Add(aStr(i), aStr(i)).Nodes
                            ordNodes.Add(ordNodeEx)
                            ordNodes = ordNodeEx.Nodes
                            ordNodeEx.UpdateChecked()
                        Case 1 'найден один узел
                            ordNodes = ordNode(0).Nodes
                        Case Else
                            ordNodes = ordNode(0).Nodes
                    End Select
                Next

            End If
        End If
        Return Node
    End Function

    Protected Overrides Sub OnNodeMouseClick(ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs)
        MyBase.OnNodeMouseClick(e)
        'если мы производим щелчек по узлу то он может только быть выбранным или сброшеннным
        If e.X > e.Node.Bounds.Left - 16 And e.X < e.Node.Bounds.Left Then
            If TypeOf e.Node Is TreeNodeEx Then
                CType(e.Node, TreeNodeEx).Checked = Not CType(e.Node, TreeNodeEx).Checked
                CType(e.Node, TreeNodeEx).UpdateChecked()
            End If
        End If
    End Sub

    Private mCheckManager As CCheckManager
    ''' <summary>
    ''' Устанавливает или возвращает объект CCheckManager одержащий коллекцию проверок
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CheckManager() As CCheckManager
        Get
            Return mCheckManager
        End Get
        Set(ByVal value As CCheckManager)
            If value IsNot Nothing Then
                Me.Nodes.Clear()
                mCheckManager = value
                Me.mWaiter = mCheckManager.Waiter
                For Each Check As CCheck In mCheckManager
                    Me.AddNode(Check)

                Next
            End If
        End Set
    End Property

    Private WithEvents mWaiter As CWaiter
    Public ReadOnly Property Waiter() As CWaiter
        Get
            Return mWaiter
        End Get
    End Property

    Private Sub Waiter_NewMessage(ByVal _Message As String) Handles mWaiter.NewMessage
        If Me.InvokeRequired = True Then
            Me.Invoke(New CWaiter.DelegatNewMessage(AddressOf pUI_Waiter_NewMessage), New Object() {_Message})
        Else
            pUI_Waiter_NewMessage(_Message)
        End If

    End Sub

    Private Sub pUI_Waiter_NewMessage(ByVal _Message As String)
        RaiseEvent NewMessage(_Message)
    End Sub

    Private Sub Waiter_NewWait(ByVal _Wait As Integer, ByVal _NoCancel As Boolean, ByVal _Message As String) Handles mWaiter.NewWait
        If Me.InvokeRequired = True Then
            Me.Invoke(New CWaiter.DelegatNewWait(AddressOf pUI_Waiter_NewWait), New Object() {_Wait, _NoCancel, _Message})
        Else
            pUI_Waiter_NewWait(_Wait, _NoCancel, _Message)
        End If
    End Sub

    Private Sub pUI_Waiter_NewWait(ByVal _Wait As Integer, ByVal _NoCancel As Boolean, ByVal _Message As String)
        RaiseEvent NewWait(_Wait, _NoCancel, _Message)
    End Sub

    Private Sub Waiter_RefreshWait(ByVal Elapsed As System.TimeSpan, ByVal Duration As System.TimeSpan) Handles mWaiter.RefreshWait
        If Me.InvokeRequired = True Then
            Me.Invoke(New CWaiter.DelegatRefreshWait(AddressOf pUI_Waiter_RefreshWait), New Object() {Elapsed, Duration})
        Else
            pUI_Waiter_RefreshWait(Elapsed, Duration)
        End If
    End Sub

    Private Sub pUI_Waiter_RefreshWait(ByVal Elapsed As System.TimeSpan, ByVal Duration As System.TimeSpan)
        RaiseEvent RefreshWait(Elapsed, Duration)
    End Sub

    Private components As System.ComponentModel.IContainer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TreeViewEx))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Unchecked.ico")
        Me.ImageList1.Images.SetKeyName(1, "Indeterminate.ico")
        Me.ImageList1.Images.SetKeyName(2, "checked.ico")
        Me.ImageList1.Images.SetKeyName(3, "check3.ico")
        '
        'TreeViewEx
        '
        Me.StateImageList = Me.ImageList1
        Me.ResumeLayout(False)

    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        ' Beep()
    End Sub

End Class

Public Class TreeNodeEx
    Inherits TreeNode

    Private mCheckedState As CheckState

    Public Sub New(ByVal Check As CCheck)
        MyBase.New()
        MyBase.Name = Check.Key
        mCheck = Check
        Me.Checked = Check.Enabled
        'Me.UpdateChecked()
    End Sub

    Public Sub New(ByVal text As String)
        MyBase.New(text)
        MyBase.Name = text
        Me.CheckedState = CheckState.Unchecked
    End Sub

    Public Sub New()
        MyBase.New()
        Me.CheckedState = CheckState.Unchecked
    End Sub

    Public Property CheckedState() As CheckState
        Get
            Return mCheckedState
        End Get
        Set(ByVal value As CheckState)
            mCheckedState = value
            Select Case mCheckedState
                Case CheckState.Checked
                    Me.StateImageKey = "checked.ico"
                Case CheckState.Indeterminate
                    Me.StateImageKey = "Indeterminate.ico"
                Case CheckState.Unchecked
                    Me.StateImageKey = "unchecked.ico"
            End Select
        End Set
    End Property

    Public Sub CheckedStateChange()
        Select Case mCheckedState
            Case CheckState.Indeterminate
                CheckedState = CheckState.Checked
            Case CheckState.Checked
                CheckedState = CheckState.Unchecked
            Case CheckState.Unchecked
                CheckedState = CheckState.Indeterminate
        End Select
    End Sub

    Private mChecked As Boolean
    Public Overloads Property Checked() As Boolean
        Get
            Return mChecked
        End Get
        Set(ByVal value As Boolean)
            mChecked = value
            Select Case value
                Case True
                    Me.CheckedState = CheckState.Checked
                Case Else
                    Me.CheckedState = CheckState.Unchecked
            End Select
            If Me.Check IsNot Nothing Then
                Me.Check.Enabled = CBool(IIf(Me.CheckedState = CheckState.Checked, True, False))
            End If
        End Set
    End Property

    Protected Friend Sub SetNodesDoun(ByVal value As Boolean)
        For Each nd As TreeNodeEx In Me.Nodes
            nd.Checked = value
            nd.SetNodesDoun(value)
        Next
    End Sub

    Protected Friend Sub SetNodesUp()
        Dim ordTN As TreeNodeEx = CType(Me.Parent, TreeNodeEx)
        Do While ordTN IsNot Nothing
            ordTN.CheckedState = CheckNodeStatus(ordTN)
            ordTN = CType(ordTN.Parent, TreeNodeEx)
        Loop
    End Sub

    Private Function CheckNodeStatus(ByVal _TreeNode As TreeNodeEx) As CheckState
        Dim ordTN As TreeNodeEx = CType(_TreeNode.FirstNode, TreeNodeEx)
        Dim ret As CheckState = CheckState.Indeterminate

        Do While (ordTN IsNot Nothing)
            Select Case ordTN.CheckedState
                Case CheckState.Unchecked
                    If ret = CheckState.Checked Then
                        ret = CheckState.Indeterminate
                        Exit Do
                    End If
                    ret = CheckState.Unchecked
                Case CheckState.Indeterminate
                    ret = CheckState.Indeterminate
                    Exit Do
                Case CheckState.Checked
                    If ret = CheckState.Unchecked Then
                        ret = CheckState.Indeterminate
                        Exit Do
                    End If
                    ret = CheckState.Checked
            End Select
            ordTN = CType(ordTN.NextNode, TreeNodeEx)
        Loop
        Return ret

    End Function

    Friend Sub UpdateChecked()
        SetNodesDoun(Me.Checked)
        SetNodesUp()
    End Sub

    Private WithEvents mCheck As CCheck
    Public Property Check() As CCheck
        Get
            Return mCheck
        End Get
        Set(ByVal value As CCheck)
            mCheck = value
        End Set
    End Property

    Private Delegate Sub DelegateCheck()

    Private Sub mCheck_EndCheck(ByVal e As CCheck) Handles mCheck.EndCheck
        If Me.TreeView.InvokeRequired = True Then
            Me.TreeView.Invoke(New DelegateCheck(AddressOf pUI_EndCheck))
        End If

    End Sub

    Private Sub mCheck_StartCheck(ByVal e As CCheck) Handles mCheck.StartCheck
        If Me.TreeView.InvokeRequired = True Then
            Me.TreeView.Invoke(New DelegateCheck(AddressOf pUI_StartCheck))
        End If
    End Sub

#Region "UI"

    Private mOldColor As Color
    Private Sub pUI_StartCheck()
        mOldColor = Me.BackColor
        Me.BackColor = Color.Red
    End Sub

    Private Sub pUI_EndCheck()
        Me.BackColor = mOldColor
        Me.Checked = False
    End Sub

#End Region

End Class

<CLSCompliant(True)> _
Public MustInherit Class CCheck ' Проверка
    ''' <summary>
    ''' Происходит перед началом выполнения проверки
    ''' </summary>
    ''' <remarks></remarks>
    Public Event StartCheck(ByVal e As CCheck)
    ''' <summary>
    ''' Происходит после окончания проверки
    ''' </summary>
    ''' <remarks></remarks>
    Public Event EndCheck(ByVal e As CCheck)


    Public Waiter As CWaiter

    Public Enum e_Status
        e_BeforeStart = 0   ' Еще не выполнялось
        e_Execute = 1       ' Выполняется
        e_Aborted = 2       ' Остановлено
        e_Сompleted = 3     ' Закончено
        e_Error = 4         ' При выполнении возникла неустранимая ошибка
    End Enum

    Protected mStatus As e_Status
    Private mErrorMessage As String = String.Empty


    Public Sub New(ByVal argKey As String)
        Me.Key = argKey
    End Sub


    Public ReadOnly Property Status() As e_Status
        Get
            Return mStatus
        End Get
    End Property

    Protected Sub SetError(ByVal _Message As String)
        mStatus = e_Status.e_Error
        mErrorMessage = _Message
    End Sub

    Protected Sub ClearError()
        mStatus = e_Status.e_Execute
        mErrorMessage = String.Empty
    End Sub

    Public ReadOnly Property ErrorMessage() As String
        Get
            If mStatus = e_Status.e_Error Then
                Return mErrorMessage
            Else
                Return String.Empty
            End If
        End Get
    End Property

    Private mEnabled As Boolean
    ''' <summary>
    ''' Определяет будет ли проверка выполняться при автоматическом выполнении
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Enabled() As Boolean
        Get
            Return mEnabled
        End Get
        Set(ByVal Value As Boolean)
            mEnabled = Value
        End Set
    End Property

    Private mKey As String
    Public Property Key() As String
        Get
            Return mKey
        End Get
        Set(ByVal Value As String)
            mKey = Value
        End Set
    End Property

    Protected MustOverride Sub DoWork()

    ''' <summary>
    '''Прерывает выполнение текущей проверки 
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub Abort()
        Select Case mStatus
            Case e_Status.e_Aborted
            Case e_Status.e_BeforeStart
            Case e_Status.e_Execute
                mStatus = e_Status.e_Aborted
            Case e_Status.e_Сompleted
        End Select
    End Sub

    ''' <summary>
    ''' Запускает выполнение текущей проверки
    ''' </summary>
    ''' <remarks></remarks>
    Public Overridable Sub Start()
        RaiseEvent StartCheck(Me)
        Me.ClearError()

        DoWork()
        RaiseEvent EndCheck(Me)
    End Sub


    Private mParent As CCheckManager
    Public Property Parent() As CCheckManager

        Get
            Return mParent
        End Get
        Set(ByVal value As CCheckManager)
            mParent = value
        End Set
    End Property


End Class

<CLSCompliant(True)> _
Public Class CCheckManager
    Inherits List(Of CCheck)

    Implements IDisposable

    Private disposed As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposed Then
            If disposing Then
                ' TODO: free unmanaged resources when explicitly called
            End If

            If (ThreadMenage Is Nothing) = False Then
                Me.AbortAllCheck = True
                ThreadMenage.Join()
                ThreadMenage = Nothing
            End If

            ' TODO: free shared unmanaged resources
        End If
        Me.disposed = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub
#End Region

#Region "Делегаты"
    Private Delegate Sub EndMenageThread()
    Public Delegate Sub DelegatMessage(ByVal _Message As String)
#End Region

#Region "События"
    ''' <summary>
    ''' Происходит когда завершилось автоматическое выполнение проверок 
    ''' </summary>
    ''' <remarks></remarks>
    Public Event AutoCheckCompleted()
    Public Event RefreshWait(ByVal Elapsed As TimeSpan, ByVal Duration As TimeSpan)
    Public Event SetWait(ByVal _Wait As Int32, ByVal _NoCancel As Boolean, ByVal _Message As String)
    Public Event Message(ByVal _Message As String)
#End Region

    Public ThreadMenage As Thread




    Private mCheckEx As CCheck

    Public Property Check() As CCheck
        Get
            Return mCheckEx
        End Get
        Set(ByVal Value As CCheck)
            mCheckEx = Value
        End Set
    End Property

    Public Overloads Sub Add(ByVal item As CCheck)
        item.Waiter = Me.Waiter
        item.Parent = Me
        MyBase.Add(item)
    End Sub

    Public ReadOnly Property GetSatusRunningAutoCheck() As Boolean
        Get
            Return mRunningAutoCheck
        End Get
    End Property

    'если проверки выполняются то mRunningAutoCheck установлен в TRUE 
    Private mRunningAutoCheck As Boolean = False
    'процедура выполняется в потоке пользовательского интерфейса
    ''' <summary>
    ''' Запускает автоматическое выполнение проверок
    ''' </summary>
    ''' <remarks>
    ''' Вызывается из потока пользовательского интерфейса
    ''' </remarks>
    Public Sub StartAutoCheck()
        If mRunningAutoCheck = False Then
            'Запускаем автоматическое выполнение проверок

            If ThreadMenage Is Nothing Then
                ThreadMenage = New Thread(AddressOf MenageThreadStart)

                ThreadMenage.Name = "MenageThread"
                ThreadMenage.Start()
            Else
                Throw New ApplicationException("В этом месте кода не можем оказаться")
            End If
            mRunningAutoCheck = True
        Else
            'Игнорируем запуск
        End If
    End Sub

    'процедура выполняется в потоке проверок
    Private Sub MenageThreadStart()

        'mCheck = mCheck.GetCheckByKey("RIzCold")
        mAbortAllCheck = False

        For i As Int32 = 0 To Me.Count - 1
            If mAbortAllCheck = False Then
                mCheckEx = Me.Item(i)
                If mCheckEx.Enabled = True Then
                    mCheckEx.Start()
                    'в момент выполнения проверки произошла ошибка которая не позволяет
                    'проведение дальнейших испытаний в автоматизированном режиме 
                    'без вмешательства обслуживающего персоонала
                    If mCheckEx.Status = CCheck.e_Status.e_Error Then
                        Exit For
                    End If
                End If
            Else
                Exit For
            End If
        Next

        'проверяем вращаются ли двигатели и если вращаются останавливаем их перед выходом
        ''If mCheckEx.Status = CCheckEx.e_Status.e_Error Then
        ''    Me.SetMessage(mCheckEx.ErrorMessage)
        ''End If

        
        Threading.Thread.Sleep(1000)
        Debug.Print("sleep1000")
        RaiseEvent AutoCheckCompleted()
        mRunningAutoCheck = False
        ThreadMenage = Nothing
    End Sub

    ''' <summary>
    ''' Отменяет автоматическое выполнение проверок
    ''' </summary>
    ''' <remarks>
    ''' Вызывается из потока пользовательского интерфейса
    ''' </remarks>
    Public Sub CancelAutoCheck()
        If (ThreadMenage Is Nothing) = False Then
            ThreadMenage.Join()
            ThreadMenage = Nothing
        End If
        mRunningAutoCheck = False
        RaiseEvent AutoCheckCompleted()
    End Sub

    ''' <summary>
    ''' Прерывает выполнение всех проверок
    ''' </summary>
    ''' <remarks>
    ''' вызывается из потока пользовательского интерфейса
    ''' </remarks>
    Private Shared mAbortAllCheck As Boolean = False
    'процедура выполняется в потоке пользовательского интерфейса
    Public Property AbortAllCheck() As Boolean
        Get
            Return mAbortAllCheck
        End Get
        Set(ByVal Value As Boolean)
            SyncLock Me
                mAbortAllCheck = Value
            End SyncLock

            If Value = True Then
                Check.Abort()
            End If
        End Set
    End Property

    Public WithEvents Waiter As New CWaiter
End Class

''' <summary>
''' Объект управляющий состоянием проверки такими как
''' продолжительность, отображение сообщений, прерывание 
''' </summary>
''' <remarks></remarks>
<CLSCompliant(True)> _
Public Class CWaiter
    Private mWait As TimeSpan
    Private StartTimeWait As DateTime
    Private mIntervalRefresh As Integer = 1000
    'Ссылка на экземпляр потока который находится в режиме ожидания
    Private mWaitingThread As Thread

#Region "Events"
    ''' <summary>
    ''' Обновляет информацию о состоянии ожидания
    ''' </summary>
    ''' <param name="Elapsed">Время прошедшее с начала проверки</param>
    ''' <param name="Duration">Продолжительность проверки </param>
    ''' <remarks>Внимание данное событие может генерируется  не из потока пользовотеьского интерфейса.
    ''' При обработке события необходимо использовать методы Invoke
    ''' </remarks>
    Public Event RefreshWait(ByVal Elapsed As TimeSpan, ByVal Duration As TimeSpan)
    ''' <summary>
    ''' Передает информацию о новом ожидании
    ''' </summary>
    ''' <param name="_Wait">Время ожидания в секундах</param>
    ''' <param name="_NoCancel">Ожидание нельзя отменить до истечения заданного времени</param>
    ''' <param name="_Message">Дополнительное информационное сообщение</param>
    ''' <remarks></remarks>
    Public Event NewWait(ByVal _Wait As Int32, ByVal _NoCancel As Boolean, ByVal _Message As String)
    ''' <summary>
    ''' Устанавливает новое информационное сообщение
    ''' </summary>
    ''' <param name="_Message">информационное сообщение</param>
    ''' <remarks></remarks>
    Public Event NewMessage(ByVal _Message As String)


#End Region
#Region "Делегаты"
    Public Delegate Function DelegatDoWait() As Boolean
    Public Delegate Sub DelegatNewWait(ByVal _Wait As Int32, ByVal _NoCancel As Boolean, ByVal _Message As String)
    Public Delegate Sub DelegatRefreshWait(ByVal Elapsed As TimeSpan, ByVal Duration As TimeSpan)
    Public Delegate Sub DelegatNewMessage(ByVal _Message As String)
#End Region
#Region "Enums"
    Public Enum e_WaitStatus
        e_Wait = 0
        e_WaitCompleted = 1
        e_WaitCanceled = 2
    End Enum

#End Region

    Private mWaitStatus As e_WaitStatus
    Private mNoCancel As Boolean = False

    Public ReadOnly Property CurrentWaitStatus() As e_WaitStatus
        Get
            Return mWaitStatus
        End Get
    End Property

    'Прерывает ожидание или подтверждает выполнение команды оператором
    'функция может вызываться как из потока пользовательского интерфейса
    'например при нажатии кнопки "Готово\Прервать ожидание"
    'так и из потока выполнения проверок когда выполнились условия выхода
    'например двигатели вышли в заданный режим
    'если флаг mNoCancel = true то прервать ожидание из потока 
    'пользовательского интерфейса нельзя
    Public Sub AbortWaiting()
        If (Thread.CurrentThread Is mWaitingThread) = True Then
            mWaitStatus = e_WaitStatus.e_WaitCanceled
        Else
            If mNoCancel = False Then
                mWaitStatus = e_WaitStatus.e_WaitCanceled

            Else
                Beep()
            End If
        End If
    End Sub

    '_Wait - Время ожидания в секундах
    '_NoCancel - Если True то ожидание нельзя прервать нажатием кнопки
    'вызывается из потока выполнения проверок
    Public Function Wait(ByVal _Wait As Int32, Optional ByVal _NoCancel As Boolean = False, Optional ByVal _Message As String = "", Optional ByVal DoWait As DelegatDoWait = Nothing) As e_WaitStatus
        Dim CurrentTickWait As TimeSpan
        mWaitingThread = Thread.CurrentThread

        SyncLock Me
            SetNewWait(_Wait, _NoCancel, _Message)
        End SyncLock

        Do While (mWaitStatus = e_WaitStatus.e_Wait)
            'вычисляем время прошедшее с начала ожидания
            CurrentTickWait = Now - StartTimeWait
            If CurrentTickWait < mWait Then
                'если время прошедшее с начала ожидания меньше времени ожидания
                'то продолжаем ожидание
                If DoWait Is Nothing Then
                    'если функция которую необходимо выполнять во время ожидания не задана
                    'то останавливаем поток на время равное интервалу обновления информации о времени ожидания
                    Thread.Sleep(mIntervalRefresh)
                Else
                    'Выполняем функцию которую необходимо выполнять во время ожидания 
                    If DoWait() = False Then
                        mWaitStatus = e_WaitStatus.e_WaitCanceled
                        Exit Do
                    End If
                    Thread.Sleep(10)
                End If
                RaiseEvent RefreshWait(CurrentTickWait, mWait)
            Else
                mWaitStatus = e_WaitStatus.e_WaitCompleted
                Exit Do
            End If
        Loop

        RaiseEvent RefreshWait(mWait, mWait)
        mWaitingThread = Nothing
        Return mWaitStatus
    End Function


    ''' <summary>
    ''' Устанавливает новые параметры ожидания вызывается из потока выполнения проверок
    ''' </summary>
    ''' <param name="_Wait"></param>
    ''' <param name="_NoCancel"></param>
    ''' <param name="_Message"></param>
    ''' <remarks></remarks>
    Public Sub SetNewWait(ByVal _Wait As Int32, Optional ByVal _NoCancel As Boolean = False, Optional ByVal _Message As String = "")
        RaiseEvent NewWait(_Wait, _NoCancel, _Message)
        mNoCancel = _NoCancel
        mWait = TimeSpan.FromSeconds(_Wait)
        mWaitStatus = e_WaitStatus.e_Wait
        StartTimeWait = Now
    End Sub

    ''' <summary>
    ''' Устанавливае новое сообщение
    ''' </summary>
    ''' <param name="_Message"></param>
    ''' <remarks></remarks>
    Public Sub SetNewMessage(ByVal _Message As String)
        RaiseEvent NewMessage(_Message)
    End Sub


End Class
