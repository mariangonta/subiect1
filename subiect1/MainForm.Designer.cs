namespace subiect1
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
            this.btn_register = new System.Windows.Forms.Button();
            this.lv_registrations = new System.Windows.Forms.ListView();
            this.btn_deleteRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(657, 41);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lv_registrations
            // 
            this.lv_registrations.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_registrations.FullRowSelect = true;
            this.lv_registrations.GridLines = true;
            this.lv_registrations.Location = new System.Drawing.Point(12, 12);
            this.lv_registrations.MultiSelect = false;
            this.lv_registrations.Name = "lv_registrations";
            this.lv_registrations.Size = new System.Drawing.Size(595, 506);
            this.lv_registrations.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_registrations.TabIndex = 1;
            this.lv_registrations.UseCompatibleStateImageBehavior = false;
            this.lv_registrations.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lv_registrations_MouseClick);
            // 
            // btn_deleteRecord
            // 
            this.btn_deleteRecord.Location = new System.Drawing.Point(657, 96);
            this.btn_deleteRecord.Name = "btn_deleteRecord";
            this.btn_deleteRecord.Size = new System.Drawing.Size(75, 55);
            this.btn_deleteRecord.TabIndex = 2;
            this.btn_deleteRecord.Text = "Delete Selected Row";
            this.btn_deleteRecord.UseVisualStyleBackColor = true;
            this.btn_deleteRecord.Click += new System.EventHandler(this.lv_deleteRegistrations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 543);
            this.Controls.Add(this.btn_deleteRecord);
            this.Controls.Add(this.lv_registrations);
            this.Controls.Add(this.btn_register);
            this.Name = "MainForm";
            this.Text = "MainApp1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.ListView lv_registrations;
        private System.Windows.Forms.Button btn_deleteRecord;
    }
}

