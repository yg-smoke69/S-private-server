using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029F0")]
internal class UINewVaultClothSetRecommendController : UIBaseController
{
	[Token(Token = "0x20029F1")]
	private sealed class _003COnDressUpClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x40101FB")]
		[FieldOffset(Offset = "0x8")]
		internal AvatarWardrobeData selectClothData;

		[Token(Token = "0x6010E79")]
		[Address(RVA = "0x2C016A0", Offset = "0x2C016A0", VA = "0x2C016A0")]
		public _003COnDressUpClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010E7A")]
		[Address(RVA = "0x2C016A8", Offset = "0x2C016A8", VA = "0x2C016A8")]
		internal bool _003C_003Em__0(AvatarWardrobeData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40101F4")]
	[FieldOffset(Offset = "0x28")]
	private UINewVaultClothSetRecommendView m_View;

	[Token(Token = "0x40101F5")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_SelectClothID;

	[Token(Token = "0x40101F6")]
	[FieldOffset(Offset = "0x30")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x40101F7")]
	[FieldOffset(Offset = "0x34")]
	private UIModelAvatar m_ModelAvatar;

	[Token(Token = "0x40101F8")]
	[FieldOffset(Offset = "0x38")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x40101F9")]
	[FieldOffset(Offset = "0x3C")]
	private Action OnClose;

	[Token(Token = "0x40101FA")]
	[FieldOffset(Offset = "0x40")]
	private List<UIStandardItemMAXBController> m_ClothSetList;

	[Token(Token = "0x6010E6C")]
	[Address(RVA = "0x27B9398", Offset = "0x27B9398", VA = "0x27B9398")]
	public UINewVaultClothSetRecommendController()
	{
	}

	[Token(Token = "0x6010E6D")]
	[Address(RVA = "0x27B941C", Offset = "0x27B941C", VA = "0x27B941C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010E6E")]
	[Address(RVA = "0x27B94C4", Offset = "0x27B94C4", VA = "0x27B94C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010E6F")]
	[Address(RVA = "0x27B9708", Offset = "0x27B9708", VA = "0x27B9708", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010E70")]
	[Address(RVA = "0x27B976C", Offset = "0x27B976C", VA = "0x27B976C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010E71")]
	[Address(RVA = "0x27B97E4", Offset = "0x27B97E4", VA = "0x27B97E4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6010E72")]
	[Address(RVA = "0x27B985C", Offset = "0x27B985C", VA = "0x27B985C")]
	public void SetViewData(uint selectClothID, UIWidget Clickbg, Action onClose)
	{
	}

	[Token(Token = "0x6010E73")]
	[Address(RVA = "0x27BA348", Offset = "0x27BA348", VA = "0x27BA348")]
	private AvatarWardrobeData GetRealLegendItemData(AvatarWardrobeData data)
	{
		return null;
	}

	[Token(Token = "0x6010E74")]
	[Address(RVA = "0x27BA554", Offset = "0x27BA554", VA = "0x27BA554")]
	private void OnDressUpClick()
	{
	}

	[Token(Token = "0x6010E75")]
	[Address(RVA = "0x27BB7C8", Offset = "0x27BB7C8", VA = "0x27BB7C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010E76")]
	[Address(RVA = "0x27BB7D0", Offset = "0x27BB7D0", VA = "0x27BB7D0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6010E77")]
	[Address(RVA = "0x27BB7D8", Offset = "0x27BB7D8", VA = "0x27BB7D8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010E78")]
	[Address(RVA = "0x27BB7E0", Offset = "0x27BB7E0", VA = "0x27BB7E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
