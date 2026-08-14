using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003970")]
public class UIRoomPopMenuView : UIBaseView
{
	[Token(Token = "0x40180DE")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WindowPanel;

	[Token(Token = "0x40180DF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Mask;

	[Token(Token = "0x40180E0")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget Container;

	[Token(Token = "0x40180E1")]
	[FieldOffset(Offset = "0x20")]
	public UISprite PlayerInfoPanel;

	[Token(Token = "0x40180E2")]
	[FieldOffset(Offset = "0x24")]
	public UIEffectSprite Portrait;

	[Token(Token = "0x40180E3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FakeHead;

	[Token(Token = "0x40180E4")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton AddBtn;

	[Token(Token = "0x40180E5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject NamePos;

	[Token(Token = "0x40180E6")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Name;

	[Token(Token = "0x40180E7")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid ItemGrid;

	[Token(Token = "0x6016FF7")]
	[Address(RVA = "0x2BE7F98", Offset = "0x2BE7F98", VA = "0x2BE7F98")]
	public UIRoomPopMenuView()
	{
	}

	[Token(Token = "0x6016FF8")]
	[Address(RVA = "0x2BE7FA0", Offset = "0x2BE7FA0", VA = "0x2BE7FA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FF9")]
	[Address(RVA = "0x2BE8490", Offset = "0x2BE8490", VA = "0x2BE8490")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
