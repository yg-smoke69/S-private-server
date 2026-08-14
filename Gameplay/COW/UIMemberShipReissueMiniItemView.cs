using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A7")]
public class UIMemberShipReissueMiniItemView : UIBaseView
{
	[Token(Token = "0x40176E2")]
	[FieldOffset(Offset = "0x14")]
	public UISprite MemberShipTagSprite;

	[Token(Token = "0x40176E3")]
	[FieldOffset(Offset = "0x18")]
	public Transform MiniItemContainer;

	[Token(Token = "0x6016DA0")]
	[Address(RVA = "0x12FF2DC", Offset = "0x12FF2DC", VA = "0x12FF2DC")]
	public UIMemberShipReissueMiniItemView()
	{
	}

	[Token(Token = "0x6016DA1")]
	[Address(RVA = "0x12FF2E4", Offset = "0x12FF2E4", VA = "0x12FF2E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DA2")]
	[Address(RVA = "0x12FF4C4", Offset = "0x12FF4C4", VA = "0x12FF4C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
