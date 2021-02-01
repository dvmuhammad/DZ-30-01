using System;

namespace zadaniya1
{
	
	class DocumentWorker
	{
		public virtual void OpenDocument()
		{
			Console.WriteLine("Документ открыт");
		}

		public virtual void EditDocument()
		{
			Console.WriteLine("Редактирование документа доступно в версии Про");
		}

		public virtual void SaveDocument()
		{
			Console.WriteLine("Сохранение документа доступно в версии Про");
		}
	}

	class ProDocumentWorker : DocumentWorker
	{
		public override void EditDocument()
		{
			Console.WriteLine("Документ отредактирован");
		}

		public override void SaveDocument()
		{
			Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
		}
	}

	class ExpertDocumentWorker : ProDocumentWorker
	{
		public override void SaveDocument()
		{
			Console.WriteLine("Документ сохранен в новом формате");
		}
	}
	class Program
	{
		private const string pro = "777";
		private const string exp = "888";

		static void Main(string[] args)
		{
			
			Console.WriteLine("Введите ключ:");
			var klych = Console.ReadLine();


			DocumentWorker worker;
			switch (klych)
			{
				case pro: worker = new ProDocumentWorker(); break;
				case exp: worker = new ExpertDocumentWorker(); break;
				default: worker = new DocumentWorker(); break;
			}


			while (true)
			{
				Console.WriteLine("Команды  (o/e/s/q): ");
				switch (Console.ReadLine())
				{
					case "o": worker.OpenDocument(); break;
					case "e": worker.EditDocument(); break;
					case "s": worker.SaveDocument(); break;
					case "q": return;
				}
			}
		}
	}

}