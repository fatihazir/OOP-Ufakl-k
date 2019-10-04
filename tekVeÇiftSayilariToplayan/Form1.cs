using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace tekVeÇiftSayilariToplayan
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public void appConfigYazma(string sonTab)
        {

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["acilacakTab"].Value = sonTab;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            
           
            
        }
        public string appConfigOkuma()
        {
            string formAcilacakTab = System.Configuration.ConfigurationManager.AppSettings["acilacakTab"];
            return formAcilacakTab;
        }
        
        
        void DosyaYaz(string islemTipi, int sonucToplam, double sonucCarpim)
        {
           
            StreamWriter sw = new StreamWriter("Log.txt", true);
            sw.WriteLine(islemTipi + " Toplama işlemi Sonucu:" + sonucToplam +"   "+ "Tarih ve zaman:" + DateTime.Now);
            sw.WriteLine(islemTipi + " Çarpma işlemi sonucu:" + sonucCarpim +"   "+ "Tarih ve zaman:" + DateTime.Now);
            sw.WriteLine("\n");
            sw.Flush();
            sw.Close();
           
        }
        void ListeleTek(int sayiTek)
        {
            listViewTek.Items.Add(sayiTek.ToString());
        }
        void ListeleCift(int sayiCift)
        {
            listViewCift.Items.Add(sayiCift.ToString());
        }
        void ListeleAsal(int sayiAsal)
        {
            listViewAsal.Items.Add(sayiAsal.ToString());
        }
        void ListeleArmstrong(int sayiArms)
        {
            listViewArmstrong.Items.Add(sayiArms.ToString());
        }
        void EkranHazirla()
        {
            txtBaslanacakSayi.Text = "1";
            txtSonSayi.Text = "10000";
            txtBaslanacakSayi.Focus();
        }
        
        void Bildirim()
        {
            notifyIcon1.Text = "NYP ödevi";
            notifyIcon1.BalloonTipText = "İki değer arasında sayı listeleme.";
            notifyIcon1.BalloonTipTitle = "Program Açıldı.";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000);
        }
        Boolean Dogrula()
        {
            if (Convert.ToInt32(txtBaslanacakSayi.Text) < Convert.ToInt32(txtSonSayi.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        int Tek()
        {
            int tekToplam = 0;
            double tekCarpim = 1;
            
            for (int i = Convert.ToInt32(txtBaslanacakSayi.Text); i <= Convert.ToInt32(txtSonSayi.Text); i++)
            {
                if (i % 2 !=0)
                {
                    tekToplam += i;
                    tekCarpim *= i;
                    ListeleTek(i);
                }
                
            }
            DosyaYaz("Tek sayilar", tekToplam, tekCarpim);

            txtToplamlarSonucu.Text = tekToplam.ToString();
            txtCarpımlarSonucu.Text = tekCarpim.ToString();
            
            return tekToplam;
           
        }
        int Cift()
        {
            int ciftToplam = 0;
            double ciftCarpim = 1;

            for (int i = Convert.ToInt32(txtBaslanacakSayi.Text); i <= Convert.ToInt32(txtSonSayi.Text); i++)
            {
                if (i % 2 == 0)
                {
                    ciftToplam += i;
                    ciftCarpim *= i;
                    ListeleCift(i);

                }
               
            }
            txtToplamlarSonucu.Text = ciftToplam.ToString();
            txtCarpımlarSonucu.Text = ciftCarpim.ToString();

            DosyaYaz("Çift sayilar",ciftToplam, ciftCarpim);

            return ciftToplam;
        }
        int asal()
        {
            int asalToplam = 0;
            double asalCarpim = 1;
            Boolean asalMi = true;

            int ilkSayi = Convert.ToInt32(txtBaslanacakSayi.Text);
            int sonSayi = Convert.ToInt32(txtSonSayi.Text);
          
                while (ilkSayi<sonSayi)
                {
                    ilkSayi++;
                     for (int i = 2; i < ilkSayi; i++)
                     {
                        if (ilkSayi % i == 0) 
                        {
                        asalMi = false;
                        }
                     }
                
                     if (asalMi == true)
                     {
                         asalToplam += ilkSayi;
                         ListeleAsal(ilkSayi);
                         asalCarpim *= ilkSayi;
                     }
                asalMi = true;

                }

            txtToplamlarSonucu.Text = asalToplam.ToString();
            txtCarpımlarSonucu.Text = asalCarpim.ToString();

            DosyaYaz("Asal Sayilar",asalToplam, asalCarpim);

            return asalToplam;
        }
        
        private void SadeceSayiGir(KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                e.Handled = true;
        }
        
        int Arms()
        {   int deger, temp, armsToplam = 0;
            int armsCarpim = 1;

            int ilkSayi = Convert.ToInt32(txtBaslanacakSayi.Text);
            int sonSayi = Convert.ToInt32(txtSonSayi.Text);

            for (int i = ilkSayi; i <= sonSayi; i++)
            {
                temp = i;
                armsToplam = 0;
                while (temp != 0)
                {
                    deger = temp % 10;
                    temp = temp / 10;
                    armsToplam = armsToplam + (deger * deger * deger);
                }
                if (armsToplam == i)
                {
                    ListeleArmstrong(i);
                    armsToplam += i;
                    armsCarpim += i;

                }
            }
            txtToplamlarSonucu.Text = armsToplam.ToString();
            txtCarpımlarSonucu.Text = armsCarpim.ToString();

            DosyaYaz("Armstrong sayilar",armsToplam, armsCarpim);

            return armsCarpim;

        }
 
        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                if (tabControl1.SelectedTab == tabPageTek)
                { 
                    Tek();
                    EkranHazirla();
                }
                if (tabControl1.SelectedTab == tabPageCift)
                {
                    Cift();
                    EkranHazirla();
                }
                if (tabControl1.SelectedTab == tabPageAsal)
                {
                    asal();
                    EkranHazirla();
                }
                if (tabControl1.SelectedTab == tabPageArms)
                {
                    Arms();
                    EkranHazirla();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            
        }
       
        private void Form1_Shown(object sender, EventArgs e)
        {
            EkranHazirla();
            Bildirim();
            string acilacakTab = appConfigOkuma();
            if (acilacakTab == "Tek sayılar")
            {
                tabControl1.SelectedTab = tabPageTek;
            }
            if (acilacakTab == "Çift sayılar")
            {
                tabControl1.SelectedTab = tabPageCift;
            }
            if (acilacakTab == "Asal sayılar")
            {
                tabControl1.SelectedTab = tabPageAsal;
            }
            if (acilacakTab == "Armstrong sayılar")
            {
                tabControl1.SelectedTab = tabPageArms;
            }

        }

        private void TxtBaslanacakSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            SadeceSayiGir(e);
        }

        private void TxtSonSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            SadeceSayiGir(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EkranHazirla();
        }

        private void BtnIleri_Click(object sender, EventArgs e)
        {
            (tabControl1.SelectedIndex) += 1;
        }
        

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            (tabControl1.SelectedIndex) -= 1;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            appConfigYazma(tabControl1.SelectedTab.Text);           
        }
    }
}
