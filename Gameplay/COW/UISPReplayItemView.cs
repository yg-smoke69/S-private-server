using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E6")]
internal class UISPReplayItemView : UIBaseView
{
	[Token(Token = "0x40185F8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Date;

	[Token(Token = "0x40185F9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MatchID;

	[Token(Token = "0x40185FA")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RoomInfo;

	[Token(Token = "0x40185FB")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Players;

	[Token(Token = "0x40185FC")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ModeName;

	[Token(Token = "0x40185FD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Sole;

	[Token(Token = "0x40185FE")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Duo;

	[Token(Token = "0x40185FF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Quad;

	[Token(Token = "0x4018600")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Time;

	[Token(Token = "0x4018601")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PlayBtn;

	[Token(Token = "0x4018602")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton DelBtn;

	[Token(Token = "0x6017158")]
	[Address(RVA = "0x14AA234", Offset = "0x14AA234", VA = "0x14AA234")]
	public UISPReplayItemView()
	{
	}

	[Token(Token = "0x6017159")]
	[Address(RVA = "0x14AA23C", Offset = "0x14AA23C", VA = "0x14AA23C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601715A")]
	[Address(RVA = "0x14AA660", Offset = "0x14AA660", VA = "0x14AA660")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
