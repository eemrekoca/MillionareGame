using System;

public partial class Form2 : Form
{
  {
    public Form2()
    {
      InitializeComponent();
    }
    string h,c;
      int toplam = 0;

    private void Form2_Load(object sender, EventArgs e)
    {
        //textBox2.Hide();
        label5.Hide();
        label6.Hide();
        label7.Hide();
        //textBox3.Hide();
        //textBox4.Hide();

      int a1;

          Random number1 = new Random();
          a1 = number.Next(1, 29);
        
    } 

    private void button1_Click(object sender, EventArgs e)
    {
        int b = int.Parse(textBox3.Text);
            
            int s = 1;
            
            if (radioButton1.Checked) h = "a";
            if (radioButton2.Checked) h = "b";
            if (radioButton3.Checked) h = "c";
            if (radioButton4.Checked) h = "d";
            c = label5.Text;
            if (h == c)
            {
              MessageBox.Show("True");

              {
                toplam = toplam + s;
                if (toplam == 1)
                {
                  button3.BackColor.Green;
                }
                if (toplam == 2)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 3)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 4)
                {
                  button4.BackColor.Blue;
                }
                if (toplam == 5)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 6)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 7)
                {
                  button4.BackColor.Blue;
                }
                if (toplam == 8)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 9)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 10)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 11)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 12)
                {
                  button4.BackColor.Green;
                }
                if (toplam == 13)
                {
                  button4.BackColor.Blue;
                }
              }
              string sor;

              int a1;
              Random number1 = new Random();
              a1 = number1.Next(1,29);
              textBox2.Text = a1.ToString();

              OleDbConnection connection = new OleDbConnection ("Provider=Microsoft.Ace.OLEDB.12.0; DATA Source=millionare.accdb");
              connection.Open();
              OleDbCommand query = new OleDbCommand("Select *From question order by[QUESTIONUMBER]", connection);

              OleDbDataReader datare;
              datare = sorgu.ExecuteReader();
              while (datare.Read())
              {
                string a = Convert.ToString(textBox2.Text);
                if (a == datare[0].ToString() &&  int.Parse(datare[7].ToString()) == 0 )

                    if ( )
                    {
                      textBox1.Text = datare[1].ToString();
                      radioButton1.Text = datare[2].ToString();
                      radioButton2.Text = datare[3].ToString();
                      radioButton3.Text = datare[4].ToString();
                      radioButton4.Text = datare[5].ToString();
                      label5.Text = datare[6].ToString();
                      textBox3.Text = datare[7].ToString();

                    }
              }
              ask = "UPDATE question set[repeat]=1 where [QUESTIONUMBER]=" + textBox2.Text + "";
              OleDbCommand apply = new OleDbCommand(ask, connection);
              apply.ExecuteNonQuery();

              datare.Close();
              connection.Close();
            }

            else
            {
              label6.Show();
              label7.Show();
              button2.Show();
              if (total < 4)
              {
                label6.Text = ("NO MONEY");

              }
              if (total < 7 & toplam >= 4)
              {
                label6.Text("1000$");
              }
              if ( total < 13 & toplam >= 7)
              {
                label6.Text = ("15.000$")
              }
              if (total == 13)
              {
                label6.Text = ("1.000.000$")
              }

              button1.Enabled = false;
            }
            if (total == 13)
            {
              label3.Show();
              label3.Text = ("CONGURATULATIONS YOU WON 1.000.000$");
              button1.Enabled = false;
              button2.Show();
              textBox1.Hide();
              radioButton1.Hide();
              radioButton2.Hide();
              radioButton3.Hide();
              radioButton4.Hide();
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            label6.Text = ("");
            toplam = 0;

            string sql;

            label7.Hide();
            int s1;
            Random a2 = new Random();
            s1 = a2.Next(1, 27);
            textBox2.Text = s1.ToString();
            button1.Enabled = true;
            button2.Hide();

            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0; DATA Source=millionare.accdb");
            connection.Open();
            OleDbCommand query = new OleDbCommand("Select *From soru oder by [QUESTIONUMBER]", connection);
            sql = "UPDATE question set Repeat=0";
            OleDbCommand save = new OleDbCommand(sql, connection);
            save.ExecuteNonQuery();

            OleDbDataReader datare;
            datare = sorgu.ExecuteReader();
            while (datare.Read())
            {
                string a = Convert.ToString(textBox2.Text)
                if (a == datare[0].ToString())
                {
                    textBox1.Text = datare[1].ToString();
                    radioButton1.Text = datare[2].ToString();
                    radioButton2.Text = datare[3].ToString();
                    radioButton3.Text = datare[4].ToString();
                    radioButton4.Text = datare[5].ToString();
                    label5.Text = datare[6].ToString();
                    textBox3.Text = datare[7].ToString();
                }
            }
            label3.Hide();

            datare.Close();
            connection.Close();
            textBox1.Show();
            radioButton1.Show(); 
            radioButton2.Show();
            radioButton3.Show();
            radioButton4.Show();
    }
  }

}
