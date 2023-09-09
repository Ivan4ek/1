using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImg1_Click(object sender, EventArgs e)
        {
            // Полный путь к изображению с расширением файла (например, .jpg, .png)
            string imagePath = @"C:\GitProjectMDK\1MDK\1MDK\bin\Debug\img1.jpg";

            try
            {
                // Освобождаем ресурсы, связанные с предыдущим изображением (если оно было загружено)
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                // Устанавливаем режим отображения изображения по центру PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

                // Отобразить изображение в PictureBox
                pictureBox1.Image = new Bitmap(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
            }
        }
    }
}