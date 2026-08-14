using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003431")]
public class UIChatRecruitItemView : UIBaseView
{
	[Token(Token = "0x4014306")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4014307")]
	[FieldOffset(Offset = "0x18")]
	public Transform ProfileContainer;

	[Token(Token = "0x4014308")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Mode;

	[Token(Token = "0x4014309")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Tag1;

	[Token(Token = "0x401430A")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Tag2;

	[Token(Token = "0x401430B")]
	[FieldOffset(Offset = "0x28")]
	public UIButton JoinGroupBtn;

	[Token(Token = "0x401430C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject GroupRoot;

	[Token(Token = "0x401430D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite LadderIcon;

	[Token(Token = "0x401430E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Map;

	[Token(Token = "0x401430F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GroupMode;

	[Token(Token = "0x4014310")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ClanSourceIcon;

	[Token(Token = "0x4014311")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ClanGroupRoot;

	[Token(Token = "0x4014312")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid ClanGroupGrid;

	[Token(Token = "0x4014313")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ClanLadderIcon1;

	[Token(Token = "0x4014314")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ClanLadderIcon2;

	[Token(Token = "0x4014315")]
	[FieldOffset(Offset = "0x50")]
	public UISprite ClanGroupIcon;

	[Token(Token = "0x4014316")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ClanGroupName;

	[Token(Token = "0x4014317")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ClanGroupMember;

	[Token(Token = "0x6016047")]
	[Address(RVA = "0x20782E4", Offset = "0x20782E4", VA = "0x20782E4")]
	public UIChatRecruitItemView()
	{
	}

	[Token(Token = "0x6016048")]
	[Address(RVA = "0x20782EC", Offset = "0x20782EC", VA = "0x20782EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016049")]
	[Address(RVA = "0x2078AA8", Offset = "0x2078AA8", VA = "0x2078AA8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
