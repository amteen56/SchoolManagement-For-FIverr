namespace SchoolManagement
{
    partial class CreateStudent
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.nametext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.idtext = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.panel6.Location = new System.Drawing.Point(-1, 320);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(844, 10);
            this.panel6.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label17.Location = new System.Drawing.Point(12, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(279, 42);
            this.label17.TabIndex = 24;
            this.label17.Text = "Create Student";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label21.Location = new System.Drawing.Point(15, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 22);
            this.label21.TabIndex = 22;
            this.label21.Text = "NAME:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(473, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 40);
            this.button3.TabIndex = 23;
            this.button3.Text = "Register";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // nametext
            // 
            this.nametext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nametext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nametext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nametext.HintForeColor = System.Drawing.Color.Black;
            this.nametext.HintText = "";
            this.nametext.isPassword = false;
            this.nametext.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.nametext.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.nametext.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.nametext.LineThickness = 3;
            this.nametext.Location = new System.Drawing.Point(16, 147);
            this.nametext.Margin = new System.Windows.Forms.Padding(4);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(307, 33);
            this.nametext.TabIndex = 27;
            this.nametext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // idtext
            // 
            this.idtext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idtext.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idtext.HintForeColor = System.Drawing.Color.Black;
            this.idtext.HintText = "";
            this.idtext.isPassword = false;
            this.idtext.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.idtext.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.idtext.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.idtext.LineThickness = 3;
            this.idtext.Location = new System.Drawing.Point(463, 147);
            this.idtext.Margin = new System.Windows.Forms.Padding(4);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(307, 33);
            this.idtext.TabIndex = 29;
            this.idtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(26)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(462, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(777, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 39);
            this.label2.TabIndex = 100;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(830, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.button3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nametext;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

