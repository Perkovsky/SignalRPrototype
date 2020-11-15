namespace Server.Models
{
	public class DashboardModel
	{
		public int C1 { get; set; }
		public int C2 { get; set; }
		public int C3 { get; set; }
		public string Uuid { get; set; }

		public override string ToString()
		{
			return $"{nameof(C1)}: {C1}, {nameof(C2)}: {C2}, {nameof(C3)}: {C3}, {nameof(Uuid)}: {Uuid}.";
		}
	}
}
