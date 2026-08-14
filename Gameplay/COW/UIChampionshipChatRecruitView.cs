using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200340C")]
public class UIChampionshipChatRecruitView : UIBaseView
{
	[Token(Token = "0x4014140")]
	[FieldOffset(Offset = "0x14")]
	public UILabel MatchName;

	[Token(Token = "0x4014141")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TeamScale;

	[Token(Token = "0x4014142")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle WorldToggle;

	[Token(Token = "0x4014143")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget WorldWidget;

	[Token(Token = "0x4014144")]
	[FieldOffset(Offset = "0x24")]
	public UILabel WorldLabel;

	[Token(Token = "0x4014145")]
	[FieldOffset(Offset = "0x28")]
	public UIToggle ClanToggle;

	[Token(Token = "0x4014146")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget ClanWidget;

	[Token(Token = "0x4014147")]
	[FieldOffset(Offset = "0x30")]
	public UIButton SendBtn;

	[Token(Token = "0x6015FD8")]
	[Address(RVA = "0x145E2F4", Offset = "0x145E2F4", VA = "0x145E2F4")]
	public UIChampionshipChatRecruitView()
	{
	}

	[Token(Token = "0x6015FD9")]
	[Address(RVA = "0x145E2FC", Offset = "0x145E2FC", VA = "0x145E2FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FDA")]
	[Address(RVA = "0x145E744", Offset = "0x145E744", VA = "0x145E744")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
