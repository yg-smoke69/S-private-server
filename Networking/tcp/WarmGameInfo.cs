using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D97")]
public class WarmGameInfo
{
	[Token(Token = "0x400BAB8")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ctype_003Ek__BackingField;

	[Token(Token = "0x400BAB9")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Clevel_003Ek__BackingField;

	[Token(Token = "0x17000D64")]
	public uint type
	{
		[Token(Token = "0x6008A8B")]
		[Address(RVA = "0x435FEB4", Offset = "0x435FEB4", VA = "0x435FEB4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A8C")]
		[Address(RVA = "0x435FEBC", Offset = "0x435FEBC", VA = "0x435FEBC")]
		set
		{
		}
	}

	[Token(Token = "0x17000D65")]
	public uint level
	{
		[Token(Token = "0x6008A8D")]
		[Address(RVA = "0x435FEC4", Offset = "0x435FEC4", VA = "0x435FEC4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A8E")]
		[Address(RVA = "0x435FECC", Offset = "0x435FECC", VA = "0x435FECC")]
		set
		{
		}
	}

	[Token(Token = "0x6008A8A")]
	[Address(RVA = "0x435FEAC", Offset = "0x435FEAC", VA = "0x435FEAC")]
	public WarmGameInfo()
	{
	}
}
