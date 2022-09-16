using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CW_16._09._2022
{
    delegate void MyDelegate();
    public abstract class GeoFigure
    {
        public string name;
        public GeoFigure()
        {
            name = "Фигура";
        }
        private bool Scalable;

        public bool scalable
        {
            get { return Scalable; }
            set { Scalable = value; } 
        }
        public void PrintName()
        {
            Console.WriteLine(this.name);
        }
        public abstract float Square();
        public virtual float Square(float _metric)
        {
            return _metric;
        }
    }
    public class Circle : GeoFigure
    {
        private event MyDelegate _notify 
        {
            add => _notify += value;
            remove => _notify -= value;
        }
        public new string name = "Окружность", _path = "output.txt";
        public float _radius;
        public override float Square()
        {
            //_notify = InformerConsole;
            float _result = _radius * _radius * 3.14f;
            float _limit = 100f;
            if(_result > _limit)
            {
                _notify += InformerConsole;
                _notify -= InformerConsole;
            }
            return _result;
        }
        public override float Square(float _metric)
        {
            return _radius * _radius * 3.14f;
        }
        public float Square(float _metric, bool IsBase)
        {
            if (IsBase)
            {
                return base.Square(_metric);
            }
            else
            {
                return Square(_metric);
            }
        }
        public void PrintSquare()
        {
            Console.WriteLine("Площадь = {0}", this.Square(this._radius));
        }
        public void PrintSquare(bool IsBase)
        {
            Console.WriteLine("Площадь = {0}", this.Square(this._radius, IsBase));
        }
        public void WriteSqaare()
        {
            string full_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var sw = new StreamWriter(full_path + "\\" + _path, true);
            sw.WriteLine("Площадь = {0}", this.Square(this._radius));
            sw.Close();
        }
        public void InformerConsole()
        {
            Console.WriteLine("Площадь окружности больше ста");
        }
    }
    internal class GeoF
    {

    }
}
