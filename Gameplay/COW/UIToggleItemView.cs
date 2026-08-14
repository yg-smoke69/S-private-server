using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039FA")]
public class UIToggleItemView : UIBaseView
{
	[Token(Token = "0x40186EE")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle ItemToggle;

	[Token(Token = "0x40186EF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SelectItemLabel;

	[Token(Token = "0x40186F0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel UnSelectItemLabel;

	[Token(Token = "0x6017194")]
	[Address(RVA = "0x201CC34", Offset = "0x201CC34", VA = "0x201CC34")]
	public UIToggleItemView()
	{
	}

	[Token(Token = "0x6017195")]
	[Address(RVA = "0x201CC3C", Offset = "0x201CC3C", VA = "0x201CC3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017196")]
	[Address(RVA = "0x201CEA4", Offset = "0x201CEA4", VA = "0x201CEA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
