using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003881")]
public class UIManualMapEvtItemView : UIBaseView
{
	[Token(Token = "0x40174D8")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIManualMapEvtItem;

	[Token(Token = "0x40174D9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x40174DA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Desc;

	[Token(Token = "0x40174DB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Icon;

	[Token(Token = "0x40174DC")]
	[FieldOffset(Offset = "0x24")]
	public UILabel QuestionLabel;

	[Token(Token = "0x40174DD")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnMore;

	[Token(Token = "0x40174DE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Tag;

	[Token(Token = "0x6016D2E")]
	[Address(RVA = "0x2C3C3A8", Offset = "0x2C3C3A8", VA = "0x2C3C3A8")]
	public UIManualMapEvtItemView()
	{
	}

	[Token(Token = "0x6016D2F")]
	[Address(RVA = "0x2C3C3B0", Offset = "0x2C3C3B0", VA = "0x2C3C3B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D30")]
	[Address(RVA = "0x2C3C78C", Offset = "0x2C3C78C", VA = "0x2C3C78C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
