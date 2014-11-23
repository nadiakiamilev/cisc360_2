/**
* Jason Walsh
* Nadia Kiamilev
* CISC360
*/

namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.accLabel = new System.Windows.Forms.Label();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.nextInstructionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.zeroLabel = new System.Windows.Forms.Label();
            this.oneLabel = new System.Windows.Forms.Label();
            this.pcLabel = new System.Windows.Forms.Label();
            this.marLabel = new System.Windows.Forms.Label();
            this.mdrLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.irLabel = new System.Windows.Forms.Label();
            this.ccLabel = new System.Windows.Forms.Label();
            this.RunToEndButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.operationCount = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.resetCpu = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cacheSize = new System.Windows.Forms.Label();
            this.cacheLabel = new System.Windows.Forms.Label();
            this.numMisses = new System.Windows.Forms.Label();
            this.numHits = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.CacheHits = new System.Windows.Forms.Label();
            this.hitMiss = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Bypassing = new System.Windows.Forms.CheckBox();
            this.NOP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.storeVal = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.decodeVal = new System.Windows.Forms.Label();
            this.executeVal = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.fetchVal = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.branchPredict = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Indigo;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACC:";
            // 
            // accLabel
            // 
            this.accLabel.AutoSize = true;
            this.accLabel.BackColor = System.Drawing.Color.Indigo;
            this.accLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accLabel.ForeColor = System.Drawing.Color.White;
            this.accLabel.Location = new System.Drawing.Point(252, 298);
            this.accLabel.Name = "accLabel";
            this.accLabel.Size = new System.Drawing.Size(80, 35);
            this.accLabel.TabIndex = 1;
            this.accLabel.Text = "value";
            // 
            // loadFileButton
            // 
            this.loadFileButton.AutoSize = true;
            this.loadFileButton.BackColor = System.Drawing.Color.White;
            this.loadFileButton.FlatAppearance.BorderSize = 0;
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileButton.Location = new System.Drawing.Point(634, 38);
            this.loadFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(167, 63);
            this.loadFileButton.TabIndex = 2;
            this.loadFileButton.Text = "LOAD FILE";
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // nextInstructionButton
            // 
            this.nextInstructionButton.AutoSize = true;
            this.nextInstructionButton.BackColor = System.Drawing.Color.White;
            this.nextInstructionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextInstructionButton.FlatAppearance.BorderSize = 0;
            this.nextInstructionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextInstructionButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextInstructionButton.ForeColor = System.Drawing.Color.Black;
            this.nextInstructionButton.Location = new System.Drawing.Point(12, 172);
            this.nextInstructionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextInstructionButton.Name = "nextInstructionButton";
            this.nextInstructionButton.Size = new System.Drawing.Size(159, 68);
            this.nextInstructionButton.TabIndex = 3;
            this.nextInstructionButton.Text = "NEXT";
            this.nextInstructionButton.UseVisualStyleBackColor = false;
            this.nextInstructionButton.Click += new System.EventHandler(this.nextInstructionButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "ZERO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Indigo;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 389);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "ONE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Indigo;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(66, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "PC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Indigo;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(66, 482);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 35);
            this.label7.TabIndex = 9;
            this.label7.Text = "MAR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Indigo;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(66, 529);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 35);
            this.label8.TabIndex = 10;
            this.label8.Text = "MDR:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Indigo;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(66, 575);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 35);
            this.label9.TabIndex = 11;
            this.label9.Text = "TEMP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Indigo;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(66, 622);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 35);
            this.label10.TabIndex = 12;
            this.label10.Text = "IR:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Indigo;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(66, 668);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 35);
            this.label11.TabIndex = 13;
            this.label11.Text = "CC:";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.BackColor = System.Drawing.Color.Indigo;
            this.aLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabel.ForeColor = System.Drawing.Color.White;
            this.aLabel.Location = new System.Drawing.Point(252, 206);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(80, 35);
            this.aLabel.TabIndex = 14;
            this.aLabel.Text = "value";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.BackColor = System.Drawing.Color.Indigo;
            this.bLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLabel.ForeColor = System.Drawing.Color.White;
            this.bLabel.Location = new System.Drawing.Point(252, 252);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(80, 35);
            this.bLabel.TabIndex = 15;
            this.bLabel.Text = "value";
            // 
            // zeroLabel
            // 
            this.zeroLabel.AutoSize = true;
            this.zeroLabel.BackColor = System.Drawing.Color.Indigo;
            this.zeroLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroLabel.ForeColor = System.Drawing.Color.White;
            this.zeroLabel.Location = new System.Drawing.Point(252, 345);
            this.zeroLabel.Name = "zeroLabel";
            this.zeroLabel.Size = new System.Drawing.Size(80, 35);
            this.zeroLabel.TabIndex = 16;
            this.zeroLabel.Text = "value";
            // 
            // oneLabel
            // 
            this.oneLabel.AutoSize = true;
            this.oneLabel.BackColor = System.Drawing.Color.Indigo;
            this.oneLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneLabel.ForeColor = System.Drawing.Color.White;
            this.oneLabel.Location = new System.Drawing.Point(252, 389);
            this.oneLabel.Name = "oneLabel";
            this.oneLabel.Size = new System.Drawing.Size(80, 35);
            this.oneLabel.TabIndex = 17;
            this.oneLabel.Text = "value";
            // 
            // pcLabel
            // 
            this.pcLabel.AutoSize = true;
            this.pcLabel.BackColor = System.Drawing.Color.Indigo;
            this.pcLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcLabel.ForeColor = System.Drawing.Color.White;
            this.pcLabel.Location = new System.Drawing.Point(252, 435);
            this.pcLabel.Name = "pcLabel";
            this.pcLabel.Size = new System.Drawing.Size(80, 35);
            this.pcLabel.TabIndex = 18;
            this.pcLabel.Text = "value";
            // 
            // marLabel
            // 
            this.marLabel.AutoSize = true;
            this.marLabel.BackColor = System.Drawing.Color.Indigo;
            this.marLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marLabel.ForeColor = System.Drawing.Color.White;
            this.marLabel.Location = new System.Drawing.Point(252, 482);
            this.marLabel.Name = "marLabel";
            this.marLabel.Size = new System.Drawing.Size(80, 35);
            this.marLabel.TabIndex = 19;
            this.marLabel.Text = "value";
            // 
            // mdrLabel
            // 
            this.mdrLabel.AutoSize = true;
            this.mdrLabel.BackColor = System.Drawing.Color.Indigo;
            this.mdrLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdrLabel.ForeColor = System.Drawing.Color.White;
            this.mdrLabel.Location = new System.Drawing.Point(252, 529);
            this.mdrLabel.Name = "mdrLabel";
            this.mdrLabel.Size = new System.Drawing.Size(80, 35);
            this.mdrLabel.TabIndex = 20;
            this.mdrLabel.Text = "value";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Indigo;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(252, 575);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(80, 35);
            this.tempLabel.TabIndex = 21;
            this.tempLabel.Text = "value";
            // 
            // irLabel
            // 
            this.irLabel.AutoSize = true;
            this.irLabel.BackColor = System.Drawing.Color.Indigo;
            this.irLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irLabel.ForeColor = System.Drawing.Color.White;
            this.irLabel.Location = new System.Drawing.Point(252, 622);
            this.irLabel.Name = "irLabel";
            this.irLabel.Size = new System.Drawing.Size(80, 35);
            this.irLabel.TabIndex = 22;
            this.irLabel.Text = "value";
            // 
            // ccLabel
            // 
            this.ccLabel.AutoSize = true;
            this.ccLabel.BackColor = System.Drawing.Color.Indigo;
            this.ccLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccLabel.ForeColor = System.Drawing.Color.White;
            this.ccLabel.Location = new System.Drawing.Point(252, 668);
            this.ccLabel.Name = "ccLabel";
            this.ccLabel.Size = new System.Drawing.Size(80, 35);
            this.ccLabel.TabIndex = 23;
            this.ccLabel.Text = "value";
            // 
            // RunToEndButton
            // 
            this.RunToEndButton.AutoSize = true;
            this.RunToEndButton.BackColor = System.Drawing.Color.White;
            this.RunToEndButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RunToEndButton.FlatAppearance.BorderSize = 0;
            this.RunToEndButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunToEndButton.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunToEndButton.ForeColor = System.Drawing.Color.Black;
            this.RunToEndButton.Location = new System.Drawing.Point(194, 172);
            this.RunToEndButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RunToEndButton.Name = "RunToEndButton";
            this.RunToEndButton.Size = new System.Drawing.Size(175, 68);
            this.RunToEndButton.TabIndex = 24;
            this.RunToEndButton.Text = "RUN TO END";
            this.RunToEndButton.UseVisualStyleBackColor = false;
            this.RunToEndButton.Click += new System.EventHandler(this.RunToEndButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(0, 0);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.CadetBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 35);
            this.label12.TabIndex = 26;
            this.label12.Text = "Next Instr:";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.BackColor = System.Drawing.Color.CadetBlue;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.White;
            this.instructionLabel.Location = new System.Drawing.Point(218, 38);
            this.instructionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(145, 35);
            this.instructionLabel.TabIndex = 27;
            this.instructionLabel.Text = "instruction";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.CadetBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(15, 102);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 35);
            this.label13.TabIndex = 28;
            this.label13.Text = "Op Count:";
            // 
            // operationCount
            // 
            this.operationCount.AutoSize = true;
            this.operationCount.BackColor = System.Drawing.Color.CadetBlue;
            this.operationCount.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationCount.ForeColor = System.Drawing.Color.White;
            this.operationCount.Location = new System.Drawing.Point(218, 102);
            this.operationCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.operationCount.Name = "operationCount";
            this.operationCount.Size = new System.Drawing.Size(128, 35);
            this.operationCount.TabIndex = 29;
            this.operationCount.Text = "op count";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(413, 63);
            this.title.TabIndex = 30;
            this.title.Text = "Gemini Simulator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(8, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 558);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.RunToEndButton);
            this.panel2.Controls.Add(this.instructionLabel);
            this.panel2.Controls.Add(this.operationCount);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.nextInstructionButton);
            this.panel2.Location = new System.Drawing.Point(440, 449);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 271);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.resetCpu);
            this.panel3.Controls.Add(this.title);
            this.panel3.Controls.Add(this.loadFileButton);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(816, 142);
            this.panel3.TabIndex = 32;
            // 
            // resetCpu
            // 
            this.resetCpu.BackColor = System.Drawing.Color.White;
            this.resetCpu.FlatAppearance.BorderSize = 0;
            this.resetCpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetCpu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetCpu.Location = new System.Drawing.Point(435, 38);
            this.resetCpu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resetCpu.Name = "resetCpu";
            this.resetCpu.Size = new System.Drawing.Size(159, 63);
            this.resetCpu.TabIndex = 31;
            this.resetCpu.Text = "RESET CPU";
            this.resetCpu.UseVisualStyleBackColor = false;
            this.resetCpu.Click += new System.EventHandler(this.resetCpu_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.cacheSize);
            this.panel4.Controls.Add(this.cacheLabel);
            this.panel4.Controls.Add(this.numMisses);
            this.panel4.Controls.Add(this.numHits);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.CacheHits);
            this.panel4.Controls.Add(this.hitMiss);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(440, 162);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(384, 277);
            this.panel4.TabIndex = 33;
            // 
            // cacheSize
            // 
            this.cacheSize.AutoSize = true;
            this.cacheSize.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheSize.ForeColor = System.Drawing.Color.White;
            this.cacheSize.Location = new System.Drawing.Point(240, 20);
            this.cacheSize.Name = "cacheSize";
            this.cacheSize.Size = new System.Drawing.Size(95, 50);
            this.cacheSize.TabIndex = 36;
            this.cacheSize.Text = "Size";
            // 
            // cacheLabel
            // 
            this.cacheLabel.AutoSize = true;
            this.cacheLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheLabel.ForeColor = System.Drawing.Color.White;
            this.cacheLabel.Location = new System.Drawing.Point(15, 20);
            this.cacheLabel.Name = "cacheLabel";
            this.cacheLabel.Size = new System.Drawing.Size(134, 50);
            this.cacheLabel.TabIndex = 35;
            this.cacheLabel.Text = "Cache";
            // 
            // numMisses
            // 
            this.numMisses.AutoSize = true;
            this.numMisses.BackColor = System.Drawing.Color.CadetBlue;
            this.numMisses.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMisses.ForeColor = System.Drawing.Color.White;
            this.numMisses.Location = new System.Drawing.Point(214, 209);
            this.numMisses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numMisses.Name = "numMisses";
            this.numMisses.Size = new System.Drawing.Size(155, 35);
            this.numMisses.TabIndex = 34;
            this.numMisses.Text = "# of Misses";
            // 
            // numHits
            // 
            this.numHits.AutoSize = true;
            this.numHits.BackColor = System.Drawing.Color.CadetBlue;
            this.numHits.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHits.ForeColor = System.Drawing.Color.White;
            this.numHits.Location = new System.Drawing.Point(218, 146);
            this.numHits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numHits.Name = "numHits";
            this.numHits.Size = new System.Drawing.Size(121, 35);
            this.numHits.TabIndex = 33;
            this.numHits.Text = "# of Hits";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.CadetBlue;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(12, 209);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(190, 35);
            this.label17.TabIndex = 32;
            this.label17.Text = "Cache Misses:";
            // 
            // CacheHits
            // 
            this.CacheHits.AutoSize = true;
            this.CacheHits.BackColor = System.Drawing.Color.CadetBlue;
            this.CacheHits.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CacheHits.ForeColor = System.Drawing.Color.White;
            this.CacheHits.Location = new System.Drawing.Point(15, 146);
            this.CacheHits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CacheHits.Name = "CacheHits";
            this.CacheHits.Size = new System.Drawing.Size(156, 35);
            this.CacheHits.TabIndex = 31;
            this.CacheHits.Text = "Cache Hits:";
            // 
            // hitMiss
            // 
            this.hitMiss.AutoSize = true;
            this.hitMiss.BackColor = System.Drawing.Color.CadetBlue;
            this.hitMiss.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitMiss.ForeColor = System.Drawing.Color.White;
            this.hitMiss.Location = new System.Drawing.Point(214, 85);
            this.hitMiss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hitMiss.Name = "hitMiss";
            this.hitMiss.Size = new System.Drawing.Size(149, 35);
            this.hitMiss.TabIndex = 30;
            this.hitMiss.Text = "Hit or Miss";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.CadetBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 35);
            this.label14.TabIndex = 27;
            this.label14.Text = "Cache:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Store
            // 
            this.Store.Name = "Store";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkViolet;
            this.panel5.Controls.Add(this.branchPredict);
            this.panel5.Controls.Add(this.Bypassing);
            this.panel5.Controls.Add(this.NOP);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.storeVal);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.decodeVal);
            this.panel5.Controls.Add(this.executeVal);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.fetchVal);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Location = new System.Drawing.Point(840, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 712);
            this.panel5.TabIndex = 34;
            // 
            // Bypassing
            // 
            this.Bypassing.AutoSize = true;
            this.Bypassing.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bypassing.ForeColor = System.Drawing.Color.White;
            this.Bypassing.Location = new System.Drawing.Point(21, 478);
            this.Bypassing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bypassing.Name = "Bypassing";
            this.Bypassing.Size = new System.Drawing.Size(266, 39);
            this.Bypassing.TabIndex = 35;
            this.Bypassing.Text = "Hazard Bypassing";
            this.Bypassing.UseVisualStyleBackColor = true;
            this.Bypassing.CheckedChanged += new System.EventHandler(this.Bypassing_CheckedChanged);
            // 
            // NOP
            // 
            this.NOP.BackColor = System.Drawing.Color.DarkViolet;
            this.NOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NOP.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F);
            this.NOP.ForeColor = System.Drawing.Color.White;
            this.NOP.Location = new System.Drawing.Point(162, 365);
            this.NOP.Name = "NOP";
            this.NOP.Size = new System.Drawing.Size(100, 36);
            this.NOP.TabIndex = 40;
            this.NOP.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkViolet;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(21, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 36);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "NOPs:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // storeVal
            // 
            this.storeVal.AutoSize = true;
            this.storeVal.BackColor = System.Drawing.Color.DarkViolet;
            this.storeVal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeVal.ForeColor = System.Drawing.Color.White;
            this.storeVal.Location = new System.Drawing.Point(156, 302);
            this.storeVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storeVal.Name = "storeVal";
            this.storeVal.Size = new System.Drawing.Size(45, 35);
            this.storeVal.TabIndex = 38;
            this.storeVal.Text = "ST";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.DarkViolet;
            this.label25.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(15, 302);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 35);
            this.label25.TabIndex = 37;
            this.label25.Text = "Store:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(14, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 50);
            this.label15.TabIndex = 36;
            this.label15.Text = "Pipeline";
            // 
            // decodeVal
            // 
            this.decodeVal.AutoSize = true;
            this.decodeVal.BackColor = System.Drawing.Color.DarkViolet;
            this.decodeVal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeVal.ForeColor = System.Drawing.Color.White;
            this.decodeVal.Location = new System.Drawing.Point(152, 176);
            this.decodeVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decodeVal.Name = "decodeVal";
            this.decodeVal.Size = new System.Drawing.Size(50, 35);
            this.decodeVal.TabIndex = 34;
            this.decodeVal.Text = "DE";
            // 
            // executeVal
            // 
            this.executeVal.AutoSize = true;
            this.executeVal.BackColor = System.Drawing.Color.DarkViolet;
            this.executeVal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeVal.ForeColor = System.Drawing.Color.White;
            this.executeVal.Location = new System.Drawing.Point(156, 240);
            this.executeVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.executeVal.Name = "executeVal";
            this.executeVal.Size = new System.Drawing.Size(47, 35);
            this.executeVal.TabIndex = 33;
            this.executeVal.Text = "EX";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.DarkViolet;
            this.label21.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(15, 176);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 35);
            this.label21.TabIndex = 32;
            this.label21.Text = "Decode:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.DarkViolet;
            this.label22.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(15, 240);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 35);
            this.label22.TabIndex = 31;
            this.label22.Text = "Execute:";
            // 
            // fetchVal
            // 
            this.fetchVal.AutoSize = true;
            this.fetchVal.BackColor = System.Drawing.Color.DarkViolet;
            this.fetchVal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchVal.ForeColor = System.Drawing.Color.White;
            this.fetchVal.Location = new System.Drawing.Point(152, 118);
            this.fetchVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fetchVal.Name = "fetchVal";
            this.fetchVal.Size = new System.Drawing.Size(44, 35);
            this.fetchVal.TabIndex = 30;
            this.fetchVal.Text = "FE";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(18, 118);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 35);
            this.label24.TabIndex = 27;
            this.label24.Text = "Fetch:";
            // 
            // branchPredict
            // 
            this.branchPredict.AutoSize = true;
            this.branchPredict.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchPredict.ForeColor = System.Drawing.Color.White;
            this.branchPredict.Location = new System.Drawing.Point(21, 539);
            this.branchPredict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.branchPredict.Name = "branchPredict";
            this.branchPredict.Size = new System.Drawing.Size(260, 39);
            this.branchPredict.TabIndex = 41;
            this.branchPredict.Text = "Branch Prediction";
            this.branchPredict.UseVisualStyleBackColor = true;
            this.branchPredict.CheckedChanged += new System.EventHandler(this.branchPredict_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 732);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ccLabel);
            this.Controls.Add(this.irLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.mdrLabel);
            this.Controls.Add(this.marLabel);
            this.Controls.Add(this.pcLabel);
            this.Controls.Add(this.oneLabel);
            this.Controls.Add(this.zeroLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.aLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Gemini";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label accLabel;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Button nextInstructionButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label zeroLabel;
        private System.Windows.Forms.Label oneLabel;
        private System.Windows.Forms.Label pcLabel;
        private System.Windows.Forms.Label marLabel;
        private System.Windows.Forms.Label mdrLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label irLabel;
        private System.Windows.Forms.Label ccLabel;
        private System.Windows.Forms.Button RunToEndButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label operationCount;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button resetCpu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label hitMiss;
        private System.Windows.Forms.Label numMisses;
        private System.Windows.Forms.Label numHits;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label CacheHits;
        private System.Windows.Forms.Label cacheLabel;
        private System.Windows.Forms.Label cacheSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fetch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Execute;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label decodeVal;
        private System.Windows.Forms.Label executeVal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label fetchVal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label storeVal;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox NOP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Bypassing;
        private System.Windows.Forms.CheckBox branchPredict;

    }
}

