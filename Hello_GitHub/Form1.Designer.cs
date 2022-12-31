namespace Hello_GitHub
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ColorTimer = new System.Windows.Forms.Timer(this.components);
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Hello_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ColorTimer
            // 
            this.ColorTimer.Enabled = true;
            this.ColorTimer.Interval = 1;
            this.ColorTimer.Tick += new System.EventHandler(this.ColorTimer_Tick);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit_Button.Location = new System.Drawing.Point(353, 0);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(30, 30);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "X";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Hello_Label
            // 
            this.Hello_Label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Hello_Label.AutoSize = true;
            this.Hello_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hello_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hello_Label.Location = new System.Drawing.Point(98, 64);
            this.Hello_Label.Name = "Hello_Label";
            this.Hello_Label.Size = new System.Drawing.Size(189, 33);
            this.Hello_Label.TabIndex = 2;
            this.Hello_Label.Text = "Hello GitHub!";
            this.Hello_Label.Click += new System.EventHandler(this.Hello_Label_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.ControlBox = false;
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Hello_Label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer ColorTimer;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Hello_Label;
    }
}

