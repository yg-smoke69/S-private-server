using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038CB")]
public class UINewVaultEmoteContainerView : UIBaseView
{
	[Token(Token = "0x401788A")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401788B")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016E0A")]
	[Address(RVA = "0x2C1E41C", Offset = "0x2C1E41C", VA = "0x2C1E41C")]
	public UINewVaultEmoteContainerView()
	{
	}

	[Token(Token = "0x6016E0B")]
	[Address(RVA = "0x2C1E424", Offset = "0x2C1E424", VA = "0x2C1E424", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E0C")]
	[Address(RVA = "0x2C1E62C", Offset = "0x2C1E62C", VA = "0x2C1E62C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
