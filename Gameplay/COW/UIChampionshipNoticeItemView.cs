using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003415")]
public class UIChampionshipNoticeItemView : UIBaseView
{
	[Token(Token = "0x40141CC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnNoticeItem;

	[Token(Token = "0x40141CD")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDNTexture;

	[Token(Token = "0x6015FF3")]
	[Address(RVA = "0x2835178", Offset = "0x2835178", VA = "0x2835178")]
	public UIChampionshipNoticeItemView()
	{
	}

	[Token(Token = "0x6015FF4")]
	[Address(RVA = "0x2835180", Offset = "0x2835180", VA = "0x2835180", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FF5")]
	[Address(RVA = "0x2835388", Offset = "0x2835388", VA = "0x2835388")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
