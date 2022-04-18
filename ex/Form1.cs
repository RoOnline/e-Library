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

namespace ex
{
    public partial class Form1 : Form
    {
        int i = 1;
        int b = 0;
        string ConnStr = "Data Source=ngknn.ru;Initial Catalog=ЗорькинРоманЭкзамен;Persist Security Info=True;User ID=44П;Password=H12TjtrV";
        public Form1()
        {
           
            InitializeComponent();
            buu();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void buu()
        {

            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();

                label1100.Text = b.ToString();



            if (i == 1)
            {
                cmd.CommandText = "select [Название] from Книги where id = 1";
                label9.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 1";
                label11.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 1";
                label13.Text = (string)cmd.ExecuteScalar();
                label15.Text = "444"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 1";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label17.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label17.Text = "Много";


                cmd.CommandText = "select [Количество на складе] from Книги where id = 1";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label19.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label19.Text = "Много";
                else label19.Text = (string)cmd.ExecuteScalar();
                label21.Text = "Страшная игра на выживания";
                Bitmap img = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Долгая прогулка.jpg");
                pictureBox1.Image = img;

                // 2

                cmd.CommandText = "select [Название] from Книги where id = 2";
                label24.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 2";
                label23.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 2";
                label26.Text = (string)cmd.ExecuteScalar();
                label34.Text = "555"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 2";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label28.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label28.Text = "Много";

                else label28.Text = (string)cmd.ExecuteScalar();

                cmd.CommandText = "select [Количество на складе] from Книги where id = 2";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label27.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label27.Text = "Много";
                else label27.Text = (string)cmd.ExecuteScalar();
                label31.Text = "В полицию Осло поступила информация";
                Bitmap img2 = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Король шрамов.jpg");
                pictureBox2.Image = img2;

                // 3

                cmd.CommandText = "select [Название] from Книги where id = 3";
                label38.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 3";
                label37.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 3";
                label40.Text = (string)cmd.ExecuteScalar();
                label48.Text = "999"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 3";
                //if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label42.Text = "Мало";
                //else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label42.Text = "Много";
                label42.Text = "Мало";

                cmd.CommandText = "select [Количество на складе] from Книги where id = 3";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label41.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label41.Text = "Много";
                else label41.Text = (string)cmd.ExecuteScalar();
                label45.Text = "Огонь полыхает";
                Bitmap img3 = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Красношейка.jpg");
                pictureBox3.Image = img3;
            }

            else if (i == 2)
            {
                cmd.CommandText = "select [Название] from Книги where id = 4";
                label9.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 4";
                label11.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 4";
                label13.Text = (string)cmd.ExecuteScalar();
                label15.Text = "353"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 4";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label17.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label17.Text = "Много";

    

                cmd.CommandText = "select [Количество на складе] from Книги where id = 4";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label19.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label19.Text = "Много";
                else label19.Text = (string)cmd.ExecuteScalar();
                label21.Text = "Может ли спасение от верной гибели обернуться таким кошмаром...";
                Bitmap img4 = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Крещение огнем.jpg");
                pictureBox1.Image = img4;

                //4

                cmd.CommandText = "select [Название] from Книги where id = 5";
                label24.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 5";
                label23.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 5";
                label26.Text = (string)cmd.ExecuteScalar();
                label34.Text = "646"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 5";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label28.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label28.Text = "Много";


                cmd.CommandText = "select [Количество на складе] from Книги where id = 5";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label27.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label27.Text = "Много";
                else label27.Text = (string)cmd.ExecuteScalar();
                label31.Text = "Странная, страшная и бесконечно притягательная книга.";
                Bitmap img2 = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Мизери.jpg");
                pictureBox2.Image = img2;

                //5

                cmd.CommandText = "select [Название] from Книги where id = 6";
                label38.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 6";
                label37.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 6";
                label40.Text = (string)cmd.ExecuteScalar();
                label48.Text = "7667"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 6";
                //if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label42.Text = "Мало";
                //else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label42.Text = "Много";
                label42.Text = "Мало";

                cmd.CommandText = "select [Количество на складе] from Книги where id = 6";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label41.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label41.Text = "Много";
                label45.Text = "Дракон похитил принцессу, чтобы сотворить древний ритуал.";
                Bitmap img9 = new Bitmap ("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Повелитель мух.jpg");
                pictureBox3.Image = img9;

                
            }
            else if (i == 3)
            {
                cmd.CommandText = "select [Название] from Книги where id = 7";
                label9.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 7";
                label11.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 7";
                label13.Text = (string)cmd.ExecuteScalar();
                label15.Text = "45"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 7";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label17.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label17.Text = "Много";


                cmd.CommandText = "select [Количество на складе] from Книги where id = 7";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label19.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label19.Text = "Много";
                label21.Text = "Фитц Чивэл, королевский убийца, возвращается к жизни.";
                Bitmap img5 = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Ритуал.jpg");
                pictureBox1.Image = img5;

                //4

                cmd.CommandText = "select [Название] from Книги where id = 7";
                label24.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 7";
                label23.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 7";
                label26.Text = (string)cmd.ExecuteScalar();
                label34.Text = "888"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 7";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label28.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label28.Text = "Много";


                cmd.CommandText = "select [Количество на складе] from Книги where id = 7";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label27.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label27.Text = "Много";
                label31.Text = "Это изустная побывальщина.";
                Bitmap img6 = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Странствия убийцы.jpg");
                pictureBox2.Image = img6;

                //5

                cmd.CommandText = "select [Название] from Книги where id = 8";
                label38.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Жанр] from Книги where id = 8";
                label37.Text = (string)cmd.ExecuteScalar();
                cmd.CommandText = "select [Автор] from Книги where id = 8";
                label40.Text = (string)cmd.ExecuteScalar();
                label48.Text = "666"; //Цена

                cmd.CommandText = "select [Кол-во в магазине] from Книги where id = 8";
                //if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label42.Text = "Мало";
                //else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label42.Text = "Много";
                label42.Text = "Мало";

                cmd.CommandText = "select [Количество на складе] from Книги where id = 8";

                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) label41.Text = "Мало";
                else if (Convert.ToInt32(cmd.ExecuteScalar()) > 3) label41.Text = "Много";
                label45.Text = "Келлен со страхом ждёт своего шестнадцатого дня рождения";
                Bitmap img7 = new Bitmap("C:/Users/Пользователь/Desktop/Модульный экзамен ПМ01/Covers/Творец заклинаний.jpg");
                pictureBox3.Image = img7;



            }
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i++;
            if (i > 5)
            { i = 5; }
            buu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Корзина f = new Корзина();
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            b++;
            buu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = 1;
            }
            buu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            b++;
            buu();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            b++;
            buu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = 0;
            buu();
        }
    }
}
