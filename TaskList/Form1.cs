using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskList
{
    public partial class Form1 : Form
    {
        int row = 1;
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taskGeneratorButton_Click(object sender, EventArgs e)
        {
            TextBox taskName = new TextBox();
            TextBox taskTime = new TextBox();
            Button editor = new Button();
            
            taskName.Name = "taskName" + row;
            taskName.Text = nameTextBox.Text;
            taskName.Size = new Size(100, 50);
            taskName.ReadOnly = true;
            taskName.Multiline = true;
            taskTime.Name = "taskTime" + row;
            taskTime.Text = timeTextBox.Text;
            taskTime.Size = new Size(100, 50);
            taskTime.ReadOnly = true;
            taskTime.Multiline = true;
            editor.Click += Editor_Click;
            editor.Name = "editor" + row;
            editor.Text = "編集";
            editor.Size = new Size(70,20);


            taskTablePanel.Controls.Add(taskName , 0, row);
            taskTablePanel.Controls.Add(taskTime, 1, row);
            taskTablePanel.Controls.Add(editor, 2, row);
            row = row + 1;
        }

        private void Editor_Click(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            int rowNum = Int32.Parse(Regex.Match(senderButton.Name, @"\d+").Value);
            TextBox taskName = (TextBox)taskTablePanel.GetControlFromPosition(0, rowNum);
            TextBox taskTime = (TextBox)taskTablePanel.GetControlFromPosition(1, rowNum);


            if (senderButton.Text == "編集")
            {
                taskName.ReadOnly = false;
                taskTime.ReadOnly = false;
                senderButton.Text = "完了";
            }else if(senderButton.Text == "完了")
            {
                taskName.ReadOnly = true;
                taskTime.ReadOnly = true;
                senderButton.Text = "編集";
            }
        
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
