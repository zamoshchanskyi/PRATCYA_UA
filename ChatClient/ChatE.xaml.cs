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

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для Chat.xaml
    /// </summary>
    public partial class Chat : Window, ISChatCallback
    {
        bool isConnected = false;
        int ID;
        SChatClient client;

        //MainWindow mainWindow = new MainWindow();
        //DiscConn disccon = new DiscConn();

        public Chat()
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
                ID = client.Connect(tbUserNameChat.Text);
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

        private void bt_SearchVacancies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_DialoguesWorker_Click(object sender, RoutedEventArgs e)
        {
            Dialogues dialogues = new Dialogues();
            dialogues.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialogues.Show();
            dialogues.bt_DialoguesWorker.IsEnabled = false;
            dialogues.tb_UserNameChatWorker.IsEnabled = false;
            dialogues.lb_NameSurname.Content = tbUserNameChat.Text.ToString();
            dialogues.lb_Login.Content = lb_Login.Content;

            var CurrentWorker = AppData.db.vacancy.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentWorker != null)
            {
                dialogues.tb_UserNameChatWorker.Text = CurrentWorker.Login_Vidgyk;
            }

            Close();
        }

        private void bt_MyVacancy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt_CreateVacancy_Click(object sender, RoutedEventArgs e)
        {
            CreateVacancy createVacancy = new CreateVacancy();
            createVacancy.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            createVacancy.Show();
            createVacancy.bt_CreateVacancy.IsEnabled = false;
            createVacancy.lb_Login.Content = lb_Login.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {
                createVacancy.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
            }

            Close();
        }

        private void bt_PersonalEmployer_Click(object sender, RoutedEventArgs e)
        {
            Employer employer = new Employer();
            employer.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            employer.Show();
            employer.bt_PersonalEmployer.IsEnabled = false;

            employer.lb_Login.Content = lb_Login.Content;

            var CurrentUser = AppData.db.personalWorker.FirstOrDefault(u => u.Login == lb_Login.Content.ToString());
            if (CurrentUser != null)
            {
                employer.tb_NameEmployer.Text = CurrentUser.Name;
                employer.tb_SurnameEmployer.Text = CurrentUser.Surname;
                employer.tb_PatronymicEmployer.Text = CurrentUser.Patronymic;
                employer.tb_DataOfBirthEmployer.Text = CurrentUser.DataOfBirthWorker;
                employer.tb_Company.Text = CurrentUser.Company;
                employer.lb_Company.Content = CurrentUser.Company.ToString();
                employer.lb_NameSurname.Content = CurrentUser.Name.ToString() + " " + CurrentUser.Surname.ToString();
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
}

