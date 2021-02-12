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
    public partial class ClientsList : Form
    {
        SqlConnection con = new SqlConnection("Data Source=10.10.14.40;Initial Catalog=Demo7;User ID=Demo7;Password=Abcd1234");
        string Qwerty = "Select * from Demo7.dbo.Clients where Demo7.dbo.Clients.ID = Demo7.dbo.Clients.ID";
        string sort = "";
        string FindName = "";
        string pol = "";
        public ClientsList()//инициализируем компоненты и производим первичную вставку
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Qwerty;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.MainGrid.DataSource = dt;
            con.Close();
        }

        private void PolChanged(object sender, EventArgs e)//поиск по полу
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if(FindPol.Text=="Мужской")
                pol = " and Pol like 'М%' ";
            else if(FindPol.Text == "Женский")
                pol = " and Pol like 'ж%' ";
            else
                pol = "";
            cmd.CommandText = Qwerty + pol + FindName + sort;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.MainGrid.DataSource = dt;
            con.Close();
        }

        private void FindNameCl(object sender, EventArgs e)//поиск по имени в режиме реальнго времени
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            FindName = " and Email like '"+FindNameClients.Text+"%'  or Famili like '"+ FindNameClients.Text + "%' or Phone like '"+ FindNameClients.Text + "%'";
            cmd.CommandText = Qwerty  + FindName + pol + sort;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.MainGrid.DataSource = dt;
            con.Close();
        }

        private void NextClients(object sender, EventArgs e)//выбор следующего клиента
        {
            int s = MainGrid.CurrentCell.RowIndex;
            if (s + 1 < MainGrid.Rows.Count)
                MainGrid.CurrentCell = MainGrid.Rows[s + 1].Cells[0];
        }

        private void LastClients(object sender, EventArgs e)//выбор предыдущего клиента
        {
            int s = MainGrid.CurrentCell.RowIndex;
            if (s - 1 >=0 )
                MainGrid.CurrentCell = MainGrid.Rows[s - 1].Cells[0];
        }

        private void Sorted(object sender, EventArgs e)//сопртимровка по алфавиту 
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (Research.Text == "Фамилия")
                sort = " order by (Famili)";
            else if (Research.Text == "Дата посещения")
                sort = " order by (RegistrDay)";
            else
                sort = "";
            cmd.CommandText = Qwerty + pol + FindName + sort;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.MainGrid.DataSource = dt;
            con.Close();
        }

        private void DeletedClick(object sender, EventArgs e)//удаление выбранного клиента
        {
            int s = MainGrid.CurrentCell.RowIndex;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from  dbo.Clients where ID = '" + MainGrid.Rows[s].Cells[0].Value +"'";
            cmd.ExecuteNonQuery();
            MainGrid.Rows.Remove(MainGrid.Rows[s]);
            con.Close();
        }
        public void Update()//обновление таблицы
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = Qwerty + pol + FindName + sort;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.MainGrid.DataSource = dt;
            con.Close();
        }

        private void Append(object sender, EventArgs e)//открытие формы добавления нового клиента на создание 
        {
            AppendClients FR = new AppendClients();
            FR.ShowDialog();
            Update();
        }

        private void Engeneer(object sender, EventArgs e)//открытие формы добавления нового клиента на редактирование
        {
            AppendClients FR = new AppendClients();
            int s = MainGrid.CurrentCell.RowIndex;
            FR.Text = "Изменение клиента";
            FR.k =(int)MainGrid.Rows[s].Cells[0].Value;
            FR.InputClient();
            FR.ShowDialog();
            Update();
        }

        private void MovingClick(object sender, EventArgs e)//открытие формы посещаемости
        {
            TableServiceClients Fr = new TableServiceClients();
            int s = MainGrid.CurrentCell.RowIndex;
            Fr.k = MainGrid.Rows[s].Cells[1].Value.ToString();
            Fr.update();
            Fr.ShowDialog();
        }
    }
}
