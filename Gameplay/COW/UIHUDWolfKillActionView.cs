using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E8")]
public class UIHUDWolfKillActionView : UIBaseView
{
	[Token(Token = "0x4016AD5")]
	[FieldOffset(Offset = "0x14")]
	public Transform root;

	[Token(Token = "0x4016AD6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NoTargetRoot;

	[Token(Token = "0x4016AD7")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CDRoot;

	[Token(Token = "0x4016AD8")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CDLabel;

	[Token(Token = "0x4016AD9")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnFire;

	[Token(Token = "0x4016ADA")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BgCore;

	[Token(Token = "0x6016B63")]
	[Address(RVA = "0x162934C", Offset = "0x162934C", VA = "0x162934C")]
	public UIHUDWolfKillActionView()
	{
	}

	[Token(Token = "0x6016B64")]
	[Address(RVA = "0x1629354", Offset = "0x1629354", VA = "0x1629354", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B65")]
	[Address(RVA = "0x162969C", Offset = "0x162969C", VA = "0x162969C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
