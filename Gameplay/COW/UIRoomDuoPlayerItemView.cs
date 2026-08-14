using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003962")]
public class UIRoomDuoPlayerItemView : UIBaseView
{
	[Token(Token = "0x4018043")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UIRoomDuoPlayerItem;

	[Token(Token = "0x4018044")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Selected;

	[Token(Token = "0x4018045")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Id;

	[Token(Token = "0x4018046")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PlayerGo1;

	[Token(Token = "0x4018047")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PlayerGo2;

	[Token(Token = "0x6016FCD")]
	[Address(RVA = "0x23BEBEC", Offset = "0x23BEBEC", VA = "0x23BEBEC")]
	public UIRoomDuoPlayerItemView()
	{
	}

	[Token(Token = "0x6016FCE")]
	[Address(RVA = "0x23BEBF4", Offset = "0x23BEBF4", VA = "0x23BEBF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FCF")]
	[Address(RVA = "0x23BEEF8", Offset = "0x23BEEF8", VA = "0x23BEEF8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
