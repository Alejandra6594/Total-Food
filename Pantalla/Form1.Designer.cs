namespace Pantalla
{
    partial class Form1
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            button6 = new Button();
            panelSolicitudes = new Panel();
            button5 = new Button();
            button4 = new Button();
            btnSolicitudes = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            panelSideMenu.SuspendLayout();
            panelSolicitudes.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(0, 31, 63);
            panelSideMenu.Controls.Add(button6);
            panelSideMenu.Controls.Add(panelSolicitudes);
            panelSideMenu.Controls.Add(btnSolicitudes);
            panelSideMenu.Controls.Add(button2);
            panelSideMenu.Controls.Add(button1);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 561);
            panelSideMenu.TabIndex = 0;
            panelSideMenu.Paint += panelSideMenu_Paint;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Bottom;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Silver;
            button6.Location = new Point(0, 516);
            button6.Name = "button6";
            button6.Size = new Size(250, 45);
            button6.TabIndex = 5;
            button6.Text = "CERRAR SESION";
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panelSolicitudes
            // 
            panelSolicitudes.BackColor = Color.FromArgb(8, 51, 88);
            panelSolicitudes.Controls.Add(button5);
            panelSolicitudes.Controls.Add(button4);
            panelSolicitudes.Dock = DockStyle.Top;
            panelSolicitudes.Location = new Point(0, 230);
            panelSolicitudes.Name = "panelSolicitudes";
            panelSolicitudes.Size = new Size(250, 90);
            panelSolicitudes.TabIndex = 4;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Silver;
            button5.Location = new Point(0, 40);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(250, 40);
            button5.TabIndex = 1;
            button5.Text = "HISTORIAL DE VENTAS";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Silver;
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(250, 40);
            button4.TabIndex = 0;
            button4.Text = "PEDIDOS POR CONFIRMAR";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.Dock = DockStyle.Top;
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnSolicitudes.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.ForeColor = Color.Silver;
            btnSolicitudes.Location = new Point(0, 185);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Padding = new Padding(10, 0, 0, 0);
            btnSolicitudes.Size = new Size(250, 45);
            btnSolicitudes.TabIndex = 3;
            btnSolicitudes.Text = "SOLICITUDES DE COMPRA";
            btnSolicitudes.TextAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSolicitudes.UseVisualStyleBackColor = true;
            btnSolicitudes.Click += btnSolicitudes_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(0, 140);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(250, 45);
            button2.TabIndex = 2;
            button2.Text = "PRODUCTOS";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(0, 95);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(250, 45);
            button1.TabIndex = 1;
            button1.Text = "PERFIL";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 95);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 95);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.LightSkyBlue;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(684, 561);
            panelChildForm.TabIndex = 1;
            panelChildForm.Paint += panelChildForm_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelSideMenu.ResumeLayout(false);
            panelSolicitudes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button button1;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button button6;
        private Panel panelSolicitudes;
        private Button button5;
        private Button button4;
        private Button btnSolicitudes;
        private Button button2;
        private Panel panelChildForm;
    }
}