using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B61")]
public class UITaskController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x2002B62")]
	public enum TaskTab
	{
		[Token(Token = "0x40109E5")]
		None,
		[Token(Token = "0x40109E6")]
		ElitePass,
		[Token(Token = "0x40109E7")]
		DailySignin
	}

	[Token(Token = "0x2002B63")]
	public class TaskData
	{
		[Token(Token = "0x40109E8")]
		[FieldOffset(Offset = "0x8")]
		public TaskTab m_TaskTab;

		[Token(Token = "0x40109E9")]
		[FieldOffset(Offset = "0xC")]
		public string m_Title;

		[Token(Token = "0x40109EA")]
		[FieldOffset(Offset = "0x10")]
		public ETipsType m_RedDot;

		[Token(Token = "0x40109EB")]
		[FieldOffset(Offset = "0x14")]
		public Func<UIBaseController> m_OnSelect;

		[Token(Token = "0x40109EC")]
		[FieldOffset(Offset = "0x18")]
		public bool hasRedDot;

		[Token(Token = "0x6011E0C")]
		[Address(RVA = "0x20173A0", Offset = "0x20173A0", VA = "0x20173A0")]
		public TaskData()
		{
		}
	}

	[Token(Token = "0x2002B64")]
	private sealed class _003CCreateTabs_003Ec__AnonStorey0
	{
		[Token(Token = "0x40109ED")]
		[FieldOffset(Offset = "0x8")]
		internal TaskData data;

		[Token(Token = "0x40109EE")]
		[FieldOffset(Offset = "0xC")]
		internal UITaskController _0024this;

		[Token(Token = "0x6011E0D")]
		[Address(RVA = "0x2017AA4", Offset = "0x2017AA4", VA = "0x2017AA4")]
		public _003CCreateTabs_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6011E0E")]
		[Address(RVA = "0x2018CC8", Offset = "0x2018CC8", VA = "0x2018CC8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x2002B65")]
	private sealed class _003CGotoTab_003Ec__AnonStorey1
	{
		[Token(Token = "0x40109EF")]
		[FieldOffset(Offset = "0x8")]
		internal TaskTab tab;

		[Token(Token = "0x40109F0")]
		[FieldOffset(Offset = "0xC")]
		internal TaskData data;

		[Token(Token = "0x6011E0F")]
		[Address(RVA = "0x2017CD4", Offset = "0x2017CD4", VA = "0x2017CD4")]
		public _003CGotoTab_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6011E10")]
		[Address(RVA = "0x2018D0C", Offset = "0x2018D0C", VA = "0x2018D0C")]
		internal bool _003C_003Em__0(TaskData x)
		{
			return default(bool);
		}

		[Token(Token = "0x6011E11")]
		[Address(RVA = "0x2018D44", Offset = "0x2018D44", VA = "0x2018D44")]
		internal bool _003C_003Em__1(StandardTopTabItemViewData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002B66")]
	private sealed class _003COnSelectTab_003Ec__AnonStorey2
	{
		[Token(Token = "0x40109F1")]
		[FieldOffset(Offset = "0x8")]
		internal TaskTab tab;

		[Token(Token = "0x6011E12")]
		[Address(RVA = "0x20181DC", Offset = "0x20181DC", VA = "0x20181DC")]
		public _003COnSelectTab_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6011E13")]
		[Address(RVA = "0x2018DFC", Offset = "0x2018DFC", VA = "0x2018DFC")]
		internal bool _003C_003Em__0(TaskData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40109D1")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x40109D2")]
	[FieldOffset(Offset = "0x80")]
	private UIModelAnnouncement m_ModelAnnouncement;

	[Token(Token = "0x40109D3")]
	[FieldOffset(Offset = "0x84")]
	private UIModelElitePass m_ModelEP;

	[Token(Token = "0x40109D4")]
	[FieldOffset(Offset = "0x88")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x40109D5")]
	[FieldOffset(Offset = "0x8C")]
	private UITaskView m_View;

	[Token(Token = "0x40109D6")]
	[FieldOffset(Offset = "0x90")]
	private List<TaskData> m_TaskDatas;

	[Token(Token = "0x40109D7")]
	[FieldOffset(Offset = "0x94")]
	private Dictionary<int, UIBaseController> m_CtrlDict;

	[Token(Token = "0x40109D8")]
	[FieldOffset(Offset = "0x98")]
	private List<StandardTopTabItemViewData> m_TabDataList;

	[Token(Token = "0x40109D9")]
	[FieldOffset(Offset = "0x9C")]
	private UIStandardTopTabController m_TabCtrl;

	[Token(Token = "0x40109DA")]
	[FieldOffset(Offset = "0xA0")]
	private int m_CurShowEPMaxRewardIndex;

	[Token(Token = "0x40109DB")]
	[FieldOffset(Offset = "0xA4")]
	private int m_CurShowFPMaxRewardIndex;

	[Token(Token = "0x40109DC")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_CurShowEPMaxRewardId;

	[Token(Token = "0x40109DD")]
	[FieldOffset(Offset = "0xAC")]
	private EInventory.AwardType m_CurShowEPMaxRewardType;

	[Token(Token = "0x40109DE")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_CurShowFPMaxRewardId;

	[Token(Token = "0x40109DF")]
	[FieldOffset(Offset = "0xB4")]
	private EInventory.AwardType m_CurShowFPMaxRewardType;

	[Token(Token = "0x40109E0")]
	[FieldOffset(Offset = "0xB8")]
	public bool ForceHidePreview;

	[Token(Token = "0x40109E1")]
	[FieldOffset(Offset = "0xBC")]
	private TaskTab _003CCurTab_003Ek__BackingField;

	[Token(Token = "0x40109E2")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40109E3")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<TaskData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x170012E4")]
	public int CurShowMaxRewardIndex
	{
		[Token(Token = "0x6011DF1")]
		[Address(RVA = "0x20166A8", Offset = "0x20166A8", VA = "0x20166A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170012E5")]
	public TaskTab CurTab
	{
		[Token(Token = "0x6011DF2")]
		[Address(RVA = "0x201672C", Offset = "0x201672C", VA = "0x201672C")]
		get
		{
			return default(TaskTab);
		}
		[Token(Token = "0x6011DF3")]
		[Address(RVA = "0x2016734", Offset = "0x2016734", VA = "0x2016734")]
		set
		{
		}
	}

	[Token(Token = "0x6011DF0")]
	[Address(RVA = "0x20165A8", Offset = "0x20165A8", VA = "0x20165A8")]
	public UITaskController()
	{
	}

	[Token(Token = "0x6011DF4")]
	[Address(RVA = "0x201673C", Offset = "0x201673C", VA = "0x201673C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011DF5")]
	[Address(RVA = "0x20167E0", Offset = "0x20167E0", VA = "0x20167E0", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6011DF6")]
	[Address(RVA = "0x2016838", Offset = "0x2016838", VA = "0x2016838", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6011DF7")]
	[Address(RVA = "0x20168A8", Offset = "0x20168A8", VA = "0x20168A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011DF8")]
	[Address(RVA = "0x201784C", Offset = "0x201784C", VA = "0x201784C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011DF9")]
	[Address(RVA = "0x20178EC", Offset = "0x20178EC", VA = "0x20178EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011DFA")]
	[Address(RVA = "0x2017998", Offset = "0x2017998", VA = "0x2017998")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6011DFB")]
	[Address(RVA = "0x20173A8", Offset = "0x20173A8", VA = "0x20173A8")]
	private void CreateTabs(TaskData data)
	{
	}

	[Token(Token = "0x6011DFC")]
	[Address(RVA = "0x2017AAC", Offset = "0x2017AAC", VA = "0x2017AAC")]
	public void GotoTab(TaskTab tab)
	{
	}

	[Token(Token = "0x6011DFD")]
	[Address(RVA = "0x2017CDC", Offset = "0x2017CDC", VA = "0x2017CDC")]
	private void OnSelectTab(TaskTab tab)
	{
	}

	[Token(Token = "0x6011DFE")]
	[Address(RVA = "0x20181E4", Offset = "0x20181E4", VA = "0x20181E4")]
	public int GetTopTabDepth()
	{
		return default(int);
	}

	[Token(Token = "0x6011DFF")]
	[Address(RVA = "0x20182E0", Offset = "0x20182E0", VA = "0x20182E0", Slot = "64")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011E00")]
	[Address(RVA = "0x20183DC", Offset = "0x20183DC", VA = "0x20183DC", Slot = "65")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011E01")]
	[Address(RVA = "0x2018470", Offset = "0x2018470", VA = "0x2018470", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6011E02")]
	[Address(RVA = "0x20186B0", Offset = "0x20186B0", VA = "0x20186B0")]
	public void SetChallengeMaxReward()
	{
	}

	[Token(Token = "0x6011E03")]
	[Address(RVA = "0x201859C", Offset = "0x201859C", VA = "0x201859C")]
	public void ShowChallengeMaxRewardView(bool isShow, bool showDesc = true)
	{
	}

	[Token(Token = "0x6011E04")]
	[Address(RVA = "0x2018A08", Offset = "0x2018A08", VA = "0x2018A08")]
	private UIBaseController _003COnUIInit_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x6011E05")]
	[Address(RVA = "0x2018AE4", Offset = "0x2018AE4", VA = "0x2018AE4")]
	private UIBaseController _003COnUIInit_003Em__1()
	{
		return null;
	}

	[Token(Token = "0x6011E06")]
	[Address(RVA = "0x2018BC0", Offset = "0x2018BC0", VA = "0x2018BC0")]
	private static void _003COnUIInit_003Em__2()
	{
	}

	[Token(Token = "0x6011E07")]
	[Address(RVA = "0x2018C84", Offset = "0x2018C84", VA = "0x2018C84")]
	private static bool _003COnUIInit_003Em__3(TaskData e)
	{
		return default(bool);
	}

	[Token(Token = "0x6011E08")]
	[Address(RVA = "0x2018CA8", Offset = "0x2018CA8", VA = "0x2018CA8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011E09")]
	[Address(RVA = "0x2018CB0", Offset = "0x2018CB0", VA = "0x2018CB0")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011E0A")]
	[Address(RVA = "0x2018CB8", Offset = "0x2018CB8", VA = "0x2018CB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011E0B")]
	[Address(RVA = "0x2018CC0", Offset = "0x2018CC0", VA = "0x2018CC0")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
