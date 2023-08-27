using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tres_imágenes
{
	public partial class MainForm : Form
	{
		string[] imagenes;
		int posicion0, posicion1, posicion2;
		int[] veces;
		public MainForm()
		{
			InitializeComponent();
		}
		
		void funcion_click(object sender, EventArgs e){
			var random = new Random();
			posicion0=random.Next(3);
			do{
				posicion1=random.Next(3);
			}while(posicion1==posicion0);
			do{
				posicion2=random.Next(3);
			}while(posicion2==posicion1 || posicion2==posicion0);
			
			pic0.Image=Image.FromFile(imagenes[posicion0]);
			pic1.Image=Image.FromFile(imagenes[posicion1]);
			pic2.Image=Image.FromFile(imagenes[posicion2]);
			
			if(posicion0==0){
				veces[0]++;
			}
			if(posicion1==1){
				veces[1]++;
			}
			if(posicion2==2){
				veces[2]++;
			}
			lbl0.Text="Veces que salió Burbuja: "+veces[0].ToString();
			lbl1.Text="Veces que salió Bellota: "+veces[1].ToString();
			lbl2.Text="Veces que salió Bombón: "+veces[2].ToString();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imagenes = new string[3];
			veces = new int[3];
			imagenes[0]="C:\\Users\\Fiski\\Downloads\\Burbuja.png";
			imagenes[1]="C:\\Users\\Fiski\\Downloads\\Bellota.png";
			imagenes[2]="C:\\Users\\Fiski\\Downloads\\Bombón.png";
		}
	}
}
