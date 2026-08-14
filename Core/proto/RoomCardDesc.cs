using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F6")]
public class RoomCardDesc
{
	[Token(Token = "0x400A2FC")]
	[FieldOffset(Offset = "0x8")]
	public uint card_id;

	[Token(Token = "0x400A2FD")]
	[FieldOffset(Offset = "0xC")]
	public ERoom.CardType card_type;

	[Token(Token = "0x600804E")]
	[Address(RVA = "0x33E1C00", Offset = "0x33E1C00", VA = "0x33E1C00")]
	public RoomCardDesc()
	{
	}
}
