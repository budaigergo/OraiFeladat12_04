using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OraiFeladat12_04
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }   
        private void felhasznalok_update()
        {
           listBox_felhasznalok.Items.Clear();
            cmd.CommandText = "SELECT * FROM `felhasznalok` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    string datum = dr.GetDateTime("szuletes").ToString("yyyyy-MM-dd");
                    felhaszn uj = new felhaszn(dr.GetInt32("id"), dr.GetString("nev"),DateTime.Parse(datum), dr.GetString("profilkep"));
                    listBox_felhasznalok.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "felhasznalok";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }

            felhasznalok_update();


        }


        public string kepfajl;
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 kepfajl= openFileDialog1.SafeFileName;
                 pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                MessageBox.Show(kepfajl);
            }
        }
        private void button_Insert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO `felhasznalok` (`Id`, `Nev`, `Szuletes`, `profilkep`) VALUES (NULL, @Nev,@Szuletes, @Kep);";
            cmd.Parameters.AddWithValue("@Nev", textBox_Nev.Text);
            cmd.Parameters.AddWithValue("@Szuletes",dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Kep",kepfajl);
            conn.Open();
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Sikeres rogzites");
            }
            if (conn.State==ConnectionState.Open)
            {
                conn.Close(); 
            }
            felhasznalok_update();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_felhasznalok.SelectedIndex<0)
            {
                return;
            }
            cmd.Parameters.Clear();
            cmd.CommandText = "DELETE FROM `felhasznalok` WHERE `Id`=@id";
            cmd.Parameters.AddWithValue("@id",textBox_Id.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("sikeres torles");
            }
            if (conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
            felhasznalok_update();
            
        }


        private void listBox_felhasznalok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_felhasznalok.SelectedIndex<0)
            {
                return;
            }
            felhaszn kivalasztottfelhaszn = (felhaszn)listBox_felhasznalok.SelectedItem;
            textBox_Id.Text = kivalasztottfelhaszn.Id.ToString();
            textBox_Nev.Text = kivalasztottfelhaszn.Nev.ToString();
            dateTimePicker1.Value=kivalasztottfelhaszn.Szuletes;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (listBox_felhasznalok.SelectedIndex<0)
            {
                MessageBox.Show("Nincs kijelölve felhasznalo");

            }
            cmd.CommandText = "UPDATE `felhasznalok` SET `Nev`=@Nev,`Szuletes`=@Szuletes,`profilkep`=@Kep WHERE `Id`=@Id";
            cmd.Parameters.AddWithValue("@Id",textBox_Id.Text);
            cmd.Parameters.AddWithValue("@Nev",textBox_Nev.Text);
            cmd.Parameters.AddWithValue("@Szuletes", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Kep",openFileDialog1.SafeFileName);
            conn.Open();
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Sikeres modositas");
                conn.Close();
                textBox_Id.Text = "";
                textBox_Nev.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                


            }
        }
    }
}
