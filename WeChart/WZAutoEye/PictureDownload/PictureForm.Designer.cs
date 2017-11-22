namespace PictureDownload
{
    partial class PictureForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.start_Time = new System.Windows.Forms.DateTimePicker();
            this.end_Time = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_rs = new System.Windows.Forms.ComboBox();
            this.ProcessTypeCD = new System.Windows.Forms.Label();
            this.cmb_ptCD = new System.Windows.Forms.ComboBox();
            this.Suggestion = new System.Windows.Forms.Label();
            this.cmb_Sugg = new System.Windows.Forms.ComboBox();
            this.Number = new System.Windows.Forms.Label();
            this.cmb_Num = new System.Windows.Forms.ComboBox();
            this.cum_Sugg2 = new System.Windows.Forms.TextBox();
            this.Suggestion2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_HosName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumThreads = new System.Windows.Forms.NumericUpDown();
            this.radio_InDR = new System.Windows.Forms.RadioButton();
            this.radio_NotDR = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cum_UserName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cum_age = new System.Windows.Forms.TextBox();
            this.cmb_DowUrl = new System.Windows.Forms.ComboBox();
            this.Dow_time = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radio_IsDiscard = new System.Windows.Forms.RadioButton();
            this.radio_NotDiscard = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.text_Remark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumThreads)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间段：";
            // 
            // start_Time
            // 
            this.start_Time.Location = new System.Drawing.Point(75, 20);
            this.start_Time.Name = "start_Time";
            this.start_Time.Size = new System.Drawing.Size(122, 21);
            this.start_Time.TabIndex = 1;
            // 
            // end_Time
            // 
            this.end_Time.Location = new System.Drawing.Point(221, 20);
            this.end_Time.Name = "end_Time";
            this.end_Time.Size = new System.Drawing.Size(129, 21);
            this.end_Time.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "~";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(356, 24);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(77, 12);
            this.lable3.TabIndex = 4;
            this.lable3.Text = "保存路径为：";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(433, 21);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(315, 21);
            this.txtPath.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "相关信息：";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(237, 439);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(104, 42);
            this.start.TabIndex = 9;
            this.start.Text = "开始整合";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 243);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(721, 190);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "建议：";
            // 
            // cmb_rs
            // 
            this.cmb_rs.DisplayMember = "123";
            this.cmb_rs.FormattingEnabled = true;
            this.cmb_rs.Items.AddRange(new object[] {
            "无",
            "定期随访，一年复查眼底像。",
            "转眼科进一步检查，确诊。",
            "双眼屈光介质混浊，眼底看不清，建议眼科会诊明确诊断。",
            "定期随访，三个月复查眼底像。",
            "定期随访，六个月复查眼底像。",
            "其它"});
            this.cmb_rs.Location = new System.Drawing.Point(433, 49);
            this.cmb_rs.Name = "cmb_rs";
            this.cmb_rs.Size = new System.Drawing.Size(315, 20);
            this.cmb_rs.TabIndex = 12;
            // 
            // ProcessTypeCD
            // 
            this.ProcessTypeCD.AutoSize = true;
            this.ProcessTypeCD.Location = new System.Drawing.Point(25, 161);
            this.ProcessTypeCD.Name = "ProcessTypeCD";
            this.ProcessTypeCD.Size = new System.Drawing.Size(65, 12);
            this.ProcessTypeCD.TabIndex = 13;
            this.ProcessTypeCD.Text = "片源类型：";
            // 
            // cmb_ptCD
            // 
            this.cmb_ptCD.FormattingEnabled = true;
            this.cmb_ptCD.Items.AddRange(new object[] {
            "全部流程",
            "人工流程",
            "自动流程"});
            this.cmb_ptCD.Location = new System.Drawing.Point(87, 158);
            this.cmb_ptCD.Name = "cmb_ptCD";
            this.cmb_ptCD.Size = new System.Drawing.Size(104, 20);
            this.cmb_ptCD.TabIndex = 14;
            // 
            // Suggestion
            // 
            this.Suggestion.AutoSize = true;
            this.Suggestion.Location = new System.Drawing.Point(28, 52);
            this.Suggestion.Name = "Suggestion";
            this.Suggestion.Size = new System.Drawing.Size(41, 12);
            this.Suggestion.TabIndex = 15;
            this.Suggestion.Text = "印象：";
            // 
            // cmb_Sugg
            // 
            this.cmb_Sugg.FormattingEnabled = true;
            this.cmb_Sugg.Items.AddRange(new object[] {
            "无",
            "可见出血或渗出，定期随访复查眼底像。",
            "可见明显出血或渗出，建议眼科检查，确诊。",
            "未见明显异常，定期随访复查眼底像。",
            "未见明显出血或渗出，定期随访复查眼底像。"});
            this.cmb_Sugg.Location = new System.Drawing.Point(75, 47);
            this.cmb_Sugg.Name = "cmb_Sugg";
            this.cmb_Sugg.Size = new System.Drawing.Size(275, 20);
            this.cmb_Sugg.TabIndex = 16;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Location = new System.Drawing.Point(638, 90);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(41, 12);
            this.Number.TabIndex = 17;
            this.Number.Text = "条数：";
            // 
            // cmb_Num
            // 
            this.cmb_Num.FormattingEnabled = true;
            this.cmb_Num.Items.AddRange(new object[] {
            "全部",
            "5",
            "10",
            "30",
            "50",
            "100",
            "130",
            "150",
            "200"});
            this.cmb_Num.Location = new System.Drawing.Point(678, 86);
            this.cmb_Num.Name = "cmb_Num";
            this.cmb_Num.Size = new System.Drawing.Size(70, 20);
            this.cmb_Num.TabIndex = 18;
            // 
            // cum_Sugg2
            // 
            this.cum_Sugg2.Location = new System.Drawing.Point(75, 85);
            this.cum_Sugg2.Name = "cum_Sugg2";
            this.cum_Sugg2.Size = new System.Drawing.Size(275, 21);
            this.cum_Sugg2.TabIndex = 19;
            // 
            // Suggestion2
            // 
            this.Suggestion2.AutoSize = true;
            this.Suggestion2.Location = new System.Drawing.Point(25, 89);
            this.Suggestion2.Name = "Suggestion2";
            this.Suggestion2.Size = new System.Drawing.Size(47, 12);
            this.Suggestion2.TabIndex = 20;
            this.Suggestion2.Text = "印象2：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "（模糊查询）";
            // 
            // cmb_HosName
            // 
            this.cmb_HosName.Location = new System.Drawing.Point(237, 159);
            this.cmb_HosName.Name = "cmb_HosName";
            this.cmb_HosName.Size = new System.Drawing.Size(113, 21);
            this.cmb_HosName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "医院：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "标注图：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "下载图片规则：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(442, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 31;
            this.label9.Text = "当前使用线程数：";
            // 
            // NumThreads
            // 
            this.NumThreads.Location = new System.Drawing.Point(549, 84);
            this.NumThreads.Name = "NumThreads";
            this.NumThreads.Size = new System.Drawing.Size(67, 21);
            this.NumThreads.TabIndex = 32;
            this.NumThreads.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // radio_InDR
            // 
            this.radio_InDR.AutoSize = true;
            this.radio_InDR.Location = new System.Drawing.Point(81, 122);
            this.radio_InDR.Name = "radio_InDR";
            this.radio_InDR.Size = new System.Drawing.Size(35, 16);
            this.radio_InDR.TabIndex = 33;
            this.radio_InDR.Text = "是";
            this.radio_InDR.UseVisualStyleBackColor = true;
            // 
            // radio_NotDR
            // 
            this.radio_NotDR.AutoSize = true;
            this.radio_NotDR.Checked = true;
            this.radio_NotDR.Location = new System.Drawing.Point(118, 122);
            this.radio_NotDR.Name = "radio_NotDR";
            this.radio_NotDR.Size = new System.Drawing.Size(35, 16);
            this.radio_NotDR.TabIndex = 34;
            this.radio_NotDR.TabStop = true;
            this.radio_NotDR.Text = "否";
            this.radio_NotDR.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 35;
            this.label10.Text = "姓名：";
            // 
            // cum_UserName
            // 
            this.cum_UserName.Location = new System.Drawing.Point(469, 160);
            this.cum_UserName.Name = "cum_UserName";
            this.cum_UserName.Size = new System.Drawing.Size(100, 21);
            this.cum_UserName.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(607, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "年龄：";
            // 
            // cum_age
            // 
            this.cum_age.Location = new System.Drawing.Point(648, 122);
            this.cum_age.Name = "cum_age";
            this.cum_age.Size = new System.Drawing.Size(100, 21);
            this.cum_age.TabIndex = 38;
            // 
            // cmb_DowUrl
            // 
            this.cmb_DowUrl.FormattingEnabled = true;
            this.cmb_DowUrl.Items.AddRange(new object[] {
            "EyePic",
            "EyePic/医院CD/时间/姓名",
            "EyePic/医院CD_姓名"});
            this.cmb_DowUrl.Location = new System.Drawing.Point(420, 123);
            this.cmb_DowUrl.Name = "cmb_DowUrl";
            this.cmb_DowUrl.Size = new System.Drawing.Size(174, 20);
            this.cmb_DowUrl.Sorted = true;
            this.cmb_DowUrl.TabIndex = 39;
            // 
            // Dow_time
            // 
            this.Dow_time.AutoSize = true;
            this.Dow_time.Location = new System.Drawing.Point(54, 472);
            this.Dow_time.Name = "Dow_time";
            this.Dow_time.Size = new System.Drawing.Size(17, 12);
            this.Dow_time.TabIndex = 40;
            this.Dow_time.Text = "  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(358, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 41;
            this.label12.Text = "(逗号分割)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(159, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 42;
            this.label13.Text = "仅下载舍弃图";
            // 
            // radio_IsDiscard
            // 
            this.radio_IsDiscard.AutoSize = true;
            this.radio_IsDiscard.Location = new System.Drawing.Point(9, 10);
            this.radio_IsDiscard.Name = "radio_IsDiscard";
            this.radio_IsDiscard.Size = new System.Drawing.Size(35, 16);
            this.radio_IsDiscard.TabIndex = 43;
            this.radio_IsDiscard.Text = "是";
            this.radio_IsDiscard.UseVisualStyleBackColor = true;
            // 
            // radio_NotDiscard
            // 
            this.radio_NotDiscard.AutoSize = true;
            this.radio_NotDiscard.Checked = true;
            this.radio_NotDiscard.Location = new System.Drawing.Point(48, 10);
            this.radio_NotDiscard.Name = "radio_NotDiscard";
            this.radio_NotDiscard.Size = new System.Drawing.Size(35, 16);
            this.radio_NotDiscard.TabIndex = 44;
            this.radio_NotDiscard.TabStop = true;
            this.radio_NotDiscard.Text = "否";
            this.radio_NotDiscard.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_NotDiscard);
            this.panel1.Controls.Add(this.radio_IsDiscard);
            this.panel1.Location = new System.Drawing.Point(237, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 36);
            this.panel1.TabIndex = 45;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 42);
            this.button2.TabIndex = 46;
            this.button2.Text = "结束整合";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_Remark
            // 
            this.text_Remark.Location = new System.Drawing.Point(87, 192);
            this.text_Remark.Name = "text_Remark";
            this.text_Remark.Size = new System.Drawing.Size(139, 21);
            this.text_Remark.TabIndex = 47;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 48;
            this.label14.Text = "备注：";
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 493);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.text_Remark);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Dow_time);
            this.Controls.Add(this.cmb_DowUrl);
            this.Controls.Add(this.cum_age);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cum_UserName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radio_NotDR);
            this.Controls.Add(this.radio_InDR);
            this.Controls.Add(this.NumThreads);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_HosName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Suggestion2);
            this.Controls.Add(this.cum_Sugg2);
            this.Controls.Add(this.cmb_Num);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.cmb_Sugg);
            this.Controls.Add(this.Suggestion);
            this.Controls.Add(this.cmb_ptCD);
            this.Controls.Add(this.ProcessTypeCD);
            this.Controls.Add(this.cmb_rs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_Time);
            this.Controls.Add(this.start_Time);
            this.Controls.Add(this.label1);
            this.Name = "PictureForm";
            this.Text = "眼底图像下载";
            this.Load += new System.EventHandler(this.PictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumThreads)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker start_Time;
        private System.Windows.Forms.DateTimePicker end_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_rs;
        private System.Windows.Forms.Label ProcessTypeCD;
        private System.Windows.Forms.ComboBox cmb_ptCD;
        private System.Windows.Forms.Label Suggestion;
        private System.Windows.Forms.ComboBox cmb_Sugg;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.ComboBox cmb_Num;
        private System.Windows.Forms.TextBox cum_Sugg2;
        private System.Windows.Forms.Label Suggestion2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cmb_HosName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NumThreads;
        private System.Windows.Forms.RadioButton radio_InDR;
        private System.Windows.Forms.RadioButton radio_NotDR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cum_UserName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cum_age;
        private System.Windows.Forms.ComboBox cmb_DowUrl;
        private System.Windows.Forms.Label Dow_time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radio_IsDiscard;
        private System.Windows.Forms.RadioButton radio_NotDiscard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_Remark;
        private System.Windows.Forms.Label label14;
    }
}

