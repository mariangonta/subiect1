namespace subiect1
{
    partial class EditRegisterForm
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
            this.back_manager = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_companyName = new System.Windows.Forms.TextBox();
            this.nm_numberOfPasses = new System.Windows.Forms.NumericUpDown();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cb_accessPackage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nm_numberOfPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // back_manager
            // 
            this.back_manager.Location = new System.Drawing.Point(13, 160);
            this.back_manager.Name = "back_manager";
            this.back_manager.Size = new System.Drawing.Size(328, 23);
            this.back_manager.TabIndex = 15;
            this.back_manager.Text = "Back to Manager";
            this.back_manager.UseVisualStyleBackColor = true;
            this.back_manager.Click += new System.EventHandler(this.back_manager_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Access Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Number Of Passes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Company Name";
            // 
            // tb_companyName
            // 
            this.tb_companyName.Location = new System.Drawing.Point(13, 24);
            this.tb_companyName.Name = "tb_companyName";
            this.tb_companyName.Size = new System.Drawing.Size(328, 20);
            this.tb_companyName.TabIndex = 8;
            // 
            // nm_numberOfPasses
            // 
            this.nm_numberOfPasses.Location = new System.Drawing.Point(13, 63);
            this.nm_numberOfPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_numberOfPasses.Name = "nm_numberOfPasses";
            this.nm_numberOfPasses.Size = new System.Drawing.Size(52, 20);
            this.nm_numberOfPasses.TabIndex = 9;
            this.nm_numberOfPasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(13, 111);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(328, 23);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cb_accessPackage
            // 
            this.cb_accessPackage.FormattingEnabled = true;
            this.cb_accessPackage.Location = new System.Drawing.Point(156, 62);
            this.cb_accessPackage.Name = "cb_accessPackage";
            this.cb_accessPackage.Size = new System.Drawing.Size(185, 21);
            this.cb_accessPackage.TabIndex = 10;
            // 
            // EditRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 191);
            this.ControlBox = false;
            this.Controls.Add(this.back_manager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_companyName);
            this.Controls.Add(this.nm_numberOfPasses);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.cb_accessPackage);
            this.Name = "EditRegisterForm";
            this.Text = "Edit Register";
            ((System.ComponentModel.ISupportInitialize)(this.nm_numberOfPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_manager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_companyName;
        private System.Windows.Forms.NumericUpDown nm_numberOfPasses;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cb_accessPackage;
    }
}