using System;

namespace VisionControl
{
  partial class VisionControl
  {
    ///////////////////////// START WIZARD GENERATED
    // cognex.wizard.globals.begin
    private const string mVppFilename = @"C:\Users\Desktop\Project Guala\Checkin5.01\QuickBuild1.vpp";
    private const string mApplicationName = "Check-In 5.01";
    private static bool mUsePasswords = true;
    private static bool mQuickBuildAccess = true;
    private const string mDefaultAdministratorPassword = "123456";
    private const string mDefaultSupervisorPassword = "123";
    private static DateTime mGenerationDateTime = new DateTime(2014,9,8,10,37,17);
    private static string mGeneratedByVersion = "45.0.0.0";
    // cognex.wizard.globals.end
    ///////////////////////// END WIZARD GENERATED

    private void Wizard_FormLoad()
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.formloadactions
      this.tabPage_Job0_MailSettings.Tag = "Supervisor";
      this.tabPage_Job0_AddRemoveTeamMember.Tag = "Supervisor";
      this.tabPage_Job0_SupervisorControls.Tag = "Supervisor";
   
      // end cognex.wizard.formloadactions
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_AttachPropertyProviders()
    {
      ///////////////////////// START WIZARD GENERATED
      // cognex.wizard.attachpropertyproviders
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_DetachPropertyProviders()
    {
      ///////////////////////// START WIZARD GENERATED
      // cognex.wizard.detachpropertyproviders
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_EnableControls(bool running)
    {
      ///////////////////////// START WIZARD GENERATED
      // cognex.wizard.enablecontrols
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_AddJobTabs(System.Collections.ArrayList newPagesList)
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.addjobtabs
      switch (mSelectedJob)
      {
        case 0:
          newPagesList.Add(tabPage_Job0_MailSettings);
          newPagesList.Add(tabPage_Job0_AddRemoveTeamMember);
          newPagesList.Add(tabPage_Job0_SupervisorControls);
          break;
       

      }
      // end cognex.wizard.addjobtabs
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_UpdateJobResults(int idx, Cognex.VisionPro.ICogRecord result)
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.updatejobresults
      // end cognex.wizard.updatejobresults
      ///////////////////////// END WIZARD GENERATED
    }

  }
}
