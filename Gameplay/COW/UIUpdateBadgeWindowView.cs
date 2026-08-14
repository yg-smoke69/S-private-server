using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A4C")]
public class UIUpdateBadgeWindowView : UIBaseView
{
	[Token(Token = "0x4018A46")]
	[FieldOffset(Offset = "0x14")]
	public UILabel BadgeNameLabel;

	[Token(Token = "0x4018A47")]
	[FieldOffset(Offset = "0x18")]
	public UILabel BadgeInfoLabel;

	[Token(Token = "0x4018A48")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton UpdateClanBadgeBtn;

	[Token(Token = "0x4018A49")]
	[FieldOffset(Offset = "0x20")]
	public UILabel BadgeStateLabel;

	[Token(Token = "0x4018A4A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton UnlockBtn;

	[Token(Token = "0x4018A4B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ChangeBadgeBG;

	[Token(Token = "0x4018A4C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LockBtn;

	[Token(Token = "0x4018A4D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Center;

	[Token(Token = "0x4018A4E")]
	[FieldOffset(Offset = "0x34")]
	public UISprite Gift;

	[Token(Token = "0x4018A4F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ItemCountLabel;

	[Token(Token = "0x4018A50")]
	[FieldOffset(Offset = "0x3C")]
	public UIPanel ScrollView;

	[Token(Token = "0x4018A51")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid BadgelGrid;

	[Token(Token = "0x4018A52")]
	[FieldOffset(Offset = "0x44")]
	public UICustomSortTable table;

	[Token(Token = "0x4018A53")]
	[FieldOffset(Offset = "0x48")]
	public UIToggleButtonGroup ModeBtnGroup;

	[Token(Token = "0x601728A")]
	[Address(RVA = "0xF56B48", Offset = "0xF56B48", VA = "0xF56B48")]
	public UIUpdateBadgeWindowView()
	{
	}

	[Token(Token = "0x601728B")]
	[Address(RVA = "0xF56B50", Offset = "0xF56B50", VA = "0xF56B50", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601728C")]
	[Address(RVA = "0xF571C0", Offset = "0xF571C0", VA = "0xF571C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
