using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200392B")]
public class UIProfileMiniRankInfoView : UIBaseView
{
	[Token(Token = "0x4017D79")]
	[FieldOffset(Offset = "0x14")]
	public UISprite RankIcon;

	[Token(Token = "0x4017D7A")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid StarsGrid;

	[Token(Token = "0x4017D7B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject star1;

	[Token(Token = "0x4017D7C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject star2;

	[Token(Token = "0x4017D7D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject star3;

	[Token(Token = "0x4017D7E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject star4;

	[Token(Token = "0x4017D7F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject star5;

	[Token(Token = "0x4017D80")]
	[FieldOffset(Offset = "0x30")]
	public GameObject blackstar1;

	[Token(Token = "0x4017D81")]
	[FieldOffset(Offset = "0x34")]
	public GameObject blackstar2;

	[Token(Token = "0x4017D82")]
	[FieldOffset(Offset = "0x38")]
	public GameObject blackstar3;

	[Token(Token = "0x4017D83")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject blackstar4;

	[Token(Token = "0x4017D84")]
	[FieldOffset(Offset = "0x40")]
	public GameObject blackstar5;

	[Token(Token = "0x4017D85")]
	[FieldOffset(Offset = "0x44")]
	public UILabel MaxRankTxt;

	[Token(Token = "0x6016F28")]
	[Address(RVA = "0x16EA82C", Offset = "0x16EA82C", VA = "0x16EA82C")]
	public UIProfileMiniRankInfoView()
	{
	}

	[Token(Token = "0x6016F29")]
	[Address(RVA = "0x16EA834", Offset = "0x16EA834", VA = "0x16EA834", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F2A")]
	[Address(RVA = "0x16EADE4", Offset = "0x16EADE4", VA = "0x16EADE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
