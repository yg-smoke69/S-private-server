using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200396B")]
public class UIRoomPentaPlayerItemView : UIBaseView
{
	[Token(Token = "0x40180AA")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomPentaPlayerItem;

	[Token(Token = "0x40180AB")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x40180AC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Id;

	[Token(Token = "0x40180AD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PlayerGo1;

	[Token(Token = "0x40180AE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PlayerGo2;

	[Token(Token = "0x40180AF")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PlayerGo3;

	[Token(Token = "0x40180B0")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlayerGo4;

	[Token(Token = "0x40180B1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PlayerGo5;

	[Token(Token = "0x6016FE8")]
	[Address(RVA = "0x23D9F3C", Offset = "0x23D9F3C", VA = "0x23D9F3C")]
	public UIRoomPentaPlayerItemView()
	{
	}

	[Token(Token = "0x6016FE9")]
	[Address(RVA = "0x23D9F44", Offset = "0x23D9F44", VA = "0x23D9F44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FEA")]
	[Address(RVA = "0x23DA344", Offset = "0x23DA344", VA = "0x23DA344")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
