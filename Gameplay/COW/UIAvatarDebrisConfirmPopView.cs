using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C6")]
public class UIAvatarDebrisConfirmPopView : UIBaseView
{
	[Token(Token = "0x4013CBE")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PopType2;

	[Token(Token = "0x4013CBF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Newtips1;

	[Token(Token = "0x4013CC0")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton OkBtn;

	[Token(Token = "0x4013CC1")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CancelBtn1;

	[Token(Token = "0x6015F08")]
	[Address(RVA = "0x2A7EFC8", Offset = "0x2A7EFC8", VA = "0x2A7EFC8")]
	public UIAvatarDebrisConfirmPopView()
	{
	}

	[Token(Token = "0x6015F09")]
	[Address(RVA = "0x2A7EFD0", Offset = "0x2A7EFD0", VA = "0x2A7EFD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F0A")]
	[Address(RVA = "0x2A7F28C", Offset = "0x2A7F28C", VA = "0x2A7F28C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
