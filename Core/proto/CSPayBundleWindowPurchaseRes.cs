using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001743")]
public class CSPayBundleWindowPurchaseRes
{
	[Token(Token = "0x40099BD")]
	[FieldOffset(Offset = "0x8")]
	public List<AwardDesc> awards;

	[Token(Token = "0x40099BE")]
	[FieldOffset(Offset = "0xC")]
	public uint purchase_times;

	[Token(Token = "0x40099BF")]
	[FieldOffset(Offset = "0x10")]
	public EStore.RebateCardBillStatus status;

	[Token(Token = "0x40099C0")]
	[FieldOffset(Offset = "0x14")]
	public uint id;

	[Token(Token = "0x6007D9D")]
	[Address(RVA = "0x30983D4", Offset = "0x30983D4", VA = "0x30983D4")]
	public CSPayBundleWindowPurchaseRes()
	{
	}
}
