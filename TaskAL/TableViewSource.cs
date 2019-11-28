using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TaskAL
{
    public class TableViewSource : UITableViewSource
    {

        public PersonsViewCandTVC owner;

        List<string> personData;
       // UIViewController parentController;
        public TableViewSource(List<string> items, PersonsViewCandTVC owner) //UIViewController viewController//)
        {
            personData = PersonManager.personData;
            this.owner = owner;
           // parentController = viewController; 
        }

        //public TableViewSource(List<string> itemData)
        //{
        //    this.itemData = itemData;
        //}

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell("cell");
            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "cell");
            }
            cell.TextLabel.Text = personData[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return personData.Count;
        }

        private UINavigationController primNav { get; set; }
       // public DetailPersonVC detailPVC { get; private set; }

        public static string SelectedRow;
        private List<string> itemData;
      


        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {



            SelectedRow = personData[indexPath.Row];
            Console.WriteLine("did select" + SelectedRow);
           // var storyboard = UIStoryboard.FromName("Main", null);
           // var controller = storyboard.InstantiateViewController("DetailPersonVC");

            //tableView.DeselectRow(indexPath, true);
            //detailPersonVC.NavigationController.PushViewController(controller, true);
            tableView.DeselectRow(indexPath, true);

            // PlayerDetailController is my view controller I want to open on button click

            // SOME THING LIKE THIS

            //  DetailPersonVC detailPersonVC = primNav.Storyboard.InstantiateViewController("DetailPersonVC") as DetailPersonVC;


            //  primNav.PushViewController(detailPersonVC, true);
            // var storyboard = UIStoryboard.FromName("Main", null);

            //  var controller = storyboard.InstantiateViewController("DetailPersonVC") as DetailPersonVC;
            //  datatopass = yourlistofdata[tag]; Here I Will pass the data to the controller  -

            /**
            var storyboard = UIStoryboard.FromName("Main", null);

            

            detailPVC = storyboard.InstantiateViewController(identifier: "DetailPersonVC") as DetailPersonVC;
            // navigationController?.pushViewController(destinationViewController, animated: true);

            detailPVC.NavigationController.PushViewController(detailPersonVC, true);


    **/

            owner.data = SelectedRow;
            owner.PerformSegue("showDetail", this);

        }
    }
}
