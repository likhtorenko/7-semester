using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class AppendClients : Form
    {
        public int k = -1;
        SqlConnection con = new SqlConnection("Data Source=10.10.14.40;Initial Catalog=Demo7;User ID=Demo7;Password=Abcd1234");
        public AppendClients()//инициализация всех компонентов в форме
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)//сохраняем нового клиента или изменения старого
        {
            if (k == -1) { 
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert Demo7.dbo.Clients (Famili, Name, FatherName, Pol, Phone, Image, Birthday, Email, RegistrDay) values ('" + Famili.Text + "','" + NameClients.Text + "','" + FatherName.Text + "','" + Pol.Text + "','" + PhoneClients.Text + "','" + Image.Text + "','" + DayFirst.Text + "','" + Mail.Text + "','" + Reg.Text + "');";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update dbo.Clients set Famili = '"+Famili.Text+"', Name = '"+NameClients.Text+"', FatherName = '"+ FatherName.Text+"', Pol = '"+ Pol.Text + "', Phone ='" + PhoneClients.Text + "', Image ='" + Image.Text + "', Birthday = '" + DayFirst.Text + "', Email = '" + Mail.Text + "', RegistrDay = '" + Reg.Text + "' where ID = '"+k+"'";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void DellText(object sender, EventArgs e)//удаляем текст при начале записи
        {
            if (k == -1)
            {
                TextBox Temp = (TextBox)sender;
                Temp.Text = "";
            }
        }
        public void InputClient()//заполняем элементы при запуске
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Demo7.dbo.Clients where ID = '"+k+"'";
            cmd.ExecuteNonQuery();
            SqlDataReader RD = cmd.ExecuteReader();
            while (RD.Read())
            {
                Famili.Text = RD[1].ToString();
                NameClients.Text = RD[2].ToString();
                FatherName.Text = RD[3].ToString();
                Pol.Text = RD[4].ToString();
                PhoneClients.Text = RD[5].ToString();
                this.Image.Text = RD[6].ToString();
                BirthDay.Text = RD[7].ToString();
                Mail.Text = RD[8].ToString();
                DataRegistr.Text = RD[9].ToString();
            }
            this.Save.Text = "Изменить";

        }
    }
}
