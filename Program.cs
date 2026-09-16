// Console.WriteLine($"Компьютер: {Environment.MachineName}");
// Console.WriteLine($"Пользователь: {Environment.UserName}");
// Console.WriteLine($"Дата и время: {DateTime.Now:dd.MM.yyyy HH:mm}");


// Console.WriteLine();
// Console.WriteLine($"OC: {Environment.OSVersion}");
// Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");

// Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}");

// Console.WriteLine($"WorkingSet: {Environment.WorkingSet} байт");
// Console.WriteLine($"WorkingSet: {Environment.WorkingSet / 1024 / 1024} МБ");

using System.Diagnostics;

Console.WriteLine("МИНИ-МОНИТОР СИСТЕМЫ\n");

Console.WriteLine($"Компьютер: {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"ОС: {Environment.OSVersion}");
Console.WriteLine($"64-битная ОС: {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"Логических процессоров: {Environment.ProcessorCount}\n");

Process currentProcess = Process.GetCurrentProcess();

Console.WriteLine($"PID процесса: {currentProcess.Id}\n");
Console.WriteLine("Память процесса:");
Console.WriteLine($"WorkingSet64: {currentProcess.WorkingSet64 / 1024 / 1024} МБ");

Console.WriteLine("\nОбновите окно через несколько секунд...");
Console.ReadLine();

currentProcess.Refresh();
Console.WriteLine($"WorkingSet64 (2-е измерение): {currentProcess.WorkingSet64 / 1024 / 1024} МБ");