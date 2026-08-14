using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027A8")]
public class UIHudLuckyDrawBoxController : UIBaseController
{
	[Token(Token = "0x400F4CA")]
	private const string TITLEGUIDEKEY = "TITLEGUIDEKEY";

	[Token(Token = "0x400F4CB")]
	private const string BUYITEMGUIDEKEY = "BUYITEMGUIDEKEY";

	[Token(Token = "0x400F4CC")]
	[FieldOffset(Offset = "0x28")]
	private Color LEVEL2TAGCOLOR;

	[Token(Token = "0x400F4CD")]
	[FieldOffset(Offset = "0x38")]
	private Color LEVEL3TAGCOLOR;

	[Token(Token = "0x400F4CE")]
	private const uint ITEMCOUNT = 5u;

	[Token(Token = "0x400F4CF")]
	[FieldOffset(Offset = "0x48")]
	private UIHudLuckyDrawBoxView m_View;

	[Token(Token = "0x400F4D0")]
	[FieldOffset(Offset = "0x4C")]
	private LevelLuckyDrawBox m_Box;

	[Token(Token = "0x400F4D1")]
	[FieldOffset(Offset = "0x50")]
	private UIInGameScene m_InGameScene;

	[Token(Token = "0x400F4D2")]
	[FieldOffset(Offset = "0x54")]
	private List<UIHudLuckyDrawBoxItemController> m_Items;

	[Token(Token = "0x400F4D3")]
	[FieldOffset(Offset = "0x58")]
	private uint m_RefreshPrice;

