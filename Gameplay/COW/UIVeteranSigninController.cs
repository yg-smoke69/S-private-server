using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002BF1")]
public class UIVeteranSigninController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010C74")]
	private const string VETERAN_TUTORIAL_TITLE = "T_28_L_V_INTRODUCE";

	[Token(Token = "0x4010C75")]
	[FieldOffset(Offset = "0x28")]
	private UIVeteranSigninView m_View;

	[Token(Token = "0x4010C76")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIVeteranSigninItemController> m_ItemControllerList;

	[Token(Token = "0x4010C77")]
	[FieldOffset(Offset = "0x30")]
	private UIVeteranSigninItemController m_LastItemController;

	[Token(Token = "0x4010C78")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601236C")]
	[Address(RVA = "0x2CC177C", Offset = "0x2CC177C", VA = "0x2CC177C")]
	public UIVeteranSigninController()
	{
	}

	[Token(Token = "0x601236D")]
	[Address(RVA = "0x2CC1834", Offset = "0x2CC1834", VA = "0x2CC1834")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601236E")]
	[Address(RVA = "0x2CC18D8", Offset = "0x2CC18D8", VA = "0x2CC18D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601236F")]
	[Address(RVA = "0x2CC1E64", Offset = "0x2CC1E64", VA = "0x2CC1E64")]
	private void OnBtnVeteranReturnClick()
	{
	}

	[Token(Token = "0x6012370")]
	[Address(RVA = "0x2CC2118", Offset = "0x2CC2118", VA = "0x2CC2118", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012371")]
	[Address(RVA = "0x2CC21D0", Offset = "0x2CC21D0", VA = "0x2CC21D0", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012372")]
	[Address(RVA = "0x2CC25AC", Offset = "0x2CC25AC", VA = "0x2CC25AC")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6012373")]
	[Address(RVA = "0x2CC2BC0", Offset = "0x2CC2BC0", VA = "0x2CC2BC0")]
	private void ResetState()
	{
	}

	[Token(Token = "0x6012374")]
	[Address(RVA = "0x2CC3164", Offset = "0x2CC3164", VA = "0x2CC3164", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6012375")]
	[Address(RVA = "0x2CC32DC", Offset = "0x2CC32DC", VA = "0x2CC32DC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012376")]
	[Address(RVA = "0x2CC34A4", Offset = "0x2CC34A4", VA = "0x2CC34A4")]
	private void _003COnUIInit_003Em__0(Texture texture)
	{
	}

	[Token(Token = "0x6012377")]
	[Address(RVA = "0x2CC35D8", Offset = "0x2CC35D8", VA = "0x2CC35D8")]
	private static CommonRewardItemInfo _003COnDataChanged_003Em__1(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6012378")]
	[Address(RVA = "0x2CC35E0", Offset = "0x2CC35E0", VA = "0x2CC35E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012379")]
	[Address(RVA = "0x2CC35E8", Offset = "0x2CC35E8", VA = "0x2CC35E8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601237A")]
	[Address(RVA = "0x2CC35F0", Offset = "0x2CC35F0", VA = "0x2CC35F0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
