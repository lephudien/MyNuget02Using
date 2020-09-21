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
      //IndSoftTestNuget01.NugetMain resp = new IndSoftTestNuget01.NugetMain();

      // System.Windows.Forms.MessageBox.Show("MyNugetVersion: " + IndSoftTestNuget01.NugetMain.GetMyVersion() + Environment.NewLine + 
      //                                      "ThirdPartyNugetVersion: " + IndSoftTestNuget03ThirdParty.ThirdPartyMain.GetMyVersion());
      
      System.Windows.Forms.MessageBox.Show(IndSoftTestNuget01.NugetMain.GetMyVersion() 
                                            + Environment.NewLine
                                            //+ IndSoftTestNuget01
                                            //+ Environment.NewLine
                                            +  IndSoftTestNuget03ThirdParty.ThirdPartyMain.GetMyVersion());
    }
  }
}
