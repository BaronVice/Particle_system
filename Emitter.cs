using Particle_system.MyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle_system
{
    /** <summary> 
     * Класс <c>Emitter</c> является генератором частиц.
     * </summary>
     * <value>
     * <c> particles </c> - существующие частицы, <br/>
     * <c> toRemove </c> - частицы для удаления, <br/>
     * <c> gravitationX и gravitationY </c> - гравитация по оси X и Y, <br/>
     * <c> amount </c> - количество генерируесых частиц.
     * </value>
     */
    class Emitter
    {
        public HashSet<Particle> particles = new HashSet<Particle>();
        private HashSet<Particle> toRemove = new HashSet<Particle>();

        public float gravitationX;
        public float gravitationY;

        public int amount;
        public static Random random = new Random();

        /** <summary> 
        * Метод <c>DrawParticleList</c> запускает прорисовку всех частиц
        * на графике <paramref name="g"/>.
        * </summary>
        * <param name="g"> График, на котором будет происходить прорисовка </param>
        */
        public void DrawParticleList(Graphics g)
        {
            Render(g);
        }

        /** <summary> 
        * Метод <c>Render</c> рисует существующие частицы
        * на графике <paramref name="g"/>.
        * </summary>
        * <param name="g"> График, на котором будет происходить прорисовка </param>
        */
        private void Render(Graphics g)
        {
            foreach (Particle particle in particles)
                particle.Draw(g);
        }

        /** <summary> 
        * Метод <c>AddParticles</c> создает новые частицы.
        * </summary>
        * <param name="display"> График, на котором будет происходить прорисовка </param>
        * <remarks>
        * Вызывается при увеличении количества частиц в <c>NumericUpDown1.</c>
        * Добавление происходит пачками до 10 частиц пока не будет достигнуто нужное количество.
        * </remarks>
        */
        public void AddParticles(PictureBox display)
        {
            int amountToAdd = random.Next(10);
            amountToAdd = Math.Min(amountToAdd, amount - amountToAdd);

            for (int i = 0; i < amountToAdd; i++)
            {
                Particle particle = new Particle(random.Next(display.Image.Width), -30);
                particles.Add(particle);
            }
        }

        /** <summary> 
        * Метод <c>UpdateState</c> обновляет состояние частиц: <br/>
        * Уменьшает жизнь частицы, смещает в соответствии с текущей гравитацией.
        * </summary>
        * <param name="display"> График, на котором будет происходить прорисовка </param>
        * <remarks>
        * В случае нулевого состояния жизни частицы, она отправляется в метод <c>ResetParticle</c>
        * (<see cref="ResetParticle(Particle, PictureBox)"/>)
        * </remarks>
        */
        public void UpdateState(PictureBox display)
        {

            foreach (Particle particle in particles)
            {
                particle.Life -= 1;

                if (particle.Life < 0)
                    ResetParticle(particle, display);
                else
                    particle.MoveParticle(gravitationX, gravitationY);
            }

            foreach (Particle particle in toRemove)
                particles.Remove(particle);

            toRemove.Clear();
        }
        /** <summary> 
        * Метод <c>ResetParticle</c> сбрасывает состояние частицы <paramref name="particle"/>.
        * В случае, если заданное количество (<paramref name="amount"/>) меньше текущего количества частиц,
        * то некоторые частицы удаляются, пока их количество не сойдет к заданному <br/>
        * Уменьшает жизнь частицы, смещает в соответствии с текущей гравитацией.
        * </summary>
        * <param name="display"> График, на котором будет происходить прорисовка </param>
        * <remarks>
        * Свойства частицы сбрасываются в методе класса частицы <c>ResetValues</c>
        * (<see cref="Particle.ResetValues(PictureBox)"/>)
        * </remarks>
        */
        private void ResetParticle(Particle particle, PictureBox display)
        {
            if (amount < particles.Count - toRemove.Count)
                toRemove.Add(particle);

            else
                particle.ResetValues(display);
        }
    }
}