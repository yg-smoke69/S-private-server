using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038CE")]
public class UINewVaultHeadPicContainerView : UIBaseView
{
	[Token(Token = "0x40178AA")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40178AB")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016E13")]
	[Address(RVA = "0x26C5520", Offset = "0x26C5520", VA = "0x26C5520")]
	public UINewVaultHeadPicContainerView()
	{
	}

	[Token(Token = "0x6016E14")]
	[Address(RVA = "0x26C5528", Offset = "0x26C5528", VA = "0x26C5528", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E15")]
	[Address(RVA = "0x26C5730", Offset = "0x26C5730", VA = "0x26C5730")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
