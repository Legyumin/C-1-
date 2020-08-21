using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

	abstract class AbstractBase
	{
		public void PrivateMethodA()
		{
			Console.WriteLine("AbstractBase.PrivateMethodA()");
		}
		public void PublicMethodA()
		{
			Console.WriteLine("AbstractBase.PublicMethodA()");
		}

		public abstract void AbstractMethodA();
	}
		class Derived : AbstractBase
		{/*
		public void PrivateMethodA() {
			Console.WriteLine("PrivateMethodA()");
		}*/
			public override void AbstractMethodA() { //override,abstract 같이 사용됨
				Console.WriteLine("Derived.AbstractMethodA()");
			PrivateMethodA();
			}
		}
		class Program
		{
			static void Main(string[] args)
			{
			AbstractBase obj = new Derived();
			obj.AbstractMethodA();
			obj.PublicMethodA();
			}
		}
	}