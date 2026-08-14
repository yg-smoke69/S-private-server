using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003EE5")]
public class UserControlMapping
{
	[Token(Token = "0x401A917")]
	[FieldOffset(Offset = "0x8")]
	private string[] m_KeyMapping;

	[Token(Token = "0x60199F1")]
	[Address(RVA = "0x2BD00F4", Offset = "0x2BD00F4", VA = "0x2BD00F4")]
	public UserControlMapping()
	{
	}

	[Token(Token = "0x60199F2")]
	[Address(RVA = "0x2BD2210", Offset = "0x2BD2210", VA = "0x2BD2210")]
	public string GetKeyDesc(int key)
	{
		return null;
	}
}
