using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003764")]
public class UIHudSwitchWeaponView : UIBaseView
{
	[Token(Token = "0x401669A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSwitch;

	[Token(Token = "0x401669B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SpriteFirst;

	[Token(Token = "0x401669C")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SpriteSecond;

	[Token(Token = "0x401669D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelInfo;

	[Token(Token = "0x401669E")]
	[FieldOffset(Offset = "0x24")]
	public ParticleSystem PaticleEffect;

	[Token(Token = "0x60169D7")]
	[Address(RVA = "0x1FF360C", Offset = "0x1FF360C", VA = "0x1FF360C")]
	public UIHudSwitchWeaponView()
	{
	}

	[Token(Token = "0x60169D8")]
	[Address(RVA = "0x1FF3614", Offset = "0x1FF3614", VA = "0x1FF3614", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169D9")]
	[Address(RVA = "0x1FF3924", Offset = "0x1FF3924", VA = "0x1FF3924")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
