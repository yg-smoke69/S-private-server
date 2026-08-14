using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037CF")]
public class UIHudWereWolvesHistroyItemView : UIBaseView
{
	[Token(Token = "0x4016A12")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4016A13")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NameLabel;

	[Token(Token = "0x4016A14")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite HeadPic;

	[Token(Token = "0x4016A15")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HeadPicBg;

	[Token(Token = "0x4016A16")]
	[FieldOffset(Offset = "0x24")]
	public UISprite CountBG;

	[Token(Token = "0x4016A17")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CountLabel;

	[Token(Token = "0x4016A18")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RoleRoot;

	[Token(Token = "0x4016A19")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HumanIcon;

	[Token(Token = "0x4016A1A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WolfIcon;

	[Token(Token = "0x4016A1B")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid VotedGridList;

	[Token(Token = "0x6016B18")]
	[Address(RVA = "0x2567940", Offset = "0x2567940", VA = "0x2567940")]
	public UIHudWereWolvesHistroyItemView()
	{
	}

	[Token(Token = "0x6016B19")]
	[Address(RVA = "0x2567948", Offset = "0x2567948", VA = "0x2567948", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B1A")]
	[Address(RVA = "0x2567E2C", Offset = "0x2567E2C", VA = "0x2567E2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
