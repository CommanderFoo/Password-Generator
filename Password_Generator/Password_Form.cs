using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator {
	public partial class Password_Form : Form {
		public Password_Form() {
			InitializeComponent();
		}

		private void create_password_Click(object sender, EventArgs e){
			int len = 16;

			if(len_8.Checked){
				len = 8;
			} else if(len_14.Checked){
				len = 14;
			} else if(len_16.Checked){
				len = 16;
			} else if(len_20.Checked){
				len = 20;
			} else if(len_24.Checked){
				len = 24;
			} else if(len_30.Checked){
				len = 30;
			}

			bool use_alpha = false;
			bool use_alpha_upper = false;
			bool use_nums = false;
			bool use_specials = false;

			if(alpha_lower.Checked){
				use_alpha = true;
			}

			if(alpha_upper.Checked){
				use_alpha_upper = true;
			}

			if(nums.Checked){
				use_nums = true;
			}

			if(specials.Checked){
				use_specials = true;
			}

			display.Text = Password.create(len, use_alpha, use_alpha_upper, use_nums, use_specials);
			Clipboard.SetText(display.Text);
		}
	}
}
