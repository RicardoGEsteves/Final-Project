namespace ManagerSoftware.GUI
{
    partial class Manager_Software_Windows
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
            this.insert_button = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.Inserted_List = new System.Windows.Forms.ListView();
            this.sent_List = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.role = new System.Windows.Forms.ComboBox();
            this.contactNumber = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.originalList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // insert_button
            // 
            this.insert_button.Enabled = false;
            this.insert_button.Location = new System.Drawing.Point(369, 320);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(75, 23);
            this.insert_button.TabIndex = 4;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.button_Insert);
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(524, 320);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // Inserted_List
            // 
            this.Inserted_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Inserted_List.Location = new System.Drawing.Point(12, 12);
            this.Inserted_List.MultiSelect = false;
            this.Inserted_List.Name = "Inserted_List";
            this.Inserted_List.Size = new System.Drawing.Size(412, 140);
            this.Inserted_List.TabIndex = 7;
            this.Inserted_List.UseCompatibleStateImageBehavior = false;
            // 
            // sent_List
            // 
            this.sent_List.Enabled = false;
            this.sent_List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.sent_List.Location = new System.Drawing.Point(443, 12);
            this.sent_List.MultiSelect = false;
            this.sent_List.Name = "sent_List";
            this.sent_List.Size = new System.Drawing.Size(403, 140);
            this.sent_List.TabIndex = 8;
            this.sent_List.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(87, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(87, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(87, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(87, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Role";
            // 
            // role
            // 
            this.role.FormattingEnabled = true;
            this.role.Items.AddRange(new object[] {
            "Diretor",
            "Operário"});
            this.role.Location = new System.Drawing.Point(195, 308);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(121, 24);
            this.role.TabIndex = 3;
            this.role.SelectedIndexChanged += new System.EventHandler(this.textChanged);
            // 
            // contactNumber
            // 
            this.contactNumber.Location = new System.Drawing.Point(195, 276);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(121, 22);
            this.contactNumber.TabIndex = 2;
            this.contactNumber.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(195, 235);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(121, 22);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(195, 198);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(121, 22);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.reset_button);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(440, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Original List";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // listBox1
            // 
            this.originalList.FormattingEnabled = true;
            this.originalList.ItemHeight = 16;
            this.originalList.Location = new System.Drawing.Point(443, 198);
            this.originalList.Name = "originalList";
            this.originalList.Size = new System.Drawing.Size(352, 100);
            this.originalList.TabIndex = 15;

            // 
            // Manager_Software_Windows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 374);
            this.Controls.Add(this.originalList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.role);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sent_List);
            this.Controls.Add(this.Inserted_List);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.insert_button);
            this.Name = "Manager_Software_Windows";
            this.Text = "Manager_Software_Windows";
            this.Load += new System.EventHandler(this.Manager_Software_Windows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListView Inserted_List;
        private System.Windows.Forms.ListView sent_List;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox role;
        private System.Windows.Forms.TextBox contactNumber;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox originalList;
    }
}