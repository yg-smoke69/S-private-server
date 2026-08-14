using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A77")]
public class UIWeaponSkinUpgraderGunPickView : UIBaseView
{
	[Token(Token = "0x4018D2E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GunPickContainer;

	[Token(Token = "0x4018D2F")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView GunPickScrollView;

	[Token(Token = "0x4018D30")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid GunGrid;

	[Token(Token = "0x601730B")]
	[Address(RVA = "0x1B735F4", Offset = "0x1B735F4", VA = "0x1B735F4")]
	public UIWeaponSkinUpgraderGunPickView()
	{
	}

	[Token(Token = "0x601730C")]
	[Address(RVA = "0x1B735FC", Offset = "0x1B735FC", VA = "0x1B735FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601730D")]
	[Address(RVA = "0x1B73858", Offset = "0x1B73858", VA = "0x1B73858")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
