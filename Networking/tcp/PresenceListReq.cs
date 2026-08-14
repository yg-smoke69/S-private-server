using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D39")]
public class PresenceListReq
{
	[Token(Token = "0x400B862")]
	[FieldOffset(Offset = "0x8")]
	private ulong[] _003Caccount_ids_003Ek__BackingField;

	[Token(Token = "0x400B863")]
	[FieldOffset(Offset = "0xC")]
	private uint _003Caccount_list_type_003Ek__BackingField;

	[Token(Token = "0x17000C3C")]
	public ulong[] account_ids
	{
		[Token(Token = "0x60087F5")]
		[Address(RVA = "0x435CF08", Offset = "0x435CF08", VA = "0x435CF08")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087F6")]
		[Address(RVA = "0x435CF10", Offset = "0x435CF10", VA = "0x435CF10")]
		set
		{
		}
	}

	[Token(Token = "0x17000C3D")]
	public uint account_list_type
	{
		[Token(Token = "0x60087F7")]
		[Address(RVA = "0x435CF18", Offset = "0x435CF18", VA = "0x435CF18")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60087F8")]
		[Address(RVA = "0x435CF20", Offset = "0x435CF20", VA = "0x435CF20")]
		set
		{
		}
	}

	[Token(Token = "0x60087F4")]
	[Address(RVA = "0x435CF00", Offset = "0x435CF00", VA = "0x435CF00")]
	public PresenceListReq()
	{
	}
}
