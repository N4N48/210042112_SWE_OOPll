using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Conway_s_GameOfLife_with_SOLID;



namespace Conway_s_GameOfLife_UnitTest_SOLID
{


    [TestClass]
    public class UnitTest1
    {
       
            [TestMethod]
            public void Grid_Initialization_RandomGridNotEmpty()
            {
                // Arrange
                int rows = 10;
                int cols = 10;
                Grid grid = new Grid(rows, cols);

                // Act
                grid.InitializeRandomGrid();

                // Assert
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Assert.IsTrue(grid.GetCellValue(i, j) == 0 || grid.GetCellValue(i, j) == 1);
                    }
                }
            }

            [TestMethod]
            public void Grid_Initialization_GridCellValuesInRange()
            {
                // Arrange
                int rows = 10;
                int cols = 10;
                Grid grid = new Grid(rows, cols);

                // Act
                grid.InitializeRandomGrid();

                // Assert
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int cellValue = grid.GetCellValue(i, j);
                        Assert.IsTrue(cellValue == 0 || cellValue == 1, $"Cell value at ({i}, {j}) is invalid: {cellValue}");
                    }
                }
            }


            [TestMethod]
            public void Grid_Initialization_GridSizeCorrect()
            {
                // Arrange
                int rows = 8;
                int cols = 6;
                Grid grid = new Grid(rows, cols);

                // Act
                int actualRows = grid.GetRows();
                int actualCols = grid.GetCols();

                // Assert
                Assert.AreEqual(rows, actualRows, "Incorrect number of rows in the grid.");
                Assert.AreEqual(cols, actualCols, "Incorrect number of columns in the grid.");
            }

        }
    }

