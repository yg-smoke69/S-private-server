using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200249E")]
public class UIAnnouncementRewardItemController : UIBaseController
{
	[Token(Token = "0x400E2F6")]
	[FieldOffset(Offset = "0x28")]
	private UIAnnouncementRewardItemView m_View;

	[Token(Token = "0x400E2F7")]
	[FieldOffset(Offset = "0x2C")]
	private UIWidget m_ItemWiget;

	[Token(Token = "0x400E2F8")]
	private const uint SIGNED_COLOR = 2779096575u;

	[Token(Token = "0x400E2F9")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<uint, string> ID_TO_LOCKEY_MAP;

	[Token(Token = "0x17001120")]
	public Vector2 ItemSize
	{
		[Token(Token = "0x600D170")]
		[Address(RVA = "0x1E6F4E0", Offset = "0x1E6F4E0", VA = "0x1E6F4E0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x600D16F")]
	[Address(RVA = "0x1E6F45C", Offset = "0x1E6F45C", VA = "0x1E6F45C")]
	public UIAnnouncementRewardItemController()
	{
	}

	[Token(Token = "0x600D171")]
	[Address(RVA = "0x1E6F6E0", Offset = "0x1E6F6E0", VA = "0x1E6F6E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D172")]
	[Address(RVA = "0x1E6F784", Offset = "0x1E6F784", VA = "0x1E6F784", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D173")]
	[Address(RVA = "0x1E6F8D4", Offset = "0x1E6F8D4", VA = "0x1E6F8D4")]
	public void ShowChoosedSprite()
	{
	}

	[Token(Token = "0x600D174")]
	[Address(RVA = "0x1E6F984", Offset = "0x1E6F984", VA = "0x1E6F984")]
	public void SetData(AttendaceItemInfo attendaceInfo)
	{
	}

	[Token(Token = "0x600D175")]
	[Address(RVA = "0x1E6FF98", Offset = "0x1E6FF98", VA = "0x1E6FF98")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600D177")]
	[Address(RVA = "0x1E70458", Offset = "0x1E70458", VA = "0x1E70458")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
