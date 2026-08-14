using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200237A")]
public class UIGraphicSettingController : UISettingContentBase
{
	[Token(Token = "0x200237B")]
	private sealed class _003CRefreshScroll_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DCD8")]
		[FieldOffset(Offset = "0x8")]
		internal UIGraphicSettingController _0024this;

		[Token(Token = "0x400DCD9")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DCDA")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DCDB")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010DA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C692")]
			[Address(RVA = "0x1479154", Offset = "0x1479154", VA = "0x1479154", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010DB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C693")]
			[Address(RVA = "0x147915C", Offset = "0x147915C", VA = "0x147915C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C690")]
		[Address(RVA = "0x1477504", Offset = "0x1477504", VA = "0x1477504")]
		public _003CRefreshScroll_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C691")]
		[Address(RVA = "0x1479050", Offset = "0x1479050", VA = "0x1479050", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C694")]
		[Address(RVA = "0x1479164", Offset = "0x1479164", VA = "0x1479164", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C695")]
		[Address(RVA = "0x1479178", Offset = "0x1479178", VA = "0x1479178", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x200237C")]
	private sealed class _003CFilterBtnClick_003Ec__AnonStorey1
	{
		[Token(Token = "0x400DCDC")]
		[FieldOffset(Offset = "0x8")]
		internal EInGameFilterSetting filter;

		[Token(Token = "0x400DCDD")]
		[FieldOffset(Offset = "0xC")]
		internal UIGraphicSettingController _0024this;

		[Token(Token = "0x600C696")]
		[Address(RVA = "0x1477E20", Offset = "0x1477E20", VA = "0x1477E20")]
		public _003CFilterBtnClick_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600C697")]
		[Address(RVA = "0x1478DD8", Offset = "0x1478DD8", VA = "0x1478DD8")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600C698")]
		[Address(RVA = "0x1478ECC", Offset = "0x1478ECC", VA = "0x1478ECC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400DCD1")]
	[FieldOffset(Offset = "0x2C")]
	private UIGraphicSettingView m_View;

	[Token(Token = "0x400DCD2")]
	[FieldOffset(Offset = "0x30")]
	private GraphicSettingInfo m_SettingInfo;

	[Token(Token = "0x400DCD3")]
	private const string TXT_NOTCH_TIP = "TXT_NOTCH_TIP";

	[Token(Token = "0x400DCD4")]
	[FieldOffset(Offset = "0x34")]
	private Coroutine m_ScrollArrowCoro;

	[Token(Token = "0x400DCD5")]
	[FieldOffset(Offset = "0x0")]
	private static OnToggleGroupValueChange _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400DCD6")]
	[FieldOffset(Offset = "0x4")]
	private static OnToggleGroupValueChange _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400DCD7")]
	[FieldOffset(Offset = "0x8")]
	private static Action _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600C671")]
	[Address(RVA = "0x1474FE4", Offset = "0x1474FE4", VA = "0x1474FE4")]
	public UIGraphicSettingController()
	{
	}

	[Token(Token = "0x600C672")]
	[Address(RVA = "0x1474FEC", Offset = "0x1474FEC", VA = "0x1474FEC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C673")]
	[Address(RVA = "0x1475054", Offset = "0x1475054", VA = "0x1475054", Slot = "32")]
	protected override void InitSettingInfo()
	{
	}

	[Token(Token = "0x600C674")]
	[Address(RVA = "0x1475218", Offset = "0x1475218", VA = "0x1475218", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C675")]
	[Address(RVA = "0x14756C8", Offset = "0x14756C8", VA = "0x14756C8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C676")]
	[Address(RVA = "0x1477480", Offset = "0x1477480", VA = "0x1477480")]
	private IEnumerator RefreshScroll()
	{
		return null;
	}

	[Token(Token = "0x600C677")]
	[Address(RVA = "0x147743C", Offset = "0x147743C", VA = "0x147743C")]
	private void RefreshScrollArrow()
	{
	}

	[Token(Token = "0x600C678")]
	[Address(RVA = "0x1477270", Offset = "0x1477270", VA = "0x1477270")]
	private void ResetScrollViewWidth()
	{
	}

	[Token(Token = "0x600C679")]
	[Address(RVA = "0x1475EAC", Offset = "0x1475EAC", VA = "0x1475EAC")]
	private void InitMiniMap()
	{
	}

	[Token(Token = "0x600C67A")]
	[Address(RVA = "0x147750C", Offset = "0x147750C", VA = "0x147750C")]
	private void OnMinimapModeChange()
	{
	}

	[Token(Token = "0x600C67B")]
	[Address(RVA = "0x14777F4", Offset = "0x14777F4", VA = "0x14777F4")]
	private void OnMinimapScaleAssistChange()
	{
	}

	[Token(Token = "0x600C67C")]
	[Address(RVA = "0x1476EA8", Offset = "0x1476EA8", VA = "0x1476EA8")]
	private void InitInGameFilterSetting()
	{
	}

	[Token(Token = "0x600C67D")]
	[Address(RVA = "0x1477A10", Offset = "0x1477A10", VA = "0x1477A10")]
	private void FilterBtnClick(EInGameFilterSetting filter)
	{
	}

	[Token(Token = "0x600C67E")]
	[Address(RVA = "0x14767B8", Offset = "0x14767B8", VA = "0x14767B8")]
	private void InitShadowSetting()
	{
	}

	[Token(Token = "0x600C67F")]
	[Address(RVA = "0x1476594", Offset = "0x1476594", VA = "0x1476594")]
	private void InitHightFPSSetting()
	{
	}

	[Token(Token = "0x600C680")]
	[Address(RVA = "0x1476C40", Offset = "0x1476C40", VA = "0x1476C40")]
	private void InitEnemyFireHintSetting()
	{
	}

	[Token(Token = "0x600C681")]
	[Address(RVA = "0x1476C84", Offset = "0x1476C84", VA = "0x1476C84")]
	private void InitEnemyFootStepHintSetting()
	{
	}

	[Token(Token = "0x600C682")]
	[Address(RVA = "0x1476264", Offset = "0x1476264", VA = "0x1476264")]
	private void InitBtnClickDelegete()
	{
	}

	[Token(Token = "0x600C683")]
	[Address(RVA = "0x14769C8", Offset = "0x14769C8", VA = "0x14769C8")]
	private void InitResolutionSetting()
	{
	}

	[Token(Token = "0x600C684")]
	[Address(RVA = "0x1476A84", Offset = "0x1476A84", VA = "0x1476A84")]
	private void InitQualitySetting()
	{
	}

	[Token(Token = "0x600C685")]
	[Address(RVA = "0x1477E28", Offset = "0x1477E28", VA = "0x1477E28")]
	private void OnQualityChange()
	{
	}

	[Token(Token = "0x600C686")]
	[Address(RVA = "0x1478710", Offset = "0x1478710", VA = "0x1478710")]
	private void DisableToggle(GameObject g, bool enable)
	{
	}

	[Token(Token = "0x600C687")]
	[Address(RVA = "0x1478744", Offset = "0x1478744", VA = "0x1478744")]
	private void _003CInitInGameFilterSetting_003Em__0()
	{
	}

	[Token(Token = "0x600C688")]
	[Address(RVA = "0x147874C", Offset = "0x147874C", VA = "0x147874C")]
	private void _003CInitInGameFilterSetting_003Em__1()
	{
	}

	[Token(Token = "0x600C689")]
	[Address(RVA = "0x1478754", Offset = "0x1478754", VA = "0x1478754")]
	private void _003CInitInGameFilterSetting_003Em__2()
	{
	}

	[Token(Token = "0x600C68A")]
	[Address(RVA = "0x147875C", Offset = "0x147875C", VA = "0x147875C")]
	private void _003CInitInGameFilterSetting_003Em__3()
	{
	}

	[Token(Token = "0x600C68B")]
	[Address(RVA = "0x1478764", Offset = "0x1478764", VA = "0x1478764")]
	private static void _003CInitShadowSetting_003Em__4(int selectContent)
	{
	}

	[Token(Token = "0x600C68C")]
	[Address(RVA = "0x14788F8", Offset = "0x14788F8", VA = "0x14788F8")]
	private void _003CInitHightFPSSetting_003Em__5(int selectContent)
	{
	}

	[Token(Token = "0x600C68D")]
	[Address(RVA = "0x1478C90", Offset = "0x1478C90", VA = "0x1478C90")]
	private static void _003CInitEnemyFootStepHintSetting_003Em__6(int selectContent)
	{
	}

	[Token(Token = "0x600C68E")]
	[Address(RVA = "0x1478D14", Offset = "0x1478D14", VA = "0x1478D14")]
	private static void _003CInitHightFPSSetting_003Em__7()
	{
	}

	[Token(Token = "0x600C68F")]
	[Address(RVA = "0x1478D94", Offset = "0x1478D94", VA = "0x1478D94")]
	private void _003CInitHightFPSSetting_003Em__8()
	{
	}
}
