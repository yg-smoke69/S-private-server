using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033E3")]
public class UIAwakenStoryItemView : UIBaseView
{
	[Token(Token = "0x4013EEA")]
	[FieldOffset(Offset = "0x14")]
	public UIAvatarAwakenStoryItemController UIAwakenStoryItem;

	[Token(Token = "0x4013EEB")]
	[FieldOffset(Offset = "0x18")]
	public Animation itemAnim;

	[Token(Token = "0x6015F5F")]
	[Address(RVA = "0x1400B84", Offset = "0x1400B84", VA = "0x1400B84")]
	public UIAwakenStoryItemView()
	{
	}

	[Token(Token = "0x6015F60")]
	[Address(RVA = "0x1400B8C", Offset = "0x1400B8C", VA = "0x1400B8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F61")]
	[Address(RVA = "0x1400D94", Offset = "0x1400D94", VA = "0x1400D94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
