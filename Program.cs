using Microsoft.VisualBasic;
using NXOpen;
using NXOpen.Assemblies;
using NXOpen.MenuBar;
using NXOpen.PDM;
using NXOpen.UF;
using System;
using System.Text;
using System.Windows.Forms;

namespace Eisenmann
{

    public class Program
    {
        public static Session theSession = (Session)null;
        public static UFSession theUFSession = (UFSession)null;
        public static ListingWindow lw = (ListingWindow)null;
        private static CustomPopupMenuHandler m_MenuHandler;
        private static UI theUI = UI.GetUI();
        public static bool isDisposeCalled;

        public static int ApplicationInit()
        {
            Program.lw.Open();
            Program.lw.WriteLine(" ");
            Program.lw.WriteLine("Inside My CSharp Init Callback");
            Program.lw.WriteLine(" ");
            return 0;
        }

        public static int ApplicationEnter()
        {
            Program.lw.Open();
            Program.lw.WriteLine(" ");
            Program.lw.WriteLine("Inside My CSharp Enter Callback");
            Program.lw.WriteLine(" ");
            return 0;
        }

        public static int ApplicationExit()
        {
            Program.lw.Open();
            Program.lw.WriteLine(" ");
            Program.lw.WriteLine("Inside My CSharp Exit Callback");
            Program.lw.WriteLine(" ");
            return 0;
        }

        public static MenuBarManager.CallbackStatus PrintApplicationIdCB(
          MenuButtonEvent buttonEvent)
        {
            Program.lw.Open();
            Program.lw.WriteLine(" ");
            Program.lw.WriteLine("Inside PrintApplicationIdCB Callback:");
            Program.lw.WriteLine("    Application Id: " + (object)buttonEvent.ApplicationId);
            Program.lw.WriteLine(" ");
            return (MenuBarManager.CallbackStatus)0;
        }

        public static MenuBarManager.CallbackStatus PrintButtonDataCB(
          MenuButtonEvent buttonEvent)
        {
            Program.lw.Open();
            Program.lw.WriteLine(" ");
            Program.lw.WriteLine("Inside My CS Callback:");
            Program.lw.WriteLine("    Button Id: " + (object)buttonEvent.ActiveButton.ButtonId);
            Program.lw.WriteLine("    Name: " + buttonEvent.ActiveButton.ButtonName);
            Program.lw.WriteLine("    Button type name: " + buttonEvent.ActiveButton.ButtonTypeName);
            Program.lw.WriteLine("    Menubar Name: " + buttonEvent.MenuBarName);
            Program.lw.WriteLine("    Application Id: " + (object)buttonEvent.ApplicationId);
            string[] menuAncestors = buttonEvent.GetMenuAncestors();
            for (int index = 0; index < menuAncestors.Length; ++index)
                Program.lw.WriteLine("    Ancestor[" + (object)index + "]: " + menuAncestors.GetValue(index));
            Program.lw.WriteLine(" ");
            return (MenuBarManager.CallbackStatus)0;
        }

        public static MenuBarManager.CallbackStatus PrintToggleStatusCB(
          MenuButtonEvent buttonEvent)
        {
            Program.lw.Open();
            Program.lw.WriteLine(" ");
            Program.lw.WriteLine("Inside PrintToggleStatusCB Callback:");
            if (buttonEvent.ActiveButton.ToggleStatus == 0)
                Program.lw.WriteLine("   The toggle is now ON");
            else
                Program.lw.WriteLine("   The toggle is now OFF");
            Program.lw.WriteLine(" ");
            return (MenuBarManager.CallbackStatus)0;
        }

