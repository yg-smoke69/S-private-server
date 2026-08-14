using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200248F")]
internal class UI2dCommonController : UIBaseController
{
	[Token(Token = "0x400E2AB")]
	[FieldOffset(Offset = "0x28")]
	private UI2dItemView m_View;

	[Token(Token = "0x400E2AC")]
	[FieldOffset(Offset = "0x2C")]
	public bool left;

	[Token(Token = "0x600D0D0")]
	[Address(RVA = "0x29F6CC4", Offset = "0x29F6CC4", VA = "0x29F6CC4")]
	public UI2dCommonController()
	{
	}

	[Token(Token = "0x600D0D1")]
	[Address(RVA = "0x29F6D48", Offset = "0x29F6D48", VA = "0x29F6D48")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0D2")]
	[Address(RVA = "0x29F6DF0", Offset = "0x29F6DF0", VA = "0x29F6DF0")]
	public void SetAnchorInspector(UIWidget item, GameObject go, int left, int right, int bottom, int top, float leftOri = 0f, float rightOri = 1f, float bottomOri = 0f, float topOri = 1f)
	{
	}

	[Token(Token = "0x600D0D3")]
	[Address(RVA = "0x29F70AC", Offset = "0x29F70AC", VA = "0x29F70AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0D4")]
	[Address(RVA = "0x29F7170", Offset = "0x29F7170", VA = "0x29F7170")]
	public void SetLeftAnchor(int biasLeft = 0, int biasRight = 0, int biasTop = 0, int biasBottom = 0)
	{
	}

	[Token(Token = "0x600D0D5")]
	[Address(RVA = "0x29F7264", Offset = "0x29F7264", VA = "0x29F7264")]
	public void SetRightAnchor()
	{
	}

	[Token(Token = "0x600D0D6")]
	[Address(RVA = "0x29F72C0", Offset = "0x29F72C0", VA = "0x29F72C0")]
	public void SetCommonDepth(int depth)
	{
	}

	[Token(Token = "0x600D0D7")]
	[Address(RVA = "0x29F7358", Offset = "0x29F7358", VA = "0x29F7358")]
	public void setUIdata(CSSharedItemData info, EFrontendUIType type)
	{
	}

	[Token(Token = "0x600D0D8")]
	[Address(RVA = "0x29F883C", Offset = "0x29F883C", VA = "0x29F883C")]
	public void SetSpecialUIdata(BaseItemInfo data, EFrontendUIType type)
	{
	}

	[Token(Token = "0x600D0D9")]
	[Address(RVA = "0x29F8A44", Offset = "0x29F8A44", VA = "0x29F8A44")]
	private void SetSPSpriteWithInfo(BaseItemInfo itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	[Token(Token = "0x600D0DA")]
	[Address(RVA = "0x29F8E5C", Offset = "0x29F8E5C", VA = "0x29F8E5C")]
	public void SetUIItemViewPos(Vector3 tr)
	{
	}

	[Token(Token = "0x600D0DB")]
	[Address(RVA = "0x29F8F3C", Offset = "0x29F8F3C", VA = "0x29F8F3C")]
	public void SetUIItemViewIconPos(Vector3 tr)
	{
	}

	[Token(Token = "0x600D0DC")]
	[Address(RVA = "0x29F901C", Offset = "0x29F901C", VA = "0x29F901C")]
	public void SetUIBannerViewPos(Vector3 tr)
	{
	}

	[Token(Token = "0x600D0DD")]
	[Address(RVA = "0x29F90DC", Offset = "0x29F90DC", VA = "0x29F90DC")]
	public void SetUIHeadPicViewPos(Vector3 tr)
	{
	}

	[Token(Token = "0x600D0DE")]
	[Address(RVA = "0x29F7DE0", Offset = "0x29F7DE0", VA = "0x29F7DE0")]
	private void SetSpriteWithInfo(CSSharedItemData itemInfo, UISprite iconSprite, bool isBigIcon = false)
	{
	}

	[Token(Token = "0x600D0DF")]
	[Address(RVA = "0x29F96C4", Offset = "0x29F96C4", VA = "0x29F96C4")]
	private void SetSpriteWithInfo(object[] data)
	{
	}

	[Token(Token = "0x600D0E0")]
	[Address(RVA = "0x29F919C", Offset = "0x29F919C", VA = "0x29F919C")]
	private void SetComposeIcon(UISprite iconSprite, UISprite sprite)
	{
	}

	[Token(Token = "0x600D0E1")]
	[Address(RVA = "0x29F9CF4", Offset = "0x29F9CF4", VA = "0x29F9CF4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
