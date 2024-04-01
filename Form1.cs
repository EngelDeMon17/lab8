﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        List<NotasAlumno> NotasAlumnos = new List<NotasAlumno>();

        List<int> notaTemp = new List<int>(); //lista temporal 
        //se coloca aqui para que no elimine la nota guardada
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregarNota_Click(object sender, EventArgs e)
        {
            
            int nota = Convert.ToInt16(textBoxNota.Text); //la tomamos del textbox y se convierte
            notaTemp.Add(nota); //se añade
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //se guarda a un alumno con sus notas
            NotasAlumno notasAlumno = new NotasAlumno();
            notasAlumno.Nombre = textBoxNombre.Text;
            notasAlumno.Nota = notaTemp;
            //guarda a ese alumno en el listado de notas de alumnos
            NotasAlumnos.Add(notasAlumno);
            //borra las listas temporales
            notaTemp.Clear();


        }
    }
}