        public static int Startup()
        {
            int num = 0;
            bool isUgMgr = false;
            try
            {
                if (Program.theSession == null)
                {
                    Program.theSession = Session.GetSession();
                    Program.theUFSession = UFSession.GetUFSession();
                    theUFSession.UF.IsUgmanagerActive(out isUgMgr);
                    if (!isUgMgr)
                        return 0;
                }
                if (Program.lw == null)
                    Program.lw = Program.theSession.ListingWindow;
                // ISSUE: method pointer
                Program.theUI.MenuBarManager.AddMenuAction("SAMPLE_CSHARP_APP__action3", new MenuBarManager.ActionCallback(PrintApplicationIdCB));
                // ISSUE: method pointer
                Program.theUI.MenuBarManager.AddMenuAction("SAMPLE_CSHARP_APP__action4", new MenuBarManager.ActionCallback(PrintButtonDataCB));
                
                // ISSUE: method pointer
                Program.theUI.MenuBarManager.AddMenuAction("EISENMANN_APP_PREOPENFILE", new MenuBarManager.ActionCallback(preOpenFileCB));
                Program.theUI.MenuBarManager.AddMenuAction("EISENMANN_APP_POSTOPENFILE", new MenuBarManager.ActionCallback(postOpenFileCB));
                // ISSUE: method pointer
                Program.theUI.MenuBarManager.RegisterConfigureContextMenuCallback("Eisenmann", "Eisenmann tools", new MenuBarManager.ConfigureContextMenu(CustomizeMenu));
            }
            catch (NXException ex)
            {
            }
            return num;
        }

        public static int CustomizeMenu(NXOpen.MenuBar.ContextMenu menu, NXOpen.MenuBar.ContextMenuProperties props)
        {
            try
            {
                MenuButton buttonFromName1 = Program.theUI.MenuBarManager.GetButtonFromName("SAMPLE_CSHARP_APP_BUTTON5");
                MenuButton buttonFromName2 = Program.theUI.MenuBarManager.GetButtonFromName("SAMPLE_CSHARP_APP_BUTTON6");
                if (props.Location.Equals("ANT"))
                {
                    NXOpen.MenuBar.ContextMenuEntry entryWithName = menu.GetEntryWithName("UGMGR_OPEN_RELATED_DRAWINGS");
                    menu.HideEntry(entryWithName);
                    menu.AddMenuButton(buttonFromName1, -1);
                    menu.AddMenuButton(buttonFromName2, -1);
                }
            }
            catch (NXException ex)
            {
            }
            return 0;
        }


        public static int GetUnloadOption(string arg) => Convert.ToInt32((object)(Session.LibraryUnloadOption)3);

        public static MenuBarManager.CallbackStatus postOpenFileCB(MenuButtonEvent buttonEvent)
        {
            NXOpen.Session theSession = NXOpen.Session.GetSession();
            NXOpen.Session.UndoMarkId markId1;
            markId1 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "起点");

            NXOpen.FileNew fileNew1;
            fileNew1 = theSession.Parts.FileNew();

            try
            {
                // 选定的模板不存在
                fileNew1.TemplateFileName = "空白";
            }
            catch (NXException ex)
            {
                ex.AssertErrorCode(3815003);
            }

            fileNew1.UseBlankTemplate = true;

            fileNew1.ApplicationName = "GatewayTemplate";

            fileNew1.Units = NXOpen.Part.Units.Millimeters;

            fileNew1.RelationType = "";

            fileNew1.UsesMasterModel = "No";

            fileNew1.TemplateType = NXOpen.FileNewTemplateType.Item;

            fileNew1.TemplatePresentationName = "";

            fileNew1.ItemType = "";

            fileNew1.Specialization = "";

            fileNew1.SetCanCreateAltrep(false);

            NXOpen.PDM.PartOperationCreateBuilder partOperationCreateBuilder1;
            partOperationCreateBuilder1 = theSession.PdmSession.CreateCreateOperationBuilder(NXOpen.PDM.PartOperationBuilder.OperationType.Create);

            fileNew1.SetPartOperationCreateBuilder(partOperationCreateBuilder1);

            partOperationCreateBuilder1.SetOperationSubType(NXOpen.PDM.PartOperationCreateBuilder.OperationSubType.SelectTemplate);

            partOperationCreateBuilder1.SetItemType("Item");

            partOperationCreateBuilder1.SetPartSpecToOpen(@"%UGMGR=V3.2 PH=wfnJq$Otp5esED PRH=wfrJq$Otp5esED PN=W32JL90101A PRN=A RT=""has shape"" AT=""UG master part file"" ");

