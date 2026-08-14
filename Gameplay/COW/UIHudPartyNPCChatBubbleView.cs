using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D1")]
public class UIHudPartyNPCChatBubbleView : UIBaseView
{
	[Token(Token = "0x4016228")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ChatMessageLabel;

	[Token(Token = "0x4016229")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ChatBg;

	[Token(Token = "0x6016820")]
	[Address(RVA = "0x18440C8", Offset = "0x18440C8", VA = "0x18440C8")]
	public UIHudPartyNPCChatBubbleView()
	{
	}

	[Token(Token = "0x6016821")]
	[Address(RVA = "0x18440D0", Offset = "0x18440D0", VA = "0x18440D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016822")]
	[Address(RVA = "0x1844238", Offset = "0x1844238", VA = "0x1844238")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
