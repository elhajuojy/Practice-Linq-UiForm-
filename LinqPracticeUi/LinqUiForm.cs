using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqPracticeUi
{
    public partial class LinqUiForm : Form
    {
        public LinqUiForm()
        {
            InitializeComponent();
        }
        List<Personne> listPersonne = new List<Personne>();
        private void LinqUiForm_Load(object sender, EventArgs e)
        {
            
            
            Personne p1 = new Personne("ELMAHDI","ELHJUOJY",22,"SAFI");
            Personne p2 = new Personne("AHMED","BOUNACER",26, "SAFI");
            Personne p3 = new Personne("ZINEB", "BELHID",24, "SAFI");
            Personne p4 = new Personne("HOUSSAM", "JEBBAR",20, "OULIDIA");
            Personne p5 = new Personne("HADIL", "TELHI",18, "ESSOUIRA");
            Personne p6 = new Personne("MOUHAMMED", "OUMOULD",20, "SAFI");
            Personne p7 = new Personne("AYOUB", "BOULGHLA",22, "AGADIR");
            
            listPersonne.Add(p1);
            listPersonne.Add(p2);
            listPersonne.Add(p3);
            listPersonne.Add(p4);
            listPersonne.Add(p5);
            listPersonne.Add(p6);
            listPersonne.Add(p7);

            


        }

        private void btnAllData_Click(object sender, EventArgs e)
        {
           var repShowwAll = from personne in listPersonne select personne;


            LsBox.Items.Clear();
            foreach (var person in repShowwAll)
            {
                LsBox.Items.Add(person.FirstName + " \x0A " + person.LastName + " \x0A " + person.Age + " \x0A " + person.City);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wherePersonne = from personne in listPersonne where personne.FirstName.Contains("M")
                                select personne;

            LsBox.Items.Clear();
            foreach(var person in wherePersonne)
            {
                LsBox.Items.Add(person.FirstName);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var reqOrder = from personne in listPersonne
                           orderby personne.Age
                           select personne;

            LsBox.Items.Clear();
            foreach(var person in reqOrder)
            {
                LsBox.Items.Add((person.FirstName +" ---> "+ person.LastName +"--->"+person.Age).ToString());
            }
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            var reGroup = from personne in listPersonne
                          group personne by personne.City;
            LsBox.Items.Clear();
            foreach(var person in reGroup)
            {
                LsBox.Items.Add(person.Key);
                foreach(var Listpre in person)
                {
                    LsBox.Items.Add("----> " + Listpre.FirstName + " " + Listpre.LastName);

                }
                LsBox.Items.Add("-------------------------");
               
            }              
        }
    }
}
