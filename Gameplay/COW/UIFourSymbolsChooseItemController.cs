using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200261A")]
public class UIFourSymbolsChooseItemController : UIBaseController
{
	[Token(Token = "0x400EB3A")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BgSprite;

	[Token(Token = "0x400EB3B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Desc;

	[Token(Token = "0x400EB3C")]
	[FieldOffset(Offset = "0x30")]
	public uint AttributeId;

	[Token(Token = "0x400EB3D")]
	[FieldOffset(Offset = "0x34")]
	public UIButton Btn;

	[Token(Token = "0x400EB3E")]
	[FieldOffset(Offset = "0x38")]
	public byte Lv;

	[Token(Token = "0x400EB3F")]
	[FieldOffset(Offset = "0x3C")]
	public Transform VFXPos;

	[Token(Token = "0x400EB40")]
	[FieldOffset(Offset = "0x40")]
	private ResourceID vfxResId;

	[Token(Token = "0x400EB41")]
	[FieldOffset(Offset = "0x44")]
	private GameObject vfxG0;

	[Token(Token = "0x400EB42")]
	[FieldOffset(Offset = "0x48")]
	private AKCEOOLDJHP m_Config;

	[Token(Token = "0x600E1BB")]
	[Address(RVA = "0x1B6B900", Offset = "0x1B6B900", VA = "0x1B6B900")]
	public UIFourSymbolsChooseItemController()
	{
	}

	[Token(Token = "0x600E1BC")]
	[Address(RVA = "0x1B6B9CC", Offset = "0x1B6B9CC", VA = "0x1B6B9CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E1BD")]
	[Address(RVA = "0x1B6BAF8", Offset = "0x1B6BAF8", VA = "0x1B6BAF8")]
	public void SetData(FourSymbolsAttributesInfoData data, AKCEOOLDJHP config, byte lv)
	{
	}

	[Token(Token = "0x600E1BE")]
	[Address(RVA = "0x1B6C0BC", Offset = "0x1B6C0BC", VA = "0x1B6C0BC")]
	public void OnBtnClick()
	{
	}

	[Token(Token = "0x600E1BF")]
	[Address(RVA = "0x1B6C488", Offset = "0x1B6C488", VA = "0x1B6C488")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
