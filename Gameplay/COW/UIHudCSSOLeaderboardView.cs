using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003629")]
public class UIHudCSSOLeaderboardView : UIBaseView
{
	[Token(Token = "0x4015B27")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ItemListGridMyTeam;

	[Token(Token = "0x4015B28")]
	[FieldOffset(Offset = "0x18")]
	public Transform ItemListGridMyTeamTF;

	[Token(Token = "0x4015B29")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnClose;

	[Token(Token = "0x4015B2A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TapToClose;

	[Token(Token = "0x4015B2B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Round;

	[Token(Token = "0x4015B2C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ComingSoon;

	[Token(Token = "0x4015B2D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CountDown;

	[Token(Token = "0x4015B2E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CurrRoundNum;

	[Token(Token = "0x4015B2F")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LastRoundNum;

	[Token(Token = "0x6016628")]
	[Address(RVA = "0x212EE70", Offset = "0x212EE70", VA = "0x212EE70")]
	public UIHudCSSOLeaderboardView()
	{
	}

	[Token(Token = "0x6016629")]
	[Address(RVA = "0x212EE78", Offset = "0x212EE78", VA = "0x212EE78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601662A")]
	[Address(RVA = "0x212F2D4", Offset = "0x212F2D4", VA = "0x212F2D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
