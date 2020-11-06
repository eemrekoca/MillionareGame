using System;

private void button2_Click(object sender, EventArgs e)
{
  form2 fr2 = new Form2(;
  this.Visible = false;
  fr2.ShowDialog();
  this.Visible = true;
}

  private void button1_Click(object sender, EventArgs e)
  {
    form3 fr3 = new Form3();
    this.Visible = false;
    fr3.ShowDialog();
    this.Visible = true;
  }
    private void button3_Click(object sender, EventArgs e)
    {
      Form4 fr4 = new Form4();
      this.Visible = false;
      fr4.ShowDialog();
      this.Visible = true;
    }
