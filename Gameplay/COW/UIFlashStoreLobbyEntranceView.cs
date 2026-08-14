using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200353A")]
public class UIFlashStoreLobbyEntranceView : UIBaseView
{
	[Token(Token = "0x40150CB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton EntranceBtn;

	[Token(Token = "0x40150CC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NormalTipsGroup;

	[Token(Token = "0x40150CD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NewTipsGroup;

	[Token(Token = "0x40150CE")]
	[FieldOffset(Offset = "0x20")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x40150CF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject IntroGroup;

	[Token(Token = "0x40150D0")]
	[FieldOffset(Offset = "0x28")]
	public UICenterTargetHelper CenterHelper;

	[Token(Token = "0x40150D1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DialogueBubbleLabel;

	[Token(Token = "0x601635E")]
	[Address(RVA = "0x1B4FE3C", Offset = "0x1B4FE3C", VA = "0x1B4FE3C")]
	public UIFlashStoreLobbyEntranceView()
	{
	}

	[Token(Token = "0x601635F")]
	[Address(RVA = "0x1B4FE44", Offset = "0x1B4FE44", VA = "0x1B4FE44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016360")]
	[Address(RVA = "0x1B50208", Offset = "0x1B50208", VA = "0x1B50208")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
