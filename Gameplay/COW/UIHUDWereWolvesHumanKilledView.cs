using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D0")]
public class UIHUDWereWolvesHumanKilledView : UIBaseView
{
	[Token(Token = "0x4016A1C")]
	[FieldOffset(Offset = "0x14")]
	public UISprite WolfIcon;

	[Token(Token = "0x4016A1D")]
	[FieldOffset(Offset = "0x18")]
	public UISprite WolfIndexBg;

	[Token(Token = "0x4016A1E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel WolfNum;

	[Token(Token = "0x4016A1F")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HumanIcon;

	[Token(Token = "0x4016A20")]
	[FieldOffset(Offset = "0x24")]
	public UISprite HumanIndexBg;

	[Token(Token = "0x4016A21")]
	[FieldOffset(Offset = "0x28")]
	public UILabel HumanNum;

	[Token(Token = "0x4016A22")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FinalKillRoot;

	[Token(Token = "0x4016A23")]
	[FieldOffset(Offset = "0x30")]
	public GameObject CommonKillRoot;

	[Token(Token = "0x6016B1B")]
	[Address(RVA = "0x1620BF8", Offset = "0x1620BF8", VA = "0x1620BF8")]
	public UIHUDWereWolvesHumanKilledView()
	{
	}

	[Token(Token = "0x6016B1C")]
	[Address(RVA = "0x1620C00", Offset = "0x1620C00", VA = "0x1620C00", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B1D")]
	[Address(RVA = "0x1621030", Offset = "0x1621030", VA = "0x1621030")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
