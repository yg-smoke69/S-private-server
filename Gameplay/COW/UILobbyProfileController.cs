using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002948")]
public class UILobbyProfileController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002949")]
	private sealed class _003COnHeadClick_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FE76")]
		[FieldOffset(Offset = "0x8")]
		internal ulong id;

		[Token(Token = "0x60107E0")]
		[Address(RVA = "0x1CB46BC", Offset = "0x1CB46BC", VA = "0x1CB46BC")]
		public _003COnHeadClick_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60107E1")]
		[Address(RVA = "0x1CB4B14", Offset = "0x1CB4B14", VA = "0x1CB4B14")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400FE74")]
	[FieldOffset(Offset = "0x28")]
	private UILobbyProfileView m_View;

	[Token(Token = "0x400FE75")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_Profile;

	[Token(Token = "0x60107CF")]
	[Address(RVA = "0x1CB300C", Offset = "0x1CB300C", VA = "0x1CB300C")]
	public UILobbyProfileController()
	{
	}

	[Token(Token = "0x60107D0")]
	[Address(RVA = "0x1CB3090", Offset = "0x1CB3090", VA = "0x1CB3090")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60107D1")]
	[Address(RVA = "0x1CB3134", Offset = "0x1CB3134", VA = "0x1CB3134", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60107D2")]
	[Address(RVA = "0x1CB35F8", Offset = "0x1CB35F8", VA = "0x1CB35F8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60107D3")]
	[Address(RVA = "0x1CB38E0", Offset = "0x1CB38E0", VA = "0x1CB38E0", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60107D4")]
	[Address(RVA = "0x1CB3980", Offset = "0x1CB3980", VA = "0x1CB3980")]
	public void UpdateProfileData()
	{
	}

	[Token(Token = "0x60107D5")]
	[Address(RVA = "0x1CB3E58", Offset = "0x1CB3E58", VA = "0x1CB3E58")]
	private void SetAvatarIcon()
	{
	}

	[Token(Token = "0x60107D6")]
	[Address(RVA = "0x1CB3FA4", Offset = "0x1CB3FA4", VA = "0x1CB3FA4")]
	private void OnBtnRenameClick()
	{
	}

	[Token(Token = "0x60107D7")]
	[Address(RVA = "0x1CB40F0", Offset = "0x1CB40F0", VA = "0x1CB40F0")]
	public void EnableHeadClick(bool enabled)
	{
	}

	[Token(Token = "0x60107D8")]
	[Address(RVA = "0x1CB4174", Offset = "0x1CB4174", VA = "0x1CB4174")]
	private void OnHeadClick()
	{
	}

	[Token(Token = "0x60107D9")]
	[Address(RVA = "0x1CB46C4", Offset = "0x1CB46C4", VA = "0x1CB46C4")]
	private void OnRenameBtnStateChange(object[] data)
	{
	}

	[Token(Token = "0x60107DA")]
	[Address(RVA = "0x1CB47F8", Offset = "0x1CB47F8", VA = "0x1CB47F8")]
	private void OnShowRankChanged(object[] data)
	{
	}

	[Token(Token = "0x60107DB")]
	[Address(RVA = "0x1CB491C", Offset = "0x1CB491C", VA = "0x1CB491C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60107DC")]
	[Address(RVA = "0x1CB4A20", Offset = "0x1CB4A20", VA = "0x1CB4A20", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60107DD")]
	[Address(RVA = "0x1CB4AFC", Offset = "0x1CB4AFC", VA = "0x1CB4AFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60107DE")]
	[Address(RVA = "0x1CB4B04", Offset = "0x1CB4B04", VA = "0x1CB4B04")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x60107DF")]
	[Address(RVA = "0x1CB4B0C", Offset = "0x1CB4B0C", VA = "0x1CB4B0C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
