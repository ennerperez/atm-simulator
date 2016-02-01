
Public Class Screen

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.MultiPanelScreen.SelectedPage = Nothing

    End Sub

    Private _Action As ScreenAction
    Public ReadOnly Property Action() As ScreenAction
        Get
            Return _Action
        End Get
    End Property

    Private Sub RefreshActions(Optional action As ScreenAction = Nothing)

        If action IsNot Nothing Then
            LabelMenuAction1.Text = action.Actions(0)
            LabelMenuAction2.Text = action.Actions(1)
            LabelMenuAction3.Text = action.Actions(2)
            LabelMenuAction4.Text = action.Actions(3)
            LabelMenuAction5.Text = action.Actions(4)
            LabelMenuAction6.Text = action.Actions(5)
            LabelMenuAction7.Text = action.Actions(6)
            LabelMenuAction8.Text = action.Actions(7)
        Else
            LabelMenuAction1.Text = String.Empty
            LabelMenuAction2.Text = String.Empty
            LabelMenuAction3.Text = String.Empty
            LabelMenuAction4.Text = String.Empty
            LabelMenuAction5.Text = String.Empty
            LabelMenuAction6.Text = String.Empty
            LabelMenuAction7.Text = String.Empty
            LabelMenuAction8.Text = String.Empty
        End If

        ButtonAction1.Enabled = Not String.IsNullOrEmpty(LabelMenuAction1.Text)
        ButtonAction2.Enabled = Not String.IsNullOrEmpty(LabelMenuAction2.Text)
        ButtonAction3.Enabled = Not String.IsNullOrEmpty(LabelMenuAction3.Text)
        ButtonAction4.Enabled = Not String.IsNullOrEmpty(LabelMenuAction4.Text)
        ButtonAction5.Enabled = Not String.IsNullOrEmpty(LabelMenuAction5.Text)
        ButtonAction6.Enabled = Not String.IsNullOrEmpty(LabelMenuAction6.Text)
        ButtonAction7.Enabled = Not String.IsNullOrEmpty(LabelMenuAction7.Text)
        ButtonAction8.Enabled = Not String.IsNullOrEmpty(LabelMenuAction8.Text)

        LabelMenuAction1.Visible = ButtonAction1.Enabled
        LabelMenuAction2.Visible = ButtonAction2.Enabled
        LabelMenuAction3.Visible = ButtonAction3.Enabled
        LabelMenuAction4.Visible = ButtonAction4.Enabled
        LabelMenuAction5.Visible = ButtonAction5.Enabled
        LabelMenuAction6.Visible = ButtonAction6.Enabled
        LabelMenuAction7.Visible = ButtonAction7.Enabled
        LabelMenuAction8.Visible = ButtonAction8.Enabled

        LabelMenuAction1.Parent = MultiPanelScreen.SelectedPage
        LabelMenuAction2.Parent = MultiPanelScreen.SelectedPage
        LabelMenuAction3.Parent = MultiPanelScreen.SelectedPage
        LabelMenuAction4.Parent = MultiPanelScreen.SelectedPage
        LabelMenuAction5.Parent = MultiPanelScreen.SelectedPage
        LabelMenuAction6.Parent = MultiPanelScreen.SelectedPage
        LabelMenuAction7.Parent = MultiPanelScreen.SelectedPage
        LabelMenuAction8.Parent = MultiPanelScreen.SelectedPage



    End Sub

    Public Sub AppendScreenText(text As String)
        Select Case Action.ScreenType
            Case ScreenType.Request
                LabelRequestText.Text = Action.Text
                LabelRequestText.Text &= vbCrLf & text
            Case ScreenType.Response
                LabelResponseText.Text = Action.Text
                LabelResponseText.Text &= vbCrLf & text
            Case ScreenType.Welcome
                LabelWelcome.Text = Action.Text
                LabelWelcome.Text &= vbCrLf & text
        End Select
    End Sub


    Public Sub SetScreenAction(action As ScreenAction)
        Me._Action = action

        RefreshActions()

        Select Case action.ScreenType
            Case ScreenType.Loading
                MultiPanelScreen.SelectedPage = PageLoading
            Case ScreenType.Menu
                LabelInfo.Text = action.Text
                MultiPanelScreen.SelectedPage = PageMenu
            Case ScreenType.Request
                LabelRequestText.Text = action.Text
                MultiPanelScreen.SelectedPage = PageRequest
            Case ScreenType.Response
                LabelResponseText.Text = action.Text
                MultiPanelScreen.SelectedPage = PageResponse
            Case ScreenType.Welcome
                LabelWelcome.Text = action.Text
                MultiPanelScreen.SelectedPage = PageWelcome
            Case Else
                MultiPanelScreen.SelectedPage = Nothing
        End Select

        RefreshActions(action)

        If action.Color <> Color.Transparent Then MultiPanelScreen.SelectedPage.BackColor = action.Color

        MultiPanelScreen.BackColor = MultiPanelScreen.SelectedPage.BackColor

    End Sub

    Private _ActionPressed As Integer
    Public ReadOnly Property ActionPressed As Integer
        Get
            Return _ActionPressed
        End Get
    End Property

    Public Event Pressed As EventHandler

    Private Sub ButtonAction_Click(sender As Object, e As EventArgs) Handles _
            ButtonAction4.Click, ButtonAction3.Click, ButtonAction2.Click, ButtonAction1.Click,
            ButtonAction8.Click, ButtonAction7.Click, ButtonAction6.Click, ButtonAction5.Click
        _ActionPressed = CInt(sender.Tag)
        RaiseEvent Pressed(Me, EventArgs.Empty)
    End Sub

End Class

Public Enum ScreenType
    None
    Loading
    Welcome
    Menu
    Request
    Response
End Enum

Public Class ScreenAction

    Private _ScreenType As ScreenType
    Public ReadOnly Property ScreenType As ScreenType
        Get
            Return _ScreenType
        End Get
    End Property

    Sub New(screenType As ScreenType)
        Me._ScreenType = screenType
        Me.Actions = New List(Of String)(8) From {"", "", "", "", "", "", "", ""}
    End Sub

    Public Property Color() As Color

    Public Property Name() As String

    Public Property Text() As String

    Public Property Actions As IEnumerable(Of String)


End Class