using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037D2")]
public class UIHudWereWolvesInteractView : UIBaseView
{
	[Token(Token = "0x4016A2E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ActButton;

	[Token(Token = "0x4016A2F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SpriteTable;

	[Token(Token = "0x4016A30")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SpriteOther;

	[Token(Token = "0x4016A31")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CountDownRoot;

	[Token(Token = "0x4016A32")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CountDownLabel;

	[Token(Token = "0x4016A33")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ActionLabel;

	[Token(Token = "0x6016B21")]
	[Address(RVA = "0x256B468", Offset = "0x256B468", VA = "0x256B468")]
	public UIHudWereWolvesInteractView()
	{
	}

	[Token(Token = "0x6016B22")]
	[Address(RVA = "0x256B470", Offset = "0x256B470", VA = "0x256B470", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B23")]
	[Address(RVA = "0x256B7D4", Offset = "0x256B7D4", VA = "0x256B7D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
