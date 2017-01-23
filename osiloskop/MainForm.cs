/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: musta
 * Tarih: 18.01.2017
 * Zaman: 16:21
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace osiloskop
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public int yatayhız=10;
		public double sonuc=0;
		public double dikeyhız=0;
		bool hulle=true;
		bool suruklenmedurumu = false; //Class seviyesinde bir field(değişken) tanımlıyoruz ki,MouseDown da biz bunu true yapacağız,MouseUpta false değerini alacak ve MouseMove eventında true ise hareket edecek.
		Point ilkkonum; //Global bir değişken tanımlıyoruz ki, ilk tıkladığımız andaki konumunu çıkarmadığımızda buton mouse imlecinden daha aşağıdan hareket edecektir.
			public bool hangisi()
			{
				if(label2.Location.Y<label1.Location.Y)return true;else return false;
			}			
		public void guncel(){
				if(hangisi())
			sonuc=-(176*Math.Pow(10,9)*trackBar1.Value/((label1.Location.Y-label2.Location.Y)*Math.Pow(10,9)))+trackBar2.Value;	
			else
				sonuc=(176*Math.Pow(10,9)*trackBar1.Value/((label2.Location.Y-label1.Location.Y)*Math.Pow(10,9)))+trackBar2.Value;	
			label5.Text=sonuc.ToString();
			if(sonuc>0)
				label5.BackColor=Color.Red;
			else 
				label5.BackColor=Color.Blue;
		}
		
		private void Down(object sender, MouseEventArgs e)
		{
			suruklenmedurumu = true; //işlemi burada true diyerek başlatıyoruz.
			((Label)sender).Cursor = Cursors.SizeAll; //SizeAll yapmamımızın amacı taşırken hoş görüntü vermek için
			ilkkonum = e.Location; //İlk konuma gördüğünüz gibi değerimizi atıyoruz.
		}
		private void Move(object sender, MouseEventArgs e)
		{
			if (suruklenmedurumu) // suruklenmedurumu==true ile aynı.
			{
				((Label)sender).Left = e.X + ((Label)sender).Left - (ilkkonum.X);
				// button.left ile soldan uzaklığını ayarlıyoruz. Yani e.X dediğimizde buton üzerinde mouseun hareket ettiği pixeli alacağız + butonun soldan uzaklığını ekliyoruz son olarakta ilk mouseın tıklandığı alanı çıkarıyoruz yoksa butonun en solunda olur mouse imleci. Alttakide aynı şekilde Y koordinati için geçerli
				((Label)sender).Top = e.Y + ((Label)sender).Top - (ilkkonum.Y);
			}
		}
		private void Up(object sender, MouseEventArgs e)
		{
			suruklenmedurumu = false; //Sol tuştan elimizi çektik artık yani sürükle işlemi bitti.
			((Label)sender).Cursor = Cursors.Default; //İmlecimiz(Cursor) default değerini alıyor.
			guncel();
		}

		void TrackBar1Scroll(object sender, EventArgs e)
		{
			label3.Text="V(10^-9):"+trackBar1.Value;	
			guncel();
		}
		
		void TrackBar2Scroll(object sender, EventArgs e)
		{
			label4.Text="G:"+trackBar2.Value;
			guncel();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{ 
			guncel();
			timer1.Start();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
		/*	if(hulle)
			{
				trackBar1.Value=trackBar1.Value+1;
				if(trackBar1.Value==10)hulle=false;
			}
			else{
				trackBar1.Value=trackBar1.Value-1;
				if(trackBar1.Value==0)hulle=true;
			}*/
	
			dikeyhız+=sonuc;
			radioButton1.Location=new Point(radioButton1.Location.X+yatayhız,radioButton1.Location.Y+(int)dikeyhız);
			if(radioButton1.Location.X>1300)
			{
				radioButton1.Location=new Point(141,282);
				dikeyhız=0;
			}

				
			if(hangisi())
			{
				if(radioButton1.Location.Y<label2.Location.Y)
			
				radioButton1.Location=new Point(radioButton1.Location.X,label2.Location.Y);
	
					if(radioButton1.Location.Y>label1.Location.Y)
				radioButton1.Location=new Point(radioButton1.Location.X,label1.Location.Y);
			}else{
								if(radioButton1.Location.Y<label1.Location.Y)
			
				radioButton1.Location=new Point(radioButton1.Location.X,label1.Location.Y);
	
					if(radioButton1.Location.Y>label2.Location.Y)
				radioButton1.Location=new Point(radioButton1.Location.X,label2.Location.Y);
			}
		}
		
		
		
		void TrackBar3Scroll(object sender, EventArgs e)
		{
			yatayhız=trackBar3.Value;
			label6.Text="yatay hız:"+yatayhız;
		}
	}
}
