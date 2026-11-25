namespace pryDiseñoLavadero
{
    partial class frmLavados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxDatos = new GroupBox();
            nudCantidad = new NumericUpDown();
            cbxServicio = new ComboBox();
            txtPatente = new TextBox();
            txtCliente = new TextBox();
            cbxFrecuente = new CheckBox();
            rdbExpress = new RadioButton();
            rdbNormal = new RadioButton();
            lblTipo = new Label();
            lblCantidad = new Label();
            lblServicio = new Label();
            lblPatente = new Label();
            lblCliente = new Label();
            lblTitulo = new Label();
            gbxImportes = new GroupBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtTotal = new TextBox();
            txtDescuento = new TextBox();
            txtRecargo = new TextBox();
            txtSubtotal = new TextBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblRecargo = new Label();
            lblSubtotal = new Label();
            tabLavadero = new TabControl();
            tpPedido = new TabPage();
            tpLavados = new TabPage();
            dgvLavados = new DataGridView();
            colCliente = new DataGridViewTextBoxColumn();
            colPatente = new DataGridViewTextBoxColumn();
            colServicio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colEntrega = new DataGridViewTextBoxColumn();
            colFrecuente = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            tpRecaudacion = new TabPage();
            gbxPorentrega = new GroupBox();
            txtExpress = new TextBox();
            txtNormal = new TextBox();
            lblExpress = new Label();
            lblNormal = new Label();
            gbxPorservicio = new GroupBox();
            txtEncerado = new TextBox();
            txtCompleto = new TextBox();
            txtExterior = new TextBox();
            lblEncerado = new Label();
            lblCompleto = new Label();
            lblExterior = new Label();
            tpConsulta = new TabPage();
            dataGridView1 = new DataGridView();
            colPatenteconsulta = new DataGridViewTextBoxColumn();
            colServicioconsulta = new DataGridViewTextBoxColumn();
            colTotalconsulta = new DataGridViewTextBoxColumn();
            txtCantidadLavados = new TextBox();
            lblCantidaddelavados = new Label();
            btnConsultar = new Button();
            lblIngresa = new Label();
            txtIngresar = new TextBox();
            lblConsulta = new Label();
            gbxDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            gbxImportes.SuspendLayout();
            tabLavadero.SuspendLayout();
            tpPedido.SuspendLayout();
            tpLavados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLavados).BeginInit();
            tpRecaudacion.SuspendLayout();
            gbxPorentrega.SuspendLayout();
            gbxPorservicio.SuspendLayout();
            tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbxDatos
            // 
            gbxDatos.Controls.Add(nudCantidad);
            gbxDatos.Controls.Add(cbxServicio);
            gbxDatos.Controls.Add(txtPatente);
            gbxDatos.Controls.Add(txtCliente);
            gbxDatos.Controls.Add(cbxFrecuente);
            gbxDatos.Controls.Add(rdbExpress);
            gbxDatos.Controls.Add(rdbNormal);
            gbxDatos.Controls.Add(lblTipo);
            gbxDatos.Controls.Add(lblCantidad);
            gbxDatos.Controls.Add(lblServicio);
            gbxDatos.Controls.Add(lblPatente);
            gbxDatos.Controls.Add(lblCliente);
            gbxDatos.Location = new Point(6, 19);
            gbxDatos.Name = "gbxDatos";
            gbxDatos.Size = new Size(222, 336);
            gbxDatos.TabIndex = 0;
            gbxDatos.TabStop = false;
            gbxDatos.Text = "Datos del pedido";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(9, 206);
            nudCantidad.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 3;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.KeyPress += nudCantidad_KeyPress;
            // 
            // cbxServicio
            // 
            cbxServicio.FormattingEnabled = true;
            cbxServicio.Items.AddRange(new object[] { "Lavado exterior - $8.000", "Lavado completo - $14.000", "Lavado con encerado - $20.000" });
            cbxServicio.Location = new Point(9, 145);
            cbxServicio.Name = "cbxServicio";
            cbxServicio.Size = new Size(207, 23);
            cbxServicio.TabIndex = 10;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(6, 101);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(210, 23);
            txtPatente.TabIndex = 9;
            txtPatente.KeyPress += txtPatente_KeyPress;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(6, 53);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(210, 23);
            txtCliente.TabIndex = 8;
            // 
            // cbxFrecuente
            // 
            cbxFrecuente.AutoSize = true;
            cbxFrecuente.Location = new Point(38, 302);
            cbxFrecuente.Name = "cbxFrecuente";
            cbxFrecuente.Size = new Size(116, 19);
            cbxFrecuente.TabIndex = 7;
            cbxFrecuente.Text = "Cliente frecuente";
            cbxFrecuente.UseVisualStyleBackColor = true;
            // 
            // rdbExpress
            // 
            rdbExpress.AutoSize = true;
            rdbExpress.Location = new Point(106, 265);
            rdbExpress.Name = "rdbExpress";
            rdbExpress.Size = new Size(63, 19);
            rdbExpress.TabIndex = 6;
            rdbExpress.TabStop = true;
            rdbExpress.Text = "Express";
            rdbExpress.UseVisualStyleBackColor = true;
            // 
            // rdbNormal
            // 
            rdbNormal.AutoSize = true;
            rdbNormal.Location = new Point(6, 265);
            rdbNormal.Name = "rdbNormal";
            rdbNormal.Size = new Size(65, 19);
            rdbNormal.TabIndex = 5;
            rdbNormal.TabStop = true;
            rdbNormal.Text = "Normal";
            rdbNormal.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 232);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(90, 15);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo de entrega";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(0, 171);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(124, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad de vehiculos";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(6, 127);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(48, 15);
            lblServicio.TabIndex = 2;
            lblServicio.Text = "Servicio";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(6, 79);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(6, 34);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(100, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(287, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Lavadero Los Andes - Sistema de registros de lavados";
            // 
            // gbxImportes
            // 
            gbxImportes.Controls.Add(btnRegistrar);
            gbxImportes.Controls.Add(btnLimpiar);
            gbxImportes.Controls.Add(btnCalcular);
            gbxImportes.Controls.Add(txtTotal);
            gbxImportes.Controls.Add(txtDescuento);
            gbxImportes.Controls.Add(txtRecargo);
            gbxImportes.Controls.Add(txtSubtotal);
            gbxImportes.Controls.Add(lblTotal);
            gbxImportes.Controls.Add(lblDescuento);
            gbxImportes.Controls.Add(lblRecargo);
            gbxImportes.Controls.Add(lblSubtotal);
            gbxImportes.Location = new Point(234, 19);
            gbxImportes.Name = "gbxImportes";
            gbxImportes.Size = new Size(222, 336);
            gbxImportes.TabIndex = 2;
            gbxImportes.TabStop = false;
            gbxImportes.Text = "Importes del pedido";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(48, 282);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(119, 23);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(48, 253);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 23);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(48, 224);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Location = new Point(28, 189);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(121, 23);
            txtTotal.TabIndex = 7;
            txtTotal.Text = "$ 0,00";
            // 
            // txtDescuento
            // 
            txtDescuento.BorderStyle = BorderStyle.FixedSingle;
            txtDescuento.Location = new Point(28, 145);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(121, 23);
            txtDescuento.TabIndex = 6;
            txtDescuento.Text = "$ 0,00";
            // 
            // txtRecargo
            // 
            txtRecargo.BorderStyle = BorderStyle.FixedSingle;
            txtRecargo.Location = new Point(28, 101);
            txtRecargo.Name = "txtRecargo";
            txtRecargo.ReadOnly = true;
            txtRecargo.Size = new Size(121, 23);
            txtRecargo.TabIndex = 5;
            txtRecargo.Text = "$ 0,00";
            // 
            // txtSubtotal
            // 
            txtSubtotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubtotal.Location = new Point(28, 53);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(121, 23);
            txtSubtotal.TabIndex = 4;
            txtSubtotal.Text = "$ 0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(6, 171);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(6, 127);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Location = new Point(6, 79);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(50, 15);
            lblRecargo.TabIndex = 1;
            lblRecargo.Text = "Recargo";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(6, 34);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(51, 15);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal";
            // 
            // tabLavadero
            // 
            tabLavadero.Controls.Add(tpPedido);
            tabLavadero.Controls.Add(tpLavados);
            tabLavadero.Controls.Add(tpRecaudacion);
            tabLavadero.Controls.Add(tpConsulta);
            tabLavadero.Location = new Point(12, 38);
            tabLavadero.Name = "tabLavadero";
            tabLavadero.SelectedIndex = 0;
            tabLavadero.Size = new Size(470, 513);
            tabLavadero.TabIndex = 3;
            // 
            // tpPedido
            // 
            tpPedido.Controls.Add(gbxImportes);
            tpPedido.Controls.Add(gbxDatos);
            tpPedido.Location = new Point(4, 24);
            tpPedido.Name = "tpPedido";
            tpPedido.Padding = new Padding(3);
            tpPedido.Size = new Size(462, 485);
            tpPedido.TabIndex = 0;
            tpPedido.Text = "Pedido";
            tpPedido.UseVisualStyleBackColor = true;
            // 
            // tpLavados
            // 
            tpLavados.Controls.Add(dgvLavados);
            tpLavados.Location = new Point(4, 24);
            tpLavados.Name = "tpLavados";
            tpLavados.Padding = new Padding(3);
            tpLavados.Size = new Size(462, 485);
            tpLavados.TabIndex = 1;
            tpLavados.Text = "Lavados del día";
            tpLavados.UseVisualStyleBackColor = true;
            // 
            // dgvLavados
            // 
            dgvLavados.AllowUserToAddRows = false;
            dgvLavados.AllowUserToDeleteRows = false;
            dgvLavados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLavados.BackgroundColor = Color.White;
            dgvLavados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLavados.Columns.AddRange(new DataGridViewColumn[] { colCliente, colPatente, colServicio, colCantidad, colEntrega, colFrecuente, colTotal });
            dgvLavados.Location = new Point(6, 16);
            dgvLavados.Name = "dgvLavados";
            dgvLavados.ReadOnly = true;
            dgvLavados.RowHeadersVisible = false;
            dgvLavados.Size = new Size(450, 150);
            dgvLavados.TabIndex = 0;
            // 
            // colCliente
            // 
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colPatente
            // 
            colPatente.HeaderText = "Patente";
            colPatente.Name = "colPatente";
            colPatente.ReadOnly = true;
            // 
            // colServicio
            // 
            colServicio.HeaderText = "Servicio";
            colServicio.Name = "colServicio";
            colServicio.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colEntrega
            // 
            colEntrega.HeaderText = "Entrega";
            colEntrega.Name = "colEntrega";
            colEntrega.ReadOnly = true;
            // 
            // colFrecuente
            // 
            colFrecuente.HeaderText = "Frecuente";
            colFrecuente.Name = "colFrecuente";
            colFrecuente.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // tpRecaudacion
            // 
            tpRecaudacion.Controls.Add(gbxPorentrega);
            tpRecaudacion.Controls.Add(gbxPorservicio);
            tpRecaudacion.Location = new Point(4, 24);
            tpRecaudacion.Name = "tpRecaudacion";
            tpRecaudacion.Padding = new Padding(3);
            tpRecaudacion.Size = new Size(462, 485);
            tpRecaudacion.TabIndex = 2;
            tpRecaudacion.Text = "Recaudación ";
            tpRecaudacion.UseVisualStyleBackColor = true;
            // 
            // gbxPorentrega
            // 
            gbxPorentrega.Controls.Add(txtExpress);
            gbxPorentrega.Controls.Add(txtNormal);
            gbxPorentrega.Controls.Add(lblExpress);
            gbxPorentrega.Controls.Add(lblNormal);
            gbxPorentrega.Location = new Point(237, 40);
            gbxPorentrega.Name = "gbxPorentrega";
            gbxPorentrega.Size = new Size(207, 269);
            gbxPorentrega.TabIndex = 1;
            gbxPorentrega.TabStop = false;
            gbxPorentrega.Text = "Recaudacion por entrega";
            // 
            // txtExpress
            // 
            txtExpress.BorderStyle = BorderStyle.FixedSingle;
            txtExpress.Location = new Point(36, 146);
            txtExpress.Name = "txtExpress";
            txtExpress.ReadOnly = true;
            txtExpress.Size = new Size(121, 23);
            txtExpress.TabIndex = 6;
            txtExpress.Text = "$ 0,00";
            // 
            // txtNormal
            // 
            txtNormal.BorderStyle = BorderStyle.FixedSingle;
            txtNormal.Location = new Point(36, 69);
            txtNormal.Name = "txtNormal";
            txtNormal.ReadOnly = true;
            txtNormal.Size = new Size(121, 23);
            txtNormal.TabIndex = 5;
            txtNormal.Text = "$ 0,00";
            // 
            // lblExpress
            // 
            lblExpress.AutoSize = true;
            lblExpress.Location = new Point(21, 111);
            lblExpress.Name = "lblExpress";
            lblExpress.Size = new Size(45, 15);
            lblExpress.TabIndex = 1;
            lblExpress.Text = "Express";
            // 
            // lblNormal
            // 
            lblNormal.AutoSize = true;
            lblNormal.Location = new Point(21, 37);
            lblNormal.Name = "lblNormal";
            lblNormal.Size = new Size(47, 15);
            lblNormal.TabIndex = 0;
            lblNormal.Text = "Normal";
            // 
            // gbxPorservicio
            // 
            gbxPorservicio.Controls.Add(txtEncerado);
            gbxPorservicio.Controls.Add(txtCompleto);
            gbxPorservicio.Controls.Add(txtExterior);
            gbxPorservicio.Controls.Add(lblEncerado);
            gbxPorservicio.Controls.Add(lblCompleto);
            gbxPorservicio.Controls.Add(lblExterior);
            gbxPorservicio.Location = new Point(6, 40);
            gbxPorservicio.Name = "gbxPorservicio";
            gbxPorservicio.Size = new Size(212, 269);
            gbxPorservicio.TabIndex = 0;
            gbxPorservicio.TabStop = false;
            gbxPorservicio.Text = "Recaudación por servicio";
            // 
            // txtEncerado
            // 
            txtEncerado.BorderStyle = BorderStyle.FixedSingle;
            txtEncerado.Location = new Point(16, 227);
            txtEncerado.Name = "txtEncerado";
            txtEncerado.ReadOnly = true;
            txtEncerado.Size = new Size(121, 23);
            txtEncerado.TabIndex = 7;
            txtEncerado.Text = "$ 0,00";
            // 
            // txtCompleto
            // 
            txtCompleto.BorderStyle = BorderStyle.FixedSingle;
            txtCompleto.Location = new Point(16, 146);
            txtCompleto.Name = "txtCompleto";
            txtCompleto.ReadOnly = true;
            txtCompleto.Size = new Size(121, 23);
            txtCompleto.TabIndex = 6;
            txtCompleto.Text = "$ 0,00";
            // 
            // txtExterior
            // 
            txtExterior.BorderStyle = BorderStyle.FixedSingle;
            txtExterior.Location = new Point(16, 69);
            txtExterior.Name = "txtExterior";
            txtExterior.ReadOnly = true;
            txtExterior.Size = new Size(121, 23);
            txtExterior.TabIndex = 5;
            txtExterior.Text = "$ 0,00";
            // 
            // lblEncerado
            // 
            lblEncerado.AutoSize = true;
            lblEncerado.Location = new Point(6, 192);
            lblEncerado.Name = "lblEncerado";
            lblEncerado.Size = new Size(56, 15);
            lblEncerado.TabIndex = 2;
            lblEncerado.Text = "Encerado";
            // 
            // lblCompleto
            // 
            lblCompleto.AutoSize = true;
            lblCompleto.Location = new Point(6, 111);
            lblCompleto.Name = "lblCompleto";
            lblCompleto.Size = new Size(60, 15);
            lblCompleto.TabIndex = 1;
            lblCompleto.Text = "Completo";
            // 
            // lblExterior
            // 
            lblExterior.AutoSize = true;
            lblExterior.Location = new Point(6, 37);
            lblExterior.Name = "lblExterior";
            lblExterior.Size = new Size(46, 15);
            lblExterior.TabIndex = 0;
            lblExterior.Text = "Exterior";
            // 
            // tpConsulta
            // 
            tpConsulta.Controls.Add(dataGridView1);
            tpConsulta.Controls.Add(txtCantidadLavados);
            tpConsulta.Controls.Add(lblCantidaddelavados);
            tpConsulta.Controls.Add(btnConsultar);
            tpConsulta.Controls.Add(lblIngresa);
            tpConsulta.Controls.Add(txtIngresar);
            tpConsulta.Controls.Add(lblConsulta);
            tpConsulta.Location = new Point(4, 24);
            tpConsulta.Name = "tpConsulta";
            tpConsulta.Padding = new Padding(3);
            tpConsulta.Size = new Size(462, 485);
            tpConsulta.TabIndex = 3;
            tpConsulta.Text = "Consulta";
            tpConsulta.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colPatenteconsulta, colServicioconsulta, colTotalconsulta });
            dataGridView1.Location = new Point(51, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(339, 150);
            dataGridView1.TabIndex = 6;
            // 
            // colPatenteconsulta
            // 
            colPatenteconsulta.HeaderText = "Patente";
            colPatenteconsulta.Name = "colPatenteconsulta";
            colPatenteconsulta.ReadOnly = true;
            // 
            // colServicioconsulta
            // 
            colServicioconsulta.HeaderText = "Servicio";
            colServicioconsulta.Name = "colServicioconsulta";
            colServicioconsulta.ReadOnly = true;
            // 
            // colTotalconsulta
            // 
            colTotalconsulta.HeaderText = "Total";
            colTotalconsulta.Name = "colTotalconsulta";
            colTotalconsulta.ReadOnly = true;
            // 
            // txtCantidadLavados
            // 
            txtCantidadLavados.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadLavados.Location = new Point(157, 149);
            txtCantidadLavados.Name = "txtCantidadLavados";
            txtCantidadLavados.ReadOnly = true;
            txtCantidadLavados.Size = new Size(48, 23);
            txtCantidadLavados.TabIndex = 5;
            // 
            // lblCantidaddelavados
            // 
            lblCantidaddelavados.AutoSize = true;
            lblCantidaddelavados.Location = new Point(20, 152);
            lblCantidaddelavados.Name = "lblCantidaddelavados";
            lblCantidaddelavados.Size = new Size(114, 15);
            lblCantidaddelavados.TabIndex = 4;
            lblCantidaddelavados.Text = "Cantidad de lavados";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(282, 70);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(108, 23);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblIngresa
            // 
            lblIngresa.AutoSize = true;
            lblIngresa.Location = new Point(20, 74);
            lblIngresa.Name = "lblIngresa";
            lblIngresa.Size = new Size(92, 15);
            lblIngresa.TabIndex = 2;
            lblIngresa.Text = "Ingresar Patente";
            // 
            // txtIngresar
            // 
            txtIngresar.Location = new Point(133, 70);
            txtIngresar.Name = "txtIngresar";
            txtIngresar.Size = new Size(124, 23);
            txtIngresar.TabIndex = 1;
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new Point(34, 28);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new Size(118, 15);
            lblConsulta.TabIndex = 0;
            lblConsulta.Text = "Consulta por patente";
            // 
            // frmLavados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 563);
            Controls.Add(lblTitulo);
            Controls.Add(tabLavadero);
            Name = "frmLavados";
            Text = "Lavadero Los Andes";
            gbxDatos.ResumeLayout(false);
            gbxDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            gbxImportes.ResumeLayout(false);
            gbxImportes.PerformLayout();
            tabLavadero.ResumeLayout(false);
            tpPedido.ResumeLayout(false);
            tpLavados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLavados).EndInit();
            tpRecaudacion.ResumeLayout(false);
            gbxPorentrega.ResumeLayout(false);
            gbxPorentrega.PerformLayout();
            gbxPorservicio.ResumeLayout(false);
            gbxPorservicio.PerformLayout();
            tpConsulta.ResumeLayout(false);
            tpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatos;
        private Label lblTitulo;
        private GroupBox gbxImportes;
        private Label lblCantidad;
        private Label lblServicio;
        private Label lblPatente;
        private Label lblCliente;
        private TextBox txtPatente;
        private TextBox txtCliente;
        private CheckBox cbxFrecuente;
        private RadioButton rdbExpress;
        private RadioButton rdbNormal;
        private Label lblTipo;
        private ComboBox cbxServicio;
        private NumericUpDown nudCantidad;
        private Button btnCalcular;
        private TextBox txtTotal;
        private TextBox txtDescuento;
        private TextBox txtRecargo;
        private TextBox txtSubtotal;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblRecargo;
        private Label lblSubtotal;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private TabControl tabLavadero;
        private TabPage tpPedido;
        private TabPage tpLavados;
        private DataGridView dgvLavados;
        private TabPage tpRecaudacion;
        private TabPage tpConsulta;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colPatente;
        private DataGridViewTextBoxColumn colServicio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colEntrega;
        private DataGridViewTextBoxColumn colFrecuente;
        private DataGridViewTextBoxColumn colTotal;
        private GroupBox gbxPorentrega;
        private Label lblExpress;
        private Label lblNormal;
        private GroupBox gbxPorservicio;
        private Label lblEncerado;
        private Label lblCompleto;
        private Label lblExterior;
        private TextBox txtExpress;
        private TextBox txtNormal;
        private TextBox txtEncerado;
        private TextBox txtCompleto;
        private TextBox txtExterior;
        private Button btnConsultar;
        private Label lblIngresa;
        private TextBox txtIngresar;
        private Label lblConsulta;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colPatenteconsulta;
        private DataGridViewTextBoxColumn colServicioconsulta;
        private DataGridViewTextBoxColumn colTotalconsulta;
        private TextBox txtCantidadLavados;
        private Label lblCantidaddelavados;
    }
}