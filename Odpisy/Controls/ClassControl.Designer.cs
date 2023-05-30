namespace Odpisy.Controls
{
    partial class ClassControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _listClass = new ListBox();
            _numPrice = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)_numPrice).BeginInit();
            SuspendLayout();
            // 
            // _listClass
            // 
            _listClass.FormattingEnabled = true;
            _listClass.ItemHeight = 20;
            _listClass.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            _listClass.Location = new Point(3, 31);
            _listClass.Name = "_listClass";
            _listClass.Size = new Size(148, 84);
            _listClass.TabIndex = 0;
            // 
            // _numPrice
            // 
            _numPrice.Location = new Point(157, 31);
            _numPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            _numPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            _numPrice.Name = "_numPrice";
            _numPrice.Size = new Size(177, 27);
            _numPrice.TabIndex = 2;
            _numPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 8);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 3;
            label1.Text = "Třída";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 8);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Částka";
            // 
            // ClassControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_numPrice);
            Controls.Add(_listClass);
            Name = "ClassControl";
            Size = new Size(356, 118);
            ((System.ComponentModel.ISupportInitialize)_numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox _listClass;
        private NumericUpDown _numPrice;
        private Label label1;
        private Label label2;
    }
}
