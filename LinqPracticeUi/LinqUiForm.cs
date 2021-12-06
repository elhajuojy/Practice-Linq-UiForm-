using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//you mast call using system.Linq 
namespace LinqPracticeUi
{
    public partial class LinqUiForm : Form
    {
        public LinqUiForm()
        {
            InitializeComponent();
        }
        // create listpersonne which type is personne
        List<Personne> listPersonne = new List<Personne>();
        List<Animal> listanimals = new List<Animal>();
        private void LinqUiForm_Load(object sender, EventArgs e)
        {

            // from class personne i create 7 object and put the in listPersonne 
            Personne p1 = new Personne("ELMAHDI", "ELHJUOJY", 22, "SAFI") { Numbers= new long[] { 21265970021, 21265565855 } };
            Personne p2 = new Personne("AHMED", "BOUNACER", 26, "SAFI") { Numbers = new long[] { 065970021, 0655658 } };
            Personne p3 = new Personne("ZINEB", "BELHID", 24, "SAFI") { Numbers = new long[] { 065970021, 0655658 } };
            Personne p4 = new Personne("HOUSSAM", "JEBBAR", 20, "OULIDIA") { Numbers = new long[] { 065970021, 0655658 } };
            Personne p5 = new Personne("HADIL", "TALHI", 18, "ESSOUIRA") { Numbers = new long[] { 065970021, 0655658 } };
            Personne p6 = new Personne("MOUHAMMED", "OUMOULD", 20, "SAFI");
            Personne p7 = new Personne("AYOUB", "BOULGHLA", 22, "AGADIR");

            Animal a1 = new Animal() { _OwnerName = "ELMAHDI", _AnimalName= "SAMANTHA",_AnimalAge=2 };
            Animal a2 = new Animal() { _OwnerName = "HOUSSAM", _AnimalName = "MIMI", _AnimalAge = 1 };
            Animal a3 = new Animal() { _OwnerName = "ZINEB", _AnimalName = "HONEY", _AnimalAge = 2 };
            Animal a4 = new Animal() { _OwnerName = "HADIL", _AnimalName = "SAMANTHA", _AnimalAge = 2 };
            Animal a5 = new Animal() { _OwnerName = "AHMED", _AnimalName = "MIMI", _AnimalAge = 1 };
            Animal a6 = new Animal() { _OwnerName = "ELMAHDI", _AnimalName = "HONEY", _AnimalAge = 2 };


            //add those personnes to listpersonne 
            listPersonne.Add(p1);
            listPersonne.Add(p2);
            listPersonne.Add(p3);
            listPersonne.Add(p4);
            listPersonne.Add(p5);
            listPersonne.Add(p6);
            listPersonne.Add(p7);


            //Add Animals to list Animal
            listanimals.Add(a1);
            listanimals.Add(a2);
            listanimals.Add(a3);
            listanimals.Add(a4);
            listanimals.Add(a5);
            listanimals.Add(a6);


        }

        private void btnAllData_Click(object sender, EventArgs e)
        {

            //rep to call all data from list pesonne Query syntax 
           var repShowwAll = from personne in listPersonne select personne;

            //show the results in listBox 
            LsBox.Items.Clear();
            foreach (var person in repShowwAll)
            {
                LsBox.Items.Add(person.FirstName + " \x0A " + person.LastName + " \x0A " + person.Age + " \x0A " + person.City);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rep to filtere data by set a condition 
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

            // order 
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

            // group personne in listPersonne by City 
            var reqGroup = from personne in listPersonne
                          group personne by personne.City;



            LsBox.Items.Clear();
            foreach(var person in reqGroup)
            {
                LsBox.Items.Add(person.Key);
                foreach(var Listpre in person)
                {
                    LsBox.Items.Add("----> " + Listpre.FirstName + " " + Listpre.LastName);

                }
                LsBox.Items.Add("-------------------------");
               
            }              
        }

        private void btnNestedQuery_Click(object sender, EventArgs e)
        {
            var reqNestedQuery = from personne in listPersonne
                                 where personne.FirstName == "ELMAHDI"
                                 from personneNumbers in personne.Numbers
                                 select personneNumbers ;

            LsBox.Items.Clear();
            foreach(var person in reqNestedQuery)
            {
                LsBox.Items.Add(person);
            }
                                 
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var reqJoins = from personn in listPersonne
                           where personn.FirstName =="ELMAHDI"
                           join animal in listanimals
                           on personn.FirstName equals animal._OwnerName
                           select animal;

            LsBox.Items.Clear();
            foreach(var animal1 in reqJoins)
            {
                LsBox.Items.Add(animal1._OwnerName+"----> "+animal1._AnimalName);
            }
                  
        }

        private void btnJoin2_Click(object sender, EventArgs e)
        {
            var reqJoinsInto = from personn in listPersonne
                               join animal in listanimals
                               on personn.FirstName equals animal._OwnerName
                               into animalAndOwernsData
                               select new { personn, animalAndOwernsData };

            LsBox.Items.Clear();
            foreach(var r in reqJoinsInto)
            {
                if(r.animalAndOwernsData.Count() > 0)
                {
                    LsBox.Items.Add(r.personn.FirstName + "  " + r.personn.LastName);
                    foreach (var y in r.animalAndOwernsData)
                    {
                        LsBox.Items.Add("------>" + y._AnimalName);
                    }
                    LsBox.Items.Add("-----------------");
                }
                
            }
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            var reqDistinct = (from animal in listanimals
                              select animal._AnimalName).Distinct();

            LsBox.Items.Clear();
            foreach(var animal in reqDistinct)
            {
                LsBox.Items.Add(animal);
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var reqSum = (from person in listPersonne select person.Age).Sum();


            LsBox.Items.Clear();
            LsBox.Items.Add("Sum Age : "+reqSum);
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            var reqAverage= (from person in listPersonne select person.Age).Average();


            LsBox.Items.Clear();
            LsBox.Items.Add("Average Age : "+reqAverage);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            var reqMin = (from person in listPersonne select person.Age).Min();


            LsBox.Items.Clear();
            LsBox.Items.Add("Min Age : "+reqMin);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            var reqMax = (from person in listPersonne select person.Age).Max();


            LsBox.Items.Clear();
            LsBox.Items.Add("Max Age : "+reqMax);
        }

        private void btnAlais_Click(object sender, EventArgs e)
        {

            //change artubits name 
            var reqAlias = from person in listPersonne
                           select new
                           {
                               prenom = person.FirstName,
                               nom = person.LastName,
                               age = person.Age,
              
                           };

            foreach(var item in reqAlias)
            {

                LsBox.Items.Add("prenom :  "+item.prenom + "  nom : "+item.nom +"  age : "+item.age);
            }
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            var reqStartWith = from personn in listPersonne
                               where personn.FirstName.StartsWith("M")
                               select personn;

            LsBox.Items.Clear();
            foreach(var item in reqStartWith)
            {
                LsBox.Items.Add("start  With (M) : --->" + item.FirstName);
            }
             
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {

            var reqEndWith = from personn in listPersonne
                               where personn.FirstName.EndsWith("M")
                               select personn;

            LsBox.Items.Clear();
            foreach (var item in reqEndWith)
            {
                LsBox.Items.Add("End With (M) : --->"+item.FirstName);
            }
        }
    }
}
