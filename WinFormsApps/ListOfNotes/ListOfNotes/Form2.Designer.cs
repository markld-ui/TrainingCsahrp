using System.Windows.Forms;

namespace ListOfNotes
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            buttonSaveNote = new Button();
            buttonClose = new Button();
            label_name = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(82, 83, 85);
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(58, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(571, 32);
            textBox1.TabIndex = 0;
            textBox1.Text = "Заголовок";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(82, 83, 85);
            richTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(58, 159);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(571, 243);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "Текст заметки";
            // 
            // buttonSaveNote
            // 
            buttonSaveNote.BackColor = Color.FromArgb(82, 83, 85);
            buttonSaveNote.ForeColor = Color.White;
            buttonSaveNote.Location = new Point(473, 408);
            buttonSaveNote.Name = "buttonSaveNote";
            buttonSaveNote.Size = new Size(75, 23);
            buttonSaveNote.TabIndex = 2;
            buttonSaveNote.Text = "Сохранить";
            buttonSaveNote.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(82, 83, 85);
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(554, 408);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 3;
            buttonClose.Text = "Закрыть";
            buttonClose.UseVisualStyleBackColor = false;
            // 
            // label_name
            // 
            label_name.Font = new Font("Segoe UI", 20F);
            label_name.ForeColor = SystemColors.Window;
            label_name.Location = new Point(12, 9);
            label_name.Name = "label_name";
            label_name.Size = new Size(120, 39);
            label_name.TabIndex = 4;
            label_name.Text = "Заметки";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 33, 36);
            ClientSize = new Size(684, 461);
            Controls.Add(label_name);
            Controls.Add(buttonClose);
            Controls.Add(buttonSaveNote);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            ForeColor = SystemColors.Window;
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button buttonSaveNote;
        private Button buttonClose;
        private Label label_name;
    }
}