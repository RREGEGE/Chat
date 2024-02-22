namespace newChat
{
    partial class Form2
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
            this.repwd_txtbox = new System.Windows.Forms.TextBox();
            this.pwd_txtbox = new System.Windows.Forms.TextBox();
            this.id_txtbox = new System.Windows.Forms.TextBox();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birth_txtbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // repwd_txtbox
            // 
            this.repwd_txtbox.Location = new System.Drawing.Point(195, 356);
            this.repwd_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.repwd_txtbox.Name = "repwd_txtbox";
            this.repwd_txtbox.Size = new System.Drawing.Size(176, 25);
            this.repwd_txtbox.TabIndex = 16;
            // 
            // pwd_txtbox
            // 
            this.pwd_txtbox.Location = new System.Drawing.Point(195, 294);
            this.pwd_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.pwd_txtbox.Name = "pwd_txtbox";
            this.pwd_txtbox.Size = new System.Drawing.Size(176, 25);
            this.pwd_txtbox.TabIndex = 15;
            // 
            // id_txtbox
            // 
            this.id_txtbox.Location = new System.Drawing.Point(195, 233);
            this.id_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.id_txtbox.Name = "id_txtbox";
            this.id_txtbox.Size = new System.Drawing.Size(176, 25);
            this.id_txtbox.TabIndex = 14;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(195, 177);
            this.name_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(176, 25);
            this.name_txtbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "생년월일(8자리)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 356);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "비밀번호 확인";
            // 
            // birth_txtbox
            // 
            this.birth_txtbox.Location = new System.Drawing.Point(195, 411);
            this.birth_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.birth_txtbox.Name = "birth_txtbox";
            this.birth_txtbox.Size = new System.Drawing.Size(176, 25);
            this.birth_txtbox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 464);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "회원가입";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birth_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.repwd_txtbox);
            this.Controls.Add(this.pwd_txtbox);
            this.Controls.Add(this.id_txtbox);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox repwd_txtbox;
        private System.Windows.Forms.TextBox pwd_txtbox;
        private System.Windows.Forms.TextBox id_txtbox;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox birth_txtbox;
        private System.Windows.Forms.Button button1;
    }
}