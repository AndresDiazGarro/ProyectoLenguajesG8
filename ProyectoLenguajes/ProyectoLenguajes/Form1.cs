﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using OracleDataReader;

namespace ProyectoLenguajes
{
    public partial class Form1 : Form

    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = ORCL; PASSWORD = DBFide1; USER ID = system;");
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM LOGIN WHERE NOM_USUARIO = :usuario AND CONTRASENA = :contra", conexion);

            comando.Parameters.AddWithValue(":usuario", txtusuario.Text);
            comando.Parameters.AddWithValue(":contra", txtcontrasena.Text);

            OracleDataReader lector = comando.ExecuteReader();
            {
                if (lector.Read())
                {
                    Form1 formulario = new Form1();
                    conexion.Close();
                    formulario.Show();

                    MessageBox.Show("Correcto bb");
                }
                else
                {

                    MessageBox.Show("Incorrecto bb");
                }
            }
        }


    }
}
