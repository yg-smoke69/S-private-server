using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002857")]
internal class UIHudSpecialPopupController : UIBaseController
{
	[Token(Token = "0x2002858")]
	public class ZoneColorGroup
	{
		[Token(Token = "0x400F8D8")]
		[FieldOffset(Offset = "0x8")]
		public IHJOFJKFIBB zoneType;

		[Token(Token = "0x400F8D9")]
		[FieldOffset(Offset = "0xC")]
		public Color iconColor;

		[Token(Token = "0x400F8DA")]
		[FieldOffset(Offset = "0x1C")]
		public Color bgColor;

		[Token(Token = "0x400F8DB")]
		[FieldOffset(Offset = "0x2C")]
		public Color bgColor2;

		[Token(Token = "0x400F8DC")]
		[FieldOffset(Offset = "0x3C")]
		public Color bgColor3;

		[Token(Token = "0x600FC55")]
		[Address(RVA = "0x1FDE0D0", Offset = "0x1FDE0D0", VA = "0x1FDE0D0")]
		public ZoneColorGroup(IHJOFJKFIBB zoneType, Color iconColor, Color bgColor, Color bgColor2, Color bgColor3)
		{
		}
	}

	[Token(Token = "0x400F8D5")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSpecialPopupView m_View;

	[Token(Token = "0x400F8D6")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400F8D7")]
	[FieldOffset(Offset = "0x30")]
	private List<ZoneColorGroup> m_ZoneColorGroupList;

	[Token(Token = "0x600FC48")]
	[Address(RVA = "0x1FDD1D8", Offset = "0x1FDD1D8", VA = "0x1FDD1D8")]
	public UIHudSpecialPopupController()
	{
	}

	[Token(Token = "0x600FC49")]
	[Address(RVA = "0x1FDD290", Offset = "0x1FDD290", VA = "0x1FDD290")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FC4A")]
	[Address(RVA = "0x1FDD334", Offset = "0x1FDD334", VA = "0x1FDD334", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FC4B")]
	[Address(RVA = "0x1FDE168", Offset = "0x1FDE168", VA = "0x1FDE168", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FC4C")]
	[Address(RVA = "0x1FDE1CC", Offset = "0x1FDE1CC", VA = "0x1FDE1CC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FC4D")]
	[Address(RVA = "0x1FDE348", Offset = "0x1FDE348", VA = "0x1FDE348")]
	public void SetMessage(GameBannerInfo gb, IHJOFJKFIBB zoneType)
	{
	}

	[Token(Token = "0x600FC4E")]
	[Address(RVA = "0x1FDED80", Offset = "0x1FDED80", VA = "0x1FDED80")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600FC4F")]
	[Address(RVA = "0x1FDE238", Offset = "0x1FDE238", VA = "0x1FDE238")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600FC50")]
	[Address(RVA = "0x1FDEE90", Offset = "0x1FDEE90", VA = "0x1FDEE90", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600FC51")]
	[Address(RVA = "0x1FDEEFC", Offset = "0x1FDEEFC", VA = "0x1FDEEFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FC52")]
	[Address(RVA = "0x1FDEF04", Offset = "0x1FDEF04", VA = "0x1FDEF04")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FC53")]
	[Address(RVA = "0x1FDEF0C", Offset = "0x1FDEF0C", VA = "0x1FDEF0C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FC54")]
	[Address(RVA = "0x1FDEF14", Offset = "0x1FDEF14", VA = "0x1FDEF14")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
