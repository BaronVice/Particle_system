using Particle_system.MyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

// Created by BaronVice
// GitHub: https://github.com/BaronVice

// Open menu to add circle - rmb click
// Pick circle to change - lmb click at circle
// Pick circle to drag - double lmb click at circle

namespace Particle_system
{
    /** <summary> 
     * Класс <c>Form1</c> основная форма.
     * </summary>
     * <value>
     * <c> emitter </c> - генератор частиц (<see cref="Emitter"/>), <br/>
     * <c> circles </c> - окружности смены цвета частиц (<see cref="Circle"/>), <br/>
     * <c> mouseX и mouseY </c> - положение курсора на рисунке <br/>
     * <c> menuClickedX и menuClickedY </c> - определение положения курсора после клика <br/>
     * <c> isDragged </c> - перемещает ли курсор окружность <br/>
     * <c> draggedCircle </c> - окружность, которую перемещает курсор <br/>
     * <c> counter </c> - количество окружностей на рисунке <br/>
     * <c> chosenCircle </c> - выбранная окружность для редактирования.
     * </value>
     */
    public partial class Form1 : Form
    {
        Emitter emitter = new Emitter();
        List<Circle> circles = new List<Circle>();

        int mouseX, mouseY;
        int menuClickedX, menuClickedY;
        MousePoint mousePoint = new MousePoint();

        bool isDragged = false;
        Circle draggedCircle;

        int counter = 1;
        Circle chosenCircle;

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emitter.amount = (int)numericUpDown1.Value;
            emitter.gravitationX = (float)gravX.Value;
            emitter.gravitationY = (float)gravY.Value;
        }

        /// <summary>
        /// Каждый тик обновляет состояния объектов на рисунке
        /// </summary>
        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            Graphics g = Graphics.FromImage(picDisplay.Image);

            emitter.UpdateState(picDisplay);
            CheckOverlaped(g);

            g.Clear(Color.Black);
            Circle.DrawCircleList(g, circles);
            emitter.DrawParticleList(g);

            picDisplay.Invalidate();

            g.Dispose();
        }

        /// <summary>
        /// Проверяет принадлежность частицы существующим окружностям.
        /// Если принадлежит, то ее цвет меняется в цвет окружности, иначе возвращается в базовый.
        /// </summary>
        private void CheckOverlaped(Graphics g)
        {
            circles.Reverse();

            foreach (Particle particle in emitter.particles)
                foreach (Circle circle in circles)
                {
                    if (particle.Overlaps(circle, g))
                    {
                        particle.ObjColor = circle.ObjColor;
                        break;
                    }
                    else
                    {
                        particle.ObjColor = Particle.baseColor;
                    }
                }

            circles.Reverse();

        }

        /// <summary>
        /// Каждый тик вызывает метод добавления частиц в эмиттер
        /// (<see cref="Emitter.AddParticles(PictureBox)"/>). Когда количество частиц эмиттера
        /// <paramref name="emitter.amount"/> достигает указанного значения 
        /// (<paramref name="emitter.particles.Count"/>), таймер останавливается.
        /// </summary>
        private void Timer2_Tick(object sender, EventArgs e)
        {
            emitter.AddParticles(picDisplay);

            if (emitter.amount <= emitter.particles.Count)
                timer2.Stop();
        }

        /// <summary>
        /// При новом значении количества частиц обновляет значение в эмиттере
        /// (<paramref name="emitter.amount"/>) и запускает проверку на добавление частиц. 
        /// </summary>
        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            emitter.amount = (int)numericUpDown1.Value;
            timer2.Start();
        }

        /// <summary>
        /// Смена гравитации по оси X
        /// </summary>
        private void gravX_ValueChanged(object sender, EventArgs e)
        {
            emitter.gravitationX = (float)gravX.Value;
        }

        /// <summary>
        /// Смена гравитации по оси Y
        /// </summary>
        private void gravY_ValueChanged(object sender, EventArgs e)
        {
            emitter.gravitationY = (float)gravY.Value;
        }

        /// <summary>
        /// Создает кольцо в выбранном месте.
        /// </summary>
        /// <remarks>
        /// Максимальное количество колец - 5. В случае переполнения самое старое кольцо удаляется.
        /// </remarks>
        private void создатьЗдесьКольцоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (circles.Count >= 5)
                circles.RemoveAt(0);

            circles.Add(new Circle(menuClickedX, menuClickedY, $"Circle{counter++}"));
        }

        /// <summary>
        /// При нажатии на <c>button1</c> происходит вызов метода смены цвета колец
        /// (<see cref="Circle.ChangeColors(List{Circle})"/>
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Circle.ChangeColors(circles);
        }

        /// <summary>
        /// При клике по области <c>picDisplay</c> если какая-либо окружность пересекается с местом клика, то
        /// она будет отображена в окне свойств окружности.
        /// </summary>
        private void picDisplay_Click(object sender, EventArgs e)
        {
            mousePoint.X = mouseX;
            mousePoint.Y = mouseY;

            foreach (Circle circle in circles)
                if (circle.Overlaps(mousePoint, Graphics.FromImage(picDisplay.Image)))
                {
                    chosenCircle = circle;

                    circleName.Enabled = true;
                    circleRadius.Enabled = true;

                    circleName.Text = circle.Name;
                    circleRadius.Value = circle.Radius;

                    return;
                }
                else
                {
                    circleName.Enabled = false;
                    circleRadius.Enabled = false;
                }
        }

        /// <summary>
        /// Смена названия окружности.
        /// </summary>
        private void circleName_TextChanged(object sender, EventArgs e)
        {
            chosenCircle.Name = circleName.Text;
        }

        /// <summary>
        /// Смена радиуса окружности.
        /// </summary>
        private void circleRadius_ValueChanged(object sender, EventArgs e)
        {
            chosenCircle.Radius = (int)circleRadius.Value;
        }

        /// <summary>
        /// При двойном клике по области <c>picDisplay</c> если какая-либо окружность пересекается с местом
        /// клика, то она будет взята для передвижения.
        /// </summary>
        private void picDisplay_DoubleClick(object sender, EventArgs e)
        {

            foreach (Circle circle in circles)
                if (circle.Overlaps(mousePoint, Graphics.FromImage(picDisplay.Image)))
                {
                    circles.Remove(circle);
                    circles.Add(circle);

                    draggedCircle = circle;
                    isDragged = !isDragged;
                    return;
                }

            isDragged = false;
        }

        /// <summary>
        /// При открытии контекстного меню запоминается позиция курсора для создания окружности
        /// (<see cref="создатьЗдесьКольцоToolStripMenuItem_Click"/>).
        /// </summary>
        private void picDisplayContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            menuClickedX = mouseX;
            menuClickedY = mouseY;
        }

        /// <summary>
        /// Отслеживание позиции курсора и передвижение окружности, если та взята.
        /// </summary>
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;

            if (isDragged)
            {
                draggedCircle.X = e.X;
                draggedCircle.Y = e.Y;
            }
        }
    }
}