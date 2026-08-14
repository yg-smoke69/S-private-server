using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A4")]
public class UISeasonStatsView : UIBaseView
{
	[Token(Token = "0x4018312")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x4018313")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnViewAll;

	[Token(Token = "0x4018314")]
	[FieldOffset(Offset = "0x1C")]
	public Transform ItemPos;

	[Token(Token = "0x4018315")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ItemRank;

	[Token(Token = "0x4018316")]
	[FieldOffset(Offset = "0x24")]
	public Transform ItemPos2;

	[Token(Token = "0x4018317")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ItemRank2;

	[Token(Token = "0x4018318")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton DetailBtn;

	[Token(Token = "0x4018319")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BooyahCount;

	[Token(Token = "0x401831A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel BooyahCountLabel;

	[Token(Token = "0x401831B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TotalKillsLabel;

	[Token(Token = "0x401831C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel KDTitle;

	[Token(Token = "0x401831D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel KDLabel;

	[Token(Token = "0x6017093")]
	[Address(RVA = "0x1A4D094", Offset = "0x1A4D094", VA = "0x1A4D094")]
	public UISeasonStatsView()
	{
	}

	[Token(Token = "0x6017094")]
	[Address(RVA = "0x1A4D09C", Offset = "0x1A4D09C", VA = "0x1A4D09C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017095")]
	[Address(RVA = "0x1A4D5FC", Offset = "0x1A4D5FC", VA = "0x1A4D5FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
