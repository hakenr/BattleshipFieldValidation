using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Solution;

public static class BattleshipField
{
	public static bool ValidateBattlefield(int[,] field)
	{
		List<List<Point>> ships = new();

		// najdi lodě
		for (int i = 0; i < field.GetLength(0); i++)
		{
			for (int j = 0; j < field.GetLength(1); j++)
			{
				if (field[i, j] != 1)
				{
					continue;
				}

				var shipTouched = ships.FirstOrDefault(ship =>
											ship.Any(p => Math.Abs(p.X - i) < 2 && Math.Abs(p.Y - j) < 2));
				if (shipTouched != null)
				{
					shipTouched.Add(new Point(i, j));
				}
				else
				{
					ships.Add(new List<Point>() { new Point(i, j) });
				}
			}
		}

		// lodí musí být 10
		if (ships.Count != 10)
		{
			return false;
		}

		// vezmi lodě podle velikosti
		var groups = ships.GroupBy(ship => ship.Count).OrderByDescending(x => x.Count()).ToList();

		// musí být 4 lodě velikosti 1, 3 lodě velikosti 2, 2 lodě velikosti 3 a 1 loď velikosti 4
		if (groups.Count != 4 || groups.Last().Key != 4)
		{
			return false;
		}

		// lodě musí být jen horizontální/vertikální
		for (int i = 0; i < ships.Count; i++)
		{
			if (!ships[i].All(p => p.X == ships[i].First().X)
				&& !ships[i].All(p => p.Y == ships[i].First().Y))
			{
				return false;
			}
		}

		return true;
	}
}