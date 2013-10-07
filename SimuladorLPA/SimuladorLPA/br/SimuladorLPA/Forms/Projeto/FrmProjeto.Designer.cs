namespace br.SimuladorLPA.Forms
{
    partial class FrmProjeto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("NAP", 0);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("NAP", 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjeto));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageListObjetos = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStripObjetos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.toolTipProjeto = new System.Windows.Forms.ToolTip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.contextMenuStripObjetos.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            listViewItem3.ToolTipText = "Saída de Grau de Evidência resultante real";
            listViewItem4.ToolTipText = "Grau de Contradição Normalizado e Intervalo de Evidência";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.LargeImageList = this.imageListObjetos;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(127, 546);
            this.listView1.SmallImageList = this.imageListObjetos;
            this.listView1.TabIndex = 0;
            this.toolTipProjeto.SetToolTip(this.listView1, "ListView");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView1_ItemDrag);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // imageListObjetos
            // 
            this.imageListObjetos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListObjetos.ImageStream")));
            this.imageListObjetos.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListObjetos.Images.SetKeyName(0, "NAP.jpg");
            this.imageListObjetos.Images.SetKeyName(1, "NAP01.bmp");
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Location = new System.Drawing.Point(145, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 546);
            this.panel1.TabIndex = 1;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BackgroundImage = global::br.SimuladorLPA.Properties.Resources.NAP2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.ContextMenuStrip = this.contextMenuStripObjetos;
            this.panel3.Location = new System.Drawing.Point(67, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 29);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.conexaoObjetos);
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.traserparafrente);
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImage = global::br.SimuladorLPA.Properties.Resources.NAP2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ContextMenuStrip = this.contextMenuStripObjetos;
            this.panel2.Location = new System.Drawing.Point(139, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(59, 29);
            this.panel2.TabIndex = 0;
            this.toolTipProjeto.SetToolTip(this.panel2, "Saída de Grau de Evidência resultante real");
            this.panel2.Click += new System.EventHandler(this.conexaoObjetos);
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.traserparafrente);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // contextMenuStripObjetos
            // 
            this.contextMenuStripObjetos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.contextMenuStripObjetos.Name = "contextMenuStripObjetos";
            this.contextMenuStripObjetos.Size = new System.Drawing.Size(123, 48);
            this.contextMenuStripObjetos.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripObjetos_Opening);
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(538, 542);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 232;
            this.lineShape2.X2 = 376;
            this.lineShape2.Y1 = 92;
            this.lineShape2.Y2 = 145;
            // 
            // toolTipProjeto
            // 
            this.toolTipProjeto.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipProjeto.ToolTipTitle = "Simulador LPA";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.BackgroundImage = global::br.SimuladorLPA.Properties.Resources.NAP2;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.ContextMenuStrip = this.contextMenuStripObjetos;
            this.panel4.Location = new System.Drawing.Point(271, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(59, 29);
            this.panel4.TabIndex = 0;
            this.panel4.Click += new System.EventHandler(this.conexaoObjetos);
            this.panel4.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.traserparafrente);
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel5.BackgroundImage = global::br.SimuladorLPA.Properties.Resources.NAP2;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.ContextMenuStrip = this.contextMenuStripObjetos;
            this.panel5.Location = new System.Drawing.Point(378, 213);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(59, 29);
            this.panel5.TabIndex = 0;
            this.panel5.Click += new System.EventHandler(this.conexaoObjetos);
            this.panel5.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel2_DragDrop);
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.traserparafrente);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // FrmProjeto
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmProjeto";
            this.Tag = "adsasd";
            this.Text = "FrmProjeto";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStripObjetos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageListObjetos;
        private System.Windows.Forms.ToolTip toolTipProjeto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripObjetos;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;


    }
}