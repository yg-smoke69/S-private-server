using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003618")]
public class UIHUDControlModeBuffIconView : UIBaseView
{
	[Token(Token = "0x4015A64")]
	[FieldOffset(Offset = "0x14")]
	public TweenFill tweenFill;

	[Token(Token = "0x4015A65")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Countdown;

	[Token(Token = "0x60165F7")]
	[Address(RVA = "0x167845C", Offset = "0x167845C", VA = "0x167845C")]
	public UIHUDControlModeBuffIconView()
	{
	}

	[Token(Token = "0x60165F8")]
	[Address(RVA = "0x1678464", Offset = "0x1678464", VA = "0x1678464", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165F9")]
	[Address(RVA = "0x167866C", Offset = "0x167866C", VA = "0x167866C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
