using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003418")]
public class UIChampionshipReviewRewardItemView : UIBaseView
{
	[Token(Token = "0x40141D7")]
	[FieldOffset(Offset = "0x14")]
	public Transform LevelRewardContainer;

	[Token(Token = "0x40141D8")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid LevelRewardGrid;

	[Token(Token = "0x40141D9")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SelectedBg;

	[Token(Token = "0x40141DA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BG;

	[Token(Token = "0x40141DB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BG1;

	[Token(Token = "0x40141DC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BG2;

	[Token(Token = "0x40141DD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BG3;

	[Token(Token = "0x40141DE")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Level;

	[Token(Token = "0x40141DF")]
	[FieldOffset(Offset = "0x34")]
	public UISprite LevelSprite;

	[Token(Token = "0x6015FFC")]
	[Address(RVA = "0x2837DE4", Offset = "0x2837DE4", VA = "0x2837DE4")]
	public UIChampionshipReviewRewardItemView()
	{
	}

	[Token(Token = "0x6015FFD")]
	[Address(RVA = "0x2837DEC", Offset = "0x2837DEC", VA = "0x2837DEC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FFE")]
	[Address(RVA = "0x2838230", Offset = "0x2838230", VA = "0x2838230")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
