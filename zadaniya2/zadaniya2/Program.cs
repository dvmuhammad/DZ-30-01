using System;

namespace zadaniya2
{
	interface IPlayable
	{
		void Play();
		void Pause();
		void Stop();
	}

	interface IRecodable
	{
		void Play();
		void Pause();
		void Stop();
	}

	class Player : IPlayable
	{
		public void Play()
		{
			Console.WriteLine("IPlayable.Play");
		}
		public void Pause()
		{
			Console.WriteLine("IPlayable.Pause");
		}
		public void Stop()
		{
			Console.WriteLine("IPlayable.Stop");
		}
	}

	class Players : IRecodable
	{
		public void Play()
		{
			Console.WriteLine("IRecodable.Play");
		}
		public void Pause()
		{
			Console.WriteLine("IRecodable.Pause");
		}
		public void Stop()
		{
			Console.WriteLine("IRecodable.Stop");
		}
		
	}

	class MainClass
	{
		static void Action(IPlayable movable)
		{
			movable.Play();
			movable.Pause();
			movable.Stop();
		}
		static void action(IRecodable Movable)
		{
			Movable.Play();
			Movable.Pause();
			Movable.Stop();
		}
		public static void Main(string[] args)
		{
			Player player = new Player();
			Action(player);
			Players players = new Players();
			action(players);
			Console.ReadKey();
			
		}
	}
}
