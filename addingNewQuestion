using System;

private void button1_Click(object sender, EventArgs e)
{
  string bag, ask,
  bag = "provider=microsoft.ace.oledb.12.0;data source=millionare.accdb";
  ask = "INSERT into question([QUESTIONS],[AQ],[BQ],[CQ],[DQ],[Answer]) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
  OleDbConnection new = new OleDbConnection(bag);
  OleDbCommand make = new OleDbCommand(ask, new);
  new.Open();
  make.ExecuteNonQuery();
  new.Close();
  MessageBox.Show("You add the question");
}

private void button2_Click(object sender, EventArgs e)
{
  textBox1.Clear();
  textBox2.Clear();
  textBox3.Clear();
  textBox4.Clear();
  textBox5.Clear();
  textBox6.Clear();
}

private void button3.Click(object sender, EventArgs e)
{
  this.Close();
}
