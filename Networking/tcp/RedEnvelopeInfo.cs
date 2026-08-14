using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D8D")]
public class RedEnvelopeInfo
{
	[Token(Token = "0x400BA9A")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400BA9B")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccnt_003Ek__BackingField;

	[Token(Token = "0x400BA9C")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cexpire_time_003Ek__BackingField;

	[Token(Token = "0x17000D46")]
	public uint id
	{
		[Token(Token = "0x6008A45")]
		[Address(RVA = "0x435D134", Offset = "0x435D134", VA = "0x435D134")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A46")]
		[Address(RVA = "0x435D13C", Offset = "0x435D13C", VA = "0x435D13C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D47")]
	public uint cnt
	{
		[Token(Token = "0x6008A47")]
		[Address(RVA = "0x435D144", Offset = "0x435D144", VA = "0x435D144")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A48")]
		[Address(RVA = "0x435D14C", Offset = "0x435D14C", VA = "0x435D14C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D48")]
	public uint expire_time
	{
		[Token(Token = "0x6008A49")]
		[Address(RVA = "0x435D154", Offset = "0x435D154", VA = "0x435D154")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A4A")]
		[Address(RVA = "0x435D15C", Offset = "0x435D15C", VA = "0x435D15C")]
		set
		{
		}
	}

	[Token(Token = "0x6008A44")]
	[Address(RVA = "0x435D12C", Offset = "0x435D12C", VA = "0x435D12C")]
	public RedEnvelopeInfo()
	{
	}
}
