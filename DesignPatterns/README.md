# 设计模式

解耦 重用

## 设计模式原则：

- 开闭原则 OPEN CLOSE PRINCIPLE
  
  ```sh
  开闭原则是面向对象设计中最基础的设计原则
  对扩展开放，对修改关闭
  ```

- 依赖倒置原则
  具体实现应该依赖于抽象
  高模块不应该依赖低模块，都依赖抽象

  ```
  public interface IDriver{
  　　public void drive(ICar car);
  }

  public class Tester : IDriver{
  　　public void drive(ICar car){
  　　　　car.run();
  　　}
  }

  public class User : IDriver{
  　　public void drive(ICar car){
  　　　　car.run();
  　　}
  }

  public interface ICar{
  　　public void run();
  }

  public class Benz : ICar{
  　　public void run(){
  　　　　System.out.println("奔驰骑车开始运行....");
  　　}
  }

  public class BMW : ICar{
  　　public void run(){
  　　　　System.out.println("宝马骑车开始运行....");
  　　}
  }
  public class Client{
  　　public static void main(String[] args){
  　　　　IDriver tester = new Driver();
  　　　　ICar benz = new Benz();
  　　　　ICar bmw = new BMW();

  　　　　tester.drive(benz);
  　　　　tester.drive(bmw);
  　　}
  }
  ```

- 里氏代换原则
- 接口隔离原则
- 最少知道原则
- 合成复用原则

## 常用的设计模式

### 单例模式

### 简单工厂模式

  ```
  public interface ISample
  {
      void Say();
  }
  public class SampleA : ISample
  {
      public void Say()
      {
          Debug.WriteLine("this is a");
      }
  }
  public class SampleB : ISample
  {
      public void Say()
      {
          Debug.WriteLine("this is b");
      }
  }
  public class Factory
  {
      public static ISample Run(int which)
      {
          ISample sample = null;
          if (which == 1)
              sample = new SampleA();
          else if (which == 2)
              sample = new SampleB();

          return sample;
      }
  }

  ISample _sa = Factory.Run(1)
  _sa.Say()
  ```

### 工厂模式

### 抽象工厂模式

### 观察者模式

