using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036BE")]
public class UIHudNameRedEnvelopeReceiverView : UIBaseView
{
	[Token(Token = "0x4016100")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ThanksLabel;

	[Token(Token = "0x4016101")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LuckyIcon;

	[Token(Token = "0x60167E7")]
	[Address(RVA = "0x1F523B0", Offset = "0x1F523B0", VA = "0x1F523B0")]
	public UIHudNameRedEnvelopeReceiverView()
	{
	}

	[Token(Token = "0x60167E8")]
	[Address(RVA = "0x1F523B8", Offset = "0x1F523B8", VA = "0x1F523B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167E9")]
	[Address(RVA = "0x1F525B4", Offset = "0x1F525B4", VA = "0x1F525B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
