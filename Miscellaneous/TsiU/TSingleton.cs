using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C39")]
public class TSingleton<T> where T : class, new()
{
	[Token(Token = "0x4019A2A")]
	[FieldOffset(Offset = "0x0")]
	private static T _instance;

	[Token(Token = "0x17001976")]
	public static T instance
	{
		[Token(Token = "0x6018070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601806F")]
	public TSingleton()
	{
	}
}
