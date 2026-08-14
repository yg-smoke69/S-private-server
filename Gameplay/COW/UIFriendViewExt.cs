using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A9E")]
internal class UIFriendViewExt : UIFriendView
{
	[Token(Token = "0x4018ECB")]
	[FieldOffset(Offset = "0xA0")]
	public int ScrollViewTopAnchorDefault;

	[Token(Token = "0x4018ECC")]
	[FieldOffset(Offset = "0xA4")]
	public Vector3 ListContainerDefaultPos;

	[Token(Token = "0x601739D")]
	[Address(RVA = "0x2514744", Offset = "0x2514744", VA = "0x2514744")]
	public UIFriendViewExt()
	{
	}

	[Token(Token = "0x601739E")]
	[Address(RVA = "0x251474C", Offset = "0x251474C", VA = "0x251474C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601739F")]
	[Address(RVA = "0x2514864", Offset = "0x2514864", VA = "0x2514864")]
	public new void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
