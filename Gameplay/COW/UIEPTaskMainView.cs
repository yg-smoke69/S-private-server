using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003523")]
public class UIEPTaskMainView : UIBaseView
{
	[Token(Token = "0x4014F9E")]
	[FieldOffset(Offset = "0x14")]
	public Transform TopTabContainer;

	[Token(Token = "0x4014F9F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x4014FA0")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BG;

	[Token(Token = "0x6016319")]
	[Address(RVA = "0x2BB4444", Offset = "0x2BB4444", VA = "0x2BB4444")]
	public UIEPTaskMainView()
	{
	}

	[Token(Token = "0x601631A")]
	[Address(RVA = "0x2BB444C", Offset = "0x2BB444C", VA = "0x2BB444C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601631B")]
	[Address(RVA = "0x2BB4680", Offset = "0x2BB4680", VA = "0x2BB4680")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
