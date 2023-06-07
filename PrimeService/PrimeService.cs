namespace Prime.Services;
/// <summary>
/// 素数を扱うサービスクラス。
/// </summary>
public class PrimeService
{
	/// <summary>
	/// 渡された数字が素数か否かを判断し、素数ならtrueを返す。
	/// </summary>
	/// <param name="candidate">素数か否か判断したい数字</param>
	/// <returns>素数ならtrue、そうでないならfalse</returns>
	public bool IsPrime(int candidate)
	{
		if (candidate < 2)
		{
			return false;
		}

		throw new NotImplementedException("Not fully implemented.");
	}
}
