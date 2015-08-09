namespace App
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Exit");
			Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab1 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbonGambling");
			Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup1 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroupGambling");
			Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Spin");
			Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool5 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Cheat");
			Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Exit");
			Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Spin");
			Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Cheat");
			Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
			this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
			this.MainForm_Fill_Panel = new Infragistics.Win.Misc.UltraPanel();
			this._MainForm_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
			this._MainForm_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
			this._MainForm_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
			this._MainForm_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
			this.labelNumber = new Infragistics.Win.Misc.UltraLabel();
			((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
			this.MainForm_Fill_Panel.ClientArea.SuspendLayout();
			this.MainForm_Fill_Panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraToolbarsManager1
			// 
			this.ultraToolbarsManager1.DesignerFlags = 1;
			this.ultraToolbarsManager1.DockWithinContainer = this;
			this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
			this.ultraToolbarsManager1.Office2007UICompatibility = false;
			this.ultraToolbarsManager1.Ribbon.ApplicationMenu2010.NavigationMenu.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1});
			this.ultraToolbarsManager1.Ribbon.FileMenuStyle = Infragistics.Win.UltraWinToolbars.FileMenuStyle.ApplicationMenu2010;
			ribbonTab1.Caption = "Gambling";
			ribbonGroup1.Caption = "Gambling";
			ribbonGroup1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool3,
            buttonTool5});
			ribbonTab1.Groups.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonGroup[] {
            ribbonGroup1});
			this.ultraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonTab[] {
            ribbonTab1});
			this.ultraToolbarsManager1.Ribbon.Visible = true;
			this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
			this.ultraToolbarsManager1.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.Office2013;
			buttonTool2.SharedPropsInternal.Caption = "Exit";
			buttonTool2.SharedPropsInternal.Category = "Application";
			buttonTool2.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			buttonTool4.SharedPropsInternal.Caption = "Spin";
			buttonTool4.SharedPropsInternal.Category = "Gambling";
			buttonTool4.SharedPropsInternal.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
			buttonTool6.SharedPropsInternal.Caption = "Cheat";
			buttonTool6.SharedPropsInternal.Category = "Gambling";
			this.ultraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool2,
            buttonTool4,
            buttonTool6});
			this.ultraToolbarsManager1.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
			// 
			// MainForm_Fill_Panel
			// 
			// 
			// MainForm_Fill_Panel.ClientArea
			// 
			this.MainForm_Fill_Panel.ClientArea.Controls.Add(this.labelNumber);
			this.MainForm_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
			this.MainForm_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainForm_Fill_Panel.Location = new System.Drawing.Point(1, 176);
			this.MainForm_Fill_Panel.Name = "MainForm_Fill_Panel";
			this.MainForm_Fill_Panel.Size = new System.Drawing.Size(787, 359);
			this.MainForm_Fill_Panel.TabIndex = 0;
			// 
			// _MainForm_Toolbars_Dock_Area_Left
			// 
			this._MainForm_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._MainForm_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
			this._MainForm_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
			this._MainForm_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 1;
			this._MainForm_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 176);
			this._MainForm_Toolbars_Dock_Area_Left.Name = "_MainForm_Toolbars_Dock_Area_Left";
			this._MainForm_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(1, 359);
			this._MainForm_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
			// 
			// _MainForm_Toolbars_Dock_Area_Right
			// 
			this._MainForm_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._MainForm_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
			this._MainForm_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
			this._MainForm_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 1;
			this._MainForm_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(788, 176);
			this._MainForm_Toolbars_Dock_Area_Right.Name = "_MainForm_Toolbars_Dock_Area_Right";
			this._MainForm_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(1, 359);
			this._MainForm_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
			// 
			// _MainForm_Toolbars_Dock_Area_Top
			// 
			this._MainForm_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._MainForm_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
			this._MainForm_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
			this._MainForm_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
			this._MainForm_Toolbars_Dock_Area_Top.Name = "_MainForm_Toolbars_Dock_Area_Top";
			this._MainForm_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(789, 176);
			this._MainForm_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
			// 
			// _MainForm_Toolbars_Dock_Area_Bottom
			// 
			this._MainForm_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
			this._MainForm_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this._MainForm_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
			this._MainForm_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
			this._MainForm_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 1;
			this._MainForm_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 535);
			this._MainForm_Toolbars_Dock_Area_Bottom.Name = "_MainForm_Toolbars_Dock_Area_Bottom";
			this._MainForm_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(789, 1);
			this._MainForm_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
			// 
			// labelNumber
			// 
			appearance1.TextHAlignAsString = "Center";
			appearance1.TextVAlignAsString = "Middle";
			this.labelNumber.Appearance = appearance1;
			this.labelNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNumber.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNumber.Location = new System.Drawing.Point(0, 0);
			this.labelNumber.Name = "labelNumber";
			this.labelNumber.Size = new System.Drawing.Size(787, 359);
			this.labelNumber.TabIndex = 0;
			this.labelNumber.Text = "Ready to spin!";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 536);
			this.Controls.Add(this.MainForm_Fill_Panel);
			this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Left);
			this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Right);
			this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Bottom);
			this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Top);
			this.Name = "MainForm";
			this.Text = "Roulette Wheel";
			((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
			this.MainForm_Fill_Panel.ClientArea.ResumeLayout(false);
			this.MainForm_Fill_Panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
		private Infragistics.Win.Misc.UltraPanel MainForm_Fill_Panel;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Left;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Right;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Bottom;
		private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Top;
		private Infragistics.Win.Misc.UltraLabel labelNumber;
	}
}

