using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C0")]
public class UIHistoryRecordItemView : UIBaseView
{
	[Token(Token = "0x4015834")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ColorBg;

	[Token(Token = "0x4015835")]
	[FieldOffset(Offset = "0x18")]
	public UILabel GameModeLabel;

	[Token(Token = "0x4015836")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject GroupHCN;

	[Token(Token = "0x4015837")]
	[FieldOffset(Offset = "0x20")]
	public UILabel GroupNum;

	[Token(Token = "0x4015838")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Kill;

	[Token(Token = "0x4015839")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PassTime;

	[Token(Token = "0x401583A")]
	[FieldOffset(Offset = "0x2C")]
	public Transform DeltaTr1;

	[Token(Token = "0x401583B")]
	[FieldOffset(Offset = "0x30")]
	public Transform DeltaTr2;

	[Token(Token = "0x401583C")]
	[FieldOffset(Offset = "0x34")]
	public Transform DeltaTr3;

	[Token(Token = "0x401583D")]
	[FieldOffset(Offset = "0x38")]
	public UILabel HistoryDeltaRating;

	[Token(Token = "0x401583E")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel HistoryRating;

	[Token(Token = "0x401583F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BRShow;

	[Token(Token = "0x4015840")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Rank;

	[Token(Token = "0x4015841")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SpecialRank;

	[Token(Token = "0x4015842")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject WinSprite;

	[Token(Token = "0x4015843")]
	[FieldOffset(Offset = "0x50")]
	public GameObject LoseSprite;

	[Token(Token = "0x4015844")]
	[FieldOffset(Offset = "0x54")]
	public GameObject CSShow;

	[Token(Token = "0x4015845")]
	[FieldOffset(Offset = "0x58")]
	public GameObject CS_V;

	[Token(Token = "0x4015846")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel V;

	[Token(Token = "0x4015847")]
	[FieldOffset(Offset = "0x60")]
	public GameObject CS_F;

	[Token(Token = "0x4015848")]
	[FieldOffset(Offset = "0x64")]
	public UILabel F;

	[Token(Token = "0x4015849")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SpriteMvp;

	[Token(Token = "0x401584A")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite SpriteSvp;

	[Token(Token = "0x401584B")]
	[FieldOffset(Offset = "0x70")]
	public GameObject SelectedHL;

	[Token(Token = "0x401584C")]
	[FieldOffset(Offset = "0x74")]
	public UIButton ItemBtn;

	[Token(Token = "0x401584D")]
	[FieldOffset(Offset = "0x78")]
	public UIButton PlayBtn;

	[Token(Token = "0x401584E")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton SaveBtn;

	[Token(Token = "0x60164EE")]
	[Address(RVA = "0x16326CC", Offset = "0x16326CC", VA = "0x16326CC")]
	public UIHistoryRecordItemView()
	{
	}

	[Token(Token = "0x60164EF")]
	[Address(RVA = "0x16326D4", Offset = "0x16326D4", VA = "0x16326D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164F0")]
	[Address(RVA = "0x1633164", Offset = "0x1633164", VA = "0x1633164")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
