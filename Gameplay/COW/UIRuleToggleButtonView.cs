using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003988")]
public class UIRuleToggleButtonView : UIBaseView
{
	[Token(Token = "0x4018187")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Select;

	[Token(Token = "0x4018188")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x601703F")]
	[Address(RVA = "0x1426234", Offset = "0x1426234", VA = "0x1426234")]
	public UIRuleToggleButtonView()
	{
	}

	[Token(Token = "0x6017040")]
	[Address(RVA = "0x142623C", Offset = "0x142623C", VA = "0x142623C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017041")]
	[Address(RVA = "0x1426444", Offset = "0x1426444", VA = "0x1426444")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
