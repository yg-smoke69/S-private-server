using Il2CppDummyDll;

namespace TsiU;

[Token(Token = "0x2003C34")]
public class TAny
{
	[Token(Token = "0x6018061")]
	[Address(RVA = "0x263F5E0", Offset = "0x263F5E0", VA = "0x263F5E0")]
	public TAny()
	{
	}

	[Token(Token = "0x6018062")]
	public T As<T>() where T : TAny
	{
		return null;
	}
}
