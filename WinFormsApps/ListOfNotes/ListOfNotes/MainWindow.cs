using System.Drawing.Drawing2D;
using Models;

namespace ListOfNotes
{
    public partial class MainWindow : Form
    {
        private ModelNotes database = new ModelNotes(); 



        public MainWindow()
        {
            InitializeComponent();
            comboBoxCategories.Items.Add("���");
            comboBoxCategories.Items.Add("���");
            comboBoxCategories.Items.Add("������");
            comboBoxCategories.Items.Add("�����");
            comboBoxCategories.Items.Add("�������");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void LoadNotes()
        {
            // �������� ��� ������� �� ���� ������
            var notes = database.GetAllNotes();
            listBoxNotes.Items.Clear(); // ������� ������� ������ �������

            foreach (var note in notes)
            {
                // ��������� ��������� ������� � ������
                listBoxNotes.Items.Add(note.Title);
            }
        }

        //Mouse Events

        private void textBoxSearch_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBoxSearch.Text == "�����...")
            {
                textBoxSearch.Clear();
            }
        }

        private void textBoxTitleNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && textBoxTitleNote.Text == "���������")
            {
                textBoxTitleNote.Clear();
            }
        }
        private void richTextBoxNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && richTextBoxNote.Text == "������� ����� �������")
            {
                richTextBoxNote.Clear();
            }
        }

        private void listBoxNotes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // ���������, ��� ��������� ������� � ������
                if (listBoxNotes.SelectedItem != null)
                {
                    // �������� ������ ��������� �������
                    int selectedIndex = listBoxNotes.SelectedIndex;
                    // �������� �����-�� ������� �� ���� �� �������
                    var note = database.GetNoteById(selectedIndex + 1); // ������������, ��� ID ������� ���������� � 1

                    if (note != null)
                    {
                        EditNoteForm editNoteForm = new EditNoteForm(database, note.Id); // ������������� note.Id
                        editNoteForm.ShowDialog();
                        editNoteForm.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("������� �� �������.");
                    }
                }
            }
        }

        //--------------------

        //Search
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        //������ �����
        private void buttonFind_Click(object sender, EventArgs e)
        {

        }

        //��������� ���������
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // ���������
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        //����� ����
        private void richTextBoxNote_TextChanged(object sender, EventArgs e)
        {

        }

        //������ �������
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //������ ����������
        private void buttonSaveNote_Click(object sender, EventArgs e)
        {
            if (
                (textBoxTitleNote.Text != "���������" && textBoxTitleNote.Text != "") &&
                (richTextBoxNote.Text != "������� ����� �������" && richTextBoxNote.Text != "")
               )
            {
                DateTime dateTime = DateTime.Now;
                // ������� ����� �������
                database.CreateData(dateTime.ToString(), textBoxTitleNote.Text, richTextBoxNote.Text);

                // ��������� ������ �������
                var notes = database.GetAllNotes();
                listBoxNotes.Items.Clear();
                foreach (var note in notes)
                {
                    listBoxNotes.Items.Add(note.Title);
                }

                MessageBox.Show($"������ ������� ���������!");
                textBoxTitleNote.Text = "���������";
                richTextBoxNote.Text = "������� ����� �������";
            }
            else
            {
                MessageBox.Show("��������� ��� ����� ������� ����(-�) ��� �������� ����������� ���������.");
            }
        }
    }
}
