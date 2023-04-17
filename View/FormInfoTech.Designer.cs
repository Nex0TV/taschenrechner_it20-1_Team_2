
namespace Taschenrechner
{
    partial class FormInfoTech
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
            this.lblInfoTech = new System.Windows.Forms.Label();
            this.lblResultInfoTech = new System.Windows.Forms.Label();
            this.tBox_number = new System.Windows.Forms.TextBox();
            this.btnCloseBasicCalc = new System.Windows.Forms.Button();
            this.btnChooseModules = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.cBox_prefixes = new System.Windows.Forms.ComboBox();
            this.lbl_resultPrefix = new System.Windows.Forms.Label();
            this.cBox_resultPrefix = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tBoxFPS = new System.Windows.Forms.TextBox();
            this.lblInfoFPS = new System.Windows.Forms.Label();
            this.lblInfoVideoLength = new System.Windows.Forms.Label();
            this.tBoxLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxSize = new System.Windows.Forms.TextBox();
            this.btnCalcVideoSize = new System.Windows.Forms.Button();
            this.lblInfoVideoSizeResult = new System.Windows.Forms.Label();
            this.lblVideoSize = new System.Windows.Forms.Label();
            this.cBoxEndSystem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxStartSystem = new System.Windows.Forms.ComboBox();
            this.lblNumberSystemResult = new System.Windows.Forms.Label();
            this.tBoxStartNumber = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCalcNumberSystem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoTech
            // 
            this.lblInfoTech.AutoSize = true;
            this.lblInfoTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoTech.Location = new System.Drawing.Point(78, 9);
            this.lblInfoTech.Name = "lblInfoTech";
            this.lblInfoTech.Size = new System.Drawing.Size(164, 22);
            this.lblInfoTech.TabIndex = 0;
            this.lblInfoTech.Text = "Informationstechnik";
            // 
            // lblResultInfoTech
            // 
            this.lblResultInfoTech.AutoSize = true;
            this.lblResultInfoTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultInfoTech.Location = new System.Drawing.Point(11, 118);
            this.lblResultInfoTech.Name = "lblResultInfoTech";
            this.lblResultInfoTech.Size = new System.Drawing.Size(76, 20);
            this.lblResultInfoTech.TabIndex = 1;
            this.lblResultInfoTech.Text = "Ergebnis:";
            // 
            // tBox_number
            // 
            this.tBox_number.Location = new System.Drawing.Point(13, 19);
            this.tBox_number.Name = "tBox_number";
            this.tBox_number.Size = new System.Drawing.Size(118, 20);
            this.tBox_number.TabIndex = 4;
            // 
            // btnCloseBasicCalc
            // 
            this.btnCloseBasicCalc.Location = new System.Drawing.Point(149, 686);
            this.btnCloseBasicCalc.Name = "btnCloseBasicCalc";
            this.btnCloseBasicCalc.Size = new System.Drawing.Size(138, 36);
            this.btnCloseBasicCalc.TabIndex = 24;
            this.btnCloseBasicCalc.Text = "Grundrechner schließen";
            this.btnCloseBasicCalc.UseVisualStyleBackColor = true;
            // 
            // btnChooseModules
            // 
            this.btnChooseModules.Location = new System.Drawing.Point(-3, 686);
            this.btnChooseModules.Name = "btnChooseModules";
            this.btnChooseModules.Size = new System.Drawing.Size(146, 36);
            this.btnChooseModules.TabIndex = 23;
            this.btnChooseModules.Text = "Rechenmodul auswählen";
            this.btnChooseModules.UseVisualStyleBackColor = true;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(93, 118);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(18, 20);
            this.lbl_result.TabIndex = 27;
            this.lbl_result.Text = "0";
            // 
            // cBox_prefixes
            // 
            this.cBox_prefixes.FormattingEnabled = true;
            this.cBox_prefixes.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "",
            "B",
            "KiB",
            "MiB",
            "GiB",
            "TiB",
            "PiB"});
            this.cBox_prefixes.Location = new System.Drawing.Point(137, 19);
            this.cBox_prefixes.Name = "cBox_prefixes";
            this.cBox_prefixes.Size = new System.Drawing.Size(65, 21);
            this.cBox_prefixes.TabIndex = 28;
            // 
            // lbl_resultPrefix
            // 
            this.lbl_resultPrefix.AutoSize = true;
            this.lbl_resultPrefix.Location = new System.Drawing.Point(12, 71);
            this.lbl_resultPrefix.Name = "lbl_resultPrefix";
            this.lbl_resultPrefix.Size = new System.Drawing.Size(80, 13);
            this.lbl_resultPrefix.TabIndex = 29;
            this.lbl_resultPrefix.Text = "Ergebnis Präfix:";
            // 
            // cBox_resultPrefix
            // 
            this.cBox_resultPrefix.FormattingEnabled = true;
            this.cBox_resultPrefix.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "",
            "B",
            "KiB",
            "MiB",
            "GiB",
            "TiB",
            "PiB"});
            this.cBox_resultPrefix.Location = new System.Drawing.Point(137, 63);
            this.cBox_resultPrefix.Name = "cBox_resultPrefix";
            this.cBox_resultPrefix.Size = new System.Drawing.Size(65, 21);
            this.cBox_resultPrefix.TabIndex = 30;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 175);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 23);
            this.btnCalculate.TabIndex = 31;
            this.btnCalculate.Text = "Umwandeln";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tBoxFPS
            // 
            this.tBoxFPS.Location = new System.Drawing.Point(95, 27);
            this.tBoxFPS.Name = "tBoxFPS";
            this.tBoxFPS.Size = new System.Drawing.Size(100, 20);
            this.tBoxFPS.TabIndex = 33;
            // 
            // lblInfoFPS
            // 
            this.lblInfoFPS.AutoSize = true;
            this.lblInfoFPS.Location = new System.Drawing.Point(17, 27);
            this.lblInfoFPS.Name = "lblInfoFPS";
            this.lblInfoFPS.Size = new System.Drawing.Size(30, 13);
            this.lblInfoFPS.TabIndex = 34;
            this.lblInfoFPS.Text = "FPS:";
            // 
            // lblInfoVideoLength
            // 
            this.lblInfoVideoLength.AutoSize = true;
            this.lblInfoVideoLength.Location = new System.Drawing.Point(17, 53);
            this.lblInfoVideoLength.Name = "lblInfoVideoLength";
            this.lblInfoVideoLength.Size = new System.Drawing.Size(61, 13);
            this.lblInfoVideoLength.TabIndex = 36;
            this.lblInfoVideoLength.Text = "Länge in S:";
            // 
            // tBoxLength
            // 
            this.tBoxLength.Location = new System.Drawing.Point(95, 53);
            this.tBoxLength.Name = "tBoxLength";
            this.tBoxLength.Size = new System.Drawing.Size(100, 20);
            this.tBoxLength.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Bildgröße in B:";
            // 
            // tBoxSize
            // 
            this.tBoxSize.Location = new System.Drawing.Point(95, 79);
            this.tBoxSize.Name = "tBoxSize";
            this.tBoxSize.Size = new System.Drawing.Size(100, 20);
            this.tBoxSize.TabIndex = 37;
            // 
            // btnCalcVideoSize
            // 
            this.btnCalcVideoSize.Location = new System.Drawing.Point(14, 146);
            this.btnCalcVideoSize.Name = "btnCalcVideoSize";
            this.btnCalcVideoSize.Size = new System.Drawing.Size(143, 23);
            this.btnCalcVideoSize.TabIndex = 39;
            this.btnCalcVideoSize.Text = "Umwandeln";
            this.btnCalcVideoSize.UseVisualStyleBackColor = true;
            this.btnCalcVideoSize.Click += new System.EventHandler(this.btnCalcVideoSize_Click);
            // 
            // lblInfoVideoSizeResult
            // 
            this.lblInfoVideoSizeResult.AutoSize = true;
            this.lblInfoVideoSizeResult.Location = new System.Drawing.Point(20, 113);
            this.lblInfoVideoSizeResult.Name = "lblInfoVideoSizeResult";
            this.lblInfoVideoSizeResult.Size = new System.Drawing.Size(64, 13);
            this.lblInfoVideoSizeResult.TabIndex = 40;
            this.lblInfoVideoSizeResult.Text = "Videogröße:";
            // 
            // lblVideoSize
            // 
            this.lblVideoSize.AutoSize = true;
            this.lblVideoSize.Location = new System.Drawing.Point(93, 113);
            this.lblVideoSize.Name = "lblVideoSize";
            this.lblVideoSize.Size = new System.Drawing.Size(13, 13);
            this.lblVideoSize.TabIndex = 41;
            this.lblVideoSize.Text = "0";
            // 
            // cBoxEndSystem
            // 
            this.cBoxEndSystem.FormattingEnabled = true;
            this.cBoxEndSystem.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cBoxEndSystem.Location = new System.Drawing.Point(129, 73);
            this.cBoxEndSystem.Name = "cBoxEndSystem";
            this.cBoxEndSystem.Size = new System.Drawing.Size(65, 21);
            this.cBoxEndSystem.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ergebnis Zahlensystem:";
            // 
            // cBoxStartSystem
            // 
            this.cBoxStartSystem.FormattingEnabled = true;
            this.cBoxStartSystem.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cBoxStartSystem.Location = new System.Drawing.Point(129, 29);
            this.cBoxStartSystem.Name = "cBoxStartSystem";
            this.cBoxStartSystem.Size = new System.Drawing.Size(65, 21);
            this.cBoxStartSystem.TabIndex = 46;
            // 
            // lblNumberSystemResult
            // 
            this.lblNumberSystemResult.AutoSize = true;
            this.lblNumberSystemResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSystemResult.Location = new System.Drawing.Point(85, 109);
            this.lblNumberSystemResult.Name = "lblNumberSystemResult";
            this.lblNumberSystemResult.Size = new System.Drawing.Size(18, 20);
            this.lblNumberSystemResult.TabIndex = 45;
            this.lblNumberSystemResult.Text = "0";
            // 
            // tBoxStartNumber
            // 
            this.tBoxStartNumber.Location = new System.Drawing.Point(5, 29);
            this.tBoxStartNumber.Name = "tBoxStartNumber";
            this.tBoxStartNumber.Size = new System.Drawing.Size(118, 20);
            this.tBoxStartNumber.TabIndex = 43;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 109);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(76, 20);
            this.lblInfo.TabIndex = 42;
            this.lblInfo.Text = "Ergebnis:";
            // 
            // btnCalcNumberSystem
            // 
            this.btnCalcNumberSystem.Location = new System.Drawing.Point(5, 156);
            this.btnCalcNumberSystem.Name = "btnCalcNumberSystem";
            this.btnCalcNumberSystem.Size = new System.Drawing.Size(143, 23);
            this.btnCalcNumberSystem.TabIndex = 49;
            this.btnCalcNumberSystem.Text = "Umwandeln";
            this.btnCalcNumberSystem.UseVisualStyleBackColor = true;
            this.btnCalcNumberSystem.Click += new System.EventHandler(this.btnCalcNumberSystem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultInfoTech);
            this.groupBox1.Controls.Add(this.tBox_number);
            this.groupBox1.Controls.Add(this.lbl_result);
            this.groupBox1.Controls.Add(this.cBox_prefixes);
            this.groupBox1.Controls.Add(this.lbl_resultPrefix);
            this.groupBox1.Controls.Add(this.cBox_resultPrefix);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 215);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Binär-Präfix-Umrechner:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfoFPS);
            this.groupBox2.Controls.Add(this.tBoxFPS);
            this.groupBox2.Controls.Add(this.tBoxLength);
            this.groupBox2.Controls.Add(this.lblInfoVideoLength);
            this.groupBox2.Controls.Add(this.tBoxSize);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCalcVideoSize);
            this.groupBox2.Controls.Add(this.lblInfoVideoSizeResult);
            this.groupBox2.Controls.Add(this.lblVideoSize);
            this.groupBox2.Location = new System.Drawing.Point(14, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 186);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Videogröße berechnen:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblInfo);
            this.groupBox3.Controls.Add(this.tBoxStartNumber);
            this.groupBox3.Controls.Add(this.btnCalcNumberSystem);
            this.groupBox3.Controls.Add(this.lblNumberSystemResult);
            this.groupBox3.Controls.Add(this.cBoxEndSystem);
            this.groupBox3.Controls.Add(this.cBoxStartSystem);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(14, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 201);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zahlensystem-Umwandler:";
            // 
            // FormInfoTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 734);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseBasicCalc);
            this.Controls.Add(this.btnChooseModules);
            this.Controls.Add(this.lblInfoTech);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInfoTech";
            this.Text = "Taschenrechner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoTech;
        private System.Windows.Forms.Label lblResultInfoTech;
        private System.Windows.Forms.TextBox tBox_number;
        private System.Windows.Forms.Button btnCloseBasicCalc;
        private System.Windows.Forms.Button btnChooseModules;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.ComboBox cBox_prefixes;
        private System.Windows.Forms.Label lbl_resultPrefix;
        private System.Windows.Forms.ComboBox cBox_resultPrefix;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tBoxFPS;
        private System.Windows.Forms.Label lblInfoFPS;
        private System.Windows.Forms.Label lblInfoVideoLength;
        private System.Windows.Forms.TextBox tBoxLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxSize;
        private System.Windows.Forms.Button btnCalcVideoSize;
        private System.Windows.Forms.Label lblInfoVideoSizeResult;
        private System.Windows.Forms.Label lblVideoSize;
        private System.Windows.Forms.ComboBox cBoxEndSystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxStartSystem;
        private System.Windows.Forms.Label lblNumberSystemResult;
        private System.Windows.Forms.TextBox tBoxStartNumber;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCalcNumberSystem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}