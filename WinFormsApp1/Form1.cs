namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string player1;
        private string player2;
        private int playerNumber;
        private int player1Score;
        private int player2Score;
        private string winer = "";

        private int moveLeft = 9;
        List<Button> buttons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            playerNumber = 1;
            buttons = new List<Button>() { field1, field2, field3, field4, field5, field6, field7, field8, field9 };
        }

        private void PrepareGame(object checkBox, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox1.Enabled = false;
            if (checkBox1.Checked == false)
                textBox1.Enabled = true;
            if (checkBox2.Checked == true)
                textBox2.Enabled = false;
            if (checkBox2.Checked == false)
                textBox2.Enabled = true;

            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                playerNumber = 1;
                player1 = textBox1.Text;
                player2 = textBox2.Text;

                foreach (var butt in buttons)
                {
                    butt.Enabled = true;
                    butt.Text = "";
                }

                player1Score = 0;
                player2Score = 0;

                textBox1.BackColor = Color.ForestGreen;
                textBox2.BackColor = Color.White;
                recordBox1.Text = $"{player1} - {player1Score}";
                recordBox2.Text = $"{player2} - {player2Score}";
            }
        }

        private void ButtonClick(object field, EventArgs e)
        {
            switch (playerNumber)
            {
                case 1:
                    field.GetType().GetProperty("Text").SetValue(field, "x");
                    playerNumber = 2;
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.ForestGreen;
                    break;
                case 2:
                    field.GetType().GetProperty("Text").SetValue(field, "o");
                    playerNumber = 1;
                    textBox2.BackColor = Color.White;
                    textBox1.BackColor = Color.ForestGreen;
                    break;
            }
            field.GetType().GetProperty("Enabled").SetValue(field, false);
            moveLeft--;
            CheckWin();
        }

        private void RestartGame(object restart, EventArgs e)
        {
            foreach(var butt in buttons)
            {
                butt.Enabled = true;
                butt.Text = "";
                winer = "";
                moveLeft = 9;
            }
        }

        private void CheckWin()
        {
            if (field1.Text == field2.Text && field2.Text == field3.Text && field3.Text == "x" ||
                field4.Text == field5.Text && field5.Text == field6.Text && field6.Text == "x" || // вертикальна€ проверка 
                field7.Text == field8.Text && field8.Text == field9.Text && field9.Text == "x" ||

                field1.Text == field4.Text && field4.Text == field7.Text && field7.Text == "x" ||
                field2.Text == field5.Text && field5.Text == field8.Text && field8.Text == "x" || // горизоетальна€ проверка 
                field3.Text == field6.Text && field6.Text == field9.Text && field9.Text == "x" ||

                field1.Text == field5.Text && field5.Text == field9.Text && field9.Text == "x" || // диагональна€ проверка 
                field3.Text == field5.Text && field5.Text == field7.Text && field7.Text == "x")
            {
                moveLeft = 0;
                for(int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i].Text == "")
                    {
                        buttons[i].GetType().GetProperty("Enabled").SetValue(buttons[i], false);
                    }
                }
                winer = player1;
                player1Score++;
                recordBox1.Text = $"{player1} - {player1Score}";
                MessageBox.Show($"»гра закончилась победил {winer}");
            }

            if (field1.Text == field2.Text && field2.Text == field3.Text && field3.Text == "o" ||
                field4.Text == field5.Text && field5.Text == field6.Text && field6.Text == "o" || // вертикальна€ проверка 
                field7.Text == field8.Text && field8.Text == field9.Text && field9.Text == "o" ||

                field1.Text == field4.Text && field4.Text == field7.Text && field7.Text == "o" ||
                field2.Text == field5.Text && field5.Text == field8.Text && field8.Text == "o" || // горизоетальна€ проверка 
                field3.Text == field6.Text && field6.Text == field9.Text && field9.Text == "o" ||

                field1.Text == field5.Text && field5.Text == field9.Text && field9.Text == "o" || // диагональна€ проверка 
                field3.Text == field5.Text && field5.Text == field7.Text && field7.Text == "o")
            {
                moveLeft = 0;
                for (int i = 0; i < buttons.Count; i++)
                {
                    if (buttons[i].Text == "")
                    {
                        buttons[i].GetType().GetProperty("Enabled").SetValue(buttons[i], false);
                    }
                }
                winer = player2;
                player2Score++;
                recordBox2.Text = $"{player2} - {player2Score}";
                MessageBox.Show($"»гра закончилась. ѕобедил {winer}");
            }

            if(moveLeft == 0 && winer == "")
            {
                MessageBox.Show($"»гра закончилась. ” нас ничь€");
            }
        }
    }
}
