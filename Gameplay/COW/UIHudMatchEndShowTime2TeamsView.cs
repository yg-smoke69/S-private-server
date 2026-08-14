using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A9")]
public class UIHudMatchEndShowTime2TeamsView : UIBaseView
{
	[Token(Token = "0x4016018")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Lose;

	[Token(Token = "0x4016019")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Win;

	[Token(Token = "0x401601A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ShowTimeLabel;

	[Token(Token = "0x401601B")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ShowResultBtn;

	[Token(Token = "0x401601C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ShowResultLabel;

	[Token(Token = "0x401601D")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Time;

	[Token(Token = "0x401601E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Team1Root;

	[Token(Token = "0x401601F")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Team1Icon;

	[Token(Token = "0x4016020")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Team1Score;

	[Token(Token = "0x4016021")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Team2Root;

	[Token(Token = "0x4016022")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Team2Icon;

	[Token(Token = "0x4016023")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Team2Score;

	[Token(Token = "0x60167A8")]
	[Address(RVA = "0xFFB278", Offset = "0xFFB278", VA = "0xFFB278")]
	public UIHudMatchEndShowTime2TeamsView()
	{
	}

	[Token(Token = "0x60167A9")]
	[Address(RVA = "0xFFB280", Offset = "0xFFB280", VA = "0xFFB280", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167AA")]
	[Address(RVA = "0xFFB80C", Offset = "0xFFB80C", VA = "0xFFB80C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
