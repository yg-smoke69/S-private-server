using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D7")]
public class UIHUDArmsRaceTopLevelWarningView : UIBaseView
{
	[Token(Token = "0x40158E0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject InfoContainer;

	[Token(Token = "0x40158E1")]
	[FieldOffset(Offset = "0x18")]
	public UILabel WarningText;

	[Token(Token = "0x6016533")]
	[Address(RVA = "0x167428C", Offset = "0x167428C", VA = "0x167428C")]
	public UIHUDArmsRaceTopLevelWarningView()
	{
	}

	[Token(Token = "0x6016534")]
	[Address(RVA = "0x1674294", Offset = "0x1674294", VA = "0x1674294", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016535")]
	[Address(RVA = "0x1674490", Offset = "0x1674490", VA = "0x1674490")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
