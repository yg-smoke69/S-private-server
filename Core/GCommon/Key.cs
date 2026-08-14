using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040B1")]
public class Key
{
	[Token(Token = "0x401B2D3")]
	[FieldOffset(Offset = "0x0")]
	private static byte[] m_InitVectorKeys;

	[Token(Token = "0x401B2D4")]
	[FieldOffset(Offset = "0x4")]
	private static string m_Keys;

	[Token(Token = "0x17001CD0")]
	public static byte[] InitVectorKeys
	{
		[Token(Token = "0x601A53B")]
		[Address(RVA = "0x32BC624", Offset = "0x32BC624", VA = "0x32BC624")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001CD1")]
	public static byte[] Keys
	{
		[Token(Token = "0x601A53C")]
		[Address(RVA = "0x32BC6B0", Offset = "0x32BC6B0", VA = "0x32BC6B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A53A")]
	[Address(RVA = "0x32BC61C", Offset = "0x32BC61C", VA = "0x32BC61C")]
	public Key()
	{
	}
}
