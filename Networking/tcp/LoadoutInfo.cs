using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D8A")]
public class LoadoutInfo
{
	[Token(Token = "0x400BA92")]
	[FieldOffset(Offset = "0x8")]
	private uint _003Cloadout_id_003Ek__BackingField;

	[Token(Token = "0x400BA93")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Cloadout_num_003Ek__BackingField;

	[Token(Token = "0x400BA94")]
	[FieldOffset(Offset = "0x10")]
	private bool _003Cis_free_play_003Ek__BackingField;

	[Token(Token = "0x17000D3E")]
	public uint loadout_id
	{
		[Token(Token = "0x6008A32")]
		[Address(RVA = "0x33EC4B0", Offset = "0x33EC4B0", VA = "0x33EC4B0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A33")]
		[Address(RVA = "0x33EC4B8", Offset = "0x33EC4B8", VA = "0x33EC4B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000D3F")]
	public uint loadout_num
	{
		[Token(Token = "0x6008A34")]
		[Address(RVA = "0x33EC4C0", Offset = "0x33EC4C0", VA = "0x33EC4C0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008A35")]
		[Address(RVA = "0x33EC4C8", Offset = "0x33EC4C8", VA = "0x33EC4C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000D40")]
	public bool is_free_play
	{
		[Token(Token = "0x6008A36")]
		[Address(RVA = "0x33EC4D0", Offset = "0x33EC4D0", VA = "0x33EC4D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008A37")]
		[Address(RVA = "0x33EC4D8", Offset = "0x33EC4D8", VA = "0x33EC4D8")]
		set
		{
		}
	}

	[Token(Token = "0x6008A31")]
	[Address(RVA = "0x33EC4A8", Offset = "0x33EC4A8", VA = "0x33EC4A8")]
	public LoadoutInfo()
	{
	}
}
