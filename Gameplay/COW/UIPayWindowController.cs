using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A47")]
public class UIPayWindowController : UIPopupWindowController
{
	[Token(Token = "0x2002A48")]
	private class ImageIterator
	{
		[Token(Token = "0x2002A49")]
		public enum ImageType
		{
			[Token(Token = "0x40103EA")]
			MainImage,
			[Token(Token = "0x40103EB")]
			SubImage
		}

		[Token(Token = "0x40103E4")]
		[FieldOffset(Offset = "0x0")]
		private static ImageIterator _I;

		[Token(Token = "0x40103E5")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<int, int> PoolState;

		[Token(Token = "0x40103E6")]
		[FieldOffset(Offset = "0xC")]
		public Dictionary<int, List<string>> IndexPool;

		[Token(Token = "0x40103E7")]
		[FieldOffset(Offset = "0x4")]
		private static Converter<CSVBaseData, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x40103E8")]
		[FieldOffset(Offset = "0x8")]
		private static Converter<CSVBaseData, string> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x170012C1")]
		public static ImageIterator I
		{
			[Token(Token = "0x6011299")]
			[Address(RVA = "0x15B9748", Offset = "0x15B9748", VA = "0x15B9748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011298")]
		[Address(RVA = "0x15BB6C4", Offset = "0x15BB6C4", VA = "0x15BB6C4")]
		private ImageIterator()
		{
		}

		[Token(Token = "0x601129A")]
		[Address(RVA = "0x15B9B14", Offset = "0x15B9B14", VA = "0x15B9B14")]
		public string Next(ImageType type)
		{
			return null;
		}

		[Token(Token = "0x601129B")]
		[Address(RVA = "0x15BB784", Offset = "0x15BB784", VA = "0x15BB784")]
		private static string _003Cget_I_003Em__0(CSVBaseData csvBaseData)
		{
			return null;
		}

		[Token(Token = "0x601129C")]
		[Address(RVA = "0x15BB858", Offset = "0x15BB858", VA = "0x15BB858")]
		private static string _003Cget_I_003Em__1(CSVBaseData csvBaseData)
		{
			return null;
		}
	}

	[Token(Token = "0x40103E1")]
	[FieldOffset(Offset = "0x48")]
	private UIPayWindowView m_View;

	[Token(Token = "0x40103E2")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIPayItemController> _PayItemControllerList;

	[Token(Token = "0x40103E3")]
	[FieldOffset(Offset = "0x50")]
	private List<AdvertDesc> _MainAds;

	[Token(Token = "0x6011280")]
	[Address(RVA = "0x15B804C", Offset = "0x15B804C", VA = "0x15B804C")]
	public UIPayWindowController()
	{
	}

	[Token(Token = "0x6011281")]
	[Address(RVA = "0x15B80D8", Offset = "0x15B80D8", VA = "0x15B80D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011282")]
	[Address(RVA = "0x15B817C", Offset = "0x15B817C", VA = "0x15B817C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011283")]
	[Address(RVA = "0x15B8BF4", Offset = "0x15B8BF4", VA = "0x15B8BF4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011284")]
	[Address(RVA = "0x15B8D90", Offset = "0x15B8D90", VA = "0x15B8D90")]
	private void ClearPayItemControllers()
	{
	}

	[Token(Token = "0x6011285")]
	[Address(RVA = "0x15B88B0", Offset = "0x15B88B0", VA = "0x15B88B0")]
	private void MakePayItemControllers()
	{
	}

	[Token(Token = "0x6011286")]
	[Address(RVA = "0x15B86D4", Offset = "0x15B86D4", VA = "0x15B86D4")]
	private void TogglePaymentPlatform()
	{
	}

	[Token(Token = "0x6011287")]
	[Address(RVA = "0x15B879C", Offset = "0x15B879C", VA = "0x15B879C")]
	private void ApplyDisplayConfig()
	{
	}

	[Token(Token = "0x6011288")]
	[Address(RVA = "0x15B8F60", Offset = "0x15B8F60", VA = "0x15B8F60")]
	private void GotCdnUrl(object[] parameters)
	{
	}

	[Token(Token = "0x6011289")]
	[Address(RVA = "0x15B9F50", Offset = "0x15B9F50", VA = "0x15B9F50")]
	private void OnMainAdButtonClick()
	{
	}

	[Token(Token = "0x601128A")]
	[Address(RVA = "0x15B9624", Offset = "0x15B9624", VA = "0x15B9624")]
	private bool IsPaid()
	{
		return default(bool);
	}

	[Token(Token = "0x601128B")]
	[Address(RVA = "0x15BA108", Offset = "0x15BA108", VA = "0x15BA108")]
	private void ApplyCdnUrlKeyToNetworkTexture(UINetworkTextureExt networkTexture, string key)
	{
	}

	[Token(Token = "0x601128C")]
	[Address(RVA = "0x15B9EA4", Offset = "0x15B9EA4", VA = "0x15B9EA4")]
	private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
	{
	}

	[Token(Token = "0x601128D")]
	[Address(RVA = "0x15BA250", Offset = "0x15BA250", VA = "0x15BA250")]
	public void OnCloseClick()
	{
	}

	[Token(Token = "0x601128E")]
	[Address(RVA = "0x15BA4C0", Offset = "0x15BA4C0", VA = "0x15BA4C0")]
	public void OnAndroidIAPButtonClick()
	{
	}

	[Token(Token = "0x601128F")]
	[Address(RVA = "0x15BA8B0", Offset = "0x15BA8B0", VA = "0x15BA8B0")]
	public void OnAndroidAdButtonClick()
	{
	}

	[Token(Token = "0x6011290")]
	[Address(RVA = "0x15BACDC", Offset = "0x15BACDC", VA = "0x15BACDC")]
	private void OnRebateCardButtonClick()
	{
	}

	[Token(Token = "0x6011291")]
	[Address(RVA = "0x15BADC4", Offset = "0x15BADC4", VA = "0x15BADC4")]
	private void OnPayItemsDataLoaded(object[] parameters)
	{
	}

	[Token(Token = "0x6011292")]
	[Address(RVA = "0x15BAE2C", Offset = "0x15BAE2C", VA = "0x15BAE2C")]
	private void OnPayItemClick(object[] parameters)
	{
	}

	[Token(Token = "0x6011293")]
	[Address(RVA = "0x15BB428", Offset = "0x15BB428", VA = "0x15BB428")]
	private void OnPayContinue(object[] parameters)
	{
	}

	[Token(Token = "0x6011294")]
	[Address(RVA = "0x15BB484", Offset = "0x15BB484", VA = "0x15BB484")]
	private void OnPaySuccess(object[] parameters)
	{
	}

	[Token(Token = "0x6011295")]
	[Address(RVA = "0x15BB658", Offset = "0x15BB658", VA = "0x15BB658")]
	private void OnPayFailure(object[] parameters)
	{
	}

	[Token(Token = "0x6011296")]
	[Address(RVA = "0x15BB6B4", Offset = "0x15BB6B4", VA = "0x15BB6B4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011297")]
	[Address(RVA = "0x15BB6BC", Offset = "0x15BB6BC", VA = "0x15BB6BC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
