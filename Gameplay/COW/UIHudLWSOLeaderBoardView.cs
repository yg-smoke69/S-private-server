using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A2")]
public class UIHudLWSOLeaderBoardView : UIBaseView
{
	[Token(Token = "0x4015FCA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ExitBtn;

	[Token(Token = "0x4015FCB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RoundLabel;

	[Token(Token = "0x4015FCC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TimerLabel;

	[Token(Token = "0x4015FCD")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4015FCE")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4015FCF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SelfInfo;

	[Token(Token = "0x4015FD0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SelfInfoUpArrow;

	[Token(Token = "0x4015FD1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SelfInfoUpArrowNumLabel;

	[Token(Token = "0x4015FD2")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SelfInfoDownArrow;

	[Token(Token = "0x4015FD3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel SelfInfoDownArrowNumLabel;

	[Token(Token = "0x4015FD4")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SelfInfoRankLabel;

	[Token(Token = "0x4015FD5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SelfInfoRankone;

	[Token(Token = "0x4015FD6")]
	[FieldOffset(Offset = "0x44")]
	public GameObject SelfInfoRanktwo;

	[Token(Token = "0x4015FD7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SelfInfoRankthre;

	[Token(Token = "0x4015FD8")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid SelfInfoHPGrid;

	[Token(Token = "0x4015FD9")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SelfInfoHP1;

	[Token(Token = "0x4015FDA")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SelfInfoHP2;

	[Token(Token = "0x4015FDB")]
	[FieldOffset(Offset = "0x58")]
	public UISprite SelfInfoHP3;

	[Token(Token = "0x4015FDC")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite SelfInfoHP4;

	[Token(Token = "0x4015FDD")]
	[FieldOffset(Offset = "0x60")]
	public UISprite SelfInfoHP5;

	[Token(Token = "0x4015FDE")]
	[FieldOffset(Offset = "0x64")]
	public UILabel SelfInfoNameLabel;

	[Token(Token = "0x4015FDF")]
	[FieldOffset(Offset = "0x68")]
	public UISprite SelfInfoRandomIcon;

	[Token(Token = "0x4015FE0")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel SelfInfoKLabel;

	[Token(Token = "0x4015FE1")]
	[FieldOffset(Offset = "0x70")]
	public UILabel SelfInfoDLabel;

	[Token(Token = "0x4015FE2")]
	[FieldOffset(Offset = "0x74")]
	public UILabel SelfInfoHSLabel;

	[Token(Token = "0x4015FE3")]
	[FieldOffset(Offset = "0x78")]
	public GameObject SelfInfoEliminate;

	[Token(Token = "0x4015FE4")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject WinStreakVFX2;

	[Token(Token = "0x4015FE5")]
	[FieldOffset(Offset = "0x80")]
	public GameObject WinStreakVFX3;

	[Token(Token = "0x6016793")]
	[Address(RVA = "0x1BC6874", Offset = "0x1BC6874", VA = "0x1BC6874")]
	public UIHudLWSOLeaderBoardView()
	{
	}

	[Token(Token = "0x6016794")]
	[Address(RVA = "0x1BC687C", Offset = "0x1BC687C", VA = "0x1BC687C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016795")]
	[Address(RVA = "0x1BC73D8", Offset = "0x1BC73D8", VA = "0x1BC73D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
