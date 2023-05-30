namespace Odpisy.Forms
{
    partial class ClassicForm
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
            _classControl = new Controls.ClassControl();
            _btnCount = new Button();
            _odpisy = new GroupBox();
            SuspendLayout();
            // 
            // _classControl
            // 
            _classControl.ForeColor = SystemColors.Control;
            _classControl.Location = new Point(12, 12);
            _classControl.Name = "_classControl";
            _classControl.Size = new Size(445, 128);
            _classControl.TabIndex = 0;
            // 
            // _btnCount
            // 
            _btnCount.Location = new Point(172, 77);
            _btnCount.Name = "_btnCount";
            _btnCount.Size = new Size(114, 29);
            _btnCount.TabIndex = 1;
            _btnCount.Text = "Spočítat";
            _btnCount.UseVisualStyleBackColor = true;
            _btnCount.Click += _btnCount_Click;
            // 
            // _odpisy
            // 
            _odpisy.ForeColor = SystemColors.Control;
            _odpisy.Location = new Point(385, 26);
            _odpisy.Name = "_odpisy";
            _odpisy.Size = new Size(842, 630);
            _odpisy.TabIndex = 2;
            _odpisy.TabStop = false;
            _odpisy.Text = "Odpisy";
            // 
            // ClassicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1297, 709);
            Controls.Add(_odpisy);
            Controls.Add(_btnCount);
            Controls.Add(_classControl);
            Name = "ClassicForm";
            Text = "ClassicForm";
            ResumeLayout(false);
        }

        #endregion

        private Controls.ClassControl _classControl;
        private Button _btnCount;
        private GroupBox _odpisy;
    }
}