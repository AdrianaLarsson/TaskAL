using Foundation;
using SQLite;
using System;
using System.IO;
using UIKit;

namespace TaskAL
{
    public partial class ViewController : UIViewController 
    {

        public static string DbName = "SQLitedb.db3";
        public static string DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), DbName);


        public static string firstN;
        public static string lastN;
        public static string age;


        public ViewController(IntPtr handle) : base(handle)
        {


    }

        public ViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void SaveBtn_TouchUpInside(UIButton sender)
        {
            firstN = FirstName.Text;
            lastN = LastName.Text;
            age = Age.Text;


            Sum.Text =  "Saved " ;
                //+ " Efternamn: " + lastN + " Ålder: "  + age ;



            Person.personData.Add(firstN);

            InsertData();

        }

        partial void CreateDatabse_TouchUpInside(UIButton sender)
        {
            CreateDB();
        }

        public void CreateDB()
        {
            try
            {
                var db = new SQLiteConnection(DbPath);
                db.CreateTable<Person>();
                lblDBName.Text = "DB Path:" + DbPath;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public void InsertData()
        {
            try
            {
                firstN = FirstName.Text;
                lastN = LastName.Text;
                age  = LastName.Text;

                var person = new Person
                {
                    Firstname = firstN,
                    Lastname = lastN,
                    Age = age

                };
                var db = new SQLiteConnection(DbPath);
                db.Insert(person);
                Sum.Text = firstN + ":" + lastN + ":" + age;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        partial void RetriveBtn_TouchUpInside(UIButton sender)
        {
            DbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "SQLitedb.db3");
            var db = new SQLiteConnection(DbPath);
            var dataTables = db.Query<Person>("select * from Person");


        }
    }



}