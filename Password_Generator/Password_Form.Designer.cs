namespace Password_Generator {
	partial class Password_Form {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password_Form));
			this.create_password = new System.Windows.Forms.Button();
			this.display = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.len_30 = new System.Windows.Forms.RadioButton();
			this.len_16 = new System.Windows.Forms.RadioButton();
			this.len_24 = new System.Windows.Forms.RadioButton();
			this.len_14 = new System.Windows.Forms.RadioButton();
			this.len_20 = new System.Windows.Forms.RadioButton();
			this.len_8 = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.specials = new System.Windows.Forms.CheckBox();
			this.nums = new System.Windows.Forms.CheckBox();
			this.alpha_upper = new System.Windows.Forms.CheckBox();
			this.alpha_lower = new System.Windows.Forms.CheckBox();
			this.tooltip = new System.Windows.Forms.ToolTip(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// create_password
			// 
			this.create_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.create_password.Location = new System.Drawing.Point(278, 144);
			this.create_password.Margin = new System.Windows.Forms.Padding(0);
			this.create_password.Name = "create_password";
			this.create_password.Size = new System.Drawing.Size(161, 38);
			this.create_password.TabIndex = 1;
			this.create_password.Text = "Create and Copy";
			this.create_password.UseVisualStyleBackColor = true;
			this.create_password.Click += new System.EventHandler(this.create_password_Click);
			// 
			// display
			// 
			this.display.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.display.Location = new System.Drawing.Point(24, 35);
			this.display.Name = "display";
			this.display.ReadOnly = true;
			this.display.Size = new System.Drawing.Size(415, 24);
			this.display.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.len_30);
			this.panel1.Controls.Add(this.len_16);
			this.panel1.Controls.Add(this.len_24);
			this.panel1.Controls.Add(this.len_14);
			this.panel1.Controls.Add(this.len_20);
			this.panel1.Controls.Add(this.len_8);
			this.panel1.Location = new System.Drawing.Point(24, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(201, 59);
			this.panel1.TabIndex = 3;
			// 
			// len_30
			// 
			this.len_30.AutoSize = true;
			this.len_30.Location = new System.Drawing.Point(138, 33);
			this.len_30.Name = "len_30";
			this.len_30.Size = new System.Drawing.Size(45, 21);
			this.len_30.TabIndex = 5;
			this.len_30.Text = "30";
			this.tooltip.SetToolTip(this.len_30, "Password Length 30");
			this.len_30.UseVisualStyleBackColor = true;
			// 
			// len_16
			// 
			this.len_16.AutoSize = true;
			this.len_16.Checked = true;
			this.len_16.Location = new System.Drawing.Point(138, 2);
			this.len_16.Name = "len_16";
			this.len_16.Size = new System.Drawing.Size(45, 21);
			this.len_16.TabIndex = 4;
			this.len_16.TabStop = true;
			this.len_16.Text = "16";
			this.tooltip.SetToolTip(this.len_16, "Password Length 16");
			this.len_16.UseVisualStyleBackColor = true;
			// 
			// len_24
			// 
			this.len_24.AutoSize = true;
			this.len_24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.len_24.Location = new System.Drawing.Point(70, 33);
			this.len_24.Name = "len_24";
			this.len_24.Size = new System.Drawing.Size(43, 20);
			this.len_24.TabIndex = 3;
			this.len_24.Text = "24";
			this.tooltip.SetToolTip(this.len_24, "Password Length 24");
			this.len_24.UseVisualStyleBackColor = true;
			// 
			// len_14
			// 
			this.len_14.AutoSize = true;
			this.len_14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.len_14.Location = new System.Drawing.Point(70, 3);
			this.len_14.Name = "len_14";
			this.len_14.Size = new System.Drawing.Size(43, 20);
			this.len_14.TabIndex = 2;
			this.len_14.Text = "14";
			this.tooltip.SetToolTip(this.len_14, "Password Length 14");
			this.len_14.UseVisualStyleBackColor = true;
			// 
			// len_20
			// 
			this.len_20.AutoSize = true;
			this.len_20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.len_20.Location = new System.Drawing.Point(3, 33);
			this.len_20.Name = "len_20";
			this.len_20.Size = new System.Drawing.Size(43, 20);
			this.len_20.TabIndex = 1;
			this.len_20.Text = "20";
			this.tooltip.SetToolTip(this.len_20, "Password Length 20");
			this.len_20.UseVisualStyleBackColor = true;
			// 
			// len_8
			// 
			this.len_8.AutoSize = true;
			this.len_8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.len_8.Location = new System.Drawing.Point(3, 4);
			this.len_8.Name = "len_8";
			this.len_8.Size = new System.Drawing.Size(36, 20);
			this.len_8.TabIndex = 0;
			this.len_8.Text = "8";
			this.tooltip.SetToolTip(this.len_8, "Password Length 8");
			this.len_8.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.specials);
			this.panel2.Controls.Add(this.nums);
			this.panel2.Controls.Add(this.alpha_upper);
			this.panel2.Controls.Add(this.alpha_lower);
			this.panel2.Location = new System.Drawing.Point(278, 69);
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.panel2.Size = new System.Drawing.Size(161, 59);
			this.panel2.TabIndex = 5;
			// 
			// specials
			// 
			this.specials.AutoSize = true;
			this.specials.Checked = true;
			this.specials.CheckState = System.Windows.Forms.CheckState.Checked;
			this.specials.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.specials.Location = new System.Drawing.Point(100, 31);
			this.specials.Name = "specials";
			this.specials.Size = new System.Drawing.Size(42, 20);
			this.specials.TabIndex = 3;
			this.specials.Text = "!*{";
			this.tooltip.SetToolTip(this.specials, "Special Characters");
			this.specials.UseVisualStyleBackColor = true;
			// 
			// nums
			// 
			this.nums.AutoSize = true;
			this.nums.Checked = true;
			this.nums.CheckState = System.Windows.Forms.CheckState.Checked;
			this.nums.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.nums.Location = new System.Drawing.Point(100, 5);
			this.nums.Name = "nums";
			this.nums.Size = new System.Drawing.Size(51, 20);
			this.nums.TabIndex = 2;
			this.nums.Text = "123";
			this.tooltip.SetToolTip(this.nums, "Numbers");
			this.nums.UseVisualStyleBackColor = true;
			// 
			// alpha_upper
			// 
			this.alpha_upper.AutoSize = true;
			this.alpha_upper.Checked = true;
			this.alpha_upper.CheckState = System.Windows.Forms.CheckState.Checked;
			this.alpha_upper.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.alpha_upper.Location = new System.Drawing.Point(3, 32);
			this.alpha_upper.Name = "alpha_upper";
			this.alpha_upper.Size = new System.Drawing.Size(57, 20);
			this.alpha_upper.TabIndex = 1;
			this.alpha_upper.Text = "ABC";
			this.tooltip.SetToolTip(this.alpha_upper, "Uppercase Characters");
			this.alpha_upper.UseVisualStyleBackColor = true;
			// 
			// alpha_lower
			// 
			this.alpha_lower.AutoSize = true;
			this.alpha_lower.Checked = true;
			this.alpha_lower.CheckState = System.Windows.Forms.CheckState.Checked;
			this.alpha_lower.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.alpha_lower.Location = new System.Drawing.Point(3, 5);
			this.alpha_lower.Name = "alpha_lower";
			this.alpha_lower.Size = new System.Drawing.Size(51, 20);
			this.alpha_lower.TabIndex = 0;
			this.alpha_lower.Text = "abc";
			this.tooltip.SetToolTip(this.alpha_lower, "Lowercase Characters");
			this.alpha_lower.UseVisualStyleBackColor = true;
			// 
			// Password_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 221);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.display);
			this.Controls.Add(this.create_password);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Password_Form";
			this.Text = "Password Generator";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button create_password;
		private System.Windows.Forms.TextBox display;
		private System.Windows.Forms.RadioButton len_24;
		private System.Windows.Forms.RadioButton len_8;
		private System.Windows.Forms.RadioButton len_20;
		private System.Windows.Forms.RadioButton len_14;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ToolTip tooltip;
		private System.Windows.Forms.CheckBox alpha_lower;
		private System.Windows.Forms.CheckBox specials;
		private System.Windows.Forms.CheckBox nums;
		private System.Windows.Forms.CheckBox alpha_upper;
		private System.Windows.Forms.RadioButton len_30;
		private System.Windows.Forms.RadioButton len_16;
	}
}

