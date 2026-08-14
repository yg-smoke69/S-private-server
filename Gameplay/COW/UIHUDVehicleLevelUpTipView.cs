using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C4")]
public class UIHUDVehicleLevelUpTipView : UIBaseView
{
	[Token(Token = "0x4016973")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ArmIcon;

	[Token(Token = "0x4016974")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TipLabel;

	[Token(Token = "0x6016AF7")]
	[Address(RVA = "0x2934E78", Offset = "0x2934E78", VA = "0x2934E78")]
	public UIHUDVehicleLevelUpTipView()
	{
	}

	[Token(Token = "0x6016AF8")]
	[Address(RVA = "0x2934E80", Offset = "0x2934E80", VA = "0x2934E80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AF9")]
	[Address(RVA = "0x2935088", Offset = "0x2935088", VA = "0x2935088")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
