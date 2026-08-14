using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016AC")]
public class CSUpdateAuthOfInspectReq
{
	[Token(Token = "0x40096BE")]
	[FieldOffset(Offset = "0x8")]
	public bool is_visible;

	[Token(Token = "0x40096BF")]
	[FieldOffset(Offset = "0xC")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x6007D0D")]
	[Address(RVA = "0x309A620", Offset = "0x309A620", VA = "0x309A620")]
	public CSUpdateAuthOfInspectReq()
	{
	}
}
