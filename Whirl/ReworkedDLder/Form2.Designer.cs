namespace ReworkedDLder
{
	// Token: 0x02000006 RID: 6
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000027F1 File Offset: 0x000009F1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002810 File Offset: 0x00000A10
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 72f);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new global::System.Drawing.Point(43, 81);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(645, 108);
			this.label1.TabIndex = 0;
			this.label1.Text = "Debug Mode!!";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(729, 271);
			base.ControlBox = false;
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Form2_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label1;
	}
}
