namespace TestGithub.Module.Controllers
{
    partial class ViewController1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleAction1 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // simpleAction1
            // 
            this.simpleAction1.Caption = "Test";
            this.simpleAction1.Category = "Edit";
            this.simpleAction1.ConfirmationMessage = null;
            this.simpleAction1.Id = "5aae26cc-e8d6-483b-85e5-5248a0bfa897";
            this.simpleAction1.ImageName = "Action_Copy";
            this.simpleAction1.TargetObjectType = typeof(TestGithub.Module.BusinessObjects.TestGithub.Master);
            this.simpleAction1.ToolTip = null;
            // 
            // ViewController1
            // 
            this.Actions.Add(this.simpleAction1);
            this.TargetObjectType = typeof(TestGithub.Module.BusinessObjects.TestGithub.Master);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleAction1;
    }
}
