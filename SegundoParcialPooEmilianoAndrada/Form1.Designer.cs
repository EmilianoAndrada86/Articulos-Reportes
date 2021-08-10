namespace SegundoParcialPooEmilianoAndrada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.codArtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesesVigenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMetodoCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaArticulosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vistaArticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vistaArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaArticulosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaArticulosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaArticulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codArtDataGridViewTextBoxColumn,
            this.descriDataGridViewTextBoxColumn,
            this.FA,
            this.FB,
            this.mesesVigenteDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.dMetodoCostoDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaArticulosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(286, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(890, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FA
            // 
            this.FA.DataPropertyName = "FA";
            this.FA.HeaderText = "Fecha de Alta";
            this.FA.Name = "FA";
            // 
            // FB
            // 
            this.FB.DataPropertyName = "FB";
            this.FB.HeaderText = "Fecha de Baja";
            this.FB.Name = "FB";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar Articulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dar de Baja Articulo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Modificar Articulo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 37);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reducir Stock";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "Agregar Stock";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(286, 353);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(890, 222);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 57);
            this.button6.TabIndex = 7;
            this.button6.Text = "Proyectar Articulos superior a stock";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 432);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 57);
            this.button7.TabIndex = 8;
            this.button7.Text = "Proyectar Descripcion Articulos stock = 0";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(27, 518);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 57);
            this.button8.TabIndex = 9;
            this.button8.Text = "Proyectar Articulos por descripcion";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(153, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(102, 66);
            this.button9.TabIndex = 10;
            this.button9.Text = "Proyectar Articulos dados de baja x meses vigente";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(153, 432);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(102, 66);
            this.button10.TabIndex = 11;
            this.button10.Text = "Proyectar Articulos Sobre n1 y menor a n2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(945, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Dinero Inmovilizado";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(1076, 322);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // codArtDataGridViewTextBoxColumn
            // 
            this.codArtDataGridViewTextBoxColumn.DataPropertyName = "codArt";
            this.codArtDataGridViewTextBoxColumn.HeaderText = "CodigoArticulo";
            this.codArtDataGridViewTextBoxColumn.Name = "codArtDataGridViewTextBoxColumn";
            // 
            // descriDataGridViewTextBoxColumn
            // 
            this.descriDataGridViewTextBoxColumn.DataPropertyName = "descri";
            this.descriDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descriDataGridViewTextBoxColumn.Name = "descriDataGridViewTextBoxColumn";
            // 
            // mesesVigenteDataGridViewTextBoxColumn
            // 
            this.mesesVigenteDataGridViewTextBoxColumn.DataPropertyName = "MesesVigente";
            this.mesesVigenteDataGridViewTextBoxColumn.HeaderText = "Meses Vigente";
            this.mesesVigenteDataGridViewTextBoxColumn.Name = "mesesVigenteDataGridViewTextBoxColumn";
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            // 
            // dMetodoCostoDataGridViewTextBoxColumn
            // 
            this.dMetodoCostoDataGridViewTextBoxColumn.DataPropertyName = "DMetodoCosto";
            this.dMetodoCostoDataGridViewTextBoxColumn.HeaderText = "MetodoCosto";
            this.dMetodoCostoDataGridViewTextBoxColumn.Name = "dMetodoCostoDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "StockActual";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // vistaArticulosBindingSource2
            // 
            this.vistaArticulosBindingSource2.DataSource = typeof(SegundoParcialPooEmilianoAndrada.Clases.VistaArticulos);
            // 
            // vistaArticulosBindingSource1
            // 
            this.vistaArticulosBindingSource1.DataSource = typeof(SegundoParcialPooEmilianoAndrada.Clases.VistaArticulos);
            // 
            // vistaArticulosBindingSource
            // 
            this.vistaArticulosBindingSource.DataSource = typeof(SegundoParcialPooEmilianoAndrada.Clases.VistaArticulos);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 681);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaArticulosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaArticulosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaArticulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource vistaArticulosBindingSource;
        private System.Windows.Forms.BindingSource vistaArticulosBindingSource1;
        private System.Windows.Forms.BindingSource vistaArticulosBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codArtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FB;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesesVigenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMetodoCostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

