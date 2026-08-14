using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037CE")]
public class UIHUDWereWolvesEndShowTimeView : UIBaseView
{
	[Token(Token = "0x4016A09")]
	[FieldOffset(Offset = "0x14")]
	public GameObject WinAnimRoot;

	[Token(Token = "0x4016A0A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WinRoot;

	[Token(Token = "0x4016A0B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject DefeatRoot;

	[Token(Token = "0x4016A0C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WolfRoleRoot;

	[Token(Token = "0x4016A0D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WolfWinIcon;

	[Token(Token = "0x4016A0E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject WolfDefeatIcon;

	[Token(Token = "0x4016A0F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HumanRoleRoot;

	[Token(Token = "0x4016A10")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HumanWinIcon;

	[Token(Token = "0x4016A11")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HumanDefeatIcon;

	[Token(Token = "0x6016B15")]
	[Address(RVA = "0x161FEFC", Offset = "0x161FEFC", VA = "0x161FEFC")]
	public UIHUDWereWolvesEndShowTimeView()
	{
	}

	[Token(Token = "0x6016B16")]
	[Address(RVA = "0x161FF04", Offset = "0x161FF04", VA = "0x161FF04", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B17")]
	[Address(RVA = "0x1620340", Offset = "0x1620340", VA = "0x1620340")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
