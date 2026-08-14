using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B9D")]
public class EventBlockDefine : ProcessBlockDefine
{
	[Token(Token = "0x40061F9")]
	[FieldOffset(Offset = "0x24")]
	public LCIPBALGMFC eventType;

	[Token(Token = "0x600581A")]
	[Address(RVA = "0x37AEC90", Offset = "0x37AEC90", VA = "0x37AEC90")]
	public EventBlockDefine()
	{
	}

	[Token(Token = "0x600581B")]
	[Address(RVA = "0x37BDE38", Offset = "0x37BDE38", VA = "0x37BDE38", Slot = "4")]
	public override bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x600581C")]
	[Address(RVA = "0x37BDF74", Offset = "0x37BDF74", VA = "0x37BDF74")]
	public new bool _003C_003EiFixBaseProxy_FromJsonData(BlockEditContext P0, JsonData P1)
	{
		return default(bool);
	}
}
