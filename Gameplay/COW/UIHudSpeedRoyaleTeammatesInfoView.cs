using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200375A")]
internal class UIHudSpeedRoyaleTeammatesInfoView : UIBaseView
{
	[Token(Token = "0x4016666")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4016667")]
	[FieldOffset(Offset = "0x18")]
	public UIHudSpeedRoyaleTeammateItem TeammateTemplate;

	[Token(Token = "0x4016668")]
	[FieldOffset(Offset = "0x1C")]
	public UIHudSpeedRoyaleTeammateGroup TeammateGroupTemplate;

	[Token(Token = "0x60169B9")]
	[Address(RVA = "0x1FE3F8C", Offset = "0x1FE3F8C", VA = "0x1FE3F8C")]
	public UIHudSpeedRoyaleTeammatesInfoView()
	{
	}

	[Token(Token = "0x60169BA")]
	[Address(RVA = "0x1FE3F94", Offset = "0x1FE3F94", VA = "0x1FE3F94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169BB")]
	[Address(RVA = "0x1FE41FC", Offset = "0x1FE41FC", VA = "0x1FE41FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
