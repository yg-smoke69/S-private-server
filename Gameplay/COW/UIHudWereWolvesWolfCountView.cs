using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E6")]
public class UIHudWereWolvesWolfCountView : UIBaseView
{
	[Token(Token = "0x4016ACC")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid gridBg;

	[Token(Token = "0x4016ACD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject wolf1Dead;

	[Token(Token = "0x4016ACE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject wolf1;

	[Token(Token = "0x4016ACF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject wolf2Dead;

	[Token(Token = "0x4016AD0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject wolf2;

	[Token(Token = "0x4016AD1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject wolf3Dead;

	[Token(Token = "0x4016AD2")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject wolf3;

	[Token(Token = "0x6016B5D")]
	[Address(RVA = "0x294150C", Offset = "0x294150C", VA = "0x294150C")]
	public UIHudWereWolvesWolfCountView()
	{
	}

	[Token(Token = "0x6016B5E")]
	[Address(RVA = "0x2941514", Offset = "0x2941514", VA = "0x2941514", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B5F")]
	[Address(RVA = "0x29418B4", Offset = "0x29418B4", VA = "0x29418B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
