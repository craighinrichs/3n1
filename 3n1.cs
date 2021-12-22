using System;

class Untitled {
	static void Main(string[] args) {
		int counter = 0;
		string line;
		System.IO.StreamReader file = new System.IO.StreamReader(@"test.txt");
		while((line = file.ReadLine()) != null) {
			string res = ProcessLine(line);
			counter++;
			Console.WriteLine(res);
		}
		file.Close();
	}
	
	static string ProcessLine(string line) {
		string[] words = line.Split(' ');
		
		int i = Int32.Parse(words[0]);
		int j = Int32.Parse(words[1]);
		
		int highest = 0;
		for(int ia = i; ia < j; ia++) {
			int s = routine(ia);
			highest = s > highest ? s : highest;
		}
		
		return i + " " + j + " " + highest;
	}
	
	static int routine(int number) {
		int steps = 1;
		int nn = number;
		while(nn != 1) {
			if(nn % 2 == 0) {
				nn = nn / 2;
			} else {
				nn = (nn * 3) + 1;
			}
			steps++;
		}
		return steps;
	}
}