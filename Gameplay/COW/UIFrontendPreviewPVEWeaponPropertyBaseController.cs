using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CC3")]
public abstract class UIFrontendPreviewPVEWeaponPropertyBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontendPreviewPVEWeaponPropertyBaseView>
{
	[Token(Token = "0x4011157")]
	[FieldOffset(Offset = "0x38")]
	private uint m_SelectedWeaponId;

	[Token(Token = "0x4011158")]
	[FieldOffset(Offset = "0x3C")]
	private List<GameObject> m_PropertyList;

	[Token(Token = "0x6012BD5")]
	[Address(RVA = "0x2658508", Offset = "0x2658508", VA = "0x2658508")]
	protected UIFrontendPreviewPVEWeaponPropertyBaseController()
	{
	}

	[Token(Token = "0x6012BD6")]
	[Address(RVA = "0x26585A0", Offset = "0x26585A0", VA = "0x26585A0", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012BD7")]
	[Address(RVA = "0x265880C", Offset = "0x265880C", VA = "0x265880C")]
	public void RefreshWeaponPropertyScore(uint itemid, bool showDot = true, bool showBg = false)
	{
	}

	[Token(Token = "0x6012BD8")]
	[Address(RVA = "0x2658F4C", Offset = "0x2658F4C", VA = "0x2658F4C")]
	private string GetPropertyName(int idx)
	{
		return null;
	}

	[Token(Token = "0x6012BD9")]
	[Address(RVA = "0x26593F4", Offset = "0x26593F4", VA = "0x26593F4")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
