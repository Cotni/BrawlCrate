﻿using BrawlLib.SSBB.ResourceNodes;
using BrawlLib.SSBB.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BrawlCrate.UI
{
    public unsafe class AdvancedCollisionEditor : CollisionEditor
    {
        protected override bool ErrorChecking => false;

        #region Designer

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
            if (disposing)
            {
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        // Advanced collision type selectors
        private GroupBox groupBoxType;
        private CheckBox chkTypeFloor;
        private CheckBox chkTypeCeiling;
        private CheckBox chkTypeLeftWall;
        private CheckBox chkTypeRightWall;

        ///// <summary> 
        ///// Required method for Designer support - do not modify 
        ///// the contents of this method with the code editor.
        ///// </summary>
        //private new void InitializeComponent()
        //{
        //    components = new System.ComponentModel.Container();

        //    // Advanced floor editor
        //    groupBoxType = new System.Windows.Forms.GroupBox();
        //    chkTypeFloor = new System.Windows.Forms.CheckBox();
        //    chkTypeCeiling = new System.Windows.Forms.CheckBox();
        //    chkTypeLeftWall = new System.Windows.Forms.CheckBox();
        //    chkTypeRightWall = new System.Windows.Forms.CheckBox();

        //    pnlPlaneProps.SuspendLayout();
        //    groupBoxType.SuspendLayout();

        //    // 
        //    // panel3
        //    // 
        //    panel3.Controls.Clear();
        //    panel3.Controls.Add(pnlPlaneProps);
        //    panel3.Controls.Add(pnlPointProps);
        //    panel3.Controls.Add(pnlObjProps);
        //    panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
        //    panel3.Location = new System.Drawing.Point(0, 82);
        //    panel3.Name = "panel3";
        //    panel3.Size = new System.Drawing.Size(209, 115);
        //    panel3.TabIndex = 16;
        //    // 
        //    // pnlPlaneProps
        //    // 
        //    pnlPlaneProps.Controls.Clear();
        //    pnlPlaneProps.Controls.Add(groupBoxFlags2);
        //    pnlPlaneProps.Controls.Add(groupBoxFlags1);
        //    pnlPlaneProps.Controls.Add(groupBoxTargets);
        //    pnlPlaneProps.Controls.Add(cboMaterial);
        //    pnlPlaneProps.Controls.Add(label5);
        //    pnlPlaneProps.Controls.Add(groupBoxType);
        //    pnlPlaneProps.Dock = System.Windows.Forms.DockStyle.Top;
        //    pnlPlaneProps.Location = new System.Drawing.Point(0, -199);
        //    pnlPlaneProps.Name = "pnlPlaneProps";
        //    pnlPlaneProps.Size = new System.Drawing.Size(209, 514);
        //    pnlPlaneProps.TabIndex = 0;
        //    pnlPlaneProps.Visible = false;
        //    // 
        //    // groupBoxType
        //    // 
        //    groupBoxType.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        //                           | System.Windows.Forms.AnchorStyles.Left);
        //    groupBoxType.Controls.Add(chkTypeFloor);
        //    groupBoxType.Controls.Add(chkTypeCeiling);
        //    groupBoxType.Controls.Add(chkTypeLeftWall);
        //    groupBoxType.Controls.Add(chkTypeRightWall);
        //    groupBoxType.Location = new System.Drawing.Point(0, 25);
        //    groupBoxType.Margin = new System.Windows.Forms.Padding(0);
        //    groupBoxType.Name = "groupBoxType";
        //    groupBoxType.Padding = new System.Windows.Forms.Padding(0);
        //    groupBoxType.Size = new System.Drawing.Size(208, 59);
        //    groupBoxType.TabIndex = 14;
        //    groupBoxType.TabStop = false;
        //    groupBoxType.Text = "Type";
        //    // 
        //    // chkTypeFloor
        //    // 
        //    chkTypeFloor.Location = new System.Drawing.Point(8, 17);
        //    chkTypeFloor.Margin = new System.Windows.Forms.Padding(0);
        //    chkTypeFloor.Name = "chkTypeFloor";
        //    chkTypeFloor.Size = new System.Drawing.Size(86, 18);
        //    chkTypeFloor.TabIndex = 3;
        //    chkTypeFloor.Text = "Floor";
        //    chkTypeFloor.UseVisualStyleBackColor = true;
        //    chkTypeFloor.CheckedChanged += new System.EventHandler(chkTypeFloor_CheckedChanged);
        //    // 
        //    // chkTypeCeiling
        //    // 
        //    chkTypeCeiling.Location = new System.Drawing.Point(112, 17);
        //    chkTypeCeiling.Margin = new System.Windows.Forms.Padding(0);
        //    chkTypeCeiling.Name = "chkTypeCeiling";
        //    chkTypeCeiling.Size = new System.Drawing.Size(86, 18);
        //    chkTypeCeiling.TabIndex = 3;
        //    chkTypeCeiling.Text = "Ceiling";
        //    chkTypeCeiling.UseVisualStyleBackColor = true;
        //    chkTypeCeiling.CheckedChanged += new System.EventHandler(chkTypeCeiling_CheckedChanged);
        //    // 
        //    // chkTypeLeftWall
        //    // 
        //    chkTypeLeftWall.Location = new System.Drawing.Point(8, 33);
        //    chkTypeLeftWall.Margin = new System.Windows.Forms.Padding(0);
        //    chkTypeLeftWall.Name = "chkTypeLeftWall";
        //    chkTypeLeftWall.Size = new System.Drawing.Size(86, 18);
        //    chkTypeLeftWall.TabIndex = 3;
        //    chkTypeLeftWall.Text = "Left Wall";
        //    chkTypeLeftWall.UseVisualStyleBackColor = true;
        //    chkTypeLeftWall.CheckedChanged += new System.EventHandler(chkTypeLeftWall_CheckedChanged);
        //    // 
        //    // chkTypeRightWall
        //    // 
        //    chkTypeRightWall.Location = new System.Drawing.Point(112, 33);
        //    chkTypeRightWall.Margin = new System.Windows.Forms.Padding(0);
        //    chkTypeRightWall.Name = "chkTypeRightWall";
        //    chkTypeRightWall.Size = new System.Drawing.Size(86, 18);
        //    chkTypeRightWall.TabIndex = 3;
        //    chkTypeRightWall.Text = "Right Wall";
        //    chkTypeRightWall.UseVisualStyleBackColor = true;
        //    chkTypeRightWall.CheckedChanged += new System.EventHandler(chkTypeRightWall_CheckedChanged);
        //    // 
        //    // groupBoxFlags1
        //    // 
        //    groupBoxFlags1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        //                             | System.Windows.Forms.AnchorStyles.Left);
        //    groupBoxFlags1.Location = new System.Drawing.Point(0, 128);
        //    groupBoxFlags1.Name = "groupBoxFlags1";
        //    // 
        //    // groupBoxFlags2
        //    // 
        //    groupBoxFlags2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        //                             | System.Windows.Forms.AnchorStyles.Left);
        //    groupBoxFlags2.Location = new System.Drawing.Point(104, 128);
        //    groupBoxFlags2.Name = "groupBoxFlags2";
        //    // 
        //    // cboMaterial
        //    // 
        //    cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        //    cboMaterial.Location = new System.Drawing.Point(59, 4);
        //    cboMaterial.Name = "cboMaterial";
        //    cboMaterial.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)
        //                          | System.Windows.Forms.AnchorStyles.Left);
        //    // 
        //    // label5
        //    // 
        //    label5.Location = new System.Drawing.Point(0, 4);
        //    label5.Name = "label5";
        //    //
        //    // groupBoxTargets
        //    // 
        //    groupBoxTargets.Location = new System.Drawing.Point(0, 76);
        //    groupBoxTargets.Name = "groupBoxTargets";

        //    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //}

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private new void InitializeComponent()
		{
			components = new System.ComponentModel.Container();

			// Advanced floor editor
			groupBoxType = new GroupBox();
			chkTypeFloor = new CheckBox();
			chkTypeCeiling = new CheckBox();
			chkTypeLeftWall = new CheckBox();
			chkTypeRightWall = new CheckBox();

			selectedPlanePropsPanel.SuspendLayout();
			//pnlPlaneProps.SuspendLayout();
			groupBoxType.SuspendLayout();

			// 
			// selectedMenuPanel
			// 
			selectedMenuPanel.Controls.Clear();
			selectedMenuPanel.Controls.Add(selectedPlanePropsPanel);
			selectedMenuPanel.Controls.Add(selectedPointPropsPanel);
			selectedMenuPanel.Controls.Add(selectedObjPropsPanel);
			selectedMenuPanel.Dock = DockStyle.Bottom;
			selectedMenuPanel.Location = new System.Drawing.Point(0, 82);
			selectedMenuPanel.Name = "selectedMenuPanel";
			selectedMenuPanel.Size = new System.Drawing.Size(209, 115);
			selectedMenuPanel.TabIndex = 16;

			// 
			// pnlPlaneProps
			// 
			selectedPlanePropsPanel.Controls.Clear();
			
			selectedPlanePropsPanel.Controls.AddRange(new Control[]
			{
				selectedPlanePropsPanel_UnknownFlagsGroup,
				selectedPlanePropsPanel_AttributeFlagsGroup,
				selectedPlanePropsPanel_TargetGroup,
				selectedPlanePropsPanel_Material,
				selectedPlanePropsPanel_MaterialLabel,
				groupBoxType
			});
			selectedPlanePropsPanel.Dock = DockStyle.Top;
			selectedPlanePropsPanel.Location = new System.Drawing.Point(0, -199);
			selectedPlanePropsPanel.Name = "pnlPlaneProps";
			selectedPlanePropsPanel.Size = new System.Drawing.Size(209, 514);
			selectedPlanePropsPanel.TabIndex = 0;
			selectedPlanePropsPanel.Visible = false;
			// 
			// groupBoxType
			// 
			groupBoxType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			groupBoxType.Controls.Add(chkTypeFloor);
			groupBoxType.Controls.Add(chkTypeCeiling);
			groupBoxType.Controls.Add(chkTypeLeftWall);
			groupBoxType.Controls.Add(chkTypeRightWall);
			groupBoxType.Location = new System.Drawing.Point(0, 25);
			groupBoxType.Margin = new Padding(0);
			groupBoxType.Name = "groupBoxType";
			groupBoxType.Padding = new Padding(0);
			groupBoxType.Size = new System.Drawing.Size(208, 59);
			groupBoxType.TabIndex = 14;
			groupBoxType.TabStop = false;
			groupBoxType.Text = "Type";
			// 
			// chkTypeFloor
			// 
			chkTypeFloor.Location = new System.Drawing.Point(8, 17);
			chkTypeFloor.Margin = new Padding(0);
			chkTypeFloor.Name = "chkTypeFloor";
			chkTypeFloor.Size = new System.Drawing.Size(86, 18);
			chkTypeFloor.TabIndex = 3;
			chkTypeFloor.Text = "Floor";
			chkTypeFloor.UseVisualStyleBackColor = true;
			chkTypeFloor.CheckedChanged += new EventHandler(chkTypeFloor_CheckedChanged);
			// 
			// chkTypeCeiling
			// 
			chkTypeCeiling.Location = new System.Drawing.Point(112, 17);
			chkTypeCeiling.Margin = new Padding(0);
			chkTypeCeiling.Name = "chkTypeCeiling";
			chkTypeCeiling.Size = new System.Drawing.Size(86, 18);
			chkTypeCeiling.TabIndex = 3;
			chkTypeCeiling.Text = "Ceiling";
			chkTypeCeiling.UseVisualStyleBackColor = true;
			chkTypeCeiling.CheckedChanged += new EventHandler(chkTypeCeiling_CheckedChanged);
			// 
			// chkTypeLeftWall
			// 
			chkTypeLeftWall.Location = new System.Drawing.Point(8, 33);
			chkTypeLeftWall.Margin = new Padding(0);
			chkTypeLeftWall.Name = "chkTypeLeftWall";
			chkTypeLeftWall.Size = new System.Drawing.Size(86, 18);
			chkTypeLeftWall.TabIndex = 3;
			chkTypeLeftWall.Text = "Left Wall";
			chkTypeLeftWall.UseVisualStyleBackColor = true;
			chkTypeLeftWall.CheckedChanged += new EventHandler(chkTypeLeftWall_CheckedChanged);
			// 
			// chkTypeRightWall
			// 
			chkTypeRightWall.Location = new System.Drawing.Point(112, 33);
			chkTypeRightWall.Margin = new System.Windows.Forms.Padding(0);
			chkTypeRightWall.Name = "chkTypeRightWall";
			chkTypeRightWall.Size = new System.Drawing.Size(86, 18);
			chkTypeRightWall.TabIndex = 3;
			chkTypeRightWall.Text = "Right Wall";
			chkTypeRightWall.UseVisualStyleBackColor = true;
			chkTypeRightWall.CheckedChanged += new System.EventHandler(chkTypeRightWall_CheckedChanged);
			// 
			// selectedPlanePropsPanel_AttributeFlagsGroup
			// 
			selectedPlanePropsPanel_AttributeFlagsGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			selectedPlanePropsPanel_AttributeFlagsGroup.Location = new System.Drawing.Point(0, 128);
			selectedPlanePropsPanel_AttributeFlagsGroup.Name = "selectedPlanePropsPanel_AttributeFlagsGroup";
			// 
			// selectedPlanePropsPanel_AttributeFlagsGroup
			// 
			selectedPlanePropsPanel_UnknownFlagsGroup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			selectedPlanePropsPanel_UnknownFlagsGroup.Location = new System.Drawing.Point(104, 128);
			selectedPlanePropsPanel_UnknownFlagsGroup.Name = "selectedPlanePropsPanel_UnknownFlagsGroup";
			// 
			// selectedPlanePropsPanel_Material
			// 
			selectedPlanePropsPanel_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			selectedPlanePropsPanel_Material.Location = new System.Drawing.Point(59, 4);
			selectedPlanePropsPanel_Material.Name = "cboMaterial";
			selectedPlanePropsPanel_Material.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
			// 
			// selectedPlanePropsPanel_MaterialLabel
			// 
			selectedPlanePropsPanel_MaterialLabel.Location = new System.Drawing.Point(0, 4);
			selectedPlanePropsPanel_MaterialLabel.Name = "selectedPlanePropsPanel_MaterialLabel";
			//
			// selectedPlanePropsPanel_TargetGroup
			// 
			selectedPlanePropsPanel_TargetGroup.Location = new System.Drawing.Point(0, 76);
			selectedPlanePropsPanel_TargetGroup.Name = "selectedPlanePropsPanel_TargetGroup";

			AutoScaleMode = AutoScaleMode.Font;
		}

		private void chkTypeFloor_CheckedChanged(object sender, EventArgs e)
        {
            if (_updating)
            {
                return;
            }

            TargetNode.SignalPropertyChange();
            foreach (CollisionPlane p in _selectedPlanes)
            {
                p.IsFloor = chkTypeFloor.Checked;
            }
        }

        private void chkTypeCeiling_CheckedChanged(object sender, EventArgs e)
        {
            if (_updating)
            {
                return;
            }

            TargetNode.SignalPropertyChange();
            foreach (CollisionPlane p in _selectedPlanes)
            {
                p.IsCeiling = chkTypeCeiling.Checked;
            }
        }

        private void chkTypeLeftWall_CheckedChanged(object sender, EventArgs e)
        {
            if (_updating)
            {
                return;
            }

            TargetNode.SignalPropertyChange();
            foreach (CollisionPlane p in _selectedPlanes)
            {
                p.IsLeftWall = chkTypeLeftWall.Checked;
            }
        }

        private void chkTypeRightWall_CheckedChanged(object sender, EventArgs e)
        {
            if (_updating)
            {
                return;
            }

            TargetNode.SignalPropertyChange();
            foreach (CollisionPlane p in _selectedPlanes)
            {
                p.IsRightWall = chkTypeRightWall.Checked;
            }
        }

        #endregion

        #endregion

        public AdvancedCollisionEditor()
        {
            InitializeComponent();
			selectedPlanePropsPanel_Material.DataSource = getMaterials();
			//selectedPlanePropsPanel_Material.DataSource = CollisionTerrain.Terrains.ToList();
		}

		public override List<CollisionTerrain> getMaterials()
		{
			return CollisionTerrain.Terrains.ToList();
		}

		protected override void SelectionModified()
		{
			_selectedPlanes.Clear();
			foreach (CollisionLink l in _selectedLinks)
			{
				foreach (CollisionPlane p in l._members)
				{
					if (_selectedLinks.Contains(p._linkLeft) &&
						_selectedLinks.Contains(p._linkRight) &&
						!_selectedPlanes.Contains(p))
					{
						_selectedPlanes.Add(p);
					}
				}
			}


			//pnlPlaneProps.Visible = false;
			//pnlObjProps.Visible = false;
			//pnlPointProps.Visible = false;
			//panel3.Height = 0;

			selectedPlanePropsPanel.Visible =
			selectedObjPropsPanel.Visible =
			selectedPointPropsPanel.Visible = false;

			selectedMenuPanel.Height = 0;

			if (_selectedPlanes.Count > 0)
			{
				selectedPointPropsPanel.Visible = true;
				selectedPointPropsPanel.Dock = DockStyle.Top;
				selectedPlanePropsPanel.Visible = true;
				selectedPlanePropsPanel.BringToFront();
				selectedMenuPanel.Height = 275;

				//pnlPlaneProps.Visible = true;
				//panel3.Height = 230;
			}
			else if (_selectedLinks.Count == 1)
			{
				selectedPointPropsPanel.Visible = true;
				selectedMenuPanel.Height = 70;

				//pnlPointProps.Visible = true;
				//panel3.Height = 70;
			}

			UpdatePropPanels();
		}

        //public override void UpdatePropPanels()
        //{
        //    _updating = true;

        //    if (pnlPlaneProps.Visible)
        //    {
        //        if (_selectedPlanes.Count <= 0)
        //        {
        //            pnlPlaneProps.Visible = false;
        //            return;
        //        }

        //        CollisionPlane p = _selectedPlanes[0];

        //        //Material
        //        cboMaterial.SelectedItem = cboMaterial.Items[p._material];
        //        //Type
        //        chkTypeFloor.Checked = p.IsFloor;
        //        chkTypeCeiling.Checked = p.IsCeiling;
        //        chkTypeLeftWall.Checked = p.IsLeftWall;
        //        chkTypeRightWall.Checked = p.IsRightWall;
        //        //Flags
        //        chkFallThrough.Checked = p.IsFallThrough;
        //        chkLeftLedge.Checked = p.IsLeftLedge;
        //        chkRightLedge.Checked = p.IsRightLedge;
        //        chkNoWalljump.Checked = p.IsNoWalljump;
        //        chkTypeCharacters.Checked = p.IsCharacters;
        //        chkTypeItems.Checked = p.IsItems;
        //        chkTypePokemonTrainer.Checked = p.IsPokemonTrainer;
        //        chkTypeRotating.Checked = p.IsRotating;
        //        //UnknownFlags
        //        chkFlagUnknown1.Checked = p.IsUnknownSSE;
        //        chkFlagUnknown2.Checked = p.IsUnknownFlag1;
        //        chkFlagSuperSoft.Checked = p.IsSuperSoft;
        //        chkFlagUnknown4.Checked = p.IsUnknownFlag4;
        //    }
        //    else if (pnlPointProps.Visible)
        //    {
        //        if (_selectedLinks.Count <= 0)
        //        {
        //            pnlPointProps.Visible = false;
        //            return;
        //        }

        //        numX.Value = _selectedLinks[0].Value._x;
        //        numY.Value = _selectedLinks[0].Value._y;
        //    }
        //    else if (pnlObjProps.Visible)
        //    {
        //        if (_selectedObject == null)
        //        {
        //            pnlObjProps.Visible = false;
        //            return;
        //        }

        //        txtModel.Text = _selectedObject._modelName;
        //        txtBone.Text = _selectedObject._boneName;
        //        chkObjUnk.Checked = _selectedObject.UnknownFlag;
        //        chkObjModule.Checked = _selectedObject.ModuleControlled;
        //        chkObjSSEUnk.Checked = _selectedObject.UnknownSSEFlag;
        //    }

        //    _updating = false;
        //}

		public override void UpdatePropPanels()
		{
			_updating = true;

			if (selectedPlanePropsPanel.Visible)
			{
				if (_selectedPlanes.Count <= 0)
				{
					selectedPointPropsPanel.Visible = _selectedLinks.Count > 0;
					selectedPlanePropsPanel.Visible = false;
					return;
				}

				CollisionPlane p = _selectedPlanes[0];
				
				// Material
				selectedPlanePropsPanel_Material.SelectedItem = selectedPlanePropsPanel_Material.Items[p._material];
				// Type
				chkTypeFloor.Checked = p.IsFloor;
				chkTypeCeiling.Checked = p.IsCeiling;
				chkTypeLeftWall.Checked = p.IsLeftWall;
				chkTypeRightWall.Checked = p.IsRightWall;
				// Flags
				AttributeFlagsGroup_PlnCheckFallThrough.Checked = p.IsFallThrough;
				AttributeFlagsGroup_PlnCheckLeftLedge.Checked = p.IsLeftLedge;
				AttributeFlagsGroup_PlnCheckRightLedge.Checked = p.IsRightLedge;
				AttributeFlagsGroup_PlnCheckNoWalljump.Checked = p.IsNoWalljump;
				AttributeFlagsGroup_PlnCheckRotating.Checked = p.IsRotating;
				TargetGroup_CheckEverything.Checked = p.IsCharacters;
				TargetGroup_CheckItems.Checked = p.IsItems;
				TargetGroup_CheckPKMNTrainer.Checked = p.IsPokemonTrainer;
				// Unknown Flags
				UnknownFlagsGroup_Check1.Checked = p.IsUnknownSSE;
				UnknownFlagsGroup_Check2.Checked = p.IsUnknownFlag1;
				UnknownFlagsGroup_SuperSoft.Checked = p.IsSuperSoft;
				UnknownFlagsGroup_Check4.Checked = p.IsUnknownFlag4;
			}
			else if (selectedPointPropsPanel.Visible)
			{
				if (_selectedLinks.Count <= 0)
				{
					selectedPointPropsPanel.Visible = false;
					return;
				}

				var value = _selectedLinks[0].Value;

				selectedPointPropsPanel_XValue.Value = value._x;
				selectedPointPropsPanel_YValue.Value = value._y;
			}
			else if (selectedObjPropsPanel.Visible)
			{
				if (_selectedObject == null)
				{
					selectedObjPropsPanel.Visible = false;
					return;
				}

				selectedObjPropsPanel_TextModel.Text = _selectedObject._modelName;
				selectedObjPropsPanel_TextBone.Text = _selectedObject._boneName;
				selectedObjPropsPanel_CheckUnknown.Checked = _selectedObject.UnknownFlag;
				selectedObjPropsPanel_CheckModuleControlled.Checked = _selectedObject.ModuleControlled;
				selectedObjPropsPanel_CheckSSEUnknown.Checked = _selectedObject.UnknownSSEFlag;
			}

			_updating = false;
		}
	}
}