using System;
using System.Windows.Forms;

namespace SUMCreader
{
    partial class Mform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mform));
            this.lbstnumber = new System.Windows.Forms.Label();
            this.edtvalue = new System.Windows.Forms.TextBox();
            this.ValuePicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblValue = new System.Windows.Forms.Label();
            this.lbtBus = new System.Windows.Forms.Label();
            this.lbtTramvai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbWebCode = new System.Windows.Forms.RichTextBox();
            this.edtStationNumber = new System.Windows.Forms.ComboBox();
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumcdbDataSet = new SUMCreader.sumcdbDataSet();
            this.btnSaveStation = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.stationsTableAdapter = new SUMCreader.sumcdbDataSetTableAdapters.StationsTableAdapter();
            this.flpBuses = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ValuePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumcdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbstnumber
            // 
            this.lbstnumber.AutoSize = true;
            this.lbstnumber.Location = new System.Drawing.Point(12, 26);
            this.lbstnumber.Name = "lbstnumber";
            this.lbstnumber.Size = new System.Drawing.Size(95, 13);
            this.lbstnumber.TabIndex = 3;
            this.lbstnumber.Text = "Избери спирката";
            // 
            // edtvalue
            // 
            this.edtvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtvalue.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtvalue.Location = new System.Drawing.Point(225, 41);
            this.edtvalue.Name = "edtvalue";
            this.edtvalue.Size = new System.Drawing.Size(109, 20);
            this.edtvalue.TabIndex = 3;
            // 
            // ValuePicture
            // 
            this.ValuePicture.Location = new System.Drawing.Point(225, 67);
            this.ValuePicture.Name = "ValuePicture";
            this.ValuePicture.Size = new System.Drawing.Size(111, 45);
            this.ValuePicture.TabIndex = 5;
            this.ValuePicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Провери спирка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click1);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(222, 26);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(114, 13);
            this.lblValue.TabIndex = 7;
            this.lblValue.Text = "Въведете символите";
            this.lblValue.Click += new System.EventHandler(this.Label1Click);
            // 
            // lbtBus
            // 
            this.lbtBus.AutoSize = true;
            this.lbtBus.Location = new System.Drawing.Point(15, 131);
            this.lbtBus.Name = "lbtBus";
            this.lbtBus.Size = new System.Drawing.Size(54, 13);
            this.lbtBus.TabIndex = 4;
            this.lbtBus.Text = "Автобуси";
            // 
            // lbtTramvai
            // 
            this.lbtTramvai.AutoSize = true;
            this.lbtTramvai.Location = new System.Drawing.Point(84, 131);
            this.lbtTramvai.Name = "lbtTramvai";
            this.lbtTramvai.Size = new System.Drawing.Size(52, 13);
            this.lbtTramvai.TabIndex = 5;
            this.lbtTramvai.Text = "Трамвай";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тролей";
            // 
            // rtbWebCode
            // 
            this.rtbWebCode.Location = new System.Drawing.Point(225, 128);
            this.rtbWebCode.Name = "rtbWebCode";
            this.rtbWebCode.Size = new System.Drawing.Size(54, 37);
            this.rtbWebCode.TabIndex = 11;
            this.rtbWebCode.Text = "";
            this.rtbWebCode.Visible = false;
            // 
            // edtStationNumber
            // 
            this.edtStationNumber.DataSource = this.stationsBindingSource;
            this.edtStationNumber.DisplayMember = "NAIMENOVANIE";
            this.edtStationNumber.FormattingEnabled = true;
            this.edtStationNumber.Location = new System.Drawing.Point(15, 41);
            this.edtStationNumber.Name = "edtStationNumber";
            this.edtStationNumber.Size = new System.Drawing.Size(184, 21);
            this.edtStationNumber.TabIndex = 0;
            this.edtStationNumber.ValueMember = "STATTION_ID";
            this.edtStationNumber.ValueMemberChanged += new System.EventHandler(this.EdtStationNumberValueMemberChanged);
            this.edtStationNumber.TextChanged += new System.EventHandler(this.EdtStationNumberTextChanged);
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataMember = "Stations";
            this.stationsBindingSource.DataSource = this.sumcdbDataSet;
            this.stationsBindingSource.CurrentChanged += new System.EventHandler(this.stationsBindingSource_CurrentChanged);
            // 
            // sumcdbDataSet
            // 
            this.sumcdbDataSet.DataSetName = "sumcdbDataSet";
            this.sumcdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSaveStation
            // 
            this.btnSaveStation.Location = new System.Drawing.Point(113, 67);
            this.btnSaveStation.Name = "btnSaveStation";
            this.btnSaveStation.Size = new System.Drawing.Size(86, 35);
            this.btnSaveStation.TabIndex = 2;
            this.btnSaveStation.Text = "Запази спирка";
            this.btnSaveStation.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(15, 160);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 7;
            // 
            // stationsTableAdapter
            // 
            this.stationsTableAdapter.ClearBeforeFill = true;
            // 
            // flpBuses
            // 
            this.flpBuses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flpBuses.Location = new System.Drawing.Point(15, 160);
            this.flpBuses.Name = "flpBuses";
            this.flpBuses.Size = new System.Drawing.Size(142, 188);
            this.flpBuses.TabIndex = 13;
            this.flpBuses.Visible = false;
            // 
            // Mform
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(346, 360);
            this.Controls.Add(this.flpBuses);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnSaveStation);
            this.Controls.Add(this.edtStationNumber);
            this.Controls.Add(this.rtbWebCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtTramvai);
            this.Controls.Add(this.lbtBus);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ValuePicture);
            this.Controls.Add(this.edtvalue);
            this.Controls.Add(this.lbstnumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mform";
            this.Text = "SUMC Reader";
            this.Load += new System.EventHandler(this.Form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValuePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumcdbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbstnumber;
        private System.Windows.Forms.TextBox edtvalue;
        private System.Windows.Forms.PictureBox ValuePicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lbtBus;
        private System.Windows.Forms.Label lbtTramvai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbWebCode;
        private System.Windows.Forms.ComboBox edtStationNumber;
        private System.Windows.Forms.Button btnSaveStation;
        private System.Windows.Forms.Label lblText;
        private bool _firstLoad;
        private sumcdbDataSet sumcdbDataSet;
        private BindingSource stationsBindingSource;
        private sumcdbDataSetTableAdapters.StationsTableAdapter stationsTableAdapter;
        private FlowLayoutPanel flpBuses;
    }
}

