using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A1A")]
public class UIPaymentSpecialStoreItemData
{
	[Token(Token = "0x40102E0")]
	[FieldOffset(Offset = "0x8")]
	public SpecialStoreDesc specialStoreDesc;

	[Token(Token = "0x40102E1")]
	[FieldOffset(Offset = "0xC")]
	public Action<EStore.PbwActivityType> onClick;

	[Token(Token = "0x40102E2")]
	[FieldOffset(Offset = "0x10")]
	public bool hasRedPoint;

	[Token(Token = "0x601107B")]
	[Address(RVA = "0x29DE580", Offset = "0x29DE580", VA = "0x29DE580")]
	public UIPaymentSpecialStoreItemData(SpecialStoreDesc special, bool redPoint = false, [Optional] Action<EStore.PbwActivityType> onClick)
	{
	}
}
