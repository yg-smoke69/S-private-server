using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D1")]
public class UIAvatarListView : UIBaseView
{
	[Token(Token = "0x4013D7E")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView AvatarListScrollView;

	[Token(Token = "0x4013D7F")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList EasyList;

	[Token(Token = "0x4013D80")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LeftArrowBtn;

	[Token(Token = "0x4013D81")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RightArrowBtn;

	[Token(Token = "0x6015F29")]
	[Address(RVA = "0x2B5D3D8", Offset = "0x2B5D3D8", VA = "0x2B5D3D8")]
	public UIAvatarListView()
	{
	}

	[Token(Token = "0x6015F2A")]
	[Address(RVA = "0x2B5D3E0", Offset = "0x2B5D3E0", VA = "0x2B5D3E0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F2B")]
	[Address(RVA = "0x2B5D6A8", Offset = "0x2B5D6A8", VA = "0x2B5D6A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
