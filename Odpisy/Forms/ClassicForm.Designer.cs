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
            _listResult = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // _classControl
            // 
            _classControl.Location = new Point(12, 12);
            _classControl.Name = "_classControl";
            _classControl.Size = new Size(445, 128);
            _classControl.TabIndex = 0;
            // 
            // _btnCount
            // 
            _btnCount.Location = new Point(382, 12);
            _btnCount.Name = "_btnCount";
            _btnCount.Size = new Size(114, 29);
            _btnCount.TabIndex = 1;
            _btnCount.Text = "Spočítat";
            _btnCount.UseVisualStyleBackColor = true;
            _btnCount.Click += _btnCount_Click;
            // 
            // _listResult
            // 
            _listResult.FormattingEnabled = true;
            _listResult.ItemHeight = 20;
            _listResult.Location = new Point(382, 113);
            _listResult.Name = "_listResult";
            _listResult.Size = new Size(274, 304);
            _listResult.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 90);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Výsledek";
            // 
            // ClassicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 437);
            Controls.Add(label1);
            Controls.Add(_listResult);
            Controls.Add(_btnCount);
            Controls.Add(_classControl);
            Name = "ClassicForm";
            Text = "ClassicForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ClassControl _classControl;
        private Button _btnCount;
        private ListBox _listResult;
        private Label label1;
    }
}