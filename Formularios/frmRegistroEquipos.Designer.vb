<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombreEquipo = New System.Windows.Forms.TextBox()
        Me.txtTipoEquipo = New System.Windows.Forms.TextBox()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.dtpFechaIngresoEquipo = New System.Windows.Forms.DateTimePicker()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbxIdDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbxIdUsuarioAsignado = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbInactivo = New System.Windows.Forms.RadioButton()
        Me.rbActivo = New System.Windows.Forms.RadioButton()
        Me.rbidUsuario = New System.Windows.Forms.RadioButton()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbEquipo = New System.Windows.Forms.RadioButton()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvEquipos = New System.Windows.Forms.DataGridView()
        Me.id_equipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_departamento_area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_usuario_encargado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Equipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Equipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Serial Equipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 347)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha Ingreso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(172, 177)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Estado Equipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label6.Location = New System.Drawing.Point(28, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Id Departamento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.GrayText
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(259, 235)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Id Usuario Asignado"
        '
        'txtNombreEquipo
        '
        Me.txtNombreEquipo.Location = New System.Drawing.Point(176, 42)
        Me.txtNombreEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreEquipo.Name = "txtNombreEquipo"
        Me.txtNombreEquipo.Size = New System.Drawing.Size(287, 22)
        Me.txtNombreEquipo.TabIndex = 7
        '
        'txtTipoEquipo
        '
        Me.txtTipoEquipo.Location = New System.Drawing.Point(176, 96)
        Me.txtTipoEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipoEquipo.Name = "txtTipoEquipo"
        Me.txtTipoEquipo.Size = New System.Drawing.Size(287, 22)
        Me.txtTipoEquipo.TabIndex = 8
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(176, 143)
        Me.txtSerial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(287, 22)
        Me.txtSerial.TabIndex = 9
        '
        'dtpFechaIngresoEquipo
        '
        Me.dtpFechaIngresoEquipo.Location = New System.Drawing.Point(32, 369)
        Me.dtpFechaIngresoEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaIngresoEquipo.Name = "dtpFechaIngresoEquipo"
        Me.dtpFechaIngresoEquipo.Size = New System.Drawing.Size(431, 22)
        Me.dtpFechaIngresoEquipo.TabIndex = 11
        '
        'CheckActivo
        '
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(176, 201)
        Me.CheckActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(66, 20)
        Me.CheckActivo.TabIndex = 13
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(1219, 594)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(39, 22)
        Me.txtID.TabIndex = 15
        Me.txtID.Visible = False
        '
        'cbxIdDepartamento
        '
        Me.cbxIdDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxIdDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxIdDepartamento.FormattingEnabled = True
        Me.cbxIdDepartamento.Location = New System.Drawing.Point(32, 257)
        Me.cbxIdDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxIdDepartamento.Name = "cbxIdDepartamento"
        Me.cbxIdDepartamento.Size = New System.Drawing.Size(217, 24)
        Me.cbxIdDepartamento.TabIndex = 16
        '
        'cbxIdUsuarioAsignado
        '
        Me.cbxIdUsuarioAsignado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxIdUsuarioAsignado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxIdUsuarioAsignado.FormattingEnabled = True
        Me.cbxIdUsuarioAsignado.Location = New System.Drawing.Point(263, 257)
        Me.cbxIdUsuarioAsignado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxIdUsuarioAsignado.Name = "cbxIdUsuarioAsignado"
        Me.cbxIdUsuarioAsignado.Size = New System.Drawing.Size(200, 24)
        Me.cbxIdUsuarioAsignado.TabIndex = 17
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancelar.Location = New System.Drawing.Point(1168, 545)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 43)
        Me.btnCancelar.TabIndex = 30
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(1317, 546)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(91, 43)
        Me.btnEliminar.TabIndex = 29
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditar.Location = New System.Drawing.Point(996, 545)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(91, 43)
        Me.btnEditar.TabIndex = 28
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGuardar.Location = New System.Drawing.Point(827, 546)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(91, 43)
        Me.btnGuardar.TabIndex = 27
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SteelBlue
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNuevo.Location = New System.Drawing.Point(652, 546)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(91, 43)
        Me.btnNuevo.TabIndex = 26
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.rbInactivo)
        Me.Panel1.Controls.Add(Me.rbActivo)
        Me.Panel1.Controls.Add(Me.rbidUsuario)
        Me.Panel1.Controls.Add(Me.rbDepartamento)
        Me.Panel1.Controls.Add(Me.rbEquipo)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvEquipos)
        Me.Panel1.Location = New System.Drawing.Point(492, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 511)
        Me.Panel1.TabIndex = 32
        '
        'rbInactivo
        '
        Me.rbInactivo.AutoSize = True
        Me.rbInactivo.Location = New System.Drawing.Point(535, 25)
        Me.rbInactivo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbInactivo.Name = "rbInactivo"
        Me.rbInactivo.Size = New System.Drawing.Size(120, 20)
        Me.rbInactivo.TabIndex = 9
        Me.rbInactivo.Text = "Estado Inactivo"
        Me.rbInactivo.UseVisualStyleBackColor = True
        '
        'rbActivo
        '
        Me.rbActivo.AutoSize = True
        Me.rbActivo.Location = New System.Drawing.Point(404, 23)
        Me.rbActivo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbActivo.Name = "rbActivo"
        Me.rbActivo.Size = New System.Drawing.Size(111, 20)
        Me.rbActivo.TabIndex = 8
        Me.rbActivo.Text = "Estado Activo"
        Me.rbActivo.UseVisualStyleBackColor = True
        '
        'rbidUsuario
        '
        Me.rbidUsuario.AutoSize = True
        Me.rbidUsuario.Location = New System.Drawing.Point(276, 22)
        Me.rbidUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.rbidUsuario.Name = "rbidUsuario"
        Me.rbidUsuario.Size = New System.Drawing.Size(89, 20)
        Me.rbidUsuario.TabIndex = 7
        Me.rbidUsuario.Text = "Id Usuario"
        Me.rbidUsuario.UseVisualStyleBackColor = True
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(135, 23)
        Me.rbDepartamento.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(114, 20)
        Me.rbDepartamento.TabIndex = 6
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbEquipo
        '
        Me.rbEquipo.AutoSize = True
        Me.rbEquipo.Location = New System.Drawing.Point(20, 23)
        Me.rbEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.rbEquipo.Name = "rbEquipo"
        Me.rbEquipo.Size = New System.Drawing.Size(102, 20)
        Me.rbEquipo.TabIndex = 5
        Me.rbEquipo.Text = "Tipo Equipo"
        Me.rbEquipo.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(156, 490)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 16)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 490)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Usuarios Registrados: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(672, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(676, 23)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(208, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvEquipos
        '
        Me.dgvEquipos.AllowUserToAddRows = False
        Me.dgvEquipos.AllowUserToDeleteRows = False
        Me.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_equipo, Me.nombre, Me.serial, Me.tipo, Me.activo, Me.id_departamento_area, Me.id_usuario_encargado})
        Me.dgvEquipos.Location = New System.Drawing.Point(20, 52)
        Me.dgvEquipos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvEquipos.Name = "dgvEquipos"
        Me.dgvEquipos.ReadOnly = True
        Me.dgvEquipos.RowHeadersVisible = False
        Me.dgvEquipos.RowHeadersWidth = 51
        Me.dgvEquipos.RowTemplate.Height = 24
        Me.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquipos.Size = New System.Drawing.Size(868, 432)
        Me.dgvEquipos.TabIndex = 0
        '
        'id_equipo
        '
        Me.id_equipo.DataPropertyName = "id_equipo"
        Me.id_equipo.HeaderText = "ID"
        Me.id_equipo.MinimumWidth = 6
        Me.id_equipo.Name = "id_equipo"
        Me.id_equipo.ReadOnly = True
        Me.id_equipo.Visible = False
        Me.id_equipo.Width = 50
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "NOMBRE EQUIPO"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 150
        '
        'serial
        '
        Me.serial.DataPropertyName = "serial"
        Me.serial.HeaderText = "SERIAL"
        Me.serial.MinimumWidth = 6
        Me.serial.Name = "serial"
        Me.serial.ReadOnly = True
        Me.serial.Width = 80
        '
        'tipo
        '
        Me.tipo.DataPropertyName = "tipo"
        Me.tipo.HeaderText = "TIPO"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 80
        '
        'activo
        '
        Me.activo.DataPropertyName = "activo"
        Me.activo.HeaderText = "ACTIVO"
        Me.activo.MinimumWidth = 6
        Me.activo.Name = "activo"
        Me.activo.ReadOnly = True
        Me.activo.Width = 70
        '
        'id_departamento_area
        '
        Me.id_departamento_area.DataPropertyName = "id_departamento_area"
        Me.id_departamento_area.HeaderText = "ID DEPARTAMENTO"
        Me.id_departamento_area.MinimumWidth = 6
        Me.id_departamento_area.Name = "id_departamento_area"
        Me.id_departamento_area.ReadOnly = True
        Me.id_departamento_area.Width = 130
        '
        'id_usuario_encargado
        '
        Me.id_usuario_encargado.DataPropertyName = "id_usuario_encargado"
        Me.id_usuario_encargado.HeaderText = "ID USUARIO ASIGNADO"
        Me.id_usuario_encargado.MinimumWidth = 6
        Me.id_usuario_encargado.Name = "id_usuario_encargado"
        Me.id_usuario_encargado.ReadOnly = True
        Me.id_usuario_encargado.Width = 130
        '
        'btnUsuario
        '
        Me.btnUsuario.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.Location = New System.Drawing.Point(390, 201)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(73, 28)
        Me.btnUsuario.TabIndex = 34
        Me.btnUsuario.Text = "..."
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'frmEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(1423, 618)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbxIdUsuarioAsignado)
        Me.Controls.Add(Me.cbxIdDepartamento)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.CheckActivo)
        Me.Controls.Add(Me.dtpFechaIngresoEquipo)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.txtTipoEquipo)
        Me.Controls.Add(Me.txtNombreEquipo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEquipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Equipos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreEquipo As TextBox
    Friend WithEvents txtTipoEquipo As TextBox
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents dtpFechaIngresoEquipo As DateTimePicker
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents cbxIdDepartamento As ComboBox
    Friend WithEvents cbxIdUsuarioAsignado As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvEquipos As DataGridView
    Friend WithEvents id_equipo As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents serial As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents activo As DataGridViewTextBoxColumn
    Friend WithEvents id_departamento_area As DataGridViewTextBoxColumn
    Friend WithEvents id_usuario_encargado As DataGridViewTextBoxColumn
    Friend WithEvents rbActivo As RadioButton
    Friend WithEvents rbidUsuario As RadioButton
    Friend WithEvents rbDepartamento As RadioButton
    Friend WithEvents rbEquipo As RadioButton
    Friend WithEvents rbInactivo As RadioButton
    Friend WithEvents btnUsuario As Button
End Class
