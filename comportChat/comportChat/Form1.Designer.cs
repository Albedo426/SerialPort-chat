using System;

namespace comportChat
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recivercom1 = new System.Windows.Forms.RichTextBox();
            this.recivercom2 = new System.Windows.Forms.RichTextBox();
            this.labelcom1 = new System.Windows.Forms.Label();
            this.labelcom2 = new System.Windows.Forms.Label();
            this.com1connet = new System.Windows.Forms.Button();
            this.com2connet = new System.Windows.Forms.Button();
            this.com1text = new System.Windows.Forms.TextBox();
            this.com2text = new System.Windows.Forms.TextBox();
            this.com1sendmessage = new System.Windows.Forms.Button();
            this.com2sendmessage = new System.Windows.Forms.Button();
            this.com1radioButton = new System.Windows.Forms.RadioButton();
            this.com2radioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // recivercom1
            // 
            this.recivercom1.Location = new System.Drawing.Point(12, 107);
            this.recivercom1.Name = "recivercom1";
            this.recivercom1.Size = new System.Drawing.Size(348, 195);
            this.recivercom1.TabIndex = 2;
            this.recivercom1.Text = "";
            // 
            // recivercom2
            // 
            this.recivercom2.Location = new System.Drawing.Point(440, 107);
            this.recivercom2.Name = "recivercom2";
            this.recivercom2.Size = new System.Drawing.Size(348, 195);
            this.recivercom2.TabIndex = 3;
            this.recivercom2.Text = "";
            // 
            // labelcom1
            // 
            this.labelcom1.AutoSize = true;
            this.labelcom1.Location = new System.Drawing.Point(12, 72);
            this.labelcom1.Name = "labelcom1";
            this.labelcom1.Size = new System.Drawing.Size(96, 17);
            this.labelcom1.TabIndex = 4;
            this.labelcom1.Text = "com1 bağlantı";
            // 
            // labelcom2
            // 
            this.labelcom2.AutoSize = true;
            this.labelcom2.Location = new System.Drawing.Point(440, 72);
            this.labelcom2.Name = "labelcom2";
            this.labelcom2.Size = new System.Drawing.Size(96, 17);
            this.labelcom2.TabIndex = 5;
            this.labelcom2.Text = "com2 bağlantı";
            // 
            // com1connet
            // 
            this.com1connet.Location = new System.Drawing.Point(273, 64);
            this.com1connet.Name = "com1connet";
            this.com1connet.Size = new System.Drawing.Size(87, 32);
            this.com1connet.TabIndex = 6;
            this.com1connet.Text = "bağlan";
            this.com1connet.UseVisualStyleBackColor = true;
            this.com1connet.Click += new System.EventHandler(this.com1connet_Click);
            // 
            // com2connet
            // 
            this.com2connet.Location = new System.Drawing.Point(701, 64);
            this.com2connet.Name = "com2connet";
            this.com2connet.Size = new System.Drawing.Size(87, 32);
            this.com2connet.TabIndex = 7;
            this.com2connet.Text = "bağlan";
            this.com2connet.UseVisualStyleBackColor = true;
            this.com2connet.Click += new System.EventHandler(this.com2connet_Click);
            // 
            // com1text
            // 
            this.com1text.Location = new System.Drawing.Point(12, 324);
            this.com1text.Name = "com1text";
            this.com1text.Size = new System.Drawing.Size(348, 22);
            this.com1text.TabIndex = 8;
            // 
            // com2text
            // 
            this.com2text.Location = new System.Drawing.Point(440, 324);
            this.com2text.Name = "com2text";
            this.com2text.Size = new System.Drawing.Size(348, 22);
            this.com2text.TabIndex = 9;
            // 
            // com1sendmessage
            // 
            this.com1sendmessage.Location = new System.Drawing.Point(12, 371);
            this.com1sendmessage.Name = "com1sendmessage";
            this.com1sendmessage.Size = new System.Drawing.Size(87, 32);
            this.com1sendmessage.TabIndex = 10;
            this.com1sendmessage.Text = "gönder";
            this.com1sendmessage.UseVisualStyleBackColor = true;
            this.com1sendmessage.Click += new System.EventHandler(this.com1sendmessage_Click);
            // 
            // com2sendmessage
            // 
            this.com2sendmessage.Location = new System.Drawing.Point(440, 371);
            this.com2sendmessage.Name = "com2sendmessage";
            this.com2sendmessage.Size = new System.Drawing.Size(87, 32);
            this.com2sendmessage.TabIndex = 11;
            this.com2sendmessage.Text = "gönder";
            this.com2sendmessage.UseVisualStyleBackColor = true;
            this.com2sendmessage.Click += new System.EventHandler(this.com2sendmessage_Click);
            // 
            // com1radioButton
            // 
            this.com1radioButton.AutoSize = true;
            this.com1radioButton.Location = new System.Drawing.Point(12, 37);
            this.com1radioButton.Name = "com1radioButton";
            this.com1radioButton.Size = new System.Drawing.Size(212, 21);
            this.com1radioButton.TabIndex = 12;
            this.com1radioButton.TabStop = true;
            this.com1radioButton.Text = "tex olarak mı iletişim kurulsun";
            this.com1radioButton.UseVisualStyleBackColor = true;
            // 
            // com2radioButton
            // 
            this.com2radioButton.AutoSize = true;
            this.com2radioButton.Location = new System.Drawing.Point(440, 37);
            this.com2radioButton.Name = "com2radioButton";
            this.com2radioButton.Size = new System.Drawing.Size(216, 21);
            this.com2radioButton.TabIndex = 13;
            this.com2radioButton.TabStop = true;
            this.com2radioButton.Text = "text olarak mı iletişim kurulsun";
            this.com2radioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.com1connet);
            this.Controls.Add(this.com2connet);
            this.Controls.Add(this.com1text);
            this.Controls.Add(this.com2text);
            this.Controls.Add(this.labelcom1);
            this.Controls.Add(this.labelcom2);
            this.Controls.Add(this.com1sendmessage);
            this.Controls.Add(this.com2sendmessage);
            this.Controls.Add(this.com1radioButton);
            this.Controls.Add(this.com2radioButton);
            this.Controls.Add(this.recivercom2);
            this.Controls.Add(this.recivercom1);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox recivercom1;
        private System.Windows.Forms.RichTextBox recivercom2;
        private System.Windows.Forms.Label labelcom1;
        private System.Windows.Forms.Label labelcom2;
        private System.Windows.Forms.Button com1connet;
        private System.Windows.Forms.Button com2connet;
        private System.Windows.Forms.TextBox com1text;
        private System.Windows.Forms.TextBox com2text;
        private System.Windows.Forms.Button com1sendmessage;
        private System.Windows.Forms.Button com2sendmessage;
        private System.Windows.Forms.RadioButton com1radioButton;
        private System.Windows.Forms.RadioButton com2radioButton;
    }
}

