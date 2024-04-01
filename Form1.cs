using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
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
        public void GrabarNotas()
        {
            //recordatorio instalar paquetes json
            //Se serializa (convierte) la lista en formato Json y se guarda en una variable de tipo string
            string json = JsonConvert.SerializeObject(NotasAlumnos);

            //El nombre del archivo
            string archivo = "Datos.json";

            //Se escribe la variable que contiene el json al archivo en un solo paso
            //con WriteAllText se escribe todo de un solo
            System.IO.File.WriteAllText(archivo, json);       
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
            notasAlumno.Nota = notaTemp.GetRange(0, notaTemp.Count);
            //guarda a ese alumno en el listado de notas de alumnos
            NotasAlumnos.Add(notasAlumno);
            GrabarNotas();
            //borra las listas temporales
            notaTemp.Clear();

           
        }
    }
}
