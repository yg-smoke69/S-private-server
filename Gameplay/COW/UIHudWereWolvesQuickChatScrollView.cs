using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D7")]
public class UIHudWereWolvesQuickChatScrollView : UIBaseView
{
	[Token(Token = "0x4016A55")]
	[FieldOffset(Offset = "0x14")]
	public UIButton bgmask;

	[Token(Token = "0x4016A56")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList QuickChatEasyList;

	[Token(Token = "0x6016B30")]
	[Address(RVA = "0x256CD4C", Offset = "0x256CD4C", VA = "0x256CD4C")]
	public UIHudWereWolvesQuickChatScrollView()
	{
	}

	[Token(Token = "0x6016B31")]
	[Address(RVA = "0x256CD54", Offset = "0x256CD54", VA = "0x256CD54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B32")]
	[Address(RVA = "0x256CF5C", Offset = "0x256CF5C", VA = "0x256CF5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
