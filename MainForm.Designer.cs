namespace tables
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAdd = new System.Windows.Forms.Button();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbExistKey = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.bPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(179, 105);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(108, 26);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // tbKey
            // 
            this.tbKey.AccessibleDescription = "key";
            this.tbKey.Location = new System.Drawing.Point(40, 91);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(133, 22);
            this.tbKey.TabIndex = 1;
            this.tbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbKey_TextChanged);
            // 
            // tbValue
            // 
            this.tbValue.AccessibleDescription = "key";
            this.tbValue.Location = new System.Drawing.Point(40, 119);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(133, 22);
            this.tbValue.TabIndex = 2;
            // 
            // tbExistKey
            // 
            this.tbExistKey.AccessibleDescription = "key";
            this.tbExistKey.Location = new System.Drawing.Point(27, 220);
            this.tbExistKey.Name = "tbExistKey";
            this.tbExistKey.Size = new System.Drawing.Size(280, 22);
            this.tbExistKey.TabIndex = 3;
            this.tbExistKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbExistKey_TextChanged);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(313, 12);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResult.Size = new System.Drawing.Size(457, 420);
            this.tbResult.TabIndex = 7;
            // 
            // cbAction
            // 
            this.cbAction.Location = new System.Drawing.Point(27, 248);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(280, 24);
            this.cbAction.TabIndex = 8;
            this.cbAction.Text = "Действие";
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.CbAction_SelectedIndexChanged);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(185, 407);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(108, 26);
            this.bPrint.TabIndex = 9;
            this.bPrint.Text = "Печать";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbExistKey);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.bAdd);
            this.Name = "MainForm";
            this.Text = "Работа с таблицами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbExistKey;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Button bPrint;
    }
}

