namespace RetouchBugTracking
{
    partial class RetouchTracking
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
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.TSSL_userInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_bring = new System.Windows.Forms.DateTimePicker();
            this.dtp_productionDate = new System.Windows.Forms.DateTimePicker();
            this.cb_personelRecord = new System.Windows.Forms.ComboBox();
            this.cb_fault = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_bring = new System.Windows.Forms.Button();
            this.cbx_productionDate = new System.Windows.Forms.CheckBox();
            this.cbx_fault = new System.Windows.Forms.CheckBox();
            this.cbx_personal = new System.Windows.Forms.CheckBox();
            this.cbx_bring = new System.Windows.Forms.CheckBox();
            this.cb_productCode = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_productCode = new System.Windows.Forms.CheckBox();
            this.cbx_productionDateFinish = new System.Windows.Forms.CheckBox();
            this.dtp_productionDateFinish = new System.Windows.Forms.DateTimePicker();
            this.cbx_bringFnish = new System.Windows.Forms.CheckBox();
            this.dtp_bringFinish = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.TSSL_userInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_list
            // 
            this.dgv_list.AllowUserToAddRows = false;
            this.dgv_list.AllowUserToDeleteRows = false;
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(1, 139);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.ReadOnly = true;
            this.dgv_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list.Size = new System.Drawing.Size(877, 474);
            this.dgv_list.TabIndex = 3;
            this.dgv_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellClick);
            // 
            // TSSL_userInfo
            // 
            this.TSSL_userInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.TSSL_userInfo.Location = new System.Drawing.Point(0, 591);
            this.TSSL_userInfo.Name = "TSSL_userInfo";
            this.TSSL_userInfo.Size = new System.Drawing.Size(878, 22);
            this.TSSL_userInfo.TabIndex = 4;
            this.TSSL_userInfo.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(791, 110);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(330, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // dtp_bring
            // 
            this.dtp_bring.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_bring.Location = new System.Drawing.Point(114, 40);
            this.dtp_bring.Name = "dtp_bring";
            this.dtp_bring.Size = new System.Drawing.Size(87, 20);
            this.dtp_bring.TabIndex = 8;
            // 
            // dtp_productionDate
            // 
            this.dtp_productionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_productionDate.Location = new System.Drawing.Point(114, 13);
            this.dtp_productionDate.Name = "dtp_productionDate";
            this.dtp_productionDate.Size = new System.Drawing.Size(87, 20);
            this.dtp_productionDate.TabIndex = 0;
            // 
            // cb_personelRecord
            // 
            this.cb_personelRecord.FormattingEnabled = true;
            this.cb_personelRecord.Location = new System.Drawing.Point(114, 76);
            this.cb_personelRecord.Name = "cb_personelRecord";
            this.cb_personelRecord.Size = new System.Drawing.Size(87, 21);
            this.cb_personelRecord.TabIndex = 12;
            // 
            // cb_fault
            // 
            this.cb_fault.FormattingEnabled = true;
            this.cb_fault.Location = new System.Drawing.Point(318, 69);
            this.cb_fault.Name = "cb_fault";
            this.cb_fault.Size = new System.Drawing.Size(92, 21);
            this.cb_fault.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Döküm \r\nBaşlangıç Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kontrol \r\nBaşlangıç Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(48, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sicil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(247, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hata";
            // 
            // btn_bring
            // 
            this.btn_bring.Location = new System.Drawing.Point(647, 79);
            this.btn_bring.Name = "btn_bring";
            this.btn_bring.Size = new System.Drawing.Size(138, 54);
            this.btn_bring.TabIndex = 9;
            this.btn_bring.Text = "GETİR";
            this.btn_bring.UseVisualStyleBackColor = true;
            this.btn_bring.Click += new System.EventHandler(this.btn_bring_Click);
            // 
            // cbx_productionDate
            // 
            this.cbx_productionDate.AutoSize = true;
            this.cbx_productionDate.Location = new System.Drawing.Point(10, 15);
            this.cbx_productionDate.Name = "cbx_productionDate";
            this.cbx_productionDate.Size = new System.Drawing.Size(15, 14);
            this.cbx_productionDate.TabIndex = 15;
            this.cbx_productionDate.UseVisualStyleBackColor = true;
            // 
            // cbx_fault
            // 
            this.cbx_fault.AutoSize = true;
            this.cbx_fault.Location = new System.Drawing.Point(214, 76);
            this.cbx_fault.Name = "cbx_fault";
            this.cbx_fault.Size = new System.Drawing.Size(15, 14);
            this.cbx_fault.TabIndex = 16;
            this.cbx_fault.UseVisualStyleBackColor = true;
            // 
            // cbx_personal
            // 
            this.cbx_personal.AutoSize = true;
            this.cbx_personal.Location = new System.Drawing.Point(10, 79);
            this.cbx_personal.Name = "cbx_personal";
            this.cbx_personal.Size = new System.Drawing.Size(15, 14);
            this.cbx_personal.TabIndex = 17;
            this.cbx_personal.UseVisualStyleBackColor = true;
            // 
            // cbx_bring
            // 
            this.cbx_bring.AutoSize = true;
            this.cbx_bring.Location = new System.Drawing.Point(10, 41);
            this.cbx_bring.Name = "cbx_bring";
            this.cbx_bring.Size = new System.Drawing.Size(15, 14);
            this.cbx_bring.TabIndex = 18;
            this.cbx_bring.UseVisualStyleBackColor = true;
            // 
            // cb_productCode
            // 
            this.cb_productCode.FormattingEnabled = true;
            this.cb_productCode.Location = new System.Drawing.Point(114, 110);
            this.cb_productCode.Name = "cb_productCode";
            this.cb_productCode.Size = new System.Drawing.Size(87, 21);
            this.cb_productCode.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(48, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kod";
            // 
            // cbx_productCode
            // 
            this.cbx_productCode.AutoSize = true;
            this.cbx_productCode.Location = new System.Drawing.Point(10, 110);
            this.cbx_productCode.Name = "cbx_productCode";
            this.cbx_productCode.Size = new System.Drawing.Size(15, 14);
            this.cbx_productCode.TabIndex = 16;
            this.cbx_productCode.UseVisualStyleBackColor = true;
            // 
            // cbx_productionDateFinish
            // 
            this.cbx_productionDateFinish.AutoSize = true;
            this.cbx_productionDateFinish.Location = new System.Drawing.Point(214, 10);
            this.cbx_productionDateFinish.Name = "cbx_productionDateFinish";
            this.cbx_productionDateFinish.Size = new System.Drawing.Size(15, 14);
            this.cbx_productionDateFinish.TabIndex = 21;
            this.cbx_productionDateFinish.UseVisualStyleBackColor = true;
            // 
            // dtp_productionDateFinish
            // 
            this.dtp_productionDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_productionDateFinish.Location = new System.Drawing.Point(318, 10);
            this.dtp_productionDateFinish.Name = "dtp_productionDateFinish";
            this.dtp_productionDateFinish.Size = new System.Drawing.Size(92, 20);
            this.dtp_productionDateFinish.TabIndex = 19;
            // 
            // cbx_bringFnish
            // 
            this.cbx_bringFnish.AutoSize = true;
            this.cbx_bringFnish.Location = new System.Drawing.Point(214, 41);
            this.cbx_bringFnish.Name = "cbx_bringFnish";
            this.cbx_bringFnish.Size = new System.Drawing.Size(15, 14);
            this.cbx_bringFnish.TabIndex = 24;
            this.cbx_bringFnish.UseVisualStyleBackColor = true;
            // 
            // dtp_bringFinish
            // 
            this.dtp_bringFinish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_bringFinish.Location = new System.Drawing.Point(318, 41);
            this.dtp_bringFinish.Name = "dtp_bringFinish";
            this.dtp_bringFinish.Size = new System.Drawing.Size(92, 20);
            this.dtp_bringFinish.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(235, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Döküm \r\nBitiş Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(235, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kontrol \r\nBitiş Tarihi";
            // 
            // RetouchTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 613);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbx_bringFnish);
            this.Controls.Add(this.dtp_bringFinish);
            this.Controls.Add(this.cbx_productionDateFinish);
            this.Controls.Add(this.dtp_productionDateFinish);
            this.Controls.Add(this.cbx_bring);
            this.Controls.Add(this.cbx_personal);
            this.Controls.Add(this.cbx_productCode);
            this.Controls.Add(this.cbx_fault);
            this.Controls.Add(this.cbx_productionDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_bring);
            this.Controls.Add(this.dtp_bring);
            this.Controls.Add(this.dtp_productionDate);
            this.Controls.Add(this.cb_personelRecord);
            this.Controls.Add(this.cb_productCode);
            this.Controls.Add(this.cb_fault);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.TSSL_userInfo);
            this.Controls.Add(this.dgv_list);
            this.MaximumSize = new System.Drawing.Size(894, 652);
            this.MinimumSize = new System.Drawing.Size(894, 652);
            this.Name = "RetouchTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rötuş Takip";
            this.Load += new System.EventHandler(this.RetouchTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.TSSL_userInfo.ResumeLayout(false);
            this.TSSL_userInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.StatusStrip TSSL_userInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_bring;
        private System.Windows.Forms.DateTimePicker dtp_productionDate;
        private System.Windows.Forms.ComboBox cb_personelRecord;
        private System.Windows.Forms.ComboBox cb_fault;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_bring;
        private System.Windows.Forms.CheckBox cbx_productionDate;
        private System.Windows.Forms.CheckBox cbx_fault;
        private System.Windows.Forms.CheckBox cbx_personal;
        private System.Windows.Forms.CheckBox cbx_bring;
        private System.Windows.Forms.ComboBox cb_productCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbx_productCode;
        private System.Windows.Forms.CheckBox cbx_productionDateFinish;
        private System.Windows.Forms.DateTimePicker dtp_productionDateFinish;
        private System.Windows.Forms.CheckBox cbx_bringFnish;
        private System.Windows.Forms.DateTimePicker dtp_bringFinish;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}