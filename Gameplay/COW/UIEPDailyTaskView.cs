using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200351C")]
public class UIEPDailyTaskView : UIBaseView
{
	[Token(Token = "0x4014F58")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TaskMask;

	[Token(Token = "0x4014F59")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TaskDesc;

	[Token(Token = "0x4014F5A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Process;

	[Token(Token = "0x4014F5B")]
	[FieldOffset(Offset = "0x20")]
	public Transform ProcessTrans;

	[Token(Token = "0x4014F5C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FPDesc;

	[Token(Token = "0x4014F5D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton UpgradeBtn;

	[Token(Token = "0x4014F5E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EPDesc;

	[Token(Token = "0x4014F5F")]
	[FieldOffset(Offset = "0x30")]
	public UIButton DailySignBtn;

	[Token(Token = "0x4014F60")]
	[FieldOffset(Offset = "0x34")]
	public UINetworkTexture CDNTexture;

	[Token(Token = "0x4014F61")]
	[FieldOffset(Offset = "0x38")]
	public Transform Pos1;

	[Token(Token = "0x4014F62")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Pos2;

	[Token(Token = "0x4014F63")]
	[FieldOffset(Offset = "0x40")]
	public Transform Pos3;

	[Token(Token = "0x4014F64")]
	[FieldOffset(Offset = "0x44")]
	public Transform Pos4;

	[Token(Token = "0x4014F65")]
	[FieldOffset(Offset = "0x48")]
	public Transform Pos5;

	[Token(Token = "0x4014F66")]
	[FieldOffset(Offset = "0x4C")]
	public Transform Pos6;

	[Token(Token = "0x4014F67")]
	[FieldOffset(Offset = "0x50")]
	public Transform Pos7;

	[Token(Token = "0x4014F68")]
	[FieldOffset(Offset = "0x54")]
	public Transform Pos8;

	[Token(Token = "0x4014F69")]
	[FieldOffset(Offset = "0x58")]
	public Animation ProcessAnim;

	[Token(Token = "0x4014F6A")]
	[FieldOffset(Offset = "0x5C")]
	public UIScrollView TaskScrollView;

	[Token(Token = "0x4014F6B")]
	[FieldOffset(Offset = "0x60")]
	public UIEasyList TaskList;

	[Token(Token = "0x6016304")]
	[Address(RVA = "0x2BA9518", Offset = "0x2BA9518", VA = "0x2BA9518")]
	public UIEPDailyTaskView()
	{
	}

	[Token(Token = "0x6016305")]
	[Address(RVA = "0x2BA9520", Offset = "0x2BA9520", VA = "0x2BA9520", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016306")]
	[Address(RVA = "0x2BA9C68", Offset = "0x2BA9C68", VA = "0x2BA9C68")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
