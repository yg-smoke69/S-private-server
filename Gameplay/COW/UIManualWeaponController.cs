using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002993")]
public class UIManualWeaponController : UIManualContentBaseController, _Attribute
{
	[Token(Token = "0x2002994")]
	private sealed class _003CGetMaxPage_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FFFE")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x6010B3C")]
		[Address(RVA = "0x1238BCC", Offset = "0x1238BCC", VA = "0x1238BCC")]
		public _003CGetMaxPage_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6010B3D")]
		[Address(RVA = "0x1238BD4", Offset = "0x1238BD4", VA = "0x1238BD4")]
		internal bool _003C_003Em__0(ManualWeaponData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002995")]
	private sealed class _003CGetDesc_003Ec__AnonStorey1
	{
		[Token(Token = "0x400FFFF")]
		[FieldOffset(Offset = "0x8")]
		internal int page;

		[Token(Token = "0x4010000")]
		[FieldOffset(Offset = "0xC")]
		internal int location;

		[Token(Token = "0x6010B3E")]
		[Address(RVA = "0x1238B68", Offset = "0x1238B68", VA = "0x1238B68")]
		public _003CGetDesc_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6010B3F")]
		[Address(RVA = "0x1238B70", Offset = "0x1238B70", VA = "0x1238B70")]
		internal bool _003C_003Em__0(ManualWeaponData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002996")]
	private sealed class _003COnClickReward_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010001")]
		[FieldOffset(Offset = "0x8")]
		internal ManualWeaponReward status;

		[Token(Token = "0x6010B40")]
		[Address(RVA = "0x1238C14", Offset = "0x1238C14", VA = "0x1238C14")]
		public _003COnClickReward_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6010B41")]
		[Address(RVA = "0x1238C1C", Offset = "0x1238C1C", VA = "0x1238C1C")]
		internal bool _003C_003Em__0(ManualWeaponRewardData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FFEC")]
	[FieldOffset(Offset = "0x3C")]
	private UIManualWeaponData m_UIManualWeaponData;

	[Token(Token = "0x400FFED")]
	[FieldOffset(Offset = "0x40")]
	private UIManualWeaponView m_View;

	[Token(Token = "0x400FFEE")]
	[FieldOffset(Offset = "0x44")]
	private List<ManualWeaponData> m_Weapons;

	[Token(Token = "0x400FFEF")]
	[FieldOffset(Offset = "0x48")]
	private UIManualWeaponItemView[] m_Items;

	[Token(Token = "0x400FFF0")]
	[FieldOffset(Offset = "0x4C")]
	private Transform[] m_ItemParents;

	[Token(Token = "0x400FFF1")]
	[FieldOffset(Offset = "0x50")]
	private UIButton[] m_Badges;

	[Token(Token = "0x400FFF2")]
	[FieldOffset(Offset = "0x54")]
	private ManualWeaponData m_CurSelectData;

	[Token(Token = "0x400FFF3")]
	private const string REWARD_FORMAT = "{0}/{1}";

	[Token(Token = "0x400FFF4")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 m_OriginSize;

	[Token(Token = "0x400FFF5")]
	[FieldOffset(Offset = "0x60")]
	private UIScrollView m_LabelScrollView;

	[Token(Token = "0x400FFF6")]
	[FieldOffset(Offset = "0x64")]
	private GameObject m_LeftArrowTips;

	[Token(Token = "0x400FFF7")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_RightArrowTips;

	[Token(Token = "0x400FFF8")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<CSVBaseData, ManualWeaponData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400FFF9")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<ManualWeaponReward> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400FFFA")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<CSVBaseData, ManualWeaponRewardData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x400FFFB")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<ManualWeaponReward> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x400FFFC")]
	[FieldOffset(Offset = "0x10")]
	private static Predicate<ManualWeaponReward> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x400FFFD")]
	[FieldOffset(Offset = "0x14")]
	private static Predicate<ManualWeaponReward> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x6010B18")]
	[Address(RVA = "0x2C41AF0", Offset = "0x2C41AF0", VA = "0x2C41AF0")]
	public UIManualWeaponController()
	{
	}

	[Token(Token = "0x6010B19")]
	[Address(RVA = "0x2C41AF8", Offset = "0x2C41AF8", VA = "0x2C41AF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B1A")]
	[Address(RVA = "0x2C41B9C", Offset = "0x2C41B9C", VA = "0x2C41B9C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B1B")]
	[Address(RVA = "0x2C42954", Offset = "0x2C42954", VA = "0x2C42954", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010B1C")]
	[Address(RVA = "0x2C42BD4", Offset = "0x2C42BD4", VA = "0x2C42BD4", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6010B1D")]
	[Address(RVA = "0x2C42C90", Offset = "0x2C42C90", VA = "0x2C42C90", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6010B1E")]
	[Address(RVA = "0x2C42D4C", Offset = "0x2C42D4C", VA = "0x2C42D4C", Slot = "31")]
	public override void SetData(UIManualDataBase data)
	{
	}

	[Token(Token = "0x6010B1F")]
	[Address(RVA = "0x2C43420", Offset = "0x2C43420", VA = "0x2C43420", Slot = "32")]
	public override void ClearData()
	{
	}

	[Token(Token = "0x6010B20")]
	[Address(RVA = "0x2C435FC", Offset = "0x2C435FC", VA = "0x2C435FC", Slot = "33")]
	public override void RefreshView()
	{
	}

	[Token(Token = "0x6010B21")]
	[Address(RVA = "0x2C44160", Offset = "0x2C44160", VA = "0x2C44160", Slot = "34")]
	protected override int GetMaxPage()
	{
		return default(int);
	}

	[Token(Token = "0x6010B22")]
	[Address(RVA = "0x2C43A20", Offset = "0x2C43A20", VA = "0x2C43A20")]
	private void SetItems(int page, bool doDefaultSelect = true)
	{
	}

	[Token(Token = "0x6010B23")]
	[Address(RVA = "0x2C44650", Offset = "0x2C44650", VA = "0x2C44650")]
	public void OnSelectItem(ManualWeaponData data)
	{
	}

	[Token(Token = "0x6010B24")]
	[Address(RVA = "0x2C44448", Offset = "0x2C44448", VA = "0x2C44448")]
	public bool HasUnlock(ManualWeaponData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6010B25")]
	[Address(RVA = "0x2C445C4", Offset = "0x2C445C4", VA = "0x2C445C4")]
	public bool IsSelect(ManualWeaponData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6010B26")]
	[Address(RVA = "0x2C44EF4", Offset = "0x2C44EF4", VA = "0x2C44EF4")]
	public void OnClickMore()
	{
	}

	[Token(Token = "0x6010B27")]
	[Address(RVA = "0x2C442D0", Offset = "0x2C442D0", VA = "0x2C442D0")]
	public ManualWeaponData GetDesc(uint tabId, int page, int location)
	{
		return null;
	}

	[Token(Token = "0x6010B28")]
	[Address(RVA = "0x2C44F6C", Offset = "0x2C44F6C", VA = "0x2C44F6C")]
	private void OnClickReward()
	{
	}

	[Token(Token = "0x6010B29")]
	[Address(RVA = "0x2C45954", Offset = "0x2C45954", VA = "0x2C45954")]
	private uint GetCurPeriodNumber()
	{
		return default(uint);
	}

	[Token(Token = "0x6010B2A")]
	[Address(RVA = "0x2C459C4", Offset = "0x2C459C4", VA = "0x2C459C4")]
	private ManualWeaponReward GetCurPeriodWeaponStatus()
	{
		return null;
	}

	[Token(Token = "0x6010B2B")]
	[Address(RVA = "0x2C43040", Offset = "0x2C43040", VA = "0x2C43040")]
	private void UpdateRewardView(object[] parameters)
	{
	}

	[Token(Token = "0x6010B2C")]
	[Address(RVA = "0x2C45CCC", Offset = "0x2C45CCC", VA = "0x2C45CCC", Slot = "35")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6010B2D")]
	[Address(RVA = "0x2C4602C", Offset = "0x2C4602C", VA = "0x2C4602C")]
	private static ManualWeaponData _003CSetData_003Em__0(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x6010B2E")]
	[Address(RVA = "0x2C460C0", Offset = "0x2C460C0", VA = "0x2C460C0")]
	private bool _003CSetData_003Em__1(ManualWeaponData temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010B2F")]
	[Address(RVA = "0x2C4610C", Offset = "0x2C4610C", VA = "0x2C4610C")]
	private static bool _003COnClickReward_003Em__2(ManualWeaponReward temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010B30")]
	[Address(RVA = "0x2C4613C", Offset = "0x2C4613C", VA = "0x2C4613C")]
	private static ManualWeaponRewardData _003COnClickReward_003Em__3(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x6010B31")]
	[Address(RVA = "0x2C461D0", Offset = "0x2C461D0", VA = "0x2C461D0")]
	private static bool _003CGetCurPeriodWeaponStatus_003Em__4(ManualWeaponReward temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010B32")]
	[Address(RVA = "0x2C461FC", Offset = "0x2C461FC", VA = "0x2C461FC")]
	private static bool _003CGetCurPeriodWeaponStatus_003Em__5(ManualWeaponReward temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010B33")]
	[Address(RVA = "0x2C4622C", Offset = "0x2C4622C", VA = "0x2C4622C")]
	private static bool _003CUpdateRewardView_003Em__6(ManualWeaponReward temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6010B34")]
	[Address(RVA = "0x2C4625C", Offset = "0x2C4625C", VA = "0x2C4625C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010B35")]
	[Address(RVA = "0x2C46264", Offset = "0x2C46264", VA = "0x2C46264")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6010B36")]
	[Address(RVA = "0x2C4626C", Offset = "0x2C4626C", VA = "0x2C4626C")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6010B37")]
	[Address(RVA = "0x2C46274", Offset = "0x2C46274", VA = "0x2C46274")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6010B38")]
	[Address(RVA = "0x2C4627C", Offset = "0x2C4627C", VA = "0x2C4627C")]
	public void _003C_003EiFixBaseProxy_SetData(UIManualDataBase P0)
	{
	}

	[Token(Token = "0x6010B39")]
	[Address(RVA = "0x2C46284", Offset = "0x2C46284", VA = "0x2C46284")]
	public void _003C_003EiFixBaseProxy_ClearData()
	{
	}

	[Token(Token = "0x6010B3A")]
	[Address(RVA = "0x2C4628C", Offset = "0x2C4628C", VA = "0x2C4628C")]
	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}

	[Token(Token = "0x6010B3B")]
	[Address(RVA = "0x2C46294", Offset = "0x2C46294", VA = "0x2C46294")]
	public int _003C_003EiFixBaseProxy_GetMaxPage()
	{
		return default(int);
	}
}
