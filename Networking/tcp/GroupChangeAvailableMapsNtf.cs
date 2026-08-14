using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CF0")]
public class GroupChangeAvailableMapsNtf
{
	[Token(Token = "0x400B73D")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B73E")]
	[FieldOffset(Offset = "0x10")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x17000BA4")]
	public ulong account_id
	{
		[Token(Token = "0x6008693")]
		[Address(RVA = "0x33EA268", Offset = "0x33EA268", VA = "0x33EA268")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008694")]
		[Address(RVA = "0x33EA270", Offset = "0x33EA270", VA = "0x33EA270")]
		set
		{
		}
	}

	[Token(Token = "0x17000BA5")]
	public uint[] available_maps
	{
		[Token(Token = "0x6008695")]
		[Address(RVA = "0x33EA280", Offset = "0x33EA280", VA = "0x33EA280")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008696")]
		[Address(RVA = "0x33EA288", Offset = "0x33EA288", VA = "0x33EA288")]
		set
		{
		}
	}

	[Token(Token = "0x6008692")]
	[Address(RVA = "0x33EA260", Offset = "0x33EA260", VA = "0x33EA260")]
	public GroupChangeAvailableMapsNtf()
	{
	}
}
