
//
//  Author:  Roselia Dela Cruz
//
//  Purpose:  Assignment 1  ICT 711 - Computer Programming Level 2
//                                
//  Date Created: November 30, 2022
//
//  Description:  A program written to demonstrate John Conway's Game of Life.



using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Assignment_1_ICT711
{
    public partial class Game_of_life_Form : Form
    {
        const int number_of_Rows = 30;
        const int number_of_Cols = 30;
        Status[,] currentGen = new Status[number_of_Rows, number_of_Cols]; //enum type array to hold current generation
        Status[,] nextGen = new Status[number_of_Rows, number_of_Cols];//enum type array to hold next generation
        Label[,] box = new Label[number_of_Rows, number_of_Cols]; //label array that serves as the grid
     

        public Game_of_life_Form()
        {
            InitializeComponent();
        }
        // Game_of_life_Form_Load()
        //
        // This method will load the form and draw a grid of label boxes according to predefined rows and columns.
        //
        private void Game_of_life_Form_Load(object sender, EventArgs e)
        {
          
            for (int i = 0; i < number_of_Rows; i++)
            {
                for (int j = 0; j < number_of_Cols; j++)
                {
                    box[i, j] = new Label();

                    box[i, j].Name = "grid_" + "x" + i.ToString() + "y" + j.ToString();
                    box[i, j].Location = new Point(18, 18 + (i * 18));
                    box[i, j].Size = new Size(18, 18);
                    box[i, j].BackColor = Color.White;
                    box[i, j].BorderStyle = BorderStyle.FixedSingle;
                  
                    box[i, j].Click += AnyBox_Click;
                                       
                    if (j > 0)
                    {
                        box[i, j].Left = box[i, j - 1].Right;
                    }

                    this.label_grid_groupBox.Controls.Add(box[i, j]);
                }
            }
            label_grid_groupBox.Enabled = true;
        }
        // AnyBox_Click()
        //
        // This will enable the user to click on any box to change its color to either white or magenta.
        //
        private void AnyBox_Click(object sender, EventArgs e)
        {
            Label b = sender as Label;
            if (b.BackColor == Color.White)
            {
                b.BackColor = Color.Magenta;
            }
            else
            {
                b.BackColor = Color.White;
            }

        }

        // Status
        //
        // An enumeration type declared to represent thw two status of every cell in the grid array
        //
        public enum Status
        {
            Dead,
            Alive,
        }
        // Load_Grid_button_Click()
        //
        // This will enable the user to load existing .GOL files. 
        //
        private void Load_Grid_button_Click(object sender, EventArgs e)
        {

            string current_path;//holds the path of currently opened file ****
            String[] lines; //holds data values per line from text/.gol file ***
            String[] coordinate_per_line; //holds coordinate from a line after removing delimeters ****

            //reset the grid before loading new one
            Reset_Grid();

            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                current_path = dialog.FileName;
              
                using (StreamReader r = File.OpenText(current_path))
                {
                    string text = r.ReadToEnd();
                    lines = text.Split('\n'); //split the values found per line

                    //for every line, check if empty, split coordinate values per delimiter
                    //before setting up the grid
                   
                    foreach (string line in lines)
                    {
                        if (line.Trim() == "")
                            continue;
                        else
                        {
                            coordinate_per_line = line.Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                            int x_coordinate = Convert.ToInt32(coordinate_per_line[0]);
                            int y_coordinate = Convert.ToInt32(coordinate_per_line[1]);
                            box[x_coordinate, y_coordinate].BackColor = Color.Magenta;
                            currentGen[x_coordinate, y_coordinate] = Status.Alive;
                        }
                    }
                }
            }
            
            label_grid_groupBox.Enabled = false; //disable grid to avoid user click;

        }
        // Save_Grid_button_Click()
        //
        // This will call the Current_Grid() to determine the last state and will write the coordinates of every alive cell 
        // found to a .GOL file. the user must enter the new file name or overwrite an existing file.
        //
        private void Save_Grid_button_Click(object sender, EventArgs e)
        {
            Current_Grid();

            var user_dialog_answer = MessageBox.Show("Save the grid as .gol file", "Save Grid File", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (user_dialog_answer == DialogResult.Cancel)
            {
                MessageBox.Show("Grid not saved.", "Save Grid File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //if ok, save to new file
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "GOL File|*.gol";
                saveFileDialog1.Title = "Save as GOL File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
                   
                    for (int row = 0; row < number_of_Rows; row++)
                    {
                        for (int col = 0; col < number_of_Cols; col++)
                        {
                            if (currentGen[row, col] == Status.Alive) 
                            {
                                SaveFile.WriteLine(row + " " + col);//must write by pair
                            }
                        }
                    }
                    SaveFile.Close();
                    MessageBox.Show("Grid saved!", "Save Grid File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Next_gen_button_Click()
        //
        // This will call the Current_Grid(), NextGeneration(), and Print_Grid() methods
        // to determine the current status and will calculate/print the next generation based
        // on the number of steps from user input
        //
        private void Next_gen_button_Click(object sender, EventArgs e)
        {
            Current_Grid();
            try
            {
                int num_of_steps = Convert.ToInt32(step_textBox.Text);

                //call nextGen here based on number of steps
                for (int step_counter = 1; step_counter <= num_of_steps; step_counter++)
                {
                    nextGen = NextGeneration(currentGen);
                    currentGen = nextGen;
                    // print the new gen
                    Print_Grid(currentGen);
                }
            }
            catch
            {
                MessageBox.Show("Please enter an integer only.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NextGeneration() - Determine the next generation
        //
        // This will loop through the grid and find the alive neighbors 
        //
        private static Status[,] NextGeneration(Status[,] currentGrid)
        {
            var nextGeneration = new Status[number_of_Rows, number_of_Cols];

            // Loop through every cell 
            for (var row = 1; row < number_of_Rows - 1; row++)
                for (var column = 1; column < number_of_Cols - 1; column++)
                {
                    // find the alive neighbors
                    var aliveNeighbors = 0;
                    for (var i = -1; i <= 1; i++)
                    {
                        for (var j = -1; j <= 1; j++)
                        {
                            aliveNeighbors += currentGrid[row + i, column + j] == Status.Alive ? 1 : 0;
                        }
                    }
                    var currentCell = currentGrid[row, column];

                    // The cell needs to be subtracted from its neighbors as it was  
                    // counted before 
                    aliveNeighbors -= currentCell == Status.Alive ? 1 : 0;

                    // Implementing the Rules of Life 

                    // Cell is lonely and dies 
                    if (currentCell == Status.Alive && aliveNeighbors < 2)
                    {
                        nextGeneration[row, column] = Status.Dead;
                    }

                    // Cell dies due to over population 
                    else if (currentCell == Status.Alive && aliveNeighbors > 3)
                    {
                        nextGeneration[row, column] = Status.Dead;
                    }

                    // A new cell is born 
                    else if (currentCell == Status.Dead && aliveNeighbors == 3)
                    {
                        nextGeneration[row, column] = Status.Alive;
                    }
                    // stays the same
                    else
                    {
                        nextGeneration[row, column] = currentCell;
                    }
                }
            return nextGeneration;
        }

        // Current_Grid() - Get the currrent status of the grid
        //
        // This will loop through the grid and determine which cell is alive or dead
        //
        public void Current_Grid()
        {
            for (int i = 0; i < number_of_Rows; i++)
            {
                for (int j = 0; j < number_of_Cols; j++)
                {
                    if (box[i, j].BackColor == Color.White)
                        currentGen[i, j] = Status.Dead;
                    else
                        currentGen[i, j] = Status.Alive;
                }
            }
        }

        // Print_Grid() - Print the grid
        //
        // This will loop through the grid and set the color of every alive cell to Magenta, otherwise, to White
        //
        public void Print_Grid(Status[,] new_grid)
        {
            for (int i = 0; i < number_of_Rows; i++)
            {
                for (int j = 0; j < number_of_Cols; j++)
                {
                    if (new_grid[i, j] == Status.Dead)
                        box[i, j].BackColor = Color.White;
                    else
                        box[i, j].BackColor = Color.Magenta;
                }
            }
        }
        // Reset_All_button_Click() - Call the Reset_Grid() method when this button is clicked.
        //
        // This will loop through the grid and reset every cell to dead status
        //
        private void Reset_All_button_Click(object sender, EventArgs e)
        {
            Reset_Grid();
            label_grid_groupBox.Enabled = true;

        }

        // Reset_Grid() - Reset the grid, a helper method that will be triggered if reset button is clicked
        // or when new grid is loaded.
        //
        // This will loop through the grid and reset every cell to dead status
        //
        private void Reset_Grid()
        {
            for (int row = 0; row < number_of_Rows; row++)
            {
                for (int col = 0; col < number_of_Cols; col++)
                {
                    box[row, col].BackColor = Color.White;

                }
            }
        }

        // Exit_button_Click() - Terminate Application
        //
        // This calls Application.Exit() to terminate the program
        //
        private void Exit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


    }


}
