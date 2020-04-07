namespace JSONandAPIs
{
    partial class frmDemo
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
            this.btnGSMNPInfo = new System.Windows.Forms.Button();
            this.btnGSMNPAlerts = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtAlerts = new System.Windows.Forms.TextBox();
            this.tbcAPIMagic = new System.Windows.Forms.TabControl();
            this.tabNationalParks = new System.Windows.Forms.TabPage();
            this.tabSerialize = new System.Windows.Forms.TabPage();
            this.lblSerializeInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateTimePicked = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabDeserialize = new System.Windows.Forms.TabPage();
            this.lblDeserializeInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeserializeFileName = new System.Windows.Forms.TextBox();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.tbcAPIMagic.SuspendLayout();
            this.tabNationalParks.SuspendLayout();
            this.tabSerialize.SuspendLayout();
            this.tabDeserialize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGSMNPInfo
            // 
            this.btnGSMNPInfo.Location = new System.Drawing.Point(18, 245);
            this.btnGSMNPInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGSMNPInfo.Name = "btnGSMNPInfo";
            this.btnGSMNPInfo.Size = new System.Drawing.Size(284, 28);
            this.btnGSMNPInfo.TabIndex = 0;
            this.btnGSMNPInfo.Text = "Smokey Mountains National Park Info";
            this.btnGSMNPInfo.UseVisualStyleBackColor = true;
            this.btnGSMNPInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGSMNPAlerts
            // 
            this.btnGSMNPAlerts.Location = new System.Drawing.Point(15, 13);
            this.btnGSMNPAlerts.Margin = new System.Windows.Forms.Padding(4);
            this.btnGSMNPAlerts.Name = "btnGSMNPAlerts";
            this.btnGSMNPAlerts.Size = new System.Drawing.Size(284, 28);
            this.btnGSMNPAlerts.TabIndex = 1;
            this.btnGSMNPAlerts.Text = "Smokey Mountains National Park Alerts";
            this.btnGSMNPAlerts.UseVisualStyleBackColor = true;
            this.btnGSMNPAlerts.Click += new System.EventHandler(this.btnGSMNPAlerts_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(338, 245);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(697, 271);
            this.txtInfo.TabIndex = 2;
            // 
            // txtAlerts
            // 
            this.txtAlerts.Location = new System.Drawing.Point(338, 12);
            this.txtAlerts.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlerts.Multiline = true;
            this.txtAlerts.Name = "txtAlerts";
            this.txtAlerts.Size = new System.Drawing.Size(695, 219);
            this.txtAlerts.TabIndex = 3;
            // 
            // tbcAPIMagic
            // 
            this.tbcAPIMagic.Controls.Add(this.tabNationalParks);
            this.tbcAPIMagic.Controls.Add(this.tabSerialize);
            this.tbcAPIMagic.Controls.Add(this.tabDeserialize);
            this.tbcAPIMagic.Location = new System.Drawing.Point(12, 12);
            this.tbcAPIMagic.Name = "tbcAPIMagic";
            this.tbcAPIMagic.SelectedIndex = 0;
            this.tbcAPIMagic.Size = new System.Drawing.Size(1427, 824);
            this.tbcAPIMagic.TabIndex = 4;
            // 
            // tabNationalParks
            // 
            this.tabNationalParks.Controls.Add(this.btnGSMNPAlerts);
            this.tabNationalParks.Controls.Add(this.txtAlerts);
            this.tabNationalParks.Controls.Add(this.btnGSMNPInfo);
            this.tabNationalParks.Controls.Add(this.txtInfo);
            this.tabNationalParks.Location = new System.Drawing.Point(4, 25);
            this.tabNationalParks.Name = "tabNationalParks";
            this.tabNationalParks.Padding = new System.Windows.Forms.Padding(3);
            this.tabNationalParks.Size = new System.Drawing.Size(1419, 795);
            this.tabNationalParks.TabIndex = 0;
            this.tabNationalParks.Text = "National Parks";
            this.tabNationalParks.UseVisualStyleBackColor = true;
            // 
            // tabSerialize
            // 
            this.tabSerialize.Controls.Add(this.lblSerializeInfo);
            this.tabSerialize.Controls.Add(this.label5);
            this.tabSerialize.Controls.Add(this.label4);
            this.tabSerialize.Controls.Add(this.txtFileName);
            this.tabSerialize.Controls.Add(this.btnSerialize);
            this.tabSerialize.Controls.Add(this.label3);
            this.tabSerialize.Controls.Add(this.label2);
            this.tabSerialize.Controls.Add(this.label1);
            this.tabSerialize.Controls.Add(this.txtDateTimePicked);
            this.tabSerialize.Controls.Add(this.txtWeight);
            this.tabSerialize.Controls.Add(this.txtName);
            this.tabSerialize.Location = new System.Drawing.Point(4, 25);
            this.tabSerialize.Name = "tabSerialize";
            this.tabSerialize.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerialize.Size = new System.Drawing.Size(1419, 795);
            this.tabSerialize.TabIndex = 1;
            this.tabSerialize.Text = "Serialize";
            this.tabSerialize.UseVisualStyleBackColor = true;
            // 
            // lblSerializeInfo
            // 
            this.lblSerializeInfo.AutoSize = true;
            this.lblSerializeInfo.Location = new System.Drawing.Point(444, 290);
            this.lblSerializeInfo.Name = "lblSerializeInfo";
            this.lblSerializeInfo.Size = new System.Drawing.Size(0, 17);
            this.lblSerializeInfo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "(Double click for now)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(453, 199);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(209, 22);
            this.txtFileName.TabIndex = 7;
            this.txtFileName.Text = "Fruit.ser";
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(453, 239);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(75, 23);
            this.btnSerialize.TabIndex = 6;
            this.btnSerialize.Text = "Serialize";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date/Time Picked";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 104);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // txtDateTimePicked
            // 
            this.txtDateTimePicked.Location = new System.Drawing.Point(453, 155);
            this.txtDateTimePicked.Name = "txtDateTimePicked";
            this.txtDateTimePicked.Size = new System.Drawing.Size(209, 22);
            this.txtDateTimePicked.TabIndex = 2;
            this.txtDateTimePicked.DoubleClick += new System.EventHandler(this.txtDateTimePicked_DoubleClick);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(453, 104);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(209, 22);
            this.txtWeight.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(453, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(209, 22);
            this.txtName.TabIndex = 0;
            // 
            // tabDeserialize
            // 
            this.tabDeserialize.Controls.Add(this.lblDeserializeInfo);
            this.tabDeserialize.Controls.Add(this.label6);
            this.tabDeserialize.Controls.Add(this.txtDeserializeFileName);
            this.tabDeserialize.Controls.Add(this.btnDeserialize);
            this.tabDeserialize.Location = new System.Drawing.Point(4, 25);
            this.tabDeserialize.Name = "tabDeserialize";
            this.tabDeserialize.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeserialize.Size = new System.Drawing.Size(1419, 795);
            this.tabDeserialize.TabIndex = 2;
            this.tabDeserialize.Text = "Deserialize";
            this.tabDeserialize.UseVisualStyleBackColor = true;
            // 
            // lblDeserializeInfo
            // 
            this.lblDeserializeInfo.AutoSize = true;
            this.lblDeserializeInfo.Location = new System.Drawing.Point(482, 305);
            this.lblDeserializeInfo.Name = "lblDeserializeInfo";
            this.lblDeserializeInfo.Size = new System.Drawing.Size(0, 17);
            this.lblDeserializeInfo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "File Name";
            // 
            // txtDeserializeFileName
            // 
            this.txtDeserializeFileName.Location = new System.Drawing.Point(485, 188);
            this.txtDeserializeFileName.Name = "txtDeserializeFileName";
            this.txtDeserializeFileName.Size = new System.Drawing.Size(209, 22);
            this.txtDeserializeFileName.TabIndex = 15;
            this.txtDeserializeFileName.Text = "Fruit.ser";
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(485, 229);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(135, 33);
            this.btnDeserialize.TabIndex = 14;
            this.btnDeserialize.Text = "Deserialize";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 870);
            this.Controls.Add(this.tbcAPIMagic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDemo";
            this.Text = "JSON and APIs";
            this.tbcAPIMagic.ResumeLayout(false);
            this.tabNationalParks.ResumeLayout(false);
            this.tabNationalParks.PerformLayout();
            this.tabSerialize.ResumeLayout(false);
            this.tabSerialize.PerformLayout();
            this.tabDeserialize.ResumeLayout(false);
            this.tabDeserialize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGSMNPInfo;
        private System.Windows.Forms.Button btnGSMNPAlerts;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtAlerts;
        private System.Windows.Forms.TabControl tbcAPIMagic;
        private System.Windows.Forms.TabPage tabNationalParks;
        private System.Windows.Forms.TabPage tabSerialize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateTimePicked;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSerializeInfo;
        private System.Windows.Forms.TabPage tabDeserialize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeserializeFileName;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Label lblDeserializeInfo;
    }
}

