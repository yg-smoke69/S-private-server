using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C9D")]
public abstract class UIFrontEndPreviewBackpackLevelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewBackpackLevelBaseView>
{
	[Token(Token = "0x401108D")]
	[FieldOffset(Offset = "0x38")]
	protected List<UIToggleButton> m_BackPackBtn;

	[Token(Token = "0x6012A5C")]
	[Address(RVA = "0x2517A44", Offset = "0x2517A44", VA = "0x2517A44")]
	protected UIFrontEndPreviewBackpackLevelBaseController()
	{
	}

	[Token(Token = "0x6012A5D")]
	[Address(RVA = "0x2517AA8", Offset = "0x2517AA8", VA = "0x2517AA8", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012A5E")]
	[Address(RVA = "0x2517B20", Offset = "0x2517B20", VA = "0x2517B20", Slot = "36")]
	protected virtual void InitBackPackBtnList()
	{
	}

	[Token(Token = "0x6012A5F")]
	[Address(RVA = "0x2517E7C", Offset = "0x2517E7C", VA = "0x2517E7C")]
	private void RefreshCollectionItemByLv(ECollectionLevel collectionLevel)
	{
	}

	[Token(Token = "0x6012A60")]
	[Address(RVA = "0x2518340", Offset = "0x2518340", VA = "0x2518340")]
	public void ClickDefaultBackPack()
	{
	}

	[Token(Token = "0x6012A61")]
	[Address(RVA = "0x25183D0", Offset = "0x25183D0", VA = "0x25183D0", Slot = "37")]
	public virtual uint GetBackpackSelectLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x6012A62")]
	[Address(RVA = "0x25184E8", Offset = "0x25184E8", VA = "0x25184E8")]
	public void ShowBackpackLevel()
	{
	}

	[Token(Token = "0x6012A63")]
	[Address(RVA = "0x251858C", Offset = "0x251858C", VA = "0x251858C")]
	public void HideBackpackLevel()
	{
	}

	[Token(Token = "0x6012A64")]
	[Address(RVA = "0x25181B0", Offset = "0x25181B0", VA = "0x25181B0")]
	private void Test_SwitchBackBagByLevel(ECollectionLevel collectionLevel)
	{
	}

	[Token(Token = "0x6012A65")]
	[Address(RVA = "0x25185F8", Offset = "0x25185F8", VA = "0x25185F8")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
