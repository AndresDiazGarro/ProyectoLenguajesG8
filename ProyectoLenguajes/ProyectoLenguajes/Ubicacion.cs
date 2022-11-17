using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
Imports System.Text;

namespace ProyectoLenguajes
{
    public partial class Ubicacion : Form
        
    {
        public Ubicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            Dim postcode As String = String.Empty
            Dim stringSearch As New StringBuilder

            stringSearch.append("http://www.google.com/maps")
            If txtSearch.Text <> String.Empty Then
                postcode = txtSearch.Text.Replace("","+")
                stringSearch.Append(postcode + "," & "+")
            End If

            WebBrowser.Navigate(stringSearch.ToString)
        {

        }
    }
}
