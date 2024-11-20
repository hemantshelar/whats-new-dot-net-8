namespace whats_new_dot_net_8.Models
{
	public class Product(int id, string name)
	{
		public int Id { get { return id; } }
		public string Name { get; set; } = name;
	}
}
