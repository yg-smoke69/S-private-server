using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D1")]
public class UINewVaultMusicContainerView : UIBaseView
{
	[Token(Token = "0x40178B6")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40178B7")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016E1C")]
	[Address(RVA = "0x26C8700", Offset = "0x26C8700", VA = "0x26C8700")]
	public UINewVaultMusicContainerView()
	{
	}

	[Token(Token = "0x6016E1D")]
	[Address(RVA = "0x26C8708", Offset = "0x26C8708", VA = "0x26C8708", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E1E")]
	[Address(RVA = "0x26C8910", Offset = "0x26C8910", VA = "0x26C8910")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
