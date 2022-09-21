using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGame
{
    public partial class Form2 : Form
    {
        public int NumQuestion = 1;
        public int Intentos = 5;
        public int Points = 1000;
        public int nextQuestion = 1;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Questions(NumQuestion, "None");
        }


        public void Questions(int NumQuestion, string Answer)
        {

            switch (NumQuestion)
            {

                case 1:
                    lblQuestion.Text = "¿Qué trilogía de las películas basadas en los cómics de Marvel recaudó más dinero en taquilla?";
                    a.Text = "a. Thor";
                    b.Text = "b. Capitán América";
                    c.Text = "c. Iron Man";
                    d.Text = "d. Wolverine";
                    if(Answer == "b")
                    {
                        more_Points(1);
                    }
                    if(Answer == "None")
                    {
                        break;
                    }
                    if(Answer != "b" && Answer != "None")
                    {
                        minus_Points(1);
                    }
                    break;
                case 2:
                    lblQuestion.Text = "¿Cuál de estos planetas está más cercano al sol?";
                    a.Text = "a. Neptuno";
                    b.Text = "b. Urano";
                    c.Text = "c. Saturno";
                    d.Text = "d. Tierra";
                    if (Answer == "d")
                    {
                        more_Points(2);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "d" && Answer != "None")
                    {
                        minus_Points(2);
                    }
                    break;
                case 3:
                    lblQuestion.Text = "¿Cuál es el océano más grande del mundo?";
                    a.Text = "a. Océano Pacífico";
                    b.Text = "b. Océano Índico";
                    c.Text = "c. Océano Antártico";
                    d.Text = "d. Océano Atlántico";
                    if (Answer == "a")
                    {
                        more_Points(3);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "a" && Answer != "None")
                    {
                        minus_Points(3);
                    }
                    break;
                case 4:
                    lblQuestion.Text = "¿Qué enfermedad tenía el legendario astrofísico Stephen Hawking?";
                    a.Text = "a. Enfermedad de Addison";
                    b.Text = "d. Progeria de Hutchinson-Gilford";
                    c.Text = "c. Esclerosis Lateral Amiotrófica";
                    d.Text = "d. Síndrome de Marfan";
                    if (Answer == "c")
                    {
                        more_Points(4);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "c" && Answer != "None")
                    {
                        minus_Points(4);
                    }
                    break;
                case 5:
                    lblQuestion.Text = "¿Como se llama el libro sagrado de la cultura Islámica?";
                    a.Text = "a. Talmud";
                    b.Text = "b. Torá";
                    c.Text = "c. Corán";
                    d.Text = "d. Kojiki";
                    if (Answer == "c")
                    {
                        more_Points(5);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "c" && Answer != "None")
                    {
                        minus_Points(5);
                    }
                    break;
                case 6:
                    lblQuestion.Text = "¿En que idioma original fue producida la reconocida película de animación El Viaje de Chihiro?";
                    a.Text = "a. Coreano";
                    b.Text = "b. Japonés";
                    c.Text = "c. Chino";
                    d.Text = "d. Samoano";
                    if (Answer == "b")
                    {
                        more_Points(6);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "b" && Answer != "None")
                    {
                        minus_Points(6);
                    }
                    break;
                case 7:
                    lblQuestion.Text = "¿Aproximadamente, qué porcentaje de la superficie de la Tierra es agua?";
                    a.Text = "a. 70%";
                    b.Text = "b. 50%";
                    c.Text = "c. 45%";
                    d.Text = "d. 80%";
                    if (Answer == "a")
                    {
                        more_Points(7);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "a" && Answer != "None")
                    {
                        minus_Points(7);
                    }
                    break;
                case 8:
                    lblQuestion.Text = "¿Cuál es el idioma oficial de Brasil?";
                    a.Text = "a.Brasileño";
                    b.Text = "b.Español";
                    c.Text = "c.Francés";
                    d.Text = "d.Portugués";
                    if (Answer == "d")
                    {
                        more_Points(8);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "d" && Answer != "None")
                    {
                        minus_Points(8);
                    }
                    break;
                case 9:
                    lblQuestion.Text = "¿Cuál es la capital de Mongolia?";
                    a.Text = "a.Makati City";
                    b.Text = "d.Nur - Sultan";
                    c.Text = "c.Naypyidaw";
                    d.Text = "d.Ulaanbaatar";
                    if (Answer == "d")
                    {
                        more_Points(9);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "d" && Answer != "None")
                    {
                        minus_Points(9);
                    }
                    break;
                case 10:
                    lblQuestion.Text = "¿Como se llama el libro sagrado de la cultura Islámica?";
                    a.Text = "a. Talmud";
                    b.Text = "b. Torá";
                    c.Text = "c. Corán";
                    d.Text = "d. Kojiki";
                    if (Answer == "c")
                    {
                        more_Points(10);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "c" && Answer != "None")
                    {
                        minus_Points(10);
                    }
                    break;
                case 11:
                    lblQuestion.Text = "¿Qué parte del cuerpo produce insulina?";
                    a.Text = "a.El páncreas";
                    b.Text = "b.El bazo";
                    c.Text = "c.El hígado";
                    d.Text = "d.El timo";
                    if (Answer == "c")
                    {
                        more_Points(11);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "c" && Answer != "None")
                    {
                        minus_Points(11);
                    }
                    break;
                case 12:
                    lblQuestion.Text = "¿En qué año se fundó la franquicia de comida rápida McDonalds?";
                    a.Text = "a. 1940";
                    b.Text = "b. 1945";
                    c.Text = "c. 1952";
                    d.Text = "d. 1967";
                    if (Answer == "a")
                    {
                        more_Points(12);
                    }
                    if (Answer == "None")
                    {
                        break;
                    }
                    if (Answer != "a" && Answer != "None")
                    {
                        minus_Points(12);
                    }
                    break;
                default:
                    break;
            }
        }
        public void more_Points(int numberQuestion)
        {
            lblPuntos.Text = Points.ToString();
            lblIntentos.Text = Intentos.ToString();
            nextQuestion = numberQuestion + 1;
            Points += 5000;
            Questions(nextQuestion, "None");

        }
        public void minus_Points(int numberQuestion)
        {
            lblPuntos.Text = Points.ToString();
            lblIntentos.Text = Intentos.ToString();
            nextQuestion = numberQuestion + 1; 
            Intentos = Intentos - 1;
            Questions(nextQuestion, "None");
        }



        private void a_Click(object sender, EventArgs e)
        {
            Questions(nextQuestion, "a");
        }
        private void b_Click(object sender, EventArgs e)
        {
            Questions(nextQuestion, "b");
        }

        private void c_Click(object sender, EventArgs e)
        {
            Questions(nextQuestion, "c");
        }

        private void d_Click(object sender, EventArgs e)
        {
            Questions(nextQuestion, "d");
        }


    }

}
