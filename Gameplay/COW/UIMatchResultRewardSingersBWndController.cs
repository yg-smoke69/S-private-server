using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023AC")]
public class UIMatchResultRewardSingersBWndController : UIPopupWindowController
{
	[Token(Token = "0x20023AD")]
	private enum MatchResultItemState
	{
		[Token(Token = "0x400DE2E")]
		Link,
		[Token(Token = "0x400DE2F")]
		Debris,
		[Token(Token = "0x400DE30")]
		Token
	}

	[Token(Token = "0x20023AE")]
	private sealed class _003CDelayCallShowRewards_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DE31")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x400DE32")]
		[FieldOffset(Offset = "0xC")]
		internal UIMatchResultRewardSingersBWndController _0024this;

		[Token(Token = "0x600C8BC")]
		[Address(RVA = "0x267F600", Offset = "0x267F600", VA = "0x267F600")]
		public _003CDelayCallShowRewards_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C8BD")]
		[Address(RVA = "0x267F608", Offset = "0x267F608", VA = "0x267F608")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20023AF")]
	private sealed class _003CSkinAni_003Ec__AnonStorey1
	{
		[Token(Token = "0x400DE33")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x400DE34")]
		[FieldOffset(Offset = "0xC")]
		internal UIMatchResultRewardSingersBWndController _0024this;

		[Token(Token = "0x600C8BE")]
		[Address(RVA = "0x267F884", Offset = "0x267F884", VA = "0x267F884")]
		public _003CSkinAni_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600C8BF")]
		[Address(RVA = "0x267F88C", Offset = "0x267F88C", VA = "0x267F88C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400DE1D")]
	private const int MOVENUM = 5;

	[Token(Token = "0x400DE1E")]
	private const int HALFITEMWIDTH = 72;

	[Token(Token = "0x400DE1F")]
	private const int TIPSOFFESTLEFT = 19;

	[Token(Token = "0x400DE20")]
	private const int TIPSOFFESTRIGHT = 21;

	[Token(Token = "0x400DE21")]
	private const int OFFSET = 2;

	[Token(Token = "0x400DE22")]
	[FieldOffset(Offset = "0x48")]
	private UIMatchResultRewardSingersBWndView m_View;

	[Token(Token = "0x400DE23")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400DE24")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<UIMatchResultRewardSingersBItemController> m_MatchResultRewardItemList;

	[Token(Token = "0x400DE25")]
	[FieldOffset(Offset = "0x54")]
	private List<uint> m_DelayCallItemList;

	[Token(Token = "0x400DE26")]
	[FieldOffset(Offset = "0x58")]
	private uint m_DelayCallISkipAni;

	[Token(Token = "0x400DE27")]
	[FieldOffset(Offset = "0x5C")]
	private int m_Index;

	[Token(Token = "0x400DE28")]
	[FieldOffset(Offset = "0x60")]
	private int m_ItemCount;

	[Token(Token = "0x400DE29")]
	private const float DELAYTIMESTART = 0.066f;

	[Token(Token = "0x400DE2A")]
	private const float DELAYTIMEITEM = 0.3f;

	[Token(Token = "0x400DE2B")]
	private const float DELAYTIMESKIPMASK = 4f;

	[Token(Token = "0x400DE2C")]
	private const float DELAYTIMESKIPANI = 0.1f;

	[Token(Token = "0x600C8A9")]
	[Address(RVA = "0x281EB80", Offset = "0x281EB80", VA = "0x281EB80")]
	public UIMatchResultRewardSingersBWndController()
	{
	}

	[Token(Token = "0x600C8AA")]
	[Address(RVA = "0x281EC40", Offset = "0x281EC40", VA = "0x281EC40")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C8AB")]
	[Address(RVA = "0x281ECE8", Offset = "0x281ECE8", VA = "0x281ECE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C8AC")]
	[Address(RVA = "0x281F81C", Offset = "0x281F81C", VA = "0x281F81C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C8AD")]
	[Address(RVA = "0x281F194", Offset = "0x281F194", VA = "0x281F194")]
	private void SetRewards()
	{
	}

	[Token(Token = "0x600C8AE")]
	[Address(RVA = "0x281F888", Offset = "0x281F888", VA = "0x281F888")]
	private void DelayCallShowRewards()
	{
	}

	[Token(Token = "0x600C8AF")]
	[Address(RVA = "0x281FB08", Offset = "0x281FB08", VA = "0x281FB08")]
	private void ScrollTo(Vector3 pos)
	{
	}

	[Token(Token = "0x600C8B0")]
	[Address(RVA = "0x281FE6C", Offset = "0x281FE6C", VA = "0x281FE6C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C8B1")]
	[Address(RVA = "0x282011C", Offset = "0x282011C", VA = "0x282011C", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x600C8B2")]
	[Address(RVA = "0x2820174", Offset = "0x2820174", VA = "0x2820174")]
	private void CloseWnd(object[] data)
	{
	}

	[Token(Token = "0x600C8B3")]
	[Address(RVA = "0x28201E0", Offset = "0x28201E0", VA = "0x28201E0")]
	private void SkinAni()
	{
	}

	[Token(Token = "0x600C8B4")]
	[Address(RVA = "0x28204A4", Offset = "0x28204A4", VA = "0x28204A4")]
	private void OpenTipsToday()
	{
	}

	[Token(Token = "0x600C8B5")]
	[Address(RVA = "0x2820840", Offset = "0x2820840", VA = "0x2820840")]
	private void OpenTipsOwned()
	{
	}

	[Token(Token = "0x600C8B6")]
	[Address(RVA = "0x2820BDC", Offset = "0x2820BDC", VA = "0x2820BDC")]
	private void OpenBuffDetail()
	{
	}

	[Token(Token = "0x600C8B7")]
	[Address(RVA = "0x282191C", Offset = "0x282191C", VA = "0x282191C")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600C8B8")]
	[Address(RVA = "0x2821994", Offset = "0x2821994", VA = "0x2821994")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C8B9")]
	[Address(RVA = "0x282199C", Offset = "0x282199C", VA = "0x282199C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C8BA")]
	[Address(RVA = "0x28219A4", Offset = "0x28219A4", VA = "0x28219A4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600C8BB")]
	[Address(RVA = "0x28219AC", Offset = "0x28219AC", VA = "0x28219AC")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}
}
