using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            txt_numero1.Clear();
            txt_numero2.Clear();
            lbl_resultado.Text = string.Empty;

            //txt_numero1.Text = "";
            //txt_numero1.Text = string.Empty;
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text=sumar(Convert.ToInt32(txt_numero1.Text), int.Parse(txt_numero2.Text)).ToString();
        }

        private int sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = resta(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(txt_numero2.Text)).ToString();
        }

        private int resta(int valor1, int valor2)
        {
            int resta = valor1 - valor2;

            return resta;
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = multiplicar(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(txt_numero2.Text)).ToString();
        }

        private int multiplicar(int valor1, int valor2)
        {
            int multiplicar = valor1 * valor2;

            return multiplicar;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = dividir(Convert.ToInt32(txt_numero1.Text), Convert.ToInt32(txt_numero2.Text)).ToString();
        }

        private int dividir(int valor1, int valor2)
        {
            int dividir = valor1 / valor2;

            return dividir;
        }
    }
}
