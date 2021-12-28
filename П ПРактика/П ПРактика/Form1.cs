using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Media;

namespace П_ПРактика
{
    public partial class Form1 : Form
    {
        private String connectionString = @"Data Source=LAPTOP-KMKUU335\SQLEXPRESS;Initial Catalog=praktika_Logo;Integrated Security=True";
        private SqlConnection myConnection;
        public Form1()
        {
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            InitializeComponent();
            myConnection = new SqlConnection(connectionString);
            try
            {
                myConnection = new SqlConnection(@"Data Source=LAPTOP-KMKUU335\SQLEXPRESS;Initial Catalog=praktika_Logo;Integrated Security=True");
                myConnection.Open();
            }
            catch
            {
                myConnection.Close();
                MessageBox.Show("Не удалось установить связь с бд:(");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.statusTableAdapter.Fill(this.praktika_LogoDataSet6.Status);
            this.staffTableAdapter.Fill(this.praktika_LogoDataSet5.Staff);
            this.clientTableAdapter.Fill(this.praktika_LogoDataSet4.Client);
            this.team_compositionTableAdapter.Fill(this.praktika_LogoDataSet3.Team_composition);
            this.teamTableAdapter.Fill(this.praktika_LogoDataSet2.Team);
            this.projektTableAdapter.Fill(this.praktika_LogoDataSet.Projekt);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Projekt ( ID_Client, ID_Staff, Start_Date, End_Date,ID_Team,Cost,ID_status ) VALUES ('" + ID_K.Text + "', '" + ID_S.Text + "', '" + D_N.Text + "', '" + D_K.Text + "', '" + ID_T.Text + "', '" + Sena.Text + "', '" + ID_St.Text + "')";
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Проект  Успешно Добавлен ;)");
            }
            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");
            }
            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Staff WHERE ID_Staff=" + Del3.Text;
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Сотрудниу Удален :(");
                dataGridView1.Refresh();
                Del3.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось Удалить Сотрудника ОШИБКА!!!  :(");
            }
            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Client WHERE id_Client=" + Del.Text;
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Клиент Удален :(");
                Del.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось Удалить Клиента ОШИБКА!!!  :(");

                
            }
            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Projekt WHERE ID_Projekt=" + Del1.Text;
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show(" Проект Удален :(");
                Del1.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось Удалить Проект ОШИБКА!!!  :(");

                
            }
            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Status WHERE ID_Status=" + Del2.Text;
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show(" Cтатус Удален :)");
                Del2.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось Удалить Статус ОШИБКА!!!  :(");

                
            }
            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Team WHERE ID_team=" + Del4.Text;
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("  Команда Удален :(");
                
                Del4.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось Удалить Статус ОШИБКА!!!  :(");

                
            }
            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Team_composition WHERE ID_Composition=" + Del5.Text;
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("   Состав Команды Удален :(");
               
                Del5.Text = "";
            }
            catch
            {
                MessageBox.Show("Не удалось Удалить Статус ОШИБКА!!!  :(");

                
            }
            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }

        private void button4_Click(object sender, EventArgs e) 
        {
             string query = "INSERT INTO Status (Nazvanie  ) VALUES ('" + Statys.Text +   "')";
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Статус  Успешно Добавлен ;)");

            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();


        }

        private void button17_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Team_composition (ID_Staff,ID_Projekt ) VALUES ('" + ID_Staff.Text + "', '" + ID_Projekt.Text + "')";
            SqlCommand Command = new SqlCommand(query, myConnection);
            Command.ExecuteNonQuery();
            MessageBox.Show("Состав Команды  Успешно обновлен ;)");

            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }

        private void button14_Click(object sender, EventArgs e)  
        {
            string query = "INSERT INTO Team ( Nazvanie) VALUES ('" + Nazvanie.Text + "')";
            SqlCommand Command = new SqlCommand(query, myConnection);
            Command.ExecuteNonQuery();
            MessageBox.Show("Состав Команды  Успешно обновлен ;)");


            MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
            Application.Restart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "INSERT INTO Staff ( Surname, Name, Patronymic, Post, phone ) VALUES ('" + F1.Text + "', '" + I1.Text + "', '" + O1.Text + "', '" + Post.Text + "', '"  + T1.Text +  "')";
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Сотрудник Успешно Добавлен ;)");

                MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
                Application.Restart();
            }

            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "INSERT INTO Client ( Surname, Name, Patronymic, phone ) VALUES ('" + F.Text + "', '" + I.Text + "', '" + O.Text + "', '"  + T.Text + "')";
                SqlCommand Command = new SqlCommand(query, myConnection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Клиент  Успешно Добавлен ;)");

                MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
                Application.Restart();
            }

            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                projektBindingSource.EndEdit();
                projektTableAdapter.Update(praktika_LogoDataSet);
                MessageBox.Show("Изменения Успешно применены;);):)");

                MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");
            }
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                staffBindingSource.EndEdit();
                staffTableAdapter.Update(praktika_LogoDataSet5);

                MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                clientBindingSource.EndEdit();
                clientTableAdapter.Update(praktika_LogoDataSet4);
                MessageBox.Show("Изменения Успешно применены;);):)");


                MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");

            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы добавить данные в таблици нужно либо заполнить данные в текстовые поля и нажать кнопку добавить либо вносить данные сразу в таблицу и нажать редактировать ");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                teamBindingSource.EndEdit();
                teamTableAdapter.Update(praktika_LogoDataSet2);
                MessageBox.Show("Изменения Успешно применены;);):)");

                MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                teamcompositionBindingSource.EndEdit();
                team_compositionTableAdapter.Update(praktika_LogoDataSet3);
                MessageBox.Show("Изменения Успешно применены;);):)");

                MessageBox.Show("Программа СЕйчас ПереЗАгрузится Для обновления таблиц");
                Application.Restart();
            }
            catch
            {
                MessageBox.Show("Ошибка Сохранения проверь код ДурАчек");
            }
        }
    }
    }
