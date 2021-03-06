﻿namespace TMCWorkbench
{
    partial class UCComposers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ddlScenegroups = new System.Windows.Forms.ComboBox();
            this.btnAddScenegroup = new System.Windows.Forms.Button();
            this.chkIsComposer = new System.Windows.Forms.CheckBox();
            this.ctrAbout = new TMCWorkbench.Controls.Resettable.ResettableTextArea();
            this.ctrDateStop = new TMCWorkbench.Controls.Resettable.ResettableDate();
            this.ctrDateStart = new TMCWorkbench.Controls.Resettable.ResettableDate();
            this.ctrName = new TMCWorkbench.Controls.Resettable.ResettableText();
            this.ctrSave = new TMCWorkbench.Controls.Resettable.ResettableButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrAliases = new TMCWorkbench.Controls.Resettable.ResettableText();
            this.gridScenegroups = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddComposer = new System.Windows.Forms.Button();
            this.txtAddComposer = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelLeftBot = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanelLeftTop = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.gridComposers = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelDivider = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridScenegroups)).BeginInit();
            this.tableLayoutPanelLeftBot.SuspendLayout();
            this.tableLayoutPanelLeftTop.SuspendLayout();
            this.tableLayoutPanelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComposers)).BeginInit();
            this.tableLayoutPanelDivider.SuspendLayout();
            this.tableLayoutPanelRight.SuspendLayout();
            this.tableLayoutPanelOuter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.ddlScenegroups, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddScenegroup, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkIsComposer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 490);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 40);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ddlScenegroups
            // 
            this.ddlScenegroups.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ddlScenegroups.FormattingEnabled = true;
            this.ddlScenegroups.Location = new System.Drawing.Point(3, 16);
            this.ddlScenegroups.Name = "ddlScenegroups";
            this.ddlScenegroups.Size = new System.Drawing.Size(301, 21);
            this.ddlScenegroups.TabIndex = 3;
            // 
            // btnAddScenegroup
            // 
            this.btnAddScenegroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddScenegroup.Location = new System.Drawing.Point(345, 14);
            this.btnAddScenegroup.Name = "btnAddScenegroup";
            this.btnAddScenegroup.Size = new System.Drawing.Size(119, 23);
            this.btnAddScenegroup.TabIndex = 2;
            this.btnAddScenegroup.Text = "Add";
            this.btnAddScenegroup.UseVisualStyleBackColor = true;
            this.btnAddScenegroup.Click += new System.EventHandler(this.Handle_btnAddScenegroup_Click);
            // 
            // chkIsComposer
            // 
            this.chkIsComposer.AutoSize = true;
            this.chkIsComposer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkIsComposer.Location = new System.Drawing.Point(310, 20);
            this.chkIsComposer.Name = "chkIsComposer";
            this.chkIsComposer.Size = new System.Drawing.Size(14, 17);
            this.chkIsComposer.TabIndex = 4;
            this.chkIsComposer.Text = "checkBox1";
            this.chkIsComposer.UseVisualStyleBackColor = true;
            // 
            // ctrAbout
            // 
            this.ctrAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrAbout.LabelTitle = "About:";
            this.ctrAbout.Location = new System.Drawing.Point(0, 96);
            this.ctrAbout.Name = "ctrAbout";
            this.ctrAbout.Size = new System.Drawing.Size(461, 100);
            this.ctrAbout.TabIndex = 11;
            // 
            // ctrDateStop
            // 
            this.ctrDateStop.Date = new System.DateTime(((long)(0)));
            this.ctrDateStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrDateStop.LabelTitle = "Date stopped:";
            this.ctrDateStop.Location = new System.Drawing.Point(0, 72);
            this.ctrDateStop.Margin = new System.Windows.Forms.Padding(0);
            this.ctrDateStop.Name = "ctrDateStop";
            this.ctrDateStop.Original = null;
            this.ctrDateStop.Size = new System.Drawing.Size(461, 24);
            this.ctrDateStop.TabIndex = 10;
            // 
            // ctrDateStart
            // 
            this.ctrDateStart.Date = new System.DateTime(((long)(0)));
            this.ctrDateStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrDateStart.LabelTitle = "Date started:";
            this.ctrDateStart.Location = new System.Drawing.Point(0, 48);
            this.ctrDateStart.Margin = new System.Windows.Forms.Padding(0);
            this.ctrDateStart.Name = "ctrDateStart";
            this.ctrDateStart.Original = null;
            this.ctrDateStart.Size = new System.Drawing.Size(461, 24);
            this.ctrDateStart.TabIndex = 9;
            // 
            // ctrName
            // 
            this.ctrName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrName.LabelTitle = "Name:";
            this.ctrName.Location = new System.Drawing.Point(0, 0);
            this.ctrName.Margin = new System.Windows.Forms.Padding(0);
            this.ctrName.Name = "ctrName";
            this.ctrName.Original = null;
            this.ctrName.Size = new System.Drawing.Size(461, 24);
            this.ctrName.TabIndex = 8;
            // 
            // ctrSave
            // 
            this.ctrSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrSave.LabelTitle = "Save";
            this.ctrSave.Location = new System.Drawing.Point(0, 195);
            this.ctrSave.Margin = new System.Windows.Forms.Padding(0);
            this.ctrSave.Name = "ctrSave";
            this.ctrSave.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ctrSave.Size = new System.Drawing.Size(461, 24);
            this.ctrSave.TabIndex = 12;
            this.ctrSave.OnButtonClick += new System.EventHandler(this.Handle_ctrSave_OnButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctrAbout);
            this.panel1.Controls.Add(this.ctrDateStop);
            this.panel1.Controls.Add(this.ctrDateStart);
            this.panel1.Controls.Add(this.ctrAliases);
            this.panel1.Controls.Add(this.ctrName);
            this.panel1.Controls.Add(this.ctrSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 219);
            this.panel1.TabIndex = 2;
            // 
            // ctrAliases
            // 
            this.ctrAliases.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrAliases.LabelTitle = "Name:";
            this.ctrAliases.Location = new System.Drawing.Point(0, 24);
            this.ctrAliases.Margin = new System.Windows.Forms.Padding(0);
            this.ctrAliases.Name = "ctrAliases";
            this.ctrAliases.Original = null;
            this.ctrAliases.Size = new System.Drawing.Size(461, 24);
            this.ctrAliases.TabIndex = 13;
            // 
            // gridScenegroups
            // 
            this.gridScenegroups.AllowUserToAddRows = false;
            this.gridScenegroups.AllowUserToResizeRows = false;
            this.gridScenegroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridScenegroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridScenegroups.Location = new System.Drawing.Point(3, 258);
            this.gridScenegroups.Name = "gridScenegroups";
            this.gridScenegroups.ReadOnly = true;
            this.gridScenegroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridScenegroups.Size = new System.Drawing.Size(461, 229);
            this.gridScenegroups.TabIndex = 3;
            this.gridScenegroups.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Handle_gridScenegroups_KeyUp);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Member of scenegroups:";
            // 
            // btnAddComposer
            // 
            this.btnAddComposer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddComposer.Location = new System.Drawing.Point(351, 14);
            this.btnAddComposer.Name = "btnAddComposer";
            this.btnAddComposer.Size = new System.Drawing.Size(119, 23);
            this.btnAddComposer.TabIndex = 2;
            this.btnAddComposer.Text = "Add";
            this.btnAddComposer.UseVisualStyleBackColor = true;
            this.btnAddComposer.Click += new System.EventHandler(this.Handle_btnAddComposer_Click);
            // 
            // txtAddComposer
            // 
            this.txtAddComposer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAddComposer.Location = new System.Drawing.Point(3, 17);
            this.txtAddComposer.Name = "txtAddComposer";
            this.txtAddComposer.Size = new System.Drawing.Size(327, 20);
            this.txtAddComposer.TabIndex = 1;
            // 
            // tableLayoutPanelLeftBot
            // 
            this.tableLayoutPanelLeftBot.ColumnCount = 2;
            this.tableLayoutPanelLeftBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftBot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanelLeftBot.Controls.Add(this.btnAddComposer, 0, 0);
            this.tableLayoutPanelLeftBot.Controls.Add(this.txtAddComposer, 0, 0);
            this.tableLayoutPanelLeftBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftBot.Location = new System.Drawing.Point(0, 496);
            this.tableLayoutPanelLeftBot.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLeftBot.Name = "tableLayoutPanelLeftBot";
            this.tableLayoutPanelLeftBot.RowCount = 1;
            this.tableLayoutPanelLeftBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftBot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeftBot.Size = new System.Drawing.Size(473, 40);
            this.tableLayoutPanelLeftBot.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(351, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelLeftTop
            // 
            this.tableLayoutPanelLeftTop.ColumnCount = 2;
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanelLeftTop.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanelLeftTop.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeftTop.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLeftTop.Name = "tableLayoutPanelLeftTop";
            this.tableLayoutPanelLeftTop.RowCount = 1;
            this.tableLayoutPanelLeftTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftTop.Size = new System.Drawing.Size(473, 40);
            this.tableLayoutPanelLeftTop.TabIndex = 0;
            // 
            // tableLayoutPanelLeft
            // 
            this.tableLayoutPanelLeft.ColumnCount = 1;
            this.tableLayoutPanelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelLeftTop, 0, 0);
            this.tableLayoutPanelLeft.Controls.Add(this.tableLayoutPanelLeftBot, 0, 2);
            this.tableLayoutPanelLeft.Controls.Add(this.gridComposers, 0, 1);
            this.tableLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            this.tableLayoutPanelLeft.RowCount = 3;
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLeft.Size = new System.Drawing.Size(473, 536);
            this.tableLayoutPanelLeft.TabIndex = 0;
            // 
            // gridComposers
            // 
            this.gridComposers.AllowUserToAddRows = false;
            this.gridComposers.AllowUserToResizeRows = false;
            this.gridComposers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComposers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridComposers.Location = new System.Drawing.Point(3, 43);
            this.gridComposers.Name = "gridComposers";
            this.gridComposers.ReadOnly = true;
            this.gridComposers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridComposers.Size = new System.Drawing.Size(467, 450);
            this.gridComposers.TabIndex = 2;
            this.gridComposers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Handle_gridComposers_KeyUp);
            // 
            // tableLayoutPanelDivider
            // 
            this.tableLayoutPanelDivider.ColumnCount = 3;
            this.tableLayoutPanelDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDivider.Controls.Add(this.tableLayoutPanelLeft, 0, 0);
            this.tableLayoutPanelDivider.Controls.Add(this.tableLayoutPanelRight, 2, 0);
            this.tableLayoutPanelDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDivider.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanelDivider.Name = "tableLayoutPanelDivider";
            this.tableLayoutPanelDivider.RowCount = 1;
            this.tableLayoutPanelDivider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDivider.Size = new System.Drawing.Size(986, 536);
            this.tableLayoutPanelDivider.TabIndex = 0;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanelRight.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelRight.Controls.Add(this.gridScenegroups, 0, 2);
            this.tableLayoutPanelRight.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(516, 3);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 4;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(467, 530);
            this.tableLayoutPanelRight.TabIndex = 1;
            // 
            // tableLayoutPanelOuter
            // 
            this.tableLayoutPanelOuter.ColumnCount = 1;
            this.tableLayoutPanelOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOuter.Controls.Add(this.tableLayoutPanelDivider, 0, 0);
            this.tableLayoutPanelOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOuter.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelOuter.Name = "tableLayoutPanelOuter";
            this.tableLayoutPanelOuter.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanelOuter.RowCount = 1;
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 542F));
            this.tableLayoutPanelOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 542F));
            this.tableLayoutPanelOuter.Size = new System.Drawing.Size(1032, 582);
            this.tableLayoutPanelOuter.TabIndex = 1;
            // 
            // UCComposers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 582);
            this.Controls.Add(this.tableLayoutPanelOuter);
            this.Name = "UCComposers";
            this.Text = "UCComposers";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridScenegroups)).EndInit();
            this.tableLayoutPanelLeftBot.ResumeLayout(false);
            this.tableLayoutPanelLeftBot.PerformLayout();
            this.tableLayoutPanelLeftTop.ResumeLayout(false);
            this.tableLayoutPanelLeftTop.PerformLayout();
            this.tableLayoutPanelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridComposers)).EndInit();
            this.tableLayoutPanelDivider.ResumeLayout(false);
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanelRight.PerformLayout();
            this.tableLayoutPanelOuter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox ddlScenegroups;
        private System.Windows.Forms.Button btnAddScenegroup;
        private System.Windows.Forms.CheckBox chkIsComposer;
        private Controls.Resettable.ResettableTextArea ctrAbout;
        private Controls.Resettable.ResettableDate ctrDateStop;
        private Controls.Resettable.ResettableDate ctrDateStart;
        private Controls.Resettable.ResettableText ctrName;
        private Controls.Resettable.ResettableButton ctrSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridScenegroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddComposer;
        private System.Windows.Forms.TextBox txtAddComposer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftBot;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeft;
        private System.Windows.Forms.DataGridView gridComposers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDivider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOuter;
        private Controls.Resettable.ResettableText ctrAliases;
    }
}