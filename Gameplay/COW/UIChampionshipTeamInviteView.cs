using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200341E")]
public class UIChampionshipTeamInviteView : UIBaseView
{
	[Token(Token = "0x4014208")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList EasyList;

	[Token(Token = "0x4014209")]
	[FieldOffset(Offset = "0x18")]
	public GameObject EmptyTips;

	[Token(Token = "0x401420A")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput SearchInput;

	[Token(Token = "0x401420B")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Search;

	[Token(Token = "0x601600E")]
	[Address(RVA = "0x2614AE8", Offset = "0x2614AE8", VA = "0x2614AE8")]
	public UIChampionshipTeamInviteView()
	{
	}

	[Token(Token = "0x601600F")]
	[Address(RVA = "0x2614AF0", Offset = "0x2614AF0", VA = "0x2614AF0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016010")]
	[Address(RVA = "0x2614DAC", Offset = "0x2614DAC", VA = "0x2614DAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
