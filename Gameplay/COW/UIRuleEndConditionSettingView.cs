using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003978")]
public class UIRuleEndConditionSettingView : UIBaseView
{
	[Token(Token = "0x4018121")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4018122")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018123")]
	[FieldOffset(Offset = "0x1C")]
	public UITable Container;

	[Token(Token = "0x601700F")]
	[Address(RVA = "0x2BF3984", Offset = "0x2BF3984", VA = "0x2BF3984")]
	public UIRuleEndConditionSettingView()
	{
	}

	[Token(Token = "0x6017010")]
	[Address(RVA = "0x2BF398C", Offset = "0x2BF398C", VA = "0x2BF398C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017011")]
	[Address(RVA = "0x2BF3BF4", Offset = "0x2BF3BF4", VA = "0x2BF3BF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
