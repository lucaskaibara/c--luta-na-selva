using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class AnimalController
    {
        public List<Animal> InicializarPecas()
        {
            List<Animal> lstAnimal = new List<Animal>();

            for (int i = 0; i < 16; i++)
            {
                Animal animal = new Animal();
                animal.pictureBox = new PictureBox();

                if (i <= 7)
                    animal.jogador = 1;

                else
                    animal.jogador = 2;

                if (i == 0 || i == 8)
                {
                    animal.nome = "Rato";
                    animal.valor = 1;
                }

                else if (i == 1 || i == 9)
                {
                    animal.nome = "Gato";
                    animal.valor = 2;
                }

                else if (i == 2 || i == 10)
                {
                    animal.nome = "Cachorro";
                    animal.valor = 3;
                }

                else if (i == 3 || i == 11)
                {
                    animal.nome = "Lobo";
                    animal.valor = 4;
                }

                else if (i == 4 || i == 12)
                {
                    animal.nome = "Leopardo";
                    animal.valor = 5;
                }

                else if (i == 5 || i == 13)
                {
                    animal.nome = "Tigre";
                    animal.valor = 6;
                }

                else if (i == 6 || i == 14)
                {
                    animal.nome = "Leão";
                    animal.valor = 7;
                }

                else if (i == 7 || i == 15)
                {
                    animal.nome = "Elefante";
                    animal.valor = 8;
                }

                if (i == 0)
                    animal.pictureBox.Image = Properties.Resources.rato;

                else if (i == 1)
                    animal.pictureBox.Image = Properties.Resources.gato;

                else if (i == 2)
                    animal.pictureBox.Image = Properties.Resources.cachorro;

                else if (i == 3)
                    animal.pictureBox.Image = Properties.Resources.lobo;

                else if (i == 4)
                    animal.pictureBox.Image = Properties.Resources.leopardo;

                else if (i == 5)
                    animal.pictureBox.Image = Properties.Resources.tigre;

                else if (i == 6)
                    animal.pictureBox.Image = Properties.Resources.leao;

                else if (i == 7)
                    animal.pictureBox.Image = Properties.Resources.elefante;

                else if (i == 8)
                    animal.pictureBox.Image = Properties.Resources.rato1;

                else if (i == 9)
                    animal.pictureBox.Image = Properties.Resources.gato1;

                else if (i == 10)
                    animal.pictureBox.Image = Properties.Resources.cachorro1;

                else if (i == 11)
                    animal.pictureBox.Image = Properties.Resources.lobo1;

                else if (i == 12)
                    animal.pictureBox.Image = Properties.Resources.leopardo1;

                else if (i == 13)
                    animal.pictureBox.Image = Properties.Resources.tigre1;

                else if (i == 14)
                    animal.pictureBox.Image = Properties.Resources.leao1;

                else if (i == 15)
                    animal.pictureBox.Image = Properties.Resources.elefante1;

                animal.pictureBox.Name = animal.nome + animal.jogador;
                animal.pictureBox.Margin = new Padding(0, 0, 0, 0);
                animal.pictureBox.Width = 60;
                animal.pictureBox.Height = 60;

                animal.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //animal.pictureBox.Click += (sender, e) => SelecionarPeca(sender, e, animal);

                lstAnimal.Add(animal);
            }

            return lstAnimal;
        }
    }
}
