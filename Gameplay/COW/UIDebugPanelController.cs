using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003346")]
internal class UIDebugPanelController : UIBaseController
{
	[Token(Token = "0x4013889")]
	[FieldOffset(Offset = "0x28")]
	private UIDebugStaticPanelView m_View;

	[Token(Token = "0x401388A")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, DebugPlayerTargetInfo> m_DebugPlayerTargetInfoDic;

	[Token(Token = "0x401388B")]
	[FieldOffset(Offset = "0x30")]
	private Queue<Color> m_ColorQueue;

	[Token(Token = "0x6015C7B")]
	[Address(RVA = "0x2D8008C", Offset = "0x2D8008C", VA = "0x2D8008C")]
	public UIDebugPanelController()
	{
	}

	[Token(Token = "0x6015C7C")]
	[Address(RVA = "0x2D80178", Offset = "0x2D80178", VA = "0x2D80178")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015C7D")]
	[Address(RVA = "0x2D80220", Offset = "0x2D80220", VA = "0x2D80220")]
	private void Update()
	{
	}

	[Token(Token = "0x6015C7E")]
	[Address(RVA = "0x2D80338", Offset = "0x2D80338", VA = "0x2D80338", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015C7F")]
	[Address(RVA = "0x2D80728", Offset = "0x2D80728", VA = "0x2D80728", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015C80")]
	[Address(RVA = "0x2D80490", Offset = "0x2D80490", VA = "0x2D80490")]
	private void PrepareColorQUeue()
	{
	}

	[Token(Token = "0x6015C81")]
	[Address(RVA = "0x2D8085C", Offset = "0x2D8085C", VA = "0x2D8085C")]
	private void OnshowDebugTargetInfo(object[] param)
	{
	}

	[Token(Token = "0x6015C82")]
	[Address(RVA = "0x2D81B08", Offset = "0x2D81B08", VA = "0x2D81B08")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015C83")]
	[Address(RVA = "0x2D81B10", Offset = "0x2D81B10", VA = "0x2D81B10")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
