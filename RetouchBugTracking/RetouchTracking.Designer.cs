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
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.cb_faultList = new System.Windows.Forms.ComboBox();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TSSL_userInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_bring = new System.Windows.Forms.DateTimePicker();
            this.btn_bring = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.TSSL_userInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_barcode
            // 
            this.tb_barcode.Location = new System.Drawing.Point(155, 38);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(134, 20);
            this.tb_barcode.TabIndex = 2;
            this.tb_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barcode_KeyDown);
            // 
            // cb_faultList
            // 
            this.cb_faultList.FormattingEnabled = true;
            this.cb_faultList.Location = new System.Drawing.Point(12, 38);
            this.cb_faultList.Name = "cb_faultList";
            this.cb_faultList.Size = new System.Drawing.Size(126, 21);
            this.cb_faultList.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(152, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hata Liste";
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
            this.label3.Location = new System.Drawing.Point(660, 12);
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
            this.label4.Location = new System.Drawing.Point(678, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // dtp_bring
            // 
            this.dtp_bring.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_bring.Location = new System.Drawing.Point(379, 38);
            this.dtp_bring.Name = "dtp_bring";
            this.dtp_bring.Size = new System.Drawing.Size(92, 20);
            this.dtp_bring.TabIndex = 8;
            // 
            // btn_bring
            // 
            this.btn_bring.Location = new System.Drawing.Point(603, 38);
            this.btn_bring.Name = "btn_bring";
            this.btn_bring.Size = new System.Drawing.Size(75, 23);
            this.btn_bring.TabIndex = 9;
            this.btn_bring.Text = "GETİR";
            this.btn_bring.UseVisualStyleBackColor = true;
            this.btn_bring.Click += new System.EventHandler(this.btn_bring_Click);
            // 
            // RetouchTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 613);
            this.Controls.Add(this.btn_bring);
            this.Controls.Add(this.dtp_bring);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.TSSL_userInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_list);
            this.Controls.Add(this.cb_faultList);
            this.Controls.Add(this.tb_barcode);
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
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.ComboBox cb_faultList;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip TSSL_userInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_bring;
        private System.Windows.Forms.Button btn_bring;
    }
}