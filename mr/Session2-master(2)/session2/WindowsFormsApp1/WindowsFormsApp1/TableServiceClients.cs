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
    public partial class TableServiceClients : Form
    {
        public string k;
        SqlConnection con = new SqlConnection("Data Source=10.10.14.40;Initial Catalog=Demo7;User ID=Demo7;Password=Abcd1234");
        public TableServiceClients()
        {
            InitializeComponent();
            
        }
        public void update()//производим заполнение посещаемости выбранного клиента
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Demo7.dbo.ClientsService where [Клиент] = '" + k + "'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.GriedService.DataSource = dt;
            Kol.Text = "количество посещений = " + (GriedService.RowCount-1);
            con.Close();
        }

    }
}
