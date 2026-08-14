using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002B36")]
public class UISPHudKilledController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010936")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudKilledView m_View;

	[Token(Token = "0x4010937")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x4010938")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, GameObject> m_KillStateCoding2IconGO;

	[Token(Token = "0x4010939")]
	private const uint killCoding = 10000u;

	[Token(Token = "0x401093A")]
	private const uint knockDownCoding = 0u;

	[Token(Token = "0x401093B")]
	private const uint headCoding = 1000u;

	[Token(Token = "0x401093C")]
	private const uint bodyCoding = 0u;

	[Token(Token = "0x401093D")]
	[FieldOffset(Offset = "0x34")]
	private GameObject m_ShowingIcon;

	[Token(Token = "0x401093E")]
	[FieldOffset(Offset = "0x38")]
	private uint m_HideDelayCallID;

	[Token(Token = "0x6011C93")]
	[Address(RVA = "0x1D2078C", Offset = "0x1D2078C", VA = "0x1D2078C")]
	public UISPHudKilledController()
	{
	}

	[Token(Token = "0x6011C94")]
	[Address(RVA = "0x1D20810", Offset = "0x1D20810", VA = "0x1D20810", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C95")]
	[Address(RVA = "0x1D20BAC", Offset = "0x1D20BAC", VA = "0x1D20BAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C96")]
	[Address(RVA = "0x1D20C54", Offset = "0x1D20C54", VA = "0x1D20C54", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011C97")]
	[Address(RVA = "0x1D2097C", Offset = "0x1D2097C", VA = "0x1D2097C")]
	private void InitDictionary()
	{
	}

	[Token(Token = "0x6011C98")]
	[Address(RVA = "0x1D20D8C", Offset = "0x1D20D8C", VA = "0x1D20D8C", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011C99")]
	[Address(RVA = "0x1D20E20", Offset = "0x1D20E20", VA = "0x1D20E20", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011C9A")]
	[Address(RVA = "0x1D21194", Offset = "0x1D21194", VA = "0x1D21194")]
	private void IconShow(bool isKnockDown, AJKGBJOJEAF hitPart, ESPKillOperateNoti operate)
	{
	}

	[Token(Token = "0x6011C9B")]
	[Address(RVA = "0x1D215F4", Offset = "0x1D215F4", VA = "0x1D215F4")]
	private void _003CIconShow_003Em__0()
	{
	}

	[Token(Token = "0x6011C9C")]
	[Address(RVA = "0x1D216E8", Offset = "0x1D216E8", VA = "0x1D216E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C9D")]
	[Address(RVA = "0x1D216F0", Offset = "0x1D216F0", VA = "0x1D216F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
