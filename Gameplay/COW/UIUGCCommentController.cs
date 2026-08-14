using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002B92")]
internal class UIUGCCommentController : UIPopupWindowController
{
	[Token(Token = "0x2002B93")]
	private sealed class _003CSetInfoData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010AC5")]
		[FieldOffset(Offset = "0x8")]
		internal List<WorkshopCommentTag> adjusted;

		[Token(Token = "0x6012033")]
		[Address(RVA = "0x2B834A8", Offset = "0x2B834A8", VA = "0x2B834A8")]
		public _003CSetInfoData_003Ec__AnonStorey0()
		{
		}
	}

	[Token(Token = "0x2002B94")]
	private sealed class _003CSetInfoData_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010AC6")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4010AC7")]
		[FieldOffset(Offset = "0xC")]
		internal _003CSetInfoData_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

		[Token(Token = "0x6012034")]
		[Address(RVA = "0x2B834B0", Offset = "0x2B834B0", VA = "0x2B834B0")]
		public _003CSetInfoData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6012035")]
		[Address(RVA = "0x2B85404", Offset = "0x2B85404", VA = "0x2B85404")]
		internal bool _003C_003Em__0(WorkshopCommentConfigData e)
		{
			return default(bool);
		}

		[Token(Token = "0x6012036")]
		[Address(RVA = "0x2B854D4", Offset = "0x2B854D4", VA = "0x2B854D4")]
		internal bool _003C_003Em__1(WorkshopCommentConfigData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002B95")]
	private sealed class _003CRefreshToBeSelectedData_003Ec__AnonStorey2
	{
		[Token(Token = "0x4010AC8")]
		[FieldOffset(Offset = "0x8")]
		internal List<WorkshopCommentConfigData> list;

		[Token(Token = "0x6012037")]
		[Address(RVA = "0x2B83B3C", Offset = "0x2B83B3C", VA = "0x2B83B3C")]
		public _003CRefreshToBeSelectedData_003Ec__AnonStorey2()
		{
		}
	}

	[Token(Token = "0x2002B96")]
	private sealed class _003CRefreshToBeSelectedData_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010AC9")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4010ACA")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRefreshToBeSelectedData_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

		[Token(Token = "0x6012038")]
		[Address(RVA = "0x2B83B44", Offset = "0x2B83B44", VA = "0x2B83B44")]
		public _003CRefreshToBeSelectedData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6012039")]
		[Address(RVA = "0x2B85258", Offset = "0x2B85258", VA = "0x2B85258")]
		internal bool _003C_003Em__0(WorkshopCommentConfigData e)
		{
			return default(bool);
		}

		[Token(Token = "0x601203A")]
		[Address(RVA = "0x2B85328", Offset = "0x2B85328", VA = "0x2B85328")]
		internal bool _003C_003Em__1(WorkshopCommentConfigData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002B97")]
	private sealed class _003COnItemSelected_003Ec__AnonStorey4
	{
		[Token(Token = "0x4010ACB")]
		[FieldOffset(Offset = "0x8")]
		internal WorkshopCommentConfigData config;

		[Token(Token = "0x601203B")]
		[Address(RVA = "0x2B84334", Offset = "0x2B84334", VA = "0x2B84334")]
		public _003COnItemSelected_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x601203C")]
		[Address(RVA = "0x2B8520C", Offset = "0x2B8520C", VA = "0x2B8520C")]
		internal bool _003C_003Em__0(WorkshopCommentConfigData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002B98")]
	private sealed class _003COnItemDeleted_003Ec__AnonStorey5
	{
		[Token(Token = "0x4010ACC")]
		[FieldOffset(Offset = "0x8")]
		internal WorkshopCommentConfigData config;

		[Token(Token = "0x601203D")]
		[Address(RVA = "0x2B84B34", Offset = "0x2B84B34", VA = "0x2B84B34")]
		public _003COnItemDeleted_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601203E")]
		[Address(RVA = "0x2B851C0", Offset = "0x2B851C0", VA = "0x2B851C0")]
		internal bool _003C_003Em__0(WorkshopCommentConfigData e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4010AB9")]
	[FieldOffset(Offset = "0x48")]
	private int m_CommentChoice;

	[Token(Token = "0x4010ABA")]
	[FieldOffset(Offset = "0x4C")]
	private UIUGCCommentView m_View;

	[Token(Token = "0x4010ABB")]
	[FieldOffset(Offset = "0x50")]
	private SceneEditSlotInfo m_Info;

	[Token(Token = "0x4010ABC")]
	[FieldOffset(Offset = "0x54")]
	private List<WorkshopCommentConfigData> m_SelectedCommentData;

	[Token(Token = "0x4010ABD")]
	[FieldOffset(Offset = "0x58")]
	private List<UIUGCCommentItemController> m_CachedSelectedCommentItemList;

	[Token(Token = "0x4010ABE")]
	[FieldOffset(Offset = "0x5C")]
	private List<UIUGCCommentItemController> m_CachedCommentItemList;

	[Token(Token = "0x4010ABF")]
	[FieldOffset(Offset = "0x60")]
	private List<WorkshopCommentConfigData> m_PositiveDataList;

	[Token(Token = "0x4010AC0")]
	[FieldOffset(Offset = "0x64")]
	private List<WorkshopCommentConfigData> m_NegativeDataList;

	[Token(Token = "0x4010AC1")]
	[FieldOffset(Offset = "0x68")]
	private bool m_Positive;

	[Token(Token = "0x4010AC2")]
	[FieldOffset(Offset = "0x6C")]
	private EUGCScene m_Src;

	[Token(Token = "0x4010AC3")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<WorkshopCommentTag> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4010AC4")]
	[FieldOffset(Offset = "0x4")]
	private static Func<WorkshopCommentConfigData, uint> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6012023")]
	[Address(RVA = "0x2B82318", Offset = "0x2B82318", VA = "0x2B82318")]
	public UIUGCCommentController()
	{
	}

	[Token(Token = "0x6012024")]
	[Address(RVA = "0x2B82428", Offset = "0x2B82428", VA = "0x2B82428")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012025")]
	[Address(RVA = "0x2B824D0", Offset = "0x2B824D0", VA = "0x2B824D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012026")]
	[Address(RVA = "0x2B82C74", Offset = "0x2B82C74", VA = "0x2B82C74")]
	public void SetInfoData(SceneEditSlotInfo info, EUGCScene src)
	{
	}

	[Token(Token = "0x6012027")]
	[Address(RVA = "0x2B829C8", Offset = "0x2B829C8", VA = "0x2B829C8")]
	private void InitSelected()
	{
	}

	[Token(Token = "0x6012028")]
	[Address(RVA = "0x2B834B8", Offset = "0x2B834B8", VA = "0x2B834B8")]
	private void OnPositiveClick()
	{
	}

	[Token(Token = "0x6012029")]
	[Address(RVA = "0x2B83AD0", Offset = "0x2B83AD0", VA = "0x2B83AD0")]
	private void OnNegativeClick()
	{
	}

	[Token(Token = "0x601202A")]
	[Address(RVA = "0x2B83524", Offset = "0x2B83524", VA = "0x2B83524")]
	private void RefreshToBeSelectedData(List<WorkshopCommentConfigData> list)
	{
	}

	[Token(Token = "0x601202B")]
	[Address(RVA = "0x2B83E20", Offset = "0x2B83E20", VA = "0x2B83E20")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x601202C")]
	[Address(RVA = "0x2B8469C", Offset = "0x2B8469C", VA = "0x2B8469C")]
	private void OnItemDeleted(object[] data)
	{
	}

	[Token(Token = "0x601202D")]
	[Address(RVA = "0x2B8433C", Offset = "0x2B8433C", VA = "0x2B8433C")]
	private void RefreshSelectedData(List<WorkshopCommentConfigData> list)
	{
	}

	[Token(Token = "0x601202E")]
	[Address(RVA = "0x2B82B68", Offset = "0x2B82B68", VA = "0x2B82B68")]
	private void RefreshBtn()
	{
	}

	[Token(Token = "0x601202F")]
	[Address(RVA = "0x2B84DA4", Offset = "0x2B84DA4", VA = "0x2B84DA4")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x6012030")]
	[Address(RVA = "0x2B85030", Offset = "0x2B85030", VA = "0x2B85030")]
	private static int _003CSetInfoData_003Em__0(WorkshopCommentTag a, WorkshopCommentTag b)
	{
		return default(int);
	}

	[Token(Token = "0x6012031")]
	[Address(RVA = "0x2B85194", Offset = "0x2B85194", VA = "0x2B85194")]
	private static uint _003COnBtnConfirmClick_003Em__1(WorkshopCommentConfigData e)
	{
		return default(uint);
	}

	[Token(Token = "0x6012032")]
	[Address(RVA = "0x2B851B8", Offset = "0x2B851B8", VA = "0x2B851B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
