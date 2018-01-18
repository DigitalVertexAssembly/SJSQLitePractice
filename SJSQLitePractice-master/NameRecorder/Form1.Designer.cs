namespace NameRecorder
{
    partial class Nrmain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("First Names");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Last Names");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Test Client");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Name Lists", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.buttonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectVoiceButton = new System.Windows.Forms.Button();
            this.selectKhzButton = new System.Windows.Forms.Button();
            this.selectedOptionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.activeVoiceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeSelectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeButtonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addListButton = new System.Windows.Forms.Button();
            this.editListButton = new System.Windows.Forms.Button();
            this.deleteListButton = new System.Windows.Forms.Button();
            this.mainViewPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLayoutPanel.SuspendLayout();
            this.selectedOptionsPanel.SuspendLayout();
            this.treeSelectionPanel.SuspendLayout();
            this.treeButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLayoutPanel
            // 
            this.buttonLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.buttonLayoutPanel.ColumnCount = 2;
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel.Controls.Add(this.selectVoiceButton, 0, 0);
            this.buttonLayoutPanel.Controls.Add(this.selectKhzButton, 1, 0);
            this.buttonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonLayoutPanel.Name = "buttonLayoutPanel";
            this.buttonLayoutPanel.RowCount = 1;
            this.buttonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayoutPanel.Size = new System.Drawing.Size(258, 100);
            this.buttonLayoutPanel.TabIndex = 0;
            // 
            // selectVoiceButton
            // 
            this.selectVoiceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectVoiceButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectVoiceButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.selectVoiceButton.Location = new System.Drawing.Point(6, 6);
            this.selectVoiceButton.Name = "selectVoiceButton";
            this.selectVoiceButton.Size = new System.Drawing.Size(118, 88);
            this.selectVoiceButton.TabIndex = 2;
            this.selectVoiceButton.Text = "Select Voice";
            this.selectVoiceButton.UseVisualStyleBackColor = true;
            this.selectVoiceButton.Click += new System.EventHandler(this.selectVoiceButton_Click);
            // 
            // selectKhzButton
            // 
            this.selectKhzButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectKhzButton.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectKhzButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.selectKhzButton.Location = new System.Drawing.Point(133, 6);
            this.selectKhzButton.Name = "selectKhzButton";
            this.selectKhzButton.Size = new System.Drawing.Size(119, 88);
            this.selectKhzButton.TabIndex = 3;
            this.selectKhzButton.Text = "Select kHz";
            this.selectKhzButton.UseVisualStyleBackColor = true;
            this.selectKhzButton.Click += new System.EventHandler(this.selectKhzButton_Click);
            // 
            // selectedOptionsPanel
            // 
            this.selectedOptionsPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectedOptionsPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selectedOptionsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.selectedOptionsPanel.ColumnCount = 2;
            this.selectedOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedOptionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedOptionsPanel.Controls.Add(this.activeVoiceLabel, 0, 0);
            this.selectedOptionsPanel.Controls.Add(this.label1, 1, 0);
            this.selectedOptionsPanel.Location = new System.Drawing.Point(258, 0);
            this.selectedOptionsPanel.Name = "selectedOptionsPanel";
            this.selectedOptionsPanel.RowCount = 1;
            this.selectedOptionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.selectedOptionsPanel.Size = new System.Drawing.Size(748, 100);
            this.selectedOptionsPanel.TabIndex = 1;
            // 
            // activeVoiceLabel
            // 
            this.activeVoiceLabel.AutoSize = true;
            this.activeVoiceLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.activeVoiceLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeVoiceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.activeVoiceLabel.Location = new System.Drawing.Point(6, 3);
            this.activeVoiceLabel.Name = "activeVoiceLabel";
            this.activeVoiceLabel.Size = new System.Drawing.Size(123, 94);
            this.activeVoiceLabel.TabIndex = 0;
            this.activeVoiceLabel.Text = "Active Voice:";
            this.activeVoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(378, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 94);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active kHz:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // treeSelectionPanel
            // 
            this.treeSelectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeSelectionPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.treeSelectionPanel.Controls.Add(this.treeView1);
            this.treeSelectionPanel.Controls.Add(this.treeButtonPanel);
            this.treeSelectionPanel.Location = new System.Drawing.Point(3, 103);
            this.treeSelectionPanel.Name = "treeSelectionPanel";
            this.treeSelectionPanel.Size = new System.Drawing.Size(252, 621);
            this.treeSelectionPanel.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "firstNames";
            treeNode1.Text = "First Names";
            treeNode2.Name = "lastNames";
            treeNode2.Text = "Last Names";
            treeNode3.Name = "testClient";
            treeNode3.Text = "Test Client";
            treeNode4.Name = "nameLists";
            treeNode4.Text = "Name Lists";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(244, 561);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeButtonPanel
            // 
            this.treeButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treeButtonPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeButtonPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.treeButtonPanel.ColumnCount = 3;
            this.treeButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.treeButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.treeButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.treeButtonPanel.Controls.Add(this.addListButton, 0, 0);
            this.treeButtonPanel.Controls.Add(this.editListButton, 1, 0);
            this.treeButtonPanel.Controls.Add(this.deleteListButton, 2, 0);
            this.treeButtonPanel.Location = new System.Drawing.Point(3, 570);
            this.treeButtonPanel.Name = "treeButtonPanel";
            this.treeButtonPanel.RowCount = 1;
            this.treeButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.treeButtonPanel.Size = new System.Drawing.Size(237, 39);
            this.treeButtonPanel.TabIndex = 1;
            // 
            // addListButton
            // 
            this.addListButton.Location = new System.Drawing.Point(6, 6);
            this.addListButton.Name = "addListButton";
            this.addListButton.Size = new System.Drawing.Size(68, 27);
            this.addListButton.TabIndex = 0;
            this.addListButton.Text = "Add List";
            this.addListButton.UseVisualStyleBackColor = true;
            this.addListButton.Click += new System.EventHandler(this.addListButton_Click);
            // 
            // editListButton
            // 
            this.editListButton.Location = new System.Drawing.Point(84, 6);
            this.editListButton.Name = "editListButton";
            this.editListButton.Size = new System.Drawing.Size(68, 27);
            this.editListButton.TabIndex = 1;
            this.editListButton.Text = "Edit List";
            this.editListButton.UseVisualStyleBackColor = true;
            this.editListButton.Click += new System.EventHandler(this.editListButton_Click);
            // 
            // deleteListButton
            // 
            this.deleteListButton.Location = new System.Drawing.Point(162, 6);
            this.deleteListButton.Name = "deleteListButton";
            this.deleteListButton.Size = new System.Drawing.Size(69, 27);
            this.deleteListButton.TabIndex = 2;
            this.deleteListButton.Text = "Delete List";
            this.deleteListButton.UseVisualStyleBackColor = true;
            this.deleteListButton.Click += new System.EventHandler(this.deleteListButton_Click);
            // 
            // mainViewPanel
            // 
            this.mainViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainViewPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainViewPanel.Location = new System.Drawing.Point(261, 106);
            this.mainViewPanel.Name = "mainViewPanel";
            this.mainViewPanel.Size = new System.Drawing.Size(745, 618);
            this.mainViewPanel.TabIndex = 3;
            // 
            // Nrmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 726);
            this.Controls.Add(this.mainViewPanel);
            this.Controls.Add(this.treeSelectionPanel);
            this.Controls.Add(this.selectedOptionsPanel);
            this.Controls.Add(this.buttonLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Nrmain";
            this.Text = "Name Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buttonLayoutPanel.ResumeLayout(false);
            this.selectedOptionsPanel.ResumeLayout(false);
            this.selectedOptionsPanel.PerformLayout();
            this.treeSelectionPanel.ResumeLayout(false);
            this.treeButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel buttonLayoutPanel;
        private System.Windows.Forms.Button selectVoiceButton;
        private System.Windows.Forms.Button selectKhzButton;
        private System.Windows.Forms.TableLayoutPanel selectedOptionsPanel;
        private System.Windows.Forms.Label activeVoiceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel treeSelectionPanel;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FlowLayoutPanel mainViewPanel;
        private System.Windows.Forms.TableLayoutPanel treeButtonPanel;
        private System.Windows.Forms.Button addListButton;
        private System.Windows.Forms.Button editListButton;
        private System.Windows.Forms.Button deleteListButton;
    }
}

