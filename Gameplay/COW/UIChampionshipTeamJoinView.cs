using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003420")]
public class UIChampionshipTeamJoinView : UIBaseView
{
	[Token(Token = "0x4014214")]
	[FieldOffset(Offset = "0x14")]
	public UIInput SearchInput;

	[Token(Token = "0x4014215")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SearchButton;

	[Token(Token = "0x4014216")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList TeamList;

	[Token(Token = "0x4014217")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EmptyTips;

	[Token(Token = "0x6016014")]
	[Address(RVA = "0x2617B98", Offset = "0x2617B98", VA = "0x2617B98")]
	public UIChampionshipTeamJoinView()
	{
	}

	[Token(Token = "0x6016015")]
	[Address(RVA = "0x2617BA0", Offset = "0x2617BA0", VA = "0x2617BA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016016")]
	[Address(RVA = "0x2617E5C", Offset = "0x2617E5C", VA = "0x2617E5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
