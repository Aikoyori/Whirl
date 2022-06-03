using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ReworkedDLder
{
	// Token: 0x02000006 RID: 6
	public partial class Form2 : Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000027BB File Offset: 0x000009BB
		public Form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000027C9 File Offset: 0x000009C9
		private void Form2_Load(object sender, EventArgs e)
		{
			this.BackColor = Color.FromArgb(255, 1, 0, 0);
			base.TransparencyKey = Color.FromArgb(255, 1, 0, 0);
		}
	}
}