	[Token(Token = "0x400F4D4")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_BuyPirce;

	[Token(Token = "0x400F4D5")]
	[FieldOffset(Offset = "0x60")]
	private uint m_Seconds;

	[Token(Token = "0x400F4D6")]
	[FieldOffset(Offset = "0x64")]
	private uint m_Min;

	[Token(Token = "0x400F4D7")]
	[FieldOffset(Offset = "0x68")]
	private uint m_Second;

	[Token(Token = "0x400F4D8")]
	[FieldOffset(Offset = "0x6C")]
	private string m_LabelUpdate;

	[Token(Token = "0x400F4D9")]
	[FieldOffset(Offset = "0x70")]
	private uint m_EndTime;

	[Token(Token = "0x400F4DA")]
	[FieldOffset(Offset = "0x74")]
	private uint m_TimeLength;

	[Token(Token = "0x400F4DB")]
	[FieldOffset(Offset = "0x78")]
	private bool m_updatedToMaxLv;

	[Token(Token = "0x400F4DC")]
	[FieldOffset(Offset = "0x7C")]
	private StringBuilder m_Timer;

	[Token(Token = "0x600F496")]
	[Address(RVA = "0xFEE7C8", Offset = "0xFEE7C8", VA = "0xFEE7C8")]
	public UIHudLuckyDrawBoxController()
	{
	}

	[Token(Token = "0x600F497")]
	[Address(RVA = "0xFEE900", Offset = "0xFEE900", VA = "0xFEE900")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F498")]
	[Address(RVA = "0xFEE9A8", Offset = "0xFEE9A8", VA = "0xFEE9A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F499")]
	[Address(RVA = "0xFEF078", Offset = "0xFEF078", VA = "0xFEF078")]
	private void InitItems()
	{
	}

	[Token(Token = "0x600F49A")]
	[Address(RVA = "0xFEF268", Offset = "0xFEF268", VA = "0xFEF268")]
	private void TryShowGuide()
	{
	}

	[Token(Token = "0x600F49B")]
	[Address(RVA = "0xFEF4A8", Offset = "0xFEF4A8", VA = "0xFEF4A8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600F49C")]
	[Address(RVA = "0xFEF604", Offset = "0xFEF604", VA = "0xFEF604")]
	public void SetViewData(LevelLuckyDrawBox box)
	{
	}

	[Token(Token = "0x600F49D")]
	[Address(RVA = "0xFF093C", Offset = "0xFF093C", VA = "0xFF093C")]
	private void PlayVfx(GameObject vfx)
	{
	}

	[Token(Token = "0x600F49E")]
	[Address(RVA = "0xFF0AC4", Offset = "0xFF0AC4", VA = "0xFF0AC4")]
	private void OnBuyBtnClick()
	{
	}

	[Token(Token = "0x600F49F")]
	[Address(RVA = "0xFF0E58", Offset = "0xFF0E58", VA = "0xFF0E58")]
	private void OnRefreshBtnClick()
	{
	}

	[Token(Token = "0x600F4A0")]
	[Address(RVA = "0xFF11EC", Offset = "0xFF11EC", VA = "0xFF11EC")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600F4A1")]
	[Address(RVA = "0xFF13E0", Offset = "0xFF13E0", VA = "0xFF13E0")]
	private static void AppendMinOrSec(StringBuilder sb, uint min)
	{
	}

	[Token(Token = "0x600F4A2")]
	[Address(RVA = "0xFF14B0", Offset = "0xFF14B0", VA = "0xFF14B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600F4A3")]
	[Address(RVA = "0xFF165C", Offset = "0xFF165C", VA = "0xFF165C")]
	private void RefreshCountDown()
	{
	}

	[Token(Token = "0x600F4A4")]
	[Address(RVA = "0xFEF77C", Offset = "0xFEF77C", VA = "0xFEF77C")]
	private void RefreshLevel()
	{
	}

	[Token(Token = "0x600F4A5")]
	[Address(RVA = "0xFF05F4", Offset = "0xFF05F4", VA = "0xFF05F4")]
	private void RefreshItems()
	{
	}

	[Token(Token = "0x600F4A6")]
	[Address(RVA = "0xFEFDB0", Offset = "0xFEFDB0", VA = "0xFEFDB0")]
	private void RefreshPrice()
	{
	}

	[Token(Token = "0x600F4A7")]
	[Address(RVA = "0xFF22B8", Offset = "0xFF22B8", VA = "0xFF22B8")]
	private void OnClose(object[] param)
	{
	}

	[Token(Token = "0x600F4A8")]
	[Address(RVA = "0xFF2424", Offset = "0xFF2424", VA = "0xFF2424")]
	private void OnForceClose(object[] param)
	{
	}

	[Token(Token = "0x600F4A9")]
	[Address(RVA = "0xFF248C", Offset = "0xFF248C", VA = "0xFF248C")]
	private void OnLevelUp(object[] param)
	{
	}

	[Token(Token = "0x600F4AA")]
	[Address(RVA = "0xFF2644", Offset = "0xFF2644", VA = "0xFF2644")]
	private void OnRefresh(object[] param)
	{
	}

	[Token(Token = "0x600F4AB")]
	[Address(RVA = "0xFF27D8", Offset = "0xFF27D8", VA = "0xFF27D8")]
	private void OnGuideBuy(object[] param)
	{
	}

	[Token(Token = "0x600F4AC")]
	[Address(RVA = "0xFF2934", Offset = "0xFF2934", VA = "0xFF2934")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600F4AD")]
	[Address(RVA = "0xFF2B18", Offset = "0xFF2B18", VA = "0xFF2B18")]
	private void OnPlayerKnockDown(object[] data)
	{
	}

	[Token(Token = "0x600F4AE")]
	[Address(RVA = "0xFF2CC4", Offset = "0xFF2CC4", VA = "0xFF2CC4")]
	private void OnTokenChanged(object[] data)
	{
	}

	[Token(Token = "0x600F4AF")]
	[Address(RVA = "0xFF20D8", Offset = "0xFF20D8", VA = "0xFF20D8")]
	private void RefreshPriceLabelColorOnBoxRefresh()
	{
	}

	[Token(Token = "0x600F4B0")]
	[Address(RVA = "0xFF2DEC", Offset = "0xFF2DEC", VA = "0xFF2DEC")]
	private void RefreshPriceLabelColor(int tokenCount)
	{
	}

	[Token(Token = "0x600F4B1")]
	[Address(RVA = "0xFF2F64", Offset = "0xFF2F64", VA = "0xFF2F64")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F4B2")]
	[Address(RVA = "0xFF2F6C", Offset = "0xFF2F6C", VA = "0xFF2F6C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
