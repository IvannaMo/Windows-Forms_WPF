using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace _2048_Game
{
    public partial class MainWindow : Window
    {
        private int _sum;


        private List<Cell> _cellList { get; set; }
        private List<Cell> _freeCell { get; set; }


        private int _highScore;


        public MainWindow()
        {
            InitializeComponent();


            _sum = 0;

            _cellList = new List<Cell>();
            _freeCell = new List<Cell>();

            _highScore = 0;


            StartGame();
        }


        void DrawCells()
        {
            gameGrid.Children.Clear();
            SpawnCell();

            for (int i = 0; i < _cellList.Count; i++)
            {
                if (_cellList[i].Value == 0)
                {
                    continue;
                }
                AddLabel((int)_cellList[i].Location.X, (int)_cellList[i].Location.Y, _cellList[i].Value);
            }

            score.Text = _sum.ToString();
            if (_sum > Convert.ToInt32(highScore.Text))
            {
                highScore.Text = _sum.ToString();
            }
        }


        private void StartGame()
        {
            score.Text = "0";
            highScore.Text = _highScore.ToString();

            _cellList.Clear();
            _freeCell.Clear();
            gameGrid.Children.Clear();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    _cellList.Add(new Cell(new Point(j, i)));
                    _freeCell.Add(_cellList.ElementAt(i * 4 + j));
                }
            }

            if (_freeCell.Count != 0)
            {
                DrawCells();
            }
        }


        private int CalculateSum()
        {
            int sum = 0;
            foreach (var cell in _cellList)
            {
                sum += cell.Value;
            }

            return sum;
        }


        void SpawnCell()
        {
            _freeCell.Clear();
            for (int i = 0; i < _cellList.Count; i++)
            {
                if (_cellList[i].Value < 2)
                {
                    _freeCell.Add(_cellList[i]);
                }
            }


            Random random = new Random();

            const int smallerNumber = 2;
            const int largerNumber = 4;
            const int largerNumberChance = 10;

            int numToSpawn = random.Next(0, 100) <= largerNumberChance ? largerNumber : smallerNumber;
            int spawnCellNum = random.Next(_freeCell.Count);
            _sum = CalculateSum();

            for (int i = 0; i < _cellList.Count; i++)
            {
                if ((_cellList[i].Location.X == _freeCell[spawnCellNum].Location.X) && (_cellList[i].Location.Y == _freeCell[spawnCellNum].Location.Y))
                {
                    _cellList[i].Value = numToSpawn;
                    break;
                }
            }
        }
        

        private void AddLabel(int x, int y, int labelValue)
        {
            Label label = new Label();
            label.Content = labelValue.ToString();

            Grid.SetColumn(label, x);
            Grid.SetRow(label, y);
            gameGrid.Children.Add(label);
        }


        private void MoveLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int target = 0; target < 3; target++)
                {
                    for (int j = target + 1; j < 4; j++)
                    {
                        if ((_cellList[i * 4 + target].Value == 0) || (_cellList[i * 4 + target].Value == _cellList[i * 4 + j].Value))
                        {
                            _cellList[i * 4 + target].Value += _cellList[i * 4 + j].Value;
                            _cellList[i * 4 + j].Value = 0;

                            if (_cellList[i * 4 + target].Value != 0)
                            { 
                                break; 
                            }
                        }
                    }
                }

            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int target = 3; target > 0; target--)
                {
                    for (int j = target - 1; j >= 0; j--)
                    {
                        if ((_cellList[i * 4 + target].Value == 0) || (_cellList[i * 4 + target].Value == _cellList[i * 4 + j].Value))
                        {
                            _cellList[i * 4 + target].Value += _cellList[i * 4 + j].Value;
                            _cellList[i * 4 + j].Value = 0;

                            if (_cellList[i * 4 + target].Value != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int target = 0; target < 4; target++)
                {
                    for (int j = target + 1; j < 4; j++)
                    {
                        if ((_cellList[target * 4 + i].Value == 0) || (_cellList[target * 4 + i].Value == _cellList[j * 4 + i].Value))
                        {
                            _cellList[target * 4 + i].Value += _cellList[j * 4 + i].Value;
                            _cellList[j * 4 + i].Value = 0;

                            if (_cellList[target * 4 + i].Value != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveDown()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int target = 3; target > 0; target--)
                {
                    for (int j = target - 1; j >= 0; j--)
                    {
                        if ((_cellList[target * 4 + i].Value == 0) || (_cellList[target * 4 + i].Value == _cellList[j * 4 + i].Value))
                        {
                            _cellList[target * 4 + i].Value += _cellList[j * 4 + i].Value;
                            _cellList[j * 4 + i].Value = 0;

                            if (_cellList[target * 4 + i].Value != 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }


        private void WindowKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key != Key.Left) && (e.Key != Key.Right) && (e.Key != Key.Up) && (e.Key != Key.Down))
            {
                return;
            }


            if (e.Key == Key.Left)
            {
                MoveLeft();
                DrawCells();
            }
            else if (e.Key == Key.Right)
            {
                MoveRight();
                DrawCells();
            }
            else if (e.Key == Key.Up)
            {
                MoveUp();
                DrawCells();
            }
            else if (e.Key == Key.Down)
            {
                MoveDown();
                DrawCells();
            }
        }


        private void RestartButtonClick(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(highScore.Text) > _highScore)
            {
                _highScore = Convert.ToInt32(highScore.Text);
            }

            StartGame();
        }
    }
}
