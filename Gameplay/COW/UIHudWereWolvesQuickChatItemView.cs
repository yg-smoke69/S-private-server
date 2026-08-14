using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D6")]
public class UIHudWereWolvesQuickChatItemView : UIBaseView
{
	[Token(Token = "0x4016A53")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnItem;

	[Token(Token = "0x4016A54")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ContentLabel;

	[Token(Token = "0x6016B2D")]
	[Address(RVA = "0x256BE00", Offset = "0x256BE00", VA = "0x256BE00")]
	public UIHudWereWolvesQuickChatItemView()
	{
	}

	[Token(Token = "0x6016B2E")]
	[Address(RVA = "0x256BE08", Offset = "0x256BE08", VA = "0x256BE08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B2F")]
	[Address(RVA = "0x256C010", Offset = "0x256C010", VA = "0x256C010")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
