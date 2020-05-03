namespace subiect1
{
    partial class RegisterForm
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
            this.cb_accessPackage = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.nm_numberOfPasses = new System.Windows.Forms.NumericUpDown();
            this.tb_companyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back_manager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nm_numberOfPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_accessPackage
            // 
            this.cb_accessPackage.FormattingEnabled = true;
            this.cb_accessPackage.Location = new System.Drawing.Point(155, 60);
            this.cb_accessPackage.Name = "cb_accessPackage";
            this.cb_accessPackage.Size = new System.Drawing.Size(185, 21);
            this.cb_accessPackage.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 109);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(328, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // nm_numberOfPasses
            // 
            this.nm_numberOfPasses.Location = new System.Drawing.Point(12, 61);
            this.nm_numberOfPasses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_numberOfPasses.Name = "nm_numberOfPasses";
            this.nm_numberOfPasses.Size = new System.Drawing.Size(52, 20);
            this.nm_numberOfPasses.TabIndex = 1;
            this.nm_numberOfPasses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_companyName
            // 
            this.tb_companyName.Location = new System.Drawing.Point(12, 22);
            this.tb_companyName.Name = "tb_companyName";
            this.tb_companyName.Size = new System.Drawing.Size(328, 20);
            this.tb_companyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number Of Passes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Access Package";
            // 
            // back_manager
            // 
            this.back_manager.Location = new System.Drawing.Point(12, 158);
            this.back_manager.Name = "back_manager";
            this.back_manager.Size = new System.Drawing.Size(328, 23);
            this.back_manager.TabIndex = 7;
            this.back_manager.Text = "Back to Manager";
            this.back_manager.UseVisualStyleBackColor = true;
            this.back_manager.Click += new System.EventHandler(this.back_manager_Click);
            // 
            // RegisterForm
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
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cb_accessPackage);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.nm_numberOfPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_accessPackage;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.NumericUpDown nm_numberOfPasses;
        private System.Windows.Forms.TextBox tb_companyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_manager;
    }
}