using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ChatClient.DataBase;
using ChatClient.ServiceChat;
using Newtonsoft.Json;

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для ChatW.xaml
    /// </summary>
    public partial class ChatW : Window, ISChatCallback
    {
        bool isConnected = false;
        int ID;
        SChatClient client;

        public ChatW()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        public void ConnectUser()
        {
            if (!isConnected)
            {
                client = new SChatClient(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(lb_LoginW.Content.ToString());
                bConnDisc.Content = "Disconnect";
                isConnected = true;
            }
        }

        public void DisconectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                bConnDisc.Content = "Connect";
                isConnected = false;
            }
        }

        public void MsgCallBack(string msg)
        {
            lbChat.Items.Add(msg);
            lbChat.ScrollIntoView(lbChat.Items[lbChat.Items.Count - 1]);

            Console.WriteLine("зашел");
            var listmsg = new ListMSG();

            listmsg.list.Add(msg);
            var listjson = JsonConvert.SerializeObject(listmsg, Formatting.Indented);

            File.WriteAllText("C:/Users/maksy/OneDrive/Рабочий стол/student3.0/ІПЗ/program/json.txt", listjson);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DisconectUser();
        }

        private void tbMsg_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                if (client != null)
                {
                    client.SendMsg(tbMsg.Text, ID);
                    tbMsg.Text = string.Empty;
                }
            }
        }

        private void bConnDisc_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                DisconectUser();
            }
            else
            {
                ConnectUser();
            }
        }

        private void bt_PersonalWorker_Click(object sender, RoutedEventArgs e)
        {
            Worker worker = new Worker();
            worker.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            worker.Show();
            worker.bt_PersonalWorker.IsEnabled = false;

            worker.lb_LoginW.Content = lb_LoginW.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_LoginW.Content.ToString());
            if (CurrentUser != null)
            {
                worker.lb_ActivityWorker.Content = CurrentUser.ActivityWorker;
                worker.tb_NameWorker.Text = CurrentUser.Name;
                worker.tb_SurnameWorker.Text = CurrentUser.Surname;
                worker.tb_PatronymicWorker.Text = CurrentUser.Patronymic;
                worker.tb_EducationWorker.Text = CurrentUser.EducationWorker;
                worker.tb_DataOfBirthWorker.Text = CurrentUser.DataOfBirthWorker;
                worker.tb_ActivityWorker.Text = CurrentUser.ActivityWorker;
                worker.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void bt_SearchVacancies_Click(object sender, RoutedEventArgs e)
        {
            ListVacancy listVacancy = new ListVacancy();

            listVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            listVacancy.Show();
            listVacancy.bt_SearchVacancies.IsEnabled = false;

            listVacancy.lb_LoginW.Content = lb_LoginW.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_LoginW.Content.ToString());
            if (CurrentUser != null)
            {
                listVacancy.lb_NameSurname.Content = CurrentUser.Login.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void bt_DialoguesWorker_Click(object sender, RoutedEventArgs e)
        {
            DialoguesW dialoguesw = new DialoguesW();
            dialoguesw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialoguesw.Show();
            dialoguesw.bt_DialoguesWorker.IsEnabled = false;
            dialoguesw.lb_Login.Content = lb_LoginW.Content;
            dialoguesw.tb_UserNameChatWorker.IsEnabled = false;

            var CurrentWorker = AppData.db.vacancy.FirstOrDefault(u => u.Login_Vidgyk == lb_LoginW.Content.ToString());
            if (CurrentWorker != null)
            {
                dialoguesw.tb_UserNameChatWorker.Text = CurrentWorker.Login;
            }

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_LoginW.Content.ToString());
            if (CurrentUser != null)
            {
                dialoguesw.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void bt_MainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();

            mainWindow.tbLoginMW.Text = "";
            mainWindow.tbPassMW.Password = "";

            Close();
        }
    }
    class ListMSG
    {
        public List<string> list = new List<string>();
    }
}
