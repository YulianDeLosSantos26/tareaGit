using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocios;
using CapaPresentacion;

namespace Capa_de_Acceso_a_datos_20220592
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source =DESKTOP-OSRUOIR\\SQLEXPRESS;Initial Catalog=Agenda_electrónica;Integrated Security=True");
        private void btn_Insertar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String Nombre = textBox1.Text;
            String Apellido = textBox2.Text;
            String Fecha_Nacimiento = textBox3.Text;
            String Dirección = textBox4.Text;
            String Genero = textBox5.Text;
            String Estado_civil = textBox6.Text;
            String Movil = textBox7.Text;
            String Telefono = textBox8.Text;
            String Correo_electronico = textBox9.Text;
            String cadena = "insert into Agenda_Personas(Nombre,Apellido,Fecha_Nacimiento,Dirección,Genero,Estado_civil,Movil,Telefono,Correo_electronico)values(@Nombre,@Apellido,@Fecha_Nacimiento,@Dirección,@Genero,@Estado_civil,@Movil,@Telefono,@Correo_electronico)";

            using (SqlCommand cmm = new SqlCommand(cadena, conn))
            {
                cmm.Parameters.AddWithValue("@Nombre", Nombre);
                cmm.Parameters.AddWithValue("@Apellido", Apellido);
                cmm.Parameters.AddWithValue("@Fecha_Nacimiento", Fecha_Nacimiento);
                cmm.Parameters.AddWithValue("@Dirección", Dirección);
                cmm.Parameters.AddWithValue("@Genero", Genero);
                cmm.Parameters.AddWithValue("@Estado_civil", Estado_civil);
                cmm.Parameters.AddWithValue("@Movil", Movil);
                cmm.Parameters.AddWithValue("@Telefono", Telefono);
                cmm.Parameters.AddWithValue("@Correo_electronico", Correo_electronico);

                cmm.ExecuteNonQuery();

            }
            MessageBox.Show("Se logro insertar los datos de forma correcta");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            conn.Close();
        }
        
        private void Modificar(int id)
        {
            conn.Open();
            int Id = id;
            String Nombre = textBox1.Text;
            String Apellido = textBox2.Text;
            String Fecha_Nacimiento = textBox3.Text;
            String Dirección = textBox4.Text;
            String Genero = textBox5.Text;
            String Estado_civil = textBox6.Text;
            String Movil = textBox7.Text;
            String Telefono = textBox8.Text;
            String Correo_electronico = textBox9.Text;
            String cadena = "UPDATE Agenda_Personas SET Nombre = @Nombre, Apellido = @Apellido, Fecha_Nacimiento = @Fecha_Nacimiento, Dirección= @Dirección, Genero =@Genero, Estado_civil=@Estado_civil, Movil = @Movil, Telefono = @Telefono, Correo_electronico =@Correo_electronico WHERE Id = @Id;";

            using (SqlCommand cmm = new SqlCommand(cadena, conn))
            {
                cmm.Parameters.AddWithValue("@Nombre", Nombre);
                cmm.Parameters.AddWithValue("@Apellido", Apellido);
                cmm.Parameters.AddWithValue("@Fecha_Nacimiento", Fecha_Nacimiento);
                cmm.Parameters.AddWithValue("@Dirección", Dirección);
                cmm.Parameters.AddWithValue("@Genero", Genero);
                cmm.Parameters.AddWithValue("@Estado_civil", Estado_civil);
                cmm.Parameters.AddWithValue("@Movil", Movil);
                cmm.Parameters.AddWithValue("@Telefono", Telefono);
                cmm.Parameters.AddWithValue("@Correo_electronico", Correo_electronico);
                cmm.Parameters.AddWithValue("@Id", Id);

                cmm.ExecuteNonQuery();
            }
            MessageBox.Show("Se ha modificado corretamente los campos");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            conn.Close();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
            int id = Convert.ToInt32(textBox10.Text);
            Modificar(id);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            conn.Open();
            string Id = textBox10.Text;
            string cadena = "Select Nombre,Apellido,Fecha_Nacimiento,Dirección,Genero,Estado_civil,Movil,Telefono,Correo_electronico FROM Agenda_Personas WHERE Id =" + Id;
            SqlCommand cmd = new SqlCommand(cadena, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["Nombre"].ToString();
                textBox2.Text = reader["Apellido"].ToString();
                textBox3.Text = reader["Fecha_Nacimiento"].ToString();
                textBox4.Text = reader["Dirección"].ToString();
                textBox5.Text = reader["Genero"].ToString();
                textBox6.Text = reader["Estado_civil"].ToString();
                textBox7.Text = reader["Movil"].ToString();
                textBox8.Text = reader["Telefono"].ToString();
                textBox9.Text = reader["Correo_electronico"].ToString();
            }
            else
                MessageBox.Show("El registro no se localiza");
            conn.Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {
            conn.Open();
            int Id = Convert.ToInt32(textBox10.Text);
            string cadena = "delete from Agenda_Personas Where Id = @Id;";
            SqlCommand cmd = new SqlCommand(cadena, conn);
            using (SqlCommand cmm = new SqlCommand(cadena, conn))
            {
                cmm.Parameters.AddWithValue("Id", Id);
                cmm.ExecuteNonQuery();
            }
            MessageBox.Show("Se elimino correctamente de la base de datos");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirme cierre de sesion","Warning", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        
    
    }

}
