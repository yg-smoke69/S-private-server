using GarenaMSDK;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D7B")]
public class PaymentAction
{
	[Token(Token = "0x401173A")]
	[FieldOffset(Offset = "0x8")]
	public SDKIAPTaskInfo Info;

	[Token(Token = "0x401173B")]
	[FieldOffset(Offset = "0xC")]
	public string ProductIdentifier;

	[Token(Token = "0x401173C")]
	[FieldOffset(Offset = "0x10")]
	public bool IsFirstTime;

	[Token(Token = "0x401173D")]
	[FieldOffset(Offset = "0x14")]
	public int Quantity;

	[Token(Token = "0x401173E")]
	[FieldOffset(Offset = "0x18")]
	public long RebateID;

	[Token(Token = "0x401173F")]
	[FieldOffset(Offset = "0x20")]
	public bool Event;

	[Token(Token = "0x4011740")]
	[FieldOffset(Offset = "0x28")]
	public long EventId;

	[Token(Token = "0x60130A5")]
	[Address(RVA = "0x2DD1998", Offset = "0x2DD1998", VA = "0x2DD1998")]
	public PaymentAction()
	{
	}
}
