using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MapsHistory
{
    public partial class LocationHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
       
         //   Response.Write(activity.getActivity());
        }

        public void CallActivitymethod()
        {
            Activity activity = new Activity();
            activity.getActivity();
            List<string> listOfActivites = activity.getActivityTypes();
        }


        protected void UploadButton_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Data/");
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists. Create it.
                Directory.CreateDirectory(folderPath);
            }
            string filename = Path.GetFileName(FileUploadControl.FileName);
            FileUploadControl.SaveAs(folderPath + Path.GetFileName(FileUploadControl.FileName));
            lblStatus.Text = Path.GetFileName(FileUploadControl.FileName) + " has been uploaded.";




        }


    }
}