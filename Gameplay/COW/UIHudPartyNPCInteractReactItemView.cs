using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D3")]
public class UIHudPartyNPCInteractReactItemView : UIBaseView
{
	[Token(Token = "0x401622F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton itemButton;

	[Token(Token = "0x4016230")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ReactionLabel;

	[Token(Token = "0x6016826")]
	[Address(RVA = "0x1845E4C", Offset = "0x1845E4C", VA = "0x1845E4C")]
	public UIHudPartyNPCInteractReactItemView()
	{
	}

	[Token(Token = "0x6016827")]
	[Address(RVA = "0x1845E54", Offset = "0x1845E54", VA = "0x1845E54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016828")]
	[Address(RVA = "0x1845FBC", Offset = "0x1845FBC", VA = "0x1845FBC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
