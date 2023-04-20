using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using Microsoft.Win32;
using RoomLibrary;

namespace RoomLiving
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            List<Room> lstRoom = new List<Room>();
            public MainWindow()
        {
            InitializeComponent();
        }
            private void BAddRoom_Click_1(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth= Convert.ToDouble(TBWidthR.Text);
            lstRoom.Add(room);
        }

        private void BAddLivingRoom_Click_1(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom= new LivingRoom();
            livingRoom.RoomLength= Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth= Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumWin= Convert.ToInt32(TBNumW.Text);
            lstRoom.Add(livingRoom);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthO.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
            lstRoom.Add(office);
        }

        private void BGetList_Click_1(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            foreach (Room r in lstRoom)
                    ListRooms.Content += r.Info() + "\n";
        }

    }
}
