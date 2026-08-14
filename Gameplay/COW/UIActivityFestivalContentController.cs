using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001F5A")]
public class UIActivityFestivalContentController : UIActivityContentController
{
	[Token(Token = "0x2001F5B")]
	private enum OperateStatus
	{
		[Token(Token = "0x400C505")]
		None,
		[Token(Token = "0x400C506")]
		GoTo,
		[Token(Token = "0x400C507")]
		UnFinished,
		[Token(Token = "0x400C508")]
		Available,
		[Token(Token = "0x400C509")]
		Received
	}

	[Token(Token = "0x2001F5C")]
	private sealed class _003CCreateAwardList_003Ec__AnonStorey0
	{
		[Token(Token = "0x400C50A")]
		[FieldOffset(Offset = "0x8")]
		internal ClientActivityDesc activity;

		[Token(Token = "0x400C50B")]
		[FieldOffset(Offset = "0xC")]
		internal UIActivityFestivalContentController _0024this;

		[Token(Token = "0x6009B47")]
		[Address(RVA = "0x2FABC78", Offset = "0x2FABC78", VA = "0x2FABC78")]
		public _003CCreateAwardList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009B48")]
		[Address(RVA = "0x2FAC854", Offset = "0x2FAC854", VA = "0x2FAC854")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400C4FE")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityFestivalContentView m_View;

	[Token(Token = "0x400C4FF")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C500")]
	[FieldOffset(Offset = "0x30")]
	private uint m_SelectAwardActivityId;

	[Token(Token = "0x400C501")]
	[FieldOffset(Offset = "0x34")]
	private OperateStatus m_OperateStatus;

	[Token(Token = "0x400C502")]
	[FieldOffset(Offset = "0x38")]
	private List<ClientActivityDesc> m_ActivityDescs;

	[Token(Token = "0x400C503")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<AwardDesc, BaseItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009B34")]
	[Address(RVA = "0x2FA9724", Offset = "0x2FA9724", VA = "0x2FA9724")]
	public UIActivityFestivalContentController()
	{
	}

	[Token(Token = "0x6009B35")]
	[Address(RVA = "0x2FA97B0", Offset = "0x2FA97B0", VA = "0x2FA97B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B36")]
	[Address(RVA = "0x2FA9854", Offset = "0x2FA9854", VA = "0x2FA9854")]
	public static ResourceID GetVFXResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B37")]
	[Address(RVA = "0x2FA98FC", Offset = "0x2FA98FC", VA = "0x2FA98FC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B38")]
	[Address(RVA = "0x2FA9AC8", Offset = "0x2FA9AC8", VA = "0x2FA9AC8", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009B39")]
	[Address(RVA = "0x2FAA040", Offset = "0x2FAA040", VA = "0x2FAA040")]
	private void CreateActivityList()
	{
	}

	[Token(Token = "0x6009B3A")]
	[Address(RVA = "0x2FAB474", Offset = "0x2FAB474", VA = "0x2FAB474")]
	private void CreateAwardList(ClientActivityDesc activity, UIScrollView AwardScrollView, UIGrid AwardGrid, UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x6009B3B")]
	[Address(RVA = "0x2FAA6A0", Offset = "0x2FAA6A0", VA = "0x2FAA6A0")]
	private void SetOperationTips()
	{
	}

	[Token(Token = "0x6009B3C")]
	[Address(RVA = "0x2FAA868", Offset = "0x2FAA868", VA = "0x2FAA868")]
	private void SetOperateButtonUI()
	{
	}

	[Token(Token = "0x6009B3D")]
	[Address(RVA = "0x2FABC80", Offset = "0x2FABC80", VA = "0x2FABC80")]
	private bool HasReceived()
	{
		return default(bool);
	}

	[Token(Token = "0x6009B3E")]
	[Address(RVA = "0x2FABE64", Offset = "0x2FABE64", VA = "0x2FABE64")]
	private void OnOperate()
	{
	}

	[Token(Token = "0x6009B3F")]
	[Address(RVA = "0x2FAC5B8", Offset = "0x2FAC5B8", VA = "0x2FAC5B8", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009B40")]
	[Address(RVA = "0x2FAC624", Offset = "0x2FAC624", VA = "0x2FAC624")]
	private bool _003COnOperate_003Em__0(ClientActivityDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x6009B41")]
	[Address(RVA = "0x2FAC65C", Offset = "0x2FAC65C", VA = "0x2FAC65C")]
	private static BaseItemInfo _003COnOperate_003Em__1(AwardDesc e)
	{
		return null;
	}

	[Token(Token = "0x6009B42")]
	[Address(RVA = "0x2FAC6E0", Offset = "0x2FAC6E0", VA = "0x2FAC6E0")]
	private void _003COnOperate_003Em__2()
	{
	}

	[Token(Token = "0x6009B43")]
	[Address(RVA = "0x2FAC804", Offset = "0x2FAC804", VA = "0x2FAC804")]
	private bool _003COnOperate_003Em__3(ClientActivityDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x6009B44")]
	[Address(RVA = "0x2FAC83C", Offset = "0x2FAC83C", VA = "0x2FAC83C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009B45")]
	[Address(RVA = "0x2FAC844", Offset = "0x2FAC844", VA = "0x2FAC844")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009B46")]
	[Address(RVA = "0x2FAC84C", Offset = "0x2FAC84C", VA = "0x2FAC84C")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
