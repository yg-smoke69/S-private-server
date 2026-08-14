using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x200215C")]
public class UILadderMatchGrandMatchPopController : UIBaseController
{
	[Token(Token = "0x400D183")]
	[FieldOffset(Offset = "0x28")]
	protected LadderMatchGrandMasterPopView m_View;

	[Token(Token = "0x400D184")]
	[FieldOffset(Offset = "0x2C")]
	protected UIClickMask m_UIClickMask;

	[Token(Token = "0x400D185")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_RankObject;

	[Token(Token = "0x400D186")]
	[FieldOffset(Offset = "0x34")]
	private int m_EachSegWidth;

	[Token(Token = "0x400D187")]
	[FieldOffset(Offset = "0x38")]
	private int m_GridNum;

	[Token(Token = "0x600B040")]
	[Address(RVA = "0x1AED204", Offset = "0x1AED204", VA = "0x1AED204")]
	public UILadderMatchGrandMatchPopController()
	{
	}

	[Token(Token = "0x600B041")]
	[Address(RVA = "0x1AED2CC", Offset = "0x1AED2CC", VA = "0x1AED2CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B042")]
	[Address(RVA = "0x1AED370", Offset = "0x1AED370", VA = "0x1AED370")]
	public void SetViewData(List<RankMasterLevel> infos, int peakScore, DGNDKMLMLPM rankMode, bool isGrandMaster)
	{
	}

	[Token(Token = "0x600B043")]
	[Address(RVA = "0x1AEDE64", Offset = "0x1AEDE64", VA = "0x1AEDE64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B044")]
	[Address(RVA = "0x1AEDF20", Offset = "0x1AEDF20", VA = "0x1AEDF20", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600B045")]
	[Address(RVA = "0x1AEDFAC", Offset = "0x1AEDFAC", VA = "0x1AEDFAC")]
	private void OnPopOverClose()
	{
	}

	[Token(Token = "0x600B046")]
	[Address(RVA = "0x1AEE02C", Offset = "0x1AEE02C", VA = "0x1AEE02C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B047")]
	[Address(RVA = "0x1AEE034", Offset = "0x1AEE034", VA = "0x1AEE034")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
