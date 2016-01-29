using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATM.Controllers
{

    public class ATM
    {

        private string dataPath;
        private string file;

        #region Singleton

        private static ATM instance;

        private ATM()
        {

            dataPath = System.IO.Path.Combine(new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName, "Data");
            file = System.IO.Path.Combine(dataPath, "ATM.json");

            Model = new Models.ATM();
            View = new Views.FormATM();
            Config = new Views.FormConfig();

            View.Shown += View_Shown;

            View.FormClosing += View_Closing;
            Config.FormClosing += Config_FormClosing;

            Load();

        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !IsShuttingDown;
        }

        private void View_Closing(object sender, FormClosingEventArgs e)
        {
            if (!IsShuttingDown)
            {
                e.Cancel = true;
                Shutdown();
            }
        }
        private void View_Shown(object sender, EventArgs e)
        {

            Config.Height = View.Height;
            Config.Show();
            Config.Location = new Point(View.Location.X - Config.Width - 3, View.Location.Y);

            Start();
        }

        public static ATM Instance
        {
            get
            {
                if (instance == null)
                    instance = new ATM();
                return instance;
            }
        }

        #endregion

        public Models.ATM Model { get; set; }
        public Views.FormATM View { get; set; }
        public Views.FormConfig Config { get; set; }

        #region Timers

        public Stopwatch Alive = new Stopwatch();
        public Stopwatch StandBy = new Stopwatch();

        #endregion

        public bool IsShuttingDown { get; set; }
        public void Shutdown(bool restart = false)
        {
            Console.WriteLine("Apagando ATM");
            IsShuttingDown = true;
            View.Enabled = !IsShuttingDown;
            Alive.Stop();
            StandBy.Start();

            if (!restart)
            {
                var _shutdownTimer = new System.Timers.Timer(3000);
                _shutdownTimer.Elapsed += _shutdownTimer_Elapsed;
                _shutdownTimer.Start();
            }

        }

        private void _shutdownTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            (sender as System.Timers.Timer).Stop();
            Save();
            Application.Exit();
        }

        public void Start(bool restart = false)
        {
            Console.WriteLine("Iniciando ATM");
            IsShuttingDown = false;
            Alive.Start();
            StandBy.Stop();

            if (!restart)
            {
                var _startTimer = new System.Timers.Timer(3000);
                _startTimer.Elapsed += _startTimer_Elapsed;
                _startTimer.Start();
            }

        }

        private void _startTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            (sender as System.Timers.Timer).Stop();
            View.Invoke(new Action(() => { View.Enabled = !IsShuttingDown; }));
        }

        public void Restart()
        {
            Shutdown(true);
            Start(true);
        }

        public void Load()
        {
            if (!System.IO.File.Exists(file))
            {
                Model.Code = "VATM001";
                Model.Bank = "General";
                Model.Boxes = new List<Models.Box>();
                Model.Boxes.Add(new Models.Box(100, 100));
                Model.Boxes.Add(new Models.Box(50, 75));
                Model.Boxes.Add(new Models.Box(20, 50));
                Model.Boxes.Add(new Models.Box(10, 25));
                Model.Receipts = 50;
                Save();
            }

            Model = JsonConvert.DeserializeObject<Models.ATM>(System.IO.File.ReadAllText(file));

        }

        public void Save()
        {
            try
            {

                Model.Alive = Model.Alive + Alive.Elapsed;
                Model.StandBy = Model.StandBy + StandBy.Elapsed;

                var _data = JsonConvert.SerializeObject(Model);
                if (!System.IO.Directory.Exists(dataPath))
                    System.IO.Directory.CreateDirectory(dataPath);
                System.IO.File.WriteAllText(file, _data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }



}
