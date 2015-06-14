using System;

namespace VisionControl
{
  partial class VisionControl
  {
    ///////////////////////// START WIZARD GENERATED
    // cognex.wizard.globals.begin
    private const string mVppFilename = @"C:\Documents and Settings\Orlin\Desktop\Rapak\QuickBuild1.vpp";
    private const string mApplicationName = "Check-In 4.0";
    private static bool mUsePasswords = true;
    private static bool mQuickBuildAccess = true;
    private const string mDefaultAdministratorPassword = "123456";
    private const string mDefaultSupervisorPassword = "123";
    private static DateTime mGenerationDateTime = new DateTime(2013,9,19,12,47,49);
    private static string mGeneratedByVersion = "45.0.0.0";
    // cognex.wizard.globals.end
    ///////////////////////// END WIZARD GENERATED

    private void Wizard_FormLoad()
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.formloadactions
      cogToolPropertyProvider0.ErrorProvider = applicationErrorProvider;
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_GlandSealRadiusMm, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool12\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].CurrentValue");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_hiMm, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool12\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectHighLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_lowMm, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool12\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectLowLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_GlandPositionXMm, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool12\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 1\"].CurrentValue");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_hiMm_1, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool12\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 1\"].RejectHighLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_lowMm_1, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool12\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 1\"].RejectLowLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_HorisontalSeal2Mm, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool11\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 1\"].CurrentValue");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_hiMm_2, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool11\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 1\"].RejectHighLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_lowMm_2, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool11\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 1\"].RejectLowLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_HorisontalSeal1Mm, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool11\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].CurrentValue");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_hiMm_3, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool11\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectHighLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_lowMm_3, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool11\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectLowLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_LeftVerticalSealMm, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).Results.Item[\"Channel 0\"].CurrentValue");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_hiMm_4, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectHighLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider0, textBox_Job0_lowMm_4, mJM.Job(0).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectLowLimit");
      cogToolPropertyProvider1.ErrorProvider = applicationErrorProvider;
      Utility.SetupPropertyProvider(cogToolPropertyProvider1, textBox_Job1_RightVerticalSealMm, mJM.Job(1).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].CurrentValue");
      Utility.SetupPropertyProvider(cogToolPropertyProvider1, textBox_Job1_hiMm, mJM.Job(1).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectHighLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider1, textBox_Job1_lowMm, mJM.Job(1).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectLowLimit");
      cogToolPropertyProvider2.ErrorProvider = applicationErrorProvider;
      Utility.SetupPropertyProvider(cogToolPropertyProvider2, textBox_Job2_GlandHighMm, mJM.Job(2).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].CurrentValue");
      Utility.SetupPropertyProvider(cogToolPropertyProvider2, textBox_Job2_hiMm, mJM.Job(2).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectHighLimit");
      Utility.SetupPropertyProvider(cogToolPropertyProvider2, textBox_Job2_lowMm, mJM.Job(2).VisionTool, "Tools.Item[\"CogDataAnalysisTool1\"].(Cognex.VisionPro.CogDataAnalysisTool).RunParams.Item[\"Channel 0\"].RejectLowLimit");
      this.tabPage_Job2_BagInspection3.Tag = "Supervisor";
      // end cognex.wizard.formloadactions
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_AttachPropertyProviders()
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.attachpropertyproviders
      cogToolPropertyProvider0.Subject = mJM.Job(0).VisionTool;
      cogToolPropertyProvider1.Subject = mJM.Job(1).VisionTool;
      cogToolPropertyProvider2.Subject = mJM.Job(2).VisionTool;
      // end cognex.wizard.attachpropertyproviders
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_DetachPropertyProviders()
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.detachpropertyproviders
      cogToolPropertyProvider0.Subject = null;
      cogToolPropertyProvider1.Subject = null;
      cogToolPropertyProvider2.Subject = null;
      // end cognex.wizard.detachpropertyproviders
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_EnableControls(bool running)
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.enablecontrols
      textBox_Job0_GlandSealRadiusMm.Enabled = ! running;
      textBox_Job0_hiMm.Enabled = ! running;
      textBox_Job0_lowMm.Enabled = ! running;
      textBox_Job0_GlandPositionXMm.Enabled = ! running;
      textBox_Job0_hiMm_1.Enabled = ! running;
      textBox_Job0_lowMm_1.Enabled = ! running;
      textBox_Job0_HorisontalSeal2Mm.Enabled = ! running;
      textBox_Job0_hiMm_2.Enabled = ! running;
      textBox_Job0_lowMm_2.Enabled = ! running;
      textBox_Job0_HorisontalSeal1Mm.Enabled = ! running;
      textBox_Job0_hiMm_3.Enabled = ! running;
      textBox_Job0_lowMm_3.Enabled = ! running;
      textBox_Job0_LeftVerticalSealMm.Enabled = ! running;
      textBox_Job0_hiMm_4.Enabled = ! running;
      textBox_Job0_lowMm_4.Enabled = ! running;
      textBox_Job1_RightVerticalSealMm.Enabled = ! running;
      textBox_Job1_hiMm.Enabled = ! running;
      textBox_Job1_lowMm.Enabled = ! running;
      textBox_Job2_GlandHighMm.Enabled = ! running;
      textBox_Job2_hiMm.Enabled = ! running;
      textBox_Job2_lowMm.Enabled = ! running;
      // end cognex.wizard.enablecontrols
      ///////////////////////// END WIZARD GENERATED
    }

    private void Wizard_AddJobTabs(System.Collections.ArrayList newPagesList)
    {
      ///////////////////////// START WIZARD GENERATED
      // begin cognex.wizard.addjobtabs
      switch (mSelectedJob)
      {
        case 0:
          newPagesList.Add(tabPage_Job0_BagInspection1);
          break;
        case 1:
          newPagesList.Add(tabPage_Job1_BagInspection2);
          break;
        case 2:
          newPagesList.Add(tabPage_Job2_BagInspection3);
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
