﻿namespace Sample1
{
    partial class Staffentry
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
            this.StaffentryName_label = new System.Windows.Forms.Label();
            this.StaffentrySex_label = new System.Windows.Forms.Label();
            this.StaffentryPosition_label = new System.Windows.Forms.Label();
            this.StaffentryTel_label = new System.Windows.Forms.Label();
            this.StaffentryAddress_label = new System.Windows.Forms.Label();
            this.StaffentryMail_label = new System.Windows.Forms.Label();
            this.Staffentry_Name = new System.Windows.Forms.TextBox();
            this.Staffentry_Sex = new System.Windows.Forms.TextBox();
            this.Staffentry_Position = new System.Windows.Forms.TextBox();
            this.Staffentry_Tel = new System.Windows.Forms.TextBox();
            this.Staffentry_Mail = new System.Windows.Forms.TextBox();
            this.Staffentry_Address = new System.Windows.Forms.TextBox();
            this.StaffentryEntry_button = new System.Windows.Forms.Button();
            this.StaffentryBack_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffentryName_label
            // 
            this.StaffentryName_label.AutoSize = true;
            this.StaffentryName_label.Location = new System.Drawing.Point(54, 56);
            this.StaffentryName_label.Name = "StaffentryName_label";
            this.StaffentryName_label.Size = new System.Drawing.Size(29, 12);
            this.StaffentryName_label.TabIndex = 0;
            this.StaffentryName_label.Text = "名前";
            // 
            // StaffentrySex_label
            // 
            this.StaffentrySex_label.AutoSize = true;
            this.StaffentrySex_label.Location = new System.Drawing.Point(54, 98);
            this.StaffentrySex_label.Name = "StaffentrySex_label";
            this.StaffentrySex_label.Size = new System.Drawing.Size(29, 12);
            this.StaffentrySex_label.TabIndex = 1;
            this.StaffentrySex_label.Text = "性別";
            this.StaffentrySex_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // StaffentryPosition_label
            // 
            this.StaffentryPosition_label.AutoSize = true;
            this.StaffentryPosition_label.Location = new System.Drawing.Point(54, 139);
            this.StaffentryPosition_label.Name = "StaffentryPosition_label";
            this.StaffentryPosition_label.Size = new System.Drawing.Size(29, 12);
            this.StaffentryPosition_label.TabIndex = 2;
            this.StaffentryPosition_label.Text = "役職";
            // 
            // StaffentryTel_label
            // 
            this.StaffentryTel_label.AutoSize = true;
            this.StaffentryTel_label.Location = new System.Drawing.Point(54, 192);
            this.StaffentryTel_label.Name = "StaffentryTel_label";
            this.StaffentryTel_label.Size = new System.Drawing.Size(53, 12);
            this.StaffentryTel_label.TabIndex = 3;
            this.StaffentryTel_label.Text = "電話番号";
            // 
            // StaffentryAddress_label
            // 
            this.StaffentryAddress_label.AutoSize = true;
            this.StaffentryAddress_label.Location = new System.Drawing.Point(54, 290);
            this.StaffentryAddress_label.Name = "StaffentryAddress_label";
            this.StaffentryAddress_label.Size = new System.Drawing.Size(29, 12);
            this.StaffentryAddress_label.TabIndex = 4;
            this.StaffentryAddress_label.Text = "住所";
            // 
            // StaffentryMail_label
            // 
            this.StaffentryMail_label.AutoSize = true;
            this.StaffentryMail_label.Location = new System.Drawing.Point(54, 241);
            this.StaffentryMail_label.Name = "StaffentryMail_label";
            this.StaffentryMail_label.Size = new System.Drawing.Size(69, 12);
            this.StaffentryMail_label.TabIndex = 5;
            this.StaffentryMail_label.Text = "メールアドレス";
            // 
            // Staffentry_Name
            // 
            this.Staffentry_Name.Location = new System.Drawing.Point(135, 56);
            this.Staffentry_Name.Name = "Staffentry_Name";
            this.Staffentry_Name.Size = new System.Drawing.Size(150, 19);
            this.Staffentry_Name.TabIndex = 6;
            // 
            // Staffentry_Sex
            // 
            this.Staffentry_Sex.Location = new System.Drawing.Point(135, 98);
            this.Staffentry_Sex.Name = "Staffentry_Sex";
            this.Staffentry_Sex.Size = new System.Drawing.Size(150, 19);
            this.Staffentry_Sex.TabIndex = 7;
            // 
            // Staffentry_Position
            // 
            this.Staffentry_Position.Location = new System.Drawing.Point(135, 139);
            this.Staffentry_Position.Name = "Staffentry_Position";
            this.Staffentry_Position.Size = new System.Drawing.Size(150, 19);
            this.Staffentry_Position.TabIndex = 8;
            // 
            // Staffentry_Tel
            // 
            this.Staffentry_Tel.Location = new System.Drawing.Point(135, 185);
            this.Staffentry_Tel.Name = "Staffentry_Tel";
            this.Staffentry_Tel.Size = new System.Drawing.Size(150, 19);
            this.Staffentry_Tel.TabIndex = 9;
            // 
            // Staffentry_Mail
            // 
            this.Staffentry_Mail.Location = new System.Drawing.Point(135, 238);
            this.Staffentry_Mail.Name = "Staffentry_Mail";
            this.Staffentry_Mail.Size = new System.Drawing.Size(150, 19);
            this.Staffentry_Mail.TabIndex = 10;
            // 
            // Staffentry_Address
            // 
            this.Staffentry_Address.Location = new System.Drawing.Point(135, 290);
            this.Staffentry_Address.Name = "Staffentry_Address";
            this.Staffentry_Address.Size = new System.Drawing.Size(150, 19);
            this.Staffentry_Address.TabIndex = 11;
            // 
            // StaffentryEntry_button
            // 
            this.StaffentryEntry_button.Location = new System.Drawing.Point(262, 337);
            this.StaffentryEntry_button.Name = "StaffentryEntry_button";
            this.StaffentryEntry_button.Size = new System.Drawing.Size(75, 23);
            this.StaffentryEntry_button.TabIndex = 12;
            this.StaffentryEntry_button.Text = "登録";
            this.StaffentryEntry_button.UseVisualStyleBackColor = true;
            // 
            // StaffentryBack_button
            // 
            this.StaffentryBack_button.Location = new System.Drawing.Point(357, 337);
            this.StaffentryBack_button.Name = "StaffentryBack_button";
            this.StaffentryBack_button.Size = new System.Drawing.Size(75, 23);
            this.StaffentryBack_button.TabIndex = 13;
            this.StaffentryBack_button.Text = "戻る";
            this.StaffentryBack_button.UseVisualStyleBackColor = true;
            // 
            // Staffentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 408);
            this.Controls.Add(this.StaffentryBack_button);
            this.Controls.Add(this.StaffentryEntry_button);
            this.Controls.Add(this.Staffentry_Address);
            this.Controls.Add(this.Staffentry_Mail);
            this.Controls.Add(this.Staffentry_Tel);
            this.Controls.Add(this.Staffentry_Position);
            this.Controls.Add(this.Staffentry_Sex);
            this.Controls.Add(this.Staffentry_Name);
            this.Controls.Add(this.StaffentryMail_label);
            this.Controls.Add(this.StaffentryAddress_label);
            this.Controls.Add(this.StaffentryTel_label);
            this.Controls.Add(this.StaffentryPosition_label);
            this.Controls.Add(this.StaffentrySex_label);
            this.Controls.Add(this.StaffentryName_label);
            this.Name = "Staffentry";
            this.Text = "Staffentry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaffentryName_label;
        private System.Windows.Forms.Label StaffentrySex_label;
        private System.Windows.Forms.Label StaffentryPosition_label;
        private System.Windows.Forms.Label StaffentryTel_label;
        private System.Windows.Forms.Label StaffentryAddress_label;
        private System.Windows.Forms.Label StaffentryMail_label;
        private System.Windows.Forms.TextBox Staffentry_Name;
        private System.Windows.Forms.TextBox Staffentry_Sex;
        private System.Windows.Forms.TextBox Staffentry_Position;
        private System.Windows.Forms.TextBox Staffentry_Tel;
        private System.Windows.Forms.TextBox Staffentry_Mail;
        private System.Windows.Forms.TextBox Staffentry_Address;
        private System.Windows.Forms.Button StaffentryEntry_button;
        private System.Windows.Forms.Button StaffentryBack_button;
    }
}