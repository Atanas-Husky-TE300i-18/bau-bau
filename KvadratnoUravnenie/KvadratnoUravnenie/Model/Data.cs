using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnoUravnenie.Model
{
    public class Data
    {
		private int a;
		public int A
		{
			get { return a; }
			set { a = value; }
		}	
		private int b;
		public int B
		{
			get { return b; }
			set { b = value; }
		}
		private int c;
		public int C
		{
			get { return c; }
			set { c = value; }
		}
		private double x1;
		public double X1
		{
			get { return x1; }
			set { x1 = value; }
		}
		private double x2;
        public double X2
		{
			get { return x2; }
			set { x2 = value; }
		}
		public Data()
		{
			this.A = 0;
			this.B = 0;
			this.C = 0;
		}
	}
}
