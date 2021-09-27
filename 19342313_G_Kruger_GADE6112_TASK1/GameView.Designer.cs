namespace _19342313_G_Kruger_GADE6112_TASK1
{
    partial class GameView
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
            this.map_label = new System.Windows.Forms.Label();
            this.playerstats_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AttackUp = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // map_label
            // 
            this.map_label.AutoSize = true;
            this.map_label.Location = new System.Drawing.Point(217, 99);
            this.map_label.Name = "map_label";
            this.map_label.Size = new System.Drawing.Size(0, 17);
            this.map_label.TabIndex = 0;
            // 
            // playerstats_label
            // 
            this.playerstats_label.AutoSize = true;
            this.playerstats_label.Location = new System.Drawing.Point(895, 99);
            this.playerstats_label.Name = "playerstats_label";
            this.playerstats_label.Size = new System.Drawing.Size(0, 17);
            this.playerstats_label.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1070, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Use Arrow Keys \r\nfor Movement";
            // 
            // AttackUp
            // 
            this.AttackUp.Location = new System.Drawing.Point(127, 327);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(77, 44);
            this.AttackUp.TabIndex = 3;
            this.AttackUp.Text = "Attack \r\nUp";
            this.AttackUp.UseVisualStyleBackColor = true;
            // 
            // AttackRight
            // 
            this.AttackRight.Location = new System.Drawing.Point(200, 377);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(77, 44);
            this.AttackRight.TabIndex = 4;
            this.AttackRight.Text = "Attack\r\nRight";
            this.AttackRight.UseVisualStyleBackColor = true;
            // 
            // AttackDown
            // 
            this.AttackDown.Location = new System.Drawing.Point(127, 427);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(77, 44);
            this.AttackDown.TabIndex = 5;
            this.AttackDown.Text = "Attack\r\nDown";
            this.AttackDown.UseVisualStyleBackColor = true;
            // 
            // AttackLeft
            // 
            this.AttackLeft.Location = new System.Drawing.Point(53, 377);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(77, 44);
            this.AttackLeft.TabIndex = 6;
            this.AttackLeft.Text = "Attack\r\nLeft";
            this.AttackLeft.UseVisualStyleBackColor = true;
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(1078, 403);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(77, 44);
            this.MoveRight.TabIndex = 10;
            this.MoveRight.Text = "Move\r\nRight";
            this.MoveRight.UseVisualStyleBackColor = true;
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(1004, 453);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(77, 44);
            this.MoveDown.TabIndex = 9;
            this.MoveDown.Text = "Move\r\nDown";
            this.MoveDown.UseVisualStyleBackColor = true;
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(929, 403);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(77, 44);
            this.MoveLeft.TabIndex = 8;
            this.MoveLeft.Text = "Move\r\nLeft";
            this.MoveLeft.UseVisualStyleBackColor = true;
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(1004, 353);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(77, 44);
            this.MoveUp.TabIndex = 7;
            this.MoveUp.Text = "Move\r\nUp";
            this.MoveUp.UseVisualStyleBackColor = true;

            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 520);
            this.Controls.Add(this.MoveRight);
            this.Controls.Add(this.MoveDown);
            this.Controls.Add(this.MoveLeft);
            this.Controls.Add(this.MoveUp);
            this.Controls.Add(this.AttackLeft);
            this.Controls.Add(this.AttackDown);
            this.Controls.Add(this.AttackRight);
            this.Controls.Add(this.AttackUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerstats_label);
            this.Controls.Add(this.map_label);
            this.Name = "GameView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label map_label;
        private System.Windows.Forms.Label playerstats_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackDown;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveUp;
    }
}

