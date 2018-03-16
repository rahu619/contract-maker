namespace ContractApplikation
{
    partial class ContractDetails
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ContractGenerator = new System.Windows.Forms.TabControl();
            this.Ansprechpartner = new System.Windows.Forms.TabPage();
            this.createCustomer = new System.Windows.Forms.Button();
            this.ort = new System.Windows.Forms.TextBox();
            this.ortLbl = new System.Windows.Forms.Label();
            this.strasse = new System.Windows.Forms.TextBox();
            this.strasseLbl = new System.Windows.Forms.Label();
            this.abteilungszusatz = new System.Windows.Forms.TextBox();
            this.departmentAdditionalLbl = new System.Windows.Forms.Label();
            this.geschäftsbereich = new System.Windows.Forms.TextBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.firma = new System.Windows.Forms.TextBox();
            this.firmaLbl = new System.Windows.Forms.Label();
            this.abteilung = new System.Windows.Forms.TextBox();
            this.abteilungLbl = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.telefonLbl = new System.Windows.Forms.Label();
            this.nachname = new System.Windows.Forms.TextBox();
            this.nachnameLbl = new System.Windows.Forms.Label();
            this.vorname = new System.Windows.Forms.TextBox();
            this.vornameLbl = new System.Windows.Forms.Label();
            this.frauRadioBtn = new System.Windows.Forms.RadioButton();
            this.herrRadioBtn = new System.Windows.Forms.RadioButton();
            this.Projekt = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.projektnummer = new System.Windows.Forms.TextBox();
            this.projektnummerLbl = new System.Windows.Forms.Label();
            this.Angebot = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ContractGenerator.SuspendLayout();
            this.Ansprechpartner.SuspendLayout();
            this.Projekt.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContractGenerator
            // 
            this.ContractGenerator.Controls.Add(this.Ansprechpartner);
            this.ContractGenerator.Controls.Add(this.Projekt);
            this.ContractGenerator.Controls.Add(this.Angebot);
            this.ContractGenerator.Location = new System.Drawing.Point(12, 12);
            this.ContractGenerator.Name = "ContractGenerator";
            this.ContractGenerator.SelectedIndex = 0;
            this.ContractGenerator.Size = new System.Drawing.Size(955, 523);
            this.ContractGenerator.TabIndex = 0;
            // 
            // Ansprechpartner
            // 
            this.Ansprechpartner.Controls.Add(this.createCustomer);
            this.Ansprechpartner.Controls.Add(this.ort);
            this.Ansprechpartner.Controls.Add(this.ortLbl);
            this.Ansprechpartner.Controls.Add(this.strasse);
            this.Ansprechpartner.Controls.Add(this.strasseLbl);
            this.Ansprechpartner.Controls.Add(this.abteilungszusatz);
            this.Ansprechpartner.Controls.Add(this.departmentAdditionalLbl);
            this.Ansprechpartner.Controls.Add(this.geschäftsbereich);
            this.Ansprechpartner.Controls.Add(this.departmentLabel);
            this.Ansprechpartner.Controls.Add(this.firma);
            this.Ansprechpartner.Controls.Add(this.firmaLbl);
            this.Ansprechpartner.Controls.Add(this.abteilung);
            this.Ansprechpartner.Controls.Add(this.abteilungLbl);
            this.Ansprechpartner.Controls.Add(this.email);
            this.Ansprechpartner.Controls.Add(this.emailLbl);
            this.Ansprechpartner.Controls.Add(this.telefon);
            this.Ansprechpartner.Controls.Add(this.telefonLbl);
            this.Ansprechpartner.Controls.Add(this.nachname);
            this.Ansprechpartner.Controls.Add(this.nachnameLbl);
            this.Ansprechpartner.Controls.Add(this.vorname);
            this.Ansprechpartner.Controls.Add(this.vornameLbl);
            this.Ansprechpartner.Controls.Add(this.frauRadioBtn);
            this.Ansprechpartner.Controls.Add(this.herrRadioBtn);
            this.Ansprechpartner.Location = new System.Drawing.Point(4, 22);
            this.Ansprechpartner.Name = "Ansprechpartner";
            this.Ansprechpartner.Padding = new System.Windows.Forms.Padding(3);
            this.Ansprechpartner.Size = new System.Drawing.Size(947, 497);
            this.Ansprechpartner.TabIndex = 0;
            this.Ansprechpartner.Text = "Ansprechpartner Erstellen";
            this.Ansprechpartner.UseVisualStyleBackColor = true;
            // 
            // createCustomer
            // 
            this.createCustomer.Location = new System.Drawing.Point(411, 395);
            this.createCustomer.Name = "createCustomer";
            this.createCustomer.Size = new System.Drawing.Size(98, 40);
            this.createCustomer.TabIndex = 22;
            this.createCustomer.Text = "Neu Kunden erstellen";
            this.createCustomer.UseVisualStyleBackColor = true;
            this.createCustomer.Click += new System.EventHandler(this.createCustomer_Click);
            // 
            // ort
            // 
            this.ort.Location = new System.Drawing.Point(632, 324);
            this.ort.Name = "ort";
            this.ort.Size = new System.Drawing.Size(212, 20);
            this.ort.TabIndex = 21;
            // 
            // ortLbl
            // 
            this.ortLbl.AutoSize = true;
            this.ortLbl.Location = new System.Drawing.Point(528, 327);
            this.ortLbl.Name = "ortLbl";
            this.ortLbl.Size = new System.Drawing.Size(21, 13);
            this.ortLbl.TabIndex = 20;
            this.ortLbl.Text = "Ort";
            // 
            // strasse
            // 
            this.strasse.Location = new System.Drawing.Point(632, 286);
            this.strasse.Name = "strasse";
            this.strasse.Size = new System.Drawing.Size(212, 20);
            this.strasse.TabIndex = 19;
            // 
            // strasseLbl
            // 
            this.strasseLbl.AutoSize = true;
            this.strasseLbl.Location = new System.Drawing.Point(528, 289);
            this.strasseLbl.Name = "strasseLbl";
            this.strasseLbl.Size = new System.Drawing.Size(42, 13);
            this.strasseLbl.TabIndex = 18;
            this.strasseLbl.Text = "Strasse";
            // 
            // abteilungszusatz
            // 
            this.abteilungszusatz.Location = new System.Drawing.Point(632, 249);
            this.abteilungszusatz.Name = "abteilungszusatz";
            this.abteilungszusatz.Size = new System.Drawing.Size(212, 20);
            this.abteilungszusatz.TabIndex = 17;
            // 
            // departmentAdditionalLbl
            // 
            this.departmentAdditionalLbl.AutoSize = true;
            this.departmentAdditionalLbl.Location = new System.Drawing.Point(528, 252);
            this.departmentAdditionalLbl.Name = "departmentAdditionalLbl";
            this.departmentAdditionalLbl.Size = new System.Drawing.Size(86, 13);
            this.departmentAdditionalLbl.TabIndex = 16;
            this.departmentAdditionalLbl.Text = "Abteilungszusatz";
            // 
            // geschäftsbereich
            // 
            this.geschäftsbereich.Location = new System.Drawing.Point(632, 211);
            this.geschäftsbereich.Name = "geschäftsbereich";
            this.geschäftsbereich.Size = new System.Drawing.Size(212, 20);
            this.geschäftsbereich.TabIndex = 15;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(528, 214);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(90, 13);
            this.departmentLabel.TabIndex = 14;
            this.departmentLabel.Text = "Geschäftsbereich";
            // 
            // firma
            // 
            this.firma.Location = new System.Drawing.Point(632, 174);
            this.firma.Name = "firma";
            this.firma.Size = new System.Drawing.Size(212, 20);
            this.firma.TabIndex = 13;
            // 
            // firmaLbl
            // 
            this.firmaLbl.AutoSize = true;
            this.firmaLbl.Location = new System.Drawing.Point(528, 177);
            this.firmaLbl.Name = "firmaLbl";
            this.firmaLbl.Size = new System.Drawing.Size(32, 13);
            this.firmaLbl.TabIndex = 12;
            this.firmaLbl.Text = "Firma";
            // 
            // abteilung
            // 
            this.abteilung.Location = new System.Drawing.Point(632, 137);
            this.abteilung.Name = "abteilung";
            this.abteilung.Size = new System.Drawing.Size(212, 20);
            this.abteilung.TabIndex = 11;
            // 
            // abteilungLbl
            // 
            this.abteilungLbl.AutoSize = true;
            this.abteilungLbl.Location = new System.Drawing.Point(528, 140);
            this.abteilungLbl.Name = "abteilungLbl";
            this.abteilungLbl.Size = new System.Drawing.Size(51, 13);
            this.abteilungLbl.TabIndex = 10;
            this.abteilungLbl.Text = "Abteilung";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(171, 249);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 20);
            this.email.TabIndex = 9;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(94, 252);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 13);
            this.emailLbl.TabIndex = 8;
            this.emailLbl.Text = "Email";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(171, 211);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(212, 20);
            this.telefon.TabIndex = 7;
            // 
            // telefonLbl
            // 
            this.telefonLbl.AutoSize = true;
            this.telefonLbl.Location = new System.Drawing.Point(94, 214);
            this.telefonLbl.Name = "telefonLbl";
            this.telefonLbl.Size = new System.Drawing.Size(43, 13);
            this.telefonLbl.TabIndex = 6;
            this.telefonLbl.Text = "Telefon";
            // 
            // nachname
            // 
            this.nachname.Location = new System.Drawing.Point(171, 174);
            this.nachname.Name = "nachname";
            this.nachname.Size = new System.Drawing.Size(212, 20);
            this.nachname.TabIndex = 5;
            // 
            // nachnameLbl
            // 
            this.nachnameLbl.AutoSize = true;
            this.nachnameLbl.Location = new System.Drawing.Point(94, 177);
            this.nachnameLbl.Name = "nachnameLbl";
            this.nachnameLbl.Size = new System.Drawing.Size(59, 13);
            this.nachnameLbl.TabIndex = 4;
            this.nachnameLbl.Text = "Nachname";
            // 
            // vorname
            // 
            this.vorname.Location = new System.Drawing.Point(171, 137);
            this.vorname.Name = "vorname";
            this.vorname.Size = new System.Drawing.Size(212, 20);
            this.vorname.TabIndex = 3;
            // 
            // vornameLbl
            // 
            this.vornameLbl.AutoSize = true;
            this.vornameLbl.Location = new System.Drawing.Point(94, 140);
            this.vornameLbl.Name = "vornameLbl";
            this.vornameLbl.Size = new System.Drawing.Size(49, 13);
            this.vornameLbl.TabIndex = 2;
            this.vornameLbl.Text = "Vorname";
            // 
            // frauRadioBtn
            // 
            this.frauRadioBtn.AutoSize = true;
            this.frauRadioBtn.Location = new System.Drawing.Point(171, 94);
            this.frauRadioBtn.Name = "frauRadioBtn";
            this.frauRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.frauRadioBtn.TabIndex = 1;
            this.frauRadioBtn.TabStop = true;
            this.frauRadioBtn.Text = "Frau";
            this.frauRadioBtn.UseVisualStyleBackColor = true;
            // 
            // herrRadioBtn
            // 
            this.herrRadioBtn.AutoSize = true;
            this.herrRadioBtn.Location = new System.Drawing.Point(97, 94);
            this.herrRadioBtn.Name = "herrRadioBtn";
            this.herrRadioBtn.Size = new System.Drawing.Size(45, 17);
            this.herrRadioBtn.TabIndex = 0;
            this.herrRadioBtn.TabStop = true;
            this.herrRadioBtn.Text = "Herr";
            this.herrRadioBtn.UseVisualStyleBackColor = true;
            // 
            // Projekt
            // 
            this.Projekt.Controls.Add(this.comboBox1);
            this.Projekt.Controls.Add(this.textBox6);
            this.Projekt.Controls.Add(this.textBox5);
            this.Projekt.Controls.Add(this.textBox4);
            this.Projekt.Controls.Add(this.textBox3);
            this.Projekt.Controls.Add(this.textBox2);
            this.Projekt.Controls.Add(this.dateTimePicker2);
            this.Projekt.Controls.Add(this.dateTimePicker1);
            this.Projekt.Controls.Add(this.label8);
            this.Projekt.Controls.Add(this.label7);
            this.Projekt.Controls.Add(this.label6);
            this.Projekt.Controls.Add(this.label5);
            this.Projekt.Controls.Add(this.label4);
            this.Projekt.Controls.Add(this.label3);
            this.Projekt.Controls.Add(this.label2);
            this.Projekt.Controls.Add(this.label1);
            this.Projekt.Controls.Add(this.projektnummer);
            this.Projekt.Controls.Add(this.projektnummerLbl);
            this.Projekt.Location = new System.Drawing.Point(4, 22);
            this.Projekt.Name = "Projekt";
            this.Projekt.Padding = new System.Windows.Forms.Padding(3);
            this.Projekt.Size = new System.Drawing.Size(947, 497);
            this.Projekt.TabIndex = 1;
            this.Projekt.Text = "Projekt Erstellen";
            this.Projekt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Datum";
            // 
            // projektnummer
            // 
            this.projektnummer.Location = new System.Drawing.Point(169, 61);
            this.projektnummer.Name = "projektnummer";
            this.projektnummer.Size = new System.Drawing.Size(48, 20);
            this.projektnummer.TabIndex = 1;
            // 
            // projektnummerLbl
            // 
            this.projektnummerLbl.AutoSize = true;
            this.projektnummerLbl.Location = new System.Drawing.Point(62, 64);
            this.projektnummerLbl.Name = "projektnummerLbl";
            this.projektnummerLbl.Size = new System.Drawing.Size(77, 13);
            this.projektnummerLbl.TabIndex = 0;
            this.projektnummerLbl.Text = "Projectnummer";
            // 
            // Angebot
            // 
            this.Angebot.Location = new System.Drawing.Point(4, 22);
            this.Angebot.Name = "Angebot";
            this.Angebot.Size = new System.Drawing.Size(947, 497);
            this.Angebot.TabIndex = 2;
            this.Angebot.Text = "Angebot Generieren";
            this.Angebot.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ansprechpartner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Anzahl Stunden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Verrechnungssatz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gesprächsperson";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Disponent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Projekt Beschreibung";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(169, 155);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(169, 295);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(570, 60);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(317, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(570, 109);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(317, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(570, 154);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(317, 200);
            this.textBox6.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // ContractDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 547);
            this.Controls.Add(this.ContractGenerator);
            this.Name = "ContractDetails";
            this.Text = "Contract Detail";
            this.ContractGenerator.ResumeLayout(false);
            this.Ansprechpartner.ResumeLayout(false);
            this.Ansprechpartner.PerformLayout();
            this.Projekt.ResumeLayout(false);
            this.Projekt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ContractGenerator;
        private System.Windows.Forms.TabPage Ansprechpartner;
        private System.Windows.Forms.Button createCustomer;
        private System.Windows.Forms.TextBox ort;
        private System.Windows.Forms.Label ortLbl;
        private System.Windows.Forms.TextBox strasse;
        private System.Windows.Forms.Label strasseLbl;
        private System.Windows.Forms.TextBox abteilungszusatz;
        private System.Windows.Forms.Label departmentAdditionalLbl;
        private System.Windows.Forms.TextBox geschäftsbereich;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox firma;
        private System.Windows.Forms.Label firmaLbl;
        private System.Windows.Forms.TextBox abteilung;
        private System.Windows.Forms.Label abteilungLbl;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label telefonLbl;
        private System.Windows.Forms.TextBox nachname;
        private System.Windows.Forms.Label nachnameLbl;
        private System.Windows.Forms.TextBox vorname;
        private System.Windows.Forms.Label vornameLbl;
        private System.Windows.Forms.RadioButton frauRadioBtn;
        private System.Windows.Forms.RadioButton herrRadioBtn;
        private System.Windows.Forms.TabPage Projekt;
        private System.Windows.Forms.TabPage Angebot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projektnummer;
        private System.Windows.Forms.Label projektnummerLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

