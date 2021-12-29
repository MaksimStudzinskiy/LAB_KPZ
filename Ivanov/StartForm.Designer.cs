
namespace Ivanov
{
    partial class StartForm
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
			this.start = new System.Windows.Forms.Button();
			this.newBS = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// start
			// 
			this.start.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.start.Location = new System.Drawing.Point(13, 204);
			this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.start.Name = "start";
			this.start.Size = new System.Drawing.Size(658, 163);
			this.start.TabIndex = 0;
			this.start.Text = "Start";
			this.start.UseVisualStyleBackColor = true;
			this.start.Click += new System.EventHandler(this.start_Click);
			// 
			// newBS
			// 
			this.newBS.Font = new System.Drawing.Font("Minion Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.newBS.Location = new System.Drawing.Point(13, 13);
			this.newBS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.newBS.Name = "newBS";
			this.newBS.Size = new System.Drawing.Size(658, 166);
			this.newBS.TabIndex = 1;
			this.newBS.Text = "New";
			this.newBS.UseVisualStyleBackColor = true;
			this.newBS.Click += new System.EventHandler(this.newBS_Click);
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(684, 380);
			this.Controls.Add(this.newBS);
			this.Controls.Add(this.start);
			this.ForeColor = System.Drawing.SystemColors.MenuText;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "StartForm";
			this.Text = "Block-Schemer";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button newBS;
    }
}