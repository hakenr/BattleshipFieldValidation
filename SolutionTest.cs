using Solution;

namespace BattleshipFieldValidation
{
	[TestFixture]
	public class SolutionTest
	{
		[Test]
		public void TestCase()
		{
			int[,] field1 = new int[10, 10]
						   {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
					  {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
					  {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
					  {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					  {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					  {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
					  {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					  {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
					  {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
					  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
			Assert.IsTrue(BattleshipField.ValidateBattlefield(field1),
					   "Must return True for valid field");

			int[,] field2 = new int[10, 10]
							{{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
					   {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
					   {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
					   {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
					   {0, 1, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
			Assert.IsFalse(BattleshipField.ValidateBattlefield(field2),
					   "Must return False if unwanted ships are present");

			int[,] field3 = new int[10, 10]
							{{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
					   {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
					   {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
					   {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 1, 1, 1, 1, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
			Assert.IsFalse(BattleshipField.ValidateBattlefield(field3),
					   "Must return False if number of ships of some type is incorrect");

			int[,] field4 = new int[10, 10]
							{{0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
					   {0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 1, 0, 1, 1, 1, 0, 1, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
			Assert.IsFalse(BattleshipField.ValidateBattlefield(field4),
					   "Must return False if some of ships is missing");

			int[,] field5 = new int[10, 10]
							{{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
					   {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
					   {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
					   {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
					   {0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
			Assert.IsFalse(BattleshipField.ValidateBattlefield(field5),
					   "Must return False if ships are in contact");

			int[,] field6 = new int[10, 10]
							{{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
					   {1, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {1, 1, 0, 0, 1, 1, 1, 0, 1, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
					   {0, 1, 0, 0, 0, 0, 0, 1, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
			Assert.IsFalse(BattleshipField.ValidateBattlefield(field6),
					   "Must return False if some of ships has incorrect shape (non-straight)");

			int[,] field7 = new int[10, 10]
							{{1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
					   {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
					   {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
					   {1, 0, 1, 0, 0, 0, 0, 0, 0, 0},
					   {0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
					   {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
					   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
			Assert.IsFalse(BattleshipField.ValidateBattlefield(field7),
					   "Must return False if the number and length of ships is not ok");
		}
	}
}