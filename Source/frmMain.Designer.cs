using VisualThemeEditor2012.Domain;

namespace VisualThemeEditor2012
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.colorRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTheme = new System.Windows.Forms.ComboBox();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdSaveColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colorFG = new System.Windows.Forms.Button();
            this.colorBG = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.lblFG = new System.Windows.Forms.Label();
            this.lblBG = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lnkReset = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.colorRecordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRecords
            // 
            this.lstRecords.DataSource = this.colorRecordBindingSource;
            this.lstRecords.DisplayMember = "Name";
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.Location = new System.Drawing.Point(12, 113);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(200, 316);
            this.lstRecords.TabIndex = 0;
            this.lstRecords.SelectedValueChanged += new System.EventHandler(this.lstRecords_SelectedValueChanged);
            this.lstRecords.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingColor);
            // 
            // colorRecordBindingSource
            // 
            this.colorRecordBindingSource.DataSource = typeof(ColorRecord);
            this.colorRecordBindingSource.CurrentChanged += new System.EventHandler(this.colorRecordBindingSource_CurrentChanged);
            // 
            // cboTheme
            // 
            this.cboTheme.DataSource = this.themeBindingSource;
            this.cboTheme.DisplayMember = "Name";
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Location = new System.Drawing.Point(68, 13);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.Size = new System.Drawing.Size(144, 21);
            this.cboTheme.TabIndex = 1;
            this.cboTheme.SelectedValueChanged += new System.EventHandler(this.cboCategory_SelectedValueChanged);
            this.cboTheme.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingColor);
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataSource = typeof(Theme);
            this.themeBindingSource.PositionChanged += new System.EventHandler(this.themeBindingSource_PositionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theme:";
            // 
            // cboCategory
            // 
            this.cboCategory.DataSource = this.categoryBindingSource;
            this.cboCategory.DisplayMember = "Name";
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(68, 50);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(208, 21);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedValueChanged += new System.EventHandler(this.cboCategory_SelectedValueChanged);
            this.cboCategory.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingColor);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Category);
            this.categoryBindingSource.PositionChanged += new System.EventHandler(this.categoryBindingSource_PositionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Theme Records:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(230, 144);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(64, 13);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Foreground:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Background:";
            // 
            // cmdSaveColor
            // 
            this.cmdSaveColor.Enabled = false;
            this.cmdSaveColor.Location = new System.Drawing.Point(286, 229);
            this.cmdSaveColor.Name = "cmdSaveColor";
            this.cmdSaveColor.Size = new System.Drawing.Size(192, 40);
            this.cmdSaveColor.TabIndex = 11;
            this.cmdSaveColor.Text = "Save Color";
            this.cmdSaveColor.UseVisualStyleBackColor = true;
            this.cmdSaveColor.Click += new System.EventHandler(this.cmdSaveColor_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(230, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 46);
            this.label5.TabIndex = 12;
            this.label5.Text = "Note: You must save each color before moving onto the next. Please restart VS for" +
    " changes to take effect.";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(291, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 47);
            this.label6.TabIndex = 12;
            this.label6.Text = "Note: Most of VS window colors are in the \"Enviornment\" category.";
            // 
            // colorFG
            // 
            this.colorFG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorFG.Location = new System.Drawing.Point(233, 160);
            this.colorFG.Name = "colorFG";
            this.colorFG.Size = new System.Drawing.Size(119, 34);
            this.colorFG.TabIndex = 13;
            this.colorFG.UseVisualStyleBackColor = true;
            this.colorFG.BackColorChanged += new System.EventHandler(this.colorFG_BackColorChanged);
            this.colorFG.Click += new System.EventHandler(this.color_Click);
            // 
            // colorBG
            // 
            this.colorBG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorBG.Location = new System.Drawing.Point(383, 160);
            this.colorBG.Name = "colorBG";
            this.colorBG.Size = new System.Drawing.Size(119, 34);
            this.colorBG.TabIndex = 13;
            this.colorBG.UseVisualStyleBackColor = true;
            this.colorBG.BackColorChanged += new System.EventHandler(this.colorBG_BackColorChanged);
            this.colorBG.Click += new System.EventHandler(this.color_Click);
            // 
            // lblFG
            // 
            this.lblFG.AutoSize = true;
            this.lblFG.Location = new System.Drawing.Point(233, 201);
            this.lblFG.Name = "lblFG";
            this.lblFG.Size = new System.Drawing.Size(42, 13);
            this.lblFG.TabIndex = 14;
            this.lblFG.Text = "R, G, B";
            // 
            // lblBG
            // 
            this.lblBG.AutoSize = true;
            this.lblBG.Location = new System.Drawing.Point(380, 201);
            this.lblBG.Name = "lblBG";
            this.lblBG.Size = new System.Drawing.Size(42, 13);
            this.lblBG.TabIndex = 14;
            this.lblBG.Text = "R, G, B";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(230, 113);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(42, 13);
            this.lblRecord.TabIndex = 14;
            this.lblRecord.Text = "R, G, B";
            // 
            // lnkReset
            // 
            this.lnkReset.AutoSize = true;
            this.lnkReset.Location = new System.Drawing.Point(219, 13);
            this.lnkReset.Name = "lnkReset";
            this.lnkReset.Size = new System.Drawing.Size(71, 13);
            this.lnkReset.TabIndex = 15;
            this.lnkReset.TabStop = true;
            this.lnkReset.Text = "Reset Theme";
            this.lnkReset.Click += new System.EventHandler(this.lnkReset_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 445);
            this.Controls.Add(this.lnkReset);
            this.Controls.Add(this.lblBG);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblFG);
            this.Controls.Add(this.colorBG);
            this.Controls.Add(this.colorFG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdSaveColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.lstRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Studio 2012 Theme Editor";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.colorRecordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRecords;
        private System.Windows.Forms.ComboBox cboTheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource colorRecordBindingSource;
        private System.Windows.Forms.Button cmdSaveColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button colorFG;
        private System.Windows.Forms.Button colorBG;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Label lblFG;
        private System.Windows.Forms.Label lblBG;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.LinkLabel lnkReset;
    }
}

