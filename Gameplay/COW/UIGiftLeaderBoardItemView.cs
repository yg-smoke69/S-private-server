using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035AF")]
public class UIGiftLeaderBoardItemView : UIBaseView
{
	[Token(Token = "0x4015726")]
	[FieldOffset(Offset = "0x14")]
	public UIButton itembtn;

	[Token(Token = "0x4015727")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Rank;

	[Token(Token = "0x4015728")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Rank_self;

	[Token(Token = "0x4015729")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CupIcon;

	[Token(Token = "0x401572A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BaseProfile;

	[Token(Token = "0x401572B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Count;

	[Token(Token = "0x401572C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BgTop;

	[Token(Token = "0x401572D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BelowBGTop;

	[Token(Token = "0x401572E")]
	[FieldOffset(Offset = "0x34")]
	public UISprite BgOther;

	[Token(Token = "0x60164BB")]
	[Address(RVA = "0x1CEA3A4", Offset = "0x1CEA3A4", VA = "0x1CEA3A4")]
	public UIGiftLeaderBoardItemView()
	{
	}

	[Token(Token = "0x60164BC")]
	[Address(RVA = "0x1CEA3AC", Offset = "0x1CEA3AC", VA = "0x1CEA3AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164BD")]
	[Address(RVA = "0x1CEA83C", Offset = "0x1CEA83C", VA = "0x1CEA83C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
