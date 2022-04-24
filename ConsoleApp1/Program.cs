using System;

namespace Sample
{
	
	class Test
	{
	
		public static void Main(string[] args)
		{
			string testString;
			Console.Write("Enter a string - ");
			testString = Console.ReadLine();
			Console.WriteLine("You entered '{0}'", testString);
			Console.Write("Masukkan jumlah string yng mau diinputkan ");
			testString = Console.ReadLine();
			int i = Convert.ToInt32(testString);
			string[] nama= new string[i];
			int[] nilai= new int[i];
			for(int j=0; j < i; j++)
            {
				testString=Console.ReadLine();
				string[] x;
				x = testString.Split(" ");
				if (x.Length == 2)
				{					
					int rev = Array.IndexOf(nama,x[0]);
                    if (rev > -1)
                    {
						nama[rev] = x[0];
						nilai[rev] = nilai[rev]+ Convert.ToInt32(x[1]);
                    }
						else
                    {
						nama[j] = x[0];
						nilai[j] = Convert.ToInt32(x[1]);
					}
				}


			}

			Console.WriteLine("String yang anda masukkan adalah ");
			string y = "";
			for(int j=0; j < i; j++)
            {
				if(nama[j] != null)
                {
					Console.Write(nama[j] + " nilainya adalah " + nilai[j] + "\n");
				} else
                {
					y = Convert.ToString(j) + "," + y ;
				}
			}
			y = y.Substring(0, y.Length - 1);
			//Console.WriteLine(y);
			string[] rr = y.Split(",");
			List<string> tmp = new List<string>(nama);
			List<int> tmp1 = new List<int>(nilai);
			for (int x = 0; x < rr.Length; x++)
            {
				if(rr[x] != null)
                {					
					tmp.RemoveAt(Convert.ToInt32(rr[x]));
					tmp1.RemoveAt(Convert.ToInt32(rr[x]));
				}

			}
			nama = tmp.ToArray();
			nilai = tmp1.ToArray();
			Console.WriteLine(" Nilai paling tertinggi adalah " + Convert.ToString(nilai.Max()) + " yaitu " +
				nama[nilai.ToList().IndexOf(nilai.Max())]);
			Console.WriteLine(" Nilai paling terendah adalah " + Convert.ToString(nilai.Min()) + " yaitu " +
				nama[nilai.ToList().IndexOf(nilai.Min())]);
			i = Convert.ToInt32(nama.Length);
			for (int j = 0; j < i; j++)
			{
					Console.Write(nama[j] + " nilainya adalah " + nilai[j] + "\n");
			}
		}
	}
}
