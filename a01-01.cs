using System;
using System.Collections;

public class Program
{
	public static void Main()
	{
		ArrayList Grades = new ArrayList();
		int TotalCHours = 0;
		try
		{
			while (true)
			{
				Console.Write("Enter the course grade (-1 to end): ");
				int Gr = Convert.ToInt32(Console.ReadLine());
				if (Gr == -1)
					break;
				Console.Write("\nEnter the course hours: ");
				int Ch = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("---------\n");
				Grades.Add(Gr >= 90 ? "A" : Gr >= 82 ? "B+" : Gr >= 74 ? "B" : Gr >= 66 ? "C+" : Gr >= 58 ? "C" : Gr >= 50 ? "D" : "F");
				TotalCHours += Ch;
			}

			double QH = 0;
			string GString = "";
			for (int i =0; i<Grades.Count;i++)
			{
				//4 , 3.5 , 3 , 2.5 , 2 , 1.5 ,0
				
				GString += Grades[i] + (Grades.Count-i == 1 ? " ":", ");
				switch (Grades[i])
				{
					case "A":
						QH += 4;
						break;
					case "B+":
						QH += 3.5;
						break;
					case "B":
						QH += 3;
						break;
					case "C+":
						QH += 2.5;
						break;
					case "C":
						QH += 2;
						break;
					case "D":
						QH += 1.5;
						break;
				}
				
			}
			 double GPA = Math.Round((QH*Grades.Count)/TotalCHours,0);
			Console.WriteLine("---------\n");
            Console.WriteLine("The grades of your courses are : {0}\nThe total number of credit hours: {1}\nYours GPA is : {2}.00\nYour final grade is {3}",GString,TotalCHours,GPA, GPA >= 3.67 ? "EX":GPA >= 3 ? "V.G": GPA>=2.5 ? "G":"FAIL");
		}
		catch (FormatException)
		{
			Console.WriteLine("Error: Invalid input type, Only Numbers are allowed");
		}
		catch (Exception)
		{
			Console.Write("Unknown Error happened");
		}
	}
}