using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D8B")]
public class RoomCardInfo
{
	[Token(Token = "0x400BA95")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cid_003Ek__BackingField;

	[Token(Token = "0x400BA96")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Ccnt_003Ek__BackingField;

	[Token(Token = "0x400BA97")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cexpire_time_003Ek__BackingField;

	[Token(Token = "0x17000D41")]
	public uint id
	{
		[Token(Token = "0x6008A39")]
		[Address(RVA = "0x435D8C0", Offset = "0x435D8C0", VA = "0x435D8C0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A3A")]
		[Address(RVA = "0x435D8C8", Offset = "0x435D8C8", VA = "0x435D8C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000D42")]
	public uint cnt
	{
		[Token(Token = "0x6008A3B")]
		[Address(RVA = "0x435D8D0", Offset = "0x435D8D0", VA = "0x435D8D0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A3C")]
		[Address(RVA = "0x435D8D8", Offset = "0x435D8D8", VA = "0x435D8D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000D43")]
	public uint expire_time
	{
		[Token(Token = "0x6008A3D")]
		[Address(RVA = "0x435D8E0", Offset = "0x435D8E0", VA = "0x435D8E0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A3E")]
		[Address(RVA = "0x435D8E8", Offset = "0x435D8E8", VA = "0x435D8E8")]
		set
		{
		}
	}

	[Token(Token = "0x6008A38")]
	[Address(RVA = "0x435D8B8", Offset = "0x435D8B8", VA = "0x435D8B8")]
	public RoomCardInfo()
	{
	}
}
