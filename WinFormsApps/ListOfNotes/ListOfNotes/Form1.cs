using System.Drawing.Drawing2D;

namespace ListOfNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCategories.Items.Add("���");
            comboBoxCategories.Items.Add("���");
            comboBoxCategories.Items.Add("������");
            comboBoxCategories.Items.Add("�����");
            comboBoxCategories.Items.Add("�������");

            listBoxNotes.Items.Add("������ �������");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        //--------------------
        //�������� "�������"
        private void label1_name_Click(object sender, EventArgs e)
        {

        }

        //Search
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        //������ �����
        private void buttonFind_Click(object sender, EventArgs e)
        {

        }

        //Label ���������
        private void labelCategories_Click(object sender, EventArgs e)
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

        private void listBoxNotes_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void listBoxNotes_ControlRemoved(object sender, ControlEventArgs e)
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
                MessageBox.Show("������ ������ ���������!");
            }
            else
            {
                MessageBox.Show("��������� ��� ����� ������� ����(-�) ��� ��������(-����) ����������� ���������");
            }

        }
    }
}
