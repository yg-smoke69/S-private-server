using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200389D")]
public class UIMatchResultZombieScreenshotTeammateItemView : UIBaseView
{
	[Token(Token = "0x401766E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite WeaponIcon;

	[Token(Token = "0x401766F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Nickname;

	[Token(Token = "0x4017670")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Damages;

	[Token(Token = "0x4017671")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MVPIcon;

	[Token(Token = "0x6016D82")]
	[Address(RVA = "0x2690504", Offset = "0x2690504", VA = "0x2690504")]
	public UIMatchResultZombieScreenshotTeammateItemView()
	{
	}

	[Token(Token = "0x6016D83")]
	[Address(RVA = "0x269050C", Offset = "0x269050C", VA = "0x269050C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D84")]
	[Address(RVA = "0x26907C8", Offset = "0x26907C8", VA = "0x26907C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