            NXOpen.PDM.LogicalObject[] logicalobjects1;
            partOperationCreateBuilder1.CreateLogicalObjects(out logicalobjects1);

            NXOpen.NXObject[] sourceobjects1;
            sourceobjects1 = logicalobjects1[0].GetUserAttributeSourceObjects();

            partOperationCreateBuilder1.DefaultDestinationFolder = ":Newstuff";

            NXOpen.NXObject[] sourceobjects2;
            sourceobjects2 = logicalobjects1[0].GetUserAttributeSourceObjects();

            partOperationCreateBuilder1.SetOperationSubType(NXOpen.PDM.PartOperationCreateBuilder.OperationSubType.SelectTemplate);

            theSession.SetUndoMarkName(markId1, "选择模板部件 对话框");

            fileNew1.TemplateFileName = "@DB/model-plain-1-mm-template/A";

            fileNew1.UseBlankTemplate = false;

            fileNew1.ApplicationName = "ModelTemplate";

            fileNew1.Units = NXOpen.Part.Units.Millimeters;

            fileNew1.RelationType = "master";

            fileNew1.UsesMasterModel = "No";

            fileNew1.TemplateType = NXOpen.FileNewTemplateType.Item;

            fileNew1.TemplatePresentationName = "模型";

            fileNew1.ItemType = "Item";

            fileNew1.Specialization = "";

            fileNew1.SetCanCreateAltrep(false);

            partOperationCreateBuilder1.SetAddMaster(false);

            NXOpen.PDM.LogicalObject[] logicalobjects2;
            partOperationCreateBuilder1.CreateLogicalObjects(out logicalobjects2);

            NXOpen.Session.UndoMarkId markId2;
            markId2 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "选择模板部件");

            theSession.DeleteUndoMark(markId2, null);

