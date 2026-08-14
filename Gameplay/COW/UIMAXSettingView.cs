using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A2")]
public class UIMAXSettingView : UIBaseView
{
	[Token(Token = "0x401768D")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView SettingScrollView;

	[Token(Token = "0x401768E")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x6016D91")]
	[Address(RVA = "0x18D2278", Offset = "0x18D2278", VA = "0x18D2278")]
	public UIMAXSettingView()
	{
	}

	[Token(Token = "0x6016D92")]
	[Address(RVA = "0x18D2280", Offset = "0x18D2280", VA = "0x18D2280", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D93")]
	[Address(RVA = "0x18D2488", Offset = "0x18D2488", VA = "0x18D2488")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
