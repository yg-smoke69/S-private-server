using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2004022")]
public class UniqueIDGenerator
{
	[Token(Token = "0x401AFDD")]
	[FieldOffset(Offset = "0x0")]
	public static uint INVALID_ID;

	[Token(Token = "0x401AFDE")]
	[FieldOffset(Offset = "0x8")]
	private uint m_NextID;

	[Token(Token = "0x601A1DA")]
	[Address(RVA = "0x2BC5458", Offset = "0x2BC5458", VA = "0x2BC5458")]
	public UniqueIDGenerator()
	{
	}

	[Token(Token = "0x601A1DB")]
	[Address(RVA = "0x2BC5460", Offset = "0x2BC5460", VA = "0x2BC5460")]
	public uint GetUniqueID()
	{
		return default(uint);
	}

	[Token(Token = "0x601A1DC")]
	[Address(RVA = "0x2BC5480", Offset = "0x2BC5480", VA = "0x2BC5480")]
	public void SetInitID(uint value)
	{
	}
}
