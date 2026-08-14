using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D6")]
public class UINewVaultSecondTabView : UIBaseView
{
	[Token(Token = "0x40178E2")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel TabPanel;

	[Token(Token = "0x40178E3")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40178E4")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyList;

	[Token(Token = "0x40178E5")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget LeftBG;

	[Token(Token = "0x6016E2B")]
	[Address(RVA = "0x26CF7A8", Offset = "0x26CF7A8", VA = "0x26CF7A8")]
	public UINewVaultSecondTabView()
	{
	}

	[Token(Token = "0x6016E2C")]
	[Address(RVA = "0x26CF7B0", Offset = "0x26CF7B0", VA = "0x26CF7B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E2D")]
	[Address(RVA = "0x26CFA78", Offset = "0x26CFA78", VA = "0x26CFA78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
