using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F2")]
public class UIStandardTabView : UIBaseView
{
	[Token(Token = "0x40186AD")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel TabPanel;

	[Token(Token = "0x40186AE")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget AllTab;

	[Token(Token = "0x40186AF")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40186B0")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList EasyList;

	[Token(Token = "0x40186B1")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget LeftBG;

	[Token(Token = "0x601717C")]
	[Address(RVA = "0x2004A2C", Offset = "0x2004A2C", VA = "0x2004A2C")]
	public UIStandardTabView()
	{
	}

	[Token(Token = "0x601717D")]
	[Address(RVA = "0x2004A34", Offset = "0x2004A34", VA = "0x2004A34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601717E")]
	[Address(RVA = "0x2004D5C", Offset = "0x2004D5C", VA = "0x2004D5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