            NXOpen.Session.UndoMarkId markId3;
            markId3 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "选择模板部件");

            fileNew1.MasterFileName = "";

            fileNew1.MakeDisplayedPart = false;

            fileNew1.DisplayPartOption = NXOpen.DisplayPartOption.AllowAdditional;

            partOperationCreateBuilder1.ValidateLogicalObjectsToCommit();

            NXOpen.PDM.LogicalObject[] logicalobjects3 = new NXOpen.PDM.LogicalObject[1];
            logicalobjects3[0] = logicalobjects1[0];
            partOperationCreateBuilder1.CreateSpecificationsForLogicalObjects(logicalobjects3);

            NXOpen.PDM.ErrorMessageHandler errorMessageHandler1;
            errorMessageHandler1 = partOperationCreateBuilder1.GetErrorMessageHandler(true);

            NXOpen.PDM.ErrorMessageHandler errorMessageHandler2;
            errorMessageHandler2 = partOperationCreateBuilder1.GetErrorMessageHandler(true);

            theSession.DeleteUndoMark(markId3, null);

            theSession.SetUndoMarkName(markId1, "选择模板部件");

            theSession.DeleteUndoMark(markId1, null);

            fileNew1.Destroy();
            return MenuBarManager.CallbackStatus.Continue;
        }

        public static MenuBarManager.CallbackStatus preOpenFileCB(MenuButtonEvent buttonEvent)
        {
            NXOpen.Session theSession = NXOpen.Session.GetSession();
            NXOpen.Session.UndoMarkId markId1;
            markId1 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "起点");

            NXOpen.FileNew fileNew1;
            fileNew1 = theSession.Parts.FileNew();

            try
            {
                // 选定的模板不存在
                fileNew1.TemplateFileName = "空白";
            }
            catch (NXException ex)
            {
                ex.AssertErrorCode(3815003);
            }

            fileNew1.UseBlankTemplate = true;

            fileNew1.ApplicationName = "GatewayTemplate";

            fileNew1.Units = NXOpen.Part.Units.Millimeters;

            fileNew1.RelationType = "";

            fileNew1.UsesMasterModel = "No";

            fileNew1.TemplateType = NXOpen.FileNewTemplateType.Item;

            fileNew1.TemplatePresentationName = "";

            fileNew1.ItemType = "";

            fileNew1.Specialization = "";

            fileNew1.SetCanCreateAltrep(false);

            NXOpen.PDM.PartOperationCreateBuilder partOperationCreateBuilder1;
            partOperationCreateBuilder1 = theSession.PdmSession.CreateCreateOperationBuilder(NXOpen.PDM.PartOperationBuilder.OperationType.Create);

            fileNew1.SetPartOperationCreateBuilder(partOperationCreateBuilder1);

            partOperationCreateBuilder1.SetOperationSubType(NXOpen.PDM.PartOperationCreateBuilder.OperationSubType.SelectTemplate);

            partOperationCreateBuilder1.SetItemType("Item");

            partOperationCreateBuilder1.SetPartSpecToOpen(@"%UGMGR=V3.2 PH=wfnJq$Otp5esED PRH=wfrJq$Otp5esED PN=W32JL90101A PRN=A RT=""has shape"" AT=""UG master part file"" ");

            NXOpen.PDM.LogicalObject[] logicalobjects1;
            partOperationCreateBuilder1.CreateLogicalObjects(out logicalobjects1);

            NXOpen.NXObject[] sourceobjects1;
            sourceobjects1 = logicalobjects1[0].GetUserAttributeSourceObjects();

            partOperationCreateBuilder1.DefaultDestinationFolder = ":Newstuff";

            NXOpen.NXObject[] sourceobjects2;
            sourceobjects2 = logicalobjects1[0].GetUserAttributeSourceObjects();

            partOperationCreateBuilder1.SetOperationSubType(NXOpen.PDM.PartOperationCreateBuilder.OperationSubType.SelectTemplate);

            theSession.SetUndoMarkName(markId1, "选择模板部件 对话框");

            fileNew1.TemplateFileName = "@DB/model-plain-1-mm-template/A";

            fileNew1.UseBlankTemplate = false;

            fileNew1.ApplicationName = "ModelTemplate";

            fileNew1.Units = NXOpen.Part.Units.Millimeters;

            fileNew1.RelationType = "master";

            fileNew1.UsesMasterModel = "No";

            fileNew1.TemplateType = NXOpen.FileNewTemplateType.Item;

            fileNew1.TemplatePresentationName = "模型";

            fileNew1.ItemType = "Item";

            fileNew1.Specialization = "";

            fileNew1.SetCanCreateAltrep(false);

            partOperationCreateBuilder1.SetAddMaster(false);

            NXOpen.PDM.LogicalObject[] logicalobjects2;
            partOperationCreateBuilder1.CreateLogicalObjects(out logicalobjects2);

            NXOpen.Session.UndoMarkId markId2;
            markId2 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "选择模板部件");

            theSession.DeleteUndoMark(markId2, null);

            NXOpen.Session.UndoMarkId markId3;
            markId3 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "选择模板部件");

            fileNew1.MasterFileName = "";

            fileNew1.MakeDisplayedPart = false;

            fileNew1.DisplayPartOption = NXOpen.DisplayPartOption.AllowAdditional;

            partOperationCreateBuilder1.ValidateLogicalObjectsToCommit();

            NXOpen.PDM.LogicalObject[] logicalobjects3 = new NXOpen.PDM.LogicalObject[1];
            logicalobjects3[0] = logicalobjects1[0];
            partOperationCreateBuilder1.CreateSpecificationsForLogicalObjects(logicalobjects3);

            NXOpen.PDM.ErrorMessageHandler errorMessageHandler1;
            errorMessageHandler1 = partOperationCreateBuilder1.GetErrorMessageHandler(true);

            NXOpen.PDM.ErrorMessageHandler errorMessageHandler2;
            errorMessageHandler2 = partOperationCreateBuilder1.GetErrorMessageHandler(true);

            theSession.DeleteUndoMark(markId3, null);

            theSession.SetUndoMarkName(markId1, "选择模板部件");

            theSession.DeleteUndoMark(markId1, null);

            fileNew1.Destroy();
            return MenuBarManager.CallbackStatus.Continue;
        }
    }
}