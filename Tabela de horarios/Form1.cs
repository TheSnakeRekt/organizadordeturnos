using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tabela_de_horarios
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox(object sender, EventArgs k)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Dias");
            dt.Columns.Add("Horas");
            dt.Columns.Add("Funcionario1");
            dt.Columns.Add("Funcionario2");
       
             DateTime sunday =new DateTime(2019, 2, 17) ;

            String turno1 = "18:10";
            String turno2 = "19:10";
            String a = "Nuno";
            String b = "Ricardo";
            String c = "Paula";
            String d = "Carmo";
            String f = "Vania"; 

            int y = 1;
            Console.WriteLine("Quantos meses quer imprimir");
            string userInput = Console.ReadLine();
            int gridprint = 12;



            for (int i = 0; i < gridprint; i++)
            {
                while (y == 1)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int x = y + j;

                        if (x == 1)
                        {
                            dt.Rows.Add(sunday.ToString("dd/MM/yyyy"), "16:30 - " + turno1, a, b);
                        }
                        else if (x == 2)
                        {
                            sunday = sunday.AddDays(7);
                            Convert.ToString(sunday);
                            dt.Rows.Add(sunday.ToString("dd/MM/yyyy"), "16:30 - " + turno2, c, d);
                        }
                        else if (x == 3)
                        {
                            sunday = sunday.AddDays(7);
                            Convert.ToString(sunday);
                            dt.Rows.Add(sunday.ToString("dd/MM/yyyy"), "16:30 - " + turno1, f, a);
                            y = 2;
                        }
                    }
                }
                while (y == 2)
                {
                    
                       int x = 4 ;
                    if (x == 4)
                    {
                        sunday = sunday.AddDays(7);
                        Convert.ToString(sunday);
                        dt.Rows.Add(sunday.ToString("dd/MM/yyyy"), "16:30 - " + turno2, b, c);
                        x = x + 1;

                        if (x == 5)
                        {
                            sunday = sunday.AddDays(7);
                            Convert.ToString(sunday);
                            dt.Rows.Add(sunday.ToString("dd/MM/yyyy"), "16:30 - " + turno2, d, f);
                            x = 0;
                            y = 1;
                        }
                    }
                    
                }
            }
            dataGridView1.DataSource = dt;
        }
    }
}
    