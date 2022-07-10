namespace ListBox_TimePicker
{
    public partial class Form1 : Form
    {
        List<string> ListaIntegrantes = new List<string>();

        public Form1()
        {
            InitializeComponent();
            DatosAlumno();
        }

        private void DatosAlumno()
        {
            lb_Alumnos.Items.Add("José Sánchez");
            lb_Alumnos.Items.Add("Josthin Ayon");
            lb_Alumnos.Items.Add("Diego Jacome");
            lb_Alumnos.Items.Add("Isaias Macias");
            lb_Alumnos.Items.Add("Oscar Loor");
            lb_Alumnos.Items.Add("Luis Minionlover");
            lb_Alumnos.Items.Add("Jostin Cantos");
        }

        private void AgregarIntegrante()
        {
            if (lb_Alumnos.Items.Count > 0)
            {
                if (lb_Alumnos.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Seleccione solo un alumno");
                }
                else if (lb_Alumnos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione un alumno");
                }
                else
                {
                    if (lb_Alumnos.SelectedIndex > -1)
                    {
                        ListaIntegrantes.Add(lb_Alumnos.Text);

                        lb_Integrantes.Items.Add(lb_Alumnos.Text);

                        lb_Alumnos.Items.Remove(lb_Alumnos.SelectedItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay alumnos para agregar");
            }
        }

        private void QuitarIntegrante()
        {
            if (lb_Integrantes.Items.Count > 0)
            {
                if (lb_Integrantes.SelectedItems.Count > 1)
                {
                    MessageBox.Show("Seleccione solo un integrante");
                }
                else if (lb_Integrantes.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Seleccione un integrante");
                }
                else
                {
                    if (lb_Integrantes.SelectedIndex > -1)
                    {
                        ListaIntegrantes.Remove(lb_Integrantes.Text);

                        lb_Alumnos.Items.Add(lb_Integrantes.Text);

                        lb_Integrantes.Items.Remove(lb_Integrantes.SelectedItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay integrante para quitar");
            }
        }

        private void QuitarTodos()
        {
            if (lb_Integrantes.Items.Count > 0)
            {
                foreach (string item in lb_Integrantes.Items)
                {
                    lb_Alumnos.Items.Add(item);
                }
                lb_Integrantes.Items.Clear();
                ListaIntegrantes.Clear();
            }
            else
            {
                MessageBox.Show("No hay integrante para quitar");
            }
        }

        private void GuardarIntegrante()
        {
            if (ListaIntegrantes.Count > 0)
            {
                if (ListaIntegrantes.Count < 3)
                {
                    MessageBox.Show("El equipo debe tener al menos 3 integrantes");
                }
                else if (ListaIntegrantes.Count > 5)
                {
                    MessageBox.Show("No se pueden guardar más de 5 integrantes");
                }
                else if (txt_EquipoTrabajo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el nombre del equipo");
                }
                else if (dtp_FechaInicio.Value.Date <= DateTime.Now.Date)
                {
                    MessageBox.Show("Ingrese una fecha mayor a la de hoy");
                }
                else
                {
                    ListViewItem itemAlumno = new ListViewItem();
                    foreach (string item in ListaIntegrantes)
                    {
                        itemAlumno = lv_Lista.Items.Add(item);
                        itemAlumno.SubItems.Add(txt_EquipoTrabajo.Text);
                        itemAlumno.SubItems.Add(dtp_FechaInicio.Value.ToShortDateString());
                    }
                    txt_EquipoTrabajo.Text = string.Empty;
                    dtp_FechaInicio.Text = string.Empty;
                    lb_Integrantes.Items.Clear();
                    ListaIntegrantes.Clear();
                }
            }
            else
            {
                MessageBox.Show("No hay integrantes para guardar");
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarIntegrante();
        }

        private void btn_Quitar_Click(object sender, EventArgs e)
        {
            QuitarIntegrante();
        }

        private void btn_QuitarTodo_Click(object sender, EventArgs e)
        {
            QuitarTodos();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarIntegrante();
        }
    }
}
