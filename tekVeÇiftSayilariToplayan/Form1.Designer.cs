namespace tekVeÇiftSayilariToplayan
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTek = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewTek = new System.Windows.Forms.ListView();
            this.tabPageCift = new System.Windows.Forms.TabPage();
            this.listViewCift = new System.Windows.Forms.ListView();
            this.tabPageAsal = new System.Windows.Forms.TabPage();
            this.listViewAsal = new System.Windows.Forms.ListView();
            this.tabPageArms = new System.Windows.Forms.TabPage();
            this.listViewArmstrong = new System.Windows.Forms.ListView();
            this.grpGirisBilgileri = new System.Windows.Forms.GroupBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtCarpımlarSonucu = new System.Windows.Forms.MaskedTextBox();
            this.btnIleri = new System.Windows.Forms.Button();
            this.txtToplamlarSonucu = new System.Windows.Forms.MaskedTextBox();
            this.txtSonSayi = new System.Windows.Forms.MaskedTextBox();
            this.Toplamlar = new System.Windows.Forms.Label();
            this.txtBaslanacakSayi = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageTek.SuspendLayout();
            this.tabPageCift.SuspendLayout();
            this.tabPageAsal.SuspendLayout();
            this.tabPageArms.SuspendLayout();
            this.grpGirisBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTek);
            this.tabControl1.Controls.Add(this.tabPageCift);
            this.tabControl1.Controls.Add(this.tabPageAsal);
            this.tabControl1.Controls.Add(this.tabPageArms);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 296);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageTek
            // 
            this.tabPageTek.Controls.Add(this.listView1);
            this.tabPageTek.Controls.Add(this.listViewTek);
            this.tabPageTek.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPageTek.Location = new System.Drawing.Point(4, 25);
            this.tabPageTek.Name = "tabPageTek";
            this.tabPageTek.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTek.Size = new System.Drawing.Size(792, 267);
            this.tabPageTek.TabIndex = 0;
            this.tabPageTek.Text = "Tek sayılar";
            this.tabPageTek.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 346);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(786, 343);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // listViewTek
            // 
            this.listViewTek.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewTek.HideSelection = false;
            this.listViewTek.Location = new System.Drawing.Point(3, 3);
            this.listViewTek.Name = "listViewTek";
            this.listViewTek.Size = new System.Drawing.Size(786, 343);
            this.listViewTek.TabIndex = 0;
            this.listViewTek.UseCompatibleStateImageBehavior = false;
            this.listViewTek.View = System.Windows.Forms.View.List;
            // 
            // tabPageCift
            // 
            this.tabPageCift.Controls.Add(this.listViewCift);
            this.tabPageCift.Location = new System.Drawing.Point(4, 25);
            this.tabPageCift.Name = "tabPageCift";
            this.tabPageCift.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCift.Size = new System.Drawing.Size(792, 267);
            this.tabPageCift.TabIndex = 1;
            this.tabPageCift.Text = "Çift sayılar";
            this.tabPageCift.UseVisualStyleBackColor = true;
            // 
            // listViewCift
            // 
            this.listViewCift.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewCift.HideSelection = false;
            this.listViewCift.Location = new System.Drawing.Point(3, 3);
            this.listViewCift.Name = "listViewCift";
            this.listViewCift.Size = new System.Drawing.Size(786, 304);
            this.listViewCift.TabIndex = 0;
            this.listViewCift.UseCompatibleStateImageBehavior = false;
            this.listViewCift.View = System.Windows.Forms.View.List;
            // 
            // tabPageAsal
            // 
            this.tabPageAsal.Controls.Add(this.listViewAsal);
            this.tabPageAsal.Location = new System.Drawing.Point(4, 25);
            this.tabPageAsal.Name = "tabPageAsal";
            this.tabPageAsal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAsal.Size = new System.Drawing.Size(792, 267);
            this.tabPageAsal.TabIndex = 2;
            this.tabPageAsal.Text = "Asal sayılar";
            this.tabPageAsal.UseVisualStyleBackColor = true;
            // 
            // listViewAsal
            // 
            this.listViewAsal.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewAsal.HideSelection = false;
            this.listViewAsal.Location = new System.Drawing.Point(3, 3);
            this.listViewAsal.Name = "listViewAsal";
            this.listViewAsal.Size = new System.Drawing.Size(786, 314);
            this.listViewAsal.TabIndex = 0;
            this.listViewAsal.UseCompatibleStateImageBehavior = false;
            this.listViewAsal.View = System.Windows.Forms.View.List;
            // 
            // tabPageArms
            // 
            this.tabPageArms.Controls.Add(this.listViewArmstrong);
            this.tabPageArms.Location = new System.Drawing.Point(4, 25);
            this.tabPageArms.Name = "tabPageArms";
            this.tabPageArms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArms.Size = new System.Drawing.Size(792, 267);
            this.tabPageArms.TabIndex = 3;
            this.tabPageArms.Text = "Armstrong sayılar";
            this.tabPageArms.UseVisualStyleBackColor = true;
            // 
            // listViewArmstrong
            // 
            this.listViewArmstrong.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewArmstrong.HideSelection = false;
            this.listViewArmstrong.Location = new System.Drawing.Point(3, 3);
            this.listViewArmstrong.Name = "listViewArmstrong";
            this.listViewArmstrong.Size = new System.Drawing.Size(786, 317);
            this.listViewArmstrong.TabIndex = 0;
            this.listViewArmstrong.UseCompatibleStateImageBehavior = false;
            this.listViewArmstrong.View = System.Windows.Forms.View.List;
            // 
            // grpGirisBilgileri
            // 
            this.grpGirisBilgileri.Controls.Add(this.btnGeri);
            this.grpGirisBilgileri.Controls.Add(this.txtCarpımlarSonucu);
            this.grpGirisBilgileri.Controls.Add(this.btnIleri);
            this.grpGirisBilgileri.Controls.Add(this.txtToplamlarSonucu);
            this.grpGirisBilgileri.Controls.Add(this.txtSonSayi);
            this.grpGirisBilgileri.Controls.Add(this.Toplamlar);
            this.grpGirisBilgileri.Controls.Add(this.txtBaslanacakSayi);
            this.grpGirisBilgileri.Controls.Add(this.label3);
            this.grpGirisBilgileri.Controls.Add(this.btnHesapla);
            this.grpGirisBilgileri.Controls.Add(this.label2);
            this.grpGirisBilgileri.Controls.Add(this.label1);
            this.grpGirisBilgileri.Location = new System.Drawing.Point(7, 12);
            this.grpGirisBilgileri.Name = "grpGirisBilgileri";
            this.grpGirisBilgileri.Size = new System.Drawing.Size(781, 136);
            this.grpGirisBilgileri.TabIndex = 14;
            this.grpGirisBilgileri.TabStop = false;
            this.grpGirisBilgileri.Text = "Giriş Bilgileri";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(525, 30);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(101, 48);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "<<GERİ";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // txtCarpımlarSonucu
            // 
            this.txtCarpımlarSonucu.Location = new System.Drawing.Point(410, 103);
            this.txtCarpımlarSonucu.Name = "txtCarpımlarSonucu";
            this.txtCarpımlarSonucu.Size = new System.Drawing.Size(100, 22);
            this.txtCarpımlarSonucu.TabIndex = 11;
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(632, 29);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(101, 49);
            this.btnIleri.TabIndex = 1;
            this.btnIleri.Text = "İLERİ>>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.BtnIleri_Click);
            // 
            // txtToplamlarSonucu
            // 
            this.txtToplamlarSonucu.Location = new System.Drawing.Point(409, 72);
            this.txtToplamlarSonucu.Name = "txtToplamlarSonucu";
            this.txtToplamlarSonucu.Size = new System.Drawing.Size(100, 22);
            this.txtToplamlarSonucu.TabIndex = 9;
            // 
            // txtSonSayi
            // 
            this.txtSonSayi.Location = new System.Drawing.Point(137, 58);
            this.txtSonSayi.Name = "txtSonSayi";
            this.txtSonSayi.Size = new System.Drawing.Size(100, 22);
            this.txtSonSayi.TabIndex = 6;
            this.txtSonSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSonSayi_KeyPress);
            // 
            // Toplamlar
            // 
            this.Toplamlar.AutoSize = true;
            this.Toplamlar.Location = new System.Drawing.Point(291, 75);
            this.Toplamlar.Name = "Toplamlar";
            this.Toplamlar.Size = new System.Drawing.Size(123, 17);
            this.Toplamlar.TabIndex = 8;
            this.Toplamlar.Text = "Toplamlar Sonucu";
            // 
            // txtBaslanacakSayi
            // 
            this.txtBaslanacakSayi.Location = new System.Drawing.Point(137, 27);
            this.txtBaslanacakSayi.Name = "txtBaslanacakSayi";
            this.txtBaslanacakSayi.Size = new System.Drawing.Size(100, 22);
            this.txtBaslanacakSayi.TabIndex = 1;
            this.txtBaslanacakSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBaslanacakSayi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Çarpımlar Sonucu";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(268, 43);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Son Sayı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlanacak Sayı";
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpGirisBilgileri);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "yo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTek.ResumeLayout(false);
            this.tabPageCift.ResumeLayout(false);
            this.tabPageAsal.ResumeLayout(false);
            this.tabPageArms.ResumeLayout(false);
            this.grpGirisBilgileri.ResumeLayout(false);
            this.grpGirisBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTek;
        private System.Windows.Forms.TabPage tabPageCift;
        private System.Windows.Forms.TabPage tabPageAsal;
        private System.Windows.Forms.TabPage tabPageArms;
        private System.Windows.Forms.GroupBox grpGirisBilgileri;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCift;
        private System.Windows.Forms.ListView listViewAsal;
        private System.Windows.Forms.ListView listViewArmstrong;
        private System.Windows.Forms.ListView listViewTek;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.MaskedTextBox txtSonSayi;
        private System.Windows.Forms.MaskedTextBox txtBaslanacakSayi;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MaskedTextBox txtCarpımlarSonucu;
        private System.Windows.Forms.MaskedTextBox txtToplamlarSonucu;
        private System.Windows.Forms.Label Toplamlar;
        private System.Windows.Forms.Label label3;
    }
}

