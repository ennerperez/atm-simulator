Public Class Card

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Sub New(card As Models.Card)
        Me.New()

        Me.Bank = card.Bank
        Me.Number = card.Number
        Me.Exp = card.Exp

    End Sub

#Region "Properties"

    Private _Bank As String = My.Application.Info.ProductName
    Public Property Bank() As String
        Get
            Return _Bank
        End Get
        Set(ByVal value As String)
            _Bank = value
        End Set
    End Property

    Private _Number As String = "0000 0000 0000 0000"
    Public Property Number() As String
        Get
            Return _Number
        End Get
        Set(ByVal value As String)
            _Number = value
        End Set
    End Property

    Private _Exp As Date = Now.Date
    Public Property Exp() As Date
        Get
            Return _Exp
        End Get
        Set(ByVal value As Date)
            _Exp = value
        End Set
    End Property

    Private _Cirrus As Boolean = True
    Public Property Cirrus() As Boolean
        Get
            Return _Cirrus
        End Get
        Set(ByVal value As Boolean)
            _Cirrus = value
        End Set
    End Property

    Private _Maestro As Boolean = True
    Public Property Maestro() As Boolean
        Get
            Return _Maestro
        End Get
        Set(ByVal value As Boolean)
            _Maestro = value
        End Set
    End Property

#End Region

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Me.LabelBank.Text = Me.Bank
        Me.LabelNumber.Text = Me.Number
        Me.LabelExp.Text = Me.Exp.ToString("MM/yy")
        Me.PictureBoxCirrus.Visible = Me.Cirrus
        Me.PictureBoxMaestro.Visible = Me.Maestro
    End Sub

    Private Sub Card_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, PictureBoxMaestro.MouseDown, PictureBoxCirrus.MouseDown, PictureBoxChip.MouseDown, LabelNumber.MouseDown, LabelExp.MouseDown, LabelBank.MouseDown
        Me.DoDragDrop(Me.Number, DragDropEffects.Copy)
    End Sub

End Class
