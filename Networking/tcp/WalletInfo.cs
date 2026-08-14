using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D92")]
public class WalletInfo
{
	[Token(Token = "0x400BAA8")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Ccoins_003Ek__BackingField;

	[Token(Token = "0x400BAA9")]
	[FieldOffset(Offset = "0xC")]
	private int _003Cgems_003Ek__BackingField;

	[Token(Token = "0x17000D54")]
	public uint coins
	{
		[Token(Token = "0x6008A66")]
		[Address(RVA = "0x435FE8C", Offset = "0x435FE8C", VA = "0x435FE8C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A67")]
		[Address(RVA = "0x435FE94", Offset = "0x435FE94", VA = "0x435FE94")]
		set
		{
		}
	}

	[Token(Token = "0x17000D55")]
	public int gems
	{
		[Token(Token = "0x6008A68")]
		[Address(RVA = "0x435FE9C", Offset = "0x435FE9C", VA = "0x435FE9C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008A69")]
		[Address(RVA = "0x435FEA4", Offset = "0x435FEA4", VA = "0x435FEA4")]
		set
		{
		}
	}

	[Token(Token = "0x6008A65")]
	[Address(RVA = "0x435FE84", Offset = "0x435FE84", VA = "0x435FE84")]
	public WalletInfo()
	{
	}
}
