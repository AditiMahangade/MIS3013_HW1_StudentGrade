// MIS 3013 HW1
// Student Grade
//
string outMesStr = "What is your first name? ";
Console.Write(outMesStr);
string stuFirstNameStr = Console.ReadLine();

outMesStr = "What is your last name? ";
Console.Write(outMesStr);
string stuLastNameStr = Console.ReadLine();

outMesStr = "What is your student id? ";
Console.Write(outMesStr);
string stuIDStr = Console.ReadLine();

outMesStr = "What is the overall percentage for the homework? ";
Console.Write(outMesStr);
string homeworkStr = Console.ReadLine();
double homeworkDb1 = Convert.ToDouble(homeworkStr);

outMesStr = "What is the overall percentage for the exercises? ";
Console.Write(outMesStr);
string exerciseStr = Console.ReadLine();
double exerciseDb1 = Convert.ToDouble(exerciseStr);


outMesStr = "What is the overall percentage for the exam? ";
Console.Write(outMesStr);
string examStr = Console.ReadLine();
double examDb1 = Convert.ToDouble(examStr);

double finalDb1 = homeworkDb1 * 0.24 + exerciseDb1 * 0.4 + examDb1 * 0.36;

// finalDb1 = finalDb1 / 100;

outMesStr = string.Format($"{stuFirstNameStr} {stuLastNameStr} ({stuIDStr}): {finalDb1 / 100:P2}");
Console.WriteLine(outMesStr);

Console.ReadLine();
