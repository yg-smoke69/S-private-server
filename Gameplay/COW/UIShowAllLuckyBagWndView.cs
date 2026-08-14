using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B0")]
public class UIShowAllLuckyBagWndView : UIBaseView
{
	[Token(Token = "0x4018394")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel ScrollView;

	[Token(Token = "0x4018395")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList Grid;

	[Token(Token = "0x60170B7")]
	[Address(RVA = "0x2054CD4", Offset = "0x2054CD4", VA = "0x2054CD4")]
	public UIShowAllLuckyBagWndView()
	{
	}

	[Token(Token = "0x60170B8")]
	[Address(RVA = "0x2054CDC", Offset = "0x2054CDC", VA = "0x2054CDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170B9")]
	[Address(RVA = "0x2054EE4", Offset = "0x2054EE4", VA = "0x2054EE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
