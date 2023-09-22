
namespace DemoTest
{
    partial class XtraForm1
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Get = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Supply = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Head = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Head = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Head.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(166, 178);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(128, 27);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // btn_Get
            // 
            this.btn_Get.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Get.Appearance.Options.UseFont = true;
            this.btn_Get.Location = new System.Drawing.Point(597, 170);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(182, 45);
            this.btn_Get.TabIndex = 1;
            this.btn_Get.Text = "获取最新";
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // btn_Supply
            // 
            this.btn_Supply.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Supply.Appearance.Options.UseFont = true;
            this.btn_Supply.Location = new System.Drawing.Point(597, 269);
            this.btn_Supply.Name = "btn_Supply";
            this.btn_Supply.Size = new System.Drawing.Size(182, 45);
            this.btn_Supply.TabIndex = 2;
            this.btn_Supply.Text = "补充数据";
            this.btn_Supply.Click += new System.EventHandler(this.btn_Supply_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(166, 277);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 27);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "labelControl2";
            // 
            // btn_Head
            // 
            this.btn_Head.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Head.Appearance.Options.UseFont = true;
            this.btn_Head.Location = new System.Drawing.Point(597, 65);
            this.btn_Head.Name = "btn_Head";
            this.btn_Head.Size = new System.Drawing.Size(182, 45);
            this.btn_Head.TabIndex = 4;
            this.btn_Head.Text = "根据头生成Key";
            this.btn_Head.Click += new System.EventHandler(this.btn_Head_Click);
            // 
            // txt_Head
            // 
            this.txt_Head.Location = new System.Drawing.Point(68, 84);
            this.txt_Head.Name = "txt_Head";
            this.txt_Head.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Head.Properties.Appearance.Options.UseFont = true;
            this.txt_Head.Size = new System.Drawing.Size(138, 26);
            this.txt_Head.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(252, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 27);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "labelControl3";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 397);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_Head);
            this.Controls.Add(this.btn_Head);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btn_Supply);
            this.Controls.Add(this.btn_Get);
            this.Controls.Add(this.labelControl1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.txt_Head.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Get;
        private DevExpress.XtraEditors.SimpleButton btn_Supply;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Head;
        private DevExpress.XtraEditors.TextEdit txt_Head;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}