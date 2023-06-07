using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DA;
using WindowsFormsApp1.Model;




namespace WindowsFormsApp1.Helper
{
    public class UserInterface
    {
        public Account Account { get; set; }

        public Image logo { get; set; }
        public int ColorTheme { get; set; }

        public UserInterface()
        {
            GetLogoFromDB();
            GetColorTheme();
        }

        public string GetTest()
        {
            return "Test";
        }

        public void GetColorTheme()
        {
            ColorTheme = UserInterfaceDA.GetColorTheme();
        }

        public void GetLogoFromDB()
        {
            logo = AccountDA.GetLogo();
        }

        public void DisplayLayout(Form form) // SHOULD HAVE NO CONNECTION TO THE DB ELSE IT WILL LOAD SLOWLY
        {

            foreach (GroupBox gb in form.Controls.OfType<GroupBox>())
            {
                //Username
                if (gb.Name.Contains("grp_LoggedInInfo"))
                {
                    int labelsWith = 0;
                    foreach(Label lb in gb.Controls.OfType<Label>())
                    {
                        if (lb.Name.Contains("AccountName")){
                            lb.Text = Account.Username;
                        }
                        labelsWith += lb.Width;
                    }
                    //Console.WriteLine(Convert.ToInt32(labelsWith * 1.1));
                    gb.Width = Convert.ToInt32(labelsWith + 10);
                }
            }


            if (logo != null)
            {
                foreach (PictureBox pb in form.Controls.OfType<PictureBox>())
                {
                    //update logo
                    pb.Image = logo;
                }

                foreach (GroupBox gb in form.Controls.OfType<GroupBox>())
                {
                    //update logo
                    //pb.Image = logo;
                    foreach (PictureBox pb in gb.Controls.OfType<PictureBox>())
                    {
                        //update logo
                        if (pb.Name.Contains("logo"))
                        {
                            pb.Image = logo;
                        }
                    }
                }
            }

            if (Account != null)
            {
                foreach (Button btn in form.Controls.OfType<Button>())
                {
                    if (btn.Name.Contains("Admin") && (!Account.IsAdmin))
                    {
                        btn.Hide();
                    }
                }

                foreach (GroupBox gb in form.Controls.OfType<GroupBox>())
                {
                    foreach (Button btn in gb.Controls.OfType<Button>())
                    {
                        if (btn.Name.Contains("Admin") && (!(Account.IsAdmin)))
                        {
                            btn.Hide();
                        }


                    }
                }
            }
        
            if (ColorTheme == 1)
            {
                //Set Buttons & stuff...
                foreach (Button control in form.Controls.OfType<Button>())
                {
                    if (control.Name.Contains("Secondary"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#0E34A0");
                    }
                    else if (control.Name.Contains("Third"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3061");
                    }
                    else if (control.Name.Contains("Admin"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#343434");
                    }
                }

                foreach (GroupBox gb in form.Controls.OfType<GroupBox>())
                {
                    foreach (Button btn in gb.Controls.OfType<Button>())
                    {
                        if (btn.Name.Contains("Secondary"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#0E34A0");
                        }
                        else if (btn.Name.Contains("Third"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#2F3061");
                        }
                        else if (btn.Name.Contains("Admin"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#343434");
                        }


                    }
                }
            }
            else if (ColorTheme == 2)
            {
                //Set Buttons & stuff...
                foreach (Button control in form.Controls.OfType<Button>())
                {
                    if (control.Name.Contains("Secondary"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#401F3E");
                    }
                    else if (control.Name.Contains("Third"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#3F2E56");
                    }
                    else if (control.Name.Contains("Admin"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#453F78");
                    }
                }

                foreach (GroupBox gb in form.Controls.OfType<GroupBox>())
                {
                    foreach (Button btn in gb.Controls.OfType<Button>())
                    {
                        if (btn.Name.Contains("Secondary"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#401F3E");
                        }
                        else if (btn.Name.Contains("Third"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#3F2E56");
                        }
                        else if (btn.Name.Contains("Admin"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#453F78");
                        }


                    }
                }
            }
            else if (ColorTheme == 3)
            {
                //Set Buttons & stuff...
                foreach (Button control in form.Controls.OfType<Button>())
                {
                    if (control.Name.Contains("Secondary"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF8360");
                    }
                    else if (control.Name.Contains("Third"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#E8E288");
                    }
                    else if (control.Name.Contains("Admin"))
                    {
                        control.BackColor = System.Drawing.ColorTranslator.FromHtml("#7DCE82");
                    }
                }

                foreach (GroupBox gb in form.Controls.OfType<GroupBox>())
                {
                    foreach (Button btn in gb.Controls.OfType<Button>())
                    {
                        if (btn.Name.Contains("Secondary"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF8360");
                        }
                        else if (btn.Name.Contains("Third"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#E8E288");
                        }
                        else if (btn.Name.Contains("Admin"))
                        {
                            btn.BackColor = System.Drawing.ColorTranslator.FromHtml("#7DCE82");
                        }


                    }
                }
            }
        }
    }
}
