using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020D4")]
public class UIEPDebrisRewardController : UIPopupWindowController
{
	[Token(Token = "0x20020D5")]
	private struct ProgressInfo
	{
		[Token(Token = "0x400CD82")]
		[FieldOffset(Offset = "0x0")]
		public float CurPercent;

		[Token(Token = "0x400CD83")]
		[FieldOffset(Offset = "0x4")]
		public float BeginProgressVal;

		[Token(Token = "0x400CD84")]
		[FieldOffset(Offset = "0x8")]
		public float EndProgressVal;

		[Token(Token = "0x400CD85")]
		[FieldOffset(Offset = "0xC")]
		public float Speed;
	}

	[Token(Token = "0x400CD77")]
	[FieldOffset(Offset = "0x48")]
	private UIEPDebrisRewardView m_View;

	[Token(Token = "0x400CD78")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x400CD79")]
	[FieldOffset(Offset = "0x50")]
	private int DebrisRate;

	[Token(Token = "0x400CD7A")]
	[FieldOffset(Offset = "0x54")]
	private Queue<ProgressInfo> progressQueue;

	[Token(Token = "0x400CD7B")]
	[FieldOffset(Offset = "0x58")]
	private ProgressInfo currentProgressInfo;

	[Token(Token = "0x400CD7C")]
	[FieldOffset(Offset = "0x68")]
	private bool DoneCurProgress;

	[Token(Token = "0x400CD7D")]
	[FieldOffset(Offset = "0x6C")]
	private int mBeginVal;

	[Token(Token = "0x400CD7E")]
	[FieldOffset(Offset = "0x70")]
	private int mIncreaseVal;

	[Token(Token = "0x400CD7F")]
	[FieldOffset(Offset = "0x74")]
	private int sliderSpeed;

	[Token(Token = "0x400CD80")]
	[FieldOffset(Offset = "0x78")]
	private bool canShow;

	[Token(Token = "0x400CD81")]
	[FieldOffset(Offset = "0x79")]
	private bool isShowing;

	[Token(Token = "0x600A9E1")]
	[Address(RVA = "0x2BAB9B4", Offset = "0x2BAB9B4", VA = "0x2BAB9B4")]
	public UIEPDebrisRewardController()
	{
	}

	[Token(Token = "0x600A9E2")]
	[Address(RVA = "0x2BABA54", Offset = "0x2BABA54", VA = "0x2BABA54")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A9E3")]
	[Address(RVA = "0x2BABAF8", Offset = "0x2BABAF8", VA = "0x2BABAF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A9E4")]
	[Address(RVA = "0x2BABE4C", Offset = "0x2BABE4C", VA = "0x2BABE4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600A9E5")]
	[Address(RVA = "0x2BAC44C", Offset = "0x2BAC44C", VA = "0x2BAC44C")]
	public void InitSlider(uint oldBadgeCnt, uint curBadgeCnt, uint oldDebrisCnt, uint curDebrisCnt)
	{
	}

	[Token(Token = "0x600A9E6")]
	[Address(RVA = "0x2BABED8", Offset = "0x2BABED8", VA = "0x2BABED8")]
	private bool DoUpdateBarVal(float time)
	{
		return default(bool);
	}

	[Token(Token = "0x600A9E7")]
	[Address(RVA = "0x2BAC3E4", Offset = "0x2BAC3E4", VA = "0x2BAC3E4")]
	private void EndBarProcess()
	{
	}

	[Token(Token = "0x600A9E8")]
	[Address(RVA = "0x2BACA90", Offset = "0x2BACA90", VA = "0x2BACA90")]
	private void ProcessBarDone()
	{
	}

	[Token(Token = "0x600A9E9")]
	[Address(RVA = "0x2BACD54", Offset = "0x2BACD54", VA = "0x2BACD54")]
	private void OnSkipClick()
	{
	}

	[Token(Token = "0x600A9EA")]
	[Address(RVA = "0x2BACDD0", Offset = "0x2BACDD0", VA = "0x2BACDD0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600A9EB")]
	[Address(RVA = "0x2BACE34", Offset = "0x2BACE34", VA = "0x2BACE34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A9EC")]
	[Address(RVA = "0x2BACE3C", Offset = "0x2BACE3C", VA = "0x2BACE3C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
