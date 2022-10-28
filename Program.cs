//В данном проекте я создаю разные модели телефонов
//с уникальными для других моделей функциями используя паттерн абстрактная фабрика

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFabric
{
    public class Program
    {
        static void Main(string[] args)
        {
            Mobile samsung = new Mobile(new Samsung());
            samsung.OS();
            samsung.Store();
            samsung.Camera();

            Mobile iphone = new Mobile(new Iphone());
             iphone.OS();
            iphone.Store();
            iphone.Camera();
        }
    }

    abstract class Camera
    {
        public abstract void Photo();
    }
    abstract class Store
    {
        public abstract void StoreType();
    }
   abstract class OperatingSystem
    {
        public abstract void SystemType();
    }

    class InfraredCamera : Camera
    {
        public override void Photo()
        {
            Console.WriteLine("Buit-in infrared camera!\n");
        }
    }
    class NightCamera : Camera
    {
        public override void Photo()
        {
            Console.WriteLine("Built-in a night camera!\n");
        }
    }
    class Android : OperatingSystem
    {
        public override void SystemType()
        {
            Console.WriteLine("Operating system: Android");
        }
    }
    class IOS : OperatingSystem
    {
        public override void SystemType()
        {
            Console.WriteLine("Operating system: IOS");
        }
    }
    class Google : Store
    {
        public override void StoreType()
        {
            Console.WriteLine("I have the GooglePlay!");
        }
    }
    class Apple : Store
    {
        public override void StoreType()
        {
            Console.WriteLine("I have the AppleStore!");
        }
    }

    abstract class MobileFactory
    {
        public abstract OperatingSystem CreateOS();
        public abstract Store CreateStore();
        public abstract Camera CreateCamera();
    }

    class Iphone : MobileFactory
    {
        public override OperatingSystem CreateOS()
        {
            return new IOS();
        }
        public override Store CreateStore()
        {
            return new Apple();
        }
        public override Camera CreateCamera()
        {
            return new InfraredCamera();
        }
    }

    class Samsung : MobileFactory
    {
        public override OperatingSystem CreateOS()
        {
            return new Android();
        }
        public override Store CreateStore()
        {
            return new Google();
        }
        public override Camera CreateCamera()
        {
            return new NightCamera();
        }
    }

    class Mobile
    {
        private OperatingSystem _os;
        private Store _store;
        private Camera _camera;

        public Mobile(MobileFactory mobileFactory)
        {
            _os = mobileFactory.CreateOS();
            _store = mobileFactory.CreateStore();   
            _camera = mobileFactory.CreateCamera();
        }

        public void OS()
        {
            _os.SystemType();
        }
        public void Camera()
        {
            _camera.Photo();
        }
        public void Store()
        {
            _store.StoreType();
        }
    }
}
