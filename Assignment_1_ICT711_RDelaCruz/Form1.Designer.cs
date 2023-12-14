namespace Assignment_1_ICT711
{
    partial class Game_of_life_Form
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
            this.file_operation_group = new System.Windows.Forms.GroupBox();
            this.reset_all_button = new System.Windows.Forms.Button();
            this.save_Grid_button = new System.Windows.Forms.Button();
            this.load_grid_button = new System.Windows.Forms.Button();
            this.single_step_Group = new System.Windows.Forms.GroupBox();
            this.generation_Label = new System.Windows.Forms.Label();
            this.step_textBox = new System.Windows.Forms.TextBox();
            this.next_gen_button = new System.Windows.Forms.Button();
            this.game_control_group = new System.Windows.Forms.GroupBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label_grid_groupBox = new System.Windows.Forms.GroupBox();
            this.file_operation_group.SuspendLayout();
            this.single_step_Group.SuspendLayout();
            this.game_control_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // file_operation_group
            // 
            this.file_operation_group.Controls.Add(this.reset_all_button);
            this.file_operation_group.Controls.Add(this.save_Grid_button);
            this.file_operation_group.Controls.Add(this.load_grid_button);
            this.file_operation_group.Location = new System.Drawing.Point(23, 50);
            this.file_operation_group.Name = "file_operation_group";
            this.file_operation_group.Size = new System.Drawing.Size(295, 191);
            this.file_operation_group.TabIndex = 1;
            this.file_operation_group.TabStop = false;
            this.file_operation_group.Text = "File Operations";
            // 
            // reset_all_button
            // 
            this.reset_all_button.Location = new System.Drawing.Point(19, 134);
            this.reset_all_button.Name = "reset_all_button";
            this.reset_all_button.Size = new System.Drawing.Size(112, 44);
            this.reset_all_button.TabIndex = 3;
            this.reset_all_button.Text = "&Reset All Cells";
            this.reset_all_button.UseVisualStyleBackColor = true;
            this.reset_all_button.Click += new System.EventHandler(this.Reset_All_button_Click);
            // 
            // save_Grid_button
            // 
            this.save_Grid_button.Location = new System.Drawing.Point(19, 84);
            this.save_Grid_button.Name = "save_Grid_button";
            this.save_Grid_button.Size = new System.Drawing.Size(112, 44);
            this.save_Grid_button.TabIndex = 2;
            this.save_Grid_button.Text = "&Save Grid";
            this.save_Grid_button.UseVisualStyleBackColor = true;
            this.save_Grid_button.Click += new System.EventHandler(this.Save_Grid_button_Click);
            // 
            // load_grid_button
            // 
            this.load_grid_button.Location = new System.Drawing.Point(19, 34);
            this.load_grid_button.Name = "load_grid_button";
            this.load_grid_button.Size = new System.Drawing.Size(112, 44);
            this.load_grid_button.TabIndex = 1;
            this.load_grid_button.Tag = "";
            this.load_grid_button.Text = "&Load Grid";
            this.load_grid_button.UseVisualStyleBackColor = true;
            this.load_grid_button.Click += new System.EventHandler(this.Load_Grid_button_Click);
            // 
            // single_step_Group
            // 
            this.single_step_Group.Controls.Add(this.generation_Label);
            this.single_step_Group.Controls.Add(this.step_textBox);
            this.single_step_Group.Controls.Add(this.next_gen_button);
            this.single_step_Group.Location = new System.Drawing.Point(23, 272);
            this.single_step_Group.Name = "single_step_Group";
            this.single_step_Group.Size = new System.Drawing.Size(294, 108);
            this.single_step_Group.TabIndex = 3;
            this.single_step_Group.TabStop = false;
            this.single_step_Group.Text = "Single Step";
            // 
            // generation_Label
            // 
            this.generation_Label.AutoSize = true;
            this.generation_Label.Location = new System.Drawing.Point(178, 52);
            this.generation_Label.Name = "generation_Label";
            this.generation_Label.Size = new System.Drawing.Size(100, 20);
            this.generation_Label.TabIndex = 2;
            this.generation_Label.Text = "Generations";
            // 
            // step_textBox
            // 
            this.step_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.step_textBox.Location = new System.Drawing.Point(136, 49);
            this.step_textBox.Name = "step_textBox";
            this.step_textBox.Size = new System.Drawing.Size(36, 27);
            this.step_textBox.TabIndex = 1;
            // 
            // next_gen_button
            // 
            this.next_gen_button.Location = new System.Drawing.Point(19, 41);
            this.next_gen_button.Name = "next_gen_button";
            this.next_gen_button.Size = new System.Drawing.Size(111, 38);
            this.next_gen_button.TabIndex = 0;
            this.next_gen_button.Text = "&Next";
            this.next_gen_button.UseVisualStyleBackColor = true;
            this.next_gen_button.Click += new System.EventHandler(this.Next_gen_button_Click);
            // 
            // game_control_group
            // 
            this.game_control_group.BackColor = System.Drawing.Color.DarkGray;
            this.game_control_group.Controls.Add(this.exit_button);
            this.game_control_group.Controls.Add(this.file_operation_group);
            this.game_control_group.Controls.Add(this.single_step_Group);
            this.game_control_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_control_group.Location = new System.Drawing.Point(776, 12);
            this.game_control_group.Name = "game_control_group";
            this.game_control_group.Size = new System.Drawing.Size(332, 699);
            this.game_control_group.TabIndex = 4;
            this.game_control_group.TabStop = false;
            this.game_control_group.Text = "Game Controls";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(194, 629);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(124, 42);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "E&xit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // label_grid_groupBox
            // 
            this.label_grid_groupBox.Location = new System.Drawing.Point(0, 12);
            this.label_grid_groupBox.Name = "label_grid_groupBox";
            this.label_grid_groupBox.Size = new System.Drawing.Size(771, 698);
            this.label_grid_groupBox.TabIndex = 5;
            this.label_grid_groupBox.TabStop = false;
            this.label_grid_groupBox.Text = "Grid";
            // 
            // Game_of_life_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 723);
            this.Controls.Add(this.label_grid_groupBox);
            this.Controls.Add(this.game_control_group);
            this.Name = "Game_of_life_Form";
            this.Text = "Game of LIfe";
            this.Load += new System.EventHandler(this.Game_of_life_Form_Load);
            this.file_operation_group.ResumeLayout(false);
            this.single_step_Group.ResumeLayout(false);
            this.single_step_Group.PerformLayout();
            this.game_control_group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox file_operation_group;
        private System.Windows.Forms.Button load_grid_button;
        private System.Windows.Forms.Button reset_all_button;
        private System.Windows.Forms.Button save_Grid_button;
        private System.Windows.Forms.GroupBox single_step_Group;
        private System.Windows.Forms.TextBox step_textBox;
        private System.Windows.Forms.Button next_gen_button;
        private System.Windows.Forms.Label generation_Label;
        private System.Windows.Forms.GroupBox game_control_group;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.GroupBox label_grid_groupBox;
    }
}

