namespace Odpisy
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
            _btnClassic = new Button();
            _btnFast = new Button();
            SuspendLayout();
            // 
            // _btnClassic
            // 
            _btnClassic.Location = new Point(83, 35);
            _btnClassic.Name = "_btnClassic";
            _btnClassic.Size = new Size(135, 52);
            _btnClassic.TabIndex = 0;
            _btnClassic.Text = "Rovnoměrný odpis";
            _btnClassic.UseVisualStyleBackColor = true;
            _btnClassic.Click += _btnClassic_Click;
            // 
            // _btnFast
            // 
            _btnFast.Location = new Point(235, 35);
            _btnFast.Name = "_btnFast";
            _btnFast.Size = new Size(127, 52);
            _btnFast.TabIndex = 1;
            _btnFast.Text = "Zrychlený odpis";
            _btnFast.UseVisualStyleBackColor = true;
            _btnFast.Click += _btnFast_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 115);
            Controls.Add(_btnFast);
            Controls.Add(_btnClassic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button _btnClassic;
        private Button _btnFast;
    }
}