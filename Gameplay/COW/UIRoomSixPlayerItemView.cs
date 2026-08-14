using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003975")]
public class UIRoomSixPlayerItemView : UIBaseView
{
	[Token(Token = "0x4018103")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomSixPlayerItem;

	[Token(Token = "0x4018104")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x4018105")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Id;

	[Token(Token = "0x4018106")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PlayerGo1;

	[Token(Token = "0x4018107")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PlayerGo2;

	[Token(Token = "0x4018108")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PlayerGo3;

	[Token(Token = "0x4018109")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PlayerGo4;

	[Token(Token = "0x401810A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PlayerGo5;

	[Token(Token = "0x401810B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PlayerGo6;

	[Token(Token = "0x6017006")]
	[Address(RVA = "0x2BED2BC", Offset = "0x2BED2BC", VA = "0x2BED2BC")]
	public UIRoomSixPlayerItemView()
	{
	}

	[Token(Token = "0x6017007")]
	[Address(RVA = "0x2BED2C4", Offset = "0x2BED2C4", VA = "0x2BED2C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017008")]
	[Address(RVA = "0x2BED718", Offset = "0x2BED718", VA = "0x2BED718")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
