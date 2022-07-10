namespace ListBox_TimePicker {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ListaAlumno = new System.Windows.Forms.Label();
            this.lbl_Integrantes = new System.Windows.Forms.Label();
            this.lbl_EquipoTrabajo = new System.Windows.Forms.Label();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Quitar = new System.Windows.Forms.Button();
            this.btn_QuitarTodo = new System.Windows.Forms.Button();
            this.lb_Alumnos = new System.Windows.Forms.ListBox();
            this.lb_Integrantes = new System.Windows.Forms.ListBox();
            this.txt_EquipoTrabajo = new System.Windows.Forms.TextBox();
            this.dtp_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lv_Lista = new System.Windows.Forms.ListView();
            this.Alumno = new System.Windows.Forms.ColumnHeader();
            this.EquipoTrabajo = new System.Windows.Forms.ColumnHeader();
            this.FechaInicio = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lbl_ListaAlumno
            // 
            this.lbl_ListaAlumno.AutoSize = true;
            this.lbl_ListaAlumno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ListaAlumno.Location = new System.Drawing.Point(52, 33);
            this.lbl_ListaAlumno.Name = "lbl_ListaAlumno";
            this.lbl_ListaAlumno.Size = new System.Drawing.Size(186, 30);
            this.lbl_ListaAlumno.TabIndex = 0;
            this.lbl_ListaAlumno.Text = "Lista de alumnos";
            // 
            // lbl_Integrantes
            // 
            this.lbl_Integrantes.AutoSize = true;
            this.lbl_Integrantes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Integrantes.Location = new System.Drawing.Point(578, 33);
            this.lbl_Integrantes.Name = "lbl_Integrantes";
            this.lbl_Integrantes.Size = new System.Drawing.Size(133, 30);
            this.lbl_Integrantes.TabIndex = 1;
            this.lbl_Integrantes.Text = "Integrantes";
            // 
            // lbl_EquipoTrabajo
            // 
            this.lbl_EquipoTrabajo.AutoSize = true;
            this.lbl_EquipoTrabajo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_EquipoTrabajo.Location = new System.Drawing.Point(34, 300);
            this.lbl_EquipoTrabajo.Name = "lbl_EquipoTrabajo";
            this.lbl_EquipoTrabajo.Size = new System.Drawing.Size(169, 28);
            this.lbl_EquipoTrabajo.TabIndex = 2;
            this.lbl_EquipoTrabajo.Text = "Equipo de trabajo";
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_FechaInicio.Location = new System.Drawing.Point(34, 357);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(141, 28);
            this.lbl_FechaInicio.TabIndex = 3;
            this.lbl_FechaInicio.Text = "Fecha de inicio";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(334, 102);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(140, 35);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agregar ->";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Quitar
            // 
            this.btn_Quitar.Location = new System.Drawing.Point(334, 143);
            this.btn_Quitar.Name = "btn_Quitar";
            this.btn_Quitar.Size = new System.Drawing.Size(140, 35);
            this.btn_Quitar.TabIndex = 4;
            this.btn_Quitar.Text = "<- Quitar";
            this.btn_Quitar.UseVisualStyleBackColor = true;
            this.btn_Quitar.Click += new System.EventHandler(this.btn_Quitar_Click);
            // 
            // btn_QuitarTodo
            // 
            this.btn_QuitarTodo.Location = new System.Drawing.Point(334, 184);
            this.btn_QuitarTodo.Name = "btn_QuitarTodo";
            this.btn_QuitarTodo.Size = new System.Drawing.Size(140, 35);
            this.btn_QuitarTodo.TabIndex = 5;
            this.btn_QuitarTodo.Text = "<- Quitar todo";
            this.btn_QuitarTodo.UseVisualStyleBackColor = true;
            this.btn_QuitarTodo.Click += new System.EventHandler(this.btn_QuitarTodo_Click);
            // 
            // lb_Alumnos
            // 
            this.lb_Alumnos.FormattingEnabled = true;
            this.lb_Alumnos.ItemHeight = 25;
            this.lb_Alumnos.Location = new System.Drawing.Point(34, 66);
            this.lb_Alumnos.Name = "lb_Alumnos";
            this.lb_Alumnos.Size = new System.Drawing.Size(240, 179);
            this.lb_Alumnos.TabIndex = 7;
            // 
            // lb_Integrantes
            // 
            this.lb_Integrantes.FormattingEnabled = true;
            this.lb_Integrantes.ItemHeight = 25;
            this.lb_Integrantes.Location = new System.Drawing.Point(524, 66);
            this.lb_Integrantes.Name = "lb_Integrantes";
            this.lb_Integrantes.Size = new System.Drawing.Size(240, 179);
            this.lb_Integrantes.TabIndex = 8;
            // 
            // txt_EquipoTrabajo
            // 
            this.txt_EquipoTrabajo.Location = new System.Drawing.Point(209, 300);
            this.txt_EquipoTrabajo.Name = "txt_EquipoTrabajo";
            this.txt_EquipoTrabajo.Size = new System.Drawing.Size(191, 31);
            this.txt_EquipoTrabajo.TabIndex = 9;
            // 
            // dtp_FechaInicio
            // 
            this.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicio.Location = new System.Drawing.Point(209, 355);
            this.dtp_FechaInicio.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dtp_FechaInicio.Name = "dtp_FechaInicio";
            this.dtp_FechaInicio.Size = new System.Drawing.Size(191, 31);
            this.dtp_FechaInicio.TabIndex = 10;
            this.dtp_FechaInicio.Value = new System.DateTime(2022, 7, 9, 23, 1, 28, 0);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(652, 351);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 34);
            this.btn_Guardar.TabIndex = 11;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lv_Lista
            // 
            this.lv_Lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Alumno,
            this.EquipoTrabajo,
            this.FechaInicio});
            this.lv_Lista.Location = new System.Drawing.Point(34, 402);
            this.lv_Lista.Name = "lv_Lista";
            this.lv_Lista.Size = new System.Drawing.Size(730, 259);
            this.lv_Lista.TabIndex = 12;
            this.lv_Lista.UseCompatibleStateImageBehavior = false;
            this.lv_Lista.View = System.Windows.Forms.View.Details;
            // 
            // Alumno
            // 
            this.Alumno.Text = "Alumno";
            this.Alumno.Width = 200;
            // 
            // EquipoTrabajo
            // 
            this.EquipoTrabajo.Text = "Equipo de trabajo";
            this.EquipoTrabajo.Width = 250;
            // 
            // FechaInicio
            // 
            this.FechaInicio.Text = "Fecha de inicio";
            this.FechaInicio.Width = 230;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 682);
            this.Controls.Add(this.lv_Lista);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.dtp_FechaInicio);
            this.Controls.Add(this.txt_EquipoTrabajo);
            this.Controls.Add(this.lb_Integrantes);
            this.Controls.Add(this.lb_Alumnos);
            this.Controls.Add(this.btn_QuitarTodo);
            this.Controls.Add(this.btn_Quitar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.lbl_EquipoTrabajo);
            this.Controls.Add(this.lbl_Integrantes);
            this.Controls.Add(this.lbl_ListaAlumno);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ListaAlumno;
        private Label lbl_Integrantes;
        private Label lbl_EquipoTrabajo;
        private Label lbl_FechaInicio;
        private Button btn_Agregar;
        private Button btn_Quitar;
        private Button btn_QuitarTodo;
        private ListBox lb_Alumnos;
        private ListBox lb_Integrantes;
        private TextBox txt_EquipoTrabajo;
        private DateTimePicker dtp_FechaInicio;
        private Button btn_Guardar;
        private ListView lv_Lista;
        private ColumnHeader Alumno;
        private ColumnHeader EquipoTrabajo;
        private ColumnHeader FechaInicio;
    }
}