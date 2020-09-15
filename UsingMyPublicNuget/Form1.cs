using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMyPublicNuget
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      IndSoftTestNuget01.NugetMain resp = new IndSoftTestNuget01.NugetMain();

      System.Windows.Forms.MessageBox.Show("AuthorizationStatus: " + resp.GetResponse().AuthorizationStatus);
    }
  }
}
