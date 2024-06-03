/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 6/3/2024
 * Time: 11:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace randomInsideClass
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
		public int rnd()
		{
			
			toRandom r = new toRandom();
			int x = r.rnd(0,6);
			r.del();
			return x;
		}
		
		void numergeasta()
		{
			
			for(int i = 0 ; i < 6; i++)
			{
				if(i%6==0){
				
					this.textBox1.Text += "\r\n";	
				}
				else
				{
					this.textBox1.Text +=rnd() + "\t\n";
				}
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			this.textBox1.Text +=rnd() + "\t\n";
		}
		/*
		 4	
3	
5	
3	
1	
2	
2	
1	
3	
1	
2	
5	
4	
3	
1	
2	
1	
5	
1	
0	
4	
5	
3	
2	
3	
2	
1	
5	
0	
1	
3	
4	
3	
1	
2	
3	
2	
2	
1	
1	
5	
0	
5	
1	
0	
5	
2	
4	
2	
2	
1	
5	
1	
4	
2	
2	
5	
4	
3	
5	
0	
0	
5	
4	
0	
1	
0	
5	
1	
1	
5	
5	
1	
5	
4	
5	
5	
5	
		 */
		public class toRandom
		{
			public Random r;
			public int rnd(int min, int max)
			{
				r = new Random();
				return r.Next(min, max);
				
			}
			public bool del()
			{
				r = null;
				return true;
			}
		}
		
	}
}
