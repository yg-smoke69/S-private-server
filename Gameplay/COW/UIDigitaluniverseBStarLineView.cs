using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034DE")]
public class UIDigitaluniverseBStarLineView : UIBaseView
{
	[Token(Token = "0x4014C5F")]
	[FieldOffset(Offset = "0x14")]
	public Animation StarLineAni;

	[Token(Token = "0x4014C60")]
	[FieldOffset(Offset = "0x18")]
	public LineRendererHelper StarLineRendererHelper;

	[Token(Token = "0x601624C")]
	[Address(RVA = "0x2F0DDB4", Offset = "0x2F0DDB4", VA = "0x2F0DDB4")]
	public UIDigitaluniverseBStarLineView()
	{
	}

	[Token(Token = "0x601624D")]
	[Address(RVA = "0x2F0DDBC", Offset = "0x2F0DDBC", VA = "0x2F0DDBC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601624E")]
	[Address(RVA = "0x2F0DFC4", Offset = "0x2F0DFC4", VA = "0x2F0DFC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
