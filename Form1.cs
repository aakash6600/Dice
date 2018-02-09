
using Dice.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Dice
{
    public class DiceForm : Form
    {
        private int[] difference = new int[6];
        private int[] pctDifference = new int[6];
        private bool[] accetable = new bool[6];
        private string msgGood = "Conclusion:  die is good.";
        private string msgBad = "Conclusion:   die is bad!";
        private Random randomNumber = new Random();
        private IContainer components = (IContainer)null;
        private int timeToRoll;
        private int averageFrequency;
        private int threshold;
        private Label label1;
        private Label label2;
        private NumericUpDown nudTolearance;
        private Button btnRoll;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTheory;
        private Label label9;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox picAcceptable1;
        private PictureBox picAcceptable2;
        private PictureBox picAcceptable3;
        private PictureBox picAcceptable4;
        private PictureBox picAcceptable5;
        private PictureBox picAcceptable6;
        private Label lblActual1;
        private Label lblActual2;
        private Label lblActual3;
        private Label lblActual4;
        private Label lblActual5;
        private Label lblActual6;
        private Label lblDifference1;
        private Label lblDifference2;
        private Label lblDifference3;
        private Label lblDifference4;
        private Label lblDifference5;
        private Label lblDifference6;
        private Label lblPctDifference1;
        private Label lblPctDifference2;
        private Label lblPctDifference3;
        private Label lblPctDifference4;
        private Label lblPctDifference5;
        private Label lblPctDifference6;
        private Label lblConclusion;
        private Label label10;
        private HScrollBar hsbRollingTimes;
        private Label lblRollingTimes;
        private Label label11;

        public DiceForm()
        {
            this.InitializeComponent();
            this.threshold = (int)this.nudTolearance.Value;
            this.lblRollingTimes.Text = this.hsbRollingTimes.Value.ToString();
            this.averageFrequency = this.timeToRoll / 6;
            this.lblTheory.Text = this.averageFrequency.ToString();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            int[] numArray = new int[6];
            bool flag = true;
            Label[] labelArray1 = new Label[6]
      {
        this.lblDifference1,
        this.lblDifference2,
        this.lblDifference3,
        this.lblDifference4,
        this.lblDifference5,
        this.lblDifference6
      };
            Label[] labelArray2 = new Label[6]
      {
        this.lblActual1,
        this.lblActual2,
        this.lblActual3,
        this.lblActual4,
        this.lblActual5,
        this.lblActual6
      };
            Label[] labelArray3 = new Label[6]
      {
        this.lblPctDifference1,
        this.lblPctDifference2,
        this.lblPctDifference3,
        this.lblPctDifference4,
        this.lblPctDifference5,
        this.lblPctDifference6
      };
            PictureBox[] pictureBoxArray = new PictureBox[6]
      {
        this.picAcceptable1,
        this.picAcceptable2,
        this.picAcceptable3,
        this.picAcceptable4,
        this.picAcceptable5,
        this.picAcceptable6
      };
            this.timeToRoll = this.hsbRollingTimes.Value;
            this.averageFrequency = this.timeToRoll / 6;
            this.lblTheory.Text = this.averageFrequency.ToString();
            for (int index1 = 0; index1 < this.timeToRoll; ++index1)
            {
                int index2 = this.randomNumber.Next(0, 6);
                ++numArray[index2];
            }
            for (int index = 0; index < 6; ++index)
            {
                this.difference[index] = Math.Abs(numArray[index] - this.averageFrequency);
                labelArray2[index].Text = numArray[index].ToString();
                labelArray1[index].Text = this.difference[index].ToString();
                this.pctDifference[index] = (int)((double)this.difference[index] * 100.0 / (double)this.averageFrequency + 0.5);
                labelArray3[index].Text = this.pctDifference[index].ToString();
                if (this.pctDifference[index] > this.threshold)
                {
                    flag = false;
                    pictureBoxArray[index].Image = (Image)Resources.ResourceManager.GetObject("NO");
                }
                else
                    pictureBoxArray[index].Image = (Image)Resources.ResourceManager.GetObject("YES");
            }
            if (flag)
            {
                this.lblConclusion.Text = this.msgGood;
                this.lblConclusion.BackColor = Color.Green;
            }
            else
            {
                this.lblConclusion.Text = this.msgBad;
                this.lblConclusion.BackColor = Color.Red;
            }
        }

        private void nudTolearance_ValueChanged(object sender, EventArgs e)
        {
            this.threshold = (int)this.nudTolearance.Value;
        }

        private void hsbRollingTimes_Scroll(object sender, ScrollEventArgs e)
        {
            this.timeToRoll = this.hsbRollingTimes.Value;
            this.lblRollingTimes.Text = this.timeToRoll.ToString();
            this.averageFrequency = this.timeToRoll / 6;
            this.lblTheory.Text = this.averageFrequency.ToString();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.nudTolearance = new NumericUpDown();
            this.btnRoll = new Button();
            this.label3 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.lblTheory = new Label();
            this.label9 = new Label();
            this.label4 = new Label();
            this.pictureBox6 = new PictureBox();
            this.pictureBox5 = new PictureBox();
            this.pictureBox4 = new PictureBox();
            this.pictureBox3 = new PictureBox();
            this.pictureBox2 = new PictureBox();
            this.pictureBox1 = new PictureBox();
            this.picAcceptable1 = new PictureBox();
            this.picAcceptable2 = new PictureBox();
            this.picAcceptable3 = new PictureBox();
            this.picAcceptable4 = new PictureBox();
            this.picAcceptable5 = new PictureBox();
            this.picAcceptable6 = new PictureBox();
            this.lblActual1 = new Label();
            this.lblActual2 = new Label();
            this.lblActual3 = new Label();
            this.lblActual4 = new Label();
            this.lblActual5 = new Label();
            this.lblActual6 = new Label();
            this.lblDifference1 = new Label();
            this.lblDifference2 = new Label();
            this.lblDifference3 = new Label();
            this.lblDifference4 = new Label();
            this.lblDifference5 = new Label();
            this.lblDifference6 = new Label();
            this.lblPctDifference1 = new Label();
            this.lblPctDifference2 = new Label();
            this.lblPctDifference3 = new Label();
            this.lblPctDifference4 = new Label();
            this.lblPctDifference5 = new Label();
            this.lblPctDifference6 = new Label();
            this.lblConclusion = new Label();
            this.label10 = new Label();
            this.hsbRollingTimes = new HScrollBar();
            this.lblRollingTimes = new Label();
            this.label11 = new Label();
            this.nudTolearance.BeginInit();
            ((ISupportInitialize)this.pictureBox6).BeginInit();
            ((ISupportInitialize)this.pictureBox5).BeginInit();
            ((ISupportInitialize)this.pictureBox4).BeginInit();
            ((ISupportInitialize)this.pictureBox3).BeginInit();
            ((ISupportInitialize)this.pictureBox2).BeginInit();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            ((ISupportInitialize)this.picAcceptable1).BeginInit();
            ((ISupportInitialize)this.picAcceptable2).BeginInit();
            ((ISupportInitialize)this.picAcceptable3).BeginInit();
            ((ISupportInitialize)this.picAcceptable4).BeginInit();
            ((ISupportInitialize)this.picAcceptable5).BeginInit();
            ((ISupportInitialize)this.picAcceptable6).BeginInit();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.BorderStyle = BorderStyle.Fixed3D;
            this.label1.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label1.Location = new Point(44, 23);
            this.label1.Name = "label1";
            this.label1.Size = new Size(337, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Is this die reliable?";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label2.Location = new Point(38, 99);
            this.label2.Name = "label2";
            this.label2.Size = new Size(94, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rolling count:";
            this.nudTolearance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            this.nudTolearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.nudTolearance.Location = new Point(201, 63);
            NumericUpDown numericUpDown1 = this.nudTolearance;
            int[] bits1 = new int[4];
            bits1[0] = 15;
            Decimal num1 = new Decimal(bits1);
            numericUpDown1.Maximum = num1;
            NumericUpDown numericUpDown2 = this.nudTolearance;
            int[] bits2 = new int[4];
            bits2[0] = 3;
            Decimal num2 = new Decimal(bits2);
            numericUpDown2.Minimum = num2;
            this.nudTolearance.Name = "nudTolearance";
            this.nudTolearance.Size = new Size(38, 22);
            this.nudTolearance.TabIndex = 2;
            NumericUpDown numericUpDown3 = this.nudTolearance;
            int[] bits3 = new int[4];
            bits3[0] = 5;
            Decimal num3 = new Decimal(bits3);
            numericUpDown3.Value = num3;
            this.nudTolearance.ValueChanged += new EventHandler(this.nudTolearance_ValueChanged);
            this.btnRoll.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte)0);
            this.btnRoll.Location = new Point(146, 166);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new Size(118, 25);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "Roll the die!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new EventHandler(this.btnRoll_Click);
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label3.Location = new Point(23, 203);
            this.label3.Name = "label3";
            this.label3.Size = new Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Face";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label5.Location = new Point(67, 203);
            this.label5.Name = "label5";
            this.label5.Size = new Size(73, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Frequency";
            this.label6.AutoSize = true;
            this.label6.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label6.Location = new Point(139, 203);
            this.label6.Name = "label6";
            this.label6.Size = new Size(73, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Difference";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label7.Location = new Point(218, 203);
            this.label7.Name = "label7";
            this.label7.Size = new Size(90, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "%-Difference";
            this.label8.AutoSize = true;
            this.label8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label8.Location = new Point(83, 134);
            this.label8.Name = "label8";
            this.label8.Size = new Size(169, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Each face should appear:";
            this.lblTheory.AutoSize = true;
            this.lblTheory.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblTheory.Location = new Point(258, 134);
            this.lblTheory.Name = "lblTheory";
            this.lblTheory.Size = new Size(29, 16);
            this.lblTheory.TabIndex = 11;
            this.lblTheory.Text = "100";
            this.label9.AutoSize = true;
            this.label9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label9.Location = new Point(297, 134);
            this.label9.Name = "label9";
            this.label9.Size = new Size(46, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Times";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.label4.Location = new Point(321, 203);
            this.label4.Name = "label4";
            this.label4.Size = new Size(95, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Acceptable?";
            this.pictureBox6.Image = (Image)Resources.die6;
            this.pictureBox6.Location = new Point(23, 446);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new Size(40, 36);
            this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox5.Image = (Image)Resources.die5;
            this.pictureBox5.Location = new Point(23, 404);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new Size(40, 36);
            this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox4.Image = (Image)Resources.die4;
            this.pictureBox4.Location = new Point(23, 362);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new Size(40, 36);
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox3.Image = (Image)Resources.die3;
            this.pictureBox3.Location = new Point(23, 318);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new Size(40, 36);
            this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox2.Image = (Image)Resources.die2;
            this.pictureBox2.Location = new Point(23, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new Size(40, 36);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox1.Image = (Image)Resources.die1;
            this.pictureBox1.Location = new Point(23, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(40, 36);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.picAcceptable1.Location = new Point(335, 234);
            this.picAcceptable1.Name = "picAcceptable1";
            this.picAcceptable1.Size = new Size(40, 36);
            this.picAcceptable1.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAcceptable1.TabIndex = 19;
            this.picAcceptable1.TabStop = false;
            this.picAcceptable2.Location = new Point(335, 276);
            this.picAcceptable2.Name = "picAcceptable2";
            this.picAcceptable2.Size = new Size(40, 36);
            this.picAcceptable2.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAcceptable2.TabIndex = 20;
            this.picAcceptable2.TabStop = false;
            this.picAcceptable3.Location = new Point(335, 318);
            this.picAcceptable3.Name = "picAcceptable3";
            this.picAcceptable3.Size = new Size(40, 36);
            this.picAcceptable3.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAcceptable3.TabIndex = 21;
            this.picAcceptable3.TabStop = false;
            this.picAcceptable4.Location = new Point(335, 362);
            this.picAcceptable4.Name = "picAcceptable4";
            this.picAcceptable4.Size = new Size(40, 36);
            this.picAcceptable4.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAcceptable4.TabIndex = 22;
            this.picAcceptable4.TabStop = false;
            this.picAcceptable5.Location = new Point(335, 400);
            this.picAcceptable5.Name = "picAcceptable5";
            this.picAcceptable5.Size = new Size(40, 36);
            this.picAcceptable5.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAcceptable5.TabIndex = 23;
            this.picAcceptable5.TabStop = false;
            this.picAcceptable6.Location = new Point(335, 442);
            this.picAcceptable6.Name = "picAcceptable6";
            this.picAcceptable6.Size = new Size(40, 36);
            this.picAcceptable6.SizeMode = PictureBoxSizeMode.Zoom;
            this.picAcceptable6.TabIndex = 24;
            this.picAcceptable6.TabStop = false;
            this.lblActual1.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblActual1.Location = new Point(83, 238);
            this.lblActual1.Name = "lblActual1";
            this.lblActual1.Size = new Size(48, 32);
            this.lblActual1.TabIndex = 25;
            this.lblActual2.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblActual2.Location = new Point(83, 280);
            this.lblActual2.Name = "lblActual2";
            this.lblActual2.Size = new Size(48, 32);
            this.lblActual2.TabIndex = 26;
            this.lblActual3.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblActual3.Location = new Point(83, 322);
            this.lblActual3.Name = "lblActual3";
            this.lblActual3.Size = new Size(48, 32);
            this.lblActual3.TabIndex = 27;
            this.lblActual4.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblActual4.Location = new Point(83, 366);
            this.lblActual4.Name = "lblActual4";
            this.lblActual4.Size = new Size(48, 32);
            this.lblActual4.TabIndex = 28;
            this.lblActual5.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblActual5.Location = new Point(83, 404);
            this.lblActual5.Name = "lblActual5";
            this.lblActual5.Size = new Size(48, 32);
            this.lblActual5.TabIndex = 29;
            this.lblActual6.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblActual6.Location = new Point(83, 450);
            this.lblActual6.Name = "lblActual6";
            this.lblActual6.Size = new Size(48, 32);
            this.lblActual6.TabIndex = 30;
            this.lblDifference1.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblDifference1.Location = new Point(155, 238);
            this.lblDifference1.Name = "lblDifference1";
            this.lblDifference1.Size = new Size(48, 32);
            this.lblDifference1.TabIndex = 31;
            this.lblDifference2.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblDifference2.Location = new Point(155, 280);
            this.lblDifference2.Name = "lblDifference2";
            this.lblDifference2.Size = new Size(48, 32);
            this.lblDifference2.TabIndex = 32;
            this.lblDifference3.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblDifference3.Location = new Point(155, 322);
            this.lblDifference3.Name = "lblDifference3";
            this.lblDifference3.Size = new Size(48, 32);
            this.lblDifference3.TabIndex = 33;
            this.lblDifference4.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblDifference4.Location = new Point(155, 370);
            this.lblDifference4.Name = "lblDifference4";
            this.lblDifference4.Size = new Size(48, 32);
            this.lblDifference4.TabIndex = 34;
            this.lblDifference5.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblDifference5.Location = new Point(155, 408);
            this.lblDifference5.Name = "lblDifference5";
            this.lblDifference5.Size = new Size(48, 32);
            this.lblDifference5.TabIndex = 35;
            this.lblDifference6.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblDifference6.Location = new Point(155, 450);
            this.lblDifference6.Name = "lblDifference6";
            this.lblDifference6.Size = new Size(48, 32);
            this.lblDifference6.TabIndex = 36;
            this.lblPctDifference1.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblPctDifference1.Location = new Point(244, 238);
            this.lblPctDifference1.Name = "lblPctDifference1";
            this.lblPctDifference1.Size = new Size(48, 32);
            this.lblPctDifference1.TabIndex = 37;
            this.lblPctDifference2.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblPctDifference2.Location = new Point(244, 280);
            this.lblPctDifference2.Name = "lblPctDifference2";
            this.lblPctDifference2.Size = new Size(48, 32);
            this.lblPctDifference2.TabIndex = 38;
            this.lblPctDifference3.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblPctDifference3.Location = new Point(244, 322);
            this.lblPctDifference3.Name = "lblPctDifference3";
            this.lblPctDifference3.Size = new Size(48, 32);
            this.lblPctDifference3.TabIndex = 39;
            this.lblPctDifference4.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblPctDifference4.Location = new Point(244, 366);
            this.lblPctDifference4.Name = "lblPctDifference4";
            this.lblPctDifference4.Size = new Size(48, 32);
            this.lblPctDifference4.TabIndex = 40;
            this.lblPctDifference5.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblPctDifference5.Location = new Point(244, 404);
            this.lblPctDifference5.Name = "lblPctDifference5";
            this.lblPctDifference5.Size = new Size(48, 32);
            this.lblPctDifference5.TabIndex = 41;
            this.lblPctDifference6.Font = new Font("Courier New", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblPctDifference6.Location = new Point(244, 442);
            this.lblPctDifference6.Name = "lblPctDifference6";
            this.lblPctDifference6.Size = new Size(48, 32);
            this.lblPctDifference6.TabIndex = 42;
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.BackColor = Color.Lime;
            this.lblConclusion.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblConclusion.ForeColor = SystemColors.ActiveCaptionText;
            this.lblConclusion.Location = new Point(59, 501);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new Size(0, 24);
            this.lblConclusion.TabIndex = 43;
            this.label10.AutoSize = true;
            this.label10.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label10.Location = new Point(139, 63);
            this.label10.Name = "label10";
            this.label10.Size = new Size(65, 15);
            this.label10.TabIndex = 44;
            this.label10.Text = "Tolerance:";
            this.hsbRollingTimes.LargeChange = 300;
            this.hsbRollingTimes.Location = new Point(146, 99);
            this.hsbRollingTimes.Maximum = 12299;
            this.hsbRollingTimes.Minimum = 600;
            this.hsbRollingTimes.Name = "hsbRollingTimes";
            this.hsbRollingTimes.Size = new Size(202, 16);
            this.hsbRollingTimes.SmallChange = 60;
            this.hsbRollingTimes.TabIndex = 45;
            this.hsbRollingTimes.Value = 600;
            this.hsbRollingTimes.Scroll += new ScrollEventHandler(this.hsbRollingTimes_Scroll);
            this.lblRollingTimes.AutoSize = true;
            this.lblRollingTimes.BorderStyle = BorderStyle.Fixed3D;
            this.lblRollingTimes.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblRollingTimes.Location = new Point(351, 99);
            this.lblRollingTimes.Name = "lblRollingTimes";
            this.lblRollingTimes.Size = new Size(30, 17);
            this.lblRollingTimes.TabIndex = 46;
            this.lblRollingTimes.Text = "600";
            this.label11.AutoSize = true;
            this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label11.Location = new Point(245, 66);
            this.label11.Name = "label11";
            this.label11.Size = new Size(20, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "%";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(427, 559);
            this.Controls.Add((Control)this.label11);
            this.Controls.Add((Control)this.lblRollingTimes);
            this.Controls.Add((Control)this.hsbRollingTimes);
            this.Controls.Add((Control)this.label10);
            this.Controls.Add((Control)this.lblConclusion);
            this.Controls.Add((Control)this.lblPctDifference6);
            this.Controls.Add((Control)this.lblPctDifference5);
            this.Controls.Add((Control)this.lblPctDifference4);
            this.Controls.Add((Control)this.lblPctDifference3);
            this.Controls.Add((Control)this.lblPctDifference2);
            this.Controls.Add((Control)this.lblPctDifference1);
            this.Controls.Add((Control)this.lblDifference6);
            this.Controls.Add((Control)this.lblDifference5);
            this.Controls.Add((Control)this.lblDifference4);
            this.Controls.Add((Control)this.lblDifference3);
            this.Controls.Add((Control)this.lblDifference2);
            this.Controls.Add((Control)this.lblDifference1);
            this.Controls.Add((Control)this.lblActual6);
            this.Controls.Add((Control)this.lblActual5);
            this.Controls.Add((Control)this.lblActual4);
            this.Controls.Add((Control)this.lblActual3);
            this.Controls.Add((Control)this.lblActual2);
            this.Controls.Add((Control)this.lblActual1);
            this.Controls.Add((Control)this.picAcceptable6);
            this.Controls.Add((Control)this.picAcceptable5);
            this.Controls.Add((Control)this.picAcceptable4);
            this.Controls.Add((Control)this.picAcceptable3);
            this.Controls.Add((Control)this.picAcceptable2);
            this.Controls.Add((Control)this.picAcceptable1);
            this.Controls.Add((Control)this.pictureBox6);
            this.Controls.Add((Control)this.pictureBox5);
            this.Controls.Add((Control)this.pictureBox4);
            this.Controls.Add((Control)this.pictureBox3);
            this.Controls.Add((Control)this.pictureBox2);
            this.Controls.Add((Control)this.label4);
            this.Controls.Add((Control)this.label9);
            this.Controls.Add((Control)this.lblTheory);
            this.Controls.Add((Control)this.label8);
            this.Controls.Add((Control)this.label7);
            this.Controls.Add((Control)this.label6);
            this.Controls.Add((Control)this.label5);
            this.Controls.Add((Control)this.label3);
            this.Controls.Add((Control)this.pictureBox1);
            this.Controls.Add((Control)this.btnRoll);
            this.Controls.Add((Control)this.nudTolearance);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.Name = "DiceForm";
            this.nudTolearance.EndInit();
            ((ISupportInitialize)this.pictureBox6).EndInit();
            ((ISupportInitialize)this.pictureBox5).EndInit();
            ((ISupportInitialize)this.pictureBox4).EndInit();
            ((ISupportInitialize)this.pictureBox3).EndInit();
            ((ISupportInitialize)this.pictureBox2).EndInit();
            ((ISupportInitialize)this.pictureBox1).EndInit();
            ((ISupportInitialize)this.picAcceptable1).EndInit();
            ((ISupportInitialize)this.picAcceptable2).EndInit();
            ((ISupportInitialize)this.picAcceptable3).EndInit();
            ((ISupportInitialize)this.picAcceptable4).EndInit();
            ((ISupportInitialize)this.picAcceptable5).EndInit();
            ((ISupportInitialize)this.picAcceptable6).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
