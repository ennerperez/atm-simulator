Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Xml.XPath
Imports ATM.Models
Imports Newtonsoft.Json

Namespace My

    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As ApplicationServices.StartupEventArgs) Handles Me.Startup
            NativeMethods.AllocConsole()
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            NativeMethods.FreeConsole()
        End Sub

    End Class

End Namespace

Public Module Program

    Public ReadOnly Property DataPath As String
        Get
            Return IO.Path.Combine(My.Application.Info.DirectoryPath, "Data")
        End Get
    End Property

    Public ReadOnly Property ATM_DataFile As String
        Get
            Return IO.Path.Combine(DataPath, "ATM.json")
        End Get
    End Property

    Public ReadOnly Property Clients_DataFile As String
        Get
            Return IO.Path.Combine(DataPath, "Clients.json")
        End Get
    End Property

    Public Property Definition As Models.ATM
    Public Property Clients As List(Of Models.Client)

#Region "Loaders"

    Private Sub LoadDefinition()

        'ATM
        Definition = New Models.ATM
        With Definition

            If Not IO.File.Exists(ATM_DataFile) Then
                .Code = "VATM001"
                .Bank = "General"
                .Boxes = New List(Of Models.Box)
                .Boxes.Add(New Models.Box(100, 100))
                .Boxes.Add(New Models.Box(50, 75))
                .Boxes.Add(New Models.Box(20, 50))
                .Boxes.Add(New Models.Box(10, 25))
                .Receipts = 50
                SaveDefinition()
            End If

        End With

        Definition = JsonConvert.DeserializeObject(Of Models.ATM)(IO.File.ReadAllText(ATM_DataFile))

    End Sub

    Private Sub LoadClients()

        Clients = New List(Of Models.Client)

        If Not IO.File.Exists(Clients_DataFile) Then
            PopulateClients()
        End If


        Clients = JsonConvert.DeserializeObject(Of List(Of Models.Client))(IO.File.ReadAllText(Clients_DataFile))

    End Sub

    Private Sub PopulateClients()
        With Clients
            Dim _client1 As New Models.Client
            _client1.Name = "Juan Fernandez"
            _client1.Identification = "14523697"

            Dim _acount11 As New Models.Account
            _acount11.Bank = "General"
            _acount11.Balance = 50000
            _acount11.Type = "Corriente"
            _acount11.Number = "12345678901234567890"


            Dim _acount12 As New Models.Account
            _acount12.Bank = "General"
            _acount12.Balance = 150000
            _acount12.Type = "Ahorro"
            _acount12.Number = "09876543210987654321"

            _client1.Accounts.Add(_acount11)
            _client1.Accounts.Add(_acount12)

            Dim _card11 As New Models.Card
            _card11.Bank = "General"
            _card11.Number = "0001 0001 0001 0001"
            _card11.Exp = Now.AddMonths(6)
            _card11.Password = "1234"
            _card11.Hash = _card11.Password.GetHashCode
            _card11.Account1 = _acount11.Number
            _card11.Account2 = _acount12.Number

            _client1.Cards.Add(_card11)

            .Add(_client1)

            Dim _client2 As New Models.Client
            _client2.Name = "Maria Torres"
            _client2.Identification = "15987532"

            Dim _acount21 As New Models.Account
            _acount21.Bank = "General"
            _acount21.Balance = 17456.54
            _acount21.Type = "Ahorro"
            _acount21.Number = "00077744499966633311"

            _client2.Accounts.Add(_acount21)

            Dim _card21 As New Models.Card
            _card21.Bank = "General"
            _card21.Number = "9008 9008 9002 9002"
            _card21.Exp = Now.AddMonths(3)
            _card21.Password = "1234"
            _card21.Hash = _card21.Password.GetHashCode
            _card21.Account1 = _acount21.Number

            _client2.Cards.Add(_card21)

            .Add(_client2)

            SaveClients()
        End With
    End Sub

#End Region

    Public Sub SaveDefinition()
        Try
            Dim _data = JsonConvert.SerializeObject(Program.Definition)
            If Not IO.Directory.Exists(DataPath) Then IO.Directory.CreateDirectory(DataPath)
            IO.File.WriteAllText(ATM_DataFile, _data)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub SaveClients()
        Try
            Dim _data = JsonConvert.SerializeObject(Program.Clients)
            If Not IO.Directory.Exists(DataPath) Then IO.Directory.CreateDirectory(DataPath)
            IO.File.WriteAllText(Clients_DataFile, _data)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Load()

        LoadDefinition()
        LoadClients()

        FormATM.Restart()
        FormConfig.Height = FormATM.Height
        FormConfig.Show()
        FormConfig.Location = New Point(FormATM.Location.X - FormConfig.Width - 3, FormATM.Location.Y)

    End Sub

#Region "Controllers"

    Public Function ValidateCard(number As String, passHash As String) As Boolean
        Dim card = GetCard(number, passHash)
        Return card IsNot Nothing
    End Function

    Public Function GetCard(number As String, passHash As String) As Models.Card

        Dim card = Clients.Select(Function(cl)
                                      Return cl.Cards.Where(Function(cd) cd.Number = number AndAlso cd.Hash = passHash).FirstOrDefault()
                                  End Function).FirstOrDefault
        Return card
    End Function

    Friend Function GetAccount(card As Models.Card, v As Integer) As Models.Account
        'Dim number = IIf(v = 0, card.Account1, card.Account2)

        Dim client = (From item In Clients
                      Where item.Cards.Contains(card)).FirstOrDefault

        Dim account = client.Accounts.ElementAt(v)

        Return account

    End Function


#End Region

End Module
