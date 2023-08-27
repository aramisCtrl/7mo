/*
 * Created by SharpDevelop.
 * User: Fiski
 * Date: 27/08/2023
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace tres_imágenes
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pic0 = new System.Windows.Forms.PictureBox();
			this.pic2 = new System.Windows.Forms.PictureBox();
			this.pic1 = new System.Windows.Forms.PictureBox();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.lbl0 = new System.Windows.Forms.Label();
			this.lbl2 = new System.Windows.Forms.Label();
			this.lbl1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pic0)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
			this.SuspendLayout();
			// 
			// pic0
			// 
			this.pic0.Location = new System.Drawing.Point(13, 70);
			this.pic0.Name = "pic0";
			this.pic0.Size = new System.Drawing.Size(242, 237);
			this.pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic0.TabIndex = 0;
			this.pic0.TabStop = false;
			// 
			// pic2
			// 
			this.pic2.Location = new System.Drawing.Point(531, 70);
			this.pic2.Name = "pic2";
			this.pic2.Size = new System.Drawing.Size(242, 237);
			this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic2.TabIndex = 1;
			this.pic2.TabStop = false;
			// 
			// pic1
			// 
			this.pic1.Location = new System.Drawing.Point(272, 70);
			this.pic1.Name = "pic1";
			this.pic1.Size = new System.Drawing.Size(242, 237);
			this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic1.TabIndex = 2;
			this.pic1.TabStop = false;
			// 
			// btn1
			// 
			this.btn1.Location = new System.Drawing.Point(88, 313);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(97, 40);
			this.btn1.TabIndex = 3;
			this.btn1.Text = "Mezclar";
			this.btn1.UseVisualStyleBackColor = true;
			this.btn1.Click += new System.EventHandler(this.funcion_click);
			// 
			// btn2
			// 
			this.btn2.Location = new System.Drawing.Point(344, 313);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(97, 40);
			this.btn2.TabIndex = 4;
			this.btn2.Text = "Mezclar";
			this.btn2.UseVisualStyleBackColor = true;
			this.btn2.Click += new System.EventHandler(this.funcion_click);
			// 
			// btn3
			// 
			this.btn3.Location = new System.Drawing.Point(601, 313);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(97, 40);
			this.btn3.TabIndex = 5;
			this.btn3.Text = "Mezclar";
			this.btn3.UseVisualStyleBackColor = true;
			this.btn3.Click += new System.EventHandler(this.funcion_click);
			// 
			// lbl0
			// 
			this.lbl0.Location = new System.Drawing.Point(13, 381);
			this.lbl0.Name = "lbl0";
			this.lbl0.Size = new System.Drawing.Size(242, 23);
			this.lbl0.TabIndex = 6;
			this.lbl0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl2
			// 
			this.lbl2.Location = new System.Drawing.Point(531, 381);
			this.lbl2.Name = "lbl2";
			this.lbl2.Size = new System.Drawing.Size(242, 23);
			this.lbl2.TabIndex = 7;
			this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl1
			// 
			this.lbl1.Location = new System.Drawing.Point(272, 381);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(242, 23);
			this.lbl1.TabIndex = 8;
			this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(785, 494);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lbl2);
			this.Controls.Add(this.lbl0);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.pic1);
			this.Controls.Add(this.pic2);
			this.Controls.Add(this.pic0);
			this.Name = "MainForm";
			this.Text = "tres_imágenes";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic0)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lbl2;
		private System.Windows.Forms.Label lbl0;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.PictureBox pic1;
		private System.Windows.Forms.PictureBox pic2;
		private System.Windows.Forms.PictureBox pic0;
	}
}
