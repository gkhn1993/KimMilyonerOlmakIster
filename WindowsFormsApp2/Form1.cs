using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.App_code;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruIndis = 0;
        bool devam = true;
        List<Soru> sorular = new List<Soru>();
        private void Form1_Load(object sender, EventArgs e)
        {
            sorularFill();
            getSoru();
            label1.Text = "Soru 1: ";
            
        }
        void getSoru()
        {
            Soru item = sorular[soruIndis];
            lblSoru.Text = item.soru;

            btnSecenekA.Text = item.secenekA;
            btnSecenekA.BackColor = Color.Transparent;

            btnSecenekB.Text = item.secenekB;
            btnSecenekB.BackColor = Color.Transparent;

            btnSecenekC.Text = item.secenekC;
            btnSecenekC.BackColor = Color.Transparent;

            btnSecenekD.Text = item.secenekD;
            btnSecenekD.BackColor = Color.Transparent;


        }
        string getKazanilanPara()
        {
            int paraToplam = 0;
            foreach (var item in sorular)
            {
                if (item.secenekCevap == item.secenekKullaniciCevap)
                {
                    paraToplam = item.odul;
                }
            }
            return string.Format("{0:C}", paraToplam);
        }
        void setKullaniciCevap(string secenek, Button button)
        {
            if (devam)
            {
                if (string.IsNullOrEmpty(sorular[soruIndis].secenekKullaniciCevap))
                {
                    DialogResult dialogResult = MessageBox.Show(button.Text + " son kararınız mı?", "Son kararınız mı?", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sorular[soruIndis].secenekKullaniciCevap = secenek;
                        lblOdul.Text = getKazanilanPara();

                        if (sorular[soruIndis].secenekCevap == sorular[soruIndis].secenekKullaniciCevap)
                        {
                            button.BackColor = Color.Green;
                        }
                        else
                        {
                            devam = false;
                            button.BackColor = Color.Red;

                            MessageBox.Show("Yarisma bitti. Kazanilan para : " + getKazanilanPara());

                            switch (sorular[soruIndis].secenekCevap)
                            {
                                case "A":
                                    btnSecenekA.BackColor = Color.Green;
                                    break;
                                case "B":
                                    btnSecenekB.BackColor = Color.Green;
                                    break;
                                case "C":
                                    btnSecenekC.BackColor = Color.Green;
                                    break;
                                case "D":
                                    btnSecenekD.BackColor = Color.Green;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Soruya cevap verdiniz. Sonraki soruya geciniz.");
                }
            }
            else
            {
                MessageBox.Show("Yarisma maalesef bitti...");
                Application.Exit();
            }
        }
        void sorularFill()
        {
            sorular.Add(new Soru()
            {
                soru = "Yunan mitolojisinde Eros ok atarak insanların birbirlerine hangisini hissetmesini sağlar?",
                secenekA = "Aşk",
                secenekB = "Şefkat",
                secenekC = "Güven",
                secenekD = "Sabır",
                secenekCevap = "A",
                odul = 500
            });
            sorular.Add(new Soru()
            {
                soru = "Kumaşın kenarına tığ ile işlenen, eski evlerde sıkça görülen, giysi ve örtülerde kullanılan örgüye ne ad verilir?",
                secenekA = "Fisto",
                secenekB = "Kanaviçe",
                secenekC = "Kurdele",
                secenekD = "Dantel",
                secenekCevap = "D",
                odul = 1000
            });
            sorular.Add(new Soru()
            {
                soru = "Bir insanın hastalığı ne olursa olsun, iyi gelmesi için klişe olarak hangisi pişirilir?",
                secenekA = "Çorba",
                secenekB = "Mantı",
                secenekC = "Menemen",
                secenekD = "Muhallebi",
                secenekCevap = "A",
                odul = 2000
            });
            sorular.Add(new Soru()
            {
                soru = "Dedesiyle dağda yaşayan, arkadaşı Peter ile mutlu günler geçiren, daha sonra yayınlanan kitapta Peter ile evlenen çizgi" +
                "film karakteri kimdir?",
                secenekA = "Heidi",
                secenekB = "Alice",
                secenekC = "Pollyanna",
                secenekD = "Candy",
                secenekCevap = "A",
                odul = 3000
            });
            sorular.Add(new Soru()
            {
                soru = "Eski bir türk masalına adını veren gülen ayva ile birlikte ağlayan meyve hangisidir?",
                secenekA = "Elma",
                secenekB = "Dut",
                secenekC = "Nar",
                secenekD = "Üzüm",
                secenekCevap = "C",
                odul = 5000
            });
            sorular.Add(new Soru()
            {
                soru = "Bir işin uygun ve kolay olduğunu belirtmek için hangisi söylenir?",
                secenekA = "Burnuma göre",
                secenekB = "Kaşıma Göre",
                secenekC = "Bıyığıma göre ",
                secenekD = "Dişime göre",
                secenekCevap = "D",
                odul = 7500
            });
            sorular.Add(new Soru()
            {
                soru = "Atasözüne göre gönülden de ırak olan kimdir?",
                secenekA = "Arabası tamircide olan",
                secenekB = "Evi uzak olan",
                secenekC = "Gözden ırak olan",
                secenekD = "İş yeri karşıda olan",
                secenekCevap = "C",
                odul = 15000
            });
            sorular.Add(new Soru()
            {
                soru = "Hangisi, bazı futbol takımlarının, taraftarları için kullandıkları bir ifadedir?",
                secenekA = "12. Adam",
                secenekB = "Yardımcı eleman",
                secenekC = "Canlı destek",
                secenekD = "Yedek kuvvet",
                secenekCevap = "A",
                odul = 30000
            });
            sorular.Add(new Soru()
            {
                soru = "Horozu çok olan köyde şeklinde başlayan atasözünün devamı nasıldır?",
                secenekA = "Sabah erken olur",
                secenekB = "Akşam geç olur",
                secenekC = "Akşam erken olur",
                secenekD = "Sabah geç olur",
                secenekCevap = "D",
                odul = 60000
            });
            sorular.Add(new Soru()
            {
                soru = "Sosyal medyada, kısa sürede ve kolayca takipçi kazanmak isteyenlerin uyguladığı klişe taktik hangisidir?",
                secenekA = "Atara atar gidere gider",
                secenekB = "Omuz omuza",
                secenekC = "göze göz dişe diş",
                secenekD = "Takibe takip",
                secenekCevap = "D",
                odul = 125000
            });
            sorular.Add(new Soru()
            {
                soru = "Gıpgıcır ne anlama gelir?",
                secenekA = "Yepyeni",
                secenekB = "Tozpembe",
                secenekC = "Sapsarı",
                secenekD = "Çok eski",
                secenekCevap = "A",
                odul = 250000
            });
            sorular.Add(new Soru()
            {
                soru = "Trafikte hangi araçların arkasında Dolu ya da Boş yazar?",
                secenekA = "Akaryakıt tankeri",
                secenekB = "Öğrenci servisi",
                secenekC = "Harfiyat kamyonu",
                secenekD = "Yolcu otobüsü",
                secenekCevap = "A",
                odul = 500000
            });
            sorular.Add(new Soru()
            {
                soru = "Çubuklara geçirilmiş küçük bayraklarla işaretlenmiş bir parkurda, belli kurallara göre ve zikzaklar çizerek yapılan kayak yarışı hangisidir?",
                secenekA = "Skeleton",
                secenekB = "Pentatlon",
                secenekC = "Slalom",
                secenekD = "Maraton",
                secenekCevap = "C",
                odul = 750000
            });
            sorular.Add(new Soru()
            {
                soru = "Gövdesi sarı veya kirli sarı; yelesi, kuyruğu ve bacağının alt kısmındaki kılları koyu renkte olan atlar içi kullanılan ifade hangisidir?",
                secenekA = "Doru",
                secenekB = "Kula",
                secenekC = "Yağız",
                secenekD = "Seki",
                secenekCevap = "B",
                odul = 900000
            });
            sorular.Add(new Soru()
            {
                soru = "3 korner 1 penaltı, gol atan kaleye, atan alır gibi kuralları varsa, oynadığınız futbol maçı muhtemelen hangisine dahildir?",
                secenekA = "FIFA Dünya Kupası",
                secenekB = "UEFA Şampiyonlar ligi",
                secenekC = "Bundesliga",
                secenekD = "Mahalle maçı",
                secenekCevap = "D",
                odul = 1000000
            });




        }
        void getSonrakiSoru()
        {
            
            if (devam)
            {
                if (!string.IsNullOrEmpty(sorular[soruIndis].secenekKullaniciCevap))
                {
                    if ((sorular.Count - 1) > soruIndis)
                    {
                       
                        soruIndis++;
                        label1.Text = "Soru " + (soruIndis + 1).ToString() +  ": ";
                        getSoru();
                    }
                    else
                    {
                        MessageBox.Show("Yarisma bitti. Kazanilan para : " + getKazanilanPara());
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Soruya cevap veriniz...");
                }
            }
            else
            {
                MessageBox.Show("Yarisma maalesef bitti...");
                Application.Exit();
            }
        }
        private void btnSecenekA_Click(object sender, EventArgs e)
        {
            setKullaniciCevap("A", (Button)sender);
        }

        private void btnSecenekB_Click(object sender, EventArgs e)
        {
            setKullaniciCevap("B", (Button)sender);
        }

        private void btnSecenekC_Click(object sender, EventArgs e)
        {
            setKullaniciCevap("C", (Button)sender);
        }

        private void btnSecenekD_Click(object sender, EventArgs e)
        {
            setKullaniciCevap("D", (Button)sender);
        }

        private void btnSonrakiSoru_Click(object sender, EventArgs e)
        {
            getSonrakiSoru();
        }
    }
}
