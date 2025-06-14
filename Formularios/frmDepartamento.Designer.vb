<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamento
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
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.txtCentroCostos = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtJefeArea = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.dgvDepartamento = New System.Windows.Forms.DataGridView()
        Me.id_departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_area_departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.centro_de_costos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_jefe_area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDepartamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(425, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Centro de costos"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.Location = New System.Drawing.Point(133, 27)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.Size = New System.Drawing.Size(271, 22)
        Me.txtDepartamento.TabIndex = 2
        '
        'txtCentroCostos
        '
        Me.txtCentroCostos.Location = New System.Drawing.Point(546, 27)
        Me.txtCentroCostos.Multiline = True
        Me.txtCentroCostos.Name = "txtCentroCostos"
        Me.txtCentroCostos.Size = New System.Drawing.Size(271, 44)
        Me.txtCentroCostos.TabIndex = 3
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(12, 0)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(44, 22)
        Me.txtId.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(726, 217)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(91, 43)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(726, 315)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(91, 43)
        Me.btnEliminar.TabIndex = 18
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(726, 266)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(91, 43)
        Me.btnEditar.TabIndex = 17
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(726, 168)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(91, 43)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(726, 119)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(91, 43)
        Me.btnNuevo.TabIndex = 15
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Jefe de Área"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(133, 84)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(271, 22)
        Me.txtDescripcion.TabIndex = 22
        '
        'txtJefeArea
        '
        Me.txtJefeArea.Location = New System.Drawing.Point(546, 84)
        Me.txtJefeArea.Name = "txtJefeArea"
        Me.txtJefeArea.Size = New System.Drawing.Size(271, 22)
        Me.txtJefeArea.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtBuscar)
        Me.Panel1.Controls.Add(Me.dgvDepartamento)
        Me.Panel1.Location = New System.Drawing.Point(18, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 297)
        Me.Panel1.TabIndex = 24
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(156, 276)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 16)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Usuarios Registrados: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(384, 20)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(298, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'dgvDepartamento
        '
        Me.dgvDepartamento.AllowUserToAddRows = False
        Me.dgvDepartamento.AllowUserToDeleteRows = False
        Me.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDepartamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_departamento, Me.nombre_area_departamento, Me.descripcion, Me.centro_de_costos, Me.nombre_jefe_area})
        Me.dgvDepartamento.Location = New System.Drawing.Point(20, 45)
        Me.dgvDepartamento.Name = "dgvDepartamento"
        Me.dgvDepartamento.ReadOnly = True
        Me.dgvDepartamento.RowHeadersVisible = False
        Me.dgvDepartamento.RowHeadersWidth = 51
        Me.dgvDepartamento.RowTemplate.Height = 24
        Me.dgvDepartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartamento.Size = New System.Drawing.Size(662, 226)
        Me.dgvDepartamento.TabIndex = 0
        '
        'id_departamento
        '
        Me.id_departamento.DataPropertyName = "id_departamento"
        Me.id_departamento.HeaderText = "ID"
        Me.id_departamento.MinimumWidth = 6
        Me.id_departamento.Name = "id_departamento"
        Me.id_departamento.ReadOnly = True
        Me.id_departamento.Visible = False
        Me.id_departamento.Width = 50
        '
        'nombre_area_departamento
        '
        Me.nombre_area_departamento.DataPropertyName = "nombre_area_departamento"
        Me.nombre_area_departamento.HeaderText = "NOMBRE DEPARTAMENTO"
        Me.nombre_area_departamento.MinimumWidth = 6
        Me.nombre_area_departamento.Name = "nombre_area_departamento"
        Me.nombre_area_departamento.ReadOnly = True
        Me.nombre_area_departamento.Width = 230
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "DESCRIPCIÓN"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 120
        '
        'centro_de_costos
        '
        Me.centro_de_costos.DataPropertyName = "centro_de_costos"
        Me.centro_de_costos.HeaderText = "CENTRO DE COSTOS"
        Me.centro_de_costos.MinimumWidth = 6
        Me.centro_de_costos.Name = "centro_de_costos"
        Me.centro_de_costos.ReadOnly = True
        Me.centro_de_costos.Width = 180
        '
        'nombre_jefe_area
        '
        Me.nombre_jefe_area.DataPropertyName = "nombre_jefe_area"
        Me.nombre_jefe_area.HeaderText = "JEFE DE ÁREA"
        Me.nombre_jefe_area.MinimumWidth = 6
        Me.nombre_jefe_area.Name = "nombre_jefe_area"
        Me.nombre_jefe_area.ReadOnly = True
        Me.nombre_jefe_area.Width = 140
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(726, 364)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(91, 43)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'frmDepartamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(861, 437)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtJefeArea)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtCentroCostos)
        Me.Controls.Add(Me.txtDepartamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmDepartamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDepartamento"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDepartamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents txtCentroCostos As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtJefeArea As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents dgvDepartamento As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents id_departamento As DataGridViewTextBoxColumn
    Friend WithEvents nombre_area_departamento As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents centro_de_costos As DataGridViewTextBoxColumn
    Friend WithEvents nombre_jefe_area As DataGridViewTextBoxColumn
End Class
