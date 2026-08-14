using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200365D")]
public class UIHudGameMissionMiniInfoPanelView : UIBaseView
{
	[Token(Token = "0x4015D16")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget WidgetRoot;

	[Token(Token = "0x4015D17")]
	[FieldOffset(Offset = "0x18")]
	public UITable Table;

	[Token(Token = "0x60166C4")]
	[Address(RVA = "0x1887FE0", Offset = "0x1887FE0", VA = "0x1887FE0")]
	public UIHudGameMissionMiniInfoPanelView()
	{
	}

	[Token(Token = "0x60166C5")]
	[Address(RVA = "0x1887FE8", Offset = "0x1887FE8", VA = "0x1887FE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166C6")]
	[Address(RVA = "0x18881F0", Offset = "0x18881F0", VA = "0x18881F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
