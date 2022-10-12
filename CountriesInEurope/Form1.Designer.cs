
namespace CountriesInEurope
{
    partial class frmEuropeanCountries
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEuropeanCountries));
            this.gboGremany = new System.Windows.Forms.GroupBox();
            this.gboSpain = new System.Windows.Forms.GroupBox();
            this.gboItaly = new System.Windows.Forms.GroupBox();
            this.gboFrance = new System.Windows.Forms.GroupBox();
            this.ptbGermany = new System.Windows.Forms.PictureBox();
            this.ptbFrance = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtGeneral = new System.Windows.Forms.TextBox();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.ptbFlag = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gboGremany.SuspendLayout();
            this.gboSpain.SuspendLayout();
            this.gboItaly.SuspendLayout();
            this.gboFrance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGermany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFrance)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gboGremany
            // 
            this.gboGremany.Controls.Add(this.ptbGermany);
            this.gboGremany.Location = new System.Drawing.Point(13, 13);
            this.gboGremany.Name = "gboGremany";
            this.gboGremany.Size = new System.Drawing.Size(151, 113);
            this.gboGremany.TabIndex = 0;
            this.gboGremany.TabStop = false;
            this.gboGremany.Text = "Germany";
            // 
            // gboSpain
            // 
            this.gboSpain.Controls.Add(this.pictureBox1);
            this.gboSpain.Location = new System.Drawing.Point(193, 13);
            this.gboSpain.Name = "gboSpain";
            this.gboSpain.Size = new System.Drawing.Size(143, 113);
            this.gboSpain.TabIndex = 1;
            this.gboSpain.TabStop = false;
            this.gboSpain.Text = "Spain";
            // 
            // gboItaly
            // 
            this.gboItaly.Controls.Add(this.pictureBox2);
            this.gboItaly.Location = new System.Drawing.Point(193, 163);
            this.gboItaly.Name = "gboItaly";
            this.gboItaly.Size = new System.Drawing.Size(143, 108);
            this.gboItaly.TabIndex = 1;
            this.gboItaly.TabStop = false;
            this.gboItaly.Text = "Italy";
            // 
            // gboFrance
            // 
            this.gboFrance.Controls.Add(this.ptbFrance);
            this.gboFrance.Location = new System.Drawing.Point(13, 163);
            this.gboFrance.Name = "gboFrance";
            this.gboFrance.Size = new System.Drawing.Size(151, 92);
            this.gboFrance.TabIndex = 1;
            this.gboFrance.TabStop = false;
            this.gboFrance.Text = "France";
            // 
            // ptbGermany
            // 
            this.ptbGermany.Enabled = false;
            this.ptbGermany.Image = ((System.Drawing.Image)(resources.GetObject("ptbGermany.Image")));
            this.ptbGermany.Location = new System.Drawing.Point(7, 23);
            this.ptbGermany.Name = "ptbGermany";
            this.ptbGermany.Size = new System.Drawing.Size(100, 50);
            this.ptbGermany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGermany.TabIndex = 0;
            this.ptbGermany.TabStop = false;
            this.ptbGermany.MouseEnter += new System.EventHandler(this.ptbGermany_MouseEnter);
            // 
            // ptbFrance
            // 
            this.ptbFrance.Image = ((System.Drawing.Image)(resources.GetObject("ptbFrance.Image")));
            this.ptbFrance.Location = new System.Drawing.Point(7, 23);
            this.ptbFrance.Name = "ptbFrance";
            this.ptbFrance.Size = new System.Drawing.Size(100, 50);
            this.ptbFrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFrance.TabIndex = 0;
            this.ptbFrance.TabStop = false;
            this.ptbFrance.MouseEnter += new System.EventHandler(this.ptbFrance_MouseEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.ptbFlag);
            this.groupBox1.Controls.Add(this.txtPopulation);
            this.groupBox1.Controls.Add(this.txtGeneral);
            this.groupBox1.Controls.Add(this.txtCurrency);
            this.groupBox1.Controls.Add(this.txtLanguage);
            this.groupBox1.Controls.Add(this.txtCapital);
            this.groupBox1.Controls.Add(this.lblCurrency);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLanguage);
            this.groupBox1.Controls.Add(this.lblPopulation);
            this.groupBox1.Controls.Add(this.lblCapital);
            this.groupBox1.Location = new System.Drawing.Point(358, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(51, 47);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(44, 15);
            this.lblCapital.TabIndex = 0;
            this.lblCapital.Text = "Capital";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(51, 87);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(65, 15);
            this.lblPopulation.TabIndex = 1;
            this.lblPopulation.Text = "Population";
            this.lblPopulation.Click += new System.EventHandler(this.lblPopulation_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(51, 120);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(59, 15);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.Click += new System.EventHandler(this.lblLanguage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "General Information";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(51, 150);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(55, 15);
            this.lblCurrency.TabIndex = 5;
            this.lblCurrency.Text = "Currency";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(122, 47);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(100, 23);
            this.txtCapital.TabIndex = 6;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(122, 112);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(100, 23);
            this.txtLanguage.TabIndex = 7;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(122, 147);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 23);
            this.txtCurrency.TabIndex = 8;
            // 
            // txtGeneral
            // 
            this.txtGeneral.Location = new System.Drawing.Point(6, 192);
            this.txtGeneral.Name = "txtGeneral";
            this.txtGeneral.Size = new System.Drawing.Size(332, 23);
            this.txtGeneral.TabIndex = 9;
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(122, 79);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(100, 23);
            this.txtPopulation.TabIndex = 10;
            // 
            // ptbFlag
            // 
            this.ptbFlag.Location = new System.Drawing.Point(228, 40);
            this.ptbFlag.Name = "ptbFlag";
            this.ptbFlag.Size = new System.Drawing.Size(138, 146);
            this.ptbFlag.TabIndex = 11;
            this.ptbFlag.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Germany-politcal-map.gif");
            this.imageList1.Images.SetKeyName(1, "map_of_france.gif");
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // frmEuropeanCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboSpain);
            this.Controls.Add(this.gboItaly);
            this.Controls.Add(this.gboFrance);
            this.Controls.Add(this.gboGremany);
            this.Name = "frmEuropeanCountries";
            this.Text = "Countries in Europe";
            this.gboGremany.ResumeLayout(false);
            this.gboSpain.ResumeLayout(false);
            this.gboItaly.ResumeLayout(false);
            this.gboFrance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbGermany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFrance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboGremany;
        private System.Windows.Forms.PictureBox ptbGermany;
        private System.Windows.Forms.GroupBox gboSpain;
        private System.Windows.Forms.GroupBox gboItaly;
        private System.Windows.Forms.GroupBox gboFrance;
        private System.Windows.Forms.PictureBox ptbFrance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.TextBox txtGeneral;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.PictureBox ptbFlag;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

