/*
 * Created by SharpDevelop.
 * User: CPD
 * Date: 09/10/2018
 * Time: 08:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace souForca
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
		
				String n;
		String m;
		int forca = 0;
		
		void Button1Click(object sender, EventArgs e)
		{
			Button bt = (Button)sender;
			StringBuilder aux = new StringBuilder(label1.Text);
			int erros = 0;
			
			for(int i = 0; i < n.Length; i++){
				
				if(n[i] == bt.Text[0]){
					aux[i] = bt.Text[0];
					label1.Text = aux.ToString();
				}else{
					erros++;
				}if(erros == n.Length){
					pictureBox1.Load("forca"+(forca++)+".png");
				}if(forca == 5){
					forca = 0;
					MessageBox.Show("Você é burro, perdeu o jogo");
					panel1.Visible = false;
				}
				}if(label1.Text == n){
					MessageBox.Show("Você não é tão burro, ganhou o jogo");
					panel1.Visible = false;
				}
				
			    
			erros = 0;
		}
		void Button28Click(object sender, EventArgs e)
		{
			
			n = textBox1.Text;
			
			for(int i = 0 ; i < n.Length; i++){
				m += "?";
				label1.Text = m;
			}
			
			textBox1.Visible = false;
			label1.Visible = true;
			button28.Visible = false;
			panel1.Visible = true;
		}
		void Button29Click(object sender, EventArgs e)
		{
			label1.Text = "";
			textBox1.Visible = true;
			label1.Visible = false;
			button28.Visible = true;
			m = "";
			pictureBox1.Load("forca0.png");
			forca = 0;
		}
	}
}
