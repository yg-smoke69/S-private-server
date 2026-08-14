using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036BD")]
public class UIHudNameRedEnvelopeOwnerView : UIBaseView
{
	[Token(Token = "0x40160FF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel OwnerName;

	[Token(Token = "0x60167E4")]
	[Address(RVA = "0x1F519F0", Offset = "0x1F519F0", VA = "0x1F519F0")]
	public UIHudNameRedEnvelopeOwnerView()
	{
	}

	[Token(Token = "0x60167E5")]
	[Address(RVA = "0x1F519F8", Offset = "0x1F519F8", VA = "0x1F519F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167E6")]
	[Address(RVA = "0x1F51BA0", Offset = "0x1F51BA0", VA = "0x1F51BA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
