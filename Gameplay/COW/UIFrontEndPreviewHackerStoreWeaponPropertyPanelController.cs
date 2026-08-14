using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CB2")]
public class UIFrontEndPreviewHackerStoreWeaponPropertyPanelController : UIFrontEndPreviewWeaponPropertyPanelBaseController
{
	[Token(Token = "0x4011109")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 PropertyTitleOriginalPos;

	[Token(Token = "0x401110A")]
	[FieldOffset(Offset = "0x44")]
	private UIFrontEndPreviewHackerStoreWeaponPropertyPanelView m_UIView;

	[Token(Token = "0x6012B60")]
	[Address(RVA = "0x27FA1E0", Offset = "0x27FA1E0", VA = "0x27FA1E0")]
	public UIFrontEndPreviewHackerStoreWeaponPropertyPanelController()
	{
	}

	[Token(Token = "0x6012B61")]
	[Address(RVA = "0x27FA1E8", Offset = "0x27FA1E8", VA = "0x27FA1E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B62")]
	[Address(RVA = "0x27FA290", Offset = "0x27FA290", VA = "0x27FA290", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B63")]
	[Address(RVA = "0x27FA340", Offset = "0x27FA340", VA = "0x27FA340", Slot = "35")]
	protected override UIFrontEndPreviewWeaponPropertyPanelBaseView InitBaseView()
	{
		return null;
	}

	[Token(Token = "0x6012B64")]
	[Address(RVA = "0x27FA3B0", Offset = "0x27FA3B0", VA = "0x27FA3B0", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012B65")]
	[Address(RVA = "0x27FA414", Offset = "0x27FA414", VA = "0x27FA414", Slot = "36")]
	public override void OnRefreshWeaponPropertyScore(uint itemID)
	{
	}

	[Token(Token = "0x6012B66")]
	[Address(RVA = "0x27FA484", Offset = "0x27FA484", VA = "0x27FA484")]
	public new void _003C_003EiFixBaseProxy_InitView()
	{
	}

	[Token(Token = "0x6012B67")]
	[Address(RVA = "0x27FA48C", Offset = "0x27FA48C", VA = "0x27FA48C")]
	public void _003C_003EiFixBaseProxy_OnRefreshWeaponPropertyScore(uint P0)
	{
	}
}
