using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;  // 表的命名空间
using System.Data.SqlClient;    // 和SQL相关的命名空间
using NXOpen;
using NXOpen.UF;
using System.Windows.Forms;
using MainProject.Utils;
using MainProject.Forms;

namespace MainProject
{

    public class Program
    {
        // class members
        public static Session theSession;
        public static UI theUI;
        public static UFSession theUfSession;
        public static Program theProgram;
        public static bool isDisposeCalled;
        //------------------------------------------------------------------------------
        // Constructor
        //------------------------------------------------------------------------------
        public Program()
        {
            try
            {
                theSession = Session.GetSession();
                theUI = UI.GetUI();
                theUfSession = UFSession.GetUFSession();
                isDisposeCalled = false;
            }
            catch (NXOpen.NXException ex)
            {
                // ---- Enter your exception handling code here -----
                // UI.GetUI().NXMessageBox.Show("Message", NXMessageBox.DialogType.Error, ex.Message);
            }
        }

        //------------------------------------------------------------------------------
        //  Explicit Activation
        //      This entry point is used to activate the application explicitly
        //------------------------------------------------------------------------------
        public static int Main(string[] args)
        {
            int retValue = 0;
            try
            {
                DateTime now = DateTime.Now;
                DateTime dateTime = new DateTime(2024, 9, 30);
                //if (DateTime.Compare(now, dateTime) > 0)
                {
                //    MessageBox.Show("程序已过期，请联系管理员！","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    //HZH_Controls.Forms.FrmTips.ShowTipsError(new Form(), "程序已过期，请联系管理员！");
                    //HZH_Controls.Forms.FrmTips.ShowTips().Show("Error", NXMessageBox.DialogType.Error, "程序已过期，请联系管理员！");
                //    return retValue;
                }
                /*
                 * 
                 * 
                 * 
                DateTime now = DateTime.Now;
                int day = now.Day;
                int dayOfYear = now.DayOfYear;
                int year = now.Year;
                if (year == 2023)
                {
                    if (dayOfYear > 300)
                        return retValue;
                }
                else { return retValue; }
                */
                theProgram = new Program();
                Application.Run(new Form2());
                //LiteDBUtils.insertDate();
                //string filename = "@DB/00002222/A";
                //string part_type = null;
                //string template_name = null;
                //int response = 0;
                //theUfSession.Ui.UgmgrAskCreatePartFileName(out filename, out part_type, out template_name, out response);
                //string connStr = "Data Source = PLM ; Database = dangan1;User Id = admin; Password = admin";
                //SqlConnection SqlCon = new SqlConnection(connStr.ToString());
                // 打开数据库
                //SqlCon.Open();
                //SqlCon.Close()
                //;
                //bool isConn = ADOUtils.ConnDB(connStr);
                //theUfSession.Ugmgr.AssignPartNumber()

                // ADOUtils.SelectStudentInfo();

                //TODO: Add your application code here 
                //theUI.NXMessageBox.Show("test", NXMessageBox.DialogType.Information, isConn+"");
                //System.Console.WriteLine(isConn);
                //PartLoadStatus p_status;
                //theSession.DeleteAllUndoMarks();
                //theSession.Parts.LoadOptions.ComponentsToLoad = NXOpen.LoadOptions.LoadComponents.All;
                //System.Console.WriteLine(theSession.GetEnvironmentVariableValue("UGII_ROOT_DIR"));
                //Part openpart = theSession.Parts.OpenDisplay("C:\\Temp\\model4.prt", out p_status);
                //System.Console.WriteLine(openpart.Name);
                theProgram.Dispose();
            }
            catch (NXOpen.NXException ex)
            {
                // ---- Enter your exception handling code here -----

            }
            return retValue;
        }

        //------------------------------------------------------------------------------
        // Following method disposes all the class members
        //------------------------------------------------------------------------------
        public void Dispose()
        {
            try
            {
                if (isDisposeCalled == false)
                {
                    //TODO: Add your application code here 
                }
                isDisposeCalled = true;
            }
            catch (NXOpen.NXException ex)
            {
                // ---- Enter your exception handling code here -----

            }
        }

    

        public static int GetUnloadOption(string arg)
        {
            //Unloads the image explicitly, via an unload dialog
            //return System.Convert.ToInt32(Session.LibraryUnloadOption.Explicitly);

            //Unloads the image immediately after execution within NX
             return System.Convert.ToInt32(Session.LibraryUnloadOption.Immediately);

            //Unloads the image when the NX session terminates
            //return System.Convert.ToInt32(Session.LibraryUnloadOption.AtTermination);
        }
    }
}
