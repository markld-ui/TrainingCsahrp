using System.Drawing.Drawing2D;

namespace ListOfNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCategories.Items.Add("Все");
            comboBoxCategories.Items.Add("Дом");
            comboBoxCategories.Items.Add("Работа");
            comboBoxCategories.Items.Add("Спорт");
            comboBoxCategories.Items.Add("Финансы");

            listBoxNotes.Items.Add("Первая заметка");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Mouse Events

        private void textBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBoxSearch.Text == "Поиск...")
            {
                textBoxSearch.Clear();
            }
        }

        private void textBoxTitleNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBoxTitleNote.Text == "Заголовок")
            {
                textBoxTitleNote.Clear();
            }
        }
        private void richTextBoxNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && richTextBoxNote.Text == "Введите текст заметки")
            {
                richTextBoxNote.Clear();
            }
        }

        //--------------------
        //Название "Заметки"
        private void label1_name_Click(object sender, EventArgs e)
        {

        }

        //Search
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        //Кнопка найти
        private void buttonFind_Click(object sender, EventArgs e)
        {

        }

        //Label Категории
        private void labelCategories_Click(object sender, EventArgs e)
        {

        }

        //Комбобокс категории
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Заголовок
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        //Текст ноты
        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        //Список заметок
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxNotes_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void listBoxNotes_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        //Кнопка сохранения
        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            if (
                (textBoxTitleNote.Text != "Заголовок" && textBoxTitleNote.Text != "") &&
                (richTextBoxNote.Text != "Введите текст заметки" && richTextBoxNote.Text != "")
               )
            {
                MessageBox.Show("Данные удачно сохранены!");
            }
            else
            {
                MessageBox.Show("Заголовок или текст заметки пуст(-ы) или является(-ются) стандартным значением");
            }

        }
    }
}
