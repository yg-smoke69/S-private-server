using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038DD")]
public class UIOperationSettingView : UIBaseView
{
	[Token(Token = "0x4017981")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView SettingScrollView;

	[Token(Token = "0x4017982")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x4017983")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CustomizeButton;

	[Token(Token = "0x6016E40")]
	[Address(RVA = "0x15A0714", Offset = "0x15A0714", VA = "0x15A0714")]
	public UIOperationSettingView()
	{
	}

	[Token(Token = "0x6016E41")]
	[Address(RVA = "0x15A071C", Offset = "0x15A071C", VA = "0x15A071C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E42")]
	[Address(RVA = "0x15A0984", Offset = "0x15A0984", VA = "0x15A0984")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
