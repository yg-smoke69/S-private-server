using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C9C")]
internal class UIFrontEndPreview2DItemController : UIBaseController
{
	[Token(Token = "0x401108B")]
	[FieldOffset(Offset = "0x28")]
	private UIFrontEndPreview2DItemView m_View;

	[Token(Token = "0x401108C")]
	[FieldOffset(Offset = "0x2C")]
	public bool left;

	[Token(Token = "0x6012A4A")]
	[Address(RVA = "0x2514868", Offset = "0x2514868", VA = "0x2514868")]
	public UIFrontEndPreview2DItemController()
	{
	}

	[Token(Token = "0x6012A4B")]
	[Address(RVA = "0x25148EC", Offset = "0x25148EC", VA = "0x25148EC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012A4C")]
	[Address(RVA = "0x2514994", Offset = "0x2514994", VA = "0x2514994")]
	public void SetAnchorInspector(UIWidget item, GameObject go, int left, int right, int bottom, int top, float leftOri = 0f, float rightOri = 1f, float bottomOri = 0f, float topOri = 1f)
	{
	}

	[Token(Token = "0x6012A4D")]
	[Address(RVA = "0x2514C50", Offset = "0x2514C50", VA = "0x2514C50", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012A4E")]
	[Address(RVA = "0x2514E74", Offset = "0x2514E74", VA = "0x2514E74")]
	public void SetLeftAnchor(int biasLeft = 0, int biasRight = 0, int biasTop = 0, int biasBottom = 0)
	{
	}

	[Token(Token = "0x6012A4F")]
	[Address(RVA = "0x2514FA0", Offset = "0x2514FA0", VA = "0x2514FA0")]
	public void SetRightAnchor()
	{
	}

	[Token(Token = "0x6012A50")]
	[Address(RVA = "0x2514FFC", Offset = "0x2514FFC", VA = "0x2514FFC")]
	public void SetCommonDepth(int depth)
	{
	}

	[Token(Token = "0x6012A51")]
	[Address(RVA = "0x2515094", Offset = "0x2515094", VA = "0x2515094")]
	public void SetUIdata(CSSharedItemData info)
	{
	}

	[Token(Token = "0x6012A52")]
	[Address(RVA = "0x2516278", Offset = "0x2516278", VA = "0x2516278")]
	public void SetSpecialUIdata(BaseItemInfo data)
	{
	}

	[Token(Token = "0x6012A53")]
	[Address(RVA = "0x25163A0", Offset = "0x25163A0", VA = "0x25163A0")]
	private void SetSPSpriteWithInfo(BaseItemInfo itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	[Token(Token = "0x6012A54")]
	[Address(RVA = "0x25167B8", Offset = "0x25167B8", VA = "0x25167B8")]
	public void SetUIItemViewPos(Vector3 tr)
	{
	}

	[Token(Token = "0x6012A55")]
	[Address(RVA = "0x2516898", Offset = "0x2516898", VA = "0x2516898")]
	public void SetUIItemViewIconPos(Vector3 tr)
	{
	}

	[Token(Token = "0x6012A56")]
	[Address(RVA = "0x2516958", Offset = "0x2516958", VA = "0x2516958")]
	public void SetUIBannerViewPos(Vector3 tr)
	{
	}

	[Token(Token = "0x6012A57")]
	[Address(RVA = "0x2516A18", Offset = "0x2516A18", VA = "0x2516A18")]
	public void SetUIHeadPicViewPos(Vector3 tr)
	{
	}

	[Token(Token = "0x6012A58")]
	[Address(RVA = "0x251581C", Offset = "0x251581C", VA = "0x251581C")]
	private void SetSpriteWithInfo(CSSharedItemData itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	[Token(Token = "0x6012A59")]
	[Address(RVA = "0x2517000", Offset = "0x2517000", VA = "0x2517000")]
	private void SetSpriteWithInfo(object[] data)
	{
	}

	[Token(Token = "0x6012A5A")]
	[Address(RVA = "0x2516AD8", Offset = "0x2516AD8", VA = "0x2516AD8")]
	private void SetComposeIcon(UISprite iconSprite, UISprite sprite)
	{
	}

	[Token(Token = "0x6012A5B")]
	[Address(RVA = "0x2517630", Offset = "0x2517630", VA = "0x2517630")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
