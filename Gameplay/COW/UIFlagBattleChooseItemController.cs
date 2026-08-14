using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002613")]
public class UIFlagBattleChooseItemController : UIBaseController
{
	[Token(Token = "0x400EB07")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BgSprite;

	[Token(Token = "0x400EB08")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Desc;

	[Token(Token = "0x400EB09")]
	[FieldOffset(Offset = "0x30")]
	public uint AttributeId;

	[Token(Token = "0x400EB0A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton Btn;

	[Token(Token = "0x400EB0B")]
	[FieldOffset(Offset = "0x38")]
	public byte Lv;

	[Token(Token = "0x400EB0C")]
	[FieldOffset(Offset = "0x3C")]
	public Transform VFXPos;

	[Token(Token = "0x400EB0D")]
	[FieldOffset(Offset = "0x40")]
	private ResourceID vfxResId;

	[Token(Token = "0x400EB0E")]
	[FieldOffset(Offset = "0x44")]
	private GameObject vfxG0;

	[Token(Token = "0x400EB0F")]
	[FieldOffset(Offset = "0x48")]
	private HHOEOEIIHOJ m_Config;

	[Token(Token = "0x600E155")]
	[Address(RVA = "0x1DBF4FC", Offset = "0x1DBF4FC", VA = "0x1DBF4FC")]
	public UIFlagBattleChooseItemController()
	{
	}

	[Token(Token = "0x600E156")]
	[Address(RVA = "0x1DBF5C8", Offset = "0x1DBF5C8", VA = "0x1DBF5C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E157")]
	[Address(RVA = "0x1DBF6F4", Offset = "0x1DBF6F4", VA = "0x1DBF6F4")]
	public void SetData(FlagBattleAttributesInfoData data, HHOEOEIIHOJ config, byte lv)
	{
	}

	[Token(Token = "0x600E158")]
	[Address(RVA = "0x1DBFCB8", Offset = "0x1DBFCB8", VA = "0x1DBFCB8")]
	public void OnBtnClick()
	{
	}

	[Token(Token = "0x600E159")]
	[Address(RVA = "0x1DC0084", Offset = "0x1DC0084", VA = "0x1DC0084")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
