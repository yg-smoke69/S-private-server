using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002299")]
public class UISPReplayItemController : UIEasyListItemController
{
	[Token(Token = "0x400D8B8")]
	[FieldOffset(Offset = "0x38")]
	private UISPReplayItemView m_View;

	[Token(Token = "0x400D8B9")]
	[FieldOffset(Offset = "0x40")]
	private TimeSpan m_Span;

	[Token(Token = "0x400D8BA")]
	[FieldOffset(Offset = "0x48")]
	private ReplayInfo m_CurInfo;

	[Token(Token = "0x400D8BB")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelReplay m_Model;

	[Token(Token = "0x600BE08")]
	[Address(RVA = "0x14A97EC", Offset = "0x14A97EC", VA = "0x14A97EC")]
	public UISPReplayItemController()
	{
	}

	[Token(Token = "0x600BE09")]
	[Address(RVA = "0x14A97F4", Offset = "0x14A97F4", VA = "0x14A97F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE0A")]
	[Address(RVA = "0x14A989C", Offset = "0x14A989C", VA = "0x14A989C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BE0B")]
	[Address(RVA = "0x14A9ADC", Offset = "0x14A9ADC", VA = "0x14A9ADC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600BE0C")]
	[Address(RVA = "0x14A9FE0", Offset = "0x14A9FE0", VA = "0x14A9FE0")]
	private void OnPlayClick()
	{
	}

	[Token(Token = "0x600BE0D")]
	[Address(RVA = "0x14AA1B0", Offset = "0x14AA1B0", VA = "0x14AA1B0")]
	private void OnDelClick()
	{
	}

	[Token(Token = "0x600BE0E")]
	[Address(RVA = "0x14A9EF0", Offset = "0x14A9EF0", VA = "0x14A9EF0")]
	private string Replace(string origin)
	{
		return null;
	}

	[Token(Token = "0x600BE0F")]
	[Address(RVA = "0x14AA22C", Offset = "0x14AA22C", VA = "0x14AA22C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
