using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003767")]
public class UIHudTDMLikeShopEntryView : UIBaseView
{
	[Token(Token = "0x40166A9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnShop;

	[Token(Token = "0x40166AA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x60169E0")]
	[Address(RVA = "0x1FFA180", Offset = "0x1FFA180", VA = "0x1FFA180")]
	public UIHudTDMLikeShopEntryView()
	{
	}

	[Token(Token = "0x60169E1")]
	[Address(RVA = "0x1FFA188", Offset = "0x1FFA188", VA = "0x1FFA188", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169E2")]
	[Address(RVA = "0x1FFA384", Offset = "0x1FFA384", VA = "0x1FFA384")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
