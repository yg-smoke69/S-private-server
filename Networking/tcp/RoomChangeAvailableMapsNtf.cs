using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D6B")]
public class RoomChangeAvailableMapsNtf
{
	[Token(Token = "0x400B9E5")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B9E6")]
	[FieldOffset(Offset = "0x10")]
	private uint[] _003Cavailable_maps_003Ek__BackingField;

	[Token(Token = "0x400B9E7")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003Croom_id_003Ek__BackingField;

	[Token(Token = "0x17000D25")]
	public ulong account_id
	{
		[Token(Token = "0x60089ED")]
		[Address(RVA = "0x435D8F8", Offset = "0x435D8F8", VA = "0x435D8F8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60089EE")]
		[Address(RVA = "0x435D900", Offset = "0x435D900", VA = "0x435D900")]
		set
		{
		}
	}

	[Token(Token = "0x17000D26")]
	public uint[] available_maps
	{
		[Token(Token = "0x60089EF")]
		[Address(RVA = "0x435D910", Offset = "0x435D910", VA = "0x435D910")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089F0")]
		[Address(RVA = "0x435D918", Offset = "0x435D918", VA = "0x435D918")]
		set
		{
		}
	}

	[Token(Token = "0x17000D27")]
	public ulong room_id
	{
		[Token(Token = "0x60089F1")]
		[Address(RVA = "0x435D920", Offset = "0x435D920", VA = "0x435D920")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60089F2")]
		[Address(RVA = "0x435D928", Offset = "0x435D928", VA = "0x435D928")]
		set
		{
		}
	}

	[Token(Token = "0x60089EC")]
	[Address(RVA = "0x435D8F0", Offset = "0x435D8F0", VA = "0x435D8F0")]
	public RoomChangeAvailableMapsNtf()
	{
	}
}
