using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003680")]
public class UIHudInventoryTagView : UIBaseView
{
	[Token(Token = "0x4015E60")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TagLabel;

	[Token(Token = "0x4015E61")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TagSprite;

	[Token(Token = "0x4015E62")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Tag1Btn;

	[Token(Token = "0x601672D")]
	[Address(RVA = "0x209EC8C", Offset = "0x209EC8C", VA = "0x209EC8C")]
	public UIHudInventoryTagView()
	{
	}

	[Token(Token = "0x601672E")]
	[Address(RVA = "0x209EC94", Offset = "0x209EC94", VA = "0x209EC94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601672F")]
	[Address(RVA = "0x209EEFC", Offset = "0x209EEFC", VA = "0x209EEFC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
