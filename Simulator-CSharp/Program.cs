using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ATM
{

    static partial class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            NativeMethods.AllocConsole();
            Application.Run(Controllers.ATM.Instance.View);
            NativeMethods.FreeConsole();
        }
    }

    static partial class Program
    {

        public static string DataPath
        {
            get
            {
                return System.IO.Path.Combine(new System.IO.DirectoryInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName, "Data");
            }
            private set { }
        }

        public static string ATM_DataFile
        {
            get { return System.IO.Path.Combine(DataPath, "ATM.json"); }
        }

        public static string Clients_DataFile
        {
            get { return System.IO.Path.Combine(DataPath, "Clients.json"); }
        }

        public static Models.ATM Definition { get; set; }
        public static List<Models.Client> Clients { get; set; }

        #region Loaders

        private static void LoadDefinition()
        {
            //ATM
            Definition = new Models.ATM();

            {
                if (!System.IO.File.Exists(ATM_DataFile))
                {
                    Definition.Code = "VATM001";
                    Definition.Bank = "General";
                    Definition.Boxes = new List<Models.Box>();
                    Definition.Boxes.Add(new Models.Box(100, 100));
                    Definition.Boxes.Add(new Models.Box(50, 75));
                    Definition.Boxes.Add(new Models.Box(20, 50));
                    Definition.Boxes.Add(new Models.Box(10, 25));
                    Definition.Receipts = 50;
                    SaveDefinition();
                }

            }

            Definition = JsonConvert.DeserializeObject<Models.ATM>(System.IO.File.ReadAllText(ATM_DataFile));

        }

        private static void LoadClients()
        {
            Clients = new List<Models.Client>();

            if (!System.IO.File.Exists(Clients_DataFile))
            {
                PopulateClients();
            }


            Clients = JsonConvert.DeserializeObject<List<Models.Client>>(System.IO.File.ReadAllText(Clients_DataFile));

        }

        private static void PopulateClients()
        {
            {
                Models.Client _client1 = new Models.Client();
                _client1.Name = "Juan Fernandez";
                _client1.Identification = "14523697";

                Models.Account _acount11 = new Models.Account();
                _acount11.Bank = "General";
                _acount11.Balance = 50000;
                _acount11.Type = "Corriente";
                _acount11.Number = "12345678901234567890";


                Models.Account _acount12 = new Models.Account();
                _acount12.Bank = "General";
                _acount12.Balance = 150000;
                _acount12.Type = "Ahorro";
                _acount12.Number = "09876543210987654321";

                _client1.Accounts.Add(_acount11);
                _client1.Accounts.Add(_acount12);

                Models.Card _card11 = new Models.Card();
                _card11.Bank = "General";
                _card11.Number = "0001 0001 0001 0001";
                _card11.Exp = DateTime.Now.AddMonths(6);
                _card11.Password = "1234";
                _card11.Account1 = _acount11.Number;
                _card11.Account2 = _acount12.Number;

                _client1.Cards.Add(_card11);

                Clients.Add(_client1);

                Models.Client _client2 = new Models.Client();
                _client2.Name = "Maria Torres";
                _client2.Identification = "15987532";

                Models.Account _acount21 = new Models.Account();
                _acount21.Bank = "General";
                _acount21.Balance = 17456.54;
                _acount21.Type = "Ahorro";
                _acount21.Number = "00077744499966633311";

                _client2.Accounts.Add(_acount21);

                Models.Card _card21 = new Models.Card();
                _card21.Bank = "General";
                _card21.Number = "9008 9008 9002 9002";
                _card21.Exp = DateTime.Now.AddMonths(3);
                _card21.Password = "1234";
                _card21.Account1 = _acount21.Number;

                _client2.Cards.Add(_card21);

                Clients.Add(_client2);

                SaveClients();
            }
        }

        #endregion
        
        public static void SaveDefinition()
        {
            try
            {
                object _data = JsonConvert.SerializeObject(Program.Definition);
                if (!System.IO.Directory.Exists(DataPath))
                    System.IO.Directory.CreateDirectory(DataPath);
                System.IO.File.WriteAllText(ATM_DataFile, _data.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void SaveClients()
        {
            try
            {
                var _data = JsonConvert.SerializeObject(Program.Clients);
                if (!System.IO.Directory.Exists(DataPath))
                    System.IO.Directory.CreateDirectory(DataPath);
                System.IO.File.WriteAllText(Clients_DataFile, _data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Load()
        {
            LoadDefinition();
            LoadClients();
            
            //FormATM.Restart();
            //FormConfig.Height = FormATM.Height;
            //FormConfig.Show();
            //FormConfig.Location = new Point(FormATM.Location.X - FormConfig.Width - 3, FormATM.Location.Y);

        }

    }
}
