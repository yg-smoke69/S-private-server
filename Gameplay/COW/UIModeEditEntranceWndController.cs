using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022F7")]
internal class UIModeEditEntranceWndController : UIPopupWindowController
{
	[Token(Token = "0x20022F8")]
	private sealed class _003CShowIcon_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DA43")]
		[FieldOffset(Offset = "0x8")]
		internal UINetworkTexture iconTexture;

		[Token(Token = "0x400DA44")]
		[FieldOffset(Offset = "0xC")]
		internal UIModeEditEntranceWndController _0024this;

		[Token(Token = "0x600C103")]
		[Address(RVA = "0x130FC74", Offset = "0x130FC74", VA = "0x130FC74")]
		public _003CShowIcon_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C104")]
		[Address(RVA = "0x130FC84", Offset = "0x130FC84", VA = "0x130FC84")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400DA41")]
	[FieldOffset(Offset = "0x48")]
	private UIModeEditEntranceWndView m_View;

	[Token(Token = "0x400DA42")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUGCModeEdit m_Model;

	[Token(Token = "0x600C0FA")]
	[Address(RVA = "0x130DE04", Offset = "0x130DE04", VA = "0x130DE04")]
	public UIModeEditEntranceWndController()
	{
	}

	[Token(Token = "0x600C0FB")]
	[Address(RVA = "0x130DE0C", Offset = "0x130DE0C", VA = "0x130DE0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C0FC")]
	[Address(RVA = "0x130DEB4", Offset = "0x130DEB4", VA = "0x130DEB4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C0FD")]
	[Address(RVA = "0x130EB08", Offset = "0x130EB08", VA = "0x130EB08")]
	private void OnClassicClick()
	{
	}

	[Token(Token = "0x600C0FE")]
	[Address(RVA = "0x130EF3C", Offset = "0x130EF3C", VA = "0x130EF3C")]
	private void OnCustomClick()
	{
	}

	[Token(Token = "0x600C0FF")]
	[Address(RVA = "0x130F06C", Offset = "0x130F06C", VA = "0x130F06C")]
	private void OnCustomLockClick()
	{
	}

	[Token(Token = "0x600C100")]
	[Address(RVA = "0x130EC38", Offset = "0x130EC38", VA = "0x130EC38")]
	private void OpenModeEditPanel(UIModeEditData data, ModeVariables variables)
	{
	}

	[Token(Token = "0x600C101")]
	[Address(RVA = "0x130E5E4", Offset = "0x130E5E4", VA = "0x130E5E4")]
	private void ShowIcon(UINetworkTexture iconTexture, GameObject defaultIcon, UIModeEditData.EntranceInfoData info)
	{
	}

	[Token(Token = "0x600C102")]
	[Address(RVA = "0x130FC7C", Offset = "0x130FC7C", VA = "0x130FC7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
