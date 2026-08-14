using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C9")]
public class UIAvatarLevelUpItemView : UIBaseView
{
	[Token(Token = "0x4013CCE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject OwnContent;

	[Token(Token = "0x4013CCF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ObtainTxt;

	[Token(Token = "0x6015F11")]
	[Address(RVA = "0x2A81484", Offset = "0x2A81484", VA = "0x2A81484")]
	public UIAvatarLevelUpItemView()
	{
	}

	[Token(Token = "0x6015F12")]
	[Address(RVA = "0x2A8148C", Offset = "0x2A8148C", VA = "0x2A8148C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F13")]
	[Address(RVA = "0x2A81688", Offset = "0x2A81688", VA = "0x2A81688")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
