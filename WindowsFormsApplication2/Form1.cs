/**
 * Jason Walsh
 * Nadia Kiamilev
 * CISC360
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeminiCore;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public CPU myCPU;
        public Memory myMemory;

        public Form1()
        {
            myCPU = new CPU();
            myMemory = new Memory();
            
            InitializeComponent();
        }

        #region Events
        private void loadFileButton_Click(object sender, EventArgs e)
        {
            String[] textArray;

            this.disableButtons();
            System.IO.File.Create(@".\binaryCodes.txt").Close();
            System.IO.File.Create(@".\binaryCodes2.txt").Close();
            
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        var ipe = new IPE(ofd.FileName);
                        ipe.ParseFile();
                        //textArray = ipe.text; //set ipe text
                    }
                    catch (Exception err)
                    {
                        // show a dialog with error
                    }
                }
            }
            this.myCPU.readBinaryFile();
            
            //Console.WriteLine(ipe.text.Length + "check out the number of instructions");
            
            //need to convert the instructions to strings
            String[] instructConverted = new String[myCPU.finalCodes.Length];
            for (int i = 0; i < myCPU.finalCodes.Length; i++ )
            {
                String temp = myCPU.finalCodes[i].ToString();
                instructConverted[i] = temp;
                Console.WriteLine(instructConverted[i]);
            }
            Console.WriteLine(instructConverted.Length + " " + myCPU.finalCodes.Length);
        }
        #endregion

        private void nextInstructionButton_Click(object sender, EventArgs e)
        {            
            this.disableButtons();
            this.myCPU.nextInstruction();
            this.myCPU.nextInstructionText();
            this.setCPUValuesToView();
        }

        private void disableButtons()
        {
            if (IPE.buttonsEnabled == false)
            {
                nextInstructionButton.Enabled = false;
                loadFileButton.Enabled = false;
                RunToEndButton.Enabled = false;
                ResetButton.Enabled = false;
            }
        }

        public void setCPUValuesToView()
        {
            this.aLabel.Text = this.myCPU.A.ToString();
            this.bLabel.Text = this.myCPU.B.ToString();
            this.accLabel.Text = this.myCPU.ACC.ToString();
            this.zeroLabel.Text = this.myCPU.Zero.ToString();
            this.oneLabel.Text = this.myCPU.One.ToString();
            this.pcLabel.Text = this.myCPU.PC.ToString();
            this.marLabel.Text = this.myCPU.MAR.ToString();
            this.mdrLabel.Text = this.myCPU.MDR.ToString();
            this.tempLabel.Text = this.myCPU.TEMP.ToString();
            this.irLabel.Text = this.myCPU.IR.ToString();
            this.ccLabel.Text = this.myCPU.CC.ToString();
            this.instructionLabel.Text = this.myCPU.nextInstructionLabel; //Instruction label text
            this.operationCount.Text = this.myCPU.operationCount.ToString();
            this.hitMiss.Text = this.myCPU.cacheStatus;
            this.numHits.Text = this.myCPU.hitsMemory.ToString();
            this.numMisses.Text = this.myCPU.missMemory.ToString();
            this.cacheSize.Text = Memory.cacheSize.ToString();
            this.fetchVal.Text = this.myCPU.fetchString;
            this.decodeVal.Text = this.myCPU.decodeString;
            this.executeVal.Text = this.myCPU.executeString;
            this.storeVal.Text = this.myCPU.storeString;
            this.NOP.Text = this.myCPU.nopCount.ToString();

        }

        private void RunToEndButton_Click(object sender, EventArgs e)
        {
            this.disableButtons();
            this.myCPU.runToEnd();
            this.setCPUValuesToView();
        }

        private void resetCpu_Click(object sender, EventArgs e)
        {
            System.IO.File.Create(@".\binaryCodes2.txt").Close();
            this.disableButtons();
            this.myCPU.resetCPU();
            this.setCPUValuesToView();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myCPU.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bypassing_CheckedChanged(object sender, EventArgs e)
        {
            this.myCPU.isBypassing = !this.myCPU.isBypassing;
            Console.WriteLine("Bypassing is " + this.myCPU.isBypassing);
        }

        private void branchPredict_CheckedChanged(object sender, EventArgs e)
        {
            this.myCPU.isBranchPrediction = !this.myCPU.isBranchPrediction;
            Console.WriteLine("Branch Prediction " + this.myCPU.isBranchPrediction);
        }
    }
}
