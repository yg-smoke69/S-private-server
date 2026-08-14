using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022C7")]
public class UIPVEWeaponPropertyController : UIBaseController
{
	[Token(Token = "0x400D95A")]
	[FieldOffset(Offset = "0x28")]
	private UIPVEWeaponPropertyView m_View;

	[Token(Token = "0x400D95B")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_SelectedWeaponId;

	[Token(Token = "0x400D95C")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_PropertyList;

	[Token(Token = "0x600BF84")]
	[Address(RVA = "0x15ACA38", Offset = "0x15ACA38", VA = "0x15ACA38")]
	public UIPVEWeaponPropertyController()
	{
	}

	[Token(Token = "0x600BF85")]
	[Address(RVA = "0x15ACAF0", Offset = "0x15ACAF0", VA = "0x15ACAF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF86")]
	[Address(RVA = "0x15ACB98", Offset = "0x15ACB98", VA = "0x15ACB98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF87")]
	[Address(RVA = "0x15ACE20", Offset = "0x15ACE20", VA = "0x15ACE20")]
	public void RefreshWeaponPropertyScore(uint itemid, bool showDot = true, bool showBg = false)
	{
	}

	[Token(Token = "0x600BF88")]
	[Address(RVA = "0x15AD8F4", Offset = "0x15AD8F4", VA = "0x15AD8F4")]
	private string GetPropertyName(int idx)
	{
		return null;
	}

	[Token(Token = "0x600BF89")]
	[Address(RVA = "0x15ADD9C", Offset = "0x15ADD9C", VA = "0x15ADD9C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
