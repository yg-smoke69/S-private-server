using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029A8")]
public class UIMatchResultRewardWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20029A9")]
	public enum EMatchResultState
	{
		[Token(Token = "0x401006F")]
		None,
		[Token(Token = "0x4010070")]
		Reward,
		[Token(Token = "0x4010071")]
		Challenge,
		[Token(Token = "0x4010072")]
		Both
	}

	[Token(Token = "0x20029AA")]
	private enum MatchResultItemState
	{
		[Token(Token = "0x4010074")]
		Link,
		[Token(Token = "0x4010075")]
		Debris,
		[Token(Token = "0x4010076")]
		Token
	}

	[Token(Token = "0x20029AB")]
	private sealed class _003CDelayCallShowRewards_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010077")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x4010078")]
		[FieldOffset(Offset = "0xC")]
		internal UIMatchResultRewardWndController _0024this;

		[Token(Token = "0x6010BED")]
		[Address(RVA = "0x2681BDC", Offset = "0x2681BDC", VA = "0x2681BDC")]
		public _003CDelayCallShowRewards_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010BEE")]
		[Address(RVA = "0x2683A78", Offset = "0x2683A78", VA = "0x2683A78")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20029AC")]
	private sealed class _003CSkinAni_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010079")]
		[FieldOffset(Offset = "0x8")]
		internal int tmp;

		[Token(Token = "0x401007A")]
		[FieldOffset(Offset = "0xC")]
		internal UIMatchResultRewardWndController _0024this;

		[Token(Token = "0x6010BEF")]
		[Address(RVA = "0x2682294", Offset = "0x2682294", VA = "0x2682294")]
		public _003CSkinAni_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010BF0")]
		[Address(RVA = "0x2683D60", Offset = "0x2683D60", VA = "0x2683D60")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401005A")]
	private const int MOVENUM = 3;

	[Token(Token = "0x401005B")]
	private const int HALFITEMWIDTH = 72;

	[Token(Token = "0x401005C")]
	private const int TIPSOFFESTLEFT = 6;

	[Token(Token = "0x401005D")]
	private const int TIPSOFFESTRIGHT = 30;

	[Token(Token = "0x401005E")]
	private const int OFFSET = 2;

	[Token(Token = "0x401005F")]
	[FieldOffset(Offset = "0x48")]
	private UIMatchResultRewardWndView m_View;

	[Token(Token = "0x4010060")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x4010061")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<UIMatchResultRewardItemController> m_MatchResultRewardItemList;

	[Token(Token = "0x4010062")]
	[FieldOffset(Offset = "0x54")]
	private List<uint> m_DelayCallItemList;

	[Token(Token = "0x4010063")]
	[FieldOffset(Offset = "0x58")]
	private uint m_DelayCallISkipAni;

	[Token(Token = "0x4010064")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_DelayCallTaskSkipAni;

	[Token(Token = "0x4010065")]
	[FieldOffset(Offset = "0x60")]
	private int m_Index;

	[Token(Token = "0x4010066")]
	[FieldOffset(Offset = "0x64")]
	private int m_ItemCount;

	[Token(Token = "0x4010067")]
	private const float DELAYTIMESTART = 0.066f;

	[Token(Token = "0x4010068")]
	private const float DELAYTIMEITEM = 0.3f;

	[Token(Token = "0x4010069")]
	private const float DELAYTIMESKIPMASK = 4f;

	[Token(Token = "0x401006A")]
	private const float DELAYTIMESKIPANI = 0.1f;

	[Token(Token = "0x401006B")]
	private const float DELAYTASKTIMESKIPANI = 1.5f;

	[Token(Token = "0x401006C")]
	[FieldOffset(Offset = "0x68")]
	private EMatchResultState m_ResultState;

	[Token(Token = "0x401006D")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_RewardLeftPos;

	[Token(Token = "0x6010BD3")]
	[Address(RVA = "0x267FF14", Offset = "0x267FF14", VA = "0x267FF14")]
	public UIMatchResultRewardWndController()
	{
	}

	[Token(Token = "0x6010BD4")]
	[Address(RVA = "0x2680018", Offset = "0x2680018", VA = "0x2680018")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010BD5")]
	[Address(RVA = "0x26800BC", Offset = "0x26800BC", VA = "0x26800BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010BD6")]
	[Address(RVA = "0x268065C", Offset = "0x268065C", VA = "0x268065C")]
	private void InitLabel()
	{
	}

	[Token(Token = "0x6010BD7")]
	[Address(RVA = "0x26808FC", Offset = "0x26808FC", VA = "0x26808FC")]
	public void HideContent()
	{
	}

	[Token(Token = "0x6010BD8")]
	[Address(RVA = "0x26809C4", Offset = "0x26809C4", VA = "0x26809C4")]
	public void SetContent()
	{
	}

	[Token(Token = "0x6010BD9")]
	[Address(RVA = "0x2680A88", Offset = "0x2680A88", VA = "0x2680A88")]
	public void SetRewards()
	{
	}

	[Token(Token = "0x6010BDA")]
	[Address(RVA = "0x26810F0", Offset = "0x26810F0", VA = "0x26810F0")]
	public void SetTasks()
	{
	}

	[Token(Token = "0x6010BDB")]
	[Address(RVA = "0x2681638", Offset = "0x2681638", VA = "0x2681638")]
	public void SetLineView()
	{
	}

	[Token(Token = "0x6010BDC")]
	[Address(RVA = "0x2681B7C", Offset = "0x2681B7C", VA = "0x2681B7C")]
	public void SetResultState(uint state)
	{
	}

	[Token(Token = "0x6010BDD")]
	[Address(RVA = "0x26819C8", Offset = "0x26819C8", VA = "0x26819C8")]
	private void AdjustPivot()
	{
	}

	[Token(Token = "0x6010BDE")]
	[Address(RVA = "0x2681748", Offset = "0x2681748", VA = "0x2681748")]
	private void DelayCallShowRewards()
	{
	}

	[Token(Token = "0x6010BDF")]
	[Address(RVA = "0x2681BE4", Offset = "0x2681BE4", VA = "0x2681BE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010BE0")]
	[Address(RVA = "0x2681F08", Offset = "0x2681F08", VA = "0x2681F08", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x6010BE1")]
	[Address(RVA = "0x2681F60", Offset = "0x2681F60", VA = "0x2681F60")]
	private void CloseWnd(object[] data)
	{
	}

	[Token(Token = "0x6010BE2")]
	[Address(RVA = "0x2681FCC", Offset = "0x2681FCC", VA = "0x2681FCC")]
	private void SkinAni()
	{
	}

	[Token(Token = "0x6010BE3")]
	[Address(RVA = "0x268229C", Offset = "0x268229C", VA = "0x268229C")]
	private void OpenTipsToday()
	{
	}

	[Token(Token = "0x6010BE4")]
	[Address(RVA = "0x2682638", Offset = "0x2682638", VA = "0x2682638")]
	private void OpenTipsOwned()
	{
	}

	[Token(Token = "0x6010BE5")]
	[Address(RVA = "0x26829D4", Offset = "0x26829D4", VA = "0x26829D4")]
	private void OpenBuffDetail()
	{
	}

	[Token(Token = "0x6010BE6")]
	[Address(RVA = "0x2683714", Offset = "0x2683714", VA = "0x2683714", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010BE7")]
	[Address(RVA = "0x2683844", Offset = "0x2683844", VA = "0x2683844", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6010BE8")]
	[Address(RVA = "0x26838C0", Offset = "0x26838C0", VA = "0x26838C0")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6010BE9")]
	[Address(RVA = "0x2683990", Offset = "0x2683990", VA = "0x2683990")]
	private void _003CSetTasks_003Em__1()
	{
	}

	[Token(Token = "0x6010BEA")]
	[Address(RVA = "0x2683A60", Offset = "0x2683A60", VA = "0x2683A60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010BEB")]
	[Address(RVA = "0x2683A68", Offset = "0x2683A68", VA = "0x2683A68")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010BEC")]
	[Address(RVA = "0x2683A70", Offset = "0x2683A70", VA = "0x2683A70")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}
}
