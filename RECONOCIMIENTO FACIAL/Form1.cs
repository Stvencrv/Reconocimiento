using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace RECONOCIMIENTO_FACIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FaceRec facerec = new FaceRec();

        private void camara_Click(object sender, EventArgs e)
        {
            facerec.openCamera(pictureBox1, pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            facerec.Save_IMAGE(textBox1.Text);
            MessageBox.Show("Se guardo con exito");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            facerec.isTrained = true;  
        }

        private void label4_Click(object sender, EventArgs e)
        {
            facerec.getPersonName(label4);

        }
        private void get_person_info()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Steven", ID = 1, Correo = "steven@yes.com", telefono = "8091234569" });
            people.Add(new Person() { Name = "Gerson", ID = 2, Correo = "gilson@yes.com", telefono = "849122569" });
            people.Add(new Person() { Name = "Erick", ID = 3, Correo = "erick@yes.com", telefono = "8491534569" });
            people.Add(new Person() { Name = "Huascar", ID = 4, Correo = "huascar@yes.com", telefono = "8491224669" });
            people.Add(new Person() { Name = "omar", ID = 5, Correo = "omar@yes.com", telefono = "829123693" });


            var filterPerson = people.Where(p => p.Name ==label4.Text);
            foreach (  var person in filterPerson)
            {
                label5.Text = person.ID.ToString();
                label6.Text = person.Correo.ToString();
                label7.Text = person.telefono.ToString();
            }
            
        }

        private void Ayuda_Click(object sender, EventArgs e)
        {
            string message = "Para usar el programa:1.Camara ,este boton es para abrir la camara,2.Guardar imagen,este boton se usa para guardar al usuario,3.Detectar cara, se utiliza para detectar la cara seleccionada, 4.Consulta, se utiliza para ver los datos de la persona detectada"; 
            string title = "ayuda";
            MessageBox.Show(message, title);
        }


        private void btnconsulta_Click(object sender, EventArgs e)
        {
            get_person_info();

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Correo { get; set; }
        public string telefono { get; set; }




    }
}
 