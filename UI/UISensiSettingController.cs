using System;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x200238C")]
public class UISensiSettingController : UISettingContentBase
{
	[Token(Token = "0x200238D")]
	private enum SensiSettingKey
	{
		[Token(Token = "0x400DD6C")]
		Sensitivity,
		[Token(Token = "0x400DD6D")]
		x1Scope,
		[Token(Token = "0x400DD6E")]
		x2Scope,
		[Token(Token = "0x400DD6F")]
		x4Scope,
		[Token(Token = "0x400DD70")]
		x8Scope,
		[Token(Token = "0x400DD71")]
		AuxAimSensitivity
	}

	[Token(Token = "0x400DD5C")]
	[FieldOffset(Offset = "0x2C")]
	private UISensiSettingView m_View;

	[Token(Token = "0x400DD5D")]
	[FieldOffset(Offset = "0x30")]
	private CommonSettingContentData m_Data;

	[Token(Token = "0x400DD5E")]
	[FieldOffset(Offset = "0x34")]
	private UICommonSettingContentController m_Ctrl;

	[Token(Token = "0x400DD5F")]
	[FieldOffset(Offset = "0x0")]
	private static Func<float> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400DD60")]
	[FieldOffset(Offset = "0x4")]
	private static Action<float> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400DD61")]
	[FieldOffset(Offset = "0x8")]
	private static Func<float> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x400DD62")]
	[FieldOffset(Offset = "0xC")]
	private static Action<float> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400DD63")]
	[FieldOffset(Offset = "0x10")]
	private static Func<float> _003C_003Ef__mg_0024cache2;

	[Token(Token = "0x400DD64")]
	[FieldOffset(Offset = "0x14")]
	private static Action<float> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400DD65")]
	[FieldOffset(Offset = "0x18")]
	private static Func<float> _003C_003Ef__mg_0024cache3;

	[Token(Token = "0x400DD66")]
	[FieldOffset(Offset = "0x1C")]
	private static Action<float> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400DD67")]
	[FieldOffset(Offset = "0x20")]
	private static Func<float> _003C_003Ef__mg_0024cache4;

	[Token(Token = "0x400DD68")]
	[FieldOffset(Offset = "0x24")]
	private static Action<float> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400DD69")]
	[FieldOffset(Offset = "0x28")]
	private static Func<float> _003C_003Ef__mg_0024cache5;

	[Token(Token = "0x400DD6A")]
	[FieldOffset(Offset = "0x2C")]
	private static Action<float> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x600C78F")]
	[Address(RVA = "0x22476FC", Offset = "0x22476FC", VA = "0x22476FC")]
	public UISensiSettingController()
	{
	}

	[Token(Token = "0x600C790")]
	[Address(RVA = "0x2247774", Offset = "0x2247774", VA = "0x2247774", Slot = "33")]
	public override void RefreshContent(object[] param)
	{
	}

	[Token(Token = "0x600C791")]
	[Address(RVA = "0x2247854", Offset = "0x2247854", VA = "0x2247854")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C792")]
	[Address(RVA = "0x22478BC", Offset = "0x22478BC", VA = "0x22478BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C793")]
	[Address(RVA = "0x224871C", Offset = "0x224871C", VA = "0x224871C")]
	private void OnSensitivyResetBtnClick()
	{
	}

	[Token(Token = "0x600C794")]
	[Address(RVA = "0x2248978", Offset = "0x2248978", VA = "0x2248978")]
	private float GetDefaultSensitivy(int type)
	{
		return default(float);
	}

	[Token(Token = "0x600C795")]
	[Address(RVA = "0x2248718", Offset = "0x2248718", VA = "0x2248718")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C796")]
	[Address(RVA = "0x2247CAC", Offset = "0x2247CAC", VA = "0x2247CAC")]
	private CommonSettingItemDataSlider CreateSensitivityData()
	{
		return null;
	}

	[Token(Token = "0x600C797")]
	[Address(RVA = "0x2247E6C", Offset = "0x2247E6C", VA = "0x2247E6C")]
	private CommonSettingItemDataSlider Createx1ScopeData()
	{
		return null;
	}

	[Token(Token = "0x600C798")]
	[Address(RVA = "0x2248028", Offset = "0x2248028", VA = "0x2248028")]
	private CommonSettingItemDataSlider Createx2ScopeData()
	{
		return null;
	}

	[Token(Token = "0x600C799")]
	[Address(RVA = "0x22481E4", Offset = "0x22481E4", VA = "0x22481E4")]
	private CommonSettingItemDataSlider Createx4ScopeData()
	{
		return null;
	}

	[Token(Token = "0x600C79A")]
	[Address(RVA = "0x22483A0", Offset = "0x22483A0", VA = "0x22483A0")]
	private CommonSettingItemDataSlider Createx8ScopeData()
	{
		return null;
	}

	[Token(Token = "0x600C79B")]
	[Address(RVA = "0x224855C", Offset = "0x224855C", VA = "0x224855C")]
	private CommonSettingItemDataSlider CreateAuxAimSensitivityData()
	{
		return null;
	}

	[Token(Token = "0x600C79C")]
	[Address(RVA = "0x22477A0", Offset = "0x22477A0", VA = "0x22477A0")]
	private void RefreshBtnsState()
	{
	}

	[Token(Token = "0x600C79D")]
	[Address(RVA = "0x22489FC", Offset = "0x22489FC", VA = "0x22489FC")]
	private void _003COnSensitivyResetBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600C79E")]
	[Address(RVA = "0x2248BDC", Offset = "0x2248BDC", VA = "0x2248BDC")]
	private static void _003CCreateSensitivityData_003Em__1(float value)
	{
	}

	[Token(Token = "0x600C79F")]
	[Address(RVA = "0x2248C60", Offset = "0x2248C60", VA = "0x2248C60")]
	private static void _003CCreatex1ScopeData_003Em__2(float value)
	{
	}

	[Token(Token = "0x600C7A0")]
	[Address(RVA = "0x2248CE4", Offset = "0x2248CE4", VA = "0x2248CE4")]
	private static void _003CCreatex2ScopeData_003Em__3(float value)
	{
	}

	[Token(Token = "0x600C7A1")]
	[Address(RVA = "0x2248D68", Offset = "0x2248D68", VA = "0x2248D68")]
	private static void _003CCreatex4ScopeData_003Em__4(float value)
	{
	}

	[Token(Token = "0x600C7A2")]
	[Address(RVA = "0x2248DEC", Offset = "0x2248DEC", VA = "0x2248DEC")]
	private static void _003CCreatex8ScopeData_003Em__5(float value)
	{
	}

	[Token(Token = "0x600C7A3")]
	[Address(RVA = "0x2248E70", Offset = "0x2248E70", VA = "0x2248E70")]
	private static void _003CCreateAuxAimSensitivityData_003Em__6(float value)
	{
	}
}
