using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Corners
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private States CurrentState = States.WhiteSelect;
        private List<CheckerBoard> ChB;
        private int IntStartIndex = -1;
        private int IntEndIndex = -1;
        private int CountColumn1 = 0;
        private int CountColumn2 = 0;
        private int CountColumn3 = 0;
        private int CountRow1 = 0;
        private int CountRow2 = 0;
        private int CountRow3 = 0;
        private Ellipse WhiteEllipse;
        private Ellipse BlackEllipse;
        private Ellipse WhiteSelectedEllipse;
        private Ellipse BlackSelectedEllipse;
        private bool BFistSteped { get; set; } = false;
        private bool BOneSteped { get; set; } = false;

        public MainWindow()
        {
            InitializeComponent();

            ChB = new List<CheckerBoard>()
            {
                new CheckerBoard(sp_A1, CheckerColor.White),
                new CheckerBoard(sp_B1, CheckerColor.White),
                new CheckerBoard(sp_C1, CheckerColor.White),
                new CheckerBoard(sp_D1, CheckerColor.Unknown),
                new CheckerBoard(sp_E1, CheckerColor.Unknown),
                new CheckerBoard(sp_F1, CheckerColor.Unknown),
                new CheckerBoard(sp_G1, CheckerColor.Unknown),
                new CheckerBoard(sp_H1, CheckerColor.Unknown),

                new CheckerBoard(sp_A2, CheckerColor.White),
                new CheckerBoard(sp_B2, CheckerColor.White),
                new CheckerBoard(sp_C2, CheckerColor.White),
                new CheckerBoard(sp_D2, CheckerColor.Unknown),
                new CheckerBoard(sp_E2, CheckerColor.Unknown),
                new CheckerBoard(sp_F2, CheckerColor.Unknown),
                new CheckerBoard(sp_G2, CheckerColor.Unknown),
                new CheckerBoard(sp_H2, CheckerColor.Unknown),

                new CheckerBoard(sp_A3, CheckerColor.White),
                new CheckerBoard(sp_B3, CheckerColor.White),
                new CheckerBoard(sp_C3, CheckerColor.White),
                new CheckerBoard(sp_D3, CheckerColor.Unknown),
                new CheckerBoard(sp_E3, CheckerColor.Unknown),
                new CheckerBoard(sp_F3, CheckerColor.Unknown),
                new CheckerBoard(sp_G3, CheckerColor.Unknown),
                new CheckerBoard(sp_H3, CheckerColor.Unknown),

                new CheckerBoard(sp_A4, CheckerColor.Unknown),
                new CheckerBoard(sp_B4, CheckerColor.Unknown),
                new CheckerBoard(sp_C4, CheckerColor.Unknown),
                new CheckerBoard(sp_D4, CheckerColor.Unknown),
                new CheckerBoard(sp_E4, CheckerColor.Unknown),
                new CheckerBoard(sp_F4, CheckerColor.Unknown),
                new CheckerBoard(sp_G4, CheckerColor.Unknown),
                new CheckerBoard(sp_H4, CheckerColor.Unknown),

                new CheckerBoard(sp_A5, CheckerColor.Unknown),
                new CheckerBoard(sp_B5, CheckerColor.Unknown),
                new CheckerBoard(sp_C5, CheckerColor.Unknown),
                new CheckerBoard(sp_D5, CheckerColor.Unknown),
                new CheckerBoard(sp_E5, CheckerColor.Unknown),
                new CheckerBoard(sp_F5, CheckerColor.Unknown),
                new CheckerBoard(sp_G5, CheckerColor.Unknown),
                new CheckerBoard(sp_H5, CheckerColor.Unknown),

                new CheckerBoard(sp_A6, CheckerColor.Unknown),
                new CheckerBoard(sp_B6, CheckerColor.Unknown),
                new CheckerBoard(sp_C6, CheckerColor.Unknown),
                new CheckerBoard(sp_D6, CheckerColor.Unknown),
                new CheckerBoard(sp_E6, CheckerColor.Unknown),
                new CheckerBoard(sp_F6, CheckerColor.Black),
                new CheckerBoard(sp_G6, CheckerColor.Black),
                new CheckerBoard(sp_H6, CheckerColor.Black),

                new CheckerBoard(sp_A7, CheckerColor.Unknown),
                new CheckerBoard(sp_B7, CheckerColor.Unknown),
                new CheckerBoard(sp_C7, CheckerColor.Unknown),
                new CheckerBoard(sp_D7, CheckerColor.Unknown),
                new CheckerBoard(sp_E7, CheckerColor.Unknown),
                new CheckerBoard(sp_F7, CheckerColor.Black),
                new CheckerBoard(sp_G7, CheckerColor.Black),
                new CheckerBoard(sp_H7, CheckerColor.Black),

                new CheckerBoard(sp_A8, CheckerColor.Unknown),
                new CheckerBoard(sp_B8, CheckerColor.Unknown),
                new CheckerBoard(sp_C8, CheckerColor.Unknown),
                new CheckerBoard(sp_D8, CheckerColor.Unknown),
                new CheckerBoard(sp_E8, CheckerColor.Unknown),
                new CheckerBoard(sp_F8, CheckerColor.Black),
                new CheckerBoard(sp_G8, CheckerColor.Black),
                new CheckerBoard(sp_H8, CheckerColor.Black),

                //new CheckerBoard(sp_A1, CheckerColor.Black),
                //new CheckerBoard(sp_B1, CheckerColor.Black),
                //new CheckerBoard(sp_C1, CheckerColor.Black),
                //new CheckerBoard(sp_D1, CheckerColor.Unknown),
                //new CheckerBoard(sp_E1, CheckerColor.Unknown),
                //new CheckerBoard(sp_F1, CheckerColor.Unknown),
                //new CheckerBoard(sp_G1, CheckerColor.Unknown),
                //new CheckerBoard(sp_H1, CheckerColor.Unknown),

                //new CheckerBoard(sp_A2, CheckerColor.Black),
                //new CheckerBoard(sp_B2, CheckerColor.Black),
                //new CheckerBoard(sp_C2, CheckerColor.Black),
                //new CheckerBoard(sp_D2, CheckerColor.Unknown),
                //new CheckerBoard(sp_E2, CheckerColor.Unknown),
                //new CheckerBoard(sp_F2, CheckerColor.Unknown),
                //new CheckerBoard(sp_G2, CheckerColor.Unknown),
                //new CheckerBoard(sp_H2, CheckerColor.Unknown),

                //new CheckerBoard(sp_A3, CheckerColor.Unknown),
                //new CheckerBoard(sp_B3, CheckerColor.Black),
                //new CheckerBoard(sp_C3, CheckerColor.Black),
                //new CheckerBoard(sp_D3, CheckerColor.Unknown),
                //new CheckerBoard(sp_E3, CheckerColor.Unknown),
                //new CheckerBoard(sp_F3, CheckerColor.Unknown),
                //new CheckerBoard(sp_G3, CheckerColor.Unknown),
                //new CheckerBoard(sp_H3, CheckerColor.Unknown),

                //new CheckerBoard(sp_A4, CheckerColor.Black),
                //new CheckerBoard(sp_B4, CheckerColor.Unknown),
                //new CheckerBoard(sp_C4, CheckerColor.Unknown),
                //new CheckerBoard(sp_D4, CheckerColor.Unknown),
                //new CheckerBoard(sp_E4, CheckerColor.Unknown),
                //new CheckerBoard(sp_F4, CheckerColor.Unknown),
                //new CheckerBoard(sp_G4, CheckerColor.Unknown),
                //new CheckerBoard(sp_H4, CheckerColor.Unknown),

                //new CheckerBoard(sp_A5, CheckerColor.Unknown),
                //new CheckerBoard(sp_B5, CheckerColor.Unknown),
                //new CheckerBoard(sp_C5, CheckerColor.Unknown),
                //new CheckerBoard(sp_D5, CheckerColor.Unknown),
                //new CheckerBoard(sp_E5, CheckerColor.Unknown),
                //new CheckerBoard(sp_F5, CheckerColor.Unknown),
                //new CheckerBoard(sp_G5, CheckerColor.Unknown),
                //new CheckerBoard(sp_H5, CheckerColor.Unknown),

                //new CheckerBoard(sp_A6, CheckerColor.Unknown),
                //new CheckerBoard(sp_B6, CheckerColor.Unknown),
                //new CheckerBoard(sp_C6, CheckerColor.Unknown),
                //new CheckerBoard(sp_D6, CheckerColor.Unknown),
                //new CheckerBoard(sp_E6, CheckerColor.Unknown),
                //new CheckerBoard(sp_F6, CheckerColor.White),
                //new CheckerBoard(sp_G6, CheckerColor.White),
                //new CheckerBoard(sp_H6, CheckerColor.White),

                //new CheckerBoard(sp_A7, CheckerColor.Unknown),
                //new CheckerBoard(sp_B7, CheckerColor.Unknown),
                //new CheckerBoard(sp_C7, CheckerColor.White),
                //new CheckerBoard(sp_D7, CheckerColor.Unknown),
                //new CheckerBoard(sp_E7, CheckerColor.Unknown),
                //new CheckerBoard(sp_F7, CheckerColor.Unknown),
                //new CheckerBoard(sp_G7, CheckerColor.White),
                //new CheckerBoard(sp_H7, CheckerColor.White),

                //new CheckerBoard(sp_A8, CheckerColor.Unknown),
                //new CheckerBoard(sp_B8, CheckerColor.Unknown),
                //new CheckerBoard(sp_C8, CheckerColor.Unknown),
                //new CheckerBoard(sp_D8, CheckerColor.Unknown),
                //new CheckerBoard(sp_E8, CheckerColor.Unknown),
                //new CheckerBoard(sp_F8, CheckerColor.White),
                //new CheckerBoard(sp_G8, CheckerColor.White),
                //new CheckerBoard(sp_H8, CheckerColor.White),
};
            WhiteEllipse = (Ellipse)Resources["WhiteEllipseRes"];
            BlackEllipse = (Ellipse)Resources["BlackEllipseRes"];
            WhiteSelectedEllipse = (Ellipse)Resources["WhiteSelectedEllipseRes"];
            BlackSelectedEllipse = (Ellipse)Resources["BlackSelectedEllipseRes"];
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine($"**** Window_Loaded ****");

            for (int n = 0; n < 64; n++)
            {
                StackPanel sp = ChB[n].StPanel;
                CheckerColor col = ChB[n].Col;
                sp.Tag = n;
                switch (col)
                {
                    case CheckerColor.Unknown:
                        break;
                    case CheckerColor.Black:
                        SetCheckerToStackPanel(n, CheckerColor.Black);
                        break;
                    case CheckerColor.White:
                        SetCheckerToStackPanel(n, CheckerColor.White);
                        break;
                }
                Console.WriteLine($"n= {sp.Tag} sp = {sp.Name} Col = {col}");
            }
            
            Console.WriteLine($"********");
            Console.WriteLine();
            new CStepDialog().Show();
        }

        private void Board_Window_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            CStepDialog d = new CStepDialog();
            d.Show();
        }

        private void Sp_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            StackPanel sp = (StackPanel)sender;
            int EndIndex = (int)sp.Tag;
            CheckerColor CheckerColor = ChB[EndIndex].Col;
            int IndexDelta = EndIndex - IntStartIndex;
            Console.WriteLine($"**** Sp_MouseDown **** {sp.Name} State = {CurrentState} IndexDelta={IndexDelta}");
            switch (CurrentState)
            {
                case States.Unknown:
                    IntStartIndex = -1;
                    BFistSteped = false;

                    CurrentState = States.WhiteSelect;
                    break;

                case States.WhiteSelect:
                    if (CheckerColor != CheckerColor.White)
                    {
                        //Нарушена очередность хода.
                        MessageBox.Show("Ход белых.");
                        break;
                    }
                    if (!IsStep(CheckerColor.White, Target.Up))
                    {
                        //Передает ход черным - нет хода белых.
                        //MessageBox.Show("Нет хода - передача хода черным");

                        MessageBox.Show("Нет хода черные выиграли");
                        this.Close();

                        CurrentState = States.BlackSelect;
                        IntStartIndex = -1;    //Черная пешка еще не выбрана.
                        BFistSteped = false;
                        break;
                    }

                    //Выделяет выбранную белую пешку и переходит на ее перемещение.
                    IntStartIndex = EndIndex;
                    CurrentState = States.WhiteMove;
                    RemoveCheckerFromStackPanel(IntStartIndex);
                    SetCheckerToStackPanel(IntStartIndex, CheckerColor.WhiteSelected);
                    break;

                case States.WhiteMove:
                    if (IndexDelta == 0)
                    {
                        //Отмняет выбор
                        CurrentState = States.WhiteSelect;
                        RemoveCheckerFromStackPanel(IntStartIndex);
                        SetCheckerToStackPanel(IntStartIndex, CheckerColor.White);
                        if (BFistSteped == true)
                        {
                           /////////////II/////////////////
                            if (StartStopcs.BContinue == true)
                            {
                                ResetCounter(CheckerColor.Black);
                                if (IsStep(CheckerColor.Black, Target.Down) == false)
                                {
                                    //Передает ход белым - нет хода черных.
                                    //MessageBox.Show("Нет хода - передача хода белым");

                                    MessageBox.Show("Нет хода - белые выиграли");
                                    this.Close();
                                    
                                    //Передает ход белым.
                                    CurrentState = States.WhiteSelect;
                                    IntStartIndex = -1;    //Черная пешка еще не выбрана.
                                    BFistSteped = false;
                                    break;
                                }
                                if ((IntEndIndex >= 0) && (IntEndIndex <= 7))
                                {
                                    BFistSteped = false;
                                }

                                //Передает ход белым.
                                CurrentState = States.WhiteSelect;
                                RemoveCheckerFromStackPanel(IntStartIndex);
                                SetCheckerToStackPanel(IntEndIndex, CheckerColor.Black);
                                IntStartIndex = -1;    //Черная пешка еще не выбрана.
                                BFistSteped = false;
                                ResetCounter(CheckerColor.Black);
                                if (WhoWon(CheckerColor.Black) == true)
                                {
                                    MessageBox.Show("Черные выиграли :(");
                                    this.Close();


                                    //Close();
                                }
                            }
                            else {
                                 //Передает ход черным.
                            CurrentState = States.BlackSelect;
                            IntStartIndex = -1;    //Черная пешка еще не выбрана.
                            BFistSteped = false;
                            }/////////////II//////////////
                            break;
                        }
                        break;
                    }
                    if (TestOneMove(IntStartIndex, EndIndex, Target.Up) == false)
                    {
                        MessageBox.Show("Неверный ход.");
                        break;
                    }
                    if (BFistSteped)
                    {
                        if ((IndexDelta == 1) || (IndexDelta == 8))
                        {
                            MessageBox.Show("Неверный ход.");
                            break;
                        }
                    }
                    if ((IndexDelta != 1) && (IndexDelta != 8))
                    {
                        //Первый ход может быть на соседнюю клетку или через соседнюю
                        //пешку на свободную клетку.
                        if (TestNextMove(EndIndex, Target.Up))
                        {
                            BFistSteped = true;
                            //Есть возможность следующего перемещения.
                            RemoveCheckerFromStackPanel(IntStartIndex);
                            SetCheckerToStackPanel(EndIndex, CheckerColor.WhiteSelected);
                            IntStartIndex = EndIndex;
                            break;
                        }
                    }
                    //Передает ход черным.
                    CurrentState = States.BlackSelect;
                    RemoveCheckerFromStackPanel(IntStartIndex);
                    SetCheckerToStackPanel(EndIndex, CheckerColor.White);
                    IntStartIndex = -1;    //Черная пешка еще не выбрана.                 
                    BFistSteped = false;

                    if (WhoWon(CheckerColor.White) == true)
                    {
                        MessageBox.Show("Белые выиграли");
                        Close();
                        
                    }

                    if (StartStopcs.BContinue == true)
                    {
                        ResetCounter(CheckerColor.Black);
                        if (IsStep(CheckerColor.Black, Target.Down) == false)
                        {
                            //Передает ход белым - нет хода черных.
                            //MessageBox.Show("Нет хода - передача хода белым");

                            MessageBox.Show("Нет хода - белые выиграли");
                            this.Close();
                            
                            //Передает ход белым.
                            CurrentState = States.WhiteSelect;
                            IntStartIndex = -1;    //Черная пешка еще не выбрана.
                            BFistSteped = false;
                            break;
                        }
                        if ((IntEndIndex >= 0) && (IntEndIndex <= 7))
                        {
                            BFistSteped = false;
                        }

                        //Передает ход белым.
                        CurrentState = States.WhiteSelect;
                        RemoveCheckerFromStackPanel(IntStartIndex);
                        SetCheckerToStackPanel(IntEndIndex, CheckerColor.Black);
                        IntStartIndex = -1;    //Черная пешка еще не выбрана.
                        BFistSteped = false;
                        ResetCounter(CheckerColor.Black);
                        if (WhoWon(CheckerColor.Black) == true)
                        {
                            MessageBox.Show("Черные выиграли :(");
                            this.Close();
                            

                            //Close();
                        }
                    }
                    break;

                case States.BlackSelect:
                    if (CheckerColor != CheckerColor.Black)
                    {
                        //Нарушена очередность хода.
                        MessageBox.Show("Ход черных.");                        
                        break;
                    }
                    if (!IsStep(CheckerColor.Black, Target.Down))
                    {
                        //Передает ход белым - нет хода черных.
                        //MessageBox.Show("Нет хода - передача хода белым");

                        MessageBox.Show("Нет хода - белые выиграли");
                        this.Close();
                        
                        
                        //Передает ход белым.
                        CurrentState = States.WhiteSelect;
                        IntStartIndex = -1;    //Черная пешка еще не выбрана.
                        BFistSteped = false;
                        break;
                    }

                    //Выделяет выбранную черную пешку и переходит на ее перемещение.
                    IntStartIndex = EndIndex;
                    CurrentState = States.BlackMove;
                    RemoveCheckerFromStackPanel(IntStartIndex);
                    SetCheckerToStackPanel(IntStartIndex, CheckerColor.BlackSelected);
                    break;

                case States.BlackMove:
                    if (IndexDelta == 0)
                    {
                        //Отмняет выбор
                        CurrentState = States.BlackSelect;
                        RemoveCheckerFromStackPanel(IntStartIndex);
                        SetCheckerToStackPanel(IntStartIndex, CheckerColor.Black);
                        if (BFistSteped == true)
                        {
                            //Передает ход белым.
                            CurrentState = States.WhiteSelect;
                            IntStartIndex = -1;    //Черная пешка еще не выбрана.
                            BFistSteped = false;
                            break;
                        }
                        break;
                    }
                    if (TestOneMove(IntStartIndex, EndIndex, Target.Down) == false)
                    {
                        MessageBox.Show("Неверный ход.");
                        break;
                    }
                    if (BFistSteped)
                    {
                        if ((IndexDelta == -1) || (IndexDelta == -8))
                        {
                            MessageBox.Show("Неверный ход.");
                            break;
                        }
                    }

                    if ((IndexDelta != -1) && (IndexDelta != -8))
                    {
                        if (TestNextMove(EndIndex, Target.Down))
                        {
                            BFistSteped = true;
                            //Есть возможность следующего перемещения.
                            RemoveCheckerFromStackPanel(IntStartIndex);
                            SetCheckerToStackPanel(EndIndex, CheckerColor.BlackSelected);
                            IntStartIndex = EndIndex;
                            break;
                        }
                    }

                    //Передает ход белым.
                    CurrentState = States.WhiteSelect;
                    RemoveCheckerFromStackPanel(IntStartIndex);
                    SetCheckerToStackPanel(EndIndex, CheckerColor.Black);
                    IntStartIndex = -1;    //Черная пешка еще не выбрана.
                    BFistSteped = false;

                    if (WhoWon(CheckerColor.Black) == true)
                    {
                        MessageBox.Show("Черные выиграли :(");
                        Close();
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"New State = {CurrentState}");
        }

        private void RemoveCheckerFromStackPanel(int ChBIndex)
        {
            StackPanel sp = ChB[ChBIndex].StPanel;
            sp.Children.RemoveAt(0);
            ChB[ChBIndex].Col = CheckerColor.Unknown;
        }

        private void SetCheckerToStackPanel(int ChBIndex, CheckerColor col)
        {
            StackPanel sp = ChB[ChBIndex].StPanel;
            switch (col)
            {
                case CheckerColor.Unknown:
                    break;
                case CheckerColor.White:
                    ChB[ChBIndex].Col = col;
                    sp.Children.Add
                        (new Ellipse
                        {
                            Width = WhiteEllipse.Width,
                            Height = WhiteEllipse.Height,
                            Stroke = WhiteEllipse.Stroke,
                            StrokeThickness = WhiteEllipse.StrokeThickness,
                            Fill = WhiteEllipse.Fill,
                        });
                    break;
                case CheckerColor.Black:
                    ChB[ChBIndex].Col = col;
                    sp.Children.Add
                        (new Ellipse
                        {
                            Width = BlackEllipse.Width,
                            Height = BlackEllipse.Height,
                            Stroke = BlackEllipse.Stroke,
                            StrokeThickness = BlackEllipse.StrokeThickness,
                            Fill = BlackEllipse.Fill
                        });
                    break;
                case CheckerColor.WhiteSelected:
                    ChB[ChBIndex].Col = col;
                    sp.Children.Add
                        (new Ellipse
                        {
                            Width = WhiteSelectedEllipse.Width,
                            Height = WhiteSelectedEllipse.Height,
                            Stroke = WhiteSelectedEllipse.Stroke,
                            StrokeThickness = WhiteSelectedEllipse.StrokeThickness,
                            Fill = WhiteSelectedEllipse.Fill,
                        });
                    break;
                case CheckerColor.BlackSelected:
                    ChB[ChBIndex].Col = col;
                    sp.Children.Add
                        (new Ellipse
                        {
                            Width = BlackSelectedEllipse.Width,
                            Height = BlackSelectedEllipse.Height,
                            Stroke = BlackSelectedEllipse.Stroke,
                            StrokeThickness = BlackSelectedEllipse.StrokeThickness,
                            Fill = BlackSelectedEllipse.Fill
                        });
                    break;
                default:
                    break;
            }
        }

        private bool TestOneMove(int _StartIndex, int _EndIndex, Target tg)
        {
            
            if (_StartIndex < 0)
            {
                return false;   //Некорректный выхов функции.
            }

            int IndexDelta = _EndIndex - _StartIndex;
            int Dlt_1;
            int Dlt_8;
            switch (tg)
            {
                case Target.Unknown:
                    return false;       //Некорректный выхов функции.
                case Target.Up:
                    Dlt_1 = 1;
                    Dlt_8 = 8;
                    if (IndexDelta < 0)
                    {
                        return false;   //Ход назад
                    }
                    if (_StartIndex % 8 > _EndIndex % 8)
                    {
                        return false;
                    }

                    break;
                case Target.Down:
                    Dlt_1 = -1;
                    Dlt_8 = -8;
                    if (IndexDelta > 0)
                    {
                        return false;   //Ход назад
                    }
                    if (_StartIndex % 8 < _EndIndex % 8)
                    {
                        return false;
                    }
                    IndexDelta = -IndexDelta;
                    break;
                default:
                    return false;       //Некорректный выхов функции.
            }

            try
            {
                if (ChB[_EndIndex].Col != CheckerColor.Unknown)
                {
                    return false;   //Ход на занятую клетку
                }
            }
            catch (Exception)
            {
                return false;
            }

            switch (IndexDelta)
            {
                case 0:
                    //Пешка осталась на своем месте.
                    return true;
                case 1:
                    //Ход на соседнюю колонку.
                    return true;
                case 2:
                    //Ход через колонку - нельзя прыгать через пустую клетку.
                    if (ChB[_StartIndex + Dlt_1].Col == CheckerColor.Unknown)
                    {
                        return false;//В соседней колонке нет пешки.
                    }
                    return true;
                case 8:
                    //Ход на соседнюю строку.
                    return true;
                case 16:
                    //Ход через строку - нельзя прыгать через пустую клетку.
                    if (ChB[_StartIndex + Dlt_8].Col == CheckerColor.Unknown)
                    {
                        return false;//В соседняей строке нет пешки.
                    }
                    return true;
                default:
                    //Непредусмотренный вариант.
                    return false;
            }
        }

        /****************************************************************
         * *** TestNextMove *** - 01.12.2019
         * Проверяет возможность последующего хода, следующего за первым.
         * Последующий ход возможен толко через занятую клетку - индекс
         * увеличивается на 2 единицы.
         * *************************************************************/
        private bool TestNextMove(int _EndIndex, Target tg)
        {
            int NextIndex2 = _EndIndex;
            int NextIndex16 = _EndIndex;

            if (tg == Target.Up)
            {
               
                NextIndex2 += 2;
                NextIndex16 += 16;
            }
            else
            {
                NextIndex2 -= 2;
                NextIndex16-= 16;
            }

            if (TestOneMove(_EndIndex, NextIndex2, tg))
            {
                if ((NextIndex2 / 8) == (_EndIndex / 8))
                {
                    IntEndIndex = NextIndex2;
                    return true;
                }
            }

            if (TestOneMove(_EndIndex, NextIndex16, tg))
            {
                IntEndIndex = NextIndex16;
                return true;
            }

            return false;
        }

        /****************************************************************
         * *** TestFirstMove *** - 01.12.2019 - 02,12,2019
         * Проверяет возможность первого хода. Первый ход возможен, либо
         * на соседнюю клетку или через клетку, если она занята пешкой
         * люього цвета.
         * *************************************************************/
        private bool TestFirstMove(int _EndIndex, Target tg)
        {
            BOneSteped = false;
            int NextIndex1 = _EndIndex;
            int NextIndex8 = _EndIndex;
            int NextIndex2 = _EndIndex;
            int NextIndex16 = _EndIndex;

            if (tg == Target.Up)
            {

                NextIndex1 += 1;
                NextIndex8 += 8;
                NextIndex2 += 2;
                NextIndex16 += 16;
            }
            else
            {
                NextIndex1 -= 1;
                NextIndex8 -= 8;
                NextIndex2 -= 2;
                NextIndex16 -= 16;
            }

            if (TestOneMove(_EndIndex, NextIndex16, tg))
            {
                IntEndIndex = NextIndex16;
                return true;
            }

            if (TestOneMove(_EndIndex, NextIndex2, tg))
            {
                if ((NextIndex2 / 8) == (_EndIndex / 8))
                {
                    IntEndIndex = NextIndex2;
                    return true;
                }
            }

            int ColumnIndex = _EndIndex % 8;
            int RowIndex = _EndIndex / 8;
            if (ColumnIndex < RowIndex)
            {
                if (TestOneMove(_EndIndex, NextIndex8, tg))
                {
                    if ((NextIndex8 % 8) == (_EndIndex % 8))
                    {
                        if (TestOverflow(_EndIndex, NextIndex8))
                        {
                            IntEndIndex = NextIndex8;
                            return true;
                        }
                    }
                }

                if (TestOneMove(_EndIndex, NextIndex1, tg))
                {
                    if (TestOverflow(_EndIndex, NextIndex1))
                    {
                        IntEndIndex = NextIndex1;
                        return true;
                    }
                }
            }
            else
            {
                if (TestOneMove(_EndIndex, NextIndex1, tg))
                {
                    if (TestOverflow(_EndIndex, NextIndex1))
                    {
                        IntEndIndex = NextIndex1;
                        BOneSteped = true;
                        return true;
                    }
                }
                if (TestOneMove(_EndIndex, NextIndex8, tg))
                {
                    if ((NextIndex1 / 8) == (_EndIndex / 8))
                    {
                        if (TestOverflow(_EndIndex, NextIndex8))
                        {
                            IntEndIndex = NextIndex8;
                            BOneSteped = true;
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private bool WhoWon(CheckerColor col)
        {
            int[] indx = { 0, 1, 2, 8, 9, 10, 16, 17, 18 };
            if (col == CheckerColor.White)
            {
                for (int i = 0; i < indx.Length; i++)
                {
                    indx[i] += 45;
                }
            }

            for (int i = 0; i < indx.Length; i++)
            {
                if (ChB[indx[i]].Col != col)
                    return false;                
            }
            return true;
        }

        private bool IsStep(CheckerColor col, Target tg)
        {
            List<int> startList = new List<int>();
            List<int> endList = new List<int>();
            int index;
            int index2 = -1;
            int maxdlt = 0;
            int start;
            int end;
            for (index = 0; index < ChB.Count; index++)
            {
                if (ChB[index].Col == col)
                {
                    index2 = -1;
                    if (TestFirstMove(index, tg))
                    {
                        if (tg == Target.Up)
                        {
                            return true;
                        }
                        if (TestOverflow(index, IntEndIndex))
                        {
                            index2 = IntEndIndex;
                        }
                        if (BOneSteped == false)
                            BOneSteped = false;
                        while ((TestNextMove(IntEndIndex, tg)) && !BOneSteped)
                        {
                            if (TestOverflow(index, IntEndIndex))
                            {
                                index2 = IntEndIndex;
                            }
                        }
                    }
                    if (index2 > -1)
                    {
                        startList.Add(index);
                        endList.Add(index2);
                    }
                }
            }
            for (index = 0; index < startList.Count; index++)
            {
                start = startList[index];
                end = endList[index];
                if ((start - end) > maxdlt)
                {
                    maxdlt = start - end;
                    index2 = index;
                }
            }

            if (index2 > -1)
            {
                IntStartIndex = startList[index2];
                IntEndIndex = endList[index2];
                return true;
            }
            return false;
        }
        
        bool TestOverflow(int start,int end)
        {
           int StartColumn = (start % 8) + 1;
            int StartRow = (start / 8) + 1;
            int EndColumn = (end % 8) + 1;
            int EndRow = (end / 8) + 1;
            bool bClumnOk = false;
            bool bRowOk = false;
            if (CountRow2 == 3)
                CountRow2 = 3;
            if (EndColumn < StartColumn)
            {
                switch (EndColumn)
                {
                    case 1:
                        if (CountColumn1 < 3)
                        {
                            bClumnOk = true;
                        }
                        break;
                    case 2:
                        if (CountColumn2 < 3)
                        {
                            bClumnOk = true;
                        }
                        break;
                    case 3:
                        if (CountColumn3 < 3)
                        {
                            bClumnOk = true;
                        }
                        break;
                    default:
                        bClumnOk = true;
                        break;
                }
            }
            else
            {
                bClumnOk = true;
            }
            if (EndRow < StartRow)
            {
                switch (EndRow)
                {
                    case 1:
                        if (CountRow1 < 3)
                        {
                            bRowOk = true;
                        }
                        break;
                    case 2:
                        if (CountRow2 < 3)
                        {
                            bRowOk = true;
                        }
                        break;
                    case 3:
                        if (CountRow3 < 3)
                        {
                            bRowOk = true;
                        }
                        break;
                    default:
                        bRowOk = true;
                        break;
                }
            }
            else
            {
                bRowOk = true;
            }
            return bClumnOk && bRowOk;
        }

        void ResetCounter(CheckerColor col)
        {
            Console.WriteLine();
            CountColumn1 = CountColumnBusy(0, col);
            CountColumn2 = CountColumnBusy(1, col);
            CountColumn3 = CountColumnBusy(2, col);
            CountRow1 = CountRowBusy(0, col);
            CountRow2 = CountRowBusy(1, col);
            CountRow3 = CountRowBusy(2, col);
            Console.WriteLine($"c1={CountColumn1.ToString()} c2={CountColumn2.ToString()} c3={CountColumn3.ToString()} ");
            Console.WriteLine($"r1={CountRow1.ToString()} r2={CountRow2.ToString()} r3={CountRow3.ToString()} ");
        }

        int CountColumnBusy(int ColumnIndex, CheckerColor col)
        {
            int count = 0;
            int StartIndex = ColumnIndex;
            for (int n = 0; n < 8; n++)
            {
                if (ChB[StartIndex + n * 8].Col == col)
                {
                    count++;
                }
            }
            return count;
        }

        int CountRowBusy(int RowIndex, CheckerColor col)
        {
            int count = 0;
            int StartIndex = RowIndex * 8;
            for (int n = 0; n < 8; n++)
            {
                if (ChB[StartIndex + n].Col == col)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
