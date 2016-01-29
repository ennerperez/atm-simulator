Public Class CurrencyBox

#Region "Properties"

    Private _Total As Double = 0.0
    Public ReadOnly Property Total As Double
        Get
            Return _Total
        End Get
    End Property

    Private _Value As Double
    Public Property Value As Double
        Get
            Return _Value
        End Get
        Set(value As Double)
            If _Value <> value Then
                _Value = value
                OnValueChanged(EventArgs.Empty)
            End If
        End Set
    End Property
    Private _Amount As Integer
    Public Property Amount As Integer
        Get
            Return _Amount
        End Get
        Set(value As Integer)
            If _Amount <> value Then
                _Amount = value
                OnAmountChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    Private _Minimum As Integer = 0
    Public Property Minimum As Integer
        Get
            Return _Minimum
        End Get
        Set(value As Integer)
            If _Minimum <> value Then
                _Minimum = value
                OnMinimumChanged(EventArgs.Empty)
            End If
        End Set
    End Property
    Private _Maximum As Integer = 100
    Public Property Maximum As Integer
        Get
            Return _Maximum
        End Get
        Set(value As Integer)
            If _Maximum <> value Then
                _Maximum = value
                OnMaximumChanged(EventArgs.Empty)
            End If
        End Set
    End Property

#End Region

    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Me.ComboBoxDenomination.DataBindings.Add("SelectedItem", Me, "Value", False, DataSourceUpdateMode.OnPropertyChanged, Nothing, "{0}")
        'Me.AmountControl.DataBindings.Add("Value", Me, "Amount", False, DataSourceUpdateMode.OnPropertyChanged)

    End Sub

#Region "Events"

    Private Sub OnMinimumChanged(e As EventArgs)
        Me.AmountControl.Minimum = Me.Minimum
    End Sub

    Private Sub OnMaximumChanged(e As EventArgs)
        Me.AmountControl.Maximum = Me.Maximum
    End Sub

    Private Sub OnAmountChanged(e As EventArgs)
        Me.AmountControl.Value = Me.Amount
        CalcTotal()
    End Sub

    Private Sub OnValueChanged(e As EventArgs)
        Me.ComboBoxDenomination.SelectedItem = Me.Value.ToString()
        CalcTotal()
    End Sub

    Private Sub CalcTotal()
        Dim _result As Double = 0.0
        If Not String.IsNullOrEmpty(Me.ComboBoxDenomination.SelectedItem) Then
            _result = CDbl(Me.ComboBoxDenomination.SelectedItem) * Me.AmountControl.Value
        End If

        If _result <> Me._Total Then
            Me._Total = _result
            RaiseEvent ValueChanged(Me, EventArgs.Empty)
        End If

    End Sub

    Public Event ValueChanged As EventHandler

#End Region

    Private Sub SubTotal()
        Me.TextBoxTotal.Text = String.Format("{0:C}", Me.Total)
        Dim _percent As Double = Me.Percent

        If _percent = 0 Then
            Me.BackColor = SystemColors.Control
        ElseIf _percent > 0 AndAlso _percent < 25 Then
            Me.BackColor = Color.FromArgb(245, 68, 55)
        ElseIf _percent >= 25 AndAlso _percent < 50
            Me.BackColor = Color.FromArgb(255, 153, 0)
        Else
            Me.BackColor = Color.FromArgb(77, 176, 81)
        End If
    End Sub

    Public Function Percent() As Double
        Return Me.AmountControl.Percent()
    End Function

    Private Sub AmountControl_ValueChanged(sender As Object, e As EventArgs) Handles AmountControl.ValueChanged
        Me.Amount = Me.AmountControl.Value
        SubTotal()
    End Sub

    Private Sub ComboBoxDenomination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDenomination.SelectedIndexChanged
        Me.Value = CDbl(Me.ComboBoxDenomination.SelectedItem)
        SubTotal()
    End Sub


End Class
