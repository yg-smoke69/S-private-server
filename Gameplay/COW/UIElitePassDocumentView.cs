using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003503")]
public class UIElitePassDocumentView : UIBaseView
{
	[Token(Token = "0x4014E26")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4014E27")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x60162B9")]
	[Address(RVA = "0x2A56CC4", Offset = "0x2A56CC4", VA = "0x2A56CC4")]
	public UIElitePassDocumentView()
	{
	}

	[Token(Token = "0x60162BA")]
	[Address(RVA = "0x2A56CCC", Offset = "0x2A56CCC", VA = "0x2A56CCC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162BB")]
	[Address(RVA = "0x2A56ED4", Offset = "0x2A56ED4", VA = "0x2A56ED4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
