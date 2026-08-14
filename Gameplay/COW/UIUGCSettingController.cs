using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002392")]
internal class UIUGCSettingController : UISettingContentBase
{
	[Token(Token = "0x2002393")]
	private enum UGCSettingKey
	{
		[Token(Token = "0x400DD91")]
		CameraMoveSpeed,
		[Token(Token = "0x400DD92")]
		FriendMessage
	}

	[Token(Token = "0x2002394")]
	private sealed class _003CCreateCameraMoveSpeedData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DD93")]
		[FieldOffset(Offset = "0x8")]
		internal float length;

		[Token(Token = "0x600C7D6")]
		[Address(RVA = "0xF40B34", Offset = "0xF40B34", VA = "0xF40B34")]
		public _003CCreateCameraMoveSpeedData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C7D7")]
		[Address(RVA = "0xF414F4", Offset = "0xF414F4", VA = "0xF414F4")]
		internal void _003C_003Em__0(float value)
		{
		}

		[Token(Token = "0x600C7D8")]
		[Address(RVA = "0xF41688", Offset = "0xF41688", VA = "0xF41688")]
		internal float _003C_003Em__1()
		{
			return default(float);
		}
	}

	[Token(Token = "0x400DD8B")]
	[FieldOffset(Offset = "0x2C")]
	private UIUGCSettingView m_View;

	[Token(Token = "0x400DD8C")]
	[FieldOffset(Offset = "0x30")]
	private List<UICommonSettingContentController> m_CtrlList;

	[Token(Token = "0x400DD8D")]
	private const string m_WebUrl = "www.baidu.com";

	[Token(Token = "0x400DD8E")]
	[FieldOffset(Offset = "0x34")]
	private SwitchDesc m_AgreementSwitchDesc;

	[Token(Token = "0x400DD8F")]
	[FieldOffset(Offset = "0x0")]
	private static Func<int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600C7C3")]
	[Address(RVA = "0xF3F9CC", Offset = "0xF3F9CC", VA = "0xF3F9CC")]
	public UIUGCSettingController()
	{
	}

	[Token(Token = "0x600C7C4")]
	[Address(RVA = "0xF3FA58", Offset = "0xF3FA58", VA = "0xF3FA58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C7C5")]
	[Address(RVA = "0xF3FB00", Offset = "0xF3FB00", VA = "0xF3FB00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C7C6")]
	[Address(RVA = "0xF404D0", Offset = "0xF404D0", VA = "0xF404D0")]
	private void SetAgreementActive()
	{
	}

	[Token(Token = "0x600C7C7")]
	[Address(RVA = "0xF40590", Offset = "0xF40590", VA = "0xF40590")]
	private void OnClickUserAgreementBtn()
	{
	}

	[Token(Token = "0x600C7C8")]
	[Address(RVA = "0xF402B4", Offset = "0xF402B4", VA = "0xF402B4")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C7C9")]
	[Address(RVA = "0xF4066C", Offset = "0xF4066C", VA = "0xF4066C")]
	private void Start()
	{
	}

	[Token(Token = "0x600C7CA")]
	[Address(RVA = "0xF406FC", Offset = "0xF406FC", VA = "0xF406FC", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x600C7CB")]
	[Address(RVA = "0xF3FFFC", Offset = "0xF3FFFC", VA = "0xF3FFFC")]
	private CommonSettingContentData CreateCameraBlockData()
	{
		return null;
	}

	[Token(Token = "0x600C7CC")]
	[Address(RVA = "0xF408F0", Offset = "0xF408F0", VA = "0xF408F0")]
	private CommonSettingItemDataSlider CreateCameraMoveSpeedData()
	{
		return null;
	}

	[Token(Token = "0x600C7CD")]
	[Address(RVA = "0xF40158", Offset = "0xF40158", VA = "0xF40158")]
	private CommonSettingContentData CreateNotificationBlockData()
	{
		return null;
	}

	[Token(Token = "0x600C7CE")]
	[Address(RVA = "0xF40B3C", Offset = "0xF40B3C", VA = "0xF40B3C")]
	private CommonSettingItemDataToggleBtns CreateFriendMessageData()
	{
		return null;
	}

	[Token(Token = "0x600C7CF")]
	[Address(RVA = "0xF40E48", Offset = "0xF40E48", VA = "0xF40E48")]
	private void OnFriendMessageOn()
	{
	}

	[Token(Token = "0x600C7D0")]
	[Address(RVA = "0xF40F14", Offset = "0xF40F14", VA = "0xF40F14")]
	private void OnFriendMessageOff()
	{
	}

	[Token(Token = "0x600C7D1")]
	[Address(RVA = "0xF40FE0", Offset = "0xF40FE0", VA = "0xF40FE0")]
	private void OnClickResetDefaultBtn()
	{
	}

	[Token(Token = "0x600C7D2")]
	[Address(RVA = "0xF41284", Offset = "0xF41284", VA = "0xF41284")]
	private static int _003CCreateFriendMessageData_003Em__0()
	{
		return default(int);
	}

	[Token(Token = "0x600C7D3")]
	[Address(RVA = "0xF41304", Offset = "0xF41304", VA = "0xF41304")]
	private void _003COnClickResetDefaultBtn_003Em__1()
	{
	}

	[Token(Token = "0x600C7D4")]
	[Address(RVA = "0xF414E4", Offset = "0xF414E4", VA = "0xF414E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C7D5")]
	[Address(RVA = "0xF414EC", Offset = "0xF414EC", VA = "0xF414EC")]
	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}
}
