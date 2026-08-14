using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D0")]
public class UINewVaultInstallmentContainerView : UIBaseView
{
	[Token(Token = "0x40178B4")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40178B5")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016E19")]
	[Address(RVA = "0x26C7F20", Offset = "0x26C7F20", VA = "0x26C7F20")]
	public UINewVaultInstallmentContainerView()
	{
	}

	[Token(Token = "0x6016E1A")]
	[Address(RVA = "0x26C7F28", Offset = "0x26C7F28", VA = "0x26C7F28", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E1B")]
	[Address(RVA = "0x26C8130", Offset = "0x26C8130", VA = "0x26C8130")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
