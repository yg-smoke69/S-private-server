using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035DA")]
public class UIHudAssistantTextView : UIBaseView
{
	[Token(Token = "0x40158ED")]
	[FieldOffset(Offset = "0x14")]
	public UILabel NameLabel;

	[Token(Token = "0x40158EE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel AssistantLabel;

	[Token(Token = "0x601653C")]
	[Address(RVA = "0x170B480", Offset = "0x170B480", VA = "0x170B480")]
	public UIHudAssistantTextView()
	{
	}

	[Token(Token = "0x601653D")]
	[Address(RVA = "0x170B488", Offset = "0x170B488", VA = "0x170B488", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601653E")]
	[Address(RVA = "0x170B690", Offset = "0x170B690", VA = "0x170B690")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
