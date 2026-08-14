using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028CE")]
public class UIHudWereWolvesWolfCountController : UIBaseController
{
	[Token(Token = "0x400FB03")]
	[FieldOffset(Offset = "0x28")]
	private UIHudWereWolvesWolfCountView m_View;

	[Token(Token = "0x400FB04")]
	[FieldOffset(Offset = "0x2C")]
	private GameObject[] m_wolfList;

	[Token(Token = "0x400FB05")]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] m_deadWolfList;

	[Token(Token = "0x601014F")]
	[Address(RVA = "0x29408CC", Offset = "0x29408CC", VA = "0x29408CC")]
	public UIHudWereWolvesWolfCountController()
	{
	}

	[Token(Token = "0x6010150")]
	[Address(RVA = "0x2940950", Offset = "0x2940950", VA = "0x2940950")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010151")]
	[Address(RVA = "0x29409F8", Offset = "0x29409F8", VA = "0x29409F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010152")]
	[Address(RVA = "0x2940F30", Offset = "0x2940F30", VA = "0x2940F30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010153")]
	[Address(RVA = "0x2941064", Offset = "0x2941064", VA = "0x2941064", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010154")]
	[Address(RVA = "0x29412E4", Offset = "0x29412E4", VA = "0x29412E4")]
	private void SetAliveWolfCount(uint cur_count, uint all_count)
	{
	}

	[Token(Token = "0x6010155")]
	[Address(RVA = "0x2941128", Offset = "0x2941128", VA = "0x2941128")]
	private void RefreshWolfCount(object[] data)
	{
	}

	[Token(Token = "0x6010156")]
	[Address(RVA = "0x29414F4", Offset = "0x29414F4", VA = "0x29414F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010157")]
	[Address(RVA = "0x29414FC", Offset = "0x29414FC", VA = "0x29414FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010158")]
	[Address(RVA = "0x2941504", Offset = "0x2941504", VA = "0x2941504")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
