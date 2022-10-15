﻿namespace RayTraceBenchmark
{
	class MyGeneric<T>
	{
		public T t;
		NestedClass n;

		public class NestedClass
		{
			public int i;
			MyGeneric<T> n;
		}

		public MyGeneric(T t)
		{
			this.t = t;
			T localT = default;
			this.t = localT;
		}
	}

	public class Program
	{
		private Program p;
		private int i;

		static void Main()
		{
			checked {
				int j = int.MaxValue;
				j = j + 1000;
				
				uint uj = uint.MaxValue;
				uj += 1000;

				long lj = long.MaxValue;
				lj += 1000;
				
				ulong ulj = ulong.MaxValue;
				ulj += 1000;
			}

			object nullObject = null;

			if (nullObject != null)
				return;
			
			int a = Foo(123);
			EXIT:;
			if (a == 124) a = -200;
			for (int i = 0; i != 2; ++i)
			{
				for (int i2 = 0; i2 != 2; ++i2)
				{
					if (i2 == 1 && i == 0) a++;
					if (a >= 1) goto EXIT;
				}
			}
		}

		static int Foo(int value)
		{
			return value + 1;
		}

		static void Foo(Program value)
		{
			value.p.i = 123;
		}

		static void FooGeneric(MyGeneric<int> wow)//, MyGeneric<int>.NestedClass nested)
		{
			int unusedLocal = FooGenericMethod<int>(22);
			FooGenericMethod<int>(44);
		}

		static T FooGenericMethod<T>(T t)
        {
			return t;
        }
	}
}
