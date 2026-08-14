using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200369C")]
public class UIHudLudoGamePlayerDetailInfoLstView : UIBaseView
{
	[Token(Token = "0x4015F95")]
	[FieldOffset(Offset = "0x14")]
	public Transform Container;

	[Token(Token = "0x4015F96")]
	[FieldOffset(Offset = "0x18")]
	public UIHudLudoGamePlayerDetailItemController PlayerItemTemplate;

	[Token(Token = "0x6016781")]
	[Address(RVA = "0xFF61D8", Offset = "0xFF61D8", VA = "0xFF61D8")]
	public UIHudLudoGamePlayerDetailInfoLstView()
	{
	}

	[Token(Token = "0x6016782")]
	[Address(RVA = "0xFF61E0", Offset = "0xFF61E0", VA = "0xFF61E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016783")]
	[Address(RVA = "0xFF63C0", Offset = "0xFF63C0", VA = "0xFF63C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
