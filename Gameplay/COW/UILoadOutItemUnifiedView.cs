using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003834")]
public class UILoadOutItemUnifiedView : UIBaseView
{
	[Token(Token = "0x4016EBB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PlayCardGameObj;

	[Token(Token = "0x4016EBC")]
	[FieldOffset(Offset = "0x18")]
	public UISprite PlayCardIcon;

	[Token(Token = "0x4016EBD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Remain;

	[Token(Token = "0x4016EBE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Content;

	[Token(Token = "0x4016EBF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Mask;

	[Token(Token = "0x4016EC0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ShopIcon;

	[Token(Token = "0x6016C47")]
	[Address(RVA = "0x214F2B8", Offset = "0x214F2B8", VA = "0x214F2B8")]
	public UILoadOutItemUnifiedView()
	{
	}

	[Token(Token = "0x6016C48")]
	[Address(RVA = "0x214F2C0", Offset = "0x214F2C0", VA = "0x214F2C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C49")]
	[Address(RVA = "0x214F618", Offset = "0x214F618", VA = "0x214F618")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
