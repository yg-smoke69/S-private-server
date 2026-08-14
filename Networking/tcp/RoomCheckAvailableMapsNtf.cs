using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D72")]
public class RoomCheckAvailableMapsNtf
{
	[Token(Token = "0x400B9EF")]
	[FieldOffset(Offset = "0x8")]
	private ulong[] _003Cinvalid_map_member_ids_003Ek__BackingField;

	[Token(Token = "0x400B9F0")]
	[FieldOffset(Offset = "0xC")]
	private ulong[] _003Cinvalid_map_spectator_ids_003Ek__BackingField;

	[Token(Token = "0x17000D2F")]
	public ulong[] invalid_map_member_ids
	{
		[Token(Token = "0x6008A08")]
		[Address(RVA = "0x435DB54", Offset = "0x435DB54", VA = "0x435DB54")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A09")]
		[Address(RVA = "0x435DB5C", Offset = "0x435DB5C", VA = "0x435DB5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D30")]
	public ulong[] invalid_map_spectator_ids
	{
		[Token(Token = "0x6008A0A")]
		[Address(RVA = "0x435DB64", Offset = "0x435DB64", VA = "0x435DB64")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A0B")]
		[Address(RVA = "0x435DB6C", Offset = "0x435DB6C", VA = "0x435DB6C")]
		set
		{
		}
	}

	[Token(Token = "0x6008A07")]
	[Address(RVA = "0x435DB4C", Offset = "0x435DB4C", VA = "0x435DB4C")]
	public RoomCheckAvailableMapsNtf()
	{
	}
}
