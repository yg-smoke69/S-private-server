using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020CA")]
public class UIEPChallengeTaskController : UIBaseController, _Attribute
{
	[Token(Token = "0x20020CB")]
	private sealed class _003CCoResetScrollView_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CD4A")]
		[FieldOffset(Offset = "0x8")]
		internal UIEPChallengeTaskController _0024this;

		[Token(Token = "0x400CD4B")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400CD4C")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400CD4D")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000FE4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600A983")]
			[Address(RVA = "0x2BA0190", Offset = "0x2BA0190", VA = "0x2BA0190", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FE5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600A984")]
			[Address(RVA = "0x2BA0198", Offset = "0x2BA0198", VA = "0x2BA0198", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600A981")]
		[Address(RVA = "0x2B9FDD8", Offset = "0x2B9FDD8", VA = "0x2B9FDD8")]
		public _003CCoResetScrollView_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600A982")]
		[Address(RVA = "0x2BA00BC", Offset = "0x2BA00BC", VA = "0x2BA00BC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600A985")]
		[Address(RVA = "0x2BA01A0", Offset = "0x2BA01A0", VA = "0x2BA01A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600A986")]
		[Address(RVA = "0x2BA01B4", Offset = "0x2BA01B4", VA = "0x2BA01B4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CD49")]
	[FieldOffset(Offset = "0x28")]
	private UIEPChallengeTaskView m_View;

	[Token(Token = "0x600A974")]
	[Address(RVA = "0x2B9F558", Offset = "0x2B9F558", VA = "0x2B9F558")]
	public UIEPChallengeTaskController()
	{
	}

	[Token(Token = "0x600A975")]
	[Address(RVA = "0x2B9F5DC", Offset = "0x2B9F5DC", VA = "0x2B9F5DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A976")]
	[Address(RVA = "0x2B9F680", Offset = "0x2B9F680", VA = "0x2B9F680", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A977")]
	[Address(RVA = "0x2B9F874", Offset = "0x2B9F874", VA = "0x2B9F874", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A978")]
	[Address(RVA = "0x2B9F9A8", Offset = "0x2B9F9A8", VA = "0x2B9F9A8")]
	private void OnQuestUpdate(object[] data)
	{
	}

	[Token(Token = "0x600A979")]
	[Address(RVA = "0x2B9F814", Offset = "0x2B9F814", VA = "0x2B9F814")]
	private void InitData()
	{
	}

	[Token(Token = "0x600A97A")]
	[Address(RVA = "0x2B9FA88", Offset = "0x2B9FA88", VA = "0x2B9FA88")]
	private void RefreshEasyList()
	{
	}

	[Token(Token = "0x600A97B")]
	[Address(RVA = "0x2B9FD0C", Offset = "0x2B9FD0C", VA = "0x2B9FD0C")]
	private IEnumerator CoResetScrollView()
	{
		return null;
	}

	[Token(Token = "0x600A97C")]
	[Address(RVA = "0x2B9FDE0", Offset = "0x2B9FDE0", VA = "0x2B9FDE0")]
	private int SortTaskList(EPMonthlyQuestInfo x, EPMonthlyQuestInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x600A97D")]
	[Address(RVA = "0x2B9FF38", Offset = "0x2B9FF38", VA = "0x2B9FF38", Slot = "31")]
	private UIEasyListItemController GCommon_002EIEasyList_002EOpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600A97E")]
	[Address(RVA = "0x2BA0030", Offset = "0x2BA0030", VA = "0x2BA0030", Slot = "32")]
	private void GCommon_002EIEasyList_002ECloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600A97F")]
	[Address(RVA = "0x2BA00AC", Offset = "0x2BA00AC", VA = "0x2BA00AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A980")]
	[Address(RVA = "0x2BA00B4", Offset = "0x2BA00B4", VA = "0x2BA00B4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
