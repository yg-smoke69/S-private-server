using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D63")]
public class RoomSetReadyReq
{
	[Token(Token = "0x400B98C")]
	[FieldOffset(Offset = "0x8")]
	private bool _003Cready_003Ek__BackingField;

	[Token(Token = "0x400B98D")]
	[FieldOffset(Offset = "0x9")]
	private bool _003Cset_group_003Ek__BackingField;

	[Token(Token = "0x17000CCC")]
	public bool ready
	{
		[Token(Token = "0x6008933")]
		[Address(RVA = "0x435ECD0", Offset = "0x435ECD0", VA = "0x435ECD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008934")]
		[Address(RVA = "0x435ECD8", Offset = "0x435ECD8", VA = "0x435ECD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000CCD")]
	public bool set_group
	{
		[Token(Token = "0x6008935")]
		[Address(RVA = "0x435ECE0", Offset = "0x435ECE0", VA = "0x435ECE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008936")]
		[Address(RVA = "0x435ECE8", Offset = "0x435ECE8", VA = "0x435ECE8")]
		set
		{
		}
	}

	[Token(Token = "0x6008932")]
	[Address(RVA = "0x435ECC8", Offset = "0x435ECC8", VA = "0x435ECC8")]
	public RoomSetReadyReq()
	{
	}
}
