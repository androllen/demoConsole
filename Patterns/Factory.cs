using System;
using System.Diagnostics;

namespace demoConsole
{
    public interface MouseFactory
    {
        Mouse createMouse();
    }

    public class HpMouseFactory : MouseFactory
    {
        public Mouse createMouse()
        {
            return new HpMouse();
        }
    }

    public class DellMouseFactory : MouseFactory
    {
        public Mouse createMouse()
        {
            return new DellMouse();
        }
    }

    public class DellMouse : Mouse
    {
        public void sayHi()
        {
            Debug.WriteLine("I am dell");
        }
    }

    public class HpMouse : Mouse
    {
        public void sayHi()
        {
            Debug.WriteLine("I am hp");
        }
    }

    public interface Mouse
    {
        void sayHi();
    }
    public class Factory
    {
        public Factory()
        {
            
            MouseFactory mouseFactory = new DellMouseFactory();
            var mouse = mouseFactory.createMouse();
            mouse.sayHi();
        }
        // public void Shell()
        // {

        // }
    }
}