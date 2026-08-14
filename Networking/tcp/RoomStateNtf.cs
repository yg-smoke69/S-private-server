using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D5D")]
public class RoomStateNtf
{
	[Token(Token = "0x400B974")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x400B975")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cstate_003Ek__BackingField;

	[Token(Token = "0x17000CB4")]
	public ulong room_id
	{
		[Token(Token = "0x60088FD")]
		[Address(RVA = "0x435EEB0", Offset = "0x435EEB0", VA = "0x435EEB0")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60088FE")]
		[Address(RVA = "0x435EEB8", Offset = "0x435EEB8", VA = "0x435EEB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000CB5")]
	public uint state
	{
		[Token(Token = "0x60088FF")]
		[Address(RVA = "0x435EEC8", Offset = "0x435EEC8", VA = "0x435EEC8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008900")]
		[Address(RVA = "0x435EED0", Offset = "0x435EED0", VA = "0x435EED0")]
		set
		{
		}
	}

	[Token(Token = "0x60088FC")]
	[Address(RVA = "0x435EEA8", Offset = "0x435EEA8", VA = "0x435EEA8")]
	public RoomStateNtf()
	{
	}
}
